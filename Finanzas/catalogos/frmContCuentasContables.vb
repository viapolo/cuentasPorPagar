Public Class frmContCuentasContables
    Private Sub CXP_CuentasContablesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_CuentasContablesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_CuentasContablesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmContCuentasContables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_CuentasContables' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasContablesTableAdapter.Fill(Me.DsProduction.CXP_CuentasContables)

    End Sub

    Private Sub TipoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class