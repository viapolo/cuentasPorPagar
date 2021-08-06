Public Class frmPerfiles
    Dim taPerfiles As New dsProductionTableAdapters.CXP_PerfilesUsuarioTableAdapter
    Private Sub frmPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction1.CXP_Perfiles' Puede moverla o quitarla según sea necesario.
        Me.CXP_PerfilesTableAdapter.Fill(Me.DsProduction1.CXP_Perfiles)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_PerfilesUsuario' Puede moverla o quitarla según sea necesario.
        Me.CXP_PerfilesUsuarioTableAdapter.Fill(Me.DsProduction.CXP_PerfilesUsuario, cmbNombrePerfil.SelectedValue)

        For Each vLocMnuOpciones As ToolStripMenuItem In mdicuentasPorPagar.MenuStrip.Items
            cmbMenu.Items.Add(vLocMnuOpciones.Name.ToString.Replace("ToolStripMenuItem1", "").Replace("ToolStripMenuItem", ""))
            'cmbMenu.Enabled = True
        Next
        deshabilitaControles()
    End Sub

    Private Sub cmbMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMenu.SelectedIndexChanged
        cmbSubMenu1.Text = ""
        cmbSubMenu1.Items.Clear()
        For Each vLocMnuOpciones As ToolStripMenuItem In mdicuentasPorPagar.MenuStrip.Items
            If vLocMnuOpciones.Name = cmbMenu.Text & "ToolStripMenuItem" Then
                For Each submenu As ToolStripMenuItem In vLocMnuOpciones.DropDownItems
                    cmbSubMenu1.Items.Add(submenu.Name.ToString.Replace("ToolStripMenuItem1", "").Replace("ToolStripMenuItem", ""))
                Next
                'cmbSubMenu1.Enabled = True
                chkEscritura.Enabled = True
                chkLectura.Enabled = True
                btnAgregar.Enabled = True
            End If
        Next
        If cmbSubMenu1.Items.Count = 0 Then
            cmbSubMenu1.Enabled = False
            cmbSubMenu2.Enabled = False
        Else
            cmbSubMenu1.Enabled = True
            cmbSubMenu2.Enabled = True
        End If
        'cmbMenu.Enabled = False
    End Sub

    Private Sub cmbSubMenu1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubMenu1.SelectedIndexChanged
        cmbSubMenu2.Text = ""
        cmbSubMenu2.Items.Clear()
        For Each vLocMnuOpciones As ToolStripMenuItem In mdicuentasPorPagar.MenuStrip.Items
            If vLocMnuOpciones.Name = cmbMenu.Text & "ToolStripMenuItem" Then
                For Each submenu As ToolStripMenuItem In vLocMnuOpciones.DropDownItems
                    If submenu.Name = cmbSubMenu1.Text & "ToolStripMenuItem" Then
                        For Each submenu1 As ToolStripMenuItem In submenu.DropDownItems
                            cmbSubMenu2.Items.Add(submenu1.Name.ToString.Replace("ToolStripMenuItem1", "").Replace("ToolStripMenuItem", ""))
                        Next
                        cmbSubMenu2.Enabled = True
                    End If
                Next
            End If
        Next
        If cmbSubMenu2.Items.Count = 0 Then
            cmbSubMenu2.Enabled = False
        Else
            cmbSubMenu2.Enabled = True
        End If
        'cmbSubMenu1.Enabled = False
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        taPerfiles.Insert(cmbMenu.Text.Trim, cmbSubMenu1.Text.Trim, cmbSubMenu2.Text.Trim, chkLectura.Checked, chkEscritura.Checked, cmbNombrePerfil.SelectedValue, False)
        cmbSubMenu1.Text = ""
        cmbSubMenu1.Items.Clear()
        cmbSubMenu2.Text = ""
        cmbSubMenu2.Items.Clear()
        taPerfiles.Fill(DsProduction.CXP_PerfilesUsuario, cmbNombrePerfil.SelectedValue)
        CXP_PerfilesUsuarioDataGridView.Rows.Clear()
        For Each rowsa As dsProduction.CXP_PerfilesUsuarioRow In DsProduction.CXP_PerfilesUsuario.Rows
            CXP_PerfilesUsuarioDataGridView.Rows.Add(rowsa.nombrePerfil, rowsa.menu, rowsa.submenu1, rowsa.submenu2, rowsa.lectura, rowsa.lecturaEscritura, "Eliminar", rowsa.idPerfil)
        Next
        cmbMenu.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CXP_PerfilesUsuarioDataGridView.Rows.Clear()
        taPerfiles.Fill(DsProduction.CXP_PerfilesUsuario, cmbNombrePerfil.SelectedValue)
        For Each rowsa As dsProduction.CXP_PerfilesUsuarioRow In DsProduction.CXP_PerfilesUsuario.Rows
            CXP_PerfilesUsuarioDataGridView.Rows.Add(rowsa.nombrePerfil, rowsa.menu, rowsa.submenu1, rowsa.submenu2, rowsa.lectura, rowsa.lecturaEscritura, "Eliminar", rowsa.idPerfil)
        Next
        habilitaControles()
        'cmbMenu.Enabled = True
        'cmbNombrePerfil.Enabled = False
    End Sub

    Private Sub CXP_PerfilesUsuarioDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CXP_PerfilesUsuarioDataGridView.CellContentClick
        If e.ColumnIndex = 6 Then
            taPerfiles.DeleteQuery(CXP_PerfilesUsuarioDataGridView.Rows(e.RowIndex).Cells(7).Value)
            MsgBox("Se ha eliminado la fila correctamente...")
        End If
        taPerfiles.Fill(DsProduction.CXP_PerfilesUsuario, cmbNombrePerfil.SelectedValue)
        CXP_PerfilesUsuarioDataGridView.Rows.Clear()
        For Each rowsa As dsProduction.CXP_PerfilesUsuarioRow In DsProduction.CXP_PerfilesUsuario.Rows
            CXP_PerfilesUsuarioDataGridView.Rows.Add(rowsa.nombrePerfil, rowsa.menu, rowsa.submenu1, rowsa.submenu2, rowsa.lectura, rowsa.lecturaEscritura, "Eliminar", rowsa.idPerfil)
        Next
    End Sub

    Private Sub cmbSubMenu2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubMenu2.SelectedIndexChanged
        'cmbSubMenu2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cmbNombrePerfil.Enabled = True
    End Sub

    Private Sub chkAccesoWeb_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkAccesoWeb_Click(sender As Object, e As EventArgs)
        'taPerfiles.ActWeb_UpdateQuery(chkAccesoWeb.Checked, cmbNombrePerfil.SelectedValue)
    End Sub

    Private Sub habilitaControles()
        Dim f As Integer
        For f = 0 To Me.Controls.Count - 1
            If TypeOf Me.Controls(f) Is TextBox Or TypeOf Me.Controls(f) Is CheckBox Or TypeOf Me.Controls(f) Is DateTimePicker Or TypeOf Me.Controls(f) Is ComboBox Or TypeOf Me.Controls(f) Is Label Or TypeOf Me.Controls(f) Is DataGridView Then
                Me.Controls(f).Enabled = True
            End If
        Next

    End Sub

    Private Sub deshabilitaControles()
        Dim f As Integer
        For f = 0 To Me.Controls.Count - 1
            If TypeOf Me.Controls(f) Is TextBox Or TypeOf Me.Controls(f) Is CheckBox Or TypeOf Me.Controls(f) Is DateTimePicker Or TypeOf Me.Controls(f) Is ComboBox Or TypeOf Me.Controls(f) Is Label Or TypeOf Me.Controls(f) Is DataGridView Then
                Me.Controls(f).Enabled = False
            End If
        Next
        btnBuscar.Enabled = True
        cmbNombrePerfil.Enabled = True
    End Sub

End Class