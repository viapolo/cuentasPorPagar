Public Class frmContabilizarNomina
    Private Sub frmContabilizarNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Vw_CXP_ContabilizarNominaTableAdapter.Fill(Me.DsContabilidad.Vw_CXP_ContabilizarNomina, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Vw_CXP_ContabilizarNominaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vw_CXP_ContabilizarNominaDataGridView.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim mdiContabilizaNomina As New frmDetalleNomina
            Dim mdiSolicitudesPago As New mdicuentasPorPagar
            Me.Enabled = False
            mdiSolicitudesPago = MdiParent
            mdiContabilizaNomina.MdiParent = mdiSolicitudesPago
            Me.Cursor = Cursors.WaitCursor
            mdiContabilizaNomina.idSolicitud = Vw_CXP_ContabilizarNominaDataGridView.Item("idFolioSolicitud", e.RowIndex).Value
            mdiContabilizaNomina.Show()

            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class