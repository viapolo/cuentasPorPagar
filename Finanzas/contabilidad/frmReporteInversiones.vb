Public Class frmReporteInversiones



    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim rptInv As New rptInversiones
        Dim taReporteInversiones As New dsContabilidadTableAdapters.CXP_InversionesTableAdapter
        Dim dtReporteInversiones As DataTable
        dtReporteInversiones = New dsContabilidad.CXP_InversionesDataTable



        taReporteInversiones.Reporte1_FillBy(dtReporteInversiones, 23, dtpFecha.Value.Month, dtpFecha.Value.Year)
        dtReporteInversiones.WriteXmlSchema("C:\Files\rptInversiones.xml")

        rptInv.SetDataSource(dtReporteInversiones)
        rptInv.Refresh()

        crvInversiones.ReportSource = rptInv
        Refresh()
    End Sub

    Private Sub crvInversiones_Load(sender As Object, e As EventArgs)

    End Sub
End Class