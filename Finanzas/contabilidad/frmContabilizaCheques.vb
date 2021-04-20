Public Class frmContabilizaCheques

    Private Sub frmContabilizaCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.PagosConChequeTableAdapter.Fill(Me.DsContabilidad.PagosConCheque, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub PagosConChequeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PagosConChequeDataGridView.CellContentClick
        If e.ColumnIndex = 1 And PagosConChequeDataGridView.Item("estatusReemb", e.RowIndex).Value.ToString = "" Then 'estatusReemb
            Dim mdiContabilizaCheques As New frmDetallePagCheques
            Dim mdiSolicitudesPago As New mdicuentasPorPagar
            Me.Enabled = False
            mdiSolicitudesPago = MdiParent
            mdiContabilizaCheques.MdiParent = mdiSolicitudesPago
            Me.Cursor = Cursors.WaitCursor
            mdiContabilizaCheques.folioSolicitud = PagosConChequeDataGridView.Item("folioSolicitud", e.RowIndex).Value
            mdiContabilizaCheques.tipoSolicitud = PagosConChequeDataGridView.Item("tipoSolicitud", e.RowIndex).Value
            mdiContabilizaCheques.importeCheque = PagosConChequeDataGridView.Item("importe", e.RowIndex).Value
            mdiContabilizaCheques.idConcepto = PagosConChequeDataGridView.Item("idConcepto", e.RowIndex).Value
            mdiContabilizaCheques.idProveedor = PagosConChequeDataGridView.Item("idProveedor", e.RowIndex).Value
            mdiContabilizaCheques.nombre = PagosConChequeDataGridView.Item("nombre", e.RowIndex).Value
            mdiContabilizaCheques.Show()

            Me.Cursor = Cursors.Default
        ElseIf e.ColumnIndex = 1 And PagosConChequeDataGridView.Item("estatusReemb", e.RowIndex).Value <> String.Empty Then 'estatusReemb
            MsgBox("El cheque ya fue contabilizado...", MsgBoxStyle.Information, "")
        End If
    End Sub


End Class