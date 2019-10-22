Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Imports AsyncTcpServer.Printer
Public Class Form1
    Friend WithEvents clientBindingSource As New BindingSource
    Private clients As New ConnectedClientCollection
    Private listener As TcpListener
    Private tokenSource As CancellationTokenSource
    Private clientTasks As New List(Of Task)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Server"
        clientBindingSource.DataSource = clients
        clientListBox.DataSource = clientBindingSource
        Dim HostName = System.Net.Dns.GetHostName
        output.DataBindings.Add("Text", clientBindingSource, "Text")
        ListBox1.DataSource = Dns.GetHostEntry(HostName).AddressList
    End Sub
    Private Async Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        If startButton.Text = "Start" Then
            startButton.Text = "Stop"
            tokenSource = New CancellationTokenSource
            listener = New TcpListener(IPAddress.Any, port.Text)
            listener.Start()
            While True
                Try
                    Dim socketClient As TcpClient = Await listener.AcceptTcpClientAsync
                    Dim client As New ConnectedClient(socketClient)
                    clientBindingSource.Add(client)
                    client.Task = ProcessClientAsync(client, tokenSource.Token)
                    clientTasks.Add(client.Task)
                Catch odex As ObjectDisposedException
                    Exit While
                End Try
            End While
            For i As Integer = clients.Count - 1 To 0 Step -1
                clients(i).TcpClient.Close()
            Next
            Await Task.WhenAll(clientTasks)
            tokenSource.Dispose()
            startButton.Text = "Start"
        Else
            tokenSource.Cancel()
            listener.Stop()
        End If
    End Sub

    Private Async Function ProcessClientAsync(client As ConnectedClient, cancel As CancellationToken) As Task
        Try
            Using stream As NetworkStream = client.TcpClient.GetStream
                Dim buffer(client.TcpClient.ReceiveBufferSize - 1) As Byte
                Dim read As Integer = 1
                While read > 0
                    read = Await stream.ReadAsync(buffer, 0, buffer.Length, cancel)
                    client.AppendData(buffer, read)
                    If client.Text.Last = " " Then
                        Dim context As String = System.Text.Encoding.GetEncoding("utf-8").GetString(Convert.FromBase64String(client.Text))
                        Dim jsonResult As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.Linq.JObject.Parse(context)
                        Dim pr = New Printer(
                                             jsonResult.Item("time").ToString, jsonResult.Item("user").ToString,
                                             jsonResult.Item("problem").ToString, jsonResult.Item("code").ToString,
                                             PrintDocument1, PrintDialog1
                                             )
                        pr.Gao()
                        client.Clear()
                    End If


                End While
            End Using
        Catch ocex As OperationCanceledException
        Catch odex As ObjectDisposedException
        Catch ioex As IOException
        Finally
            client.TcpClient.Close()
            clientBindingSource.Remove(client)
            clientTasks.Remove(client.Task)
        End Try
    End Function

    Private Function DoHeavyWork(buffer() As Byte, read As Integer, client As ConnectedClient) As Integer
        Invoke(Sub()
                   client.AppendData(buffer, read)
               End Sub
               )
        System.Threading.Thread.Sleep(500)
        Return 0
    End Function
End Class

