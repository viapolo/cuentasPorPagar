Public Class frmDetalleRetInversiones
    Public idBancoRetiro As Decimal
    Public monto As Decimal
    Public interes As Decimal
    Public tipoFira As String
    Public idInversion As Decimal

    Dim taInversiones As New dsContabilidadTableAdapters.CXP_InversionesTableAdapter
    Private Sub frmDetalleRetInversiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CXP_CuentasBancariasTableAdapter.Fill(Me.DsContabilidad.CXP_CuentasBancarias, varGlobal_IdEmpresa)
        'cmbCuentaAbono.SelectedIndex = CuentasBindingSource1.Find("Codigo", "1501909000000000")
        cmbBancoOrigen.SelectedIndex = CXPCuentasBancariasBindingSource.Find("idCuentaBancaria", idBancoRetiro)
        txtInteres.Text = interes.ToString("c")
        txtMonto.Text = monto.ToString("c")
        txtTipoFira.Text = tipoFira
        tsslIdInversion.Text = "Id de Inversión: " & idInversion.ToString
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmDetalleRetInversiones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmRetiroDeInversion.Enabled = True
    End Sub

    Private Sub frmDetalleRetInversiones_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmRetiroDeInversion.Enabled = True
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click

        Try
            'taInversiones.Insert(cmbBancoOrigen.SelectedValue, dtpFechaInicial.Value, txtTasa.Text, txtMonto.Text, tipoFira, Nothing, "INV", varGlobal_IdEmpresa, "44")
            taInversiones.Insert(idBancoRetiro, dtpFechaRetiro.Value.ToShortDateString, Nothing, txtMonto.Text, tipoFira, txtInteres.Text, "RET", varGlobal_IdEmpresa, "44", idInversion)
            taInversiones.CambiaEstatus_UpdateQuery("45", idInversion)
            MsgBox("Retiro de inversión correcto...", MsgBoxStyle.Information, "")
            frmRetiroDeInversion.CXP_CuentasBancariasTableAdapter.Fill(Me.DsContabilidad.CXP_CuentasBancarias, varGlobal_IdEmpresa)
            frmRetiroDeInversion.CXP_InversionesTableAdapter.ObtInversiones_FillBy(Me.DsContabilidad.CXP_Inversiones, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)))
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
        Me.Close()
    End Sub
End Class