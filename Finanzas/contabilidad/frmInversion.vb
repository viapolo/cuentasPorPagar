Public Class frmInversion
    Dim tipoFira As String
    Dim inversion As String
    Dim taInversiones As New dsContabilidadTableAdapters.CXP_InversionesTableAdapter
    Dim taRegCont As New dsTesoreriaTableAdapters.CXP_RegContTableAdapter
    Dim taCuentasContpaq As New contpaqTableAdapters.CuentasTableAdapter
    Dim taCuentasBancarias As New dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter
    Dim taTiposDeDocumento As New dsContabilidadTableAdapters.CXP_tipoDeDocumentoTableAdapter
    Dim taCuentasInversiones As New dsContabilidadTableAdapters.CXP_CuentasInversionesTableAdapter

    Dim taPolizas As New dsTesoreriaTableAdapters.CXP_tipoDeDocumentoTableAdapter
    Dim taDatosPolizas As New dsTesoreriaTableAdapters.DatosPolizasTableAdapter

    Dim taPagosTesoreria As New dsTesoreriaTableAdapters.CXP_PagosTesoreria1TableAdapter
    Private Sub frmInversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsContabilidad.CXP_Inversiones' Puede moverla o quitarla según sea necesario.

        Me.CXP_CuentasBancariasTableAdapter.Fill(Me.DsTesoreria.CXP_CuentasBancarias, varGlobal_IdEmpresa)
        dtpFechaInicial.MinDate = Date.Now.AddDays(-1)
        dtpFechaInicial.MaxDate = Date.Now
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbBancoOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBancoOrigen.SelectedIndexChanged
        If cmbBancoOrigen.SelectedIndex = 1 Then
            chkFira.Enabled = True
            chkFiraGarantia.Enabled = True
            chkFira.Checked = True
        Else
            chkFira.Enabled = False
            chkFiraGarantia.Enabled = False
            chkFira.Checked = False
            chkFiraGarantia.Checked = False
        End If
    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim idProveedorEmpresa As Decimal
        Dim idInversion As Integer
        Dim idTipoPoliza As Integer = taDatosPolizas.ObtTipoPoliza_ScalarQuery("INV", 3, "MXN", varGlobal_IdEmpresa)
        Dim folioTipoPoliza As Integer = taPolizas.ConsultaUltimoFolio_ScalarQuery(idTipoPoliza, varGlobal_IdEmpresa)
        Dim folioCheque As Integer = taCuentasBancarias.ConsultaChequeActual_ScalarQuery(cmbBancoOrigen.SelectedValue)


        If varGlobal_IdEmpresa = "23" Then
            idProveedorEmpresa = 9
        ElseIf varGlobal_IdEmpresa = "24" Then
            idProveedorEmpresa = 96
        End If
        valida()

        Try
            If taCuentasInversiones.ObtCuentaContable_ScalarQuery(cmbBancoOrigen.SelectedValue, tipoFira) = 0 Then
                MsgBox("Es necesario configurar la cuenta contable correspondiente...", MsgBoxStyle.Information, "")
                Exit Sub
            End If

            idInversion = taInversiones.NuevaInversion_ScalarQuery(cmbBancoOrigen.SelectedValue, dtpFechaInicial.Value, txtTasa.Text, txtMonto.Text,
            tipoFira, Nothing, "INV", varGlobal_IdEmpresa, "44", Nothing)

            taPagosTesoreria.Insert("INV", idInversion, cmbBancoOrigen.SelectedValue, taCuentasInversiones.ObtCuentaDestino_ScalarQuery(cmbBancoOrigen.SelectedValue, tipoFira), 37,
            varGlobal_IdEmpresa, txtMonto.Text, dtpFechaInicial.Value, 3, dtpFechaInicial.Value, "MXN", dtpFechaInicial.Value, Nothing, Nothing, 9, 234, Nothing, folioCheque)

            'cargo
            taRegCont.Insert(taCuentasInversiones.ObtCuentaContable_ScalarQuery(cmbBancoOrigen.SelectedValue, tipoFira), idProveedorEmpresa,
            CDec(txtMonto.Text), 0, "INVERSION", "INVERSION" & " " & cmbBancoOrigen.Text & " " & dtpFechaInicial.Value.ToShortDateString, idTipoPoliza, folioTipoPoliza,
            varGlobal_IdEmpresa, Nothing, idInversion, dtpFechaInicial.Value, 40, 234, 2, "INV")
            'abono
            taRegCont.Insert(taCuentasBancarias.ObtieneCuentaContable_ScalarQuery(cmbBancoOrigen.SelectedValue), idProveedorEmpresa,
            0, CDec(txtMonto.Text), "INVERSION", "INVERSION" & " " & cmbBancoOrigen.Text & " " & dtpFechaInicial.Value.ToShortDateString, idTipoPoliza, folioTipoPoliza,
            varGlobal_IdEmpresa, Nothing, idInversion, dtpFechaInicial.Value, 40, 234, 2, "INV")
            taPolizas.ConsumeUltimoFolio_UpdateQuery(idTipoPoliza, varGlobal_IdEmpresa)
            taCuentasBancarias.ConsumeFolioCheque_UpdateQuery(cmbBancoOrigen.SelectedValue)

            MsgBox("Registrado correctamente...", MsgBoxStyle.Information, "")
            limpia()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Public Sub limpia()
        cmbBancoOrigen.SelectedIndex = 0
        txtMonto.Text = ""
        txtTasa.Text = ""
        dtpFechaInicial.MinDate = Date.Now.AddDays(-1)
        dtpFechaInicial.MaxDate = Date.Now
        dtpFechaInicial.Value = Date.Now.ToShortDateString
    End Sub

    Public Sub valida()
        If chkFira.Enabled = True Then
            If chkFira.Checked = True Then
                tipoFira = "FIRA"
            ElseIf chkFiraGarantia.Checked = True Then
                tipoFira = "GLIQ"
            Else
                tipoFira = "NAPL"
            End If
        Else
            tipoFira = "NAPL"
        End If
    End Sub

    Private Sub chkFira_CheckedChanged(sender As Object, e As EventArgs) Handles chkFira.CheckedChanged
        If chkFira.Checked = True Then
            chkFiraGarantia.Checked = False
        Else
            chkFiraGarantia.Checked = True
        End If
    End Sub

    Private Sub chkFiraGarantia_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiraGarantia.CheckedChanged
        If chkFiraGarantia.Checked = True Then
            chkFira.Checked = False
        Else
            chkFira.Checked = True
        End If
    End Sub
End Class