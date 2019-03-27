Public Class frmContCuentasBancarias
    Private Sub CXP_CuentasBancariasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_CuentasBancariasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_CuentasBancariasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmContCuentasBancarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Bancos' Puede moverla o quitarla según sea necesario.
        Me.CXP_BancosTableAdapter.Fill(Me.DsProduction.CXP_Bancos)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_c_Moneda' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_MonedaTableAdapter.Fill(Me.DsProduction.CXP_c_Moneda)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_CuentasBancarias' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasBancariasTableAdapter.Fill(Me.DsProduction.CXP_CuentasBancarias)

    End Sub

End Class