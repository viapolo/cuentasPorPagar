Option Explicit On
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.Data.SqlClient
Imports System.IO
Imports System.Collections.Specialized
Imports System.Web
Imports System.Deployment.Application
Imports System.ComponentModel

Public Class mdicuentasPorPagar
    Public varGlUser As String
    Public varGlIdUser As String
    Public varGlPerfil As String
    Public varGlEmpresa As String
    Public varGlEmpresaD As String

    Dim taPerfil As New dsProductionTableAdapters.CXP_PerfilesUsuarioTableAdapter
    Dim t As New dsProduction.CXP_PerfilesUsuarioDataTable
    Dim dtPerfiles As New DataTable
    Dim drPerfiles As DataRow
    Dim USUARIOX As String
    Public CuentasTableAdapterG As New contpaqTableAdapters.CuentasTableAdapter
    Public dtCuentasG As New contpaq.CuentasDataTable


    Private Sub PerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmPerfiles.MdiParent = Me
        frmPerfiles.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        lfrInicio.Close()

        For Each Formulario As Form In Me.MdiChildren
            Formulario.Close()
        Next
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
        Me.Text = "Cuentas por Pagar   ** " + varGlEmpresaD
        Dim cn As New SqlConnection()
        Dim strSelect As String
        Dim Usuario As String
        Dim Password As String
        Dim strConnectionSecurity As String
        Dim cm As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daMenus As New SqlDataAdapter(cm)
        Dim drMenu As DataRow
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim Args() As String
        Try
            Args = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData
        Catch ex As Exception
            ReDim Args(1)
            Args(0) = "1"
        End Try

        Try
            Dim rkCurrentUser As RegistryKey = Registry.CurrentUser
            ' Obtain the test key (read-only) and display it.
            Dim rkTest As RegistryKey = rkCurrentUser.OpenSubKey("Software\INFO100\FINANCIERA")
            rkTest.Close()
            rkCurrentUser.Close()
            rkTest = Registry.CurrentUser.OpenSubKey("Software\INFO100\FINANCIERA")
            rkTest.Close()
            rkTest = Registry.CurrentUser.OpenSubKey("Software\INFO100\FINANCIERA", True)
            strConnectionSecurity = My.Settings.SeguridadNvaConnectionString
            Dim cadenacon As String
            cadenacon = rkTest.GetValue("FINANCIERA").ToString
            'Usuario = Mid(cadenacon, InStr(cadenacon, "user ID ="), 10)
            'Password = rkTest.GetValue("Contrasena").ToString
            Usuario = varGlUser 'rkTest.GetValue("Usuario").ToString
            'USUARIOX = Usuario
            'varGlUser = Usuario
            Password = rkTest.GetValue("Contrasena").ToString
            rkTest.Close()

            'If varGlUser <> "desarrollo" And varGlUser <> "viapolo" Then
            '    If (InStr(Args(0), "Agil.application") <= 0 And InStr(Args(0), "Finagil.application") <= 0) And varGlUser <> "desarrollo" Then
            '        MessageBox.Show("Faltan argumentos para iniciar esta aplicación. (Error1) " & Args(0) & " " & varGlUser, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        End
            '    End If
            'End If

        Catch eException As Exception
            Console.WriteLine("The file could not be read:")
            MessageBox.Show(eException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

        strSelect = "SELECT cve_menu, cve_submenu, cve_ssubmenu, cve_sssubmenu FROM SEG_MAESTRA " &
       "WHERE cve_perfil IN (SELECT PERFILES.cve_perfil FROM PERFILES " &
                             "INNER JOIN USUARIOS_PERFILES ON PERFILES.cve_perfil = USUARIOS_PERFILES.cve_perfil " &
                             "INNER JOIN USUARIO ON USUARIOS_PERFILES.cve_empleado = USUARIO.cve_empleado " &
                             "WHERE nom_sistema = 'TESORERIAFINAGIL' AND (USUARIO.id_usuario = '" & Usuario & "' ))" &
       "ORDER BY cve_menu, cve_submenu, cve_ssubmenu, cve_sssubmenu"

        cn.ConnectionString = strConnectionSecurity

        With cm
            .Connection = cn
            .CommandText = strSelect
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión

        daMenus.Fill(dsAgil, "Menus")

        'UsuarioGlobalNombre = USER_SEC.ScalarNombre(Usuario)
        'UsuarioGlobalDepto = USER_SEC.ScalarDepto(Usuario)
        'UsuarioGlobalCorreo = USER_SEC.ScalarCorreo(Usuario)


        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim c As Integer = 0

        For Each drMenu In dsAgil.Tables("Menus").Rows

            If drMenu(0) > 0 Then
                MenuStrip.Items(drMenu(0)).Enabled = True
                If drMenu(1) > 0 Then
                    For Each menu1 As ToolStripMenuItem In Me.MenuStrip.Items.Find(MenuStrip.Items(drMenu(0)).Name, True)
                        For Each menu2 As ToolStripMenuItem In menu1.DropDownItems
                            If a = drMenu(1) Then
                                menu2.Enabled = True
                            End If
                            a += 1
                        Next
                    Next
                Else
                    For Each menu1 As ToolStripMenuItem In Me.MenuStrip.Items.Find(MenuStrip.Items(drMenu(0)).Name, True)
                        For Each menu2 As ToolStripMenuItem In menu1.DropDownItems
                            menu2.Enabled = True
                        Next
                    Next
                End If

                If drMenu(2) > 0 Then
                    For Each menu1 As ToolStripMenuItem In Me.MenuStrip.Items.Find(MenuStrip.Items(drMenu(0)).Name, True)
                        For Each menu2 As ToolStripMenuItem In menu1.DropDownItems.Find(menu1.DropDownItems(drMenu(1)).name, True)
                            For Each menu3 As ToolStripMenuItem In menu2.DropDownItems '.Find(menu2.DropDownItems(drMenu(2)).name, True)
                                If b = drMenu(2) Then
                                    menu3.Enabled = True
                                End If
                                b += 1
                            Next
                        Next
                    Next
                Else
                    For Each menu1 As ToolStripMenuItem In Me.MenuStrip.Items.Find(MenuStrip.Items(drMenu(0)).Name, True)
                        For Each menu2 As ToolStripMenuItem In menu1.DropDownItems.Find(menu1.DropDownItems(drMenu(1)).name, True)
                            For Each menu3 As ToolStripMenuItem In menu2.DropDownItems '.Find(menu2.DropDownItems(drMenu(2)).name, True)
                                menu3.Enabled = True
                            Next
                        Next
                    Next
                End If
            Else
                For Each menu1 As ToolStripMenuItem In Me.MenuStrip.Items
                    menu1.Enabled = True
                    For Each menu2 As ToolStripMenuItem In menu1.DropDownItems
                        menu2.Enabled = True
                        For Each menu3 As ToolStripMenuItem In menu2.DropDownItems
                            MenuStrip.Enabled = True
                        Next
                    Next
                Next
            End If
        Next

        If varGlUser = "viapolo" Then
            For Each vLocMnuOpciones As ToolStripMenuItem In Me.MenuStrip.Items
                For Each submenu1 As ToolStripMenuItem In vLocMnuOpciones.DropDownItems
                    For Each submenu2a As ToolStripMenuItem In submenu1.DropDownItems
                        submenu2a.Enabled = True
                    Next
                    submenu1.Enabled = True
                Next
                vLocMnuOpciones.Enabled = True
            Next
        End If
        tssUsuario.Text = "Usuario: " & varGlUser
        tssEmpresa.Text = "Empresa: " & varGlEmpresaD
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
        For Each Formulario As Form In Me.MdiChildren
            Formulario.Close()
        Next
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

    Private Sub DiariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiariosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmDiario.MdiParent = Me
        frmDiario.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub TipoDeDocumentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoDeDocumentoToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSATTipoDocumento.MdiParent = Me
        frmSATTipoDocumento.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub FacturasElectrónicasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasElectrónicasToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSolicitudesDePago.MdiParent = Me
        frmSolicitudesDePago.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SucursalesToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSucursales.MdiParent = Me
        frmSucursales.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub AutorizadoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AutorizadoresToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmAutorizaciones.MdiParent = Me
        frmAutorizaciones.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub TipoDeCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeCuentaToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmTipoCuentaContable.MdiParent = Me
        frmTipoCuentaContable.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub TipoDeSolcitudPorConceptoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeSolcitudPorConceptoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmTipoConcepto.MdiParent = Me
        frmTipoConcepto.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub CambiarDeEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarDeEmpresaToolStripMenuItem.Click
        lfrInicio.Show()
    End Sub

    Private Sub GastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        fmrPolizasDiarioSCuenta.MdiParent = Me
        fmrPolizasDiarioSCuenta.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub



    Private Sub ComprobaciónDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobaciónDeGastosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmCompGstPDF.MdiParent = Me
        frmCompGstPDF.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ConComprobanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConComprobanteToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmCCPDF.MdiParent = Me
        frmCCPDF.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SinComprobanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SinComprobanteToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSCPDF.MdiParent = Me
        frmSCPDF.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SaldosPorUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldosPorUsuarioToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSaldosGastos.MdiParent = Me
        frmSaldosGastos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSucursales.MdiParent = Me
        frmSucursales.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmDepartamentos.MdiParent = Me
        frmDepartamentos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub DocumentaciónProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentaciónProveedorToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmDocumentosProveedores.MdiParent = Me
        frmDocumentosProveedores.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub GenerarPólizasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarPólizasToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmGenPolizas.MdiParent = Me
        frmGenPolizas.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SolicitudesDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitudesDePagoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmTesSolicitudesDePago.MdiParent = Me
        frmTesSolicitudesDePago.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub PeriodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeriodosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmPeridos.MdiParent = Me
        frmPeridos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub GenerarPDFDeExpedienteDigitalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarPDFDeExpedienteDigitalToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmGeneraPdfExpediente.MdiParent = Me
        frmGeneraPdfExpediente.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub
End Class
