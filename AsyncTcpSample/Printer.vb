Imports System.IO
Imports System.Drawing.Printing

Public Class Printer
    Private PrintPageSettings As New PageSettings
    Private TitleFont As New Font("Arial", 12, FontStyle.Bold)
    Private PrintFont As New Font("Arial", 10)

    Private StringToPrint As String
    Public SubmitTime = New Date().ToString()
    Public SubmitTeam = "YTS1999"
    Public SubmitProblem = "YTS1999"

    Friend WithEvents PrintDocument1 As PrintDocument
    Public PrintDialog1 As PrintDialog

    Public Sub New(ByVal time As String, ByVal team As String, ByVal problem As String, ByVal code As String,
                   ByVal doc As PrintDocument, ByVal dia As PrintDialog)
        SubmitProblem = problem
        SubmitTeam = team
        SubmitTime = time
        StringToPrint = code
        PrintDocument1 = doc
        PrintDialog1 = dia
    End Sub
    Public Sub Gao()
        Try
            PrintDocument1.DefaultPageSettings = PrintPageSettings
            PrintDialog1.Document = PrintDocument1
            PrintDocument1.Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
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
