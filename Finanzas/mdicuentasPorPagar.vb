Imports System.Windows.Forms

Public Class mdicuentasPorPagar
    Public varGlUser As String
    Public varGlIdUser As String
    Public varGlPerfil As String
    Public varGlEmpresa As String
    Dim taPerfil As New dsProductionTableAdapters.CXP_PerfilesUsuarioTableAdapter
    Dim t As New dsProduction.CXP_PerfilesUsuarioDataTable
    Dim dtPerfiles As New DataTable
    Dim drPerfiles As DataRow

    Private Sub PerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmPerfiles.MdiParent = Me
        frmPerfiles.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmEmpresas.MdiParent = Me
        frmEmpresas.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmUsuario.MdiParent = Me
        frmUsuario.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub MonedasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonedasToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSATMonedas.MdiParent = Me
        frmSATMonedas.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSucursales.MdiParent = Me
        frmSucursales.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ImpuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpuestosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSATImpuestos.MdiParent = Me
        frmSATImpuestos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub TipoDeDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeDocumentoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContTipoDocumentos.MdiParent = Me
        frmContTipoDocumentos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub BancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        Bancos.MdiParent = Me
        Bancos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub CuentasContablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasContablesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContCuentasContables.MdiParent = Me
        frmContCuentasContables.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub CódigoAgrupalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CódigoAgrupalToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmCodigoAgrupador.MdiParent = Me
        frmCodigoAgrupador.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub CuentasBancariasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasBancariasToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContCuentasBancarias.MdiParent = Me
        frmContCuentasBancarias.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContProveedoresClientes.MdiParent = Me
        frmContProveedoresClientes.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub PaisesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaisesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmNacionalidades.MdiParent = Me
        frmNacionalidades.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub mdicuentasPorPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If varGlUser = "viapolo" Then
            For Each vLocMnuOpciones As ToolStripMenuItem In Me.MenuStrip.Items
                vLocMnuOpciones.Enabled = True
                For Each submenu1 As ToolStripMenuItem In vLocMnuOpciones.DropDownItems
                    submenu1.Enabled = True
                    For Each submenu2 As ToolStripMenuItem In submenu1.DropDownItems
                        submenu2.Enabled = True
                    Next
                Next
            Next
        Else
            taPerfil.ObtDetPerfil_FillBy(t, varGlPerfil)
            If t.Rows.Count > 0 Then
                For Each rows As dsProduction.CXP_PerfilesUsuarioRow In t
                    For Each vLocMnuOpciones As ToolStripMenuItem In Me.MenuStrip.Items
                        If rows.Item("menu") = vLocMnuOpciones.Name Then
                            vLocMnuOpciones.Enabled = True
                            For Each submenu1 As ToolStripMenuItem In vLocMnuOpciones.DropDownItems
                                If rows.Item("submenu1") = submenu1.Name Then
                                    submenu1.Enabled = True
                                    If rows.Item("submenu2") = "" Then
                                        For Each submenu2a As ToolStripMenuItem In submenu1.DropDownItems
                                            submenu2a.Enabled = True
                                        Next
                                    Else
                                        For Each submenu2 As ToolStripMenuItem In submenu1.DropDownItems
                                            If rows.Item("submenu2") = submenu2.Name Then
                                                submenu2.Enabled = True
                                            End If
                                        Next
                                    End If
                                End If
                            Next
                        End If
                    Next
                Next
            End If
        End If
    End Sub

    Private Sub NombrePerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NombrePerfilesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmNombrePerfiles.MdiParent = Me
        frmNombrePerfiles.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub mdicuentasPorPagar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        lfrInicio.Close()
    End Sub

    Private Sub ConceptosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConceptosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmConceptos.MdiParent = Me
        frmConceptos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub TipoDeGastoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeGastoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmTipoGasto.MdiParent = Me
        frmTipoGasto.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub
End Class
