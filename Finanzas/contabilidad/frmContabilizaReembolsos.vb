Public Class frmContabilizaReembolsos
    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub frmContabilizaReembolsos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Vw_CXP_MisSolicitudesSCTableAdapter.Fill(Me.DsContabilidad.Vw_CXP_MisSolicitudesSC, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Vw_CXP_MisSolicitudesSCDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vw_CXP_MisSolicitudesSCDataGridView.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim mdiComprobacionesReembolsos As New frmDetalleReembolsos
            Dim mdiSolicitudesPago As New mdicuentasPorPagar
            Me.Enabled = False
            mdiSolicitudesPago = MdiParent
            mdiComprobacionesReembolsos.MdiParent = mdiSolicitudesPago
            Me.Cursor = Cursors.WaitCursor
            mdiComprobacionesReembolsos.idSolicitud = Vw_CXP_MisSolicitudesSCDataGridView.Item("idFolioSolicitud", e.RowIndex).Value
            mdiComprobacionesReembolsos.Show()

            Me.Cursor = Cursors.Default

        End If
    End Sub
End Class