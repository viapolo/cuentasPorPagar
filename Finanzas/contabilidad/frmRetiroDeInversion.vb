Public Class frmRetiroDeInversion

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmRetiroDeInversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsContabilidad.CXP_Estatus' Puede moverla o quitarla según sea necesario.

        Try
            Me.CXP_CuentasBancariasTableAdapter.Fill(Me.DsContabilidad.CXP_CuentasBancarias, varGlobal_IdEmpresa)
            Me.CXP_InversionesTableAdapter.ObtInversiones_FillBy(Me.DsContabilidad.CXP_Inversiones, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)))

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CXP_InversionesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CXP_InversionesDataGridView.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim mdiRetiroDeInversion As New frmDetalleRetInversiones
            Dim mdiSolicitudesPago As New mdicuentasPorPagar
            Me.Enabled = False
            mdiSolicitudesPago = MdiParent
            mdiRetiroDeInversion.MdiParent = mdiSolicitudesPago
            Me.Cursor = Cursors.WaitCursor
            mdiRetiroDeInversion.idBancoRetiro = CXP_InversionesDataGridView.Item("idBancoOrigen", e.RowIndex).Value
            mdiRetiroDeInversion.monto = CXP_InversionesDataGridView.Item("monto", e.RowIndex).Value
            mdiRetiroDeInversion.tipoFira = CXP_InversionesDataGridView.Item("tipoFira", e.RowIndex).Value
            mdiRetiroDeInversion.idInversion = CXP_InversionesDataGridView.Item("idInversion", e.RowIndex).Value
            mdiRetiroDeInversion.Show()

            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class