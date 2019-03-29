Public Class frmDiariosFe
    Private Sub CXP_DiariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_DiariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_DiariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmDiariosFe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Proveedores' Puede moverla o quitarla según sea necesario.
        Me.CXP_ProveedoresTableAdapter.Fill(Me.DsProduction.CXP_Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Diarios' Puede moverla o quitarla según sea necesario.
        Me.CXP_DiariosTableAdapter.Fill(Me.DsProduction.CXP_Diarios)
        IdUsuarioTextBox.Text = varGlobal_NombreUsuario
    End Sub
End Class