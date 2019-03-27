Public Class frmSATImpuestos
    Private Sub CXP_ImpuestoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_ImpuestoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_ImpuestoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmSATImpuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_CuentasContables' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasContablesTableAdapter.Fill(Me.DsProduction.CXP_CuentasContables)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Impuesto' Puede moverla o quitarla según sea necesario.
        Me.CXP_ImpuestoTableAdapter.Fill(Me.DsProduction.CXP_Impuesto)

    End Sub

    Private Sub cmbDescripcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDescripcion.SelectedIndexChanged
        If cmbDescripcion.Text = "ISR" Then
            ImpuestoTextBox.Text = "001"
        ElseIf cmbDescripcion.Text = "IVA" Then
            ImpuestoTextBox.Text = "002"
        ElseIf cmbDescripcion.Text = "IEPS" Then
            ImpuestoTextBox.Text = "003"
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbEfecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEfecto.SelectedIndexChanged
        If cmbEfecto.Text = "TRA" And cmbDescripcion.Text = "ISR" Then
            MsgBox("El impuesto ISR no puede ser trasladado", MsgBoxStyle.Information)
            cmbEfecto.Text = "RET"
        End If
    End Sub

    Private Sub cmbEfecto_LostFocus(sender As Object, e As EventArgs) Handles cmbEfecto.LostFocus
        If cmbEfecto.Text = "TRA" And cmbDescripcion.Text = "ISR" Then
            MsgBox("El impuesto ISR no puede ser trasladado", MsgBoxStyle.Information)
            cmbEfecto.Text = "RET"
        End If
    End Sub
End Class