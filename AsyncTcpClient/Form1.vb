Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Public Structure Submit
        Dim code As String
        Dim time As String
        Dim user As String
        Dim problem As String
    End Structure

    Private client As TcpClient
    Private Async Sub connectButton_Click(sender As Object, e As EventArgs) Handles connectButton.Click
        If connectButton.Text = "Connect" Then
            client = New TcpClient
            Try
                Await client.ConnectAsync(ip.Text, port.Text)
                connectButton.Text = "Disconnect"
            Catch odex As ObjectDisposedException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                client.Close()
            End Try
            connectButton.Text = "Connect"
        Else
            client.Close()
        End If
    End Sub
    Private Async Sub sendButton_Click(sender As Object, e As EventArgs) Handles sendButton.Click
        If client IsNot Nothing AndAlso client.Connected Then
            Dim stream As NetworkStream = client.GetStream
            Dim res As Submit
            res.code = inputTextBox.Text
            res.time = Date.Now().ToString()
            res.user = "Yts1999"
            res.problem = "Yts1999"
            Dim context = Newtonsoft.Json.JsonConvert.SerializeObject(res).ToString()
            Dim Message As New XProtocol.XMessage(<TextMessage text1=<%= context %>/>)
            Dim buffer() As Byte = message.ToByteArray
            Try
                Await stream.WriteAsync(buffer, 0, buffer.Length)
            Catch ioex As System.IO.IOException
            Catch odex As ObjectDisposedException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            inputTextBox.Clear()
        End If
    End Sub
End Class
