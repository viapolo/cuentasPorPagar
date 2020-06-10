Public Class frmDocumentosProveedores


    Private Sub frmDocumentosProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_DocumentacionProv' Puede moverla o quitarla según sea necesario.
        Me.CXP_DocumentacionProvTableAdapter.Fill(Me.DsProduction.CXP_DocumentacionProv)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_DocumentacionProv' Puede moverla o quitarla según sea necesario.
        Me.CXP_DocumentacionProvTableAdapter.Fill(Me.DsProduction.CXP_DocumentacionProv)

    End Sub

    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs) Handles GuardarToolStripButton.Click
        Me.Validate()
        Me.CXPDocumentacionProvBindingSource.EndEdit()
        Me.CXP_DocumentacionProvTableAdapter.Update(Me.DsProduction)
    End Sub
End Class


