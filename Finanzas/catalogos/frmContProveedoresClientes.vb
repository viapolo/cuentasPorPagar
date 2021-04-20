Imports System.Text.RegularExpressions

Public Class frmContProveedoresClientes

    Dim noProveedor As Integer
    Dim autoriza2 As String = "viapolo@finagil.com.mx"
    Dim usuarioSolicita As String = ""
    Dim razonSocial As String = ""
    Private Sub frmContProveedoresClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction1.CXP_Estatus1' Puede moverla o quitarla según sea necesario.
        Me.CXP_Estatus1TableAdapter.ProveedoresActivo_Fill(Me.DsProduction1.CXP_Estatus1)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Estatus' Puede moverla o quitarla según sea necesario.
        Me.CXP_EstatusTableAdapter.ProveedoresAutorizado_Fill(Me.DsProduction.CXP_Estatus)

        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Proveedores' Puede moverla o quitarla según sea necesario.
        Me.CXP_ProveedoresTableAdapter.Fill(Me.DsProduction.CXP_Proveedores)
        txtBuscaProveedor.Focus()
        'actualizaCuentas()
        If RazonSocialTextBox.Text.Trim.Length > 50 Then
            razonSocial = RazonSocialTextBox.Text.Trim.Substring(0, 49)
        End If

    End Sub

    Private Sub actualizar()
        Dim taUsuarios As New dsSeguridadTableAdapters.USUARIOTableAdapter

        Try
            If IsDBNull(CXP_ProveedoresBindingSource.Current("autorizadoS")) = False Then
                If CXP_ProveedoresBindingSource.Current("autorizadoS") = "AUTORIZADO" Or CXP_ProveedoresBindingSource.Current("autorizadoS") = "PENDIENTE" Then
                    cmbAutorizado.Enabled = False
                Else
                    cmbAutorizado.Enabled = True
                End If
            Else
                cmbAutorizado.Enabled = True
            End If
            btnCtasBancarias.Enabled = True
            btnDocumentacion.Enabled = True
        Catch ex As Exception
            btnCtasBancarias.Enabled = False
            btnDocumentacion.Enabled = False
        End Try

        If taUsuarios.ExisteRfc_ScalarQuery(RfcTextBox.Text.Trim) = "NE" Or IsNothing(taUsuarios.ExisteRfc_ScalarQuery(RfcTextBox.Text.Trim)) Then
            If RfcTextBox.Text.Trim.Length = 12 Then
                lblTipoPersona.Text = "Persona Moral"
            ElseIf RfcTextBox.Text.Trim.Length = 13 Then
                lblTipoPersona.Text = "Persona Física"
            End If
        Else
            lblTipoPersona.Text = "Empleado"
        End If

    End Sub

    Private Sub RelacionadoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub MailTextBox_LostFocus(sender As Object, e As EventArgs) Handles MailTextBox.LostFocus
        If MailTextBox.TextLength > 0 Then
            utilerias.validaMail(MailTextBox.Text.Trim)
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Dim f As Integer
        For f = 0 To Me.Controls.Count - 1
            If TypeOf Me.Controls(f) Is TextBox Or TypeOf Me.Controls(f) Is CheckBox Or TypeOf Me.Controls(f) Is DateTimePicker Or TypeOf Me.Controls(f) Is ComboBox Then
                Me.Controls(f).Enabled = True
            End If
        Next
        BindingNavigatorAddNewItem.Enabled = False
        CXP_ProveedoresBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.CXP_ProveedoresBindingSource.Filter = "razonSocial like '%" & txtBuscaProveedor.Text & "%'"
    End Sub




    Private Sub btnCtasBancarias_Click(sender As Object, e As EventArgs) Handles btnCtasBancarias.Click
        Dim taUsuarios As New dsSeguridadTableAdapters.USUARIOTableAdapter
        Dim taProveedores As New dsProductionTableAdapters.CXP_ProveedoresTableAdapter
        Dim tipoPersona As String

        If taUsuarios.ExisteRfc_ScalarQuery(RfcTextBox.Text.Trim) = "NE" Or IsNothing(taUsuarios.ExisteRfc_ScalarQuery(RfcTextBox.Text.Trim)) Then
            If taProveedores.ObtClientProv_ScalarQuery(RfcTextBox.Text.Trim) = False Then
                If RfcTextBox.Text.Trim.Length = 12 Then
                    tipoPersona = "M"
                ElseIf RfcTextBox.Text.Trim.Length = 13 Then
                    tipoPersona = "F"
                End If
            Else
                tipoPersona = "C"
            End If
        Else
                tipoPersona = "E"
        End If

        Dim frmCuentasBancarias2 As New frmCuentasBancarias
        Dim mdictas As New mdicuentasPorPagar
        mdictas = MdiParent
        Me.Cursor = Cursors.WaitCursor
        Me.Enabled = False
        frmCuentasBancarias2.MdiParent = mdictas
        noProveedor = CXP_ProveedoresBindingSource.Current("idProveedor")
        frmCuentasBancarias2.NoProveedorParaCtasBancarias = noProveedor
        frmCuentasBancarias2.tipoPersonaParaCuentasProv = tipoPersona
        frmCuentasBancarias2.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CXP_ProveedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_ProveedoresBindingNavigatorSaveItem.Click
        Dim tableAdapterDocumentacionProv As New dsProductionTableAdapters.CXP_DocumentacionProvTableAdapter
        Dim tableAdapterProveedorArch As New dsProductionTableAdapters.CXP_ProveedoresArchTableAdapter
        Dim tableAdatpterCuentasBancarias As New dsProductionTableAdapters.CXP_CuentasBancariasProvTableAdapter
        Dim taUsuarios As New dsSeguridadTableAdapters.USUARIOTableAdapter
        Dim taProveedores As New dsProductionTableAdapters.CXP_ProveedoresTableAdapter

        FechaRegistroDateTimePicker.Value = Date.Now

        Dim tipoPersona As String = ""
        Dim mensaje As String = ""

        Try

            If taUsuarios.ExisteRfc_ScalarQuery(RfcTextBox.Text.Trim) = "NE" Or IsNothing(taUsuarios.ExisteRfc_ScalarQuery(RfcTextBox.Text.Trim)) Then
                If taProveedores.ObtClientProv_ScalarQuery(RfcTextBox.Text.Trim) = False Then
                    If RfcTextBox.Text.Trim.Length = 12 Then
                        tipoPersona = "M"
                    ElseIf RfcTextBox.Text.Trim.Length = 13 Then
                        tipoPersona = "F"
                    End If
                Else
                    tipoPersona = "C"
                End If
            Else
                tipoPersona = "E"
            End If

            Dim validacion As String = "SI"
            'valida RFC
            If RfcTextBox.Text <> String.Empty Then
                If Regex.IsMatch(RfcTextBox.Text.Trim, "^([A-ZÑ\x26]{3,4}([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1]))([A-Z\d]{3})?$") = False Then
                    MsgBox("Estructura del RFC cincorrecta.", MsgBoxStyle.Information, "")
                    validacion = "NO"
                    Exit Sub
                End If
            End If

            'valida CURP
            If CurpTextBox.Text.Trim <> String.Empty Then
                If Regex.IsMatch(CurpTextBox.Text.Trim, "^([a-zA-Z]{4,4}[0-9]{6}[a-zA-Z]{6,6}[0-9-a-zA-Z]{2})$") = False Then
                    MsgBox("Estructura de la clave CURP incorrecta.", MsgBoxStyle.Information, "")
                    validacion = "NO"
                    Exit Sub
                End If
            End If

            If validacion = "SI" Then
                If CDec(CXP_ProveedoresTableAdapter.ExisteRfc_ScalarQuery(RfcTextBox.Text.Trim)) = 0 Then
                    If cmbAutorizado.SelectedValue = "AUTORIZADO" Then
                        If tableAdapterDocumentacionProv.NoDoctosOblig_ScalarQuery(tipoPersona) <= tableAdapterProveedorArch.noDocOblig_ScalarQuery(IdProveedorTextBox.Text.Trim) Then
                            tableAdapterProveedorArch.CambiaEstatusAll_UpdateQuery(16, CXP_ProveedoresBindingSource.Current("idProveedor"))
                            tableAdatpterCuentasBancarias.CambiaEstatusAll_UpdateQuery(11, CXP_ProveedoresBindingSource.Current("idProveedor"))

                            insertaCuentaNuevaEnBanco(CXP_ProveedoresBindingSource.Current("idProveedor"), razonSocial)

                            CXP_ProveedoresBindingSource.Current("autorizaP1") = varGlobal_NombreUsuario
                            CXP_ProveedoresBindingSource.Current("autorizaP2") = autoriza2

                            notificaAutorizacion()

                            taProveedores.CambioEstatusActYAut_UpdateQuery(cmbAutorizado.SelectedValue, cmbActivo.SelectedValue, RelacionadoCheckBox.Checked, Date.Now, varGlobal_NombreUsuario, IdProveedorTextBox.Text.Trim)

                            'Me.Validate()
                            'Me.CXP_ProveedoresBindingSource.EndEdit()
                            'Me.TableAdapterManager.UpdateAll(Me.DsProduction)
                            noProveedor = CDec(CXP_ProveedoresBindingSource.Current("idProveedor"))

                        Else
                            MsgBox("El proveedor no cuenta con la documentación necesaria para ser autorizado.", MsgBoxStyle.Information, "")
                        End If
                    ElseIf cmbAutorizado.SelectedValue = "RECHAZADO" Then
                        CXP_ProveedoresBindingSource.Current("motivoRechazo") = InputBox("Motivo de rechazo: ")
                        notificaRechazo(CXP_ProveedoresBindingSource.Current("motivoRechazo"))
                        tableAdapterProveedorArch.CambiaEstatusAll_UpdateQuery(20, CDec(CXP_ProveedoresBindingSource.Current("idProveedor")))
                        tableAdatpterCuentasBancarias.CambiaEstatusAll_UpdateQuery(15, CDec(CXP_ProveedoresBindingSource.Current("idProveedor")))

                        taProveedores.CambioEstatusActYAut_UpdateQuery(cmbAutorizado.SelectedValue, cmbActivo.SelectedValue, RelacionadoCheckBox.Checked, Date.Now, varGlobal_NombreUsuario, IdProveedorTextBox.Text.Trim)
                        'Me.Validate()
                        'Me.CXP_ProveedoresBindingSource.EndEdit()
                        'Me.TableAdapterManager.UpdateAll(Me.DsProduction)
                        noProveedor = CDec(CXP_ProveedoresBindingSource.Current("idProveedor"))


                    Else
                        taProveedores.CambioEstatusActYAut_UpdateQuery(cmbAutorizado.SelectedValue, cmbActivo.SelectedValue, RelacionadoCheckBox.Checked, Date.Now, varGlobal_NombreUsuario, IdProveedorTextBox.Text.Trim)
                        'Me.Validate()
                        'Me.CXP_ProveedoresBindingSource.EndEdit()
                        'Me.TableAdapterManager.UpdateAll(Me.DsProduction)
                        noProveedor = CDec(CXP_ProveedoresBindingSource.Current("idProveedor"))
                    End If
                Else
                    If RfcTextBox.Text.Trim = "XAXX010101000" Or RfcTextBox.Text.Trim = "XAXX010101000" Then
                        If cmbAutorizado.SelectedValue = "AUTORIZADO" Then
                            If tableAdapterDocumentacionProv.NoDoctosOblig_ScalarQuery(tipoPersona) <= tableAdapterProveedorArch.noDocOblig_ScalarQuery(IdProveedorTextBox.Text.Trim) Then
                                tableAdapterProveedorArch.CambiaEstatusAll_UpdateQuery(16, CXP_ProveedoresBindingSource.Current("idProveedor"))
                                tableAdatpterCuentasBancarias.CambiaEstatusAll_UpdateQuery(11, CXP_ProveedoresBindingSource.Current("idProveedor"))
                                CXP_ProveedoresBindingSource.Current("autorizaP1") = varGlobal_NombreUsuario
                                CXP_ProveedoresBindingSource.Current("autorizaP2") = autoriza2

                                insertaCuentaNuevaEnBanco(CXP_ProveedoresBindingSource.Current("idProveedor"), razonSocial)

                                notificaAutorizacion()
                                taProveedores.CambioEstatusActYAut_UpdateQuery(cmbAutorizado.SelectedValue, cmbActivo.SelectedValue, RelacionadoCheckBox.Checked, Date.Now, varGlobal_NombreUsuario, IdProveedorTextBox.Text.Trim)
                                'Me.Validate()
                                'Me.CXP_ProveedoresBindingSource.EndEdit()
                                'Me.TableAdapterManager.UpdateAll(Me.DsProduction)
                                noProveedor = CDec(CXP_ProveedoresBindingSource.Current("idProveedor"))


                            Else
                                MsgBox("El proveedor no cuenta con la documentación necesaria para ser autorizado.", MsgBoxStyle.Information, "")
                                cmbAutorizado.SelectedValue = "EN PROCESO"
                            End If
                        ElseIf cmbAutorizado.SelectedValue = "RECHAZADO" Then
                            CXP_ProveedoresBindingSource.Current("motivoRechazo") = InputBox("Motivo de rechazo: ")
                            notificaRechazo(CXP_ProveedoresBindingSource.Current("motivoRechazo"))
                            tableAdapterProveedorArch.CambiaEstatusAll_UpdateQuery(20, CDec(CXP_ProveedoresBindingSource.Current("idProveedor")))
                            tableAdatpterCuentasBancarias.CambiaEstatusAll_UpdateQuery(15, CDec(CXP_ProveedoresBindingSource.Current("idProveedor")))
                            'Me.Validate()
                            'Me.CXP_ProveedoresBindingSource.EndEdit()
                            'Me.TableAdapterManager.UpdateAll(Me.DsProduction)
                            taProveedores.CambioEstatusActYAut_UpdateQuery(cmbAutorizado.SelectedValue, cmbActivo.SelectedValue, RelacionadoCheckBox.Checked, Date.Now, varGlobal_NombreUsuario, IdProveedorTextBox.Text.Trim)
                            noProveedor = CDec(CXP_ProveedoresBindingSource.Current("idProveedor"))


                        Else
                            'Me.Validate()
                            'Me.CXP_ProveedoresBindingSource.EndEdit()
                            'Me.TableAdapterManager.UpdateAll(Me.DsProduction)
                            taProveedores.CambioEstatusActYAut_UpdateQuery(cmbAutorizado.SelectedValue, cmbActivo.SelectedValue, RelacionadoCheckBox.Checked, Date.Now, varGlobal_NombreUsuario, IdProveedorTextBox.Text.Trim)
                            noProveedor = CDec(CXP_ProveedoresBindingSource.Current("idProveedor"))
                        End If
                    Else
                        If IdProveedorTextBox.Text.Trim = "-1" Then
                            MsgBox("El proveedor: " & RazonSocialTextBox.Text.Trim & " ya existe.")
                            Dim index As Integer = CXP_ProveedoresBindingSource.Find("rfc", RfcTextBox.Text.Trim)
                            CXP_ProveedoresBindingSource.CancelEdit()
                            CXP_ProveedoresBindingSource.Position = index
                            CXP_ProveedoresBindingSource.EndEdit()
                        Else
                            If cmbAutorizado.SelectedValue = "AUTORIZADO" Then
                                If tableAdapterDocumentacionProv.NoDoctosOblig_ScalarQuery(tipoPersona) <= tableAdapterProveedorArch.noDocOblig_ScalarQuery(IdProveedorTextBox.Text.Trim) Then
                                    tableAdapterProveedorArch.CambiaEstatusAll_UpdateQuery(16, CXP_ProveedoresBindingSource.Current("idProveedor"))
                                    tableAdatpterCuentasBancarias.CambiaEstatusAll_UpdateQuery(11, CXP_ProveedoresBindingSource.Current("idProveedor"))
                                    CXP_ProveedoresBindingSource.Current("autorizaP1") = varGlobal_NombreUsuario
                                    CXP_ProveedoresBindingSource.Current("autorizaP2") = autoriza2

                                    insertaCuentaNuevaEnBanco(CXP_ProveedoresBindingSource.Current("idProveedor"), razonSocial)

                                    notificaAutorizacion()
                                    'Me.Validate()
                                    'Me.CXP_ProveedoresBindingSource.EndEdit()
                                    'Me.TableAdapterManager.UpdateAll(Me.DsProduction)
                                    taProveedores.CambioEstatusActYAut_UpdateQuery(cmbAutorizado.SelectedValue, cmbActivo.SelectedValue, RelacionadoCheckBox.Checked, Date.Now, varGlobal_NombreUsuario, IdProveedorTextBox.Text.Trim)
                                    Try
                                        noProveedor = CDec(CXP_ProveedoresBindingSource.Current("idProveedor"))
                                    Catch
                                    End Try

                                Else
                                    MsgBox("El proveedor no cuenta con la documentación necesaria para ser autorizado.", MsgBoxStyle.Information, "")
                                    cmbAutorizado.SelectedValue = "EN PROCESO"
                                End If
                            ElseIf cmbAutorizado.SelectedValue = "RECHAZADO" Then
                                CXP_ProveedoresBindingSource.Current("motivoRechazo") = InputBox("Motivo de rechazo: ")
                                notificaRechazo(CXP_ProveedoresBindingSource.Current("motivoRechazo"))
                                tableAdapterProveedorArch.CambiaEstatusAll_UpdateQuery(20, CDec(CXP_ProveedoresBindingSource.Current("idProveedor")))
                                tableAdatpterCuentasBancarias.CambiaEstatusAll_UpdateQuery(15, CDec(CXP_ProveedoresBindingSource.Current("idProveedor")))
                                'Me.Validate()
                                'Me.CXP_ProveedoresBindingSource.EndEdit()
                                'Me.TableAdapterManager.UpdateAll(Me.DsProduction)
                                taProveedores.CambioEstatusActYAut_UpdateQuery(cmbAutorizado.SelectedValue, cmbActivo.SelectedValue, RelacionadoCheckBox.Checked, Date.Now, varGlobal_NombreUsuario, IdProveedorTextBox.Text.Trim)
                                Try
                                    noProveedor = CDec(CXP_ProveedoresBindingSource.Current("idProveedor"))
                                Catch
                                End Try

                            Else

                                'Me.Validate()
                                'Me.CXP_ProveedoresBindingSource.EndEdit()
                                'Me.TableAdapterManager.UpdateAll(Me.DsProduction)
                                taProveedores.CambioEstatusActYAut_UpdateQuery(cmbAutorizado.SelectedValue, cmbActivo.SelectedValue, RelacionadoCheckBox.Checked, Date.Now, varGlobal_NombreUsuario, IdProveedorTextBox.Text.Trim)

                                noProveedor = CDec(CXP_ProveedoresBindingSource.Current("idProveedor"))

                            End If
                        End If
                    End If
                End If
            End If
            Me.CXP_ProveedoresTableAdapter.Fill(Me.DsProduction.CXP_Proveedores)
            actualizar()

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub btnDocumentacion_Click(sender As Object, e As EventArgs) Handles btnDocumentacion.Click
        Try
            Dim taUsuarios As New dsSeguridadTableAdapters.USUARIOTableAdapter
            Dim taProveedores As New dsProductionTableAdapters.CXP_ProveedoresTableAdapter
            Dim tipoPersona As String


            If taUsuarios.ExisteRfc_ScalarQuery(RfcTextBox.Text.Trim) = "NE" Or IsNothing(taUsuarios.ExisteRfc_ScalarQuery(RfcTextBox.Text.Trim)) Then
                If taProveedores.ObtClientProv_ScalarQuery(RfcTextBox.Text.Trim) = False Then
                    If RfcTextBox.Text.Trim.Length = 12 Then
                        tipoPersona = "M"
                    ElseIf RfcTextBox.Text.Trim.Length = 13 Then
                        If RfcTextBox.Text.Trim = "XAXX010101000" Then
                            tipoPersona = "C"
                        Else
                            tipoPersona = "F"
                        End If
                    End If
                    Else
                    tipoPersona = "C"
                End If
            Else
                tipoPersona = "E"
            End If

            Dim frmDocumentacion As New frmDocumentosProv
            Dim mdiDocumentacion As New mdicuentasPorPagar
            mdiDocumentacion = MdiParent
            Me.Cursor = Cursors.WaitCursor
            Me.Enabled = False
            frmDocumentacion.MdiParent = mdiDocumentacion
            noProveedor = CXP_ProveedoresBindingSource.Current("idProveedor")
            frmDocumentacion.noProveedorParaDocumentosProv = noProveedor
            frmDocumentacion.tipoPersonaParaDocumentosProv = tipoPersona 'RfcTextBox.Text.Length
            frmDocumentacion.Show()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub notificaAutorizacion()
        Try
            Dim tableAdapterGenCorreos As New dsProductionTableAdapters.GEN_Correos_SistemaFinagilTableAdapter
            Dim mensaje As String = "<html><body><font size=3 face=" & Chr(34) & "Arial" & Chr(34) & ">" &
                       "<h1><font size=3 align" & Chr(34) & "center" & Chr(34) & ">" & "Estimado (a), le notificamos que se ha AUTORIZADO la solicitud de alta del proveedor con los siguientes datos: </font></h1>" &
                        "<table  align=" & Chr(34) & "center" & Chr(34) & " border=1 cellspacing=0 cellpadding=2>" &
                       "<tr>" &
                           "<td>Razón Social</td>" &
                           "<td>RFC</td>" &
                       "</tr>" &
                       "<tr>" &
                               "<td>" & RazonSocialTextBox.Text.Trim & "</td>" &
                               "<td>" & RfcTextBox.Text.Trim & "</td>" &
                           "</tr></table><HR width=20%>" &
                      "<tfoot><tr><font align=" & Chr(34) & "center" & Chr(34) & "size=3 face=" & Chr(34) & "Arial" & Chr(34) & ">" & "</font></tr></tfoot>" &
                        "</body></html>"
            tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", UsuarioSolicitaTextBox.Text.Trim, "Autorización de alta de proveedor", mensaje, False, Date.Now.ToLongDateString, "")
            tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", "viapolo@finagil.com.mx", "Autorización de alta de proveedor", mensaje, False, Date.Now.ToLongDateString, "")
            tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", "lgarcia@finagil.com.mx", "Autorización de alta de proveedor", mensaje, False, Date.Now.ToLongDateString, "")

            If UsuarioSolicitaTextBox.Text.Trim = "atorres@finagil.com.mx" Or UsuarioSolicitaTextBox.Text.Trim = "gisvazquez@finagil.com.mx" Then
                tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", "lgarcia@finagil.com.mx", "Autorización de alta de proveedor (Tesorería)", mensaje, False, Date.Now.ToLongDateString, "")
                tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", "vcruz@finagil.com.mx", "Autorización de alta de proveedor (Tesorería)", mensaje, False, Date.Now.ToLongDateString, "")
                tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", "epineda@finagil.com.mx", "Autorización de alta de proveedor (Tesorería)", mensaje, False, Date.Now.ToLongDateString, "")
                tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", "viapolo@finagil.com.mx", "Autorización de alta de proveedor (Tesorería)", mensaje, False, Date.Now.ToLongDateString, "")
            End If

        Catch ex As Exception
            MsgBox("Error al enviar correo de autorización" & ex.ToString)
        End Try
    End Sub

    Private Sub notificaRechazo(motivoRechazo As String)
        Try
            Dim tableAdapterGenCorreos As New dsProductionTableAdapters.GEN_Correos_SistemaFinagilTableAdapter
            Dim mensaje As String = "<html><body><font size=3 face=" & Chr(34) & "Arial" & Chr(34) & ">" &
                    "<h1><font size=3 align" & Chr(34) & "center" & Chr(34) & ">" & "Estimado (a), le notificamos que se ha RECHAZADO la solicitud de alta del proveedor con los siguientes datos: </font></h1>" &
                     "<table  align=" & Chr(34) & "center" & Chr(34) & " border=1 cellspacing=0 cellpadding=2>" &
                    "<tr>" &
                        "<td>Razón Social</td>" &
                        "<td>RFC</td>" &
                        "<td>Motivo de rechazo</td>" &
                    "</tr>" &
                    "<tr>" &
                            "<td>" & RazonSocialTextBox.Text.Trim & "</td>" &
                            "<td>" & RfcTextBox.Text.Trim & "</td>" &
                            "<td>" & motivoRechazo & "</td>" &
                        "</tr></table><HR width=20%>" &
                   "<tfoot><tr><font align=" & Chr(34) & "center" & Chr(34) & "size=3 face=" & Chr(34) & "Arial" & Chr(34) & ">" & "</font></tr></tfoot>" &
                     "</body></html>"
            tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", UsuarioSolicitaTextBox.Text.Trim, "Rechazo de alta de proveedor", mensaje, False, Date.Now.ToLongDateString, "")
            tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", "viapolo@finagil.com.mx", "Rechazo de alta de proveedor", mensaje, False, Date.Now.ToLongDateString, "")
            tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", "lgarcia@finagil.com.mx", "Rechazo de alta de proveedor", mensaje, False, Date.Now.ToLongDateString, "")
        Catch ex As Exception
            MsgBox("Error al enviar correo de rechaco" & ex.ToString)
        End Try
    End Sub

    Private Sub btnBuscarCmbs_Click(sender As Object, e As EventArgs) Handles btnBuscarCmbs.Click
        CXP_ProveedoresBindingSource.Filter = "autorizadoS = '" & cmbBuscaAutorizado.SelectedValue.ToString & "'"
    End Sub

    Private Sub RfcTextBox_TextChanged(sender As Object, e As EventArgs) Handles RfcTextBox.TextChanged
        actualizar()
    End Sub

    Private Sub main_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Control + Keys.D Then
            Call btnDocumentacion_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyData = Keys.Control + Keys.B Then
            Call btnCtasBancarias_Click(sender, e)
        End If
        If e.KeyData = Keys.Control + Keys.D Then
            Call btnDocumentacion_Click(sender, e)
        End If
    End Sub

    Private Sub FPagoInicialTextBox_TextChanged(sender As Object, e As EventArgs) Handles FPagoInicialTextBox.TextChanged
        FPagoInicialTextBox.Text = FPagoInicialTextBox.Text.Replace("True", "Cheque").Replace("False", "Transferencia")
    End Sub
End Class