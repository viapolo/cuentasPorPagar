Public Class frmCuentasBanco
    Private Sub CXP_CuentaBancoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_CuentaBancoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_CuentaBancoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsConfiguracion)

    End Sub

    Private Sub frmCuentasBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsConfiguracion.CXP_CuentaBanco' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentaBancoTableAdapter.Fill(Me.DsConfiguracion.CXP_CuentaBanco)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class