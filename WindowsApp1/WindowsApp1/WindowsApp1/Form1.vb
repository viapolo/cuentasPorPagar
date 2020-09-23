Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser
Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oReader As New iTextSharp.text.pdf.PdfReader("C:\Users\vicente-apolonio\OneDrive - Corporativo La Moderna\Desktop\AVIO 09092020 2.pdf")

        Dim sOut = ""

        For i = 1 To oReader.NumberOfPages
            Dim its As New iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy
            sOut += iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(oReader, 1, its)
        Next

        MessageBox.Show(sOut)
    End Sub
End Class
