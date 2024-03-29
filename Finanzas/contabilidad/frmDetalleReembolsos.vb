﻿Imports System.ComponentModel

Public Class frmDetalleReembolsos
    Public idSolicitud As Integer
    Public fechaSolicitud As Date
    Public fPago As String
    Public monedaPago As String
    Public nombreDeudor As String
    Dim taDetalleReembolsos As New dsContabilidadTableAdapters.Vw_CXP_AutorizacionesTableAdapter
    Dim dtDetalleReembolsos As New dsContabilidad.Vw_CXP_AutorizacionesDataTable
    Dim taPagosTesoreria As New dsContabilidadTableAdapters.CXP_PagosTesoreriaTableAdapter
    Dim taImpuestosCfdi As New dsTesoreriaTableAdapters.Vw_CXP_ImpuestosCFDITableAdapter
    Dim dtImpuestosCfdi As New dsTesoreria.Vw_CXP_ImpuestosCFDIDataTable
    Dim taDatosPolizas As New dsTesoreriaTableAdapters.DatosPolizasTableAdapter
    Dim taPeriodos As New dsContabilidadTableAdapters.CXP_PeriodosTableAdapter
    Dim taRegContable As New dsProductionTableAdapters.CXP_RegContTableAdapter
    Dim taPagos As New dsContabilidadTableAdapters.CXP_PagosTableAdapter

    Dim posRow As Integer
    Dim posCol As Integer
    Dim diarioEgreso As String = ""

    Private Sub frmDetalleReembolsos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim totalCargoDed As Decimal = 0
        Dim totalCargoNDed As Decimal = 0
        Dim descripcion, solicitante As String

        Dim rwImpuestosCfdi As dsTesoreria.Vw_CXP_ImpuestosCFDIRow

        Try
            If varGlobal_IdEmpresa = "24" Then
                CuentasTableAdapter.Connection.ConnectionString = My.Settings.csContpaqArfin
            Else
                CuentasTableAdapter.Connection.ConnectionString = My.Settings.csContpaqFinagil
            End If
            Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error en conexión...")
        End Try

        Dim str As String = taPagosTesoreria.ObtFechaPago_ScalarQuery("CXP", idSolicitud, varGlobal_IdEmpresa).ToString

        If CDate(taPagosTesoreria.ObtFechaPago_ScalarQuery("CXP", idSolicitud, varGlobal_IdEmpresa)).Month = fechaSolicitud.Month Then

            Me.Text = "Detalle Reembolsos - Egreso"
            dtpFechaProceso.Value = taPagosTesoreria.ObtFechaPago_ScalarQuery("CXP", idSolicitud, varGlobal_IdEmpresa)
            dtpFechaSolicitud.Value = fechaSolicitud
            dtpFechaProceso.Enabled = False
            cmbCuentaAbono.SelectedIndex = CuentasBindingSource1.Find("Codigo", "1103020200000000")
            diarioEgreso = "Egreso"
        ElseIf CDate(taPagosTesoreria.ObtFechaPago_ScalarQuery("CXP", idSolicitud, varGlobal_IdEmpresa)).Month <> fechaSolicitud.Month And taPagosTesoreria.ObtFechaPago_ScalarQuery("CXP", idSolicitud, varGlobal_IdEmpresa) = "1900-01-01 00:00:00.000" Then
            Me.Text = "Detalle Reembolsos - Diario"
            dtpFechaProceso.Value = taPagosTesoreria.ObtFechaPago_ScalarQuery("CXP", idSolicitud, varGlobal_IdEmpresa)
            dtpFechaProceso.Value = Date.Now
            dtpFechaSolicitud.Value = fechaSolicitud
            'dtpFechaProceso.Enabled = False
            cmbCuentaAbono.SelectedIndex = CuentasBindingSource1.Find("Codigo", "2311019000900000")
            diarioEgreso = "Diario"
        ElseIf taPagosTesoreria.ObtFechaPago_ScalarQuery("CXP", idSolicitud, varGlobal_IdEmpresa).ToString <> "01/01/1900 12:00:00 a. m." Then
            Me.Text = "Detalle Reembolsos - Egreso"
            dtpFechaProceso.Value = taPagosTesoreria.ObtFechaPago_ScalarQuery("CXP", idSolicitud, varGlobal_IdEmpresa)
            dtpFechaSolicitud.Value = fechaSolicitud
            dtpFechaProceso.Enabled = False
            cmbCuentaAbono.SelectedIndex = CuentasBindingSource1.Find("Codigo", "1103020200000000")
            diarioEgreso = "Egreso"
        End If


        taDetalleReembolsos.DetalleReembolso_FillBy(dtDetalleReembolsos, varGlobal_IdEmpresa, idSolicitud)

        For Each rwComprobaciongts As dsContabilidad.Vw_CXP_AutorizacionesRow In dtDetalleReembolsos.Rows
            Dim contador As Integer = 0
            descripcion = ""
            solicitante = ""
            If rwComprobaciongts.folio = "ND" Then
                dgvDetalleReembolsos.Rows.Add("", "", rwComprobaciongts.totalPagadoTC, 0, "REEMB GTS S-" & idSolicitud, "S-" & idSolicitud & " " & rwComprobaciongts.decripcion, "ND")
                totalCargoNDed += rwComprobaciongts.totalPagadoTC
            ElseIf rwComprobaciongts.folio <> "PROVEEDOR" Then
                taImpuestosCfdi.Fill(dtImpuestosCfdi, rwComprobaciongts.uuid)
                rwImpuestosCfdi = dtImpuestosCfdi.Rows(0)

                Dim porcentajePago As Decimal = rwComprobaciongts.totalPagadoTC / rwImpuestosCfdi.total

                'dgvDetalleComprobaciones.Rows.Add("", "", rwImpuestosCfdi.SubTotal, 0, rwComprobaciongts.rfc, "S-" & idSolicitud & " F-" & rwComprobaciongts.serie & " " & rwComprobaciongts.folio & " " & rwComprobaciongts.descripcion, rwComprobaciongts.uuid)
                taImpuestosCfdi.Fill(dtImpuestosCfdi, rwComprobaciongts.uuid)
                For Each rowsCfdi As dsTesoreria.Vw_CXP_ImpuestosCFDIRow In dtImpuestosCfdi.Rows
                    If rowsCfdi.mTras <> "X" Then
                        If rowsCfdi.tipoFactor = "Exento" Then
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.base * porcentajePago, 0, rowsCfdi.rfcEmisor & " Exento", "F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                        ElseIf rowsCfdi.tipoFactor = "No Objeto" Then
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.importeCon * porcentajePago, 0, rowsCfdi.rfcEmisor & " No Objeto", "F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                        ElseIf rowsCfdi.tipoFactor = "Tasa" And CDec(rowsCfdi.mTras) = 0 Then
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.base * porcentajePago, 0, rowsCfdi.rfcEmisor & " Tasa 0 %", "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                        ElseIf rowsCfdi.tipoFactor = "Tasa" And CDec(rowsCfdi.mTras) > 0 Then
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.base * porcentajePago, 0, rowsCfdi.rfcEmisor, "F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.mTras * porcentajePago, 0, rowsCfdi.rfcEmisor, "F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                        End If
                    Else
                        If rowsCfdi.tipoFactor = "No Objeto" Then
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.importeCon * porcentajePago, 0, rowsCfdi.rfcEmisor & " No Objeto", "F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                        End If
                    End If
                    If rowsCfdi.mRet <> "X" Then
                        dgvDetalleReembolsos.Rows.Add("", "", 0, rowsCfdi.mRet * porcentajePago, rowsCfdi.Impuesto.Replace("001", "ISR").Replace("002", "IVA").Replace("003", "IEPS") & " " & rowsCfdi.rfcEmisor, "F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                    End If

                    If contador = 0 Then
                        If rowsCfdi.mLocTra <> "X" And rowsCfdi.mLocTra <> 0 Then
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.mLocTra * porcentajePago, 0, rowsCfdi.Impuesto.Replace("001", "ISR Loc").Replace("002", "IVA Loc").Replace("003", "IEPS Loc") & " " & rowsCfdi.rfcEmisor, "F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                        End If
                        If rowsCfdi.mLocRet <> "X" And rowsCfdi.mLocRet <> 0 Then
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.mLocRet * porcentajePago, 0, rowsCfdi.Impuesto.Replace("001", "ISR Loc").Replace("002", "IVA Loc").Replace("003", "IEPS Loc") & " " & rowsCfdi.rfcEmisor, "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                        End If
                    End If
                    contador += 1
                Next
                totalCargoDed += rwComprobaciongts.totalPagadoTC
            End If

            descripcion = rwComprobaciongts.decripcion
            solicitante = rwComprobaciongts.razonSocial

        Next
        dgvDetalleReembolsos.Rows.Add(cmbCuentaAbono.SelectedValue, cmbCuentaAbono.Text, 0, totalCargoDed + totalCargoNDed, "REEMB GTS S-" & idSolicitud & " ", nombreDeudor & " " & descripcion, "ND")
        dgvDetalleReembolsos.Focus()
    End Sub


    Private Sub frmDetalleReembolsos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmContabilizaReembolsos.Enabled = True
    End Sub

    Private Sub frmDetalleReembolsos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmContabilizaReembolsos.Enabled = True
    End Sub



    Public Sub actualizaCuenta()
        dgvDetalleReembolsos.Item(0, posRow).Value = cmbCuentasContpaq.SelectedValue
        dgvDetalleReembolsos.Item(1, posRow).Value = cmbCuentasContpaq.SelectedText

        pnlCuentasContpaq.Visible = False
    End Sub

    Private Sub cmbCuentasContpaq_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbCuentasContpaq.KeyUp
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            actualizaCuenta()
        ElseIf e.KeyCode = Keys.Escape Then
            pnlCuentasContpaq.Visible = False
        End If
    End Sub


    Private Sub dgvDetalleReembolsos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleReembolsos.CellClick
        posCol = e.ColumnIndex
        posRow = e.RowIndex
        If e.RowIndex < dgvDetalleReembolsos.Rows.Count - 1 Then
            pnlCuentasContpaq.Visible = True
            cmbCuentasContpaq.Focus()
        End If
    End Sub

    Private Sub dgvDetalleReembolsos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleReembolsos.CellContentClick

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        Dim rwDatosSolicitud As dsContabilidad.Vw_CXP_AutorizacionesRow
        Dim dtAutorizaciones As New dsContabilidad.Vw_CXP_AutorizacionesDataTable
        Dim taPolizas As New dsTesoreriaTableAdapters.CXP_tipoDeDocumentoTableAdapter
        Dim taEmpresas As New dsProductionTableAdapters.CXP_EmpresasTableAdapter
        Dim taTipoDeDocumento As New dsContabilidadTableAdapters.CXP_tipoDeDocumentoTableAdapter

        Dim contValid As Integer = 0

        For Each rows As DataGridViewRow In dgvDetalleReembolsos.Rows
            If dgvDetalleReembolsos.Item("idCuenta", contValid).Value.ToString = "" Then
                contValid += 1
                MsgBox("No se han asignado cuentas en todos los registros", MsgBoxStyle.Information, "")
                Exit Sub
            End If
        Next

        taDetalleReembolsos.ObtDatosSolicitud_FillBy(dtAutorizaciones, varGlobal_IdEmpresa, idSolicitud)
        If dtAutorizaciones.Rows.Count = 1 Then
            rwDatosSolicitud = dtAutorizaciones.Rows(0)
        End If

        'Eventos contable según fecha de pago
        Dim idTipoDocumento As Integer
        Dim folioPoliza As Integer
        If diarioEgreso = "Egreso" Then
            'egreso
            idTipoDocumento = taDatosPolizas.ObtTipoPoliza_ScalarQuery("CXP", rwDatosSolicitud.formaDePago, rwDatosSolicitud.monedaPago, varGlobal_IdEmpresa)

            If dtpFechaProceso.Value.Month = dtpFechaSolicitud.Value.Month Then
                folioPoliza = taPolizas.ConsultaUltimoFolio_ScalarQuery(idTipoDocumento, varGlobal_IdEmpresa)
            ElseIf taPagosTesoreria.ObtFechaPago_ScalarQuery("CXP", idSolicitud, varGlobal_IdEmpresa) <> "01/01/1900 12:00:00 a. m." Then
                folioPoliza = taPolizas.ConsultaUltimoFolio_ScalarQuery(idTipoDocumento, varGlobal_IdEmpresa)
            Else
                folioPoliza = taPeriodos.ConsultaFolio_ScalarQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa)
            End If

            Dim contador As Integer = 0
            For Each rows As DataGridViewRow In dgvDetalleReembolsos.Rows
                taRegContable.Insert(CDec(dgvDetalleReembolsos.Item("idCuenta", contador).Value), rwDatosSolicitud.idProveedor, CDec(dgvDetalleReembolsos.Item("cargo", contador).Value), CDec(dgvDetalleReembolsos.Item("abono", contador).Value), dgvDetalleReembolsos.Item("referencia", contador).Value, dgvDetalleReembolsos.Item("concepto", contador).Value, idTipoDocumento, folioPoliza, varGlobal_IdEmpresa, dgvDetalleReembolsos.Item("uuid", contador).Value, idSolicitud, dtpFechaProceso.Value, "29", rwDatosSolicitud.idConcepto, 2, "CXP")
                contador += 1
            Next
            If dtpFechaProceso.Value.Month = Date.Now.Month Then
                taPolizas.ConsumeUltimoFolio_UpdateQuery(idTipoDocumento, varGlobal_IdEmpresa)
            Else
                taPeriodos.ConsumeFolio_UpdateQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa)
            End If
            btnProcesar.Enabled = False
            taPagos.ActualizaContabilizado_UpdateQuery("Contabilizado", idSolicitud, varGlobal_IdEmpresa)
            MsgBox("Proceso ejecutado correctamente", MsgBoxStyle.Information, "")

        Else
            'diario


            If dtpFechaProceso.Value.Month <> Date.Now.Month Then
                idTipoDocumento = taTipoDeDocumento.ObtTipoDePoliza_ScalarQuery("Diario", varGlobal_IdEmpresa)
                folioPoliza = taPolizas.ConsultaUltimoFolio_ScalarQuery(idTipoDocumento, varGlobal_IdEmpresa)
            Else
                dtpFechaProceso.Value = DateSerial(Date.Now.Year, Date.Now.Month, 0)
                idTipoDocumento = taDatosPolizas.ObtTipoPoliza_ScalarQuery("CXP", fPago, monedaPago, varGlobal_IdEmpresa)
                folioPoliza = taPeriodos.ConsultaFolio_ScalarQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa)
            End If
            'folioPoliza = taPolizas.ConsultaUltimoFolio_ScalarQuery(idTipoDocumento, varGlobal_IdEmpresa)

            Dim contador As Integer = 0
            For Each rows As DataGridViewRow In dgvDetalleReembolsos.Rows
                taRegContable.Insert(CDec(dgvDetalleReembolsos.Item("idCuenta", contador).Value), rwDatosSolicitud.idProveedor, CDec(dgvDetalleReembolsos.Item("cargo", contador).Value), CDec(dgvDetalleReembolsos.Item("abono", contador).Value), dgvDetalleReembolsos.Item("referencia", contador).Value, dgvDetalleReembolsos.Item("concepto", contador).Value, idTipoDocumento, folioPoliza, varGlobal_IdEmpresa, dgvDetalleReembolsos.Item("uuid", contador).Value, idSolicitud, dtpFechaProceso.Value, "29", rwDatosSolicitud.idConcepto, 2, "CXP")
                contador += 1
            Next

            taPeriodos.ConsumeFolio_UpdateQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa)
            btnProcesar.Enabled = False
            taPagos.ActualizaContabilizado_UpdateQuery("Contabilizado", idSolicitud, varGlobal_IdEmpresa)
            MsgBox("Proceso ejecutado correctamente", MsgBoxStyle.Information, "")
        End If


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class