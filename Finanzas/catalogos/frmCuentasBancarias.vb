Public Class frmCuentasBancarias

    Public NoProveedorParaCtasBancarias As Integer = 0
    Public tipoPersonaParaCuentasProv As String
    Private Sub frmCuentasBancarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Estatus2' Puede moverla o quitarla según sea necesario.
        Me.CXP_Estatus2TableAdapter.Fill(Me.DsProduction.CXP_Estatus2)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_c_Moneda' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_MonedaTableAdapter.Fill(Me.DsProduction.CXP_c_Moneda)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Bancos' Puede moverla o quitarla según sea necesario.
        Me.CXP_BancosTableAdapter.Fill(Me.DsProduction.CXP_Bancos)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_CuentasBancariasProv' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasBancariasProvTableAdapter.Fill(Me.DsProduction.CXP_CuentasBancariasProv)

        CXP_CuentasBancariasProvBindingSource.Filter = "idProveedor = '" & NoProveedorParaCtasBancarias & "'"
    End Sub

    Private Sub CXP_CuentasBancariasProvBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_CuentasBancariasProvBindingNavigatorSaveItem.Click
        Dim guuid As String = Guid.NewGuid.ToString
        Dim contador As Integer = 0
        Dim contadorFilas As Integer = CXP_CuentasBancariasProvDataGridView.Rows.Count
        Dim validacion As String = "OK"
        CXP_CuentasBancariasProvDataGridView.EndEdit()

        Try
            For rows As Integer = 0 To contadorFilas - 2
                If IsNothing(CXP_CuentasBancariasProvDataGridView.Rows(rows).Cells(0)) = False Then
                    If CXP_CuentasBancariasProvDataGridView.Rows(rows).Cells(0).Value.ToString = "" Then
                        MsgBox("No se ha seleccionado un banco para esta cuenta", MsgBoxStyle.Critical, "")
                        validacion = "NO"
                    End If
                Else
                    MsgBox("No se ha seleccionado un banco para esta cuenta", MsgBoxStyle.Critical, "")
                    validacion = "NO"
                End If

                If IsNothing(CXP_CuentasBancariasProvDataGridView.Rows(rows).Cells(1).Value) = False Then
                    If CXP_CuentasBancariasProvDataGridView.Rows(rows).Cells(1).Value.ToString.Trim = "" Then
                        MsgBox("Se requiere una descripción para esta cuenta", MsgBoxStyle.Critical, "")
                        validacion = "NO"
                    End If
                Else
                    MsgBox("Se requiere una descripción para esta cuenta", MsgBoxStyle.Critical, "")
                    validacion = "NO"
                End If

                If IsNothing(CXP_CuentasBancariasProvDataGridView.Rows(rows).Cells(2).Value) = False Then
                    If CXP_CuentasBancariasProvDataGridView.Rows(rows).Cells(2).Value.ToString.Trim.Length <> 10 Then
                        MsgBox("La cuenta bancaria no tiene la longitud correcta", MsgBoxStyle.Critical, "")
                        validacion = "NO"
                    End If
                Else
                    MsgBox("No se ingreso una cuenta bancaria", MsgBoxStyle.Critical, "")
                    validacion = "NO"
                End If

                If IsNothing(CXP_CuentasBancariasProvDataGridView.Rows(rows).Cells(3).Value) = False Then
                    If CXP_CuentasBancariasProvDataGridView.Rows(rows).Cells(3).Value.ToString.Trim.Length <> 18 Then
                        MsgBox("La cuenta CLABE no tiene la longitud correcta", MsgBoxStyle.Critical, "")
                        validacion = "NO"
                    End If
                Else
                    MsgBox("No se ingreso una cuenta CLABE", MsgBoxStyle.Critical, "")
                    validacion = "NO"
                End If

                If IsNothing(CXP_CuentasBancariasProvDataGridView.Rows(rows).Cells(4)) = False Then
                    If CXP_CuentasBancariasProvDataGridView.Rows(rows).Cells(4).Value.ToString = "" Then
                        MsgBox("No se ha seleccionado una moneda para esta cuenta", MsgBoxStyle.Critical, "")
                        validacion = "NO"
                    End If
                Else
                    MsgBox("No se ha seleccionado una moneda para esta cuenta", MsgBoxStyle.Critical, "")
                    validacion = "NO"
                End If
                contador += 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try

        Try
            If validacion = "OK" Then
                CXP_CuentasBancariasProvBindingSource.Current("idProveedor") = NoProveedorParaCtasBancarias
                If CXP_CuentasBancariasProvBindingSource.Current("idCuentas") < 1 Then
                    CXP_CuentasBancariasProvBindingSource.Current("archivo1") = guuid
                    CXP_CuentasBancariasProvBindingSource.Current("vigente") = True

                    Dim filePath As String = ""
                    OpenFileDialog1.Filter = "pdf|*.pdf|PDF|*.PDF"
                    If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                        filePath = OpenFileDialog1.FileName
                        System.IO.File.Copy(OpenFileDialog1.FileName, My.Settings.fileNas & "CXP\FilesProv\" & guuid & ".pdf")
                        MsgBox("Documento cargado correctamente", MsgBoxStyle.Information, "")
                    End If
                End If

                Me.Validate()
                Me.CXP_CuentasBancariasProvBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DsProduction)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CXP_CuentasBancariasProvDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CXP_CuentasBancariasProvDataGridView.CellContentClick
        Try
            Dim filePath As String = ""
            If e.ColumnIndex = 7 Then
                If System.IO.File.Exists(My.Settings.fileNas & "CXP\FilesProv\" & CXP_CuentasBancariasProvBindingSource.Current("archivo1") & ".pdf") = True Then
                    Process.Start(My.Settings.fileNas & "CXP\FilesProv\" & CXP_CuentasBancariasProvBindingSource.Current("archivo1") & ".pdf")
                Else
                    OpenFileDialog1.Filter = "pdf|*.pdf|PDF|*.PDF"
                    If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                        filePath = OpenFileDialog1.FileName
                        System.IO.File.Copy(OpenFileDialog1.FileName, My.Settings.fileNas & "CXP\FilesProv\" & CXP_CuentasBancariasProvBindingSource.Current("archivo1") & ".pdf")
                        MsgBox("Documento cargado correctamente", MsgBoxStyle.Information, "")
                    End If
                End If
            End If
            If e.ColumnIndex = 9 Then
                If CXP_CuentasBancariasProvDataGridView.Rows(e.RowIndex).Cells("estatus").Value = 12 Or CXP_CuentasBancariasProvDataGridView.Rows(e.RowIndex).Cells("estatus").Value = 14 Then
                    Dim frmDocumentacion As New frmAutorizarCuentasBancarias
                    Dim mdiDocumentacion As New mdicuentasPorPagar
                    mdiDocumentacion = MdiParent
                    frmDocumentacion.MdiParent = mdiDocumentacion
                    Me.Cursor = Cursors.WaitCursor
                    frmDocumentacion.idCuentas = CXP_CuentasBancariasProvDataGridView.Rows(e.RowIndex).Cells("idCuentas").Value
                    frmDocumentacion.idEstatus = CXP_CuentasBancariasProvDataGridView.Rows(e.RowIndex).Cells("estatus").Value
                    frmDocumentacion.noProveedor = NoProveedorParaCtasBancarias
                    frmDocumentacion.tipoPersonaCuentasAutoriza = tipoPersonaParaCuentasProv
                    frmDocumentacion.Show()
                    Me.Cursor = Cursors.Default
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub actualizaGridView()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In CXP_CuentasBancariasProvDataGridView.Rows
            If CXP_CuentasBancariasProvDataGridView.Rows(cont).Cells("estatus").Value = 12 Or CXP_CuentasBancariasProvDataGridView.Rows(cont).Cells("estatus").Value = 14 Then
                CXP_CuentasBancariasProvDataGridView.Rows(cont).Cells(0).Style.BackColor = Color.Orange
                CXP_CuentasBancariasProvDataGridView.Rows(cont).Cells(1).Style.BackColor = Color.Orange
                CXP_CuentasBancariasProvDataGridView.Rows(cont).Cells(2).Style.BackColor = Color.Orange
                CXP_CuentasBancariasProvDataGridView.Rows(cont).Cells(3).Style.BackColor = Color.Orange
                CXP_CuentasBancariasProvDataGridView.Rows(cont).Cells(4).Style.BackColor = Color.Orange
                CXP_CuentasBancariasProvDataGridView.Rows(cont).Cells(5).Style.BackColor = Color.Orange
                CXP_CuentasBancariasProvDataGridView.Rows(cont).Cells(6).Style.BackColor = Color.Orange
                CXP_CuentasBancariasProvDataGridView.Rows(cont).Cells(7).Style.BackColor = Color.Orange
                CXP_CuentasBancariasProvDataGridView.Rows(cont).Cells(8).Style.BackColor = Color.Orange
                CXP_CuentasBancariasProvDataGridView.Item("autorizar", cont).Value = "Autorizar"
            End If
            cont += 1
        Next
    End Sub

    Private Sub CXP_CuentasBancariasProvDataGridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles CXP_CuentasBancariasProvDataGridView.DataBindingComplete
        actualizaGridView()
    End Sub

    Private Sub frmCuentasBancarias_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmContProveedoresClientes.Enabled = True
        frmContProveedoresClientes.Refresh()
        frmContProveedoresClientes.Update()
    End Sub

    Private Sub frmCuentasBancarias_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class