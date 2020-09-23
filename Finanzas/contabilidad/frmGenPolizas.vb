Imports System.IO
Public Class frmGenPolizas


    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        generaPolizaD()
    End Sub

    Private Sub generaPolizaD()
        Dim filePolizaD As StreamWriter
        Dim encabezadoD As String = ""
        Dim renglonD As String = ""
        Dim taPolizasEnc As New dsContabilidadTableAdapters.Vw_CXP_PolizasEncTableAdapter
        Dim dtPolizasEnc As New dsContabilidad.Vw_CXP_PolizasEncDataTable
        Dim taTipoDocumento As New dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter

        Dim taPolizaDet As New dsContabilidadTableAdapters.Vw_CXP_PolizasDetTableAdapter
        Dim taPolizaDetUuid As New dsProductionTableAdapters.Vw_CXP_PolizasDetTableAdapter
        Dim dtPolizaDet As New dsContabilidad.Vw_CXP_PolizasDetDataTable
        Dim dtPolizaDetUuid As New dsContabilidad.Vw_CXP_PolizasDetDataTable

        'Dim CuentasTableAdapter As New contpaqTableAdapters.CuentasTableAdapter
        Dim dtCuentasCpq As New contpaq.CuentasDataTable
        Dim rwCuentasCpq As contpaq.CuentasRow
        Dim Cuenta As Integer = 1

        sfdPolizas = New SaveFileDialog
        sfdPolizas.Filter = "txt files (*.txt)|*.txt"
        sfdPolizas.FilterIndex = 2
        sfdPolizas.RestoreDirectory = True
        sfdPolizas.FileName = "PD" & taTipoDocumento.ObtTipoDeAsiento_ScalarQuery(varGlobal_IdEmpresa) & " " & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & ".txt"

        If sfdPolizas.ShowDialog = DialogResult.OK Then
            taPolizasEnc.PolizasXRangoFechas_FillBy(dtPolizasEnc, dtpFechaInicial.Value, dtpFechaFinal.Value, taTipoDocumento.ObtTipoDeAsiento_ScalarQuery(varGlobal_IdEmpresa), varGlobal_IdEmpresa, varGlobal_idDocumento)
            If varGlobal_IdEmpresa = "24" Then
                If dtPolizasEnc.Rows.Count > 0 Then
                    filePolizaD = New StreamWriter(sfdPolizas.FileName)
                    tsBarProceso.Maximum = dtPolizasEnc.Rows.Count
                    For Each rwPolizasEnc As dsContabilidad.Vw_CXP_PolizasEncRow In dtPolizasEnc.Rows
                        tsBarProceso.Value = Cuenta
                        Application.DoEvents()

                        Cuenta = Cuenta + 1

                        Dim nConcepto As String = Stuff(Trim(rwPolizasEnc.razonSocial & " " & rwPolizasEnc.folioSolicitud & " " & rwPolizasEnc.nConcepto), "D", " ", 100)
                        encabezadoD = "P  " & dtpFechaInicial.Value.ToString("yyyyMMdd") & "    3" & Space(10 - rwPolizasEnc.folioTipoDocumento.ToString.Length) & rwPolizasEnc.folioTipoDocumento.ToString & " 1 0          " & nConcepto & " 11 0 0 "
                        taPolizaDet.DetallePoliza_FillBy(dtPolizaDet, rwPolizasEnc.idEmpresa, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioTipoDocumento, rwPolizasEnc.folioSolicitud, rwPolizasEnc.idConcepto)
                        filePolizaD.WriteLine(encabezadoD)
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

                                'Desabilitado 09/09/2020
                                'If cont = 0 Then
                                '    uuidA(cont) = rwPolizasDet.uuid
                                '    cont += 1
                                'Else
                                '    If uuidA(cont - 1) <> rwPolizasDet.uuid Then
                                '        ReDim Preserve uuidA(cont)
                                '        uuidA(cont) = rwPolizasDet.uuid
                                '        cont += 1
                                '    End If
                                'End If

                            End If
                            filePolizaD.WriteLine(Eliminar_Acentos(renglonD.ToUpper))
                        Next
                        'Desabilitado 09/09/2020
                        'For i As Integer = 0 To UBound(uuidA)
                        '    renglonD = "AM " & uuidA(i) & vbNewLine & "AD " & uuidA(i)
                        '    filePolizaD.WriteLine(Eliminar_Acentos(renglonD))
                        'Next
                    Next
                    filePolizaD.Close()
                    MsgBox("Proceso terminado", MsgBoxStyle.Information, "")
                    tsBarProceso.Value = 0
                    Application.DoEvents()
                End If
            Else
                MsgBox("Proceso cancelado...", MsgBoxStyle.Information, "")
            End If
        End If


    End Sub

    Private Sub frmGenPolizas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsContabilidad.Vw_CXP_PolizasEnc' Puede moverla o quitarla según sea necesario.
        'Me.Vw_CXP_PolizasEncTableAdapter.Fill(Me.DsContabilidad.Vw_CXP_PolizasEnc)
        dtpFechaInicial.Value = Date.Now.AddDays(-Now.Day + 1)
        Try
            If varGlobal_IdEmpresa = "24" Then
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctCONEARFIN;Persist Security Info=True;User ID=finagil;Password=finagil"
            Else
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctFINAGILCONEFINAGIL2015;Persist Security Info=True;User ID=finagil;Password=finagil"
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
End Class
