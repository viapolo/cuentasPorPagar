Public Class frmNotificacionesPago
    Private Sub frmNotificacionesPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsHerramientas.CXP_Proveedores' Puede moverla o quitarla según sea necesario.
        Me.CXP_ProveedoresTableAdapter.NotificaPagos_FillBy(Me.DsHerramientas.CXP_Proveedores)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If IsNumeric(txtBuscar.Text.Trim) Then
            CXPProveedoresBindingSource.Filter = "idProveedor = " & txtBuscar.Text.Trim
        Else
            CXPProveedoresBindingSource.Filter = "rfc LIKE '%" & txtBuscar.Text.Trim & "%' OR razonSocial LIKE '%" & txtBuscar.Text.Trim & "%'"
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.CXPProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsHerramientas)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNotificaProveedores.CellContentClick
        If e.ColumnIndex = 1 Then
            Dim frmNotificaPagos As New frmCorreosNotificacionesPago
            Dim mdiDocumentacion As New mdicuentasPorPagar
            mdiDocumentacion = MdiParent
            frmNotificaPagos.MdiParent = mdiDocumentacion
            Me.Cursor = Cursors.WaitCursor
            frmNotificaPagos.idProveedor = dgvNotificaProveedores.Rows(e.RowIndex).Cells(0).Value
            frmNotificaPagos.Show()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class