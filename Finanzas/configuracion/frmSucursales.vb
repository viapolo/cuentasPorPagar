Public Class frmSucursales
    Private Sub CXP_SucursalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CXP_SucursalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Sucursales' Puede moverla o quitarla según sea necesario.
        Me.CXP_SucursalesTableAdapter.Fill(Me.DsProduction.CXP_Sucursales)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Sucursales' Puede moverla o quitarla según sea necesario.
        Me.CXP_SucursalesTableAdapter.Fill(Me.DsProduction.CXP_Sucursales)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CXP_SucursalesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CXP_SucursalesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_SucursalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub
End Class