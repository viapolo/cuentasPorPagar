Public Class frmDocumentosProv
    Public noProveedorParaDocumentosProv As Integer
    Public tipoPersonaParaDocumentosProv As String
    Dim conFormDoc As Integer
    Private Sub frmDocumentosProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Estatus2' Puede moverla o quitarla según sea necesario.
        Me.CXP_Estatus2TableAdapter.Fill(Me.DsProduction.CXP_Estatus2)
        If tipoPersonaParaDocumentosProv = "M" Then
            Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "M")
        ElseIf tipoPersonaParaDocumentosProv = "F" Then
            Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "F")
        ElseIf tipoPersonaParaDocumentosProv = "E" Then
            Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "E")
        ElseIf tipoPersonaParaDocumentosProv = "C" Then
            Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "C")
        End If
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_ProveedoresArch' Puede moverla o quitarla según sea necesario.
        Me.CXP_ProveedoresArchTableAdapter.Fill(Me.DsProduction.CXP_ProveedoresArch)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_ProveedoresArch1' Puede moverla o quitarla según sea necesario.

        CXP_ProveedoresArchBindingSource.Filter = "idProveedor = '" & noProveedorParaDocumentosProv & "'"

        actualizaGridView()
    End Sub


    Private Sub CXP_ProveedoresArchBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CXP_ProveedoresArchBindingNavigatorSaveItem.Click
        Dim guuid As String = Guid.NewGuid.ToString
        Dim contador As Integer = 0
        Dim contadorFilas As Integer = CXP_ProveedoresArchDataGridView.Rows.Count
        Dim validacion As String = "OK"
        CXP_ProveedoresArchDataGridView.EndEdit()

        Try
            For rows As Integer = 0 To contadorFilas - 2
                If CXP_ProveedoresArchDataGridView.Rows(rows).Cells(3).Value = CXPDocumentacionProvBindingSource.Current("idDocAdjunto") Then
                    MsgBox("El (La) " & CXPDocumentacionProvBindingSource.Current("descripcion") & "ya existe.", MsgBoxStyle.Information, "")
                    validacion = "NO"
                End If

                If IsNothing(CXP_ProveedoresArchDataGridView.Rows(rows).Cells(0)) = False Then
                    If CXP_ProveedoresArchDataGridView.Rows(rows).Cells(0).Value.ToString = "" Then
                        MsgBox("No se ha seleccionado un tipo de documento", MsgBoxStyle.Critical, "")
                        validacion = "NO"
                    End If
                Else
                    MsgBox("No se ha seleccionado un tipo de documento", MsgBoxStyle.Critical, "")
                    validacion = "NO"
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try

        Try
            If validacion = "OK" Then
                CXP_ProveedoresArchBindingSource.Current("idProveedor") = noProveedorParaDocumentosProv
                If CXP_ProveedoresArchBindingSource.Current("idProveedoresArch") < 0 Then
                    CXP_ProveedoresArchBindingSource.Current("uuid") = guuid
                    CXP_ProveedoresArchBindingSource.Current("activo") = True

                    Dim filePath As String = ""
                    OpenFileDialog1.Filter = "pdf|*.pdf|PDF|*.PDF"
                    If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                        filePath = OpenFileDialog1.FileName
                        System.IO.File.Copy(OpenFileDialog1.FileName, My.Settings.fileNas & "CXP\FilesProv\" & guuid & ".pdf")
                        MsgBox("Documento cargado correctamente", MsgBoxStyle.Information, "")
                    End If
                End If


                Me.Validate()
                Me.CXP_ProveedoresArchBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DsProduction)

            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try

        actualizaGridView()
    End Sub

    Private Sub actualizaGridView()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In CXP_ProveedoresArchDataGridView.Rows
            If CXP_ProveedoresArchDataGridView.Rows(cont).Cells(3).Value = 19 Or CXP_ProveedoresArchDataGridView.Rows(cont).Cells(3).Value = 17 Then
                CXP_ProveedoresArchDataGridView.Rows(cont).Cells(0).Style.BackColor = Color.Orange
                CXP_ProveedoresArchDataGridView.Rows(cont).Cells(1).Style.BackColor = Color.Orange
                CXP_ProveedoresArchDataGridView.Rows(cont).Cells(2).Style.BackColor = Color.Orange
                CXP_ProveedoresArchDataGridView.Rows(cont).Cells(3).Style.BackColor = Color.Orange
                CXP_ProveedoresArchDataGridView.Rows(cont).Cells(4).Style.BackColor = Color.Orange
                CXP_ProveedoresArchDataGridView.Rows(cont).Cells(5).Style.BackColor = Color.Orange
                CXP_ProveedoresArchDataGridView.Rows(cont).Cells(6).Style.BackColor = Color.Orange
                CXP_ProveedoresArchDataGridView.Rows(cont).Cells(7).Style.BackColor = Color.Orange
                CXP_ProveedoresArchDataGridView.Rows(cont).Cells(8).Style.BackColor = Color.Orange
                CXP_ProveedoresArchDataGridView.Rows(cont).Cells(9).Style.BackColor = Color.Orange
                CXP_ProveedoresArchDataGridView.Item("autorizar1", cont).Value = "Autorizar"
            End If
            cont += 1
        Next
    End Sub

    Function validaGridView()
        Dim cont As Integer = 0
        Dim resultado As Boolean = True
        For Each row As DataGridViewRow In CXP_ProveedoresArchDataGridView.Rows
            If CXP_ProveedoresArchDataGridView.Rows(cont).ReadOnly = False Then
                If CXP_ProveedoresArchDataGridView.Rows(cont).Cells(3).Value <> 20 Or CXP_ProveedoresArchDataGridView.Rows(cont).Cells(3).Value <> 24 Or CXP_ProveedoresArchDataGridView.Rows(cont).Cells(3).Value <> 26 Then
                    resultado = False
                End If
            End If
            cont += 1
        Next
        Return resultado
    End Function

    Private Sub CXP_ProveedoresArchDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CXP_ProveedoresArchDataGridView.CellContentClick
        Try
            If e.ColumnIndex = 1 Then
                If System.IO.File.Exists(My.Settings.fileNas & "CXP\FilesProv\" & CXP_ProveedoresArchBindingSource.Current("uuid") & ".pdf") = True Then
                    Process.Start(My.Settings.fileNas & "CXP\FilesProv\" & CXP_ProveedoresArchBindingSource.Current("uuid") & ".pdf")
                End If
            End If
            If e.ColumnIndex = 8 Then
                If CXP_ProveedoresArchDataGridView.Rows(e.RowIndex).Cells(3).Value = 19 Or CXP_ProveedoresArchDataGridView.Rows(e.RowIndex).Cells(3).Value = 17 Then
                    Dim frmDocumentacion As New frmAutorizarDocumentacion
                    Dim mdiDocumentacion As New mdicuentasPorPagar
                    mdiDocumentacion = MdiParent
                    frmDocumentacion.MdiParent = mdiDocumentacion
                    Me.Cursor = Cursors.WaitCursor
                    frmDocumentacion.idProveedorArch = CXP_ProveedoresArchDataGridView.Rows(e.RowIndex).Cells(9).Value
                    frmDocumentacion.idEstatus = CXP_ProveedoresArchDataGridView.Rows(e.RowIndex).Cells(3).Value
                    frmDocumentacion.noProveedor = noProveedorParaDocumentosProv
                    frmDocumentacion.tipoPersonaDocumentosAutoriza = tipoPersonaParaDocumentosProv
                    frmDocumentacion.Show()
                    Me.Cursor = Cursors.Default
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmDocumentosProv_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmContProveedoresClientes.Enabled = True
        frmContProveedoresClientes.Refresh()
        frmContProveedoresClientes.Update()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Enabled = False
        frmAutorizarDocumentacion.Show()
    End Sub

    Private Sub CXP_ProveedoresArchDataGridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles CXP_ProveedoresArchDataGridView.DataBindingComplete
        actualizaGridView()
    End Sub

    Private Sub frmDocumentosProv_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class