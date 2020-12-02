
Imports System.ComponentModel

Public Class frmDocumentosAdjuntos
    Public idSolPago As String
    Public tipoSolicitud As String
    Private Sub frmDocumentosAdjuntos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If tipoSolicitud = "CXP" Then
        'TODO: esta línea de código carga datos en la tabla 'DsTesoreria.CXP_Pagos' Puede moverla o quitarla según sea necesario.
        Me.CXP_PagosTableAdapter.DocumentosAdjuntos_FillBy(Me.DsTesoreria.CXP_Pagos, idSolPago, varGlobal_IdEmpresa)
        'End If
        lnkFolioSolicitud.Text = idSolPago
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmDocumentosAdjuntos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmTesSolicitudesDePago.Enabled = True
        frmCCPDF.Enabled = True
        frmCompGstPDF.Enabled = True
        frmSCPDF.Enabled = True
    End Sub

    Private Sub frmDocumentosAdjuntos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmTesSolicitudesDePago.Enabled = True
        frmCCPDF.Enabled = True
        frmCompGstPDF.Enabled = True
        frmSCPDF.Enabled = True
    End Sub

    Private Sub CXP_PagosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CXP_PagosDataGridView.CellContentClick
        contadorActividad = 0
        Try
            If e.ColumnIndex = 0 Then
                Select Case varGlobal_IdEmpresa
                    Case "23"
                        System.IO.File.Copy(My.Settings.addFinagil & CXP_PagosDataGridView.Item("uuid", e.RowIndex).Value & ".pdf", "C:\Files\" & CXP_PagosDataGridView.Item("uuid", e.RowIndex).Value & ".pdf", True)
                        System.Diagnostics.Process.Start("C:\Files\" & CXP_PagosDataGridView.Item("uuid", e.RowIndex).Value & ".pdf")
                    Case "24"
                        System.IO.File.Copy(My.Settings.addArfin & CXP_PagosDataGridView.Item("uuid", e.RowIndex).Value & ".pdf", "C:\Files\" & CXP_PagosDataGridView.Item("uuid", e.RowIndex).Value & ".pdf", True)
                        System.Diagnostics.Process.Start("C:\Files\" & CXP_PagosDataGridView.Item("uuid", e.RowIndex).Value & ".pdf")
                End Select

            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub lnkFolioSolicitud_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkFolioSolicitud.LinkClicked
        Try
            Select Case tipoSolicitud
                Case "TRA"
                    System.IO.File.Copy(My.Settings.fileNas & "TRA\" & tipoSolicitud & "-" & idSolPago & ".pdf", "C:\Files\" & tipoSolicitud & "-" & idSolPago & ".pdf", True)
                    System.Diagnostics.Process.Start("C:\Files\" & tipoSolicitud & "-" & idSolPago & ".pdf")
                Case Else
                    System.IO.File.Copy(My.Settings.fileNas & "CXP\" & varGlobal_IdEmpresa & "-" & idSolPago & ".pdf", "C:\Files\" & varGlobal_IdEmpresa & "-" & idSolPago & ".pdf", True)
                    System.Diagnostics.Process.Start("C:\Files\" & varGlobal_IdEmpresa & "-" & idSolPago & ".pdf")
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub lnkComprobanteIndividual_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkComprobanteIndividual.LinkClicked
        Dim taPagosTes As New dsTesoreriaTableAdapters.CXP_PagosTesoreriaTableAdapter
        Try
            Dim documento As String = taPagosTes.OntieneComPago_ScalarQuery(idSolPago, varGlobal_IdEmpresa)
            System.IO.File.Copy(My.Settings.fileNas & "CXP\ComPago\" & documento & ".pdf", "C:\Files\" & documento & ".pdf", True)
            System.Diagnostics.Process.Start("C:\Files\" & documento & ".pdf")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub lnkComprobanteOriginal_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkComprobanteOriginal.LinkClicked
        Dim taPagosTes As New dsTesoreriaTableAdapters.CXP_PagosTesoreriaTableAdapter
        Try
            Dim documento As String = taPagosTes.OntieneComPago_ScalarQuery(idSolPago, varGlobal_IdEmpresa).Substring(0, 36)
            System.IO.File.Copy(My.Settings.fileNas & "CXP\ComPago\ComOriginales\" & documento & ".pdf", "C:\Files\" & documento & ".pdf", True)
            System.Diagnostics.Process.Start("C:\Files\" & documento & ".pdf")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub
End Class