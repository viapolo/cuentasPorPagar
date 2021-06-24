Public Class frmComprobaAsignaCuenta
    Private Sub frmComprobaAsignaCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If varGlobal_IdEmpresa = "24" Then
                CuentasTableAdapter.Connection.ConnectionString = My.Settings.csContpaqArfin
            Else
                CuentasTableAdapter.Connection.ConnectionString = My.Settings.csContpaqFinagil
            End If
            Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error en conexión...")
        End Try
    End Sub

    Private Sub frmComprobaAsignaCuenta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmDetalleComprobaciones.Enabled = True
    End Sub

    Private Sub frmComprobaAsignaCuenta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmDetalleComprobaciones.Enabled = True
    End Sub
End Class