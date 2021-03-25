

Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms


Public Class frmTesSolicitudesDePago

    Dim taPagos As New dsTesoreriaTableAdapters.CXP_PagosTableAdapter
    Dim taPagosTesoreria As New dsTesoreriaTableAdapters.CXP_PagosTesoreriaTableAdapter
    Dim importeTotal As Decimal = 0
    Dim totalregistros As Integer = 0
    Dim registrosSeleccionados As Integer = 0
    Dim idSolPagoG As String
    Dim tipoSolicitudG As String
    Dim convenioG As String
    Dim folioSolicitudG As String
    Dim idBancoG As String
    Dim referenciaG As String
    Dim importeG As String
    Dim estatusSol As String

    Private Sub frmTesSolicitudesDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaPagoInicial.Value = Date.Now.AddDays(-Now.Day - 5)

        Me.CXP_CuentasBancariasTableAdapter.Fill(Me.DsTesoreria.CXP_CuentasBancarias, varGlobal_IdEmpresa)

        Vw_CXP_SugPagoTesoreriaDataGridView.Visible = False
        Dim taTipoSolicitud As New dsTesoreriaTableAdapters.CXP_TipoDeSolicitudTableAdapter
        Dim dtTipoSolicitud As New dsTesoreria.CXP_TipoDeSolicitudDataTable

        taTipoSolicitud.Fill(dtTipoSolicitud)

        For Each rwTipoSol As dsTesoreria.CXP_TipoDeSolicitudRow In dtTipoSolicitud
            If varGlobal_IdEmpresa = 23 Then
                If rwTipoSol.tipoSolicitud = "CXP" Then
                    cblTS.Items.Add(rwTipoSol.tipoSolicitud, True)
                Else
                    cblTS.Items.Add(rwTipoSol.tipoSolicitud, False)
                End If
            Else
                If rwTipoSol.tipoSolicitud = "CXP" Or rwTipoSol.tipoSolicitud = "TRA" Then
                    cblTS.Items.Add(rwTipoSol.tipoSolicitud, True)
                End If
            End If
        Next


    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        importeTotal = 0
        totalregistros = 0
        registrosSeleccionados = 0
        lblTotalAPagar.Text = "$0"
        pbxCargando.Visible = True
        Application.DoEvents()

        If dtpFechaPagoFinal.Value < dtpFechaPagoInicial.Value Then
            MsgBox("La fecha inicial no puede ser mayor a la fecha final...", MsgBoxStyle.Critical, "")
        Else
            generaConsulta()
        End If
        tssTotalRegistros.Text = Vw_CXP_SugPagoTesoreriaDataGridView.Rows.Count.ToString
        tssRegistrosSeleccionados.Text = "0"
        If rbtnNoPagada.Checked = True Then
            gbxLayout.Enabled = True
            gbxSeleccionar.Enabled = True
        End If
    End Sub

    Public Sub actualizaGrid()
        Dim dataRow As DataRowView

        Dim taDatosPagos As New dsTesoreriaTableAdapters.DatosPagosTableAdapter
        Dim taDatosPagosAvi As New dsTesoreriaTableAdapters.DatosPagosAviTableAdapter
        Dim dtDatosPagos As New dsTesoreria.DatosPagosDataTable
        Dim dtDatosPagosAvi As New dsTesoreria.DatosPagosAviDataTable
        Dim drDatosPagos As dsTesoreria.DatosPagosRow
        Dim drDatosPagosAvi As dsTesoreria.DatosPagosAviRow
        Dim taCuentasBanco As New dsConfiguracionTableAdapters.CXP_CuentaBancoTableAdapter
        Dim dtCuentasBanco As New dsConfiguracion.CXP_CuentaBancoDataTable
        Dim rwCuentasBanco As dsConfiguracion.CXP_CuentaBancoRow

        Dim contRows As Integer = 0

        Dim d As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn
        Dim dc As DataGridViewComboBoxCell = New DataGridViewComboBoxCell
        Dim existeCol As String = "NO"


        For Each col As DataGridViewColumn In Vw_CXP_SugPagoTesoreriaDataGridView.Columns
            If col.Name = "bancoOrdenante" Then
                existeCol = "SI"
                Exit For
            End If
        Next

        If existeCol = "NO" Then
            d.Name = "bancoOrdenante"
            d.HeaderText = "Banco Ordenante"
            d.DataSource = CXPCuentasBancariasBindingSource
            d.DisplayMember = "nombre"
            d.ValueMember = "idCuentaBancaria"
            d.DisplayIndex = 9
            d.Width = 200
            d.Frozen = True

            Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Add(d)
        End If

        For Each rows As DataGridViewRow In Vw_CXP_SugPagoTesoreriaDataGridView.Rows
            Application.DoEvents()
            taDatosPagos.Fill(dtDatosPagos, varGlobal_IdEmpresa, Vw_CXP_SugPagoTesoreriaDataGridView.Item("folioSolicitud", contRows).Value)
            taDatosPagosAvi.DatosPago_FillBy(dtDatosPagosAvi, Vw_CXP_SugPagoTesoreriaDataGridView.Item("tipoSolicitud", contRows).Value, Vw_CXP_SugPagoTesoreriaDataGridView.Item("folioSolicitud", contRows).Value, Vw_CXP_SugPagoTesoreriaDataGridView.Item("idBancoBen", contRows).Value, varGlobal_IdEmpresa)

            dc = CType(Vw_CXP_SugPagoTesoreriaDataGridView.Rows(contRows).Cells("bancoOrdenante"), DataGridViewComboBoxCell)
            dataRow = dc.Items(0)
            dc.Value = dataRow.Item(0)

            If dtDatosPagos.Rows.Count = 1 Or dtDatosPagosAvi.Rows.Count = 1 Then

                If Vw_CXP_SugPagoTesoreriaDataGridView.Item("tipoSolicitud", contRows).Value = "CXP" Then
                    drDatosPagos = dtDatosPagos.Rows(0)
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("clabeBeneficiaria", contRows).Value = drDatosPagos.clabe
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("cuentaBeneficiaria", contRows).Value = drDatosPagos.cuenta
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("concepto", contRows).Value = drDatosPagos.concepto
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("convenio", contRows).Value = drDatosPagos.convenio
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("referencia", contRows).Value = drDatosPagos.referencia
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("bancoBeneficiario", contRows).Value = drDatosPagos.nombreCorto
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("idBancoBen", contRows).Value = drDatosPagos.idBanco
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("noContrato", contRows).Value = drDatosPagos.noContrato
                    If Vw_CXP_SugPagoTesoreriaDataGridView.Item("Tipar", contRows).Value <> String.Empty Then
                        If Vw_CXP_SugPagoTesoreriaDataGridView.Item("clabeBeneficiaria", contRows).Value.ToString <> String.Empty Then
                            Vw_CXP_SugPagoTesoreriaDataGridView.Item("cuentaBeneficiaria", contRows).Value = drDatosPagos.clabe.ToString.Substring(6, 11)
                        End If
                    End If
                Else
                    drDatosPagosAvi = dtDatosPagosAvi.Rows(0)
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("clabeBeneficiaria", contRows).Value = drDatosPagosAvi.clabe
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("cuentaBeneficiaria", contRows).Value = drDatosPagosAvi.cuenta
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("convenio", contRows).Value = drDatosPagosAvi.convenio
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("referencia", contRows).Value = drDatosPagosAvi.referencia
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("bancoBeneficiario", contRows).Value = drDatosPagosAvi.nombreCorto
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("idBancoBen", contRows).Value = drDatosPagosAvi.idBanco
                    Vw_CXP_SugPagoTesoreriaDataGridView.Item("noContrato", contRows).Value = "" 'drDatosPagosAvi.noContrato
                End If


                If Vw_CXP_SugPagoTesoreriaDataGridView.Item("estatusPago", contRows).Value = "37" Then

                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("seleccionar").Visible = False
                    d.Visible = False
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("bancoOrdenante").Visible = False
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").DisplayIndex = 9
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").Frozen = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").Visible = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").HeaderText = "Banco Ordenante"

                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaProceso").DisplayIndex = 18
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaProceso").Frozen = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaProceso").Visible = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaProceso").HeaderText = "Fecha Proceso"
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaPago").Visible = False
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaProgPago").Visible = False

                ElseIf Vw_CXP_SugPagoTesoreriaDataGridView.Item("estatusPago", contRows).Value = "34" Then
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("seleccionar").Visible = False
                    d.Visible = False
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("bancoOrdenante").Visible = False
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").DisplayIndex = 9
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").Frozen = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").Visible = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").HeaderText = "Banco Ordenante"

                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaPago").DisplayIndex = 18
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaPago").Frozen = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaPago").Visible = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaPago").HeaderText = "Fecha Pago"
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaProgPago").Visible = False
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaProceso").Visible = False

                ElseIf Vw_CXP_SugPagoTesoreriaDataGridView.Item("estatusPago", contRows).Value = "33" Then
                    d.Visible = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("bancoOrdenante").Visible = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").Frozen = False
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").Visible = False
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("seleccionar").Visible = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaProgPago").Visible = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaProceso").Visible = False
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("fechaPago").Visible = False
                    If Vw_CXP_SugPagoTesoreriaDataGridView.Item("tipoSolicitud", contRows).Value = "AVI" Then
                        dataRow = dc.Items(1)
                        dc.Value = dataRow.Item(0)
                    ElseIf Vw_CXP_SugPagoTesoreriaDataGridView.Item("tipoSolicitud", contRows).Value = "TRA" Then
                        dataRow = dc.Items(CXPCuentasBancariasBindingSource.Find("idCuentaBancaria", Vw_CXP_SugPagoTesoreriaDataGridView.Item("origenRecurso", contRows).Value))
                        dc.Value = dataRow.Item(0)
                    ElseIf Vw_CXP_SugPagoTesoreriaDataGridView.Item("moneda", contRows).Value = "USD" And varGlobal_IdEmpresa = "23" Then
                        dataRow = dc.Items(2)
                        dc.Value = dataRow.Item(0)
                    End If
                End If
                If Vw_CXP_SugPagoTesoreriaDataGridView.Item("cuentaBeneficiaria", contRows).Value <> String.Empty Or Vw_CXP_SugPagoTesoreriaDataGridView.Item("clabeBeneficiaria", contRows).Value <> String.Empty Then
                    If Vw_CXP_SugPagoTesoreriaDataGridView.Item("cuentaBeneficiaria", contRows).Value <> "" Then
                        If Vw_CXP_SugPagoTesoreriaDataGridView.Item("cuentaBeneficiaria", contRows).Value.ToString.Substring(0, 3) = "012" Then
                            taCuentasBanco.ExisteEstatus_FillBy(dtCuentasBanco, Vw_CXP_SugPagoTesoreriaDataGridView.Item("cuentaBeneficiaria", contRows).Value, Vw_CXP_SugPagoTesoreriaDataGridView.Item("moneda", contRows).Value.ToString.Replace("MXN", "MXP"), "TER")
                        Else
                            taCuentasBanco.ExisteEstatus_FillBy(dtCuentasBanco, Vw_CXP_SugPagoTesoreriaDataGridView.Item("cuentaBeneficiaria", contRows).Value, Vw_CXP_SugPagoTesoreriaDataGridView.Item("moneda", contRows).Value.ToString.Replace("MXN", "MXP"), "TER")
                        End If
                    Else
                        taCuentasBanco.ExisteEstatus_FillBy(dtCuentasBanco, Nothing, Vw_CXP_SugPagoTesoreriaDataGridView.Item("moneda", contRows).Value.ToString.Replace("MXN", "MXP"), "TER")
                    End If

                    If dtCuentasBanco.Rows.Count = 0 Then
                        taCuentasBanco.ExisteEstatus_FillBy(dtCuentasBanco, Vw_CXP_SugPagoTesoreriaDataGridView.Item("clabeBeneficiaria", contRows).Value, Vw_CXP_SugPagoTesoreriaDataGridView.Item("moneda", contRows).Value.ToString.Replace("MXN", "MXP"), "INT")
                        If dtCuentasBanco.Rows.Count = 0 Then
                            rows.DefaultCellStyle.BackColor = Color.Aqua
                        End If
                    End If
                ElseIf Vw_CXP_SugPagoTesoreriaDataGridView.Item("convenio", contRows).Value <> String.Empty Then
                    taCuentasBanco.ExisteEstatus_FillBy(dtCuentasBanco, Vw_CXP_SugPagoTesoreriaDataGridView.Item("convenio", contRows).Value, Vw_CXP_SugPagoTesoreriaDataGridView.Item("moneda", contRows).Value.ToString.Replace("MXN", "MXP"), "CIE")
                    If dtCuentasBanco.Rows.Count = 0 Then
                        rows.DefaultCellStyle.BackColor = Color.Aqua
                    End If
                ElseIf Vw_CXP_SugPagoTesoreriaDataGridView.Item("cuentaBeneficiaria", contRows).Value = String.Empty And Vw_CXP_SugPagoTesoreriaDataGridView.Item("clabeBeneficiaria", contRows).Value = String.Empty And Vw_CXP_SugPagoTesoreriaDataGridView.Item("referencia", contRows).Value <> String.Empty Then
                    taCuentasBanco.ExisteEstatus_FillBy(dtCuentasBanco, obtNumCadena(Vw_CXP_SugPagoTesoreriaDataGridView.Item("referencia", contRows).Value), Vw_CXP_SugPagoTesoreriaDataGridView.Item("moneda", contRows).Value.ToString.Replace("MXN", "MXP"), "TCR")
                    If dtCuentasBanco.Rows.Count = 0 Then
                        rows.DefaultCellStyle.BackColor = Color.Aqua
                    End If
                End If
                End If
            contRows += 1
        Next
        pbxCargando.Visible = False
        If estatusSol = "37" Then
            actualizaImporteProcesoPago()
        End If
    End Sub

    Private Sub CXP_PagosTesoreriaDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        Dim taDatosPagos As New dsTesoreriaTableAdapters.DatosPagosTableAdapter
        Dim dtDatosPagos As New dsTesoreria.DatosPagosDataTable
        Dim drDatosPagos As dsTesoreria.DatosPagosRow
        Dim contRows As Integer = 0
        For Each rows As DataGridViewRow In Vw_CXP_SugPagoTesoreriaDataGridView.Rows
            rows.Cells("sugerencia").Style.BackColor = Color.Red
            contRows += 1
        Next
    End Sub

    Private Sub actualizar()
        Dim taDatosPagos As New dsTesoreriaTableAdapters.DatosPagosTableAdapter
        Dim dtDatosPagos As New dsTesoreria.DatosPagosDataTable
        Dim drDatosPagos As dsTesoreria.DatosPagosRow
        Dim contRows As Integer = 0
        For Each rows As DataGridViewRow In Vw_CXP_SugPagoTesoreriaDataGridView.Rows
            taDatosPagos.Fill(dtDatosPagos, varGlobal_IdEmpresa, Vw_CXP_SugPagoTesoreriaDataGridView.Item("folioSolicitud", contRows).Value)

            If dtDatosPagos.Rows.Count = 1 Then
                drDatosPagos = dtDatosPagos.Rows(0)
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("clabeBeneficiaria", contRows).Value = drDatosPagos.clabe
            End If

            contRows += 1
        Next
        Me.Update()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles btnSeleccionarTodo.Click
        For Each rows As DataGridViewRow In Vw_CXP_SugPagoTesoreriaDataGridView.Rows
            If rows.Cells("estatusPago").Value = "33" Then
                rows.Cells("seleccionar").Value = True
            End If
        Next
        actualizaImporte()
    End Sub

    Private Sub btnSeleccionarNada_Click(sender As Object, e As EventArgs) Handles btnSeleccionarNada.Click
        For Each rows As DataGridViewRow In Vw_CXP_SugPagoTesoreriaDataGridView.Rows
            rows.Cells("seleccionar").Value = False
        Next
        actualizaImporte()
    End Sub

    Private Sub btnGenerarLayOut_Click(sender As Object, e As EventArgs) Handles btnGenerarLayOut.Click
        pbxCargando.Visible = True
        Application.DoEvents()
        Dim taCuentasBancarias As New dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter
        Dim dtCuentasBancarias As New dsTesoreria.CXP_CuentasBancariasDataTable
        Dim drCuentasBancarias As dsTesoreria.CXP_CuentasBancariasRow
        Dim cont As Integer = 0
        Dim fechaProceso As Date = Date.Now
        For Each rows As DataGridViewRow In Vw_CXP_SugPagoTesoreriaDataGridView.Rows
            If rows.Cells("seleccionar").Value = True Then
                cont += 1
            End If
        Next

        'For Each item As Object In cblTipoSolicitud.Items
        '    MsgBox(item.ToString)
        'Next

        If cont > 0 Then

            taCuentasBancarias.Fill(dtCuentasBancarias, varGlobal_IdEmpresa)

            'For Each drCuentasBancarias In dtCuentasBancarias.Rows
            For Each item In cblTS.Items
                Dim txt As StreamWriter
                sfdTxtBancario = New SaveFileDialog
                sfdTxtBancario.Filter = "txt files (*.txt)|*.txt"
                sfdTxtBancario.FilterIndex = 2
                sfdTxtBancario.RestoreDirectory = True
                sfdTxtBancario.FileName = varGlobal_rfcEmpresa.Replace("FIN940905AX7", "Finagil").Replace("SAR951230N5A", "Arfin") & " " & item.ToString & " " & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & ".txt"
                If lecturGridTxt(item.ToString, True, fechaProceso).ToString.Length > 0 Then
                    Application.DoEvents()
                    If sfdTxtBancario.ShowDialog = DialogResult.OK Then
                        Try
                            txt = New StreamWriter(sfdTxtBancario.FileName)
                            txt.Write(lecturGridTxt(item.ToString, False, fechaProceso))
                            txt.Close()


                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
                            txt.Close()
                        End Try
                    Else
                        MsgBox("Proceso cancelado...", MsgBoxStyle.Information, "")
                    End If
                End If
            Next
            MsgBox("Proceso terminado...", MsgBoxStyle.Information, "")
            generaConsulta()
        Else
            MsgBox("No se ha seleccionado ningún registro...", MsgBoxStyle.Information, "")
        End If
        pbxCargando.Visible = False
    End Sub

    Private Function lecturGridTxt(ByVal idBancoSat As String, ByVal consulta As Boolean, ByVal fechaProceso As Date)
        Dim taVwAutorizaciones As New dsTesoreriaTableAdapters.Vw_CXP_AutorizacionesTableAdapter
        Dim taCuentasBancarias As New dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter
        Dim idBancoXEmpresa As Integer
        If varGlobal_IdEmpresa = 24 Then idBancoXEmpresa = 1 Else idBancoXEmpresa = 2

        Dim texto As String = ""
        For Each rows As DataGridViewRow In Vw_CXP_SugPagoTesoreriaDataGridView.Rows
            Dim referencia As String = ""
            'If taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) = idBancoSat Then
            If rows.Cells("tipoSolicitud").Value = idBancoSat Then
                If rows.Cells("seleccionar").Value = True Then
                    If rows.Cells("tipoSolicitud").Value = "CXP" Then
                        If rows.Cells("clabeBeneficiaria").Value <> String.Empty Then
                            If rows.Cells("Tipar").Value = "-" Then
                                If rows.Cells("referencia").Value <> String.Empty Then ' pago con referencia
                                    'Pagos distintos a contratos
                                    If rows.Cells("idBancoBen").Value = taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) Then
                                        'Pagos a terceros
                                        texto += "PTC" & Stuff(rows.Cells("clabeBeneficiaria").Value.ToString.Substring(6, 11), "I", "0", 18) &
                                    Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                    rows.Cells("moneda").Value.ToString.Replace("MXN", "MXP") & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                    Stuff(rows.Cells("referencia").Value, "D", " ", 30) & "0                  000000000000.00"

                                        referencia = Stuff(rows.Cells("referencia").Value, "D", " ", 30)
                                    Else
                                        'Pagos interbancarios
                                        texto += "PSC" & Stuff(rows.Cells("clabeBeneficiaria").Value, "I", "0", 18) &
                                    Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                    rows.Cells("moneda").Value.ToString.Replace("MXN", "MXP") & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                    Stuff(obtRazonSocial(rows.Cells("razonSocial").Value.ToString.Trim, 30), "D", " ", 30) & "40" & rows.Cells("clabeBeneficiaria").Value.ToString.Substring(0, 3) &
                                    Stuff(rows.Cells("referencia").Value, "D", " ", 30) & Stuff(rows.Cells("folioSolicitud").Value, "I", "0", 7) & "H0                  000000000000.00"

                                        referencia = Stuff(rows.Cells("referencia").Value, "D", " ", 30)
                                    End If
                                Else ' pago sin referencia
                                    'Pagos distintos a contratos
                                    If rows.Cells("idBancoBen").Value = taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) Then
                                        'Pagos a terceros
                                        texto += "PTC" & Stuff(rows.Cells("clabeBeneficiaria").Value.ToString.Substring(6, 11), "I", "0", 18) &
                                    Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                    rows.Cells("moneda").Value.ToString.Replace("MXN", "MXP") & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                    Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                    tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22).Trim, "D", " ", 30) & "0                  000000000000.00"

                                        referencia = Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                    tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22).Trim, "D", " ", 30)
                                    Else
                                        'Pagos interbancarios
                                        texto += "PSC" & Stuff(rows.Cells("clabeBeneficiaria").Value, "I", "0", 18) &
                                    Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                    rows.Cells("moneda").Value.ToString.Replace("MXN", "MXP") & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                    Stuff(obtRazonSocial(rows.Cells("razonSocial").Value.ToString.Trim, 30), "D", " ", 30) & "40" & rows.Cells("clabeBeneficiaria").Value.ToString.Substring(0, 3) &
                                    Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                    tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22).Trim, "D", " ", 30) & Stuff(rows.Cells("folioSolicitud").Value, "I", "0", 7) & "H0                  000000000000.00"

                                        referencia = Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                    tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22).Trim, "D", " ", 30)
                                    End If
                                End If
                            Else
                                    'Pagos de contratos
                                    If rows.Cells("idBancoBen").Value = taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) Then
                                    'Pagos a terceros
                                    texto += "PTC" & Stuff(rows.Cells("clabeBeneficiaria").Value.ToString.Substring(6, 11), "I", "0", 18) &
                                Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                rows.Cells("moneda").Value.ToString.Replace("MXN", "MXP") & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                obtContrato(rows.Cells("noContrato").Value) & " " &
                                tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22 - (obtContrato(rows.Cells("noContrato").Value).Length + 1)).Trim, "D", " ", 30) & "0                  000000000000.00"

                                    referencia = Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                obtContrato(rows.Cells("noContrato").Value) & " " &
                                tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22 - (obtContrato(rows.Cells("noContrato").Value).Length + 1)).Trim, "D", " ", 30)
                                Else
                                    'Pagos interbancarios
                                    texto += "PSC" & Stuff(rows.Cells("clabeBeneficiaria").Value, "I", "0", 18) &
                                Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                rows.Cells("moneda").Value.ToString.Replace("MXN", "MXP") & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                                            Stuff(obtRazonSocial(rows.Cells("razonSocial").Value.ToString.Trim, 30), "D", " ", 30) & "40" & rows.Cells("clabeBeneficiaria").Value.ToString.Substring(0, 3) &
                                                            Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                obtContrato(rows.Cells("noContrato").Value) & " " &
                                tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22 - (obtContrato(rows.Cells("noContrato").Value).Length + 1)).Trim, "D", " ", 30) & Stuff(rows.Cells("folioSolicitud").Value, "I", "0", 7) & "H0                  000000000000.00"

                                    referencia = Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                obtContrato(rows.Cells("noContrato").Value) & " " &
                                tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22 - (obtContrato(rows.Cells("noContrato").Value).Length + 1)).Trim, "D", " ", 30)
                                End If
                            End If
                            If consulta = False Then
                                Dim folioCheque As Integer = taCuentasBancarias.ConsultaChequeActual_ScalarQuery(idBancoXEmpresa)
                                taPagos.CambiaEstatus_UpdateQuery("En Proceso de Pago", rows.Cells("folioSolicitud").Value, "No Pagada", rows.Cells("idEmpresa").Value)
                                taPagosTesoreria.CambiaEstatus_UpdateQuery(37, fechaProceso, Eliminar_Acentos(referencia.Trim), rows.Cells("bancoOrdenante").Value, folioCheque, rows.Cells("tipoSolicitud").Value, rows.Cells("folioSolicitud").Value, 33, rows.Cells("idEmpresa").Value)
                                taCuentasBancarias.ConsumeFolioCheque_UpdateQuery(idBancoXEmpresa)
                                texto = texto & vbCrLf
                            End If
                        Else
                            '///////////////**************************
                            If rows.Cells("convenio").Value <> String.Empty Then
                                If rows.Cells("Tipar").Value = "-" Then
                                    'Pagos distintos a contratos
                                    If rows.Cells("idBancoBen").Value = taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) Then
                                        'Pagos CIE
                                        texto += "CIL" & Stuff(obtRazonSocial(rows.Cells("concepto").Value.ToString.Trim, 30), "D", " ", 30) & Stuff(obtRazonSocial(rows.Cells("convenio").Value.ToString.Trim, 30), "I", "0", 7) &
                                        Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                        Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                        Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                        tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22).Trim, "D", " ", 30) &
                                        Stuff(rows.Cells("referencia").Value, "D", " ", 20)

                                        referencia = Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                        tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22).Trim, "D", " ", 30)
                                    End If
                                Else
                                    'Pagos de contratos
                                    If rows.Cells("idBancoBen").Value = taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) Then
                                        'Pagos CIE
                                        texto += "CIL" & Stuff(obtRazonSocial(rows.Cells("concepto").Value.ToString.Trim, 30), "D", " ", 30) & Stuff(obtRazonSocial(rows.Cells("convenio").Value.ToString.Trim, 30), "I", "0", 7) &
                                        Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                        Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                        Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                        obtContrato(rows.Cells("noContrato").Value) & " " &
                                         tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22 - (obtContrato(rows.Cells("noContrato").Value).Length + 1)).Trim, "D", " ", 30) &
                                        Stuff(rows.Cells("referencia").Value, "D", " ", 20)

                                        referencia = Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                        obtContrato(rows.Cells("noContrato").Value) & " " &
                                        tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22 - (obtContrato(rows.Cells("noContrato").Value).Length + 1)).Trim, "D", " ", 30)
                                    End If
                                End If
                                If consulta = False Then
                                    Dim folioCheque As Integer = taCuentasBancarias.ConsultaChequeActual_ScalarQuery(idBancoXEmpresa)
                                    taPagos.CambiaEstatus_UpdateQuery("En Proceso de Pago", rows.Cells("folioSolicitud").Value, "No Pagada", rows.Cells("idEmpresa").Value)
                                    taPagosTesoreria.CambiaEstatus_UpdateQuery(37, fechaProceso, Eliminar_Acentos(referencia.Trim), rows.Cells("bancoOrdenante").Value, folioCheque, rows.Cells("tipoSolicitud").Value, rows.Cells("folioSolicitud").Value, 33, rows.Cells("idEmpresa").Value)
                                    taCuentasBancarias.ConsumeFolioCheque_UpdateQuery(idBancoXEmpresa)
                                    texto = texto & vbCrLf
                                End If
                            End If
                        End If
                    Else
                        If rows.Cells("clabeBeneficiaria").Value <> String.Empty Then
                            If rows.Cells("Tipar").Value = "-" Then
                                'Pagos distintos a contratos
                                If rows.Cells("idBancoBen").Value = taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) Then
                                    'Pagos a terceros
                                    texto += "PTC" & Stuff(rows.Cells("clabeBeneficiaria").Value.ToString.Substring(6, 11), "I", "0", 18) &
                                Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                rows.Cells("moneda").Value.ToString.Replace("MXN", "MXP") & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                Stuff(rows.Cells("referencia").Value, "D", " ", 30) & "0                  000000000000.00"

                                    referencia = rows.Cells("referencia").Value
                                Else
                                    'Pagos interbancarios
                                    texto += "PSC" & Stuff(rows.Cells("clabeBeneficiaria").Value, "I", "0", 18) &
                                Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                rows.Cells("moneda").Value.ToString.Replace("MXN", "MXP") & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                Stuff(obtRazonSocial(rows.Cells("razonSocial").Value.ToString.Trim, 30), "D", " ", 30) & "40" & rows.Cells("clabeBeneficiaria").Value.ToString.Substring(0, 3) &
                                Stuff(rows.Cells("referencia").Value, "D", " ", 30) & Stuff(rows.Cells("folioSolicitud").Value, "I", "0", 7) & "H0                  000000000000.00"

                                    referencia = rows.Cells("referencia").Value
                                End If
                            Else
                                'Pagos de contratos
                                If rows.Cells("idBancoBen").Value = taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) Then
                                    'Pagos a terceros
                                    texto += "PTC" & Stuff(rows.Cells("clabeBeneficiaria").Value.ToString.Substring(6, 11), "I", "0", 18) &
                                Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                rows.Cells("moneda").Value.ToString.Replace("MXN", "MXP") & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                Stuff(rows.Cells("referencia").Value, "D", " ", 30) & "0                  000000000000.00"

                                    referencia = rows.Cells("referencia").Value
                                Else
                                    'Pagos interbancarios
                                    texto += "PSC" & Stuff(rows.Cells("clabeBeneficiaria").Value, "I", "0", 18) &
                                Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                rows.Cells("moneda").Value.ToString.Replace("MXN", "MXP") & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                                            Stuff(obtRazonSocial(rows.Cells("razonSocial").Value.ToString.Trim, 30), "D", " ", 30) & "40" & rows.Cells("clabeBeneficiaria").Value.ToString.Substring(0, 3) &
                                                            Stuff(rows.Cells("referencia").Value, "D", " ", 30) & Stuff(rows.Cells("folioSolicitud").Value, "I", "0", 7) & "H0                  000000000000.00"

                                    referencia = rows.Cells("referencia").Value
                                End If
                            End If
                            If consulta = False Then
                                Dim folioCheque As Integer = taCuentasBancarias.ConsultaChequeActual_ScalarQuery(idBancoXEmpresa)
                                taPagos.CambiaEstatus_UpdateQuery("En Proceso de Pago", rows.Cells("folioSolicitud").Value, "No Pagada", rows.Cells("idEmpresa").Value)
                                taPagosTesoreria.CambiaEstatus_UpdateQuery(37, fechaProceso, Eliminar_Acentos(referencia.Trim), rows.Cells("bancoOrdenante").Value, folioCheque, rows.Cells("tipoSolicitud").Value, rows.Cells("folioSolicitud").Value, 33, rows.Cells("idEmpresa").Value)
                                taCuentasBancarias.ConsumeFolioCheque_UpdateQuery(idBancoXEmpresa)
                                texto = texto & vbCrLf
                            End If
                        Else
                            '///////////////**************************
                            If rows.Cells("convenio").Value <> String.Empty Then
                                If rows.Cells("Tipar").Value = "-" Then
                                    'Pagos distintos a contratos
                                    If rows.Cells("idBancoBen").Value = taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) Then
                                        'Pagos CIE
                                        texto += "CIL" & Stuff(obtRazonSocial(rows.Cells("concepto").Value.ToString.Trim, 30), "D", " ", 30) & Stuff(obtRazonSocial(rows.Cells("convenio").Value.ToString.Trim, 30), "I", "0", 7) &
                                        Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                        Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                        Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                        tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22).Trim, "D", " ", 30) &
                                        Stuff(rows.Cells("referencia").Value, "D", " ", 20)

                                        referencia = rows.Cells("referencia").Value
                                    End If
                                Else
                                    'Pagos de contratos
                                    If rows.Cells("idBancoBen").Value = taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) Then
                                        'Pagos CIE
                                        texto += "CIL" & Stuff(obtRazonSocial(rows.Cells("concepto").Value.ToString.Trim, 30), "D", " ", 30) & Stuff(obtRazonSocial(rows.Cells("convenio").Value.ToString.Trim, 30), "I", "0", 7) &
                                        Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                        Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                        Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                        obtContrato(rows.Cells("noContrato").Value) & " " &
                                        tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22 - (obtContrato(rows.Cells("noContrato").Value).Length + 1)).Trim, "D", " ", 30) & "0                  000000000000.00" &
                                        Stuff(rows.Cells("referencia").Value, "D", " ", 20)

                                        referencia = rows.Cells("referencia").Value
                                    End If
                                End If
                                If consulta = False Then
                                    Dim folioCheque As Integer = taCuentasBancarias.ConsultaChequeActual_ScalarQuery(idBancoXEmpresa)
                                    taPagos.CambiaEstatus_UpdateQuery("En Proceso de Pago", rows.Cells("folioSolicitud").Value, "No Pagada", rows.Cells("idEmpresa").Value)
                                    taPagosTesoreria.CambiaEstatus_UpdateQuery(37, fechaProceso, Eliminar_Acentos(referencia.Trim), rows.Cells("bancoOrdenante").Value, folioCheque, rows.Cells("tipoSolicitud").Value, rows.Cells("folioSolicitud").Value, 33, rows.Cells("idEmpresa").Value)
                                    taCuentasBancarias.ConsumeFolioCheque_UpdateQuery(idBancoXEmpresa)
                                    texto = texto & vbCrLf
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Next

        Return texto
    End Function

    Private Function obtContrato(ByVal contrato As String) As String
        obtContrato = "CTO " & CStr(CInt(contrato.Substring(0, 5))) & " " & CStr(CInt(contrato.Substring(5, 4)))
    End Function
    Private Function obtRazonSocial(ByVal razonSocial As String, ByVal longitudMaxima As Integer) As String
        If razonSocial.Length > longitudMaxima Then
            obtRazonSocial = Eliminar_Acentos(razonSocial.Substring(0, longitudMaxima))
        Else
            obtRazonSocial = Eliminar_Acentos(razonSocial)
        End If
    End Function

    Public Sub generaConsulta()

        Dim listaTipoSol As String = ""


        'For i = 0 To cblTipoSolicitud.Items.Count
        For Each rw As Object In cblTS.CheckedItems
            listaTipoSol += "'" & rw.ToString & "',"
        Next
        ' Next


        Dim p As String = "0"

        Dim t As String = ""
        Dim c As String = ""

        If rbtnNoPagada.Checked = True Then
            p = "33"
            estatusSol = "33"
            ToolStripMenuItem1.Enabled = True
            ToolStripMenuItem2.Enabled = True
            ToolStripMenuItem3.Enabled = True
        ElseIf rbtnProcesoPago.Checked = True Then
            p = "37"
            estatusSol = "37"
            ToolStripMenuItem1.Enabled = True
            ToolStripMenuItem2.Enabled = True
            ToolStripMenuItem3.Enabled = True
        ElseIf rbtnPagada.Checked = True Then
            p = "34"
            estatusSol = "34"
            ToolStripMenuItem1.Enabled = True
            ToolStripMenuItem2.Enabled = False
            ToolStripMenuItem3.Enabled = False
        End If


        If chkTranferencia.Checked = True Then
            t = "TRE"
        End If
        If chkConvenio.Checked = True Then
            c = "CRE"
        End If

        dtpFechaPagoInicial.Enabled = False
        btnConsultar.Enabled = False
        btnSalir.Enabled = False
        Try
            Application.DoEvents()
            If p = "33" Then
                Me.Vw_CXP_SugPagoTesoreriaTableAdapter.PagosElectronicosNP_FillBy(Me.DsTesoreria.Vw_CXP_SugPagoTesoreria, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)), New System.Nullable(Of Date)(CType(dtpFechaPagoInicial.Value.AddDays(-1), Date)), New System.Nullable(Of Date)(CType(dtpFechaPagoFinal.Value, Date)), p)
            ElseIf p = "34" Then
                Me.Vw_CXP_SugPagoTesoreriaTableAdapter.PagosElectronicosP_FillBy(Me.DsTesoreria.Vw_CXP_SugPagoTesoreria, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)), p, New System.Nullable(Of Date)(CType(dtpFechaPagoInicial.Value.AddDays(-1), Date)), New System.Nullable(Of Date)(CType(dtpFechaPagoFinal.Value, Date)))
            ElseIf p = "37" Then
                Me.Vw_CXP_SugPagoTesoreriaTableAdapter.PagosElectronicosPP_FillBy(Me.DsTesoreria.Vw_CXP_SugPagoTesoreria, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)), p, New System.Nullable(Of Date)(CType(dtpFechaPagoInicial.Value.AddDays(-1), Date)), New System.Nullable(Of Date)(CType(dtpFechaPagoFinal.Value.AddDays(1), Date)))
            End If
            Me.Vw_CXP_SugPagoTesoreriaBindingSource.Filter = "ref IN ('" & t & "','" & c & "') AND tipoSolicitud IN (" & listaTipoSol & ")"
            Application.DoEvents()
            Vw_CXP_SugPagoTesoreriaDataGridView.Visible = True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        actualizaGrid()
        dtpFechaPagoInicial.Enabled = True
        btnConsultar.Enabled = True
        btnSalir.Enabled = True
        pbxCargando.Visible = False
    End Sub

    Private Sub Vw_CXP_SugPagoTesoreriaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vw_CXP_SugPagoTesoreriaDataGridView.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim mdiFrmDocumentosAdjuntos As New frmDocumentosAdjuntos
            Dim mdiSolicitudesPago As New mdicuentasPorPagar
            Me.Enabled = False
            mdiSolicitudesPago = MdiParent
            mdiFrmDocumentosAdjuntos.MdiParent = mdiSolicitudesPago
            Me.Cursor = Cursors.WaitCursor
            mdiFrmDocumentosAdjuntos.tipoSolicitud = Vw_CXP_SugPagoTesoreriaDataGridView.Item(7, e.RowIndex).Value
            mdiFrmDocumentosAdjuntos.idSolPago = Vw_CXP_SugPagoTesoreriaDataGridView.Item(0, e.RowIndex).Value
            mdiFrmDocumentosAdjuntos.Show()
            Me.Cursor = Cursors.Default
        ElseIf e.ColumnIndex = 12 Then
            actualizaImporte()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPdfConfirmacion.Click
        contadorPagosTes = 0
        Dim filePath As String = ""
        ofdPdfConfirmacion.Filter = "pdf|*.pdf|PDF|*.PDF"
        Dim guuid As String = Guid.NewGuid.ToString

        If ofdPdfConfirmacion.ShowDialog() = DialogResult.OK Then
            Try
                filePath = ofdPdfConfirmacion.FileName
                extraePaginaSharp(filePath, My.Settings.fileNas & "CXP\ComPago\", guuid, "", "", "", "", "")

                System.IO.File.Copy(ofdPdfConfirmacion.FileName, My.Settings.fileNas & "CXP\ComPago\ComOriginales\" & guuid & ".pdf")

                MsgBox("Proceso terminado..." & vbNewLine & "Páginas comprobante: " & contadorPagosPag.ToString & vbNewLine & "Documentos confirmados: " & contadorPagosTes.ToString, MsgBoxStyle.Information, "")
                generaConsulta()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
            End Try
        Else
            MsgBox("Proceso cancelado", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Sub rbtnPagada_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPagada.CheckedChanged
        gbxLayout.Enabled = False
        gbxSeleccionar.Enabled = False
    End Sub

    Private Sub rbtnProcesoPago_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnProcesoPago.CheckedChanged
        gbxLayout.Enabled = False
        gbxSeleccionar.Enabled = False
    End Sub

    Private Sub rbtnNoPagada_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnNoPagada.CheckedChanged

    End Sub

    Private Sub frmTesSolicitudesDePago_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        contadorActividad = 0
    End Sub

    Private Sub Vw_CXP_SugPagoTesoreriaDataGridView_MouseMove(sender As Object, e As MouseEventArgs) Handles Vw_CXP_SugPagoTesoreriaDataGridView.MouseMove
        contadorActividad = 0
    End Sub

    Private Sub actualizaImporte()
        Vw_CXP_SugPagoTesoreriaDataGridView.EndEdit()
        importeTotal = 0
        registrosSeleccionados = 0

        Me.Refresh()
        Me.Update()

        For Each rows As DataGridViewRow In Vw_CXP_SugPagoTesoreriaDataGridView.Rows
            If rows.Cells("seleccionar").Value = True Then
                importeTotal = importeTotal + CDec(rows.Cells("importeSolicitado").Value)
                registrosSeleccionados += 1
            End If
        Next
        tssRegistrosSeleccionados.Text = registrosSeleccionados.ToString
        lblTotalAPagar.Text = FormatCurrency(importeTotal.ToString)
    End Sub

    Private Sub actualizaImporteProcesoPago()
        Vw_CXP_SugPagoTesoreriaDataGridView.EndEdit()
        importeTotal = 0
        registrosSeleccionados = 0

        Me.Refresh()
        Me.Update()

        For Each rows As DataGridViewRow In Vw_CXP_SugPagoTesoreriaDataGridView.Rows
            importeTotal = importeTotal + CDec(rows.Cells("importeSolicitado").Value)
            registrosSeleccionados += 1
        Next
        tssRegistrosSeleccionados.Text = registrosSeleccionados.ToString
        lblTotalAPagar.Text = FormatCurrency(importeTotal.ToString)
    End Sub

    Private Sub Vw_CXP_SugPagoTesoreriaDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Vw_CXP_SugPagoTesoreriaDataGridView.CellEndEdit
        actualizaImporte()
    End Sub

    Private Sub Vw_CXP_SugPagoTesoreriaDataGridView_CellContextMenuStripChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Vw_CXP_SugPagoTesoreriaDataGridView.CellContextMenuStripChanged
        actualizaImporte()
    End Sub

    Private Sub Vw_CXP_SugPagoTesoreriaDataGridView_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Vw_CXP_SugPagoTesoreriaDataGridView.CellMouseDown
        idSolPagoG = Vw_CXP_SugPagoTesoreriaDataGridView.Item(0, e.RowIndex).Value
        tipoSolicitudG = Vw_CXP_SugPagoTesoreriaDataGridView.Item("tipoSolicitud", e.RowIndex).Value
        convenioG = Vw_CXP_SugPagoTesoreriaDataGridView.Item("convenio", e.RowIndex).Value
        folioSolicitudG = Vw_CXP_SugPagoTesoreriaDataGridView.Item("folioSolicitud", e.RowIndex).Value
        idBancoG = Vw_CXP_SugPagoTesoreriaDataGridView.Item("origenRecurso", e.RowIndex).Value
        If idBancoG = 0 Then
            idBancoG = CXPCuentasBancariasBindingSource.Current("idCuentaBancaria") 'Vw_CXP_SugPagoTesoreriaDataGridView.Item("idBancoBen", e.RowIndex).Value
        End If
        referenciaG = Vw_CXP_SugPagoTesoreriaDataGridView.Item("referencia", e.RowIndex).Value
        importeG = Vw_CXP_SugPagoTesoreriaDataGridView.Item("importeSolicitado", e.RowIndex).Value
    End Sub

    Private Sub cmsMenuOpciones_Opening(sender As Object, e As CancelEventArgs) Handles cmsMenuOpciones.Opening
        If (tipoSolicitudG = "CXP") And (estatusSol = "33" Or estatusSol = "34") Then
            ToolStripMenuItem3.Enabled = False
        Else
            ToolStripMenuItem3.Enabled = True
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If tipoSolicitudG <> "AVI" And convenioG = "" Then
            Dim mdiCargPagNoCie As New frmCargPagNoCie
            Dim mdiSolicitudesPago As New mdicuentasPorPagar
            Me.Enabled = False
            mdiSolicitudesPago = MdiParent
            mdiCargPagNoCie.MdiParent = mdiSolicitudesPago
            Me.Cursor = Cursors.WaitCursor
            mdiCargPagNoCie.folioSolicitud = folioSolicitudG
            mdiCargPagNoCie.tipoSolicitud = tipoSolicitudG
            mdiCargPagNoCie.idBanco = idBancoG
            mdiCargPagNoCie.referencia = referenciaG
            mdiCargPagNoCie.tdc = "TDC"
            mdiCargPagNoCie.Show()
            Me.Cursor = Cursors.Default
        ElseIf tipoSolicitudG <> "AVI" And convenioG <> "" Then
            Dim mdiCargPagNoCie As New frmCargPagNoCie
            Dim mdiSolicitudesPago As New mdicuentasPorPagar
            Me.Enabled = False
            mdiSolicitudesPago = MdiParent
            mdiCargPagNoCie.MdiParent = mdiSolicitudesPago
            Me.Cursor = Cursors.WaitCursor
            mdiCargPagNoCie.folioSolicitud = folioSolicitudG
            mdiCargPagNoCie.tipoSolicitud = tipoSolicitudG
            mdiCargPagNoCie.idBanco = idBancoG
            mdiCargPagNoCie.tdc = "CIE"
            mdiCargPagNoCie.Show()
            Me.Cursor = Cursors.Default
        Else
            MsgBox("El pago es Avio", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim mdiFrmDocumentosAdjuntos As New frmDocumentosAdjuntos
        Dim mdiSolicitudesPago As New mdicuentasPorPagar
        Me.Enabled = False
        mdiSolicitudesPago = MdiParent
        mdiFrmDocumentosAdjuntos.MdiParent = mdiSolicitudesPago
        Me.Cursor = Cursors.WaitCursor
        mdiFrmDocumentosAdjuntos.idSolPago = idSolPagoG
        mdiFrmDocumentosAdjuntos.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

        Dim mdiFrmCancelaMovimientos As New frmCancelaMovimiento
        Dim mdiSolicitudesPago As New mdicuentasPorPagar
        Me.Enabled = False
        mdiSolicitudesPago = MdiParent
        mdiFrmCancelaMovimientos.MdiParent = mdiSolicitudesPago
        Me.Cursor = Cursors.WaitCursor
        mdiFrmCancelaMovimientos.tipoSolicitudCan = tipoSolicitudG
        mdiFrmCancelaMovimientos.folioSolicitudCan = folioSolicitudG
        mdiFrmCancelaMovimientos.importeCan = importeG
        mdiFrmCancelaMovimientos.estatusSolicitud = estatusSol
        mdiFrmCancelaMovimientos.idBancoOrigenCan = idBancoG
        mdiFrmCancelaMovimientos.Show()
        Me.Cursor = Cursors.Default

    End Sub
End Class