Public Class frmEmpresas
    Private Sub CXP_EmpresasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub frmEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Empresas' Puede moverla o quitarla según sea necesario.
        Me.CXP_EmpresasTableAdapter.Fill(Me.DsProduction.CXP_Empresas)
    End Sub

    Private Sub RazonSocialTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CalleTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RfcLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.Validate()
        Me.CXP_EmpresasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)
    End Sub
End Class