Public Class frmContCuentasContables


    Private Sub frmContCuentasContables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If varGlobal_IdEmpresa = "24" Then
            CuentasTableAdapter.Connection.ConnectionString = My.Settings.csContpaqArfin
        Else
            CuentasTableAdapter.Connection.ConnectionString = My.Settings.csContpaqFinagil
        End If
        'TODO: esta línea de código carga datos en la tabla 'Contpaq.Cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)

    End Sub

    Private Sub TipoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CuentasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CuentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contpaq)

    End Sub
End Class