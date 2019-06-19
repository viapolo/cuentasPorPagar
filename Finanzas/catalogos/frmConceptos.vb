Public Class frmConceptos

    Dim taImpuesto As New dsProductionTableAdapters.CXP_ImpuestoTableAdapter
    Dim taConceptos As New dsProductionTableAdapters.CXP_ConceptosTableAdapter
    Dim taImpCon As New dsProductionTableAdapters.Vw_CXP_ImpConTableAdapter
    Dim taImpuestoConcepto As New dsProductionTableAdapters.CXP_ImpConTableAdapter


    Private Sub CXP_ConceptosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_ConceptosBindingNavigatorSaveItem.Click
        CXP_ConceptosBindingSource.Current("idEmpresa") = varGlobal_IdEmpresa
        Me.Validate()
        Me.CXP_ConceptosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)
    End Sub

    Private Sub frmConceptos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_tipoDeDocumento' Puede moverla o quitarla según sea necesario.
        Me.CXP_tipoDeDocumentoTableAdapter.Fill(Me.DsProduction.CXP_tipoDeDocumento, varGlobal_IdEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction2.Vw_CXP_ImpCon' Puede moverla o quitarla según sea necesario.
        'Me.Vw_CXP_ImpConTableAdapter.Fill(Me.DsProduction.Vw_CXP_ImpCon)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_ImpConc' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsProduction1.CXP_CuentasContables' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasContablesTableAdapter.Fill(Me.DsProduction1.CXP_CuentasContables, varGlobal_IdEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_TipoGasto' Puede moverla o quitarla según sea necesario.
        Me.CXP_TipoGastoTableAdapter.Fill(Me.DsProduction.CXP_TipoGasto, varGlobal_IdEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction1.CXP_TipoGasto' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Impuesto' Puede moverla o quitarla según sea necesario.
        Me.CXP_ImpuestoTableAdapter.Fill(Me.DsProduction.CXP_Impuesto, varGlobal_IdEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_CuentasContables' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasContablesTableAdapter.Fill(Me.DsProduction.CXP_CuentasContables, varGlobal_IdEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Conceptos' Puede moverla o quitarla según sea necesario.
        Me.CXP_ConceptosTableAdapter.Fill(Me.DsProduction.CXP_Conceptos, varGlobal_IdEmpresa)


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
            If dgvImpuestos.Item(4, cont).Value = valor Then
                MsgBox("Ya se encuentra el impuesto actual...", MsgBoxStyle.Critical)
                Exit Sub
            End If
            cont = cont + 1
        Next

        taImpuestoConcepto.Insert(cmbImpuesto.SelectedValue, IdConceptoTextBox.Text)
        actualiza()
        'dgvImpuestos.Rows.Add(cmbImpuesto.SelectedValue, cmbImpuesto.Text, taImpuesto.ObtCuenta_ScalarQuery(cmbImpuesto.SelectedValue), "Eliminar", im)
    End Sub

    Private Sub actualiza()
        'VwCXPImpConBindingSource.Filter = "idConcepto = " & CXP_ConceptosBindingSource.Current("idConcepto")
        Dim dt As New dsProduction.Vw_CXP_ImpConDataTable


        If NombreTextBox.Text <> "" And IdConceptoTextBox.Text <> "-1" Then
            dgvImpuestos.Rows.Clear()
            taImpCon.ObtImpuestos_FillBy(dt, IdConceptoTextBox.Text.Trim) 'ImpuestoTextBox.Text.Split(",") 'taConceptos.ObtImpuesto_ScalarQuery(CXP_ConceptosBindingSource.Current("idConcepto")).ToString.Split(",")
            'For i As Integer = 0 To arrayImpuestos.Length - 1
            Dim cont As Integer = 0
            For Each row As dsProduction.Vw_CXP_ImpConRow In dt 'DsProduction.Vw_CXP_ImpCon.Rows
                dgvImpuestos.Rows.Add()
                dgvImpuestos.Item(0, cont).Value = row.idImpCon
                dgvImpuestos.Item(1, cont).Value = row.descripcionLarga
                dgvImpuestos.Item(2, cont).Value = row.cuenta
                dgvImpuestos.Item(3, cont).Value = "Eliminar"
                dgvImpuestos.Item(4, cont).Value = row.idImpuesto
                cont += 1
            Next
        Else
            dgvImpuestos.Rows.Clear()
        End If
    End Sub

    Private Sub dgvImpuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImpuestos.CellContentClick
        If e.ColumnIndex = 3 Then
            taImpuestoConcepto.DeleteQuery(dgvImpuestos.Item(0, e.RowIndex).Value)
        End If
        actualiza()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        dgvImpuestos.Rows.Clear()
    End Sub

    Private Sub dgvImpuestos_Click(sender As Object, e As EventArgs) Handles dgvImpuestos.Click
        actualiza()
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        dgvImpuestos.Rows.Clear()
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        dgvImpuestos.Rows.Clear()
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        dgvImpuestos.Rows.Clear()
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        dgvImpuestos.Rows.Clear()
    End Sub

    Private Sub BindingNavigatorPositionItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.Click
        dgvImpuestos.Rows.Clear()
    End Sub

    Private Sub IdConceptoTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdConceptoTextBox.TextChanged
        If IdConceptoTextBox.Text = "-1" Then
            cmbImpuesto.Enabled = False
            btnAgregar.Enabled = False
        Else
            cmbImpuesto.Enabled = True
            btnAgregar.Enabled = True
        End If
    End Sub
End Class