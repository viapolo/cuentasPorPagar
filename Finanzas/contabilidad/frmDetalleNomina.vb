Public Class frmDetalleNomina
    Public idSolicitud As Integer
    Dim taDetalleReembolsos As New dsContabilidadTableAdapters.Vw_CXP_AutorizacionesTableAdapter
    Dim dtDetalleReembolsos As New dsContabilidad.Vw_CXP_AutorizacionesDataTable
    Dim taContabilizaNominas As New dsContabilidadTableAdapters.Vw_CXP_ContabilizarNominaTableAdapter
    Dim taPeriodos As New dsContabilidadTableAdapters.CXP_PeriodosTableAdapter
    Dim taPagos As New dsContabilidadTableAdapters.CXP_PagosTableAdapter
    Dim taDatosPolizas As New dsTesoreriaTableAdapters.DatosPolizasTableAdapter
    Dim taRegContable As New dsProductionTableAdapters.CXP_RegContTableAdapter
    Dim taTipoDeDocumento As New dsContabilidadTableAdapters.CXP_tipoDeDocumentoTableAdapter
    Dim taEmpresas As New dsProductionTableAdapters.CXP_EmpresasTableAdapter

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmDetalleNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If taContabilizaNominas.ObtestatusReemb_ScalarQuery("CXP", idSolicitud) = "Contabilizado" Then
            MsgBox("La solicitud ya ha sido contabilizada", MsgBoxStyle.Information, "")
        End If
        Try
            If varGlobal_IdEmpresa = "24" Then
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctCONEARFIN;Persist Security Info=True;User ID=finagil;Password=finagil"
            Else
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctFINAGILCONEFINAGIL2015;Persist Security Info=True;User ID=finagil;Password=finagil"
            End If
            Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)
            Me.CXP_CuentasBancariasTableAdapter.FillBy(Me.DsContabilidad.CXP_CuentasBancarias, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)))
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error en conexión...")
        End Try

        dtpFechaProceso.Value = taContabilizaNominas.ObtFechPago_ScalarQuery("CXP", idSolicitud)
        cmbCuentaAbono.SelectedIndex = CuentasBindingSource.Find("Codigo", "2303060100000000")
        'cmbCuentaCargo.SelectedIndex = CuentasBindingSource1.Find("Id", taContabilizaNominas.ObtCtaCont_ScalarQuery("CXP", idSolicitud))

        taDetalleReembolsos.DetalleReembolso_FillBy(dtDetalleReembolsos, varGlobal_IdEmpresa, idSolicitud)

        For Each rwComprobaciongts As dsContabilidad.Vw_CXP_AutorizacionesRow In dtDetalleReembolsos.Rows
            dgvDetalleNomina.Rows.Add(cmbCuentaAbono.SelectedValue, cmbCuentaAbono.Text, rwComprobaciongts.totalPagadoTC, 0, rwComprobaciongts.decripcion.Substring(rwComprobaciongts.decripcion.IndexOf("CAT"), rwComprobaciongts.decripcion.Length - rwComprobaciongts.decripcion.IndexOf("CAT")), rwComprobaciongts.decripcion, "ND")
            dgvDetalleNomina.Rows.Add(cmbCuentaCargo.SelectedValue, cmbCuentaCargo.Text, 0, rwComprobaciongts.totalPagadoTC, rwComprobaciongts.decripcion.Substring(rwComprobaciongts.decripcion.IndexOf("CAT"), rwComprobaciongts.decripcion.Length - rwComprobaciongts.decripcion.IndexOf("CAT")), rwComprobaciongts.decripcion, "ND")
        Next
    End Sub

    Private Sub btnAplicCuenta_Click(sender As Object, e As EventArgs) Handles btnAplicCuenta.Click
        dgvDetalleNomina.Rows.Clear()
        taDetalleReembolsos.DetalleReembolso_FillBy(dtDetalleReembolsos, varGlobal_IdEmpresa, idSolicitud)

        For Each rwComprobaciongts As dsContabilidad.Vw_CXP_AutorizacionesRow In dtDetalleReembolsos.Rows
            dgvDetalleNomina.Rows.Add(cmbCuentaAbono.SelectedValue, cmbCuentaAbono.Text, rwComprobaciongts.totalPagadoTC, 0, rwComprobaciongts.decripcion.Substring(rwComprobaciongts.decripcion.IndexOf("CAT"), rwComprobaciongts.decripcion.Length - rwComprobaciongts.decripcion.IndexOf("CAT")), "S-" & idSolicitud & " " & rwComprobaciongts.decripcion, "ND")
            dgvDetalleNomina.Rows.Add(cmbCuentaCargo.SelectedValue, cmbCuentaCargo.Text, 0, rwComprobaciongts.totalPagadoTC, rwComprobaciongts.decripcion.Substring(rwComprobaciongts.decripcion.IndexOf("CAT"), rwComprobaciongts.decripcion.Length - rwComprobaciongts.decripcion.IndexOf("CAT")), "S-" & idSolicitud & " " & rwComprobaciongts.decripcion, "ND")
        Next

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim rwDatosSolicitud As dsContabilidad.Vw_CXP_AutorizacionesRow
        Dim dtAutorizaciones As New dsContabilidad.Vw_CXP_AutorizacionesDataTable
        Dim taPolizas As New dsTesoreriaTableAdapters.CXP_tipoDeDocumentoTableAdapter

        Dim contValid As Integer = 0

        For Each rows As DataGridViewRow In dgvDetalleNomina.Rows
            If dgvDetalleNomina.Item("idCuenta", contValid).Value.ToString = "" Then
                contValid += 1
                MsgBox("No se han asignado cuentas en todos los registros", MsgBoxStyle.Information, "")
                Exit Sub
            End If
        Next

        taDetalleReembolsos.ObtDatosSolicitud_FillBy(dtAutorizaciones, varGlobal_IdEmpresa, idSolicitud)
        If dtAutorizaciones.Rows.Count = 1 Then
            rwDatosSolicitud = dtAutorizaciones.Rows(0)
        End If



        'egreso
        If dtpFechaProceso.Value.Month < Date.Now.Month Then
            If taPeriodos.ExistePeriodoCerrado_ScalarQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa) <> "NE" Then
                Dim idTipoDocumento As Integer = taDatosPolizas.ObtTipoPoliza_ScalarQuery("CXP", rwDatosSolicitud.formaDePago, rwDatosSolicitud.monedaPago, varGlobal_IdEmpresa)
                Dim folioPoliza As Integer = taPeriodos.ConsultaFolio_ScalarQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa)
                Dim contador As Integer = 0
                For Each rows As DataGridViewRow In dgvDetalleNomina.Rows
                    taRegContable.Insert(CDec(dgvDetalleNomina.Item("idCuenta", contador).Value), rwDatosSolicitud.idProveedor, CDec(dgvDetalleNomina.Item("cargo", contador).Value), CDec(dgvDetalleNomina.Item("abono", contador).Value), dgvDetalleNomina.Item("referencia", contador).Value, dgvDetalleNomina.Item("concepto", contador).Value, idTipoDocumento, folioPoliza, varGlobal_IdEmpresa, dgvDetalleNomina.Item("uuid", contador).Value, idSolicitud, dtpFechaProceso.Value, "29", rwDatosSolicitud.idConcepto, 2, "CXP")
                    contador += 1
                Next

                taPeriodos.ConsumeFolio_UpdateQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa)
                btnProcesar.Enabled = False
                MsgBox("Proceso ejecutado correctamente", MsgBoxStyle.Information, "")
                taPagos.ActualizaContabilizado_UpdateQuery("Contabilizado", idSolicitud, varGlobal_IdEmpresa)
                Me.Close()
            Else
                MsgBox("El periodo no se ha cerrado", MsgBoxStyle.Information, "")
            End If
        Else
            Dim idTipoDocumento As Integer = taDatosPolizas.ObtTipoPoliza_ScalarQuery("CXP", rwDatosSolicitud.formaDePago, rwDatosSolicitud.monedaPago, varGlobal_IdEmpresa)
            Dim folioPoliza As Integer = taTipoDeDocumento.ConsultaFolio_ScalarQuery(idTipoDocumento) 'taPeriodos.ConsultaFolio_ScalarQuery(dtpFechaProceso.Value.Year, dtpFechaProceso.Value.Month, varGlobal_IdEmpresa)
                Dim contador As Integer = 0
                For Each rows As DataGridViewRow In dgvDetalleNomina.Rows
                taRegContable.Insert(CDec(dgvDetalleNomina.Item("idCuenta", contador).Value), rwDatosSolicitud.idProveedor, CDec(dgvDetalleNomina.Item("cargo", contador).Value), CDec(dgvDetalleNomina.Item("abono", contador).Value), dgvDetalleNomina.Item("referencia", contador).Value, dgvDetalleNomina.Item("concepto", contador).Value, idTipoDocumento, folioPoliza, varGlobal_IdEmpresa, dgvDetalleNomina.Item("uuid", contador).Value, idSolicitud, dtpFechaProceso.Value, "29", rwDatosSolicitud.idConcepto, 2, "CXP")
                contador += 1
                Next
            taTipoDeDocumento.ConsumeFolio_UpdateQuery(idTipoDocumento)
            taPagos.ActualizaContabilizado_UpdateQuery("Contabilizado", idSolicitud, varGlobal_IdEmpresa)
            btnProcesar.Enabled = False
                MsgBox("Proceso ejecutado correctamente", MsgBoxStyle.Information, "")
            End If
    End Sub

    Private Sub frmDetalleNomina_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

    End Sub

    Private Sub frmDetalleNomina_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmContabilizarNomina.Enabled = True
    End Sub

    Private Sub frmDetalleNomina_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmContabilizarNomina.Enabled = True
    End Sub
End Class