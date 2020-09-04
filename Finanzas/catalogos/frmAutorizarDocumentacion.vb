Imports System.ComponentModel

Public Class frmAutorizarDocumentacion
    Public noProveedor As Integer
    Public idEstatus As Integer
    Public idProveedorArch As Integer
    Public tipoPersonaDocumentosAutoriza As String
    Dim autoriza2 As String = "viapolo@finagil.com.mx"

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmAutorizarDocumentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Vw_CXP_DocumentacionProvTableAdapter.Fill(Me.DsProduction.Vw_CXP_DocumentacionProv, New System.Nullable(Of Decimal)(CType(noProveedor, Decimal)))
            Vw_CXP_DocumentacionProvBindingSource.Filter = "idProveedoresArch = '" & idProveedorArch.ToString & "'"
            If Vw_CXP_DocumentacionProvBindingSource.Current("estatus") = 19 Then
                btnAutorizar.Text = "Autorizar Bloqueo"
                btnRechazar.Text = "Rechazar Bloqueo"
            ElseIf Vw_CXP_DocumentacionProvBindingSource.Current("estatus") = 17 Then
                btnAutorizar.Text = "Autorizar Activación"
                btnRechazar.Text = "Rechazar Activación"
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDocumento.LinkClicked
        Process.Start(My.Settings.fileNas & "CXP\FilesProv\" & Vw_CXP_DocumentacionProvBindingSource.Current("uuid") & ".pdf")
    End Sub

    Private Sub btnAutorizar_Click(sender As Object, e As EventArgs) Handles btnAutorizar.Click
        Dim tableAdapterDocumentacion As New dsProductionTableAdapters.CXP_ProveedoresArchTableAdapter
        Try
            If Vw_CXP_DocumentacionProvBindingSource.Current("estatus") = 19 Then
                tableAdapterDocumentacion.CambiaEstatus_UpdateQuery(18, varGlobal_NombreUsuario, Date.Now, idProveedorArch)
                MsgBox("Autorización de bloqueo de documento enviada correctamente", MsgBoxStyle.Information, "")
                enviaCorreoDocumentos(Vw_CXP_DocumentacionProvBindingSource.Current("descripcion"), Vw_CXP_DocumentacionProvBindingSource.Current("razonSocial"), Vw_CXP_DocumentacionProvBindingSource.Current("rfc"), Vw_CXP_DocumentacionProvBindingSource.Current("sn1"), "autorizada la solicitud de bloqueo ", "Autorización de bloqueo", "", varGlobal_NombreUsuario, Vw_CXP_DocumentacionProvBindingSource.Current("sm2"), Vw_CXP_DocumentacionProvBindingSource.Current("uuid"))
                'enviaCorreoDocumentosA2(Vw_CXP_DocumentacionProvBindingSource.Current("razonSocial"), Vw_CXP_DocumentacionProvBindingSource.Current("rfc"), Vw_CXP_DocumentacionProvBindingSource.Current("sn1"), "preautorizado la solicitud de BLOQUEO del documento ", "Solicitud de bloqueo", Vw_CXP_DocumentacionProvBindingSource.Current("descripcion"), idProveedorArch, autoriza2, Vw_CXP_DocumentacionProvBindingSource.Current("uuid"))
                validaYCambiaEstatus(noProveedor, Vw_CXP_DocumentacionProvBindingSource.Current("rfc"))
                Me.Close()
            ElseIf Vw_CXP_DocumentacionProvBindingSource.Current("estatus") = 17 Then
                tableAdapterDocumentacion.CambiaEstatus_UpdateQuery(16, varGlobal_NombreUsuario, Date.Now, idProveedorArch)
                MsgBox("Autorización de activación de documento enviada correctamente", MsgBoxStyle.Information, "")
                enviaCorreoDocumentos(Vw_CXP_DocumentacionProvBindingSource.Current("descripcion"), Vw_CXP_DocumentacionProvBindingSource.Current("razonSocial"), Vw_CXP_DocumentacionProvBindingSource.Current("rfc"), Vw_CXP_DocumentacionProvBindingSource.Current("sn1"), "autorizada la solicitud de activación ", "Autorización de activación", "", varGlobal_NombreUsuario, Vw_CXP_DocumentacionProvBindingSource.Current("sm1"), Vw_CXP_DocumentacionProvBindingSource.Current("uuid"))
                'enviaCorreoDocumentosA2(Vw_CXP_DocumentacionProvBindingSource.Current("razonSocial"), Vw_CXP_DocumentacionProvBindingSource.Current("rfc"), Vw_CXP_DocumentacionProvBindingSource.Current("sn1"), "preautorizado la solicitud de ACTIVACIÖN del documento ", "Solicitud de activación", Vw_CXP_DocumentacionProvBindingSource.Current("descripcion"), idProveedorArch, autoriza2, Vw_CXP_DocumentacionProvBindingSource.Current("uuid"))
                validaYCambiaEstatus(noProveedor, Vw_CXP_DocumentacionProvBindingSource.Current("rfc"))
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click
        Dim tableAdapterDocumentacion As New dsProductionTableAdapters.CXP_ProveedoresArchTableAdapter
        Try
            If Vw_CXP_DocumentacionProvBindingSource.Current("estatus") = 19 Then
                tableAdapterDocumentacion.CambiaEstatus_UpdateQuery(16, varGlobal_NombreUsuario, Date.Now, idProveedorArch)
                Dim comentarios As String = InputBox("Motivo de rechazo", "", "Sin Comentarios")
                enviaCorreoDocumentos(Vw_CXP_DocumentacionProvBindingSource.Current("descripcion"), Vw_CXP_DocumentacionProvBindingSource.Current("razonSocial"), Vw_CXP_DocumentacionProvBindingSource.Current("rfc"), Vw_CXP_DocumentacionProvBindingSource.Current("sn1"), "rechazado la solicitud de bloqueo ", "Rechazo de bloqueo", comentarios, varGlobal_NombreUsuario, Vw_CXP_DocumentacionProvBindingSource.Current("sm1"), Vw_CXP_DocumentacionProvBindingSource.Current("uuid"))
                MsgBox("Preautorización de bloqueo rechazada correctamente", MsgBoxStyle.Information, "")
                validaYCambiaEstatus(noProveedor, Vw_CXP_DocumentacionProvBindingSource.Current("rfc"))
                Me.Close()

            ElseIf Vw_CXP_DocumentacionProvBindingSource.Current("estatus") = 17 Then
                tableAdapterDocumentacion.CambiaEstatus_UpdateQuery(20, varGlobal_NombreUsuario, Date.Now, idProveedorArch)
                Dim comentarios As String = InputBox("Motivo de rechazo", "", "Sin Comentarios")
                enviaCorreoDocumentos(Vw_CXP_DocumentacionProvBindingSource.Current("descripcion"), Vw_CXP_DocumentacionProvBindingSource.Current("razonSocial"), Vw_CXP_DocumentacionProvBindingSource.Current("rfc"), Vw_CXP_DocumentacionProvBindingSource.Current("sn1"), "rechazado la solicitud de activación ", "Rechazo de activación", comentarios, varGlobal_NombreUsuario, Vw_CXP_DocumentacionProvBindingSource.Current("sm1"), Vw_CXP_DocumentacionProvBindingSource.Current("uuid"))
                MsgBox("Preautorización de activación rechazada correctamente", MsgBoxStyle.Information, "")
                validaYCambiaEstatus(noProveedor, Vw_CXP_DocumentacionProvBindingSource.Current("rfc"))
                Me.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Protected Sub enviaCorreoDocumentos(documento As String, razonSocial As String, rfc As String, solicitante As String, textoEncabezado As String, asuntoMensaje As String, comentarios As String, preautorizante As String, mailDestinatario As String, attachDocto As String)
        Dim tableAdapterGenCorreos As New dsProductionTableAdapters.GEN_Correos_SistemaFinagilTableAdapter

        Dim mensaje As String = "<html><body><font size=3 face=" & Chr(34) & "Arial" & Chr(34) & ">" &
                    "<h1><font size=3 align" & Chr(34) & "center" & Chr(34) & ">" & "Estimado (a), le notificamos que se ha " & textoEncabezado & " del siguiente documento con los siguientes datos: </font></h1>" &
                     "<table  align=" & Chr(34) & "center" & Chr(34) & " border=1 cellspacing=0 cellpadding=2>" &
                    "<tr>" &
                        "<td>Razón Social</td>" &
                        "<td>" & razonSocial & "</td>" &
                    "</tr>" &
                    "<tr>" &
                        "<td>RFC</td>" &
                        "<td>" & rfc & "</td>" &
                    "</tr>" &
                    "<tr>" &
                        "<td>Documento</td>" &
                        "<td>" & documento & "</td>" &
                    "</tr>" &
                    "<tr>" &
                        "<td>Comentarios adicionales</td>" &
                        "<td>" & comentarios & "</td>" &
                    "</tr>" &
                    "</table><HR width=20%>" &
                   "<tfoot><tr><font align=" & Chr(34) & "center" & Chr(34) & "size=3 face=" & Chr(34) & "Arial" & Chr(34) & ">" & "Solicitante: " & solicitante & vbNewLine & "</font></tr></tfoot>" &
                     "</body></html>"
        tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", mailDestinatario, asuntoMensaje, mensaje, False, Date.Now.ToLongDateString, "")
        tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", "viapolo@finagil.com.mx", asuntoMensaje, mensaje, False, Date.Now.ToLongDateString, "")
        If mailDestinatario = "atorres@finagil.com.mx" Or mailDestinatario = "gizvazquez@finagil.com.mx" Then
            tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", "viapolo@finagil.com.mx", asuntoMensaje & " (Tesorería)", mensaje, False, Date.Now.ToLongDateString, "CXP\FilesProv\" & attachDocto & ".pdf")
            tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", "epineda@finagil.com.mx", asuntoMensaje & " (Tesorería)", mensaje, False, Date.Now.ToLongDateString, "CXP\FilesProv\" & attachDocto & ".pdf")
            tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", "vcruz@finagil.com.mx", asuntoMensaje & " (Tesorería)", mensaje, False, Date.Now.ToLongDateString, "CXP\FilesProv\" & attachDocto & ".pdf")
            tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", "lgarcia@finagil.com.mx", asuntoMensaje & " (Tesorería)", mensaje, False, Date.Now.ToLongDateString, "CXP\FilesProv\" & attachDocto & ".pdf")
        End If
    End Sub

    Protected Sub enviaCorreoDocumentosA2(razonSocial As String, rfc As String, solicitante As String, textoEncabezado As String, asuntoMensaje As String, documento As String, idProveedoresArch As String, mailAutoriza2 As String, uuid As String)
        Dim tableAdapterGenCorreos As New dsProductionTableAdapters.GEN_Correos_SistemaFinagilTableAdapter

        Dim mensaje As String = "<html><body><font size=3 face=" & Chr(34) & "Arial" & Chr(34) & ">" &
                    "<h1><font size=3 align" & Chr(34) & "center" & Chr(34) & ">" & "Estimado (a), le notificamos que se ha " & textoEncabezado & " con los siguientes datos: </font></h1>" &
                     "<table  align=" & Chr(34) & "center" & Chr(34) & " border=1 cellspacing=0 cellpadding=2>" &
                    "<tr>" &
                        "<td>Razón Social</td>" &
                        "<td>" & razonSocial & "</td>" &
                    "</tr>" &
                    "<tr>" &
                        "<td>RFC</td>" &
                        "<td>" & rfc & "</td>" &
                    "</tr>" &
                    "<tr>" &
                        "<td>Documento</td>" &
                        "<td>" & documento & "</td>" &
                    "</tr>" &
                    "<tr>" &
                        "<td><A HREF='https://finagil.com.mx/WEBtasas/aut2TwoPrvDtos.aspx?idProveedoresArch=" & idProveedoresArch.ToString & "&uuid=" & uuid & "&mailAutoriza2=" & mailAutoriza2 & "'>Liga para Autorización.</A></td>" &
                    "</tr>" &
                   "</table><HR width=20%>" &
                    "<tfoot><tr><font align=" & Chr(34) & "center" & Chr(34) & "size=3 face=" & Chr(34) & "Arial" & Chr(34) & ">" & "Solicitante: " & solicitante & vbNewLine & "</font></tr></tfoot>" &
                     "</body></html>"
        tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", mailAutoriza2, asuntoMensaje, mensaje, False, Date.Now.ToLongDateString, "")
    End Sub

    Protected Sub validaYCambiaEstatus(idProveedor As String, rfcP As String)
        Dim taCtas As New dsProductionTableAdapters.CXP_CuentasBancariasProvTableAdapter
        Dim taDctos As New dsProductionTableAdapters.CXP_ProveedoresArchTableAdapter
        Dim taProv As New dsProductionTableAdapters.CXP_ProveedoresTableAdapter
        Dim taDocn As New dsProductionTableAdapters.CXP_DocumentacionProvTableAdapter
        'Dim tipoPersona As String = ""

        'If rfcP.Length = 12 Then
        '    tipoPersona = "M"
        'ElseIf rfcP.Length = 13 Then
        '    tipoPersona = "F"
        'End If

        If taDctos.noDocObligXProv_ScalarQuery(idProveedor) = taDocn.NoDoctosOblig_ScalarQuery(tipoPersonaDocumentosAutoriza) Then
            If IsNothing(taCtas.Contador_ScalarQuery(idProveedor)) And IsNothing(taDctos.Contador_ScalarQuery(idProveedor)) Then
                taProv.CambiaEstatus_UpdateQuery("AUTORIZADO", idProveedor)
            End If
        End If

    End Sub

    Private Sub frmAutorizarDocumentacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmDocumentosProv.Refresh()
    End Sub

    Private Sub frmAutorizarDocumentacion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class