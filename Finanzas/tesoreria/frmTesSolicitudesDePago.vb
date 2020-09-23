Imports System.IO
Imports System.Windows.Forms
Imports AcroPDFLib
Imports AxAcroPDFLib
Public Class frmTesSolicitudesDePago

    Dim taPagos As New dsTesoreriaTableAdapters.CXP_PagosTableAdapter
    Dim taPagosTesoreria As New dsTesoreriaTableAdapters.CXP_PagosTesoreriaTableAdapter

    Private Sub frmTesSolicitudesDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaPagoInicial.Value = Date.Now.AddDays(-Now.Day + 1)
        'TODO: esta línea de código carga datos en la tabla 'DsTesoreria.CXP_CuentasBancarias' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasBancariasTableAdapter.Fill(Me.DsTesoreria.CXP_CuentasBancarias, varGlobal_IdEmpresa)

        Vw_CXP_SugPagoTesoreriaDataGridView.Visible = False

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        pbxCargando.Visible = True
        Application.DoEvents()

        If dtpFechaPagoFinal.Value < dtpFechaPagoInicial.Value Then
            MsgBox("La fecha inicial no puede ser mayor a la fecha final...", MsgBoxStyle.Critical, "")
        Else
            generaConsulta()
        End If

    End Sub


    Private Sub actualizaGrid()
        'Dim dgvColumna As DataGridViewComboBoxCell = New DataGridViewComboBoxCell
        'gbxSeleccionar.Enabled = False
        'gbxLayout.Enabled = False
        Dim dataRow As DataRowView

        Dim taDatosPagos As New dsTesoreriaTableAdapters.DatosPagosTableAdapter
        Dim dtDatosPagos As New dsTesoreria.DatosPagosDataTable
        Dim drDatosPagos As dsTesoreria.DatosPagosRow
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

            dc = CType(Vw_CXP_SugPagoTesoreriaDataGridView.Rows(contRows).Cells("bancoOrdenante"), DataGridViewComboBoxCell)
            dataRow = dc.Items(0)
            dc.Value = dataRow.Item(0)

            If dtDatosPagos.Rows.Count = 1 Then
                drDatosPagos = dtDatosPagos.Rows(0)
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("clabeBeneficiaria", contRows).Value = drDatosPagos.clabe
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("cuentaBeneficiaria", contRows).Value = drDatosPagos.cuenta
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("convenio", contRows).Value = drDatosPagos.convenio
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("referencia", contRows).Value = drDatosPagos.referencia
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("bancoBeneficiario", contRows).Value = drDatosPagos.nombreCorto
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("idBancoBen", contRows).Value = drDatosPagos.idBanco
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("noContrato", contRows).Value = drDatosPagos.noContrato

                If Vw_CXP_SugPagoTesoreriaDataGridView.Item("estatusPago", contRows).Value = "37" Or Vw_CXP_SugPagoTesoreriaDataGridView.Item("estatusPago", contRows).Value = "34" Then
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("seleccionar").Visible = False
                    d.Visible = False
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("bancoOrdenante").Visible = False
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").DisplayIndex = 9
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").Frozen = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").Visible = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").HeaderText = "Banco Ordenante"
                Else
                    d.Visible = True
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("bancoOrdenante").Visible = True
                    'Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").DisplayIndex = 9
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").Frozen = False
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("nombre").Visible = False
                    Vw_CXP_SugPagoTesoreriaDataGridView.Columns.Item("seleccionar").Visible = True
                End If

            ElseIf dtDatosPagos.Rows.Count = 0 Then
                'CXP_PagosTesoreriaDataGridView.Rows.Remove(rows)
            End If

            contRows += 1
            'gbxSeleccionar.Enabled = True
            'gbxLayout.Enabled = True
        Next
        pbxCargando.Visible = False
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
    End Sub

    Private Sub btnSeleccionarNada_Click(sender As Object, e As EventArgs) Handles btnSeleccionarNada.Click
        For Each rows As DataGridViewRow In Vw_CXP_SugPagoTesoreriaDataGridView.Rows
            rows.Cells("seleccionar").Value = False
        Next
    End Sub

    Private Sub btnGenerarLayOut_Click(sender As Object, e As EventArgs) Handles btnGenerarLayOut.Click
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
        If cont > 0 Then

            taCuentasBancarias.Fill(dtCuentasBancarias, varGlobal_IdEmpresa)

            For Each drCuentasBancarias In dtCuentasBancarias.Rows
                Dim txt As StreamWriter
                sfdTxtBancario = New SaveFileDialog
                sfdTxtBancario.Filter = "txt files (*.txt)|*.txt"
                sfdTxtBancario.FilterIndex = 2
                sfdTxtBancario.RestoreDirectory = True
                sfdTxtBancario.FileName = varGlobal_rfcEmpresa & " " & drCuentasBancarias.nombre.Replace(",", "") & " " & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & ".txt"
                If lecturGridTxt(drCuentasBancarias.idBancoSat, True, fechaProceso).ToString.Length > 0 Then

                    If sfdTxtBancario.ShowDialog = DialogResult.OK Then
                        Try
                            txt = New StreamWriter(sfdTxtBancario.FileName)
                            txt.WriteLine(lecturGridTxt(drCuentasBancarias.idBancoSat, False, fechaProceso))
                            txt.Close()
                            generaConsulta()
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
                            txt.Close()
                        End Try
                    Else
                        MsgBox("Proceso cancelado...", MsgBoxStyle.Information, "")
                    End If
                End If
            Next
        Else
            MsgBox("No se ha seleccionado ningún registro...", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Function lecturGridTxt(ByVal idBancoSat As Integer, ByVal consulta As Boolean, ByVal fechaProceso As Date)
        Dim taVwAutorizaciones As New dsTesoreriaTableAdapters.Vw_CXP_AutorizacionesTableAdapter
        Dim taCuentasBancarias As New dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter

        Dim texto As String = ""
        For Each rows As DataGridViewRow In Vw_CXP_SugPagoTesoreriaDataGridView.Rows
            Dim referencia As String = ""
            If taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) = idBancoSat Then
                If rows.Cells("seleccionar").Value = True Then
                    If rows.Cells("clabeBeneficiaria").Value <> String.Empty Then
                        If rows.Cells("Tipar").Value = "-" Then
                            'Pagos distintos a contratos
                            If rows.Cells("idBancoBen").Value = taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) Then
                                'Pagos a terceros
                                texto += "PTC" & Stuff(rows.Cells("clabeBeneficiaria").Value, "I", "0", 18) &
                            Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                            rows.Cells("moneda").Value & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                            Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                            tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22).Trim, "D", " ", 30) & "0                  000000000000.00" & vbNewLine

                                referencia = Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                            tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22).Trim, "D", " ", 30) & "0                  000000000000.00" & vbNewLine
                            Else
                                'Pagos interbancarios
                                texto += "PSC" & Stuff(rows.Cells("clabeBeneficiaria").Value, "I", "0", 18) &
                            Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                            rows.Cells("moneda").Value & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                            Stuff(obtRazonSocial(rows.Cells("razonSocial").Value.ToString.Trim, 30), "D", " ", 30) & "40" & rows.Cells("clabeBeneficiaria").Value.ToString.Substring(0, 3) &
                            Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                            tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22).Trim, "D", " ", 30) & "0999999H0                  000000000000.00" & vbNewLine

                                referencia = Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                            tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22).Trim, "D", " ", 30) & "0999999H0                  000000000000.00" & vbNewLine
                            End If
                        Else
                            'Pagos de contratos
                            If rows.Cells("idBancoBen").Value = taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) Then
                                'Pagos a terceros
                                texto += "PTC" & Stuff(rows.Cells("clabeBeneficiaria").Value, "I", "0", 18) &
                            Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                            rows.Cells("moneda").Value & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                            Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                            obtContrato(rows.Cells("noContrato").Value) & " " &
                            tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22 - (obtContrato(rows.Cells("noContrato").Value).Length + 1)).Trim, "D", " ", 30) & "0                  000000000000.00" & vbNewLine

                                referencia = Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                            obtContrato(rows.Cells("noContrato").Value) & " " &
                            tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22 - (obtContrato(rows.Cells("noContrato").Value).Length + 1)).Trim, "D", " ", 30) & "0                  000000000000.00" & vbNewLine
                            Else
                                'Pagos interbancarios
                                texto += "PSC" & Stuff(rows.Cells("clabeBeneficiaria").Value, "I", "0", 18) &
                            Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                            rows.Cells("moneda").Value & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                                        Stuff(obtRazonSocial(rows.Cells("razonSocial").Value.ToString.Trim, 30), "D", " ", 30) & "40" & rows.Cells("clabeBeneficiaria").Value.ToString.Substring(0, 3) &
                                                        Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                            obtContrato(rows.Cells("noContrato").Value) & " " &
                            tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22 - (obtContrato(rows.Cells("noContrato").Value).Length + 1)).Trim, "D", " ", 30) & "0999999H0                  000000000000.00" & vbNewLine

                                referencia = Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                            obtContrato(rows.Cells("noContrato").Value) & " " &
                            tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22 - (obtContrato(rows.Cells("noContrato").Value).Length + 1)).Trim, "D", " ", 30) & "0999999H0                  000000000000.00" & vbNewLine
                            End If
                        End If
                        If consulta = False Then
                            taPagos.CambiaEstatus_UpdateQuery("En Proceso de Pago", rows.Cells("folioSolicitud").Value, "No Pagada", rows.Cells("idEmpresa").Value)
                            taPagosTesoreria.CambiaEstatus_UpdateQuery(37, fechaProceso, Eliminar_Acentos(referencia.Trim), rows.Cells("bancoOrdenante").Value, rows.Cells("tipoSolicitud").Value, rows.Cells("folioSolicitud").Value, 33, rows.Cells("idEmpresa").Value)
                        End If
                    Else
                        '///////////////**************************
                        If rows.Cells("convenio").Value <> String.Empty Then
                            If rows.Cells("Tipar").Value = "-" Then
                                'Pagos distintos a contratos
                                If rows.Cells("idBancoBen").Value = taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) Then
                                    'Pagos CIE
                                    texto += "CIL" & Stuff(obtRazonSocial(rows.Cells("razonSocial").Value.ToString.Trim, 30), "D", " ", 30) & Stuff(obtRazonSocial(rows.Cells("convenio").Value.ToString.Trim, 30), "D", " ", 7) &
                                    Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                    Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                    Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                    tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22).Trim, "D", " ", 30) &
                                    Stuff(rows.Cells("referencia").Value, "I", " ", 20)

                                    referencia = Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                    tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22).Trim, "D", " ", 30)
                                End If
                            Else
                                'Pagos de contratos
                                If rows.Cells("idBancoBen").Value = taCuentasBancarias.ObtIdBanco_ScalarQuery(rows.Cells("bancoOrdenante").Value) Then
                                    'Pagos CIE
                                    texto += "CIL" & Stuff(obtRazonSocial(rows.Cells("razonSocial").Value.ToString.Trim, 30), "D", " ", 30) & Stuff(obtRazonSocial(rows.Cells("convenio").Value.ToString.Trim, 30), "D", " ", 7) &
                                    Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                                    Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                    Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                    obtContrato(rows.Cells("noContrato").Value) & " " &
                                    tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22 - (obtContrato(rows.Cells("noContrato").Value).Length + 1)).Trim, "D", " ", 30) & "0                  000000000000.00" & vbNewLine &
                                    Stuff(rows.Cells("referencia").Value, "I", " ", 20)

                                    referencia = Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                                    obtContrato(rows.Cells("noContrato").Value) & " " &
                                    tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22 - (obtContrato(rows.Cells("noContrato").Value).Length + 1)).Trim, "D", " ", 30) & "0                  000000000000.00" & vbNewLine
                                End If
                            End If
                            If consulta = False Then
                                taPagos.CambiaEstatus_UpdateQuery("En Proceso de Pago", rows.Cells("folioSolicitud").Value, "No Pagada", rows.Cells("idEmpresa").Value)
                                taPagosTesoreria.CambiaEstatus_UpdateQuery(37, fechaProceso, Eliminar_Acentos(referencia.Trim), rows.Cells("bancoOrdenante").Value, rows.Cells("tipoSolicitud").Value, rows.Cells("folioSolicitud").Value, 33, rows.Cells("idEmpresa").Value)
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
            obtRazonSocial = razonSocial.Substring(0, longitudMaxima)
        Else
            obtRazonSocial = razonSocial
        End If
    End Function

    Private Sub generaConsulta()

        Dim p As String = "0"

        Dim t As String = ""
        Dim c As String = ""

        If rbtnNoPagada.Checked = True Then
            p = "33"
        ElseIf rbtnProcesoPago.Checked = True Then
            p = "37"
        ElseIf rbtnPagada.Checked = True Then
            p = "34"
        End If


        If chkTranferencia.Checked = True Then
            t = "TRE"
        End If
        If chkConvenio.Checked = True Then
            c = "CER"
        End If

        dtpFechaPagoInicial.Enabled = False
        btnConsultar.Enabled = False
        btnSalir.Enabled = False
        Try
            Application.DoEvents()
            Me.Vw_CXP_SugPagoTesoreriaTableAdapter.PagosElectronicos_FillBy(Me.DsTesoreria.Vw_CXP_SugPagoTesoreria, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)), New System.Nullable(Of Date)(CType(dtpFechaPagoInicial.Value.AddDays(-1), Date)), New System.Nullable(Of Date)(CType(dtpFechaPagoFinal.Value, Date)))
            Me.Vw_CXP_SugPagoTesoreriaBindingSource.Filter = "estatusPago = '" & p & "' AND ref IN('" & t & "','" & c & "')"
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

    Private Sub loadTable()

    End Sub


    Private Sub Vw_CXP_SugPagoTesoreriaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vw_CXP_SugPagoTesoreriaDataGridView.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim mdiFrmDocumentosAdjuntos As New frmDocumentosAdjuntos
            Dim mdiSolicitudesPago As New mdicuentasPorPagar
            Me.Enabled = False
            mdiSolicitudesPago = MdiParent
            mdiFrmDocumentosAdjuntos.MdiParent = mdiSolicitudesPago
            Me.Cursor = Cursors.WaitCursor
            mdiFrmDocumentosAdjuntos.idSolPago = Vw_CXP_SugPagoTesoreriaDataGridView.Item(0, e.RowIndex).Value
            mdiFrmDocumentosAdjuntos.Show()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPdfConfirmacion.Click
        Dim filePath As String = ""
        ofdPdfConfirmacion.Filter = "pdf|*.pdf|PDF|*.PDF"
        Dim guuid As String = Guid.NewGuid.ToString

        If ofdPdfConfirmacion.ShowDialog() = DialogResult.OK Then
            Try
                filePath = ofdPdfConfirmacion.FileName
                extraePaginaSharp(filePath, My.Settings.fileNas & "CXP\ComPago\", guuid)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
            End Try
        Else
            MsgBox("Proceso cancelado")
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
        gbxLayout.Enabled = True
        gbxSeleccionar.Enabled = True
    End Sub
End Class