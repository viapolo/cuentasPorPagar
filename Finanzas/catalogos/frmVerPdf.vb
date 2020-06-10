Public Class frmVerPdf
    Public rutaPdf As String
    Private Sub frmVerPdf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxAcroPDF1.LoadFile("E:\VS_Proj\WEB_cxp\cxP\TmpFinagil\FilesProv\5e88652f-e252-4995-a66d-6ec8e5aa67d2.pdf")
    End Sub
End Class