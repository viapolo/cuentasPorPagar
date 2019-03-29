Public Class frmConceptos

    Dim taImpuesto As New dsProductionTableAdapters.CXP_ImpuestoTableAdapter
    Dim taConceptos As New dsProductionTableAdapters.CXP_ConceptosTableAdapter
    Dim arrayImpuestos() As String
    Dim concatImpuestos As String = ""
    Private Sub CXP_ConceptosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_ConceptosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_ConceptosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

        Dim contador As Integer = 0
        For Each rows As DataGridViewRow In dgvImpuestos.Rows
            concatImpuestos = concatImpuestos & dgvImpuestos.Item(0, contador).Value & ","
            contador = contador + 1
        Next
        taConceptos.ActImpuestos_UpdateQuery(concatImpuestos, CXP_ConceptosBindingSource.Current("idConcepto"))
    End Sub

    Private Sub frmConceptos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction1.CXP_CuentasContables' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasContablesTableAdapter.Fill(Me.DsProduction1.CXP_CuentasContables)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_TipoGasto' Puede moverla o quitarla según sea necesario.
        Me.CXP_TipoGastoTableAdapter.Fill(Me.DsProduction.CXP_TipoGasto)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction1.CXP_TipoGasto' Puede moverla o quitarla según sea necesario.
        Me.CXP_TipoGastoTableAdapter.Fill(Me.DsProduction.CXP_TipoGasto)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Impuesto' Puede moverla o quitarla según sea necesario.
        Me.CXP_ImpuestoTableAdapter.Fill(Me.DsProduction.CXP_Impuesto)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_CuentasContables' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasContablesTableAdapter.Fill(Me.DsProduction.CXP_CuentasContables)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Conceptos' Puede moverla o quitarla según sea necesario.
        Me.CXP_ConceptosTableAdapter.Fill(Me.DsProduction.CXP_Conceptos)

        actualiza()
    End Sub

    Private Sub ObtCtasEgreso_FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CXP_CuentasContablesTableAdapter.ObtCtasEgreso_FillBy(Me.DsProduction.CXP_CuentasContables)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim valor As Integer = cmbImpuesto.SelectedValue
        Dim cont As Integer = 0

        For Each rows As DataGridViewRow In dgvImpuestos.Rows
            If dgvImpuestos.Item(0, cont).Value = valor Then
                MsgBox("Ya se encuentra el impuesto actual...", MsgBoxStyle.Critical)
                Exit Sub
            End If
            cont = cont + 1
        Next

        dgvImpuestos.Rows.Add(cmbImpuesto.SelectedValue, cmbImpuesto.Text, taImpuesto.ObtCuenta_ScalarQuery(cmbImpuesto.SelectedValue), "Eliminar")
    End Sub

    Private Sub actualiza()
        If NombreTextBox.Text <> "" Then
            dgvImpuestos.Rows.Clear()
            arrayImpuestos = taConceptos.ObtImpuesto_ScalarQuery(CXP_ConceptosBindingSource.Current("idConcepto")).ToString.Split(",")
            For i As Integer = 0 To arrayImpuestos.Length - 1
                If arrayImpuestos(i) <> "" Then
                    dgvImpuestos.Rows.Add()
                    dgvImpuestos.Item(0, i).Value = arrayImpuestos(i)
                    dgvImpuestos.Item(1, i).Value = taImpuesto.ObtDescri_ScalarQuery(arrayImpuestos(i))
                    dgvImpuestos.Item(2, i).Value = taImpuesto.ObtCuenta_ScalarQuery(arrayImpuestos(i))
                    dgvImpuestos.Item(3, i).Value = "Eliminar"
                End If
            Next
        End If
    End Sub

    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTextBox.TextChanged
        actualiza()
    End Sub

    Private Sub CuentaEgresoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvImpuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImpuestos.CellContentClick
        If e.ColumnIndex = 3 Then
            dgvImpuestos.Rows.Remove(dgvImpuestos.CurrentRow)
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class