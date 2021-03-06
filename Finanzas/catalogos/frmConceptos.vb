﻿Public Class frmConceptos

    Dim taImpuesto As New dsProductionTableAdapters.CXP_ImpuestoTableAdapter
    Dim taConceptos As New dsProductionTableAdapters.CXP_ConceptosTableAdapter
    Dim taImpCon As New dsProductionTableAdapters.Vw_CXP_ImpConTableAdapter
    Dim taImpuestoConcepto As New dsProductionTableAdapters.CXP_ImpConTableAdapter


    Private Sub CXP_ConceptosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_ConceptosBindingNavigatorSaveItem.Click
        CXP_ConceptosBindingSource.Current("idEmpresa") = varGlobal_IdEmpresa
        Me.Validate()
        Me.CXP_ConceptosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)
        'Me.CXP_ConceptosTableAdapter.Fill(Me.DsProduction.CXP_Conceptos, varGlobal_IdEmpresa)
    End Sub

    Private Sub frmConceptos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction4.CXP_Estatus2' Puede moverla o quitarla según sea necesario.
        Me.CXP_Estatus2TableAdapter.Fill(Me.DsProduction4.CXP_Estatus2)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Estatus' Puede moverla o quitarla según sea necesario.
        Me.CXP_EstatusTableAdapter.ProveedoresAutorizado_Fill(Me.DsProduction.CXP_Estatus)
        If varGlobal_IdEmpresa = "24" Then
            CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctCONEARFIN;Persist Security Info=True;User ID=finagil;Password=finagil"
        Else
            CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctFINAGILCONEFINAGIL2015;Persist Security Info=True;User ID=finagil;Password=finagil"
        End If
        'TODO: esta línea de código carga datos en la tabla 'Contpaq.Cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction3.CXP_tipoConcepto' Puede moverla o quitarla según sea necesario.
        Me.CXP_tipoConceptoTableAdapter.Fill(Me.DsProduction3.CXP_tipoConcepto)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_tipoDeDocumento' Puede moverla o quitarla según sea necesario.
        Me.CXP_tipoDeDocumentoTableAdapter.Fill(Me.DsProduction.CXP_tipoDeDocumento, varGlobal_IdEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction2.Vw_CXP_ImpCon' Puede moverla o quitarla según sea necesario.
        'Me.Vw_CXP_ImpConTableAdapter.Fill(Me.DsProduction.Vw_CXP_ImpCon)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_ImpConc' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsProduction1.CXP_CuentasContables' Puede moverla o quitarla según sea necesario.
        'Me.CXP_CuentasContablesTableAdapter.Fill(Me.DsProduction1.CXP_CuentasContables, varGlobal_IdEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_TipoGasto' Puede moverla o quitarla según sea necesario.
        Me.CXP_TipoGastoTableAdapter.Fill(Me.DsProduction.CXP_TipoGasto, varGlobal_IdEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction1.CXP_TipoGasto' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Impuesto' Puede moverla o quitarla según sea necesario.
        Me.CXP_ImpuestoTableAdapter.Fill(Me.DsProduction.CXP_Impuesto, varGlobal_IdEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_CuentasContables' Puede moverla o quitarla según sea necesario.
        'Me.CXP_CuentasContablesTableAdapter.Fill(Me.DsProduction.CXP_CuentasContables, varGlobal_IdEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Conceptos' Puede moverla o quitarla según sea necesario.
        Me.CXP_ConceptosTableAdapter.Fill(Me.DsProduction.CXP_Conceptos, varGlobal_IdEmpresa)


        actualiza()
        actualizaP()
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

        taImpuestoConcepto.Insert(cmbImpuesto.SelectedValue, IdConceptoTextBox.Text, "S")
        actualiza()

        'dgvImpuestos.Rows.Add(cmbImpuesto.SelectedValue, cmbImpuesto.Text, taImpuesto.ObtCuenta_ScalarQuery(cmbImpuesto.SelectedValue), "Eliminar")
    End Sub

    Private Sub actualiza()
        Dim dt As New dsProduction.Vw_CXP_ImpConDataTable
        'Dim taCtas As New contpaqTableAdapters.CuentasTableAdapter
        Dim dtCtas As New contpaq.CuentasDataTable
        Dim rowCtas As contpaq.CuentasRow

        If NombreTextBox.Text <> "" And IdConceptoTextBox.Text <> "-1" Then
            dgvImpuestos.Rows.Clear()
            taImpCon.ObtImpuestos_FillBy(dt, IdConceptoTextBox.Text.Trim, "S")
            Dim cont As Integer = 0
            For Each row As dsProduction.Vw_CXP_ImpConRow In dt

                CuentasTableAdapter.DatosCtas_FillBy(dtCtas, row.ctaDeImpuestos)
                If dtCtas.Rows.Count >= 1 Then
                    rowCtas = dtCtas.Rows(0)

                    dgvImpuestos.Rows.Add()
                    dgvImpuestos.Item(0, cont).Value = row.idImpCon
                    dgvImpuestos.Item(1, cont).Value = row.descripcionLarga
                    dgvImpuestos.Item(2, cont).Value = rowCtas.Codigo.ToString.Insert(4, "-").Insert(7, "-").Insert(10, "-").Insert(15, "-") 'row.cuenta
                    dgvImpuestos.Item(3, cont).Value = "Eliminar"
                    dgvImpuestos.Item(4, cont).Value = row.idImpuesto
                    cont += 1
                End If
            Next
        Else
            dgvImpuestos.Rows.Clear()
        End If
    End Sub

    Private Sub actualizaP()
        Dim dt As New dsProduction.Vw_CXP_ImpConDataTable
        'Dim taCtas As New contpaqTableAdapters.CuentasTableAdapter
        Dim dtCtas As New contpaq.CuentasDataTable
        Dim rowCtas As contpaq.CuentasRow

        If NombreTextBox.Text <> "" And IdConceptoTextBox.Text <> "-1" Then
            dgvImpuestosP.Rows.Clear()
            taImpCon.ObtImpuestos_FillBy(dt, IdConceptoTextBox.Text.Trim, "P")
            Dim cont As Integer = 0
            For Each row As dsProduction.Vw_CXP_ImpConRow In dt

                CuentasTableAdapter.DatosCtas_FillBy(dtCtas, row.ctaDeImpuestos)
                If dtCtas.Rows.Count >= 1 Then
                    rowCtas = dtCtas.Rows(0)

                    dgvImpuestosP.Rows.Add()
                    dgvImpuestosP.Item(0, cont).Value = row.idImpCon
                    dgvImpuestosP.Item(1, cont).Value = row.descripcionLarga
                    dgvImpuestosP.Item(2, cont).Value = rowCtas.Codigo.ToString.Insert(4, "-").Insert(7, "-").Insert(10, "-").Insert(15, "-") 'row.cuenta
                    dgvImpuestosP.Item(3, cont).Value = "Eliminar"
                    dgvImpuestosP.Item(4, cont).Value = row.idImpuesto
                    cont += 1
                End If
            Next
        Else
            dgvImpuestosP.Rows.Clear()
        End If
    End Sub

    Private Sub dgvImpuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImpuestos.CellContentClick
        If e.ColumnIndex = 3 Then
            taImpuestoConcepto.DeleteQuery(dgvImpuestos.Item(0, e.RowIndex).Value)
        End If
        actualiza()
    End Sub

    Private Sub dgvImpuestosP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImpuestosP.CellContentClick
        If e.ColumnIndex = 3 Then
            taImpuestoConcepto.DeleteQuery(dgvImpuestosP.Item(0, e.RowIndex).Value)
        End If
        actualizaP()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        dgvImpuestos.Rows.Clear()
    End Sub

    'Private Sub dgvImpuestos_Click(sender As Object, e As EventArgs) Handles dgvImpuestos.Click
    '    actualiza()
    'End Sub

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



    Private Sub lnkEliminar3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEliminar3.LinkClicked
        Dim id As String = IdConceptoTextBox.Text
        taConceptos.CtaCargoSol_UpdateQuery(CDec(IdConceptoTextBox.Text))
        cmbCtaCargoSol.SelectedValue = 0
        ' Me.CXP_ConceptosTableAdapter.Fill(Me.DsProduction.CXP_Conceptos, varGlobal_IdEmpresa)
        CXP_ConceptosBindingSource.Position = CXP_ConceptosBindingSource.Find("idConcepto", IdConceptoTextBox.Text.Trim)
        'CXP_ConceptosBindingSource.Filter = "idConcepto = '" & IdConceptoTextBox.Text.Trim & "'"
    End Sub

    Private Sub lnkEliminar4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEliminar4.LinkClicked
        Dim id As String = IdConceptoTextBox.Text
        taConceptos.CtaAbonoSol_UpdateQuery(CDec(IdConceptoTextBox.Text))
        cmbCtaAbonoSol.SelectedValue = 0
        'Me.CXP_ConceptosTableAdapter.Fill(Me.DsProduction.CXP_Conceptos, varGlobal_IdEmpresa)
        CXP_ConceptosBindingSource.Position = CXP_ConceptosBindingSource.Find("idConcepto", IdConceptoTextBox.Text.Trim)
    End Sub

    Private Sub lnkElimina1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkElimina1.LinkClicked
        Dim id As String = IdConceptoTextBox.Text
        taConceptos.CtaCargoPago_UpdateQuery(CDec(IdConceptoTextBox.Text))
        cmbCtaCargoPago.SelectedValue = 0
        'Me.CXP_ConceptosTableAdapter.Fill(Me.DsProduction.CXP_Conceptos, varGlobal_IdEmpresa)
        'm_Pos = CXP_ConceptosBindingSource.Find("idConcepto", m_ArticuloID)
        CXP_ConceptosBindingSource.Position = CXP_ConceptosBindingSource.Find("idConcepto", IdConceptoTextBox.Text.Trim)

        'CXP_ConceptosBindingSource.Filter = "idConcepto = '" & IdConceptoTextBox.Text.Trim & "'"
    End Sub

    Private Sub lnkElimina2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkElimina2.LinkClicked
        Dim id As String = IdConceptoTextBox.Text
        taConceptos.CtaAbonoPago_UpdateQuery(CDec(IdConceptoTextBox.Text))
        cmbCtaAbonoPago.SelectedValue = 0
        'Me.Update()
        'Me.CXP_ConceptosTableAdapter.Fill(Me.DsProduction.CXP_Conceptos, varGlobal_IdEmpresa)
        CXP_ConceptosBindingSource.Position = CXP_ConceptosBindingSource.Find("idConcepto", IdConceptoTextBox.Text.Trim)
    End Sub

    Private Sub dgvImpuestos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImpuestos.CellClick
        If e.ColumnIndex = 3 Then
            taImpuestoConcepto.DeleteQuery(dgvImpuestos.Item(0, e.RowIndex).Value)
        End If
        'actualiza()
    End Sub

    Private Sub frmConceptos_Move(sender As Object, e As EventArgs) Handles Me.Move

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CXP_ConceptosBindingSource.Filter = "nombre like '%" & txtBuscar.Text & "%'"
    End Sub

    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTextBox.TextChanged
        actualiza()
        actualizaP()
    End Sub

    Private Sub btnAgregarP_Click(sender As Object, e As EventArgs) Handles btnAgregarP.Click
        Dim valor As Integer = cmbImpuestosP.SelectedValue
        Dim cont As Integer = 0

        For Each rows As DataGridViewRow In dgvImpuestosP.Rows
            If dgvImpuestosP.Item(4, cont).Value = valor Then
                MsgBox("Ya se encuentra el impuesto actual...", MsgBoxStyle.Critical)
                Exit Sub
            End If
            cont = cont + 1
        Next

        taImpuestoConcepto.Insert(cmbImpuestosP.SelectedValue, IdConceptoTextBox.Text, "P")
        actualizaP()
        'dgvImpuestos.Rows.Add(cmbImpuesto.SelectedValue, cmbImpuesto.Text, taImpuesto.ObtCuenta_ScalarQuery(cmbImpuesto.SelectedValue), "Eliminar")
    End Sub

    Private Sub cmbImpuestosP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbImpuestosP.SelectedIndexChanged

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub CXP_ConceptosBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles CXP_ConceptosBindingNavigator.RefreshItems

    End Sub
End Class