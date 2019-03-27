Public Class frmContTipoDocumentos
    Private Sub CXP_tipoDeDocumentoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_tipoDeDocumentoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_tipoDeDocumentoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmSATTipoDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_tipoDeDocumento' Puede moverla o quitarla según sea necesario.
        Me.CXP_tipoDeDocumentoTableAdapter.Fill(Me.DsProduction.CXP_tipoDeDocumento)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class