
Imports System.ComponentModel

Public Class frmDocumentosAdjuntos
    Public idSolPago As String
    Private Sub frmDocumentosAdjuntos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsTesoreria.CXP_Pagos' Puede moverla o quitarla según sea necesario.
        Me.CXP_PagosTableAdapter.DocumentosAdjuntos_FillBy(Me.DsTesoreria.CXP_Pagos, idSolPago, varGlobal_IdEmpresa)
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
        Try
            If e.ColumnIndex = 3 Then
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
        System.IO.File.Copy(My.Settings.fileNas & "CXP\" & varGlobal_IdEmpresa & "-" & idSolPago & ".pdf", "C:\Files\" & varGlobal_IdEmpresa & "-" & idSolPago & ".pdf", True)
        System.Diagnostics.Process.Start("C:\Files\" & varGlobal_IdEmpresa & "-" & idSolPago & ".pdf")
    End Sub
End Class