Imports System.ComponentModel

Public Class frmSolicitudesDePagoCFDI

    Public total As Decimal = 0
    Public subTotal As Decimal = 0
    Public iva As Decimal = 0
    Public totalRet As Decimal = 0
    Public var_rfcProveedor As String
    Private Sub frmSolicitudesDePagoCFDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Vw_CXP_XmlCfdi2_grpUuidTableAdapter.ObtCfdi_FillBy(DsProduction.vw_CXP_XmlCfdi2_grpUuid, var_rfcProveedor)
    End Sub

    Private Sub CXP_XmlCfdiDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CXP_XmlCfdiDataGridView.CellContentClick
        If CXP_XmlCfdiDataGridView.Item("seleccionar", e.RowIndex).Value = True Then
            CXP_XmlCfdiDataGridView.Item("seleccionar", e.RowIndex).Value = False
        Else
            CXP_XmlCfdiDataGridView.Item("seleccionar", e.RowIndex).Value = True
        End If
    End Sub

    Private Sub frmSolicitudesDePagoCFDI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmSolicitudesDePagoCFDI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dtProveedores As New dsProductionTableAdapters.CXP_ProveedoresTableAdapter
        Dim dtCuentas As New dsProductionTableAdapters.CXP_CuentasContablesTableAdapter
        Dim dtConceptos As New dsProductionTableAdapters.CXP_ConceptosTableAdapter
        Dim dtConceptosImpuestos As New dsProductionTableAdapters.vw_CXP_XmlCfdi2_grpUuidTableAdapter
        Dim dtimpuesto As New dsProductionTableAdapters.CXP_ImpuestoTableAdapter

        Dim cont As Integer = 0
        Dim cont2 As Integer = 1
        For Each rows As DataGridViewRow In CXP_XmlCfdiDataGridView.Rows
            'MsgBox(CXP_XmlCfdiDataGridView.Item(8, cont).Value.ToString)
            If CXP_XmlCfdiDataGridView.Item("seleccionar", cont).Value = True Then

                total += Val(CXP_XmlCfdiDataGridView.Item("impIva", cont).Value)

                subTotal += Val(CXP_XmlCfdiDataGridView.Item("Column2", cont).Value)
                frmSolicitudesDePago.dgvDispercion.Rows.Add(cont2, dtCuentas.ObtCuenta_ScalarQuery(dtProveedores.ObtCuentCont_ScalarQuery(frmSolicitudesDePago.cmbProveedores.SelectedValue)), dtCuentas.ObtNombreCta_ScalarQuery(dtProveedores.ObtCuentCont_ScalarQuery(frmSolicitudesDePago.cmbProveedores.SelectedValue)), subTotal, "0", "Referencia")
                cont2 += 1

                dtConceptosImpuestos.SumImp_FillBy(DsProduction.vw_CXP_XmlCfdi2_grpUuid, CXP_XmlCfdiDataGridView.Item("UuidDataGridViewTextBoxColumn", cont).Value)

                For Each rowsDetalleCfdi As dsProduction.vw_CXP_XmlCfdi2_grpUuidRow In DsProduction.vw_CXP_XmlCfdi2_grpUuid.Rows
                    frmSolicitudesDePago.dgvDispercion.Rows.Add(cont2, dtimpuesto.ObtCuentaComp_ScalarQuery(rowsDetalleCfdi.impueto), dtimpuesto.ObtNombreCta_ScalarQuery(rowsDetalleCfdi.impueto), rowsDetalleCfdi.montoImpuesto, "0", "Referencia")
                    cont2 += 1
                Next

                frmSolicitudesDePago.dgvDispercion.Rows.Add(cont2, dtCuentas.ObtCuenta_ScalarQuery(dtConceptos.ObtCuentaEgreso_ScalarQuery(frmSolicitudesDePago.ComboBox2.SelectedValue)), dtCuentas.ObtNombreCta_ScalarQuery(dtConceptos.ObtCuentaEgreso_ScalarQuery(frmSolicitudesDePago.ComboBox2.SelectedValue)), "0", total, "Referencia")
                cont2 += 1

            End If
            cont += 1
        Next
    End Sub
End Class