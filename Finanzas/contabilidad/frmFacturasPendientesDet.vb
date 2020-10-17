Public Class frmFacturasPendientesDet
    Public uuid As String
    Public serie As String
    Public folio As String
    Public rSocial As String
    Public rfc As String

    Dim taTipoDeDocumento As New dsContabilidadTableAdapters.CXP_tipoDeDocumentoTableAdapter
    Dim taRegContable As New dsProductionTableAdapters.CXP_RegContTableAdapter
    Dim taEmpresas As New dsProductionTableAdapters.CXP_EmpresasTableAdapter
    Dim taPeriodos As New dsContabilidadTableAdapters.CXP_PeriodosTableAdapter

    Private Sub frmFacturasPendientesDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Proveedores' Puede moverla o quitarla según sea necesario.
        dtpFecha.Value = Date.Now.AddDays(-Now.Day + 1).AddDays(-1)
        dtpFecha.MaxDate = Date.Now.AddDays(-Now.Day + 1).AddDays(-1)
        If taRegContable.ExisteUUID_ScalarQuery(uuid) <> "NE" Then
            btnProcesar.Enabled = False
            MsgBox("La factura ya se ha provisionado...", MsgBoxStyle.Information, "")
        End If
        Try
            If varGlobal_IdEmpresa = "24" Then
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctCONEARFIN;Persist Security Info=True;User ID=finagil;Password=finagil"
            Else
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctFINAGILCONEFINAGIL2015;Persist Security Info=True;User ID=finagil;Password=finagil"
            End If
            'Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)
            Me.CXP_ConceptosTableAdapter.Fill(Me.DsProduction.CXP_Conceptos, varGlobal_IdEmpresa)
            Me.CXP_ProveedoresTableAdapter.Fill(Me.DsProduction.CXP_Proveedores)
            CXPProveedoresBindingSource.Filter = "rfc='" & rfc & "'"
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error en conexión...")
        End Try
    End Sub

    Private Sub btnAsignarConcepto_Click(sender As Object, e As EventArgs) Handles btnAsignarConcepto.Click

        Dim taImpuestos As New dsTesoreriaTableAdapters.Vw_CXP_ImpuestosCFDITableAdapter
        Dim taConceptos As New dsTesoreriaTableAdapters.CXP_ConceptosTableAdapter
        Dim dtImpuestos As New dsTesoreria.Vw_CXP_ImpuestosCFDIDataTable
        'Dim CuentasTableAdapter As New contpaqTableAdapters.CuentasTableAdapter

        If txtDescripcion.Text.Trim = String.Empty Then
            MsgBox("No se ha ingresado una descripción", MsgBoxStyle.Information, "")
            Exit Sub
        End If

        dgvDetalleCfdi.Rows.Clear()
        taImpuestos.Fill(dtImpuestos, uuid)
        Dim contador As Integer = 0
        Dim mTotal As Decimal = 0

        For Each rowsCfdi As dsTesoreria.Vw_CXP_ImpuestosCFDIRow In dtImpuestos
            Dim cuentaCompaq As String = ""


            mTotal = rowsCfdi.total
            If contador = 0 Then dgvDetalleCfdi.Rows.Add(taConceptos.ObtCuentaCargoDiario_ScalarQuery(cmbConcepto.SelectedValue), CuentasTableAdapter.ObtCuentaContable_ScalarQuery(taConceptos.ObtCuentaCargoDiario_ScalarQuery(cmbConcepto.SelectedValue)), rowsCfdi.SubTotal, 0, rfc, "F-" & serie & " " & folio & " " & txtDescripcion.Text.Trim)

            If rowsCfdi.mTras <> "X" Then
                dgvDetalleCfdi.Rows.Add(taConceptos.ObtCtaImpTras_ScalarQuery(cmbConcepto.SelectedValue, rowsCfdi.Impuesto, "TRA", rowsCfdi.tipoFactor, "Federal", "S"), CuentasTableAdapter.ObtCuentaContable_ScalarQuery(taConceptos.ObtCtaImpTras_ScalarQuery(cmbConcepto.SelectedValue, rowsCfdi.Impuesto, "TRA", rowsCfdi.tipoFactor, "Federal", "S")), rowsCfdi.mTras, 0, taConceptos.ObtCtaImpTraDescripcion_ScalarQuery(cmbConcepto.SelectedValue, rowsCfdi.Impuesto, "TRA", rowsCfdi.tipoFactor, "Federal", "S") & " " & rfc, "F-" & serie & " " & folio & " " & txtDescripcion.Text.Trim)
            End If
            If rowsCfdi.mRet <> "X" Then
                dgvDetalleCfdi.Rows.Add(taConceptos.ObtCtaImpTras_ScalarQuery(cmbConcepto.SelectedValue, rowsCfdi.Impuesto, "RET", rowsCfdi.tipoFactor, "Federal", "S"), CuentasTableAdapter.ObtCuentaContable_ScalarQuery(taConceptos.ObtCtaImpTras_ScalarQuery(cmbConcepto.SelectedValue, rowsCfdi.Impuesto, "RET", rowsCfdi.tipoFactor, "Federal", "S")), 0, rowsCfdi.mRet, taConceptos.ObtCtaImpTraDescripcion_ScalarQuery(cmbConcepto.SelectedValue, rowsCfdi.Impuesto, "RET", rowsCfdi.tipoFactor, "Federal", "S") & " " & rfc, "F-" & serie & " " & folio & " " & txtDescripcion.Text.Trim)
            End If

            If contador = 0 Then
                If rowsCfdi.mLocTra <> "X" And rowsCfdi.mLocTra <> 0 Then
                    dgvDetalleCfdi.Rows.Add(taConceptos.ObtCtaImpLocal_ScalarQuery(cmbConcepto.SelectedValue, "Local", "TRA", "S"), CuentasTableAdapter.ObtCuentaContable_ScalarQuery(taConceptos.ObtCtaImpLocal_ScalarQuery(cmbConcepto.SelectedValue, "Local", "TRA", "S")), 0, rowsCfdi.mLocTra, taConceptos.ObtCtaImpLocalDes_ScalarQuery(cmbConcepto.SelectedValue, "Local", "TRA", "S") & " " & rfc, "F-" & serie & " " & folio & " " & txtDescripcion.Text.Trim)
                End If
                If rowsCfdi.mLocRet <> "X" And rowsCfdi.mLocRet <> 0 Then
                    dgvDetalleCfdi.Rows.Add(taConceptos.ObtCtaImpLocal_ScalarQuery(cmbConcepto.SelectedValue, "Local", "TRA", "S"), CuentasTableAdapter.ObtCuentaContable_ScalarQuery(taConceptos.ObtCtaImpLocal_ScalarQuery(cmbConcepto.SelectedValue, "Local", "RET", "S")), 0, rowsCfdi.mLocRet, taConceptos.ObtCtaImpLocalDes_ScalarQuery(cmbConcepto.SelectedValue, "Local", "RET", "S") & " " & rfc, "F-" & serie & " " & folio & " " & txtDescripcion.Text.Trim)
                End If
            End If
            contador += 1
        Next
        dgvDetalleCfdi.Rows.Add(taConceptos.ObtCuentaAbonoDiario_ScalarQuery(cmbConcepto.SelectedValue), CuentasTableAdapter.ObtCuentaContable_ScalarQuery(taConceptos.ObtCuentaAbonoDiario_ScalarQuery(cmbConcepto.SelectedValue)), 0, mTotal, rfc, rSocial & "F-" & serie & " " & folio & " " & txtDescripcion.Text.Trim)
    End Sub

    Private Sub frmFacturasPendientesDet_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmFacturasPendientes.Enabled = True
    End Sub

    Private Sub frmFacturasPendientesDet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmFacturasPendientes.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        If taPeriodos.ExistePeriodoCerrado_ScalarQuery(dtpFecha.Value.Year, dtpFecha.Value.Month, varGlobal_IdEmpresa) <> "NE" Then

            Dim idTipoDocumento As Integer = taEmpresas.ObtPolizaDiario_ScalarQuery(varGlobal_IdEmpresa)
            Dim folioPoliza As Integer = taPeriodos.ConsultaFolio_ScalarQuery(dtpFecha.Value.Year, dtpFecha.Value.Month, varGlobal_IdEmpresa) 'taTipoDeDocumento.ConsultaFolio_ScalarQuery(idTipoDocumento)
            Dim contador As Integer = 0
            For Each rows As DataGridViewRow In dgvDetalleCfdi.Rows
                taRegContable.Insert(CDec(dgvDetalleCfdi.Item("id", contador).Value), CDec(cmbProveedor.SelectedValue), CDec(dgvDetalleCfdi.Item("cargo", contador).Value), CDec(dgvDetalleCfdi.Item("abono", contador).Value), dgvDetalleCfdi.Item("referencia", contador).Value, dgvDetalleCfdi.Item("descripcion", contador).Value, idTipoDocumento, folioPoliza, varGlobal_IdEmpresa, uuid, 0, dtpFecha.Value, "29", CDec(cmbConcepto.SelectedValue), 1)
                contador += 1
            Next
            'taTipoDeDocumento.ConsumeFolio_UpdateQuery(idTipoDocumento)
            taPeriodos.ConsumeFolio_UpdateQuery(dtpFecha.Value.Year, dtpFecha.Value.Month, varGlobal_IdEmpresa)
            btnProcesar.Enabled = False
            MsgBox("Proceso ejecutado correctamente", MsgBoxStyle.Information, "")
        Else
            MsgBox("El periodo no se ha cerrado", MsgBoxStyle.Information, "")
        End If
    End Sub
End Class