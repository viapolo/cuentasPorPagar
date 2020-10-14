Public Class frmFacturasPendientes
    Private Sub frmFacturasPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsContabilidad.vw_CXP_XmlCfdi2_grpUuid' Puede moverla o quitarla según sea necesario.
        dtpFechaInicio.Value = Date.Now.AddDays(-Now.Day + 1)


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.Vw_CXP_XmlCfdi2_grpUuidTableAdapter.FacturasNoPagadas_FillBy(Me.DsContabilidad.vw_CXP_XmlCfdi2_grpUuid, varGlobal_rfcEmpresa, dtpFechaInicio.Value.ToString("MM/dd/yyyy"), dtpFechaFin.Value.ToString("MM/dd/yyyy"))
    End Sub

    Private Sub Vw_CXP_XmlCfdi2_grpUuidDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vw_CXP_XmlCfdi2_grpUuidDataGridView.CellContentClick
        If e.ColumnIndex = 4 Then
            Dim mdiFrmFacturasPendientesDet As New frmFacturasPendientesDet
            Dim mdiFacturasPendientes As New mdicuentasPorPagar
            Me.Enabled = False
            mdiFacturasPendientes = MdiParent
            mdiFrmFacturasPendientesDet.MdiParent = mdiFacturasPendientes
            Me.Cursor = Cursors.WaitCursor
            mdiFrmFacturasPendientesDet.uuid = Vw_CXP_XmlCfdi2_grpUuidDataGridView.Item("uuid", e.RowIndex).Value
            mdiFrmFacturasPendientesDet.serie = Vw_CXP_XmlCfdi2_grpUuidDataGridView.Item("serie", e.RowIndex).Value
            mdiFrmFacturasPendientesDet.folio = Vw_CXP_XmlCfdi2_grpUuidDataGridView.Item("folio", e.RowIndex).Value
            mdiFrmFacturasPendientesDet.rfc = Vw_CXP_XmlCfdi2_grpUuidDataGridView.Item("rfc", e.RowIndex).Value
            mdiFrmFacturasPendientesDet.rSocial = Vw_CXP_XmlCfdi2_grpUuidDataGridView.Item("rSocial", e.RowIndex).Value
            mdiFrmFacturasPendientesDet.Show()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class