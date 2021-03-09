Public Class frmDetPolizasEgresos
    Public folioTipoDocumento As Integer
    Public folioSolicitud As Integer
    Public fecha As Date

    Private Sub CXP_RegContBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_RegContBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_RegContBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsTesoreria)

    End Sub

    Private Sub frmDetPolizasEgresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If varGlobal_IdEmpresa = "24" Then
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctCONEARFIN;Persist Security Info=True;User ID=finagil;Password=finagil"
            Else
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctFINAGILCONEFINAGIL2015;Persist Security Info=True;User ID=finagil;Password=finagil"
            End If
            Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error en conexión...")
        End Try
        'TODO: esta línea de código carga datos en la tabla 'Contpaq.Cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)
        'TODO: esta línea de código carga datos en la tabla 'DsTesoreria.CXP_RegCont' Puede moverla o quitarla según sea necesario.
        Me.CXP_RegContTableAdapter.DetalleRegContable_FillBy(Me.DsTesoreria.CXP_RegCont, folioTipoDocumento, varGlobal_IdEmpresa, folioSolicitud, fecha)


        actualizarGrid()
    End Sub

    Private Sub frmDetPolizasEgresos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmPolizasEgresos.Enabled = True
    End Sub

    Private Sub frmDetPolizasEgresos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPolizasEgresos.Enabled = True
    End Sub

    Private Sub actualizarGrid()
        Dim contador As Integer = 0
        Dim dtCuentas As New contpaq.CuentasDataTable
        Dim rwCuentas As contpaq.CuentasRow

        For Each rows As DataGridViewRow In CXP_RegContDataGridView.Rows
            CuentasTableAdapter.DatosCtas_FillBy(dtCuentas, CXP_RegContDataGridView.Item("idCuenta", contador).Value)
            If dtCuentas.Rows.Count > 0 Then
                rwCuentas = dtCuentas.Rows(0)
                CXP_RegContDataGridView.Item("descCuenta", contador).Value = rwCuentas.nCuenta
            End If
            contador += 1
        Next
        Me.Update()
        Me.Refresh()
    End Sub
End Class