Public Class frmContabilizaComprobaciones
    Private Sub frmContabilizaComprobaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Vw_CXP_MisComprobacionesTableAdapter.Fill(Me.DsContabilidad.Vw_CXP_MisComprobaciones, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class