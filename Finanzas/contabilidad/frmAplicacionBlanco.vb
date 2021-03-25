Public Class frmAplicacionBlanco
    Private Sub frmAplicacionBlanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CXP_ProveedoresTableAdapter.Fill(Me.DsContabilidad.CXP_Proveedores)
        Me.CXP_ConceptosTableAdapter.Fill(Me.DsContabilidad.CXP_Conceptos, varGlobal_IdEmpresa)
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Me.Vw_CXP_XmlCfdi2_grpUuidTableAdapter.ObtCFDiXRfc_FillBy(Me.DsProduction.vw_CXP_XmlCfdi2_grpUuid, txtRfc.Text.Trim, varGlobal_rfcEmpresa)
    End Sub

    Private Sub btnVistaPrevia_Click(sender As Object, e As EventArgs) Handles btnVistaPrevia.Click
        For Each rowDgv As DataGridViewRow In dgvFacturasCfdi.Rows
            If rowDgv.Cells("seleccionar").Value = True Then
                dgvVistaPrevia.Rows.Add(rowDgv.Cells("SerieDataGridViewTextBoxColumn").Value, rowDgv.Cells("FolioDataGridViewTextBoxColumn").Value, rowDgv.Cells("UuidDataGridViewTextBoxColumn").Value, rowDgv.Cells("total").Value, cmbConcepto.Text)
            End If
        Next
        dgvVistaPrevia.Visible = True
        btnVistaPrevia.Visible = False
        btnProcesar.Visible = True
        btnCancelar.Visible = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        dgvVistaPrevia.Rows.Clear()
        dgvVistaPrevia.Visible = False
        btnVistaPrevia.Visible = True
        btnProcesar.Visible = False
        btnCancelar.Visible = False
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim taRegContable As New dsTesoreriaTableAdapters.CXP_RegContTableAdapter
        Dim taConceptos As New dsTesoreriaTableAdapters.CXP_ConceptosTableAdapter
        Dim taImpuestos As New dsTesoreriaTableAdapters.Vw_CXP_ImpuestosCFDITableAdapter
        Dim dtImpuestos As New dsTesoreria.Vw_CXP_ImpuestosCFDIDataTable
        Dim contador As Integer = 0
        Dim fechaHorActual As Date = Date.Now
        Dim tipoPoliza As Integer = 0
        Dim folioPoliza As Integer = 0
        Dim folioSolicitud As Integer = 0

        For Each row As DataGridViewRow In dgvVistaPrevia.Rows
            taImpuestos.Fill(dtImpuestos, row.Cells("UuidDataGridViewTextBoxColumn").Value)
            For Each rowsCfdi As dsTesoreria.Vw_CXP_ImpuestosCFDIRow In dtImpuestos
                Dim efecto As String = ""
                Dim tipo As String = ""
                Dim retecionL As String = ""
                Dim mPago As Decimal = 0
                Dim percentPago As Decimal

                If row.Cells("total").Value > 0 Then
                    percentPago = CDec(row.Cells("total").Value) / CDec(row.Cells("TotalDataGridViewTextBoxColumn").Value)
                Else
                    percentPago = 1
                End If

                If rowsCfdi.mTras <> "X" Then
                    efecto = "TRA"
                    mPago = Math.Round(CDec(Val(rowsCfdi.mTras) * percentPago), 2)
                    tipo = "Federal"
                    taRegContable.Insert(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(cmbConcepto.SelectedValue, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "S", rowsCfdi.tasaOCuota)), cmbProveedor.SelectedValue, 0, mPago, txtRfc.Text, "F-" & rowsCfdi.serie & " " & rowsCfdi.folio & " " & txtDescripcion.Text.Trim, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rowsCfdi.uuid, folioSolicitud, fechaHorActual, 29, cmbConcepto.SelectedValue, 2, "CXP")
                End If

                If rowsCfdi.mRet <> "X" Then
                    efecto = "RET"
                    mPago = Math.Round(CDec(Val(rowsCfdi.mRet) * percentPago), 2)
                    tipo = "Federal"
                    taRegContable.Insert(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(cmbConcepto.SelectedValue, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "S", rowsCfdi.tasaOCuota)), cmbProveedor.SelectedValue, mPago, 0, txtRfc.Text, "F-" & rowsCfdi.serie & " " & rowsCfdi.folio & " " & txtDescripcion.Text.Trim, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rowsCfdi.uuid, folioSolicitud, fechaHorActual, 29, cmbConcepto.SelectedValue, 2, "CXP")
                End If

                If contador = 0 Then
                    If rowsCfdi.mLocTra <> "X" And rowsCfdi.mLocTra <> 0 Then
                        efecto = "LOC"
                        mPago = Math.Round(CDec(Val(rowsCfdi.mLocTra) * percentPago), 2)
                        tipo = "Local"
                        taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(cmbConcepto.SelectedValue, tipo, "TRA", "S")), cmbProveedor.SelectedValue, mPago, 0, txtRfc.Text, "F-" & rowsCfdi.serie & " " & rowsCfdi.folio & " " & txtDescripcion.Text.Trim, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rowsCfdi.uuid, folioSolicitud, fechaHorActual, 29, cmbConcepto.SelectedValue, 2, "CXP")
                    End If

                    If rowsCfdi.mLocRet <> "X" And rowsCfdi.mLocRet <> 0 Then
                        efecto = "LOC"
                        mPago = Math.Round(CDec(Val(rowsCfdi.mLocRet) * percentPago), 2)
                        tipo = "Local"
                        taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(cmbConcepto.SelectedValue, tipo, "RET", "S")), cmbProveedor.SelectedValue, mPago, 0, txtRfc.Text, "F-" & rowsCfdi.serie & " " & rowsCfdi.folio & " " & txtDescripcion.Text.Trim, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rowsCfdi.uuid, folioSolicitud, fechaHorActual, 29, cmbConcepto.SelectedValue, 2, "CXP")
                    End If
                End If
                contador += 1
            Next
        Next
    End Sub
End Class