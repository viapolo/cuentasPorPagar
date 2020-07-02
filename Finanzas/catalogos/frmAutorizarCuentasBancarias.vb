Imports System.ComponentModel

Public Class frmAutorizarCuentasBancarias
    Public noProveedor As Integer
    Public idCuentas As Integer
    Public idEstatus As Integer
    Public tipoPersonaCuentasAutoriza As String
    Dim autoriza2 As String = "viapolo@finagil.com.mx"

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmAutorizarCuentasBancarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Vw_CXP_CuentasBancariasProvTableAdapter.Fill(Me.DsProduction.Vw_CXP_CuentasBancariasProv, New System.Nullable(Of Decimal)(CType(noProveedor, Decimal)))
            Vw_CXP_CuentasBancariasProvBindingSource.Filter = "idCuentas = '" & idCuentas & "'"
            'If Vw_CXP_CuentasBancariasProvBindingSource.Current("estatus") = 14 Then
            '    btnAutorizar.Text = "Preautorizar Bloqueo"
            '    btnRechazar.Text = "Rechazar Bloqueo"
            'ElseIf Vw_CXP_CuentasBancariasProvBindingSource.Current("estatus") = 12 Then
            '    btnAutorizar.Text = "Preautorizar Activación"
            '    btnRechazar.Text = "Rechazar Activación"
            'End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lnkCuenta_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCuenta.LinkClicked
        Process.Start(My.Settings.fileNas & "CXP\FilesProv\" & Vw_CXP_CuentasBancariasProvBindingSource.Current("archivo1") & ".pdf")
    End Sub

    Private Sub btnAutorizar_Click(sender As Object, e As EventArgs) Handles btnAutorizar.Click
        Dim tableAdapterCuentAsProv As New dsProductionTableAdapters.CXP_CuentasBancariasProvTableAdapter
        Try
            If Vw_CXP_CuentasBancariasProvBindingSource.Current("estatus") = 14 Then
                tableAdapterCuentAsProv.CambiaEstatus_UpdateQuery(13, varGlobal_NombreUsuario, Date.Now, idCuentas)
                MsgBox("Autorización de bloqueo de documento enviada correctamente", MsgBoxStyle.Information, "")
                enviaCorreoDocumentos(Vw_CXP_CuentasBancariasProvBindingSource.Current("nombreCorto"), Vw_CXP_CuentasBancariasProvBindingSource.Current("c_NombreMoneda"), Vw_CXP_CuentasBancariasProvBindingSource.Current("cuenta"), Vw_CXP_CuentasBancariasProvBindingSource.Current("clabe"), Vw_CXP_CuentasBancariasProvBindingSource.Current("razonSocial"), Vw_CXP_CuentasBancariasProvBindingSource.Current("rfc"), Vw_CXP_CuentasBancariasProvBindingSource.Current("sn1"), "autorizada la solicitud de bloqueo ", "Autorización de activación", "", varGlobal_NombreUsuario, Vw_CXP_CuentasBancariasProvBindingSource.Current("sm1"))
                'enviaCorreoDocumentosA2(Vw_CXP_CuentasBancariasProvBindingSource.Current("razonSocial"), Vw_CXP_CuentasBancariasProvBindingSource.Current("rfc"), Vw_CXP_CuentasBancariasProvBindingSource.Current("sn1"), "enviado una solicitud de BLOQUEO de cuenta ", "Solicitud de bloqueo de cuenta bancaria", Vw_CXP_CuentasBancariasProvBindingSource.Current("nombreCorto"), Vw_CXP_CuentasBancariasProvBindingSource.Current("c_NombreMoneda"), Vw_CXP_CuentasBancariasProvBindingSource.Current("cuenta"), Vw_CXP_CuentasBancariasProvBindingSource.Current("clabe"), idCuentas, autoriza2, Vw_CXP_CuentasBancariasProvBindingSource.Current("archivo1"))
                validaYCambiaEstatus(noProveedor, Vw_CXP_CuentasBancariasProvBindingSource.Current("rfc"))
                Me.Close()
            ElseIf Vw_CXP_CuentasBancariasProvBindingSource.Current("estatus") = 12 Then
                tableAdapterCuentAsProv.CambiaEstatus_UpdateQuery(11, varGlobal_NombreUsuario, Date.Now, idCuentas)
                MsgBox("Autorización de activación de documento enviada correctamente", MsgBoxStyle.Information, "")
                enviaCorreoDocumentos(Vw_CXP_CuentasBancariasProvBindingSource.Current("nombreCorto"), Vw_CXP_CuentasBancariasProvBindingSource.Current("c_NombreMoneda"), Vw_CXP_CuentasBancariasProvBindingSource.Current("cuenta"), Vw_CXP_CuentasBancariasProvBindingSource.Current("clabe"), Vw_CXP_CuentasBancariasProvBindingSource.Current("razonSocial"), Vw_CXP_CuentasBancariasProvBindingSource.Current("rfc"), Vw_CXP_CuentasBancariasProvBindingSource.Current("sn1"), "autorizado la solicitud de activación ", "Autorización de activación", "", varGlobal_NombreUsuario, Vw_CXP_CuentasBancariasProvBindingSource.Current("sm1"))
                'enviaCorreoDocumentosA2(Vw_CXP_CuentasBancariasProvBindingSource.Current("razonSocial"), Vw_CXP_CuentasBancariasProvBindingSource.Current("rfc"), Vw_CXP_CuentasBancariasProvBindingSource.Current("sn1"), "enviado una solicitud de ACTIVACIÖN de cuenta ", "Solicitud de activación de cuenta bancaria", Vw_CXP_CuentasBancariasProvBindingSource.Current("nombreCorto"), Vw_CXP_CuentasBancariasProvBindingSource.Current("c_NombreMoneda"), Vw_CXP_CuentasBancariasProvBindingSource.Current("cuenta"), Vw_CXP_CuentasBancariasProvBindingSource.Current("clabe"), idCuentas, autoriza2, Vw_CXP_CuentasBancariasProvBindingSource.Current("archivo1"))
                validaYCambiaEstatus(noProveedor, Vw_CXP_CuentasBancariasProvBindingSource.Current("rfc"))
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try

    End Sub

    Protected Sub enviaCorreoDocumentos(banco As String, moneda As String, cuenta As String, clabe As String, razonSocial As String, rfc As String, solicitante As String, textoEncabezado As String, asuntoMensaje As String, comentarios As String, preautorizante As String, mailDestinatario As String)
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
                        "<td>Banco</td>" &
                        "<td>" & banco & "</td>" &
                    "</tr>" &
                    "<tr>" &
                        "<td>Moneda</td>" &
                        "<td>" & moneda & "</td>" &
                    "</tr>" &
                    "<tr>" &
                        "<td>Cuenta</td>" &
                        "<td>" & cuenta & "</td>" &
                    "</tr>" &
                    "<tr>" &
                        "<td>CLABE</td>" &
                        "<td>" & clabe & "</td>" &
                    "</tr>" &
                     "<tr>" &
                        "<td>Comentarios</td>" &
                        "<td>" & comentarios & "</td>" &
                    "</tr>" &
                    "</table><HR width=20%>" &
                    "<tfoot><tr><font align=" & Chr(34) & "center" & Chr(34) & "size=3 face=" & Chr(34) & "Arial" & Chr(34) & ">" & "Solicitante: " & solicitante & vbNewLine & "</font></tr></tfoot>" &
                     "</body></html>"
        tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", mailDestinatario, asuntoMensaje, mensaje, False, Date.Now.ToLongDateString, "")
    End Sub


    Protected Sub enviaCorreoDocumentosA2(razonSocial As String, rfc As String, solicitante As String, textoEncabezado As String, asuntoMensaje As String, banco As String, moneda As String, cuenta As String, clabe As String, idCuentas As String, mailAutoriza2 As String, archivo1 As String)
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
                        "<td>Banco</td>" &
                        "<td>" & banco & "</td>" &
                    "</tr>" &
                    "<tr>" &
                        "<td>Moneda</td>" &
                        "<td>" & moneda & "</td>" &
                    "</tr>" &
                    "<tr>" &
                        "<td>Cuenta</td>" &
                        "<td>" & cuenta & "</td>" &
                    "</tr>" &
                    "<tr>" &
                        "<td>CLABE</td>" &
                        "<td>" & clabe & "</td>" &
                    "</tr>" &
                    "<tr>" &
                        "<td><A HREF='https://finagil.com.mx/WEBtasas/aut2TwoPrvCtas.aspx?idCuentas=" & idCuentas.ToString & "&archivo1=" & archivo1 & "&mailAutoriza2=" & mailAutoriza2 & "'>Liga para Autorización.</A></td>" &
                    "</tr>" &
                   "</table><HR width=20%>" &
                    "<tfoot><tr><font align=" & Chr(34) & "center" & Chr(34) & "size=3 face=" & Chr(34) & "Arial" & Chr(34) & ">" & "Solicitante: " & solicitante & vbNewLine & "</font></tr></tfoot>" &
                     "</body></html>"
        tableAdapterGenCorreos.Insert("AltaProveedores@finagil.com.mx", mailAutoriza2, asuntoMensaje, mensaje, False, Date.Now.ToLongDateString, "")
    End Sub


    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click
        Dim tableAdapterCuentas As New dsProductionTableAdapters.CXP_CuentasBancariasProvTableAdapter

        Try
            If Vw_CXP_CuentasBancariasProvBindingSource.Current("estatus") = 14 Then
                tableAdapterCuentas.CambiaEstatus_UpdateQuery(11, varGlobal_NombreUsuario, Date.Now, idCuentas)
                Dim comentarios As String = InputBox("Motivo de rechazo", "", "")
                'enviaCorreoDocumentos(Vw_CXP_CuentasBancariasProvBindingSource.Current("descripcion"), Vw_CXP_CuentasBancariasProvBindingSource.Current("razonSocial"), Vw_CXP_CuentasBancariasProvBindingSource.Current("rfc"), Vw_CXP_CuentasBancariasProvBindingSource.Current("sn1"), "rechazado la solicitud de bloqueo ", "Rechazo de bloqueo", comentarios, varGlobal_NombreUsuario, Vw_CXP_CuentasBancariasProvBindingSource.Current("sm1"))
                enviaCorreoDocumentos(Vw_CXP_CuentasBancariasProvBindingSource.Current("nombreCorto"), Vw_CXP_CuentasBancariasProvBindingSource.Current("c_NombreMoneda"), Vw_CXP_CuentasBancariasProvBindingSource.Current("cuenta"), Vw_CXP_CuentasBancariasProvBindingSource.Current("clabe"), Vw_CXP_CuentasBancariasProvBindingSource.Current("razonSocial"), Vw_CXP_CuentasBancariasProvBindingSource.Current("rfc"), Vw_CXP_CuentasBancariasProvBindingSource.Current("sn1"), "rechazada la solicitud de bloqueo ", "Rechazo de bloqueo", comentarios, varGlobal_NombreUsuario, Vw_CXP_CuentasBancariasProvBindingSource.Current("sm1"))
                MsgBox("Autorización de bloqueo rechazada correctamente", MsgBoxStyle.Information, "")
                validaYCambiaEstatus(noProveedor, Vw_CXP_CuentasBancariasProvBindingSource.Current("rfc"))
                Me.Close()

            ElseIf Vw_CXP_CuentasBancariasProvBindingSource.Current("estatus") = 12 Then
                tableAdapterCuentas.CambiaEstatus_UpdateQuery(15, varGlobal_NombreUsuario, Date.Now, idCuentas)
                Dim comentarios As String = InputBox("Motivo de rechazo", "", "")
                'enviaCorreoDocumentos(Vw_CXP_CuentasBancariasProvBindingSource.Current("descripcion"), Vw_CXP_CuentasBancariasProvBindingSource.Current("razonSocial"), Vw_CXP_CuentasBancariasProvBindingSource.Current("rfc"), Vw_CXP_CuentasBancariasProvBindingSource.Current("sn1"), "rechazado la solicitud de activación ", "Rechazo de activación", comentarios, varGlobal_NombreUsuario, Vw_CXP_CuentasBancariasProvBindingSource.Current("sm1"))
                enviaCorreoDocumentos(Vw_CXP_CuentasBancariasProvBindingSource.Current("nombreCorto"), Vw_CXP_CuentasBancariasProvBindingSource.Current("c_NombreMoneda"), Vw_CXP_CuentasBancariasProvBindingSource.Current("cuenta"), Vw_CXP_CuentasBancariasProvBindingSource.Current("clabe"), Vw_CXP_CuentasBancariasProvBindingSource.Current("razonSocial"), Vw_CXP_CuentasBancariasProvBindingSource.Current("rfc"), Vw_CXP_CuentasBancariasProvBindingSource.Current("sn1"), "rechazada la solicitud de activación ", "Rechazo de activación", comentarios, varGlobal_NombreUsuario, Vw_CXP_CuentasBancariasProvBindingSource.Current("sm1"))
                MsgBox("Autorización de activación rechazada correctamente", MsgBoxStyle.Information, "")
                validaYCambiaEstatus(noProveedor, Vw_CXP_CuentasBancariasProvBindingSource.Current("rfc"))
                Me.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
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

        If taDctos.noDocObligXProv_ScalarQuery(idProveedor) = taDocn.NoDoctosOblig_ScalarQuery(tipoPersonaCuentasAutoriza) Then
            If IsNothing(taCtas.Contador_ScalarQuery(idProveedor)) And IsNothing(taDctos.Contador_ScalarQuery(idProveedor)) Then
                taProv.CambiaEstatus_UpdateQuery("AUTORIZADO", idProveedor)
            End If
        End If

    End Sub


    Private Sub frmAutorizarCuentasBancarias_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub


End Class