Imports System.IO

Public Class frmPolizasEgresos

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If varGlobal_IdEmpresa = 24 Then
            Vw_CXP_PolizasEncTableAdapter.PolizasXRangoFechas_FillBy(Me.DsContabilidad.Vw_CXP_PolizasEnc, 6, varGlobal_IdEmpresa, dtpFechaInicio.Value.ToString("dd/MM/yyyy"), dtpFechaFin.Value.AddDays(1).ToString("dd/MM/yyyy"))
        Else
            Vw_CXP_PolizasEncTableAdapter.PolizasXRangoFechas_FillBy(Me.DsContabilidad.Vw_CXP_PolizasEnc, 4, varGlobal_IdEmpresa, dtpFechaInicio.Value.ToString("dd/MM/yyyy"), dtpFechaFin.Value.AddDays(1).ToString("dd/MM/yyyy"))
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim folioPoliza As Integer = CInt(txtPolizaInicial.Text)
        Dim contador As Integer = 0
        Try
            Dim taRegCont As New dsTesoreriaTableAdapters.CXP_RegContTableAdapter
            Dim taConceptos As New dsTesoreriaTableAdapters.CXP_ConceptosTableAdapter

            For Each rows As DataGridViewRow In Vw_CXP_PolizasEncDataGridView.Rows
                taRegCont.CambiaFolio_UpdateQuery(folioPoliza, varGlobal_IdEmpresa, Vw_CXP_PolizasEncDataGridView.Item("folioSolicitud", contador).Value, Vw_CXP_PolizasEncDataGridView.Item("fecha", contador).Value)
                Dim dtRegCont As New dsTesoreria.CXP_RegContDataTable

                taRegCont.DetalleRegContable_FillBy(dtRegCont, folioPoliza, varGlobal_IdEmpresa, Vw_CXP_PolizasEncDataGridView.Item("folioSolicitud", contador).Value, Vw_CXP_PolizasEncDataGridView.Item("fecha", contador).Value)
                For Each rwRegCont As dsTesoreria.CXP_RegContRow In dtRegCont.Rows
                    If rwRegCont.idCuenta = 0 Then
                        taRegCont.ActualizaCuenta_UpdateQuery(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(rwRegCont.idConcepto, "002", "TRA", "Tasa", "Federal", "P", "0.160000")), rwRegCont.idReg)
                    End If
                Next

                folioPoliza += 1
                contador += 1
            Next
            MsgBox("Proceso terminado correctamente...", MsgBoxStyle.Information, "")
            Vw_CXP_PolizasEncTableAdapter.PolizasXRangoFechas_FillBy(Me.DsContabilidad.Vw_CXP_PolizasEnc, 6, varGlobal_IdEmpresa, dtpFechaInicio.Value.ToString("dd/MM/yyyy"), dtpFechaFin.Value.AddDays(1).ToString("dd/MM/yyyy"))
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "")
        End Try
    End Sub

    Private Sub frmPolizasEgresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaInicio.Value = Date.Now.AddDays(-Now.Day + 1)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Vw_CXP_PolizasEncDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vw_CXP_PolizasEncDataGridView.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim mdiDetallePolizasEgresos As New frmDetPolizasEgresos
            Dim mdiSolicitudesPago As New mdicuentasPorPagar
            Me.Enabled = False
            mdiSolicitudesPago = MdiParent
            mdiDetallePolizasEgresos.MdiParent = mdiSolicitudesPago
            Me.Cursor = Cursors.WaitCursor
            mdiDetallePolizasEgresos.folioTipoDocumento = Vw_CXP_PolizasEncDataGridView.Item("folioTipoDocumento", e.RowIndex).Value
            mdiDetallePolizasEgresos.folioSolicitud = Vw_CXP_PolizasEncDataGridView.Item("folioSolicitud", e.RowIndex).Value
            mdiDetallePolizasEgresos.fecha = Vw_CXP_PolizasEncDataGridView.Item("fecha", e.RowIndex).Value
            mdiDetallePolizasEgresos.Show()
            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class