Public Class frmDetalleCompraFondos

    Public idSolicitud As Integer
    Private Sub frmDetalleCompraFondos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim taDetalleReembolsos As New dsContabilidadTableAdapters.Vw_CXP_AutorizacionesTableAdapter
        Dim dtDetalleReembolsos As New dsContabilidad.Vw_CXP_AutorizacionesDataTable
        Dim taPagosTesoreria As New dsContabilidadTableAdapters.CXP_PagosTesoreriaTableAdapter
        Dim taImpuestosCfdi As New dsTesoreriaTableAdapters.Vw_CXP_ImpuestosCFDITableAdapter
        Dim dtImpuestosCfdi As New dsTesoreria.Vw_CXP_ImpuestosCFDIDataTable
        Dim taDatosPolizas As New dsTesoreriaTableAdapters.DatosPolizasTableAdapter
        Dim taPeriodos As New dsContabilidadTableAdapters.CXP_PeriodosTableAdapter
        Dim taRegContable As New dsProductionTableAdapters.CXP_RegContTableAdapter
        Dim taPagos As New dsContabilidadTableAdapters.CXP_PagosTableAdapter
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

        taDetalleReembolsos.DetalleReembolso_FillBy(dtDetalleReembolsos, varGlobal_IdEmpresa, idSolicitud)

        For Each rwComprobaciongts As dsContabilidad.Vw_CXP_AutorizacionesRow In dtDetalleReembolsos.Rows
            Dim contador As Integer = 0

            If rwComprobaciongts.folio = "ND" Then
                dgvDetalleReembolsos.Rows.Add("", "", rwComprobaciongts.totalPagadoTC, 0, "REEMB GTS S-" & idSolicitud, "S-" & idSolicitud & " " & rwComprobaciongts.decripcion, "ND")

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

            End If



        Next
        'dgvDetalleReembolsos.Rows.Add(cmbCuentaAbono.SelectedValue, cmbCuentaAbono.Text, 0, totalCargoDed + totalCargoNDed, "REEMB GTS S-" & idSolicitud & " ", nombreDeudor & " " & descripcion, "ND")
        dgvDetalleReembolsos.Focus()
    End Sub
End Class