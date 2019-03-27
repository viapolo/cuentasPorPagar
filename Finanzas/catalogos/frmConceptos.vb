Public Class frmConceptos
    Private Sub CXP_ConceptosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_ConceptosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_ConceptosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmConceptos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Conceptos' Puede moverla o quitarla según sea necesario.
        Me.CXP_ConceptosTableAdapter.Fill(Me.DsProduction.CXP_Conceptos)

    End Sub
End Class