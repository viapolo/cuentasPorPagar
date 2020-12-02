Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Math
Imports System.WeakReference
Imports System.Xml
Imports System.Text
Public Class frmTraspasos
    Dim validacion As Boolean = True

    Private Sub frmTraspasos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsTesoreria.CXP_CuentasBancariasProv' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasBancariasProvTableAdapter.CtasFinagilTras_FillBy(Me.DsTesoreria.CXP_CuentasBancariasProv)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_c_Moneda' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_MonedaTableAdapter.Fill(Me.DsProduction.CXP_c_Moneda)
        Me.CXP_tipoDocumentoSatTableAdapter.Fill(Me.DsContabilidad.CXP_tipoDocumentoSat, varGlobal_IdEmpresa)
        cmbMoneda.SelectedIndex = CXPcMonedaBindingSource.Find("c_Moneda", "MXN")
        cmbFormaPago.SelectedIndex = CXPtipoDocumentoSatBindingSource.Find("ref", "TRE")
        'TODO: esta línea de código carga datos en la tabla 'DsContabilidad.CXP_c_Moneda' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasBancariasTableAdapter.Fill(DsTesoreria.CXP_CuentasBancarias, varGlobal_IdEmpresa)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim crDiskFileDestinationOptions As New DiskFileDestinationOptions()
        Dim rptTraspaso As New cuentasPorPagar.rptVistPreviaTraspaso
        Dim archivoTra As String

        Try
            validacion = True
            validaDatos()
            validaCuentas()

            If validacion Then
                Dim taPagosTesorería As New dsTesoreriaTableAdapters.CXP_PagosTesoreria1TableAdapter
                Dim taEmpresas As New dsProductionTableAdapters.CXP_EmpresasTableAdapter
                Dim folioTraspaso As Decimal = taEmpresas.ConsultaFolioTra_ScalarQuery(varGlobal_IdEmpresa)

                taPagosTesorería.Insert("TRA", folioTraspaso, cmbCuentaOrdenante.SelectedValue, cmbCuentaBeneficiaria.SelectedValue, 33, varGlobal_IdEmpresa, CDec(txtImporte.Text), SqlTypes.SqlDateTime.Null, cmbFormaPago.SelectedValue, dtpFecha.Value.ToShortDateString, cmbMoneda.SelectedValue, SqlTypes.SqlDateTime.Null, tokenReferencia(txtDescripcion.Text, "D", 4, 22), Nothing, 9, 194, CDec(txtTipoCambio.Text), Nothing)

                taEmpresas.ConsumeFolioTra_UpdateQuery(varGlobal_IdEmpresa)

                Dim mdiFrmVistaPreviaTraspaso As New frmTraspasosVPrev
                Dim mdiSolicitudesPago As New mdicuentasPorPagar
                Me.Enabled = False
                mdiSolicitudesPago = MdiParent
                mdiFrmVistaPreviaTraspaso.MdiParent = mdiSolicitudesPago
                mdiFrmVistaPreviaTraspaso.nombreBancoOrdenante = cmbCuentaOrdenante.Text
                mdiFrmVistaPreviaTraspaso.nombreBancoBeneficiario = cmbCuentaBeneficiaria.Text
                mdiFrmVistaPreviaTraspaso.importe = FormatCurrency(txtImporte.Text)
                mdiFrmVistaPreviaTraspaso.moneda = cmbMoneda.Text
                mdiFrmVistaPreviaTraspaso.tipoCambio = txtTipoCambio.Text
                mdiFrmVistaPreviaTraspaso.descripcion = txtDescripcion.Text
                mdiFrmVistaPreviaTraspaso.folioTraspaso = folioTraspaso.ToString
                Me.Cursor = Cursors.WaitCursor
                'generea PDF Traspaso

                rptTraspaso.SetParameterValue("var_nombreEmpresa", varGlobal_Empresa)
                rptTraspaso.SetParameterValue("var_nombreBancoOrdenante", cmbCuentaOrdenante.Text)
                rptTraspaso.SetParameterValue("var_nombreBancoBeneficiario", cmbCuentaBeneficiaria.Text)

                rptTraspaso.SetParameterValue("var_importe", FormatCurrency(txtImporte.Text))
                rptTraspaso.SetParameterValue("var_moneda", cmbMoneda.Text)
                rptTraspaso.SetParameterValue("var_tipoCambio", txtTipoCambio.Text)
                rptTraspaso.SetParameterValue("var_descripcion", txtDescripcion.Text)
                rptTraspaso.SetParameterValue("var_folioTras", folioTraspaso.ToString)

                rptTraspaso.SetParameterValue("var_usuario", varGlobal_NombreUsuario)
                rptTraspaso.SetParameterValue("var_fecha", Date.Now)

                rptTraspaso.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
                rptTraspaso.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat
                archivoTra = My.Settings.fileNas & "TRA\TRA-" & folioTraspaso.ToString & ".PDF"
                crDiskFileDestinationOptions.DiskFileName = archivoTra
                rptTraspaso.ExportOptions.DestinationOptions = crDiskFileDestinationOptions
                rptTraspaso.Export()
                rptTraspaso.Dispose()

                mdiFrmVistaPreviaTraspaso.Show()
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub btnVistPrevia_Click(sender As Object, e As EventArgs) Handles btnVistPrevia.Click
        Try
            validacion = True

            validaCuentas()
            validaDatos()
            If validacion Then
                Dim mdiFrmVistaPreviaTraspaso As New frmTraspasosVPrev
                Dim mdiSolicitudesPago As New mdicuentasPorPagar
                Me.Enabled = False
                mdiSolicitudesPago = MdiParent
                mdiFrmVistaPreviaTraspaso.MdiParent = mdiSolicitudesPago
                mdiFrmVistaPreviaTraspaso.nombreBancoOrdenante = cmbCuentaOrdenante.Text
                mdiFrmVistaPreviaTraspaso.nombreBancoBeneficiario = cmbCuentaBeneficiaria.Text
                mdiFrmVistaPreviaTraspaso.importe = FormatCurrency(txtImporte.Text)
                mdiFrmVistaPreviaTraspaso.moneda = cmbMoneda.Text
                mdiFrmVistaPreviaTraspaso.tipoCambio = txtTipoCambio.Text
                mdiFrmVistaPreviaTraspaso.descripcion = txtDescripcion.Text
                mdiFrmVistaPreviaTraspaso.folioTraspaso = "NA"
                Me.Cursor = Cursors.WaitCursor
                mdiFrmVistaPreviaTraspaso.Show()
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub validaCuentas()
        Dim taCuentasBancarias As New dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter
        Dim taCuentasBancariasProv As New dsTesoreriaTableAdapters.CXP_CuentasBancariasProvTableAdapter

        If taCuentasBancarias.ObtCtaClabe_ScalarQuery(varGlobal_IdEmpresa, cmbCuentaOrdenante.SelectedValue) = taCuentasBancariasProv.ObtCtaClabe_ScalarQuery(cmbCuentaBeneficiaria.SelectedValue) Then
            MsgBox("No es posible realizar traspasos entre la misma cuenta", MsgBoxStyle.Critical, "")
            validacion = False
            Exit Sub
        End If
    End Sub

    Private Sub validaDatos()
        If txtDescripcion.Text = String.Empty Then
            MsgBox("Es necesario ingresar una descrpición del traspaso", MsgBoxStyle.Critical, "")
            validacion = False
            Exit Sub
        End If
        If CDec(txtImporte.Text) <= 0 Then
            MsgBox("El importe debe ser mayor a cero", MsgBoxStyle.Critical, "")
            validacion = False
            Exit Sub
        End If
        If cmbMoneda.SelectedValue <> "MXN" Then
            If CDec(txtTipoCambio.Text) = 1 Then
                MsgBox("El tipo de cambio no es correcto", MsgBoxStyle.Critical, "")
                validacion = False
                Exit Sub
            End If
        End If
    End Sub

End Class