Imports System.IO
Imports System.Windows.Forms
Public Class frmTesSolicitudesDePago
    Private Sub frmTesSolicitudesDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsTesoreria.CXP_CuentasBancarias' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasBancariasTableAdapter.Fill(Me.DsTesoreria.CXP_CuentasBancarias, varGlobal_IdEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'DsTesoreria.Vw_CXP_SugPagoTesoreria' Puede moverla o quitarla según sea necesario.
        'Me.Vw_CXP_SugPagoTesoreriaTableAdapter.Fill(Me.DsTesoreria.Vw_CXP_SugPagoTesoreria)
        'Try
        '    Me.Vw_CXP_SugPagoTesoreriaTableAdapter.Fill(Me.DsTesoreria.Vw_CXP_SugPagoTesoreria, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)), New System.Nullable(Of Decimal)(CType("33", Decimal)), New System.Nullable(Of Date)(CType(dtpFechaPago.Value, Date)))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try
        'actualizaGrid()
        'Call btnConsultar_Click(sender, e)

        Vw_CXP_SugPagoTesoreriaDataGridView.Visible = False

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            'Vw_CXP_SugPagoTesoreriaDataGridView.Dispose()
            Me.Vw_CXP_SugPagoTesoreriaTableAdapter.PagosElectronicos_FillBy(Me.DsTesoreria.Vw_CXP_SugPagoTesoreria, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)), New System.Nullable(Of Decimal)(CType("33", Decimal)), New System.Nullable(Of Date)(CType(dtpFechaPago.Value, Date)))
            Vw_CXP_SugPagoTesoreriaDataGridView.Visible = True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        actualizaGrid()
    End Sub




    'Private Sub frmTesSolicitudesDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'TODO: esta línea de código carga datos en la tabla 'DsTesoreria.Vw_CXP_SugerenciasPago' Puede moverla o quitarla según sea necesario.
    '    Me.Vw_CXP_SugerenciasPagoTableAdapter.Fill(Me.DsTesoreria.Vw_CXP_SugerenciasPago, varGlobal_IdEmpresa)

    '    'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Estatus2' Puede moverla o quitarla según sea necesario.
    '    Me.CXP_Estatus2TableAdapter.Fill(Me.DsProduction.CXP_Estatus2)
    '    'TODO: esta línea de código carga datos en la tabla 'DsTesoreria.CXP_CuentasBancarias' Puede moverla o quitarla según sea necesario.
    '    Me.CXP_CuentasBancariasTableAdapter.Fill(Me.DsTesoreria.CXP_CuentasBancarias)


    '    Try
    '        Me.CXP_PagosTesoreriaTableAdapter.Fill(Me.DsTesoreria.CXP_PagosTesoreria, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try
    '    actualizaGrid()
    'End Sub

    Private Sub actualizaGrid()
        'Dim dgvColumna As DataGridViewComboBoxCell = New DataGridViewComboBoxCell
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
        'dataRow = d.Items(0)
        'd.Selected = 0



        'dgvColumna.DataSource = Me.CXPCuentasBancariasBindingSource
        'dgvColumna.DisplayMember = "nombre"
        'dgvColumna.ValueMember = "idCuentaBancaria"



        For Each rows As DataGridViewRow In Vw_CXP_SugPagoTesoreriaDataGridView.Rows
            taDatosPagos.Fill(dtDatosPagos, varGlobal_IdEmpresa, Vw_CXP_SugPagoTesoreriaDataGridView.Item("folioSolicitud", contRows).Value)

            'Vw_CXP_SugPagoTesoreriaDataGridView.Item("bancoOrdenante", contRows).Value = "Hola"

            'Me.Vw_CXP_SugPagoTesoreriaDataGridView.Item("fechaPago", contRows).Style.BackColor = Color.Green
            dc = CType(Vw_CXP_SugPagoTesoreriaDataGridView.Rows(contRows).Cells("bancoOrdenante"), DataGridViewComboBoxCell)
            dataRow = dc.Items(0)
            dc.Value = dataRow.Item(0)


            'dgvColumna = CType(Vw_CXP_SugPagoTesoreriaDataGridView.Rows(contRows).Cells("bancoOrdenante"), DataGridViewComboBoxCell)
            'dgvColumna.DataSource = Me.CXPCuentasBancariasBindingSource
            'dgvColumna.DisplayMember = "nombre"
            'dgvColumna.ValueMember = "idCuentaBancaria"
            'dgvColumna.Value = 1


            If dtDatosPagos.Rows.Count = 1 Then
                drDatosPagos = dtDatosPagos.Rows(0)
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("clabeBeneficiaria", contRows).Value = drDatosPagos.clabe
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("cuentaBeneficiaria", contRows).Value = drDatosPagos.cuenta
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("convenio", contRows).Value = drDatosPagos.convenio
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("referencia", contRows).Value = drDatosPagos.referencia
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("bancoBeneficiario", contRows).Value = drDatosPagos.nombreCorto
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("idBancoBen", contRows).Value = drDatosPagos.idBanco
                Vw_CXP_SugPagoTesoreriaDataGridView.Item("noContrato", contRows).Value = drDatosPagos.noContrato

                'dataRow = dgvColumna.Items(0)
                'dgvColumna.Value = dataRow.Item(0)

                'Vw_CXP_SugPagoTesoreriaDataGridView.Item("moneda", contRows).Value = drDatosPagos.moneda
                'Vw_CXP_SugPagoTesoreriaDataGridView.Item("tipoCambio", contRows).Value = drDatosPagos.TipoCambio
                'If drDatosPagos.ok1 <> "" And drDatosPagos.ok1 <> "CANCELADA" And drDatosPagos.ok2 <> "" And drDatosPagos.ok2 <> "CANCELADA" Then
                '    Vw_CXP_SugPagoTesoreriaDataGridView.Item("estatusAutorizacion", contRows).Value = "AUTORIZADA"
                'Else
                '    Vw_CXP_SugPagoTesoreriaDataGridView.Item("estatusAutorizacion", contRows).Value = "NO AUTORIZADA"
                'End If
            ElseIf dtDatosPagos.Rows.Count = 0 Then
                'CXP_PagosTesoreriaDataGridView.Rows.Remove(rows)
            End If

            contRows += 1
        Next

    End Sub


    Private Sub CXP_PagosTesoreriaDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        Dim taDatosPagos As New dsTesoreriaTableAdapters.DatosPagosTableAdapter
        Dim dtDatosPagos As New dsTesoreria.DatosPagosDataTable
        Dim drDatosPagos As dsTesoreria.DatosPagosRow
        Dim contRows As Integer = 0
        For Each rows As DataGridViewRow In Vw_CXP_SugPagoTesoreriaDataGridView.Rows
            rows.Cells("sugerencia").Style.BackColor = Color.Red

            'If rows.Cells("fechaPago").Value = "" Then
            '    rows.DefaultCellStyle.BackColor = Color.Red
            '    rows.Cells("estatusAutorizacion").Value = "CANCELADA"
            '    rows.ReadOnly = True
            'ElseIf rows.Cells("estatusAutorizacion").Value = "NO AUTORIZADA" Then
            '    rows.ReadOnly = True
            '    rows.DefaultCellStyle.BackColor = Color.White
            'ElseIf rows.Cells("estatusAutorizacion").Value = "AUTORIZADA" Then
            '    rows.DefaultCellStyle.BackColor = Color.GreenYellow
            'End If
            contRows += 1
        Next
    End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    actualizaGrid()
    'End Sub

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
            rows.Cells("seleccionar").Value = True
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
                sfdTxtBancario.FileName = "Pagos Br " & varGlobal_rfcEmpresa & " " & drCuentasBancarias.nombre.Replace(",", "") & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & ".txt"
                If lecturGridTxt(drCuentasBancarias.idBancoSat).ToString.Length > 0 Then

                    If sfdTxtBancario.ShowDialog = DialogResult.OK Then
                        Try
                            txt = New StreamWriter(sfdTxtBancario.FileName)
                            txt.WriteLine(lecturGridTxt(drCuentasBancarias.idBancoSat))
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
        Else
            MsgBox("No se ha seleccionado ningún registro...", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Function lecturGridTxt(ByVal idBancoSat As Integer)
        Dim taVwAutorizaciones As New dsTesoreriaTableAdapters.Vw_CXP_AutorizacionesTableAdapter
        Dim taCuentasBancarias As New dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter
        Dim texto As String = ""
        For Each rows As DataGridViewRow In Vw_CXP_SugPagoTesoreriaDataGridView.Rows
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
                            Else
                                'Pagos interbancarios
                                texto += "PSC" & Stuff(rows.Cells("clabeBeneficiaria").Value, "I", "0", 18) &
                            Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                            rows.Cells("moneda").Value & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                            Stuff(obtRazonSocial(rows.Cells("razonSocial").Value.ToString.Trim, 30), "D", " ", 30) & "40" & rows.Cells("clabeBeneficiaria").Value.ToString.Substring(0, 3) &
                            Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
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
                            Else
                                'Pagos interbancarios
                                texto += "PSC" & Stuff(rows.Cells("clabeBeneficiaria").Value, "I", "0", 18) &
                            Stuff(CXP_CuentasBancariasTableAdapter.ObtNumeroCuenta_ScalarQuery(rows.Cells("bancoOrdenante").Value), "I", "0", 18) &
                            rows.Cells("moneda").Value & Stuff(rows.Cells("importeSolicitado").Value, "I", "0", 16) &
                                                        Stuff(obtRazonSocial(rows.Cells("razonSocial").Value.ToString.Trim, 30), "D", " ", 30) & "40" & rows.Cells("clabeBeneficiaria").Value.ToString.Substring(0, 3) &
                                                        Stuff(rows.Cells("tipoSolicitud").Value & rows.Cells("folioSolicitud").Value & " " &
                            obtContrato(rows.Cells("noContrato").Value) & " " &
                            tokenReferencia(taVwAutorizaciones.ObtRefernciaPago_ScalarQuery(rows.Cells("idEmpresa").Value, rows.Cells("folioSolicitud").Value), "D", 4, 22 - (obtContrato(rows.Cells("noContrato").Value).Length + 1)).Trim, "D", " ", 30) & "0999999H0                  000000000000.00" & vbNewLine
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
End Class