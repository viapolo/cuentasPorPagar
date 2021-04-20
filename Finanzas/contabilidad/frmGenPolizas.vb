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
            taPolizasEnc.Fill(dtPolizasEnc, dtpFechaInicial.Value.ToString("dd/MM/yyyy"), taTipoDocumento.ObtTipoDeAsiento_ScalarQuery(varGlobal_IdEmpresa), varGlobal_IdEmpresa, dtpFechaFinal.Value.AddDays(1).ToString("dd/MM/yyyy"))
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

                        taDetallePolizas.Fill(dtDetalleSol, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, varGlobal_IdEmpresa, rwPolizasEnc.tipoSolicitud)

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
                        taPolizaDet.DetallePoliza_FillBy(dtPolizaDet, rwPolizasEnc.idEmpresa, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, rwPolizasEnc.tipoSolicitud)
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
                        'For Each drDetConceptos As dsContabilidad.DataTableDetallePolizasRow In dtDetalleSol.Rows
                        Dim taPolizaDetB As New dsContabilidadTableAdapters.Vw_CXP_PolizasDetTableAdapter
                        Dim dtPolizaDetB As New dsContabilidad.Vw_CXP_PolizasDetDataTable

                        taPolizaDetB.DetallePoliza_FillBy(dtPolizaDetB, rwPolizasEnc.idEmpresa, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, rwPolizasEnc.tipoSolicitud)
                        For Each rwPolizasDet As dsContabilidad.Vw_CXP_PolizasDetRow In dtPolizaDetB.Rows

                                CuentasTableAdapter.DatosCtas_FillBy(dtCuentasCpq, rwPolizasDet.idCuenta)

                                If dtCuentasCpq.Rows.Count >= 1 Then
                                    rwCuentasCpq = dtCuentasCpq.Rows(0)
                                    Dim dImporte As String = ""
                                If cont = 1 Then
                                    If totalCargo < totalAbono Then
                                        dImporte = Stuff(Trim((rwPolizasDet.importe - diferencia).ToString), "D", " ", 20)
                                    ElseIf totalCargo > totalAbono Then
                                        dImporte = Stuff(Trim((rwPolizasDet.importe + diferencia).ToString), "D", " ", 20)
                                    ElseIf totalAbono = totalCargo Then
                                        dImporte = Stuff(Trim((rwPolizasDet.importe).ToString), "D", " ", 20)
                                    End If
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
                                            Else
                                                dReferencia1 = Stuff(Trim(rwPolizasDet.referencia.Replace("IVA ", "")), "D", " ", 20)
                                            End If
                                        End If
                                    Else
                                        If dReferencia.IndexOf(Eliminar_AcentosPolizas(rwPolizasEnc.razonSocial)) > 0 Then
                                            dReferencia1 = "PROV F-" & taCfdi.ObtieneFolio_ScalarQuery(rwPolizasDet.uuid) '& rwPolizasDet.folio
                                        Else
                                            dReferencia1 = rwPolizasDet.referencia
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
                        'Next
                    Next
                    filePolizaD.Close()
                    MsgBox("Proceso terminado", MsgBoxStyle.Information, "")
                    tsBarProceso.Value = 0
                    Application.DoEvents()
                Else
                    MsgBox("Sin registros en el rango de fecha seleccionado", MsgBoxStyle.Information, "")

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

                        taDetallePolizas.Fill(dtDetalleSol, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, varGlobal_IdEmpresa, rwPolizasEnc.tipoSolicitud)

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
                        taPolizaDet.DetallePoliza_FillBy(dtPolizaDet, rwPolizasEnc.idEmpresa, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, rwPolizasEnc.tipoSolicitud)
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
                        'For Each drDetConceptos As dsContabilidad.DataTableDetallePolizasRow In dtDetalleSol.Rows
                        Dim taPolizaDetB As New dsContabilidadTableAdapters.Vw_CXP_PolizasDetTableAdapter
                            Dim dtPolizaDetB As New dsContabilidad.Vw_CXP_PolizasDetDataTable

                        taPolizaDetB.DetallePoliza_FillBy(dtPolizaDetB, rwPolizasEnc.idEmpresa, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, rwPolizasEnc.tipoSolicitud)
                        For Each rwPolizasDet As dsContabilidad.Vw_CXP_PolizasDetRow In dtPolizaDetB.Rows

                                CuentasTableAdapter.DatosCtas_FillBy(dtCuentasCpq, rwPolizasDet.idCuenta)

                                If dtCuentasCpq.Rows.Count >= 1 Then
                                    rwCuentasCpq = dtCuentasCpq.Rows(0)
                                    Dim dImporte As String = ""
                                If cont = 1 Then
                                    If totalCargo < totalAbono Then
                                        dImporte = Stuff(Trim((rwPolizasDet.importe - diferencia).ToString), "D", " ", 20)
                                    ElseIf totalCargo > totalAbono Then
                                        dImporte = Stuff(Trim((rwPolizasDet.importe + diferencia).ToString), "D", " ", 20)
                                    ElseIf totalAbono = totalCargo Then
                                        dImporte = Stuff(Trim((rwPolizasDet.importe).ToString), "D", " ", 20)
                                    End If
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
                                            dReferencia1 = Stuff(Trim(rwPolizasDet.referencia), "D", " ", 20)
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
                            'Next
                        Next
                    filePolizaD.Close()
                    MsgBox("Proceso terminado", MsgBoxStyle.Information, "")
                    tsBarProceso.Value = 0
                    Application.DoEvents()
                Else
                    MsgBox("Sin registros en el rango de fecha seleccionado", MsgBoxStyle.Information, "")
                End If
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
        Dim taCuentasBancariasProv As New dsTesoreriaTableAdapters.CXP_CuentasBancariasProvTableAdapter

        Dim taDetallePolizas As New dsContabilidadTableAdapters.DataTableDetallePolizasTableAdapter

        Dim taAutorizaciones As New dsContabilidadTableAdapters.Vw_CXP_AutorizacionesTableAdapter
        Dim dtAutorizaciones As New dsContabilidad.Vw_CXP_AutorizacionesDataTable
        Dim rwAutorizaciones As dsContabilidad.Vw_CXP_AutorizacionesRow

        'Dim CuentasTableAdapter As New contpaqTableAdapters.CuentasTableAdapter
        Dim dtCuentasCpq As New contpaq.CuentasDataTable
        Dim rwCuentasCpq As contpaq.CuentasRow
        Dim dtProveedoresCpq As New contpaq.ProveedoresDataTable
        Dim rwProveedoresCpq As contpaq.ProveedoresRow
        Dim taTipoDeCambio As New dsContabilidadTableAdapters.CONT_TiposDeCambioTableAdapter
        Dim taDetallePolizaAvio As New dsContabilidadTableAdapters.DetallePolizaAvioTableAdapter
        Dim dtDetallePolizaAvio As New dsContabilidad.DetallePolizaAvioDataTable

        Dim Cuenta As Integer = 1



        'Dim nombreArchivo As String = sfdPolizas.FileName



        taTipoDePoliza.ObtTipoDePoliza_FillBy(dtTipoDePoliza, "Egreso", varGlobal_IdEmpresa)

            For Each rwTipoPoliza As dsContabilidad.CXP_tipoDeDocumentoRow In dtTipoDePoliza
                Dim fileNamePoliza As String = ""

                taPolizasEnc.PolizasXRangoFechas_FillBy(dtPolizasEnc, rwTipoPoliza.idTipoDeDocumento, varGlobal_IdEmpresa, dtpFechaInicio.Value.ToString("dd/MM/yyyy"), dtpFechaFin.Value.AddDays(1).ToString("dd/MM/yyyy"))
                If dtPolizasEnc.Rows.Count > 0 Then


                'fileNamePoliza = "PE " & rwTipoPoliza.idConpaq.ToString & " " & nombreArchivo
                If varGlobal_IdEmpresa = "24" Then
                    If dtPolizasEnc.Rows.Count > 0 Then
                        sfdPolizas = New SaveFileDialog
                        sfdPolizas.Filter = "txt files (*.txt)|*.txt"
                        sfdPolizas.FilterIndex = 2
                        sfdPolizas.RestoreDirectory = True
                        sfdPolizas.FileName = "PE " & rwTipoPoliza.idConpaq.ToString & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & ".txt"
                        If sfdPolizas.ShowDialog = DialogResult.OK Then
                            filePolizaD = New StreamWriter(sfdPolizas.FileName)
                            'filePolizaD = New StreamWriter(sfdPolizas.FileName)
                            tsBarProceso.Maximum = dtPolizasEnc.Rows.Count
                            Dim dtDetalleSol As New dsContabilidad.DataTableDetallePolizasDataTable
                            Dim rwDetalleSol As dsContabilidad.DataTableDetallePolizasRow

                            For Each rwPolizasEnc As dsContabilidad.Vw_CXP_PolizasEncRow In dtPolizasEnc.Rows

                                'tsBarProceso.Value = Cuenta
                                ProveedoresContpaqTableAdapter.Fill(dtProveedoresCpq, rwPolizasEnc.rfc)
                                If dtProveedoresCpq.Rows.Count > 0 Then
                                    rwProveedoresCpq = dtProveedoresCpq.Rows(0)

                                    Cuenta = Cuenta + 1

                                    Dim nConceptoD As String = ""
                                    Dim idConceptoD As Integer
                                    Dim conComprobante As String = ""
                                    Dim conceptoNominaD As String = ""

                                    taDetallePolizas.Fill(dtDetalleSol, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, varGlobal_IdEmpresa, rwPolizasEnc.tipoSolicitud)

                                    If dtDetalleSol.Rows.Count > 0 Then
                                        rwDetalleSol = dtDetalleSol.Rows(0)
                                        nConceptoD = rwDetalleSol.nConcepto
                                        idConceptoD = rwDetalleSol.idConcepto
                                        conceptoNominaD = rwDetalleSol.concepto
                                    End If

                                    taAutorizaciones.ObtDatosSolicitud_FillBy(dtAutorizaciones, varGlobal_IdEmpresa, rwPolizasEnc.folioSolicitud)

                                    If dtAutorizaciones.Rows.Count > 0 Then
                                        rwAutorizaciones = dtAutorizaciones.Rows(0)
                                        conComprobante = rwAutorizaciones.serie
                                    End If

                                    Dim nConcepto As String
                                    If idConceptoD <> 51 And idConceptoD <> 52 Then
                                        nConcepto = Stuff(Trim(rwPolizasEnc.razonSocial & " " & rwPolizasEnc.folioSolicitud & " " & nConceptoD), "D", " ", 100)
                                    Else
                                        nConcepto = Stuff(Trim("S-" & rwPolizasEnc.folioSolicitud & " " & conceptoNominaD), "D", " ", 100)
                                    End If

                                    If nConcepto.Length > 100 Then
                                        nConcepto = nConcepto.Substring(0, 100)
                                    End If

                                    encabezadoD = "P  " & rwPolizasEnc.fecha.ToString("yyyyMMdd") & " " & Stuff(rwTipoPoliza.idConpaq.ToString, "I", " ", 4) & Space(10 - rwPolizasEnc.folioTipoDocumento.ToString.Length) & rwPolizasEnc.folioTipoDocumento.ToString & " 1 0          " & nConcepto & " 11 0 0 "
                                    taPolizaDet.DetallePoliza_FillBy(dtPolizaDet, rwPolizasEnc.idEmpresa, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, rwPolizasEnc.tipoSolicitud)
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


                                            If dReferencia.Length > 100 Then
                                                dReferencia = dReferencia.Substring(0, 100)
                                            End If

                                            Dim dReferencia1 As String = ""

                                            If rwPolizasDet.noContrato = String.Empty Then
                                                dReferencia1 = Stuff(Trim(rwPolizasDet.referencia), "D", " ", 20)
                                                If dReferencia1.Length > 20 Then
                                                    dReferencia1 = dReferencia1.Substring(0, 20)
                                                End If
                                            Else
                                                dReferencia1 = Stuff(Trim(rwPolizasDet.noContrato), "D", " ", 20)
                                            End If

                                            Dim dsegNegocios As String = Stuff(Trim(rwPolizasDet.idSuc), "D", " ", 4)
                                            Dim idDiario As String = Stuff("0", "D", " ", 10)

                                            Dim importeME As String = "0.00"

                                            If CDec(rwPolizasDet.TipoDeCambio) > 1 Then
                                                importeME = Stuff((Math.Round((CDec(rwPolizasDet.importe) * CDec(rwPolizasDet.TipoDeCambio)), 2).ToString), "D", " ", 20)
                                            Else
                                                importeME = Stuff(importeME, "D", " ", 20)
                                            End If

                                            'asigna segmento de negocios Toluca para todos los abonos a bancos
                                            If rwCuentasCpq.Codigo = "1103020200000000" And rwPolizasDet.TipoMovto = 1 Then
                                                dsegNegocios = Stuff(Trim("1"), "D", " ", 4)
                                            End If



                                            If rwPolizasDet.uuid <> "ND" And idConceptoD <> 52 And idConceptoD <> 51 And conComprobante <> "PSC" Then
                                                renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & Stuff(Eliminar_AcentosPolizas(dReferencia), "D", " ", 100) & Space(1) & dsegNegocios & Space(1) & rwPolizasDet.uuid & Space(37) & vbNewLine &
                                                "AM " & rwPolizasDet.uuid & vbNewLine & "AD " & rwPolizasDet.uuid
                                            ElseIf rwPolizasDet.uuid <> "ND" And conComprobante = "PSC" And (idConceptoD = 40 Or idConceptoD = 42) Then
                                                renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & Stuff(Eliminar_AcentosPolizas(dReferencia), "D", " ", 100) & Space(1) & dsegNegocios & Space(1) & rwPolizasDet.uuid & Space(37) & vbNewLine &
                                                "AM " & rwPolizasDet.uuid & vbNewLine & "AD " & rwPolizasDet.uuid
                                            ElseIf rwDetalleSol.ref = "CHE" Then
                                                renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & Stuff(Eliminar_AcentosPolizas(dReferencia), "D", " ", 100) & Space(1) & dsegNegocios & Space(1)
                                            Else
                                                renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & Stuff(Eliminar_AcentosPolizas(dReferencia), "D", " ", 100) & Space(1) & dsegNegocios & Space(1)
                                            End If
                                        End If
                                        filePolizaD.WriteLine(Eliminar_AcentosPolizas(renglonD.ToUpper))
                                        If rwDetalleSol.ref = "CHE" Then
                                            Dim taDetallePagoCheque As New dsContabilidadTableAdapters.PagosConChequeDetalleTableAdapter
                                            Dim dtDetallePagoCheque As New dsContabilidad.PagosConChequeDetalleDataTable

                                            taDetallePagoCheque.Fill(dtDetallePagoCheque, varGlobal_IdEmpresa, rwPolizasEnc.tipoSolicitud, rwPolizasEnc.folioSolicitud)
                                            For Each rwDetallePagoCheque As dsContabilidad.PagosConChequeDetalleRow In dtDetallePagoCheque.Rows
                                                filePolizaD.WriteLine("AM " & rwDetallePagoCheque.uuid)
                                                filePolizaD.WriteLine("AD " & rwDetallePagoCheque.uuid)
                                            Next
                                        End If
                                    Next
                                    Dim referecnia20 As String = ""
                                    If rwPolizasEnc.referencia.Length >= 20 Then
                                        referecnia20 = rwPolizasEnc.referencia.Substring(0, 20)
                                    End If
                                    If idConceptoD <> 51 And idConceptoD <> 52 Then
                                        Dim cuentaDestino As String = ""

                                        If rwPolizasEnc.clabe <> String.Empty Then
                                            cuentaDestino = rwPolizasEnc.clabe
                                        ElseIf rwPolizasEnc.convenio <> String.Empty Then
                                            cuentaDestino = rwPolizasEnc.convenio
                                        Else
                                            If rwPolizasEnc.referencia.Replace(" ", "").Length >= 25 Then
                                                cuentaDestino = rwPolizasEnc.referencia.Replace(" ", "").Substring(0, 18)
                                            Else
                                                cuentaDestino = rwPolizasEnc.referencia.Replace(" ", "")
                                            End If
                                        End If
                                        Dim taTipoEgreso As String = "53"
                                        Dim formPagoSat As String = "03"
                                        If rwDetalleSol.ref = "CHE" Then
                                            formPagoSat = "02"
                                            taTipoEgreso = "49"
                                        End If
                                        filePolizaD.WriteLine("EG" &
                                                          " " & "04040" &
                                                          " " & Stuff(taTipoEgreso, "I", " ", 30) &
                                                          " " & Stuff(rwPolizasEnc.folioCheque.ToString, "I", " ", 20) &
                                                          " " & rwPolizasEnc.fecha.ToString("yyyyMMdd") &
                                                          " " & rwPolizasEnc.fecha.ToString("yyyyMMdd") &
                                                          " " & Stuff(rwProveedoresCpq.Codigo, "D", " ", 6) &
                                                          " " & Stuff(Eliminar_AcentosPolizas(rwProveedoresCpq.Nombre.ToUpper), "D", " ", 200) &
                                                          " " & Stuff(rwPolizasEnc.numeroDeCuenta, "D", " ", 20) &
                                                          " " & Stuff(rwPolizasEnc.monedaPago.Replace("MXN", "1").Replace("USD", "2").Replace("EUR", "3"), "I", " ", 4) &
                                                          " " & Stuff(rwPolizasEnc.impSol.ToString, "D", " ", 20) &
                                                          " " & Stuff(referecnia20, "D", " ", 20) &
                                                          " " & Stuff("11", "I", " ", 5) &
                                                          " " & Stuff(BancosContpaqTableAdapter.ObtCodigoProv_ScalarQuery(rwPolizasEnc.claveBancos), "I", " ", 30) &
                                                          " " & Stuff(cuentaDestino, "D", " ", 30) &
                                                          " " & Stuff(formPagoSat, "D", " ", 5) &
                                                          " " & Space(36) &
                                                          " " & Stuff(rwPolizasEnc.rfc, "D", " ", 13) &
                                                          " " & Space(60) &
                                                          " " & Stuff(rwPolizasEnc.tipoDeCambio.ToString, "D", " ", 20) &
                                                          " " & Space(37) &
                                                          " " & Space(5) &
                                                          " " & Stuff("2", "D", " ", 4)
                                                          )
                                    End If
                                    Else
                                    filePolizaD.WriteLine("****** NO EXISTE EL RFC " & rwPolizasEnc.rfc & " agregar en catálogo CONTPAQ")
                                End If
                            Next

                            filePolizaD.Close()
                            MsgBox("Proceso terminado", MsgBoxStyle.Information, "")
                            tsBarProceso.Value = 0
                            Application.DoEvents()
                        Else
                            MsgBox("Proceso cancelado...", MsgBoxStyle.Information, "")
                        End If
                    End If

                End If
                If varGlobal_IdEmpresa = "23" Then
                    If dtPolizasEnc.Rows.Count > 0 Then

                        sfdPolizas = New SaveFileDialog
                            sfdPolizas.Filter = "txt files (*.txt)|*.txt"
                            sfdPolizas.FilterIndex = 2
                            sfdPolizas.RestoreDirectory = True
                            sfdPolizas.FileName = "PE " & rwTipoPoliza.idConpaq.ToString & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & ".txt"
                        If sfdPolizas.ShowDialog = DialogResult.OK Then

                            filePolizaD = New StreamWriter(sfdPolizas.FileName)
                            tsBarProceso.Maximum = dtPolizasEnc.Rows.Count
                            Dim dtDetalleSol As New dsContabilidad.DataTableDetallePolizasDataTable
                            Dim rwDetalleSol As dsContabilidad.DataTableDetallePolizasRow
                            Dim rwDetalleSolAvio As dsContabilidad.DetallePolizaAvioRow

                            For Each rwPolizasEnc As dsContabilidad.Vw_CXP_PolizasEncRow In dtPolizasEnc.Rows

                                'tsBarProceso.Value = Cuenta
                                ProveedoresContpaqTableAdapter.Fill(dtProveedoresCpq, rwPolizasEnc.rfc)
                                If dtProveedoresCpq.Rows.Count > 0 Then
                                    rwProveedoresCpq = dtProveedoresCpq.Rows(0)

                                    Cuenta = Cuenta + 1

                                    Dim nConceptoD As String = ""
                                    Dim idConceptoD As Integer
                                    Dim conComprobante As String = ""
                                    Dim conceptoNominaD As String = ""
                                    Dim referencia As String = ""

                                    taDetallePolizas.Fill(dtDetalleSol, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, varGlobal_IdEmpresa, rwPolizasEnc.tipoSolicitud)

                                    If dtDetalleSol.Rows.Count > 0 Then
                                        rwDetalleSol = dtDetalleSol.Rows(0)
                                        nConceptoD = rwDetalleSol.nConcepto
                                        idConceptoD = rwDetalleSol.idConcepto
                                        conceptoNominaD = rwDetalleSol.concepto
                                        referencia = rwDetalleSol.referencia
                                    End If

                                    taAutorizaciones.ObtDatosSolicitud_FillBy(dtAutorizaciones, varGlobal_IdEmpresa, rwPolizasEnc.folioSolicitud)

                                    If dtAutorizaciones.Rows.Count > 0 Then
                                        rwAutorizaciones = dtAutorizaciones.Rows(0)
                                        conComprobante = rwAutorizaciones.serie
                                    End If

                                    Dim nConcepto As String
                                    If idConceptoD <> 51 And idConceptoD <> 52 Then
                                        If rwPolizasEnc.tipoSolicitud = "CXP" Or rwPolizasEnc.tipoSolicitud = "" Then
                                            nConcepto = Stuff(Trim(rwPolizasEnc.razonSocial & " " & rwPolizasEnc.folioSolicitud & " " & nConceptoD), "D", " ", 100)
                                        ElseIf rwPolizasEnc.tipoSolicitud = "AVI" Then
                                            nConcepto = Stuff("MINISTRACION CONTRATO " & referencia & "  " & Trim(rwPolizasEnc.razonSocial & " " & rwPolizasEnc.folioSolicitud & " " & nConceptoD), "D", " ", 100)
                                        ElseIf rwPolizasEnc.tipoSolicitud = "TRA" Then
                                            nConcepto = Stuff(nConceptoD & " " & taCuentasBancarias.ObtNombreCuenta_ScalarQuery(rwPolizasEnc.origenRecurso) & " A " & taCuentasBancariasProv.NombreCuenta_ScalarQuery(rwPolizasEnc.destinoRecurso), "D", " ", 100)
                                        End If
                                    Else
                                        nConcepto = Stuff(Trim("S-" & rwPolizasEnc.folioSolicitud & " " & conceptoNominaD), "D", " ", 100)
                                    End If

                                    If nConcepto.Length > 100 Then
                                        nConcepto = nConcepto.Substring(0, 100)
                                    End If

                                    encabezadoD = "P  " & rwPolizasEnc.fecha.ToString("yyyyMMdd") & " " & Stuff(rwTipoPoliza.idConpaq.ToString, "I", " ", 4) & Space(10 - rwPolizasEnc.folioTipoDocumento.ToString.Length) & rwPolizasEnc.folioTipoDocumento.ToString & " 1 0          " & nConcepto & " 11 0 0 "
                                    taPolizaDet.DetallePoliza_FillBy(dtPolizaDet, rwPolizasEnc.idEmpresa, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, rwPolizasEnc.tipoSolicitud)
                                    filePolizaD.WriteLine(Eliminar_AcentosPolizas(encabezadoD.ToUpper))
                                    'If rwPolizasEnc.folioTipoDocumento = 15 Then
                                    '    MsgBox("15")
                                    'End If
                                    Dim uuid As String = ""
                                    Dim uuidA(0) As String
                                    Dim cont As Integer = 0
                                    Dim m As String
                                    For Each rwPolizasDet As dsContabilidad.Vw_CXP_PolizasDetRow In dtPolizaDet.Rows

                                        CuentasTableAdapter.DatosCtas_FillBy(dtCuentasCpq, rwPolizasDet.idCuenta)
                                        If dtCuentasCpq.Rows.Count = 0 Then
                                            Dim idCuentaTemp As Integer = CuentasTableAdapter.ObtieneIdCta_ScalarQuery("231101900020" & rwPolizasDet.referencia.Substring(1, 4))
                                            CuentasTableAdapter.DatosCtas_FillBy(dtCuentasCpq, idCuentaTemp)
                                        End If
                                        If dtCuentasCpq.Rows.Count >= 1 Then
                                            rwCuentasCpq = dtCuentasCpq.Rows(0)
                                            Dim dImporte As String = Stuff(Trim(rwPolizasDet.importe.ToString), "D", " ", 20)
                                            Dim dReferencia As String
                                            If rwPolizasEnc.tipoSolicitud = "AVI" Then
                                                dReferencia = Stuff(Trim(rwPolizasDet.concepto.Trim), "D", " ", 100)
                                            Else
                                                dReferencia = Stuff(Trim("S-" & rwPolizasDet.folioSolicitud & " " & rwPolizasDet.concepto.Trim), "D", " ", 100)
                                            End If

                                            If dReferencia.Length > 100 Then
                                                dReferencia = dReferencia.Substring(0, 100)
                                            End If

                                            Dim dReferencia1 As String = ""

                                            If rwPolizasDet.noContrato = String.Empty Then
                                                dReferencia1 = Stuff(Trim(rwPolizasDet.referencia), "D", " ", 20)
                                                If dReferencia1.Length > 20 Then
                                                    dReferencia1 = dReferencia1.Substring(0, 20)
                                                End If
                                            Else
                                                dReferencia1 = Stuff(Trim(rwPolizasDet.noContrato), "D", " ", 20)
                                            End If

                                            Dim dsegNegocios As String = Stuff(Trim(rwPolizasDet.idSuc), "D", " ", 4)
                                            Dim idDiario As String = Stuff("0", "D", " ", 10)

                                            Dim tipoCambio As String
                                            If rwPolizasEnc.monedaPago = "USD" Then
                                                tipoCambio = taTipoDeCambio.ObtieneTipoDeCambio_ScalarQuery(rwPolizasEnc.fechaPago, "USD")
                                            Else
                                                tipoCambio = "0.0"
                                            End If


                                            Dim importeME As String = "0.00"

                                            If CDec(rwPolizasEnc.tipoDeCambio) > 1 Then
                                                importeME = Stuff((Math.Round((CDec(rwPolizasDet.importe) * CDec(tipoCambio)), 2).ToString), "D", " ", 20)
                                            Else
                                                importeME = Stuff(importeME, "D", " ", 20)
                                            End If

                                            If rwPolizasEnc.tipoSolicitud = "AVI" Then
                                                dsegNegocios = CStr(CInt(taDetallePolizaAvio.ObtSucursal_ScalarQuery(rwPolizasEnc.referencia)))
                                            End If

                                            'asigna segmento de negocios Toluca para todos los abonos a bancos
                                            If (rwCuentasCpq.Codigo = "1103020200000000" Or rwCuentasCpq.Codigo = "1103021100000000") And rwPolizasDet.TipoMovto = 1 Then
                                                dsegNegocios = Stuff(Trim("1"), "D", " ", 4)
                                            End If
                                            renglonD = ""
                                            If rwPolizasDet.uuid <> Nothing And rwPolizasDet.uuid <> "ND" And idConceptoD <> 52 And idConceptoD <> 51 And conComprobante <> "PSC" Then
                                                renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & dReferencia & Space(1) & dsegNegocios & Space(1) & rwPolizasDet.uuid & Space(37) & vbNewLine &
                                                    "AM " & rwPolizasDet.uuid & vbNewLine & "AD " & rwPolizasDet.uuid
                                            ElseIf rwPolizasDet.uuid <> "ND" And conComprobante = "PSC" And (idConceptoD = 40 Or idConceptoD = 42) Then
                                                renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & dReferencia & Space(1) & dsegNegocios & Space(1) & rwPolizasDet.uuid & Space(37) & vbNewLine &
                                                "AM " & rwPolizasDet.uuid & vbNewLine & "AD " & rwPolizasDet.uuid
                                            ElseIf rwDetalleSol.ref = "CHE" Then
                                                renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & Stuff(Eliminar_AcentosPolizas(dReferencia), "D", " ", 100) & Space(1) & dsegNegocios & Space(1)
                                            Else
                                                renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & dReferencia & Space(1) & dsegNegocios & Space(1)
                                            End If

                                            filePolizaD.WriteLine(Eliminar_AcentosPolizas(renglonD.ToUpper))
                                            If rwDetalleSol.ref = "CHE" Then
                                                Dim taDetallePagoCheque As New dsContabilidadTableAdapters.PagosConChequeDetalleTableAdapter
                                                Dim dtDetallePagoCheque As New dsContabilidad.PagosConChequeDetalleDataTable

                                                taDetallePagoCheque.Fill(dtDetallePagoCheque, varGlobal_IdEmpresa, rwPolizasEnc.tipoSolicitud, rwPolizasEnc.folioSolicitud)
                                                For Each rwDetallePagoCheque As dsContabilidad.PagosConChequeDetalleRow In dtDetallePagoCheque.Rows
                                                    filePolizaD.WriteLine("AM " & rwDetallePagoCheque.uuid)
                                                    filePolizaD.WriteLine("AD " & rwDetallePagoCheque.uuid)
                                                Next
                                            End If
                                        End If

                                        'm += renglonD
                                    Next
                                    Dim referecnia20 As String = ""
                                    If rwPolizasEnc.referencia.Length >= 20 Then
                                        referecnia20 = rwPolizasEnc.referencia.Substring(0, 20)
                                    End If
                                    If idConceptoD <> 51 And idConceptoD <> 52 Then
                                        Dim cuentaDestino As String = ""

                                        If rwPolizasEnc.clabe <> String.Empty Then
                                            cuentaDestino = rwPolizasEnc.clabe
                                        ElseIf rwPolizasEnc.convenio <> String.Empty Then
                                            cuentaDestino = rwPolizasEnc.convenio
                                        Else
                                            If rwPolizasEnc.referencia.Length >= 25 Then
                                                cuentaDestino = rwPolizasEnc.referencia.Substring(0, 25)
                                            Else
                                                cuentaDestino = rwPolizasEnc.referencia
                                            End If
                                        End If

                                        Dim tipoCambio As String
                                        If rwPolizasEnc.monedaPago = "USD" Then
                                            tipoCambio = taTipoDeCambio.ObtieneTipoDeCambio_ScalarQuery(rwPolizasEnc.fechaPago, "USD")
                                        Else
                                            tipoCambio = "0.0"
                                        End If
                                        Dim taTipoEgreso As String = "53"
                                        Dim formPagoSat As String = "03"
                                        If rwDetalleSol.ref = "CHE" Then
                                            formPagoSat = "02"
                                            taTipoEgreso = "49"
                                        End If
                                        filePolizaD.WriteLine("EG" &
                                                          " " & "04040" &
                                                          " " & Stuff(taTipoEgreso, "I", " ", 30) &
                                                      " " & Stuff(rwPolizasEnc.folioCheque.ToString, "I", " ", 20) &
                                                      " " & rwPolizasEnc.fecha.ToString("yyyyMMdd") &
                                                      " " & rwPolizasEnc.fecha.ToString("yyyyMMdd") &
                                                      " " & Stuff(rwProveedoresCpq.Codigo, "D", " ", 6) &
                                                      " " & Stuff(Eliminar_AcentosPolizas(rwProveedoresCpq.Nombre.ToUpper), "D", " ", 200) &
                                                      " " & Stuff(rwPolizasEnc.numeroDeCuenta.Substring(8, 10), "D", " ", 20) &
                                                      " " & Stuff(rwPolizasEnc.monedaPago.Replace("MXN", "1").Replace("USD", "2").Replace("EUR", "3"), "I", " ", 4) &
                                                      " " & Stuff(rwPolizasEnc.impSol.ToString, "D", " ", 20) &
                                                      " " & Stuff(referecnia20, "D", " ", 20) &
                                                      " " & Stuff("11", "I", " ", 5) &
                                                      " " & Stuff(BancosContpaqTableAdapter.ObtCodigoProv_ScalarQuery(rwPolizasEnc.claveBancos), "I", " ", 30) &
                                                      " " & Stuff(cuentaDestino, "D", " ", 30) &
                                                      " " & Stuff("03", "D", " ", 5) &
                                                      " " & Space(36) &
                                                      " " & Stuff(rwPolizasEnc.rfc, "D", " ", 13) &
                                                      " " & Space(60) &
                                                      " " & Stuff(tipoCambio, "D", " ", 20) &
                                                      " " & Space(37) &
                                                      " " & Space(5) &
                                                      " " & Stuff("2", "D", " ", 4)
                                                      )
                                    End If
                                Else
                                    filePolizaD.WriteLine("****** NO EXISTE EL RFC " & rwPolizasEnc.rfc & " - " & rwPolizasEnc.razonSocial & " NO EXISTE")
                                End If
                            Next

                            filePolizaD.Close()
                            MsgBox("Proceso terminado", MsgBoxStyle.Information, "")
                            tsBarProceso.Value = 0
                            Application.DoEvents()
                        Else
                            MsgBox("Proceso cancelado...", MsgBoxStyle.Information, "")
                        End If
                    End If

                End If
            Else
                    MsgBox("No existen registros en las fechas seleccionadas", MsgBoxStyle.Information, "")
                End If
            Next

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
