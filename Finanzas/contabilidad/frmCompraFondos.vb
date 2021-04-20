Public Class frmCompraFondos

    Private Sub frmCompraFondos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Vw_CXP_AutorizacionesTableAdapter.SolicitudesEspeciales_FillBy(Me.DsContabilidad.Vw_CXP_Autorizaciones, CType(varGlobal_IdEmpresa, Decimal))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Vw_CXP_AutorizacionesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vw_CXP_AutorizacionesDataGridView.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim mdiCompraDeFondosDetalle As New frmDetalleCompraFondos
            Dim mdiSolicitudesPago As New mdicuentasPorPagar
            Me.Enabled = False
            mdiSolicitudesPago = MdiParent
            mdiCompraDeFondosDetalle.MdiParent = mdiSolicitudesPago
            Me.Cursor = Cursors.WaitCursor

            mdiCompraDeFondosDetalle.idSolicitud = Vw_CXP_AutorizacionesDataGridView.Item("idFolioSolicitud", e.RowIndex).Value

            mdiCompraDeFondosDetalle.Show()

            Me.Cursor = Cursors.Default

        End If
    End Sub
End Class