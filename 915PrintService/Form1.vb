Imports System.IO
Imports System.Drawing.Printing

Public Class Form1
    Private PrintPageSettings As New PageSettings
    Private StringToPrint As String
    Private TitleFont As New Font("Arial", 12, FontStyle.Bold)
    Private PrintFont As New Font("Arial", 10)
    Private SubmitTime = New Date().ToString()
    Private SubmitTeam = "YTS1999"
    Private SubmitProblem = "YTS1999"
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim FilePath As String
        OpenFileDialog1.Filter = "Text files (*.txt)|*.txt"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            FilePath = OpenFileDialog1.FileName
            Try
                Dim MyFileStream As New FileStream(FilePath, FileMode.Open)
                RichTextBox1.LoadFile(MyFileStream, RichTextBoxStreamType.PlainText)
                MyFileStream.Close()
                btnPrint.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            PrintDocument1.DefaultPageSettings = PrintPageSettings
            StringToPrint = RichTextBox1.Text
            PrintDialog1.Document = PrintDocument1
            PrintDocument1.Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim numChars As Integer
        Dim numLines As Integer
        Dim stringForPage As String
        Dim strFormat As New StringFormat
        Dim titleRect As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top - 30, e.MarginBounds.Width, e.MarginBounds.Height)
        Dim lineRect As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top - 20, e.MarginBounds.Width, e.MarginBounds.Height)
        Dim rectDraw As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)
        Dim sizeMeasure As New SizeF(e.MarginBounds.Width, e.MarginBounds.Height - PrintFont.GetHeight(e.Graphics))
        strFormat.Trimming = StringTrimming.Word
        e.Graphics.MeasureString(StringToPrint, PrintFont, sizeMeasure, strFormat, numChars, numLines)
        stringForPage = StringToPrint.Substring(0, numChars)
        e.Graphics.DrawString(SubmitTime + "      " + SubmitProblem + "     " + SubmitTeam + vbCrLf, TitleFont, Brushes.Black, titleRect, strFormat)
        e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------" + vbCrLf, TitleFont, Brushes.Black, lineRect, strFormat)
        e.Graphics.DrawString(stringForPage, PrintFont, Brushes.Black, rectDraw, strFormat)
        If numChars < StringToPrint.Length Then
            StringToPrint = StringToPrint.Substring(numChars)
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub
End Class
