Public Class frmInversion
    Dim tipoFira As String
    Dim inversion As String
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
        Else
            chkFira.Enabled = False
            chkFiraGarantia.Enabled = False
            chkFira.Checked = False
            chkFiraGarantia.Checked = False
        End If
    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim taInversiones As New dsContabilidadTableAdapters.CXP_InversionesTableAdapter
        Dim taRegCont As New dsTesoreriaTableAdapters.CXP_RegContTableAdapter
        Dim taCuentasContpaq As New contpaqTableAdapters.CuentasTableAdapter
        Dim taCuentasBancarias As New dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter
        Dim idProveedorEmpresa As Decimal

        If varGlobal_IdEmpresa = "23" Then
            idProveedorEmpresa = 9
        ElseIf varGlobal_IdEmpresa = "24" Then
            idProveedorEmpresa = 96
        End If


        Try
            valida()
            taInversiones.Insert(cmbBancoOrigen.SelectedValue, dtpFechaInicial.Value, txtTasa.Text, txtMonto.Text, tipoFira, Nothing, "INV", varGlobal_IdEmpresa, "44", Nothing)

            'taRegCont.Insert(taCuentasBancarias.ObtieneCuentaContable_ScalarQuery(cmbBancoOrigen.SelectedValue), idProveedorEmpresa,
            '                 CDec(txtMonto.Text), 0, "INVERSION", cmbBancoOrigen.Text,


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
        If chkFira.Checked = True Then
            tipoFira = "FIRA"
        ElseIf chkFiraGarantia.Checked = True Then
            tipoFira = "GLIQ"
        Else
            tipoFira = "NAPL"
        End If

    End Sub

End Class