Public Class frmContabilizaComprobaciones
    Private Sub frmContabilizaComprobaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If obtienePermisosLecturEscritura(varGlobal_ToolStrip) = False Then
        '    habilitaControles(Me, False)
        '    BindingNavigatorAddNewItem.Visible = False
        '    BindingNavigatorDeleteItem.Visible = False
        '    Vw_CXP_MisComprobacionesBindingNavigatorSaveItem.Visible = False
        'End If

        Try
            Me.Vw_CXP_MisComprobacionesTableAdapter.Fill(Me.DsContabilidad.Vw_CXP_MisComprobaciones, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Vw_CXP_MisComprobacionesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vw_CXP_MisComprobacionesDataGridView.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim mdiComprobacionesDetalle As New frmDetalleComprobaciones
            Dim mdiSolicitudesPago As New mdicuentasPorPagar
            Me.Enabled = False
            mdiSolicitudesPago = MdiParent
            mdiComprobacionesDetalle.MdiParent = mdiSolicitudesPago
            Me.Cursor = Cursors.WaitCursor
            mdiComprobacionesDetalle.idComprobacion = Vw_CXP_MisComprobacionesDataGridView.Item("idFolioComprobacion", e.RowIndex).Value
            mdiComprobacionesDetalle.idSolicitud = Vw_CXP_MisComprobacionesDataGridView.Item("idFolioSolicitud", e.RowIndex).Value
            mdiComprobacionesDetalle.impPendiXComprobar = Vw_CXP_MisComprobacionesDataGridView.Item("saldoSolicitud", e.RowIndex).Value
            mdiComprobacionesDetalle.nombreDeudor = Vw_CXP_MisComprobacionesDataGridView.Item("razonSocial", e.RowIndex).Value
            mdiComprobacionesDetalle.Show()

            Me.Cursor = Cursors.Default

        End If
    End Sub

    Private Sub Vw_CXP_MisComprobacionesBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles Vw_CXP_MisComprobacionesBindingNavigator.RefreshItems

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub Vw_CXP_MisComprobacionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Vw_CXP_MisComprobacionesBindingNavigatorSaveItem.Click

    End Sub
End Class