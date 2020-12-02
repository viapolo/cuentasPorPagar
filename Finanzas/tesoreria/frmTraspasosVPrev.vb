Public Class frmTraspasosVPrev
    Public nombreBancoOrdenante As String
    Public nombreBancoBeneficiario As String
    Public importe As String
    Public moneda As String
    Public tipoCambio As String
    Public descripcion As String
    Public folioTraspaso As String


    Private Sub frmTraspasosVPrev_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptGeneraPdf As New rptVistPreviaTraspaso

        rptGeneraPdf.SetParameterValue("var_nombreEmpresa", varGlobal_Empresa)
        rptGeneraPdf.SetParameterValue("var_nombreBancoOrdenante", nombreBancoOrdenante)
        rptGeneraPdf.SetParameterValue("var_nombreBancoBeneficiario", nombreBancoBeneficiario)

        rptGeneraPdf.SetParameterValue("var_importe", importe)
        rptGeneraPdf.SetParameterValue("var_moneda", moneda)
        rptGeneraPdf.SetParameterValue("var_tipoCambio", tipoCambio)
        rptGeneraPdf.SetParameterValue("var_descripcion", descripcion)
        rptGeneraPdf.SetParameterValue("var_folioTras", folioTraspaso)

        rptGeneraPdf.SetParameterValue("var_usuario", varGlobal_NombreUsuario)
        rptGeneraPdf.SetParameterValue("var_fecha", Date.Now)


        CrystalReportViewer1.ReportSource = rptGeneraPdf
        Refresh()

    End Sub

    Private Sub frmTraspasosVPrev_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmTraspasos.Enabled = True
    End Sub

    Private Sub frmTraspasosVPrev_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmTraspasos.Enabled = True
    End Sub
End Class