Public Class frmCancelaMovimiento
    Public folioSolicitudCan As String
    Public tipoSolicitudCan As String
    Public importeCan As String
    Public estatusSolicitud As String
    Public idBancoOrigenCan As String
    Dim taPagosTesoreria As New dsTesoreriaTableAdapters.CXP_PagosTesoreriaTableAdapter
    Dim taPagos As New dsTesoreriaTableAdapters.CXP_PagosTableAdapter
    Dim taCorreosFinagil As New dsTesoreriaTableAdapters.GEN_Correos_SistemaFinagilTableAdapter
    Dim taDatosUsuarios As New dsTesoreriaTableAdapters.DatosUsuarioSolicitaTableAdapter


    Private Sub frmCancelaMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLeyenda.Text = "El folio: " & tipoSolicitudCan & " - " & folioSolicitudCan & " (" & FormatCurrency(importeCan).ToString & ") está por cancelarse, ¿Confirma proceso?"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmCancelaMovimiento_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmTesSolicitudesDePago.Enabled = True
    End Sub

    Private Sub frmCancelaMovimiento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmTesSolicitudesDePago.Enabled = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim dtDatosUaurios As New dsTesoreria.DatosUsuarioSolicitaDataTable
        Dim drDatosUaurios As dsTesoreria.DatosUsuarioSolicitaRow

        Try
            If tipoSolicitudCan = "TRA" Or tipoSolicitudCan = "FAC" Or tipoSolicitudCan = "AVI" Then
                If estatusSolicitud = "33" Then
                    taPagosTesoreria.CambiaEstatusPagoTdc_UpdateQuery(35, SqlTypes.SqlDateTime.Null, idBancoOrigenCan, Nothing, importeCan, 33, folioSolicitudCan, tipoSolicitudCan)
                Else
                    taPagosTesoreria.CambiaEstatusPagoTdc_UpdateQuery(33, SqlTypes.SqlDateTime.Null, idBancoOrigenCan, Nothing, importeCan, 37, folioSolicitudCan, tipoSolicitudCan)
                End If
            Else
                taPagosTesoreria.CambiaEstatusPagoTdc_UpdateQuery(33, SqlTypes.SqlDateTime.Null, Nothing, Nothing, importeCan, 37, folioSolicitudCan, tipoSolicitudCan)
            End If

            If tipoSolicitudCan = "CXP" Then
                taDatosUsuarios.Fill(dtDatosUaurios, folioSolicitudCan, varGlobal_IdEmpresa)
                If dtDatosUaurios.Rows.Count > 0 Then
                    drDatosUaurios = dtDatosUaurios.Rows(0)
                    taPagos.CambiaEstatus_UpdateQuery("No Pagada", folioSolicitudCan, "En Proceso de Pago", varGlobal_IdEmpresa)
                    If chkNotificaCancelacion.Checked = False Then
                        taCorreosFinagil.Insert("notificaciones@finagil.com.mx", drDatosUaurios.mail, "Cancelación del proceso de pago CXP-" & folioSolicitudCan, "Se ha realizado la cancelación del proceso de pago de la solicitud CXP-" & folioSolicitudCan & vbNewLine & "Por el siguiente motivo: " & txtMotivoRechazo.Text.Trim, False, Date.Now, "")
                        taCorreosFinagil.Insert("notificaciones@finagil.com.mx", "viapolo@finagil.com.mx", "Cancelación del proceso de pago CXP-" & folioSolicitudCan, "Se ha realizado la cancelación del proceso de pago de la solicitud CXP-" & folioSolicitudCan & vbNewLine & "Por el siguiente motivo: " & txtMotivoRechazo.Text.Trim, False, Date.Now, "")
                    Else
                        taCorreosFinagil.Insert("notificaciones@finagil.com.mx", drDatosUaurios.mail, "Cancelación del proceso de pago CXP-" & folioSolicitudCan, "Se ha realizado la cancelación del proceso de pago de la solicitud CXP-" & folioSolicitudCan & vbNewLine & "Por el siguiente motivo: " & txtMotivoRechazo.Text.Trim & vbNewLine & "**** FAVOR DE CANCELAR LA SOLICITUD Y EMITIRLA NUEVAMENTE", False, Date.Now, "")
                        taCorreosFinagil.Insert("notificaciones@finagil.com.mx", "viapolo@finagil.com.mx", "Cancelación del proceso de pago CXP-" & folioSolicitudCan, "Se ha realizado la cancelación del proceso de pago de la solicitud CXP-" & folioSolicitudCan & vbNewLine & "Por el siguiente motivo: " & txtMotivoRechazo.Text.Trim & vbNewLine & "**** FAVOR DE CANCELAR LA SOLICITUD Y EMITIRLA NUEVAMENTE", False, Date.Now, "")
                    End If
                End If
            End If
            MsgBox("Proceso termiando", MsgBoxStyle.Information, "")
            frmTesSolicitudesDePago.actualizaGrid()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub
End Class