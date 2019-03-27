Public Class frmEmpresas
    Private Sub frmEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_c_Pais' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_PaisTableAdapter.Fill(Me.DsProduction.CXP_c_Pais)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction3.CXP_c_Moneda' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_MonedaTableAdapter.Fill(Me.DsProduction3.CXP_c_Moneda)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction2.CXP_c_Moneda' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_MonedaTableAdapter.Fill(Me.DsProduction2.CXP_c_Moneda)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction2.CXP_c_RegimenFiscal' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_RegimenFiscalTableAdapter.Fill(Me.DsProduction2.CXP_c_RegimenFiscal)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction1.CXP_c_Estado' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_EstadoTableAdapter.Fill(Me.DsProduction1.CXP_c_Estado)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Empresas' Puede moverla o quitarla según sea necesario.
        Me.CXP_EmpresasTableAdapter.Fill(Me.DsProduction.CXP_Empresas)
    End Sub

    Private Sub RazonSocialTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CalleTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RfcLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CXP_SucursalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_SucursalesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CXP_EmpresasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsProduction)
            Me.CXP_EmpresasTableAdapter.Fill(Me.DsProduction.CXP_Empresas)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub RfcTextBox_TextChanged(sender As Object, e As EventArgs) Handles RfcTextBox.TextChanged

    End Sub

    Private Sub RfcTextBox_LostFocus(sender As Object, e As EventArgs) Handles RfcTextBox.LostFocus
        utilerias.validaRfc(RfcTextBox.Text.Trim)
    End Sub
End Class