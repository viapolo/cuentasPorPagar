Public Class frmBancos
    Private Sub frmBancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptBancos As New rptBancos_1
        Dim taBancos As New dsTesoreriaTableAdapters.Vw_CXP_EstadoCuentaTableAdapter
        Dim dtBancos As DataTable

        dtBancos = New dsTesoreria.Vw_CXP_EstadoCuentaDataTable

        taBancos.Fill(dtBancos)

        rptBancos.SetDataSource(dtBancos)
        crvBancos.ReportSource = rptBancos
        Refresh()
    End Sub
End Class