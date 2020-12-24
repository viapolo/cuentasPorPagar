Imports System.IO
Public Class frmGenPolizas


    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        generaPolizaD()
    End Sub

    Private Sub generaPolizaD()
        Dim filePolizaD As StreamWriter
        Dim encabezadoD As String = ""

        Dim taPolizasEnc As New dsContabilidadTableAdapters.Vw_CXP_PolizasEncTableAdapter
        Dim dtPolizasEnc As New dsContabilidad.Vw_CXP_PolizasEncDataTable
        Dim taTipoDocumento As New dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter

        Dim taPolizaDet As New dsContabilidadTableAdapters.Vw_CXP_PolizasDetTableAdapter
        Dim taPolizaDetUuid As New dsProductionTableAdapters.Vw_CXP_PolizasDetTableAdapter
        Dim dtPolizaDet As New dsContabilidad.Vw_CXP_PolizasDetDataTable
        Dim dtPolizaDetUuid As New dsContabilidad.Vw_CXP_PolizasDetDataTable
        Dim taCfdi As New dsContabilidadTableAdapters.vw_CXP_XmlCfdi2_grpUuidTableAdapter

        Dim taDetallePolizas As New dsContabilidadTableAdapters.DataTableDetallePolizasTableAdapter

        'Dim CuentasTableAdapter As New contpaqTableAdapters.CuentasTableAdapter
        Dim dtCuentasCpq As New contpaq.CuentasDataTable
        Dim rwCuentasCpq As contpaq.CuentasRow
        Dim Cuenta As Integer = 1

        sfdPolizas = New SaveFileDialog
        sfdPolizas.Filter = "txt files (*.txt)|*.txt"
        sfdPolizas.FilterIndex = 2
        sfdPolizas.RestoreDirectory = True
        sfdPolizas.FileName = "PD " & taTipoDocumento.ObtTipoDeAsiento_ScalarQuery(varGlobal_IdEmpresa) & " " & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & ".txt"

        If sfdPolizas.ShowDialog = DialogResult.OK Then
            taPolizasEnc.Fill(dtPolizasEnc, dtpFechaInicial.Value.ToShortDateString, dtpFechaFinal.Value.AddDays(1).ToShortDateString, taTipoDocumento.ObtTipoDeAsiento_ScalarQuery(varGlobal_IdEmpresa), varGlobal_IdEmpresa, varGlobal_idDocumento)
            Dim estatus As String = ""
            If varGlobal_IdEmpresa = "24" Then
                Dim renglonD As String = ""
                If dtPolizasEnc.Rows.Count > 0 Then
                    filePolizaD = New StreamWriter(sfdPolizas.FileName)
                    tsBarProceso.Maximum = dtPolizasEnc.Rows.Count
                    Dim dtDetalleSol As New dsContabilidad.DataTableDetallePolizasDataTable
                    Dim rwDetalleSol As dsContabilidad.DataTableDetallePolizasRow

                    For Each rwPolizasEnc As dsContabilidad.Vw_CXP_PolizasEncRow In dtPolizasEnc.Rows
                        tsBarProceso.Value = Cuenta
                        Application.DoEvents()

                        Cuenta = Cuenta + 1
                        Dim nConceptoD As String = ""
                        Dim idConceptoD As Integer

                        taDetallePolizas.Fill(dtDetalleSol, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, varGlobal_IdEmpresa)

                        If dtDetalleSol.Rows.Count > 0 Then
                            rwDetalleSol = dtDetalleSol.Rows(0)
                            nConceptoD = rwDetalleSol.nConcepto
                            idConceptoD = rwDetalleSol.idConcepto
                        End If

                        'MsgBox(taPolizaDet.Obtieneestatus_ScalarQuery(rwPolizasEnc.folioTipoDocumento, varGlobal_IdEmpresa, rwPolizasEnc.folioSolicitud))

                        If taPolizaDet.Obtieneestatus_ScalarQuery(rwPolizasEnc.folioTipoDocumento, varGlobal_IdEmpresa, rwPolizasEnc.folioSolicitud) = "NE" Then
                            estatus = ""
                        Else
                            estatus = "CAX-"
                        End If


                        Dim nConcepto As String = estatus & rwPolizasEnc.razonSocial & " " & rwPolizasEnc.folioSolicitud & " " & nConceptoD.Replace("GASTOS A COMPROBAR", "COMPROBACION DE GASTOS")
                        If nConcepto.Length > 100 Then
                            nConcepto = nConcepto.Substring(0, 99)
                        End If
                        nConcepto = Stuff(nConcepto, "D", " ", 100)

                        encabezadoD = "P  " & rwPolizasEnc.fecha.ToString("yyyyMMdd") & "    3" & Space(10 - rwPolizasEnc.folioTipoDocumento.ToString.Length) & rwPolizasEnc.folioTipoDocumento.ToString & " 1 0          " & nConcepto & " 11 0 0 "
                        taPolizaDet.DetallePoliza_FillBy(dtPolizaDet, rwPolizasEnc.idEmpresa, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, idConceptoD)
                        filePolizaD.WriteLine(Eliminar_AcentosPolizas(encabezadoD.ToUpper))
                        Dim uuid As String = ""
                        Dim uuidA(0) As String
                        Dim cont As Integer = 1
                        Dim totalCargo As Decimal = 0
                        Dim totalAbono As Decimal = 0
                        Dim diferencia As Decimal = 0

                        For Each rwPolDet As dsContabilidad.Vw_CXP_PolizasDetRow In dtPolizaDet.Rows
                            If rwPolDet.TipoMovto = 0 Then
                                totalAbono += rwPolDet.importe
                            Else
                                totalCargo += rwPolDet.importe
                            End If
                        Next

                        If totalCargo <> totalAbono Then
                            'MsgBox((totalCargo - totalAbono).ToString & "-" & rwPolizasEnc.folioSolicitud)
                            diferencia = totalCargo - totalAbono
                        End If
                        For Each drDetConceptos As dsContabilidad.DataTableDetallePolizasRow In dtDetalleSol.Rows
                            Dim taPolizaDetB As New dsContabilidadTableAdapters.Vw_CXP_PolizasDetTableAdapter
                            Dim dtPolizaDetB As New dsContabilidad.Vw_CXP_PolizasDetDataTable

                            taPolizaDetB.DetallePoliza_FillBy(dtPolizaDetB, rwPolizasEnc.idEmpresa, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, drDetConceptos.idConcepto)
                            For Each rwPolizasDet As dsContabilidad.Vw_CXP_PolizasDetRow In dtPolizaDetB.Rows

                                CuentasTableAdapter.DatosCtas_FillBy(dtCuentasCpq, rwPolizasDet.idCuenta)

                                If dtCuentasCpq.Rows.Count >= 1 Then
                                    rwCuentasCpq = dtCuentasCpq.Rows(0)
                                    Dim dImporte As String = ""
                                    If cont = 1 Then
                                        dImporte = Stuff(Trim((rwPolizasDet.importe + diferencia).ToString), "D", " ", 20)
                                    Else
                                        dImporte = Stuff(Trim(rwPolizasDet.importe.ToString), "D", " ", 20)
                                    End If
                                    Dim dReferencia As String = Stuff(Trim("S-" & rwPolizasDet.folioSolicitud & " " & Eliminar_AcentosPolizas(rwPolizasDet.concepto.Trim)), "D", " ", 100)
                                    Dim dReferencia1 As String = "" 'Stuff(Trim(rwPolizasDet.folioSolicitud), "D", " ", 20)

                                    If rwPolizasDet.noContrato = String.Empty Then
                                        If cont = dtPolizaDet.Rows.Count Then
                                            If idConceptoD = 34 Or idConceptoD = 41 Then
                                                dReferencia1 = rwPolizasDet.referencia
                                            Else
                                                If dReferencia.IndexOf(Eliminar_AcentosPolizas(rwPolizasEnc.razonSocial)) > 0 Then
                                                    dReferencia1 = "PROV F-" & taCfdi.ObtieneFolio_ScalarQuery(rwPolizasDet.uuid) '& rwPolizasDet.folio
                                                End If
                                            End If
                                        Else
                                            If dReferencia.IndexOf(Eliminar_AcentosPolizas(rwPolizasEnc.razonSocial)) > 0 Then
                                                dReferencia1 = "PROV F-" & taCfdi.ObtieneFolio_ScalarQuery(rwPolizasDet.uuid) '& rwPolizasDet.folio
                                            Else
                                                dReferencia1 = Stuff(Trim(rwPolizasDet.referencia.Replace("IVA ", "")), "D", " ", 20)
                                            End If
                                        End If
                                    Else
                                        dReferencia1 = Stuff(Trim(rwPolizasDet.noContrato), "D", " ", 20)
                                    End If

                                    If dReferencia1.Length > 20 Then
                                        dReferencia1 = Stuff(dReferencia1.Substring(0, 19), "D", " ", 20)
                                    Else
                                        dReferencia1 = Stuff(dReferencia1, "D", " ", 20)
                                    End If


                                    If idConceptoD = 34 Or idConceptoD = 41 Then
                                        dReferencia = Stuff(Trim(Eliminar_AcentosPolizas(rwPolizasDet.concepto.Trim)), "D", " ", 100)
                                    End If

                                    If dReferencia.Length > 100 Then
                                        dReferencia = dReferencia.Substring(0, 100)
                                    End If

                                    Dim dsegNegocios As String = Stuff(Trim(rwPolizasDet.idSuc), "D", " ", 4)
                                    Dim idDiario As String = Stuff("0", "D", " ", 10)
                                    Dim importeME As String = "0.00"

                                    If CDec(rwPolizasDet.TipoDeCambio) > 1 Then
                                        importeME = Stuff((Math.Round((CDec(rwPolizasDet.importe) * CDec(rwPolizasDet.TipoDeCambio)), 2).ToString), "D", " ", 20)
                                    Else
                                        importeME = Stuff(importeME, "D", " ", 20)
                                    End If

                                    If rwPolizasDet.uuid <> "ND" Then
                                        renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & dReferencia & Space(1) & dsegNegocios & Space(1) & rwPolizasDet.uuid & Space(37) & vbNewLine &
                                            "AM " & rwPolizasDet.uuid & vbNewLine & "AD " & rwPolizasDet.uuid
                                    Else
                                        renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & dReferencia & Space(1) & dsegNegocios & Space(1)
                                    End If
                                End If
                                filePolizaD.WriteLine(renglonD.ToUpper)
                                cont += 1
                            Next
                        Next
                    Next
                    filePolizaD.Close()
                    MsgBox("Proceso terminado", MsgBoxStyle.Information, "")
                    tsBarProceso.Value = 0
                    Application.DoEvents()

                End If
            ElseIf varGlobal_IdEmpresa = "23" Then
                Dim renglonD As String = ""
                If dtPolizasEnc.Rows.Count > 0 Then
                    filePolizaD = New StreamWriter(sfdPolizas.FileName)
                    tsBarProceso.Maximum = dtPolizasEnc.Rows.Count
                    Dim dtDetalleSol As New dsContabilidad.DataTableDetallePolizasDataTable
                    Dim rwDetalleSol As dsContabilidad.DataTableDetallePolizasRow

                    For Each rwPolizasEnc As dsContabilidad.Vw_CXP_PolizasEncRow In dtPolizasEnc.Rows
                        tsBarProceso.Value = Cuenta
                        'Application.DoEvents()

                        Cuenta = Cuenta + 1
                        Dim nConceptoD As String = ""
                        Dim idConceptoD As Integer

                        taDetallePolizas.Fill(dtDetalleSol, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, varGlobal_IdEmpresa)

                        If dtDetalleSol.Rows.Count > 0 Then
                            rwDetalleSol = dtDetalleSol.Rows(0)
                            nConceptoD = rwDetalleSol.nConcepto
                            idConceptoD = rwDetalleSol.idConcepto
                        End If

                        'MsgBox(taPolizaDet.Obtieneestatus_ScalarQuery(rwPolizasEnc.folioTipoDocumento, varGlobal_IdEmpresa, rwPolizasEnc.folioSolicitud))

                        If taPolizaDet.Obtieneestatus_ScalarQuery(rwPolizasEnc.folioTipoDocumento, varGlobal_IdEmpresa, rwPolizasEnc.folioSolicitud) = "NE" Then
                            estatus = ""
                        Else
                            estatus = "CAX-"
                        End If


                        Dim nConcepto As String = estatus & rwPolizasEnc.razonSocial & " " & rwPolizasEnc.folioSolicitud & " " & nConceptoD.Replace("GASTOS A COMPROBAR", "COMPROBACION DE GASTOS")
                        If nConcepto.Length > 100 Then
                            nConcepto = nConcepto.Substring(0, 99)
                        End If
                        nConcepto = Stuff(nConcepto, "D", " ", 100)

                        encabezadoD = "P  " & rwPolizasEnc.fecha.ToString("yyyyMMdd") & "    3" & Space(10 - rwPolizasEnc.folioTipoDocumento.ToString.Length) & rwPolizasEnc.folioTipoDocumento.ToString & " 1 0          " & nConcepto & " 11 0 0 "
                        taPolizaDet.DetallePoliza_FillBy(dtPolizaDet, rwPolizasEnc.idEmpresa, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, idConceptoD)
                        filePolizaD.WriteLine(Eliminar_AcentosPolizas(encabezadoD.ToUpper))
                        Dim uuid As String = ""
                        Dim uuidA(0) As String
                        Dim cont As Integer = 1
                        Dim totalCargo As Decimal = 0
                        Dim totalAbono As Decimal = 0
                        Dim diferencia As Decimal = 0


                        For Each rwPolDet As dsContabilidad.Vw_CXP_PolizasDetRow In dtPolizaDet.Rows
                            If rwPolDet.TipoMovto = 0 Then
                                totalAbono += rwPolDet.importe
                            Else
                                totalCargo += rwPolDet.importe
                            End If
                        Next

                        If totalCargo <> totalAbono Then
                            'MsgBox((totalCargo - totalAbono).ToString & "-" & rwPolizasEnc.folioSolicitud)
                            diferencia = totalCargo - totalAbono
                        End If
                        For Each drDetConceptos As dsContabilidad.DataTableDetallePolizasRow In dtDetalleSol.Rows
                            Dim taPolizaDetB As New dsContabilidadTableAdapters.Vw_CXP_PolizasDetTableAdapter
                            Dim dtPolizaDetB As New dsContabilidad.Vw_CXP_PolizasDetDataTable

                            taPolizaDetB.DetallePoliza_FillBy(dtPolizaDetB, rwPolizasEnc.idEmpresa, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, drDetConceptos.idConcepto)
                            For Each rwPolizasDet As dsContabilidad.Vw_CXP_PolizasDetRow In dtPolizaDetB.Rows

                                CuentasTableAdapter.DatosCtas_FillBy(dtCuentasCpq, rwPolizasDet.idCuenta)

                                If dtCuentasCpq.Rows.Count >= 1 Then
                                    rwCuentasCpq = dtCuentasCpq.Rows(0)
                                    Dim dImporte As String = ""
                                    If cont = 1 Then
                                        dImporte = Stuff(Trim((rwPolizasDet.importe + diferencia).ToString), "D", " ", 20)
                                    Else
                                        dImporte = Stuff(Trim(rwPolizasDet.importe.ToString), "D", " ", 20)
                                    End If
                                    Dim dReferencia As String = Stuff(Trim("S-" & rwPolizasDet.folioSolicitud & " " & Eliminar_AcentosPolizas(rwPolizasDet.concepto.Trim)), "D", " ", 100)
                                    Dim dReferencia1 As String = "" 'Stuff(Trim(rwPolizasDet.folioSolicitud), "D", " ", 20)

                                    If rwPolizasDet.noContrato = String.Empty Then
                                        If cont = dtPolizaDet.Rows.Count Then
                                            If idConceptoD = 34 Or idConceptoD = 41 Then
                                                dReferencia1 = rwPolizasDet.referencia
                                            Else
                                                If dReferencia.IndexOf(Eliminar_AcentosPolizas(rwPolizasEnc.razonSocial)) > 0 Then
                                                    dReferencia1 = "PROV F-" & taCfdi.ObtieneFolio_ScalarQuery(rwPolizasDet.uuid) '& rwPolizasDet.folio
                                                End If
                                            End If
                                        Else
                                            If dReferencia.IndexOf(Eliminar_AcentosPolizas(rwPolizasEnc.razonSocial)) > 0 Then
                                                dReferencia1 = "PROV F-" & taCfdi.ObtieneFolio_ScalarQuery(rwPolizasDet.uuid) '& rwPolizasDet.folio
                                            Else
                                                dReferencia1 = Stuff(Trim(rwPolizasDet.referencia.Replace("IVA ", "")), "D", " ", 20)
                                            End If
                                        End If
                                    Else
                                        dReferencia1 = Stuff(Trim(rwPolizasDet.noContrato), "D", " ", 20)
                                    End If

                                    If dReferencia1.Length > 20 Then
                                        dReferencia1 = Stuff(dReferencia1.Substring(0, 19), "D", " ", 20)
                                    Else
                                        dReferencia1 = Stuff(dReferencia1, "D", " ", 20)
                                    End If


                                    If idConceptoD = 34 Or idConceptoD = 41 Then
                                        dReferencia = Stuff(Trim(Eliminar_AcentosPolizas(rwPolizasDet.concepto.Trim)), "D", " ", 100)
                                    End If

                                    If dReferencia.Length > 100 Then
                                        dReferencia = dReferencia.Substring(0, 100)
                                    End If

                                    Dim dsegNegocios As String = Stuff(Trim(rwPolizasDet.idSuc), "D", " ", 4)
                                    Dim idDiario As String = Stuff("0", "D", " ", 10)
                                    Dim importeME As String = "0.00"

                                    If CDec(rwPolizasDet.TipoDeCambio) > 1 Then
                                        importeME = Stuff((Math.Round((CDec(rwPolizasDet.importe) * CDec(rwPolizasDet.TipoDeCambio)), 2).ToString), "D", " ", 20)
                                    Else
                                        importeME = Stuff(importeME, "D", " ", 20)
                                    End If

                                    If rwPolizasDet.uuid <> "ND" Then
                                        renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & dReferencia & Space(1) & dsegNegocios & Space(1) & rwPolizasDet.uuid & Space(37) & vbNewLine &
                                            "AM " & rwPolizasDet.uuid & vbNewLine & "AD " & rwPolizasDet.uuid
                                    Else
                                        renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & dReferencia & Space(1) & dsegNegocios & Space(1)
                                    End If
                                End If
                                filePolizaD.WriteLine(renglonD.ToUpper)
                                cont += 1
                            Next
                        Next
                    Next
                    filePolizaD.Close()
                    MsgBox("Proceso terminado", MsgBoxStyle.Information, "")
                    tsBarProceso.Value = 0
                    Application.DoEvents()

                End If
                'If dtPolizasEnc.Rows.Count > 0 Then
                '    filePolizaD = New StreamWriter(sfdPolizas.FileName)
                '    tsBarProceso.Maximum = dtPolizasEnc.Rows.Count
                '    Dim dtDetalleSol As New dsContabilidad.DataTableDetallePolizasDataTable
                '    Dim rwDetalleSol As dsContabilidad.DataTableDetallePolizasRow

                '    For Each rwPolizasEnc As dsContabilidad.Vw_CXP_PolizasEncRow In dtPolizasEnc.Rows
                '        tsBarProceso.Value = Cuenta
                '        Application.DoEvents()

                '        Cuenta = Cuenta + 1
                '        Dim nConceptoD As String = ""
                '        Dim idConceptoD As Integer

                '        taDetallePolizas.Fill(dtDetalleSol, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, varGlobal_IdEmpresa)


                '        If dtDetalleSol.Rows.Count > 0 Then
                '            rwDetalleSol = dtDetalleSol.Rows(0)
                '            nConceptoD = rwDetalleSol.nConcepto
                '            idConceptoD = rwDetalleSol.idConcepto
                '        End If

                '        'MsgBox(taPolizaDet.Obtieneestatus_ScalarQuery(rwPolizasEnc.folioTipoDocumento, varGlobal_IdEmpresa, rwPolizasEnc.folioSolicitud))

                '        If taPolizaDet.Obtieneestatus_ScalarQuery(rwPolizasEnc.folioTipoDocumento, varGlobal_IdEmpresa, rwPolizasEnc.folioSolicitud) = "NE" Then
                '            estatus = ""
                '        Else
                '            estatus = "CAX-"
                '        End If


                '        Dim nConcepto As String = estatus & rwPolizasEnc.razonSocial & " " & rwPolizasEnc.folioSolicitud & " " & nConceptoD.Replace("GASTOS A COMPROBAR", "COMPROBACION DE GASTOS").Replace(vbLf, "")
                '        If nConcepto.Length > 100 Then
                '            nConcepto = nConcepto.Substring(0, 99)
                '        End If
                '        nConcepto = Stuff(nConcepto, "D", " ", 100)

                '        encabezadoD = "P  " & rwPolizasEnc.fecha.ToString("yyyyMMdd") & "    3" & Space(10 - rwPolizasEnc.folioTipoDocumento.ToString.Length) & rwPolizasEnc.folioTipoDocumento.ToString & " 1 0          " & nConcepto & " 11 0 0 "
                '        taPolizaDet.DetallePoliza_FillBy(dtPolizaDet, rwPolizasEnc.idEmpresa, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, idConceptoD)
                '        filePolizaD.WriteLine(Eliminar_AcentosPolizas(encabezadoD.ToUpper))
                '        Dim uuid As String = ""
                '        Dim uuidA(0) As String
                '        Dim cont As Integer = 1
                '        Dim totalCargo As Decimal = 0
                '        Dim totalAbono As Decimal = 0
                '        Dim diferencia As Decimal = 0

                '        For Each rwPolDet As dsContabilidad.Vw_CXP_PolizasDetRow In dtPolizaDet.Rows
                '            If rwPolDet.TipoMovto = 0 Then
                '                totalAbono += rwPolDet.importe
                '            Else
                '                totalCargo += rwPolDet.importe
                '            End If
                '        Next

                '        If totalCargo <> totalAbono Then
                '            'MsgBox((totalCargo - totalAbono).ToString & "-" & rwPolizasEnc.folioSolicitud)
                '            diferencia = totalCargo - totalAbono
                '        End If
                '        For Each drDetConceptos As dsContabilidad.DataTableDetallePolizasRow In dtDetalleSol.Rows
                '            For Each rwPolizasDet As dsContabilidad.Vw_CXP_PolizasDetRow In dtPolizaDet.Rows

                '                CuentasTableAdapter.DatosCtas_FillBy(dtCuentasCpq, rwPolizasDet.idCuenta)

                '                'If rwPolizasDet.folioTipoDocumento = 1088 Then
                '                '    MsgBox("Hola")
                '                'End If

                '                If dtCuentasCpq.Rows.Count >= 1 Then
                '                    rwCuentasCpq = dtCuentasCpq.Rows(0)
                '                    Dim dImporte As String = ""
                '                    If cont = 1 Then
                '                        dImporte = Stuff(Trim((rwPolizasDet.importe + diferencia).ToString), "D", " ", 20)
                '                    Else
                '                        dImporte = Stuff(Trim(rwPolizasDet.importe.ToString), "D", " ", 20)
                '                    End If
                '                    Dim dReferencia As String = Stuff(Trim("S-" & rwPolizasDet.folioSolicitud & " " & Eliminar_AcentosPolizas(rwPolizasDet.concepto.Trim)), "D", " ", 100)
                '                    Dim dReferencia1 As String = "" 'Stuff(Trim(rwPolizasDet.folioSolicitud), "D", " ", 20)

                '                    If rwPolizasDet.noContrato = String.Empty Then
                '                        If cont = dtPolizaDet.Rows.Count Then
                '                            If idConceptoD = 34 Or idConceptoD = 41 Then
                '                                dReferencia1 = rwPolizasDet.referencia
                '                            Else
                '                                dReferencia1 = "PROV F-" & taCfdi.ObtieneFolio_ScalarQuery(rwPolizasDet.uuid) '& rwPolizasDet.folio
                '                            End If

                '                        Else
                '                            dReferencia1 = Stuff(Trim(rwPolizasDet.referencia.Replace("IVA ", "")), "D", " ", 20)
                '                        End If
                '                    Else
                '                        dReferencia1 = Stuff(Trim(rwPolizasDet.noContrato), "D", " ", 20)
                '                    End If

                '                    If dReferencia1.Length > 20 Then
                '                        dReferencia1 = Stuff(dReferencia1.Substring(0, 19), "D", " ", 20)
                '                    Else
                '                        dReferencia1 = Stuff(dReferencia1, "D", " ", 20)
                '                    End If


                '                    If idConceptoD = 34 Or idConceptoD = 41 Then
                '                        dReferencia = Stuff(Trim(Eliminar_AcentosPolizas(rwPolizasDet.concepto.Trim)), "D", " ", 100)
                '                    End If

                '                    If dReferencia.Length > 100 Then
                '                        dReferencia = dReferencia.Substring(0, 100)
                '                    End If




                '                    Dim dsegNegocios As String = Stuff(Trim(rwPolizasDet.idSuc), "D", " ", 4)
                '                    Dim idDiario As String = Stuff("0", "D", " ", 10)
                '                    Dim importeME As String = "0.00"

                '                    If CDec(rwPolizasDet.TipoDeCambio) > 1 Then
                '                        importeME = Stuff((Math.Round((CDec(rwPolizasDet.importe) * CDec(rwPolizasDet.TipoDeCambio)), 2).ToString), "D", " ", 20)
                '                    Else
                '                        importeME = Stuff(importeME, "D", " ", 20)
                '                    End If

                '                    If rwPolizasDet.uuid <> "ND" Then
                '                        renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & dReferencia & Space(1) & dsegNegocios & Space(1) & rwPolizasDet.uuid & Space(37) & vbNewLine &
                '                            "AM " & rwPolizasDet.uuid & vbNewLine & "AD " & rwPolizasDet.uuid
                '                    Else
                '                        renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & dReferencia & Space(1) & dsegNegocios & Space(1)
                '                    End If
                '                Else
                '                    renglonD = "NO EXISTE CUENTA CONTABLE"
                '                    filePolizaD.WriteLine(renglonD.ToUpper)
                '                    'Exit For
                '                End If
                '                filePolizaD.WriteLine(renglonD.ToUpper)
                '                cont += 1
                '            Next
                '        Next
                '    Next
                '    filePolizaD.Close()
                '    MsgBox("Proceso terminado", MsgBoxStyle.Information, "")
                '    tsBarProceso.Value = 0
                '    Application.DoEvents()

                'End If
            End If
        Else
            MsgBox("Proceso cancelado...", MsgBoxStyle.Information, "")
        End If
    End Sub


    Private Sub generaPolizaP()
        Dim filePolizaD As StreamWriter
        Dim encabezadoD As String = ""
        Dim renglonD As String = ""
        Dim taPolizasEnc As New dsContabilidadTableAdapters.Vw_CXP_PolizasEncTableAdapter
        Dim dtPolizasEnc As New dsContabilidad.Vw_CXP_PolizasEncDataTable
        Dim taTipoDocumento As New dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter

        Dim taTipoDePoliza As New dsContabilidadTableAdapters.CXP_tipoDeDocumentoTableAdapter
        Dim dtTipoDePoliza As New dsContabilidad.CXP_tipoDeDocumentoDataTable

        Dim taPolizaDet As New dsContabilidadTableAdapters.Vw_CXP_PolizasDetTableAdapter
        Dim taPolizaDetUuid As New dsProductionTableAdapters.Vw_CXP_PolizasDetTableAdapter
        Dim dtPolizaDet As New dsContabilidad.Vw_CXP_PolizasDetDataTable
        Dim dtPolizaDetUuid As New dsContabilidad.Vw_CXP_PolizasDetDataTable
        Dim taCuentasBancarias As New dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter

        Dim taDetallePolizas As New dsContabilidadTableAdapters.DataTableDetallePolizasTableAdapter

        'Dim CuentasTableAdapter As New contpaqTableAdapters.CuentasTableAdapter
        Dim dtCuentasCpq As New contpaq.CuentasDataTable
        Dim rwCuentasCpq As contpaq.CuentasRow
        Dim dtProveedoresCpq As New contpaq.ProveedoresDataTable
        Dim rwProveedoresCpq As contpaq.ProveedoresRow

        Dim Cuenta As Integer = 1

        sfdPolizas = New SaveFileDialog
        sfdPolizas.Filter = "txt files (*.txt)|*.txt"
        sfdPolizas.FilterIndex = 2
        sfdPolizas.RestoreDirectory = True

        If fbdPolizas.ShowDialog = DialogResult.OK Then

            taTipoDePoliza.ObtTipoDePoliza_FillBy(dtTipoDePoliza, "Egreso", varGlobal_IdEmpresa)

            For Each rwTipoPoliza As dsContabilidad.CXP_tipoDeDocumentoRow In dtTipoDePoliza
                Dim fileNamePoliza As String = ""

                taPolizasEnc.PolizasXRangoFechas_FillBy(dtPolizasEnc, dtpFechaInicio.Value, dtpFechaFin.Value, rwTipoPoliza.idTipoDeDocumento, varGlobal_IdEmpresa, varGlobal_idDocumento)
                If dtPolizasEnc.Rows.Count > 0 Then


                    fileNamePoliza = "PE " & rwTipoPoliza.idConpaq.ToString & " " & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & ".txt"
                    If varGlobal_IdEmpresa = "24" Then
                        If dtPolizasEnc.Rows.Count > 0 Then
                            filePolizaD = New StreamWriter(fbdPolizas.SelectedPath & "\" & fileNamePoliza)
                            tsBarProceso.Maximum = dtPolizasEnc.Rows.Count
                            Dim dtDetalleSol As New dsContabilidad.DataTableDetallePolizasDataTable
                            Dim rwDetalleSol As dsContabilidad.DataTableDetallePolizasRow

                            For Each rwPolizasEnc As dsContabilidad.Vw_CXP_PolizasEncRow In dtPolizasEnc.Rows

                                tsBarProceso.Value = Cuenta
                                ProveedoresContpaqTableAdapter.Fill(dtProveedoresCpq, rwPolizasEnc.rfc)
                                If dtProveedoresCpq.Rows.Count > 0 Then
                                    rwProveedoresCpq = dtProveedoresCpq.Rows(0)



                                    'Application.DoEvents()

                                    Cuenta = Cuenta + 1

                                    Dim nConceptoD As String = ""
                                    Dim idConceptoD As Integer

                                    taDetallePolizas.Fill(dtDetalleSol, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, varGlobal_IdEmpresa)

                                    If dtDetalleSol.Rows.Count > 0 Then
                                        rwDetalleSol = dtDetalleSol.Rows(0)
                                        nConceptoD = rwDetalleSol.nConcepto
                                        idConceptoD = rwDetalleSol.idConcepto
                                    End If

                                    Dim nConcepto As String = Stuff(Trim(rwPolizasEnc.razonSocial & " " & rwPolizasEnc.folioSolicitud & " " & nConceptoD), "D", " ", 100)
                                    encabezadoD = "P  " & rwPolizasEnc.fecha.ToString("yyyyMMdd") & " " & Stuff(rwTipoPoliza.idConpaq.ToString, "I", " ", 4) & Space(10 - rwPolizasEnc.folioTipoDocumento.ToString.Length) & rwPolizasEnc.folioTipoDocumento.ToString & " 1 0          " & nConcepto & " 11 0 0 "
                                    taPolizaDet.DetallePoliza_FillBy(dtPolizaDet, rwPolizasEnc.idEmpresa, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, idConceptoD)
                                    filePolizaD.WriteLine(Eliminar_AcentosPolizas(encabezadoD.ToUpper))
                                    Dim uuid As String = ""
                                    Dim uuidA(0) As String
                                    Dim cont As Integer = 0
                                    For Each rwPolizasDet As dsContabilidad.Vw_CXP_PolizasDetRow In dtPolizaDet.Rows

                                        CuentasTableAdapter.DatosCtas_FillBy(dtCuentasCpq, rwPolizasDet.idCuenta)
                                        If dtCuentasCpq.Rows.Count >= 1 Then
                                            rwCuentasCpq = dtCuentasCpq.Rows(0)
                                            Dim dImporte As String = Stuff(Trim(rwPolizasDet.importe.ToString), "D", " ", 20)
                                            Dim dReferencia As String = Stuff(Trim("S-" & rwPolizasDet.folioSolicitud & " " & rwPolizasDet.concepto.Trim), "D", " ", 100)
                                            Dim dReferencia1 As String = "" 'Stuff(Trim(rwPolizasDet.folioSolicitud), "D", " ", 20)

                                            If rwPolizasDet.noContrato = String.Empty Then
                                                dReferencia1 = Stuff(Trim(rwPolizasDet.rfc), "D", " ", 20)
                                            Else
                                                dReferencia1 = Stuff(Trim(rwPolizasDet.noContrato), "D", " ", 20)
                                            End If

                                            Dim dsegNegocios As String = Stuff(Trim(rwPolizasDet.idSuc), "D", " ", 4)
                                            Dim idDiario As String = Stuff("0", "D", " ", 10)
                                            Dim importeME As String = Stuff((Math.Round((CDec(rwPolizasDet.importe) * CDec(rwPolizasDet.TipoDeCambio)), 2).ToString), "D", " ", 20)
                                            If dReferencia.Length > 100 Then
                                                dReferencia = dReferencia.Substring(0, 100)
                                            End If

                                            renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & dReferencia & Space(1) & dsegNegocios & Space(1) & rwPolizasDet.uuid & Space(37) & vbNewLine &
                                                    "AM " & rwPolizasDet.uuid & vbNewLine & "AD " & rwPolizasDet.uuid
                                        End If
                                        filePolizaD.WriteLine(Eliminar_AcentosPolizas(renglonD.ToUpper))
                                    Next
                                    Dim referecnia20 As String = ""
                                    If rwPolizasEnc.referencia.Length >= 20 Then
                                        referecnia20 = rwPolizasEnc.referencia.Substring(0, 20)
                                    End If
                                    filePolizaD.WriteLine("EG" &
                                                          " " & "04040" &
                                                          " " & Stuff("53", "I", " ", 30) &
                                                          " " & Stuff(rwPolizasEnc.folioCheque.ToString, "I", " ", 20) &
                                                          " " & dtpFechaInicial.Value.ToString("yyyyMMdd") &
                                                          " " & dtpFechaInicial.Value.ToString("yyyyMMdd") &
                                                          " " & Stuff(rwProveedoresCpq.Codigo, "D", " ", 6) &
                                                          " " & Stuff(Eliminar_AcentosPolizas(rwProveedoresCpq.Nombre.ToUpper), "D", " ", 200) &
                                                          " " & Stuff(rwPolizasEnc.numeroDeCuenta, "D", " ", 20) &
                                                          " " & Stuff(rwPolizasEnc.monedaPago.Replace("MXN", "1").Replace("USD", "2").Replace("EUR", "3"), "I", " ", 4) &
                                                          " " & Stuff(rwPolizasEnc.importeSolicitado.ToString, "D", " ", 20) &
                                                          " " & Stuff(referecnia20, "D", " ", 20) &
                                                          " " & Stuff("11", "I", " ", 5) &
                                                          " " & Stuff(BancosContpaqTableAdapter.ObtCodigoProv_ScalarQuery(rwPolizasEnc.claveBancos), "I", " ", 30) &
                                                          " " & Stuff(rwPolizasEnc.numeroDeCuenta, "D", " ", 30) &
                                                          " " & Stuff("03", "D", " ", 5) &
                                                          " " & Space(36) &
                                                          " " & Stuff(rwPolizasEnc.rfc, "D", " ", 13) &
                                                          " " & Space(60) &
                                                          " " & Stuff(rwPolizasEnc.tipoDeCambio.ToString, "D", " ", 20) &
                                                          " " & Space(37) &
                                                          " " & Space(5) &
                                                          " " & Stuff("2", "D", " ", 4)
                                                          )
                                End If
                            Next

                            filePolizaD.Close()
                            MsgBox("Proceso terminado", MsgBoxStyle.Information, "")
                            tsBarProceso.Value = 0
                            Application.DoEvents()
                        End If

                    End If
                End If
            Next
        Else
            MsgBox("Proceso cancelado...", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Sub frmGenPolizas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsContabilidad.Vw_CXP_PolizasEnc' Puede moverla o quitarla según sea necesario.
        'Me.Vw_CXP_PolizasEncTableAdapter.Fill(Me.DsContabilidad.Vw_CXP_PolizasEnc)

        dtpFechaInicial.Value = Date.Now.AddDays(-Now.Day + 1)
        dtpFechaInicio.Value = Date.Now.AddDays(-Now.Day + 1)
        Try
            If varGlobal_IdEmpresa = "24" Then
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctCONEARFIN;Persist Security Info=True;User ID=finagil;Password=finagil"
                ProveedoresContpaqTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctCONEARFIN;Persist Security Info=True;User ID=finagil;Password=finagil"
                BancosContpaqTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctCONEARFIN;Persist Security Info=True;User ID=finagil;Password=finagil"
            Else
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctFINAGILCONEFINAGIL2015;Persist Security Info=True;User ID=finagil;Password=finagil"
                ProveedoresContpaqTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctFINAGILCONEFINAGIL2015;Persist Security Info=True;User ID=finagil;Password=finagil"
                BancosContpaqTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctFINAGILCONEFINAGIL2015;Persist Security Info=True;User ID=finagil;Password=finagil"
            End If
            'TODO: esta línea de código carga datos en la tabla 'Contpaq.Cuentas' Puede moverla o quitarla según sea necesario.
            Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error en conexión...")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnProcesarP_Click(sender As Object, e As EventArgs) Handles btnProcesarP.Click
        generaPolizaP()
    End Sub


End Class
