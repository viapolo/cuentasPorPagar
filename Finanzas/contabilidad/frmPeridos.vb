Public Class frmPeridos

    Private Sub CXP_PeriodosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_PeriodosBindingNavigatorSaveItem.Click
        CXP_PeriodosBindingSource.Current("idEmpresa") = varGlobal_IdEmpresa
        Me.Validate()
        Me.CXP_PeriodosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsContabilidad)

    End Sub

    Private Sub frmPeridos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsContabilidad.CXP_Estatus' Puede moverla o quitarla según sea necesario.
        Me.CXP_EstatusTableAdapter.Fill(Me.DsContabilidad.CXP_Estatus)
        'TODO: esta línea de código carga datos en la tabla 'DsContabilidad.CXP_Periodos' Puede moverla o quitarla según sea necesario.
        Me.CXP_PeriodosTableAdapter.Fill(Me.DsContabilidad.CXP_Periodos, varGlobal_IdEmpresa)

        Me.CXP_PeriodosDataGridView.Columns.Remove("DataGridViewTextBoxColumn3")
        Me.CXP_PeriodosDataGridView.Columns.Remove("DataGridViewTextBoxColumn4")

        Dim oMCCol As ColumnaPersonalizada = New ColumnaPersonalizada()
        oMCCol.Width = 200
        oMCCol.HeaderText = "Inicio"
        oMCCol.DataPropertyName = "inicioPeriodo"
        oMCCol.Visible = False
        Me.CXP_PeriodosDataGridView.Columns.Add(oMCCol)

        Dim oMCColF As ColumnaPersonalizada = New ColumnaPersonalizada()
        oMCColF.Width = 200
        oMCColF.HeaderText = "Fin"
        oMCColF.DataPropertyName = "finPeriodo"
        oMCColF.Visible = False
        Me.CXP_PeriodosDataGridView.Columns.Add(oMCColF)


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub CXP_PeriodosDataGridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles CXP_PeriodosDataGridView.DataBindingComplete
        actualizaGrid()
    End Sub

    Public Sub actualizaGrid()
        For Each rw As DataGridViewRow In CXP_PeriodosDataGridView.Rows
            If rw.Cells.Item("estatus").Value = 31 Then
                rw.ReadOnly = False
                rw.DefaultCellStyle.ForeColor = Color.Green
            Else
                rw.ReadOnly = True
                rw.DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
    End Sub

End Class

