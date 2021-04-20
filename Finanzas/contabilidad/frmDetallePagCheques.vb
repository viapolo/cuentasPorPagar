Imports System.ComponentModel

Public Class frmDetallePagCheques
    Public folioSolicitud As Integer
    Public tipoSolicitud As String
    Public importeCheque As Decimal
    Public idProveedor As Integer
    Public nombre As String
    Public idConcepto As Integer
    Dim idTipoDocumento As Integer
    Dim idBancoXEmpresa, idFormaPago As Integer
    Dim taCuentasBancarias As New dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter
    Dim taTipoDeDocumento As New dsContabilidadTableAdapters.CXP_tipoDeDocumentoTableAdapter
    Dim taDatosPolizas As New dsTesoreriaTableAdapters.DatosPolizasTableAdapter
    Private Sub frmDetallePagCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If varGlobal_IdEmpresa = 24 Then
            idBancoXEmpresa = 1
            idFormaPago = 5
        Else
            idBancoXEmpresa = 2
            idFormaPago = 2
        End If
        idTipoDocumento = taDatosPolizas.ObtTipoPoliza_ScalarQuery("CXP", idFormaPago, "MXN", varGlobal_IdEmpresa)
        tsslFolioCheque.Text = "Documento bancario actual: " & taCuentasBancarias.ConsultaChequeActual_ScalarQuery(idBancoXEmpresa)
        tsslFolioEvento.Text = "Póliza actual: " & taTipoDeDocumento.ConsultaFolio_ScalarQuery(idTipoDocumento)

        Try
            Me.PagosConChequeDetalleTableAdapter.Fill(Me.DsContabilidad.PagosConChequeDetalle, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)), tipoSolicitud, folioSolicitud)
            Me.CXP_CuentasBancariasTableAdapter.Fill(DsContabilidad.CXP_CuentasBancarias, varGlobal_IdEmpresa)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            If varGlobal_IdEmpresa = "24" Then
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctCONEARFIN;Persist Security Info=True;User ID=finagil;Password=finagil"
            Else
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctFINAGILCONEFINAGIL2015;Persist Security Info=True;User ID=finagil;Password=finagil"
            End If
            Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error en conexión...")
        End Try

        txtImporteAbono.Text = FormatCurrency(importeCheque)
        txtImporteCargo.Text = FormatCurrency(importeCheque)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmDetallePagCheques_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmContabilizaCheques.Enabled = True
    End Sub

    Private Sub frmDetallePagCheques_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmContabilizaCheques.Enabled = True
        frmContabilizaCheques.PagosConChequeTableAdapter.Fill(Me.DsContabilidad.PagosConCheque, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)))
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim taRegContables As New dsTesoreriaTableAdapters.CXP_RegContTableAdapter
        Dim taCuentasBancarias As New dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter
        Dim taPagos As New dsContabilidadTableAdapters.CXP_PagosTableAdapter
        Dim taPagosTesoreria As New dsTesoreriaTableAdapters.CXP_PagosTesoreriaTableAdapter
        If IsNumeric(txtCheque.Text) Then
            'cargo
            taRegContables.Insert(CDec(cmbCargo.SelectedValue), idProveedor, CDec(txtImporteCargo.Text), 0, txtCheque.Text.Trim, "S-" & folioSolicitud.ToString & " " & nombre, idTipoDocumento, CDec(taTipoDeDocumento.ConsultaFolio_ScalarQuery(idTipoDocumento)), varGlobal_IdEmpresa, "ND", folioSolicitud, dtpfecha.Value.ToShortDateString, "40", idConcepto, 2, "CXP")
            'abono
            taRegContables.Insert(CDec(cmbAbono.SelectedValue), idProveedor, 0, CDec(txtImporteCargo.Text), txtCheque.Text.Trim, "S-" & folioSolicitud.ToString & " " & nombre, idTipoDocumento, CDec(taTipoDeDocumento.ConsultaFolio_ScalarQuery(idTipoDocumento)), varGlobal_IdEmpresa, "ND", folioSolicitud, dtpfecha.Value.ToShortDateString, "40", idConcepto, 2, "CXP")
            MsgBox("Documento contabilizado correctamente", MsgBoxStyle.Information, "")
            taTipoDeDocumento.ConsumeFolio_UpdateQuery(idTipoDocumento)
            taCuentasBancarias.ConsumeFolioCheque_UpdateQuery(idBancoXEmpresa)
            taPagos.ActualizaContabilizado_UpdateQuery("Contabilizado", folioSolicitud, varGlobal_IdEmpresa)
            taPagosTesoreria.InsertaFolioCheque_UpdateQuery(CDec(taCuentasBancarias.ConsultaChequeActual_ScalarQuery(idBancoXEmpresa)), 34, CDec(cmbBanco.SelectedValue), "CXP", folioSolicitud)
            Me.Close()
        Else
            MsgBox("El número de cheque debe de ser numerico...", MsgBoxStyle.Information, "")
        End If
    End Sub
End Class