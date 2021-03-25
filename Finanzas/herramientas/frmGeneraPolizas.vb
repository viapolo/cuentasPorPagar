Public Class frmGeneraPolizas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Try

            Dim fechaHorActual As Date = Date.Now
            'contadorPagosTes += 1
            Dim dtDatosSolicitud As New dsTesoreria.DatosSolicitudDataTable
            Dim rwDatosSolTmp As dsTesoreria.DatosSolicitudRow
            Dim dtDatosDetalleSolicitud As New dsTesoreria.DatosSolicitudDataTable
            Dim taCuentasConpaq As New contpaqTableAdapters.CuentasTableAdapter
            Dim taDatosAnexos As New dsProductionTableAdapters.SacaIVAanexoTableAdapter
            Dim taFactoraje As New dsTesoreriaTableAdapters.FactorajeTableAdapter
            Dim dtFactoraje As New dsTesoreria.FactorajeDataTable
            Dim taGenCorreos As New dsProductionTableAdapters.GEN_CorreosFasesTableAdapter
            Dim dtGenCorreos As New dsProduction.GEN_CorreosFasesDataTable
            Dim taGenCorreosFinagil As New dsProductionTableAdapters.GEN_Correos_SistemaFinagilTableAdapter
            Dim taDatosSolicitud As New dsTesoreriaTableAdapters.DatosSolicitudTableAdapter
            Dim taDatosPolizas As New dsTesoreriaTableAdapters.DatosPolizasTableAdapter
            Dim taCuentasBanc As New dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter
            Dim taPolizas As New dsTesoreriaTableAdapters.CXP_tipoDeDocumentoTableAdapter
            Dim taRegContable As New dsTesoreriaTableAdapters.CXP_RegContTableAdapter
            Dim taImpuestos As New dsTesoreriaTableAdapters.Vw_CXP_ImpuestosCFDITableAdapter
            Dim taConceptos As New dsTesoreriaTableAdapters.CXP_ConceptosTableAdapter

            taDatosSolicitud.SolicitudesDePago_FillBy(dtDatosSolicitud, txtImporte.Text, txtTipoSolicitud.Text, txtFolioSolicitud.Text)
            If dtDatosSolicitud.Rows.Count > 0 Then
                rwDatosSolTmp = dtDatosSolicitud.Rows(0)
                Dim tipoPoliza As Integer = taDatosPolizas.ObtTipoPoliza_ScalarQuery(rwDatosSolTmp.tipoSolicitud, rwDatosSolTmp.formaDePago, rwDatosSolTmp.monedaPago, rwDatosSolTmp.idEmpresa)
                Dim origenRecurso As Integer = taCuentasBanc.ObtieneCuentaContable_ScalarQuery(rwDatosSolTmp.origenRecurso)
                Dim folioPoliza As Integer = taPolizas.ConsultaUltimoFolio_ScalarQuery(tipoPoliza, varGlobal_IdEmpresa)
                If rwDatosSolTmp.tipoSolicitud = "CXP" Then

                    If tipoPoliza <> 0 Then
                        If rwDatosSolTmp.idConcepto = 43 Then
                            taDatosSolicitud.Detalle_Contabilidad_FillBy(dtDatosDetalleSolicitud, rwDatosSolTmp.destinoRecurso, rwDatosSolTmp.importeSolicitado, rwDatosSolTmp.origenRecurso, rwDatosSolTmp.referencia, txtFolioSolicitud.Text)
                            If dtDatosDetalleSolicitud.Rows.Count > 0 Then
                                Dim perImpuesto As Decimal = taDatosAnexos.ScalarQuery_SacaIVAAnexo(rwDatosSolTmp.noContrato)
                                For Each rwDetalleEvento As dsTesoreria.DatosSolicitudRow In dtDatosDetalleSolicitud
                                    taRegContable.Insert(rwDetalleEvento.ctaCargoPago, rwDetalleEvento.idProveedor, rwDetalleEvento.importeSolicitado, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                Next
                            End If
                            'cargo
                        Else
                            taDatosSolicitud.Detalle_Contabilidad_FillBy(dtDatosDetalleSolicitud, rwDatosSolTmp.destinoRecurso, rwDatosSolTmp.importeSolicitado, rwDatosSolTmp.origenRecurso, rwDatosSolTmp.referencia, txtFolioSolicitud.Text)
                            If dtDatosDetalleSolicitud.Rows.Count > 0 Then
                                For Each rwDetalleEvento As dsTesoreria.DatosSolicitudRow In dtDatosDetalleSolicitud
                                    Dim dtImpuestos As New dsTesoreria.Vw_CXP_ImpuestosCFDIDataTable
                                    taImpuestos.Fill(dtImpuestos, rwDetalleEvento.uuid)
                                    Dim contador As Integer = 0

                                    'cargo
                                    taRegContable.Insert(rwDetalleEvento.ctaCargoPago, rwDetalleEvento.idProveedor, rwDetalleEvento.importeSolicitado, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                    'abono
                                    taRegContable.Insert(origenRecurso, rwDetalleEvento.idProveedor, 0, rwDetalleEvento.totalPagado, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)

                                    For Each rowsCfdi As dsTesoreria.Vw_CXP_ImpuestosCFDIRow In dtImpuestos
                                        Dim efecto As String = ""
                                        Dim tipo As String = ""
                                        Dim retecionL As String = ""
                                        Dim mPago As Decimal = 0
                                        Dim percentPago As Decimal

                                        If rwDetalleEvento.totalOrg > 0 Then
                                            percentPago = CDec(rwDetalleEvento.totalPagado) / CDec(rwDetalleEvento.totalOrg)
                                        Else
                                            percentPago = 1
                                        End If



                                        If rowsCfdi.mTras <> "X" Then
                                            efecto = "TRA"
                                            mPago = Math.Round(CDec(Val(rowsCfdi.mTras) * percentPago), 2)
                                            tipo = "Federal"
                                            taRegContable.Insert(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(rwDetalleEvento.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "P", rowsCfdi.tasaOCuota)), rwDetalleEvento.idProveedor, mPago, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                            taRegContable.Insert(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(rwDetalleEvento.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "S", rowsCfdi.tasaOCuota)), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                        End If

                                        If rowsCfdi.mRet <> "X" Then
                                            efecto = "RET"
                                            mPago = Math.Round(CDec(Val(rowsCfdi.mRet) * percentPago), 2)
                                            tipo = "Federal"
                                            taRegContable.Insert(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(rwDetalleEvento.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "P", rowsCfdi.tasaOCuota)), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                            taRegContable.Insert(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(rwDetalleEvento.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "S", rowsCfdi.tasaOCuota)), rwDetalleEvento.idProveedor, mPago, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                        End If

                                        If contador = 0 Then
                                            If rowsCfdi.mLocTra <> "X" And rowsCfdi.mLocTra <> 0 Then
                                                efecto = "LOC"
                                                mPago = Math.Round(CDec(Val(rowsCfdi.mLocTra) * percentPago), 2)
                                                tipo = "Local"
                                                taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDetalleEvento.idConcepto, tipo, "TRA", "P")), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDetalleEvento.idConcepto, tipo, "TRA", "S")), rwDetalleEvento.idProveedor, mPago, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                            End If

                                            If rowsCfdi.mLocRet <> "X" And rowsCfdi.mLocRet <> 0 Then
                                                efecto = "LOC"
                                                mPago = Math.Round(CDec(Val(rowsCfdi.mLocRet) * percentPago), 2)
                                                tipo = "Local"
                                                taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDetalleEvento.idConcepto, tipo, "RET", "P")), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDetalleEvento.idConcepto, tipo, "RET", "S")), rwDetalleEvento.idProveedor, mPago, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                            End If
                                        End If

                                        contador += 1
                                    Next

                                Next
                            Else

                            End If
                            taPolizas.ConsumeUltimoFolio_UpdateQuery(taDatosPolizas.ObtTipoPoliza_ScalarQuery(rwDatosSolTmp.tipoSolicitud, rwDatosSolTmp.formaDePago, rwDatosSolTmp.monedaPago, rwDatosSolTmp.idEmpresa), varGlobal_IdEmpresa)
                        End If
                    End If
                ElseIf rwDatosSolTmp.tipoSolicitud = "AVI" Then

                    taDatosSolicitud.Detalle_Contabilidad_FillBy(dtDatosDetalleSolicitud, rwDatosSolTmp.destinoRecurso, rwDatosSolTmp.importeSolicitado, rwDatosSolTmp.origenRecurso, rwDatosSolTmp.referencia, txtFolioSolicitud.Text)
                    For Each rwDetalleEvento As dsTesoreria.DatosSolicitudRow In dtDatosDetalleSolicitud
                        'cargo
                        taRegContable.Insert(taCuentasConpaq.ObtieneIdCta_ScalarQuery("231101900020" & rwDetalleEvento.referencia.Substring(1, 4)), rwDetalleEvento.idProveedor, rwDetalleEvento.importeSolicitado, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " AVIO " & rwDetalleEvento.referencia, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                        'abono
                        taRegContable.Insert(origenRecurso, rwDetalleEvento.idProveedor, 0, rwDetalleEvento.importeSolicitado, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " AVIO " & rwDetalleEvento.referencia, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                    Next
                    ''''Para otro tipo de asientos
                ElseIf rwDatosSolTmp.tipoSolicitud = "FAC" Then
                    'Envia correo del pago
                    taFactoraje.Fill(dtFactoraje, rwDatosSolTmp.referencia.Trim)
                    Dim rwFactoraje As dsTesoreria.FactorajeRow
                    If dtFactoraje.Rows.Count > 0 Then
                        rwFactoraje = dtFactoraje.Rows(0)
                        If rwFactoraje.existe = 0 Then
                            taGenCorreos.Fill(dtGenCorreos, "Riesgos")
                            For Each rwGenCorreos As dsProduction.GEN_CorreosFasesRow In dtGenCorreos.Rows
                                taGenCorreosFinagil.Insert("", rwGenCorreos.Correo, "", "", "", "", "")
                            Next
                        End If
                    End If
                End If
            End If
            MsgBox("Proceso terminado")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
            Exit Sub
        End Try
    End Sub

    Private Sub btnNotificaPago_Click(sender As Object, e As EventArgs) Handles btnNotificaPago.Click

        'contadorPagosTes += 1
        Dim dtDatosSolicitud As New dsTesoreria.DatosSolicitudDataTable
        Dim rwDatosSolTmp As dsTesoreria.DatosSolicitudRow
        Dim dtDatosDetalleSolicitud As New dsTesoreria.DatosSolicitudDataTable
        Dim taCuentasConpaq As New contpaqTableAdapters.CuentasTableAdapter
        Dim taDatosAnexos As New dsProductionTableAdapters.SacaIVAanexoTableAdapter
        Dim taFactoraje As New dsTesoreriaTableAdapters.FactorajeTableAdapter
        Dim dtFactoraje As New dsTesoreria.FactorajeDataTable
        Dim taGenCorreos As New dsProductionTableAdapters.GEN_CorreosFasesTableAdapter
        Dim dtGenCorreos As New dsProduction.GEN_CorreosFasesDataTable
        Dim taGenCorreosFinagil As New dsProductionTableAdapters.GEN_Correos_SistemaFinagilTableAdapter
        Dim taSugPagos As New dsTesoreriaTableAdapters.Vw_CXP_SugPagoTesoreriaTableAdapter
        Dim dtSugPagos As New dsTesoreria.Vw_CXP_SugPagoTesoreriaDataTable
        Dim taCorreosProveedores As New dsHerramientasTableAdapters.DatosPagosTableAdapter
        Dim dtCorreosProveedores As New dsHerramientas.DatosPagosDataTable
        Dim rwCorreosProveedores As dsHerramientas.DatosPagosRow
        Dim taDetallePago As New dsHerramientasTableAdapters.CXP_PagosTableAdapter
        Dim dtDetallePago As New dsHerramientas.CXP_PagosDataTable
        Dim rwDetallePago As dsHerramientas.CXP_PagosRow
        Dim rwDetallePagoEnc As dsHerramientas.CXP_PagosRow
        Dim taDatosSolicitud As New dsTesoreriaTableAdapters.DatosSolicitudTableAdapter
        Dim taDatosPolizas As New dsTesoreriaTableAdapters.DatosPolizasTableAdapter
        Dim taCuentasBanc As New dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter
        Dim taPolizas As New dsTesoreriaTableAdapters.CXP_tipoDeDocumentoTableAdapter


        taDatosSolicitud.SolicitudesDePago_FillBy(dtDatosSolicitud, txtTipoSolicitud.Text, txtFolioSolicitud.Text, txtImporte.Text)
        If dtDatosSolicitud.Rows.Count > 0 Then
            rwDatosSolTmp = dtDatosSolicitud.Rows(0)
            Dim tipoPoliza As Integer = taDatosPolizas.ObtTipoPoliza_ScalarQuery(rwDatosSolTmp.tipoSolicitud, rwDatosSolTmp.formaDePago, rwDatosSolTmp.monedaPago, rwDatosSolTmp.idEmpresa)
            Dim origenRecurso As Integer = taCuentasBanc.ObtieneCuentaContable_ScalarQuery(rwDatosSolTmp.origenRecurso)
            Dim folioPoliza As Integer = taPolizas.ConsultaUltimoFolio_ScalarQuery(tipoPoliza, varGlobal_IdEmpresa)


            'Notifica pago
            taCorreosProveedores.Fill(dtCorreosProveedores, rwDatosSolTmp.idProveedor)
            Dim contNotifica As Integer = 0
            For Each rwCorreosProveedores In dtCorreosProveedores.Rows
                If rwCorreosProveedores.notificaPago = True Then
                    taDetallePago.Fill(dtDetallePago, rwDatosSolTmp.tipoSolicitud, varGlobal_IdEmpresa, rwDatosSolTmp.folioSolicitud)
                    If dtDetallePago.Rows.Count > 0 Then
                        rwDetallePagoEnc = dtDetallePago.Rows(0)
                        Dim mensaje As String = "<html><body><font size=3 face='Arial'><h1><font size=3 align'center'> Estimado (a): " & rwDetallePagoEnc.razonSocial &
                                    " le notificamos que se ha pagado la solicitud " & txtTipoSolicitud.Text & " - " & txtFolioSolicitud.Text & " por la cantidad de " & FormatCurrency(rwDetallePagoEnc.importe) & " que contiene los siguientes comprobantes: " &
                                    "<table align='center' border='1' cellspacing='0' cellpadding='2'>" &
                                    "<tr>" &
                                        "<td>Folio de Factura</td>" &
                                        "<td>Serie</td>" &
                                        "<td>UUID</td>" &
                                        "<td>Importe Factura</td>" &
                                        "<td>Importe Pagado</td>" &
                                        "<td>Moneda</td>" &
                                        "<td>Fecha Pago</td>" &
                                        "<td>Referencia</td>" &
                                    "</tr>"
                        For Each rwDetallePago In dtDetallePago.Rows
                            mensaje = mensaje &
                                     "<tr>" &
                                        "<td>" & rwDetallePago.folio & "</td>" &
                                        "<td>" & rwDetallePago.serie & "</td>" &
                                        "<td>" & rwDetallePago.uuid & "</td>" &
                                        "<td>" & rwDetallePago.total.ToString("c") & "</td>" &
                                        "<td>" & rwDetallePago.totalPagado.ToString("c") & "</td>" &
                                        "<td>" & rwDetallePago.monedaPago & "</td>" &
                                        "<td>" & rwDetallePago.fechaPago & "</td>" &
                                        "<td>" & rwDetallePago.referencia & "</td>" &
                                    "</tr>"
                        Next
                        mensaje = mensaje & "</table>" & vbNewLine &
                                "<HR width=20%>" &
                                    "<tfoot><tr><font align=" & Chr(34) & "center" & Chr(34) & "size=3 face=" & Chr(34) & "Arial" & Chr(34) & ">" & "Atentamente: " & rwDetallePagoEnc.nombreEmpresa & vbNewLine & "</font></tr></tfoot>" &
                                "</body></html>"
                        If rwCorreosProveedores.adjuntaComprobante = True Then
                            taGenCorreosFinagil.Insert("Pagos@finagil.com.mx", rwCorreosProveedores.direccionCorreo, "Notificación de pago de Factura: " & rwDetallePagoEnc.idEmpresas.ToString.Replace("24", "Servicios Arfin").Replace("23", "Finagil"), mensaje, False, Date.Now, "CXP\ComPago\" & rwDetallePagoEnc.uuidPago & ".pdf")
                            taGenCorreosFinagil.Insert("Pagos@finagil.com.mx", "viapolo@finagil.com.mx", "Notificación de pago de Factura: " & rwDetallePagoEnc.idEmpresas.ToString.Replace("24", "Servicios Arfin").Replace("23", "Finagil"), mensaje, False, Date.Now, "CXP\ComPago\" & rwDetallePagoEnc.uuidPago & ".pdf")
                        Else
                            taGenCorreosFinagil.Insert("Pagos@finagil.com.mx", rwCorreosProveedores.direccionCorreo, "Notificación de pago de Factura: " & rwDetallePagoEnc.idEmpresas.ToString.Replace("24", "Servicios Arfin").Replace("23", "Finagil"), mensaje, False, Date.Now, "")
                            taGenCorreosFinagil.Insert("Pagos@finagil.com.mx", "viapolo@finagil.com.mx", "Notificación de pago de Factura: " & rwDetallePagoEnc.idEmpresas.ToString.Replace("24", "Servicios Arfin").Replace("23", "Finagil"), mensaje, False, Date.Now, "")
                        End If
                        If rwCorreosProveedores.notificaContabilidad = True And contNotifica = 0 Then
                            taGenCorreosFinagil.Insert("Pagos@finagil.com.mx", "lgarcia@finagil.com.mx", "Notificación de pago de Factura: " & rwDetallePagoEnc.idEmpresas.ToString.Replace("24", "Servicios Arfin").Replace("23", "Finagil"), mensaje, False, Date.Now, "CXP\ComPago\" & rwDetallePagoEnc.uuidPago & ".pdf")
                        End If
                    End If
                End If
                contNotifica += 1
            Next
            'Termina notifica pago
        End If
    End Sub
End Class