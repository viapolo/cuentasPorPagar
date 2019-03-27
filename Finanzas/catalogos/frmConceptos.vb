Public Class frmConceptos
    Private Sub CXP_ConceptosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_ConceptosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_ConceptosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmConceptos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction1.CXP_TipoGasto' Puede moverla o quitarla según sea necesario.
        Me.CXP_TipoGastoTableAdapter.Fill(Me.DsProduction1.CXP_TipoGasto)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Impuesto' Puede moverla o quitarla según sea necesario.
        Me.CXP_ImpuestoTableAdapter.Fill(Me.DsProduction.CXP_Impuesto)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_CuentasContables' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasContablesTableAdapter.Fill(Me.DsProduction.CXP_CuentasContables)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Conceptos' Puede moverla o quitarla según sea necesario.
        Me.CXP_ConceptosTableAdapter.Fill(Me.DsProduction.CXP_Conceptos)

    End Sub

    Private Sub ObtCtasEgreso_FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CXP_CuentasContablesTableAdapter.ObtCtasEgreso_FillBy(Me.DsProduction.CXP_CuentasContables)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class