Option Explicit On
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.Data.SqlClient
Imports System.IO
Imports System.Collections.Specialized
Imports System.Web
Imports System.Deployment.Application
Imports System.ComponentModel
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser



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

    Private Sub mdicuentasPorPagar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        contadorActividad = 0
    End Sub

    'Private Sub timActividad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timActividad.Tick
    'contadorActividad = contadorActividad + 1
    'frmAccesoDirecto.Label1.Text = contadorActividad.ToString
    'If contadorActividad > 1000 Then
    '    timActividad.Enabled = False
    '    Me.Enabled = False
    '    Dim Response
    '    Response = MsgBox("Se ha superado el tiempo de inactividad, ¿Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Tiempo de inactividad")

    '    If Response = vbYes Then
    '        Me.Enabled = True
    '        timActividad.Enabled = True
    '        contadorActividad = 0
    '    Else
    '        Me.Close()
    '    End If
    'End If
    'End Sub

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

    Private Sub CuentasBancariasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContCuentasBancarias.MdiParent = Me
        frmContCuentasBancarias.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs)
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

        If IsMdiContainer Then
            For Each cin As Control In Controls
                If cin.GetType().Equals(GetType(MdiClient)) Then
                    AddHandler cin.MouseMove, AddressOf MDI_MouseMove
                End If
            Next
        End If

        If varGlobal_IdEmpresa = 24 Then
            Me.Icon = My.Resources.icono_arf
            Me.BackgroundImage = My.Resources.logoArfin
        End If

        contadorActividad = 0

        'frmAccesoDirecto.MdiParent = Me
        'frmAccesoDirecto.Show()

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

        Dim taPerfiles As New dsProductionTableAdapters.PermisosPerfilesTableAdapter
        Dim dtPerfiles As New dsProduction.PermisosPerfilesDataTable
        Dim drPerfiles As dsProduction.PermisosPerfilesRow

        taPerfiles.Fill(dtPerfiles, Usuario)

        For Each drPerfiles In dtPerfiles
            If drPerfiles.submenu2 <> String.Empty Then
                For Each m As ToolStripMenuItem In MenuStrip.Items.Find(MenuStrip.Items(drPerfiles.menu & "ToolStripMenuItem").Name, True)
                    If m.Name.Replace(" ", "") = drPerfiles.menu & "ToolStripMenuItem" Then
                        MenuStrip.Items(drPerfiles.menu.Replace(" ", "") & "ToolStripMenuItem").Enabled = True = True
                    End If
                    For Each m1 As ToolStripMenuItem In m.DropDownItems
                        If m1.Name.Replace(" ", "") = drPerfiles.submenu1 & "ToolStripMenuItem" Then
                            m1.Enabled = True
                            For Each m2 As ToolStripMenuItem In m1.DropDownItems
                                If m2.Name.Replace(" ", "") = drPerfiles.submenu2 & "ToolStripMenuItem" Then
                                    m2.Enabled = True
                                End If
                            Next
                        End If
                    Next
                Next
            Else
                If drPerfiles.submenu1 <> String.Empty Then
                    For Each m As ToolStripMenuItem In MenuStrip.Items.Find(MenuStrip.Items(drPerfiles.menu & "ToolStripMenuItem").Name, True)
                        If m.Name.Replace(" ", "") = drPerfiles.menu & "ToolStripMenuItem" Then
                            MenuStrip.Items(drPerfiles.menu.Replace(" ", "") & "ToolStripMenuItem").Enabled = True = True
                        End If
                        For Each m1 As ToolStripMenuItem In m.DropDownItems
                            If m1.Name.Replace(" ", "") = drPerfiles.submenu1 & "ToolStripMenuItem" Then
                                m1.Enabled = True
                            End If
                        Next
                    Next
                    If drPerfiles.submenu2 = String.Empty Then
                        For Each m As ToolStripMenuItem In MenuStrip.Items.Find(MenuStrip.Items(drPerfiles.menu & "ToolStripMenuItem").Name, True)
                            If m.Name.Replace(" ", "") = drPerfiles.menu & "ToolStripMenuItem" Then
                                For Each all As ToolStripMenuItem In m.DropDownItems
                                    If all.Name.Replace(" ", "") = drPerfiles.submenu1 & "ToolStripMenuItem" Then
                                        For Each all2 As ToolStripMenuItem In all.DropDownItems
                                            all2.Enabled = True
                                        Next
                                    End If
                                Next
                            End If
                        Next
                    End If
                Else
                    If drPerfiles.menu <> String.Empty Then
                        For Each m As ToolStripMenuItem In MenuStrip.Items.Find(MenuStrip.Items(drPerfiles.menu & "ToolStripMenuItem").Name, True)
                            m.Enabled = True
                            If m.Name.Replace(" ", "") = drPerfiles.menu & "ToolStripMenuItem" Then
                                For Each all As ToolStripMenuItem In m.DropDownItems
                                    all.Enabled = True
                                    For Each all2 As ToolStripMenuItem In all.DropDownItems
                                        all2.Enabled = True
                                    Next
                                Next
                            End If
                        Next
                    End If
                End If
            End If
        Next


        If varGlUser = "desarrollo" Or varGlUser = "ecacerest" Or varGlUser = "viapolo1" Then
            For Each vLocMnuOpciones As ToolStripMenuItem In Me.MenuStrip.Items
                For Each submenu1 As ToolStripMenuItem In vLocMnuOpciones.DropDownItems
                    For Each submenu2a As ToolStripMenuItem In submenu1.DropDownItems
                        For Each submenu3a As ToolStripMenuItem In submenu2a.DropDownItems
                            submenu3a.Enabled = True
                        Next
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

    Private Sub DiariosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TipoDeDocumentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoDeDocumentoToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSATTipoDocumento.MdiParent = Me
        frmSATTipoDocumento.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub FacturasElectrónicasToolStripMenuItem_Click(sender As Object, e As EventArgs)

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

    Private Sub CambiarDeEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs)


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


    Private Sub TraspasosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraspasosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmTraspasos.MdiParent = Me
        frmTraspasos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub PagoDeFondeosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagoDeFondeosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmPagoFondeos.MdiParent = Me
        frmPagoFondeos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub InversionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InversionesToolStripMenuItem.Click

    End Sub

    Private Sub FacturasElctrónicasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasElctrónicasToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSolicitudesDePago.MdiParent = Me
        frmSolicitudesDePago.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub DiariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DiariosToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmDiario.MdiParent = Me
        frmDiario.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub GastosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        fmrPolizasDiarioSCuenta.MdiParent = Me
        fmrPolizasDiarioSCuenta.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ComprobaciónDeGastosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprobaciónDeGastosToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmCompGstPDF.MdiParent = Me
        frmCompGstPDF.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SolicitudesConComprobanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitudesConComprobanteToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmCCPDF.MdiParent = Me
        frmCCPDF.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SolicitudesSinComprobanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitudesSinComprobanteToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSCPDF.MdiParent = Me
        frmSCPDF.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub


    Private Sub PagosConChequeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosConChequeToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmTesSolicitudesDePagoChe.MdiParent = Me
        frmTesSolicitudesDePagoChe.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SugerenciaDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        contadorActividad = 0
    End Sub

    Private Sub PruebasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub


    Sub metadatos(ByVal ficheroPDFIndexar As String)

        'Public string obtenerMetaDatosFicheroPDF(String ficheroPDFIndexar)
        '{
        '    String mMetadatos = "";            
        '    Try
        '    {
        '        PdfReader ficheroPDF = New PdfReader(ficheroPDFIndexar);
        '        Dictionary metadatosPDF = ficheroPDF.Info;
        '        foreach(KeyValuePair clavesMetadatosPDF In metadatosPDF)
        '        {
        '            If (mMetadatos!= "") Then
        '                            {
        '                mMetadatos = mMetadatos + Environment.NewLine +
        '                    (clavesMetadatosPDF.Key + " ===> " + clavesMetadatosPDF.Value);
        '            }
        '            Else
        '            {
        '                mMetadatos = (clavesMetadatosPDF.Key + " ===> " +
        '                    clavesMetadatosPDF.Value);
        '            }
        '        }
        '        Return mMetadatos;
        '    }
        '    Catch
        '    {
        '        Return null;
        '    }
        '}
    End Sub

    Private Sub PólizaMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PólizaMovimientosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmPolizasMvtos.MdiParent = Me
        frmPolizasMvtos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ComprobaciónDeGastosToolStripMenuItem1_MouseMove(sender As Object, e As MouseEventArgs) Handles ComprobaciónDeGastosToolStripMenuItem1.MouseMove

    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        contadorActividad = 0
    End Sub

    Private Sub CatálogosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatálogosToolStripMenuItem.Click
        contadorActividad = 0
    End Sub

    Private Sub ContabilidadToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContabilidadToolStripMenuItem.Click
        contadorActividad = 0
    End Sub

    Private Sub TesoreríaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TesoreríaToolStripMenuItem.Click
        contadorActividad = 0
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem.Click
        contadorActividad = 0
    End Sub

    Private Sub MDI_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        'Text = String.Format("MouseMoved to {0},{1}", e.X, e.Y)
        contadorActividad = 0
    End Sub

    Private Sub ValidadorCFDIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidadorCFDIToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmValidaCfdi.MdiParent = Me
        frmValidaCfdi.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub FacturasPendientesDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasPendientesDePagoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmFacturasPendientes.MdiParent = Me
        frmFacturasPendientes.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ComprobacionesDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobacionesDeGastosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContabilizaComprobaciones.MdiParent = Me
        frmContabilizaComprobaciones.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
        varGlobal_ToolStrip = ComprobacionesDeGastosToolStripMenuItem.Name.ToString.Replace("ToolStripMenuItem", "")
    End Sub

    Private Sub ReembolsosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReembolsosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContabilizaReembolsos.MdiParent = Me
        frmContabilizaReembolsos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmRptProveedores.MdiParent = Me
        frmRptProveedores.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub BancosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BancosToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmBancos_1.MdiParent = Me
        frmBancos_1.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub CargarDatosBancariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarDatosBancariosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmCargaCuentas.MdiParent = Me
        frmCargaCuentas.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub PruebasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PruebasToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        Form1.MdiParent = Me
        Form1.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ProveedoresToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem2.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContProveedoresClientes.MdiParent = Me
        frmContProveedoresClientes.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub CuentasBancariasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CuentasBancariasToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContCuentasBancarias.MdiParent = Me
        frmContCuentasBancarias.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub CambiarDeEmpresaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CambiarDeEmpresaToolStripMenuItem1.Click
        Dim p As Process
        For Each p In Process.GetProcesses()
            If Not p Is Nothing Then
                If p.ProcessName.ToString = "cuentasPorPagar" Then
                    Try
                        Process.Start(My.Settings.hostExe & "cuentasPorPagar.application")
                        p.Kill()
                        Exit For
                    Catch msg As Exception
                        MsgBox(msg.Message.ToString, MsgBoxStyle.Critical)
                        Exit Sub
                    End Try
                End If
            End If
        Next
    End Sub

    Private Sub NóminaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NóminaToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContabilizarNomina.MdiParent = Me
        frmContabilizarNomina.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub AplicacionesEnBlancoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplicacionesEnBlancoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmAplicacionBlanco.MdiParent = Me
        frmAplicacionBlanco.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub GenerarPólizasFaltantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarPólizasFaltantesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmGeneraPolizas.MdiParent = Me
        frmGeneraPolizas.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub NotificacionesDePagoPorProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificacionesDePagoPorProveedorToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmNotificacionesPago.MdiParent = Me
        frmNotificacionesPago.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub PolizasDeEgresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PolizasDeEgresoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmPolizasEgresos.MdiParent = Me
        frmPolizasEgresos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub CuentasBancoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasBancoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmCuentasBanco.MdiParent = Me
        frmCuentasBanco.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ConceptosEspecialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConceptosEspecialesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmCompraFondos.MdiParent = Me
        frmCompraFondos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ChequesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChequesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContabilizaCheques.MdiParent = Me
        frmContabilizaCheques.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub CuentasConceptosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasConceptosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmCuentasConceptos.MdiParent = Me
        frmCuentasConceptos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub InversionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InversionesToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmInversion.MdiParent = Me
        frmInversion.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub RetiroDeInversionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetiroDeInversionesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmRetiroDeInversion.MdiParent = Me
        frmRetiroDeInversion.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub InversionesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InversionesToolStripMenuItem2.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmReporteInversiones.MdiParent = Me
        frmReporteInversiones.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub PerfilesDeAccesoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilesDeAccesoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmPerfiles.MdiParent = Me
        frmPerfiles.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ContabilidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionContableToolStripMenuItem.Click

    End Sub
End Class
