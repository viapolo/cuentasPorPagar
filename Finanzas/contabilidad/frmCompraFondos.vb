Public Class frmCompraFondos

    Private Sub frmCompraFondos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Vw_CXP_AutorizacionesTableAdapter.SolicitudesEspeciales_FillBy(Me.DsContabilidad.Vw_CXP_Autorizaciones, CType(varGlobal_IdEmpresa, Decimal))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class