Imports System.ComponentModel

Public Class frmCargPagNoCie
    Public tipoSolicitud As String
    Public folioSolicitud As String
    Public idBanco As String
    Public tdc As String
    Public referencia As String
    Private Sub frmCargPagNoCie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubirComprobante_Click(sender As Object, e As EventArgs) Handles btnSubirComprobante.Click
        contadorPagosTes = 0
        Dim filePath As String = ""
        ofdPdfConfirmacion.Filter = "pdf|*.pdf|PDF|*.PDF"
        Dim guuid As String = Guid.NewGuid.ToString

        If ofdPdfConfirmacion.ShowDialog() = DialogResult.OK Then
            Try
                filePath = ofdPdfConfirmacion.FileName
                extraePaginaSharp(filePath, My.Settings.fileNas & "CXP\ComPago\", guuid, tdc, folioSolicitud, tipoSolicitud, idBanco, referencia)

                System.IO.File.Copy(ofdPdfConfirmacion.FileName, My.Settings.fileNas & "CXP\ComPago\ComOriginales\" & guuid & ".pdf")

                MsgBox("Proceso terminado..." & vbNewLine & "Páginas comprobante: " & contadorPagosPag.ToString & vbNewLine & "Documentos confirmados: " & contadorPagosTes.ToString, MsgBoxStyle.Information, "")

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
            End Try
        Else
            MsgBox("Proceso cancelado", MsgBoxStyle.Information, "")
        End If
        Me.Close()
    End Sub

    Private Sub frmCargPagNoCie_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmTesSolicitudesDePago.Enabled = True
    End Sub

    Private Sub frmCargPagNoCie_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmTesSolicitudesDePago.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class