Public Class frmGeneraPdfExpedienteView
    Public var_proveedor As String = ""
    Public var_autorizante As String = ""
    Public var_documento As String = ""
    Private Sub frmGeneraPdfExpedienteView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptGeneraPdf As New rptPdfDocumentacion

        rptGeneraPdf.SetParameterValue("var_proveedor", var_proveedor)
        rptGeneraPdf.SetParameterValue("var_autorizante", var_autorizante)
        rptGeneraPdf.SetParameterValue("var_documento", var_documento)

        crvGeneraPdf.ReportSource = rptGeneraPdf
        Refresh()

    End Sub
End Class