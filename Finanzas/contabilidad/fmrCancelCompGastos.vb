Public Class fmrCancelCompGastos

    Dim taEmpresa As New dsProductionTableAdapters.CXP_EmpresasTableAdapter

    Private Sub fmrCancelCompGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualiza()
    End Sub

    Private Sub VW_SaldoComprobacionesDeGastosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VW_SaldoComprobacionesDeGastosDataGridView.CellContentClick
        Dim taPagos As New dsProductionTableAdapters.CXP_ComprobGtosTableAdapter
        Dim result As DialogResult
        Try
            If e.ColumnIndex = 0 Then
                result = MsgBox("¿Desea cancelar el saldo pendiente de comprobar?" & vbNewLine & "Solicitud: " & VW_SaldoComprobacionesDeGastosDataGridView.Item(e.ColumnIndex, e.RowIndex).Value & vbNewLine & "Saldo: " & FormatCurrency(VW_SaldoComprobacionesDeGastosDataGridView.Item("saldo", e.RowIndex).Value), MsgBoxStyle.YesNo, "")
                If result = MsgBoxResult.Yes Then
                    taPagos.Insert(0, VW_SaldoComprobacionesDeGastosDataGridView.Item(e.ColumnIndex, e.RowIndex).Value, varGlobal_IdEmpresa, "XXXXXXXX-XXXX-XXXX-XXXX-CANCELADOGTS", VW_SaldoComprobacionesDeGastosDataGridView.Item("saldo", e.RowIndex).Value, 0, "CANCELACION DE SALDO POR " & varGlobal_NombreUsuario, "", "", varGlobal_NombreUsuario, Nothing, Nothing, 0, "", "", "", "", "", "", Date.Now, Nothing, Nothing)
                    MsgBox("Saldo cancelado correctamente", MsgBoxStyle.Information, "")
                Else
                    MsgBox("Proceso cancelado", MsgBoxStyle.Information, "")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
        actualiza()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Sub actualiza()
        Try
            Me.VW_SaldoComprobacionesDeGastosTableAdapter.Fill(Me.DsContabilidad.VW_SaldoComprobacionesDeGastos, New System.Nullable(Of Decimal)(CType(taEmpresa.ObtConceptoGts_ScalarQuery(varGlobal_IdEmpresa), Decimal)))
            VW_SaldoComprobacionesDeGastosBindingSource.Filter = "saldoSolicitud > 0"
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class