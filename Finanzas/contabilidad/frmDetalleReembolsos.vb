Imports System.ComponentModel

Public Class frmDetalleReembolsos
    Public idSolicitud As Integer
    Public fechaSolicitud As Date
    Dim taDetalleReembolsos As New dsContabilidadTableAdapters.Vw_CXP_AutorizacionesTableAdapter
    Dim dtDetalleReembolsos As New dsContabilidad.Vw_CXP_AutorizacionesDataTable
    Dim taPagosTesoreria As New dsContabilidadTableAdapters.CXP_PagosTesoreriaTableAdapter
    Dim taImpuestosCfdi As New dsTesoreriaTableAdapters.Vw_CXP_ImpuestosCFDITableAdapter
    Dim dtImpuestosCfdi As New dsTesoreria.Vw_CXP_ImpuestosCFDIDataTable
    Dim taDatosPolizas As New dsTesoreriaTableAdapters.DatosPolizasTableAdapter
    Dim taPeriodos As New dsContabilidadTableAdapters.CXP_PeriodosTableAdapter
    Dim taRegContable As New dsProductionTableAdapters.CXP_RegContTableAdapter

    Dim posRow As Integer
    Dim posCol As Integer

    Private Sub frmDetalleReembolsos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim totalCargoDed As Decimal = 0
        Dim totalCargoNDed As Decimal = 0
        Dim descripcion, solicitante As String

        Dim rwImpuestosCfdi As dsTesoreria.Vw_CXP_ImpuestosCFDIRow

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

        If taPagosTesoreria.ObtFechaPago_ScalarQuery("CXP", idSolicitud) = "01/01/1900 12:00:00 a. m." Then
            dtpFechaProceso.Value = taPagosTesoreria.ObtFechaPago_ScalarQuery("CXP", idSolicitud)
            dtpFechaProceso.Enabled = True
            lblFechaPago.Text = "Fecha de pago:"
            btnProcesar.Enabled = False
        Else
            dtpFechaProceso.Value = taPagosTesoreria.ObtFechaPago_ScalarQuery("CXP", idSolicitud)
            dtpFechaProceso.Enabled = False
            lblFechaPago.Text = "Fecha de registro:"
        End If

        cmbCuentaAbono.SelectedIndex = CuentasBindingSource1.Find("Codigo", "1103020200000000")

        taDetalleReembolsos.DetalleReembolso_FillBy(dtDetalleReembolsos, varGlobal_IdEmpresa, idSolicitud)

        For Each rwComprobaciongts As dsContabilidad.Vw_CXP_AutorizacionesRow In dtDetalleReembolsos.Rows
            Dim contador As Integer = 0
            If rwComprobaciongts.folio = "ND" Then
                dgvDetalleReembolsos.Rows.Add("", "", rwComprobaciongts.totalPagadoTC, 0, "REEMB GTS S-" & idSolicitud, "S-" & idSolicitud & " " & rwComprobaciongts.decripcion, "ND")
                totalCargoNDed += rwComprobaciongts.totalPagadoTC
            ElseIf rwComprobaciongts.folio <> "PROVEEDOR" Then
                taImpuestosCfdi.Fill(dtImpuestosCfdi, rwComprobaciongts.uuid)
                rwImpuestosCfdi = dtImpuestosCfdi.Rows(0)

                Dim porcentajePago As Integer = rwComprobaciongts.totalPagadoTC / rwImpuestosCfdi.total

                'dgvDetalleComprobaciones.Rows.Add("", "", rwImpuestosCfdi.SubTotal, 0, rwComprobaciongts.rfc, "S-" & idSolicitud & " F-" & rwComprobaciongts.serie & " " & rwComprobaciongts.folio & " " & rwComprobaciongts.descripcion, rwComprobaciongts.uuid)
                taImpuestosCfdi.Fill(dtImpuestosCfdi, rwComprobaciongts.uuid)
                For Each rowsCfdi As dsTesoreria.Vw_CXP_ImpuestosCFDIRow In dtImpuestosCfdi.Rows
                    If rowsCfdi.mTras <> "X" Then
                        If rowsCfdi.tipoFactor = "Exento" Then
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.base, 0, rwComprobaciongts.rfc & " Exento", "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                        ElseIf rowsCfdi.tipoFactor = "No Objeto" Then
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.importeCon, 0, rwComprobaciongts.rfc & " No Objeto", "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                        ElseIf rowsCfdi.tipoFactor = "Tasa" And CDec(rowsCfdi.mTras) = 0 Then
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.base, 0, rwComprobaciongts.rfc & " Tasa 0 %", "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                        ElseIf rowsCfdi.tipoFactor = "Tasa" And CDec(rowsCfdi.mTras) > 0 Then
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.base, 0, rwComprobaciongts.rfc, "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.mTras, 0, rwComprobaciongts.rfc, "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                        End If
                    Else
                        If rowsCfdi.tipoFactor = "No Objeto" Then
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.importeCon, 0, rwComprobaciongts.rfc & " No Objeto", "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                        End If
                    End If
                    If rowsCfdi.mRet <> "X" Then
                        dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.mRet, 0, rowsCfdi.Impuesto.Replace("001", "ISR").Replace("002", "IVA").Replace("003", "IEPS") & " " & rwComprobaciongts.rfc, "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                    End If

                    If contador = 0 Then
                        If rowsCfdi.mLocTra <> "X" And rowsCfdi.mLocTra <> 0 Then
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.mLocTra, 0, rowsCfdi.Impuesto.Replace("001", "ISR Loc").Replace("002", "IVA Loc").Replace("003", "IEPS Loc") & " " & rwComprobaciongts.rfc, "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                        End If
                        If rowsCfdi.mLocRet <> "X" And rowsCfdi.mLocRet <> 0 Then
                            dgvDetalleReembolsos.Rows.Add("", "", rowsCfdi.mLocRet, 0, rowsCfdi.Impuesto.Replace("001", "ISR Loc").Replace("002", "IVA Loc").Replace("003", "IEPS Loc") & " " & rwComprobaciongts.rfc, "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.decripcion, rwComprobaciongts.uuid)
                        End If
                    End If
                    contador += 1
                Next
                totalCargoDed += rwComprobaciongts.totalPagadoTC
            End If

            descripcion = rwComprobaciongts.decripcion
            solicitante = rwComprobaciongts.razonSocial
            'idConcepto = rwComprobaciongts.idConcepto
            'idProveedor = rwComprobaciongts.idProveedor

        Next
        dgvDetalleReembolsos.Rows.Add(cmbCuentaAbono.SelectedValue, cmbCuentaAbono.Text, 0, totalCargoDed + totalCargoNDed, "REEMB GTS S- " & idSolicitud & " ", "S- " & idSolicitud & " " & solicitante & " " & descripcion, "ND")
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

        pnlCuentasContpaq.Visible = True
        cmbCuentasContpaq.Focus()
    End Sub

    Private Sub dgvDetalleReembolsos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleReembolsos.CellContentClick

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        Dim rwDatosSolicitud As dsContabilidad.Vw_CXP_AutorizacionesRow
        Dim dtAutorizaciones As New dsContabilidad.Vw_CXP_AutorizacionesDataTable

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

        Dim idTipoDocumento As Integer = taDatosPolizas.ObtTipoPoliza_ScalarQuery("CXP", rwDatosSolicitud.formaDePago, rwDatosSolicitud.monedaPago, varGlobal_IdEmpresa)

        Dim folioPoliza As Integer = taPeriodos.ConsultaFolio_ScalarQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa)
        Dim contador As Integer = 0
        For Each rows As DataGridViewRow In dgvDetalleReembolsos.Rows

            taRegContable.Insert(CDec(dgvDetalleReembolsos.Item("idCuenta", contador).Value), rwDatosSolicitud.idProveedor, CDec(dgvDetalleReembolsos.Item("cargo", contador).Value), CDec(dgvDetalleReembolsos.Item("abono", contador).Value), dgvDetalleReembolsos.Item("referencia", contador).Value, dgvDetalleReembolsos.Item("concepto", contador).Value, idTipoDocumento, folioPoliza, varGlobal_IdEmpresa, dgvDetalleReembolsos.Item("uuid", contador).Value, idSolicitud, dtpFechaProceso.Value, "29", rwDatosSolicitud.idConcepto, 2)
            contador += 1
        Next
        'taTipoDeDocumento.ConsumeFolio_UpdateQuery(idTipoDocumento)
        taPeriodos.ConsumeFolio_UpdateQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa)
        btnProcesar.Enabled = False
        MsgBox("Proceso ejecutado correctamente", MsgBoxStyle.Information, "")
        'taRegCont.CambiaEstatus_UpdateQuery("Contabilizado", idSolicitud, idComprobacion, varGlobal_IdEmpresa)
    End Sub

    Private Sub cmbCuentasContpaq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuentasContpaq.SelectedIndexChanged

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class