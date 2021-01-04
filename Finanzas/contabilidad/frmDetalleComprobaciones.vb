
Public Class frmDetalleComprobaciones
    Public idComprobacion As Integer
    Public idSolicitud As Integer
    Dim posRow As Integer
    Dim posCol As Integer
    Dim taPeriodos As New dsContabilidadTableAdapters.CXP_PeriodosTableAdapter
    Dim taTipoDeDocumento As New dsContabilidadTableAdapters.CXP_tipoDeDocumentoTableAdapter
    Dim taRegContable As New dsProductionTableAdapters.CXP_RegContTableAdapter
    Dim taRegCont As New dsContabilidadTableAdapters.CXP_ComprobGtos1TableAdapter
    Dim taEmpresas As New dsProductionTableAdapters.CXP_EmpresasTableAdapter
    Dim idProveedor As Integer
    Dim idConcepto As Integer

    Private Sub frmDetalleComprobaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim taComprobacionGts As New dsContabilidadTableAdapters.CXP_ComprobGtosTableAdapter
        Dim dtComprobacionGts As New dsContabilidad.CXP_ComprobGtosDataTable

        Dim taImpuestosCfdi As New dsTesoreriaTableAdapters.Vw_CXP_ImpuestosCFDITableAdapter
        Dim dtImpuestosCfdi As New dsTesoreria.Vw_CXP_ImpuestosCFDIDataTable
        Dim rwImpuestosCfdi As dsTesoreria.Vw_CXP_ImpuestosCFDIRow
        Dim totalCargoDed As Decimal = 0
        Dim totalCargoNDed As Decimal = 0
        Dim descripcion, solicitante As String

        If taRegCont.ConsultaEstatus_ScalarQuery(idSolicitud, varGlobal_IdEmpresa, idComprobacion) = "Contabilizado" Then
            MsgBox("Comprobación ya contabilizada", MsgBoxStyle.Information, "")
            Exit Sub
        End If

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

        cmbCuentaAbono.SelectedIndex = CuentasBindingSource1.Find("Codigo", "1501909000000000")


        taComprobacionGts.DetalleComprobacion_FillBy(dtComprobacionGts, varGlobal_IdEmpresa, idSolicitud, idComprobacion)

        For Each rwComprobaciongts As dsContabilidad.CXP_ComprobGtosRow In dtComprobacionGts.Rows
            Dim contador As Integer = 0
            If rwComprobaciongts.serie = "ND" Then
                If rwComprobaciongts.importe >= 0 Then
                    dgvDetalleComprobaciones.Rows.Add("", "", rwComprobaciongts.importe, 0, "COMP GTS S-" & idSolicitud, "S-" & idSolicitud & " " & rwComprobaciongts.descripcion, "ND")
                Else
                    dgvDetalleComprobaciones.Rows.Add("", "", 0, Math.Abs(rwComprobaciongts.importe), "COMP GTS S-" & idSolicitud, "S-" & idSolicitud & " " & rwComprobaciongts.descripcion, "ND")
                End If
                                    totalCargoNDed += rwComprobaciongts.importe
            Else
                taImpuestosCfdi.Fill(dtImpuestosCfdi, rwComprobaciongts.uuid)
                rwImpuestosCfdi = dtImpuestosCfdi.Rows(0)

                Dim porcentajePago As Integer = rwComprobaciongts.importe / rwImpuestosCfdi.total

                'dgvDetalleComprobaciones.Rows.Add("", "", rwImpuestosCfdi.SubTotal, 0, rwComprobaciongts.rfc, "S-" & idSolicitud & " F-" & rwComprobaciongts.serie & " " & rwComprobaciongts.folio & " " & rwComprobaciongts.descripcion, rwComprobaciongts.uuid)
                taImpuestosCfdi.Fill(dtImpuestosCfdi, rwComprobaciongts.uuid)
                For Each rowsCfdi As dsTesoreria.Vw_CXP_ImpuestosCFDIRow In dtImpuestosCfdi.Rows
                    If rowsCfdi.mTras <> "X" Then
                        If rowsCfdi.tipoFactor = "Exento" Then
                            dgvDetalleComprobaciones.Rows.Add("", "", rowsCfdi.base, 0, rwComprobaciongts.rfcBen & " Exento", "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.descripcion, rwComprobaciongts.uuid)
                        ElseIf rowsCfdi.tipoFactor = "No Objeto" Then
                            dgvDetalleComprobaciones.Rows.Add("", "", rowsCfdi.importeCon, 0, rwComprobaciongts.rfcBen & " No Obj", "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.descripcion, rwComprobaciongts.uuid)
                        ElseIf rowsCfdi.tipoFactor = "Tasa" And CDec(rowsCfdi.mTras) = 0 Then
                            dgvDetalleComprobaciones.Rows.Add("", "", rowsCfdi.base, 0, rwComprobaciongts.rfcBen & " Tasa 0%", "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.descripcion, rwComprobaciongts.uuid)
                        ElseIf rowsCfdi.tipoFactor = "Tasa" And CDec(rowsCfdi.mTras) > 0 Then
                            dgvDetalleComprobaciones.Rows.Add("", "", rowsCfdi.base, 0, rwComprobaciongts.rfcBen, "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.descripcion, rwComprobaciongts.uuid)
                            dgvDetalleComprobaciones.Rows.Add("", "", rowsCfdi.mTras, 0, rwComprobaciongts.rfcBen, "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.descripcion, rwComprobaciongts.uuid)
                        End If
                    Else
                        If rowsCfdi.tipoFactor = "No Objeto" Then
                            dgvDetalleComprobaciones.Rows.Add("", "", 0, FormatCurrency(rowsCfdi.importeCon), rwComprobaciongts.rfcBen & " No Obj", "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.descripcion, rwComprobaciongts.uuid)
                        End If
                    End If
                    If rowsCfdi.mRet <> "X" Then
                        dgvDetalleComprobaciones.Rows.Add("", "", 0, FormatCurrency(rowsCfdi.mRet), rowsCfdi.Impuesto.Replace("001", "ISR").Replace("002", "IVA").Replace("003", "IEPS") & " " & rwComprobaciongts.rfcBen, "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.descripcion, rwComprobaciongts.uuid)
                    End If

                    If contador = 0 Then
                        If rowsCfdi.mLocTra <> "X" And rowsCfdi.mLocTra <> 0 Then
                            dgvDetalleComprobaciones.Rows.Add("", "", 0, rowsCfdi.mLocTra, rowsCfdi.Impuesto.Replace("001", "ISR Loc").Replace("002", "IVA Loc").Replace("003", "IEPS Loc") & " " & rwComprobaciongts.rfcBen, "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.descripcion, rwComprobaciongts.uuid)
                        End If
                        If rowsCfdi.mLocRet <> "X" And rowsCfdi.mLocRet <> 0 Then
                            dgvDetalleComprobaciones.Rows.Add("", "", 0, rowsCfdi.mLocRet, rowsCfdi.Impuesto.Replace("001", "ISR Loc").Replace("002", "IVA Loc").Replace("003", "IEPS Loc") & " " & rwComprobaciongts.rfcBen, "S-" & idSolicitud & " F- " & rwComprobaciongts.folio & " " & rwComprobaciongts.descripcion, rwComprobaciongts.uuid)
                        End If
                    End If
                    contador += 1
                Next
                totalCargoDed += rwComprobaciongts.importe
            End If

            descripcion = rwComprobaciongts.destinoN
            solicitante = rwComprobaciongts.razonSocial
            idConcepto = rwComprobaciongts.idConcepto
            idProveedor = rwComprobaciongts.idProveedor

        Next
        dgvDetalleComprobaciones.Rows.Add(cmbCuentaAbono.SelectedValue, cmbCuentaAbono.Text, 0, totalCargoDed + totalCargoNDed, "COMP GTS S-" & idSolicitud & " ", "S-" & idSolicitud & " " & solicitante & " " & descripcion, "ND")
        dgvDetalleComprobaciones.Focus()
    End Sub

    Private Sub frmDetalleComprobaciones_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmContabilizaComprobaciones.Enabled = True
    End Sub

    Private Sub frmDetalleComprobaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmContabilizaComprobaciones.Enabled = True
    End Sub

    Private Sub dgvDetalleComprobaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleComprobaciones.CellClick
        posCol = e.ColumnIndex
        posRow = e.RowIndex

        If e.RowIndex < dgvDetalleComprobaciones.Rows.Count - 1 Then
            pnlCuentasContpaq.Visible = True
            cmbCuentasContpaq.Focus()
        End If
    End Sub

    Private Sub cmbCuentasContpaq_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbCuentasContpaq.KeyUp
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            actualizaCuenta()
        ElseIf e.KeyCode = Keys.Escape Then
            pnlCuentasContpaq.Visible = False
        End If
    End Sub

    Private Sub cmbCuentasContpaq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuentasContpaq.SelectedIndexChanged

    End Sub
    Public Sub actualizaCuenta()
        dgvDetalleComprobaciones.Item(0, posRow).Value = cmbCuentasContpaq.SelectedValue
        dgvDetalleComprobaciones.Item(1, posRow).Value = cmbCuentasContpaq.SelectedText
        pnlCuentasContpaq.Visible = False
    End Sub

    Private Sub dgvDetalleComprobaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleComprobaciones.CellContentClick

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim contValid As Integer = 0
        Dim periodoEjercicio As String = "2"

        If varGlobal_IdEmpresa = 23 Then
            periodoEjercicio = "1"
        End If

        For Each rows As DataGridViewRow In dgvDetalleComprobaciones.Rows
            If dgvDetalleComprobaciones.Item("idCuenta", contValid).Value.ToString = "" Then
                contValid += 1
                MsgBox("No se han asignado cuentas en todos los registros", MsgBoxStyle.Information, "")
                Exit Sub
            End If
        Next
        If dtpFechaProceso.Value.Month < Date.Now.Month Then
            If taPeriodos.ExistePeriodoCerrado_ScalarQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa) <> "NE" Then
                Dim idTipoDocumento As Integer = taEmpresas.ObtPolizaDiario_ScalarQuery(varGlobal_IdEmpresa)
                Dim folioPoliza As Integer = taPeriodos.ConsultaFolio_ScalarQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa)
                Dim contador As Integer = 0
                For Each rows As DataGridViewRow In dgvDetalleComprobaciones.Rows
                    taRegContable.Insert(CDec(dgvDetalleComprobaciones.Item("idCuenta", contador).Value), idProveedor, CDec(dgvDetalleComprobaciones.Item("cargo", contador).Value), CDec(dgvDetalleComprobaciones.Item("abono", contador).Value), dgvDetalleComprobaciones.Item("referencia", contador).Value, dgvDetalleComprobaciones.Item("concepto", contador).Value, idTipoDocumento, folioPoliza, varGlobal_IdEmpresa, dgvDetalleComprobaciones.Item("uuid", contador).Value, idSolicitud, dtpFechaProceso.Value, "29", idConcepto, periodoEjercicio)
                    contador += 1
                Next
                'taTipoDeDocumento.ConsumeFolio_UpdateQuery(idTipoDocumento)
                taPeriodos.ConsumeFolio_UpdateQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa)
                btnProcesar.Enabled = False
                MsgBox("Proceso ejecutado correctamente", MsgBoxStyle.Information, "")
                taRegCont.CambiaEstatus_UpdateQuery("Contabilizado", idSolicitud, idComprobacion, varGlobal_IdEmpresa)
            Else
                MsgBox("El periodo no se ha cerrado", MsgBoxStyle.Information, "")
            End If
        Else
            Dim idTipoDocumento As Integer = taEmpresas.ObtPolizaDiario_ScalarQuery(varGlobal_IdEmpresa)
            Dim folioPoliza As Integer = taTipoDeDocumento.ConsultaFolio_ScalarQuery(idTipoDocumento) 'taPeriodos.ConsultaFolio_ScalarQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa)
            Dim contador As Integer = 0
            For Each rows As DataGridViewRow In dgvDetalleComprobaciones.Rows
                taRegContable.Insert(CDec(dgvDetalleComprobaciones.Item("idCuenta", contador).Value), idProveedor, CDec(dgvDetalleComprobaciones.Item("cargo", contador).Value), CDec(dgvDetalleComprobaciones.Item("abono", contador).Value), dgvDetalleComprobaciones.Item("referencia", contador).Value, dgvDetalleComprobaciones.Item("concepto", contador).Value, idTipoDocumento, folioPoliza, varGlobal_IdEmpresa, dgvDetalleComprobaciones.Item("uuid", contador).Value, idSolicitud, dtpFechaProceso.Value, "29", idConcepto, 2)
                contador += 1
            Next
            taTipoDeDocumento.ConsumeFolio_UpdateQuery(idTipoDocumento)
            'taPeriodos.ConsumeFolio_UpdateQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa)
            btnProcesar.Enabled = False
            MsgBox("Proceso ejecutado correctamente", MsgBoxStyle.Information, "")
            taRegCont.CambiaEstatus_UpdateQuery("Contabilizado", idSolicitud, idComprobacion, varGlobal_IdEmpresa)
        End If
    End Sub

    Private Sub dgvDetalleComprobaciones_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvDetalleComprobaciones.KeyUp

    End Sub
End Class