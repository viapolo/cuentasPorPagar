Public Class frmBancos_1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim taBancos_1 As New dsTesoreriaTableAdapters.Vw_CXP_EstadoCuentaTableAdapter
        Dim dtBancos_1 As New dsTesoreria.Vw_CXP_EstadoCuentaDataTable

        taBancos_1.Bancos_1_FillBy(dtBancos_1, varGlobal_IdEmpresa)

        For Each rwBancos_1 As dsTesoreria.Vw_CXP_EstadoCuentaRow In dtBancos_1.Rows
            dgvCuentasBancarias.Rows.Add(rwBancos_1.idCuentaBancaria, rwBancos_1.nombre, rwBancos_1.numeroDeCuenta, rwBancos_1.cuentaClabe, rwBancos_1.idMoneda, rwBancos_1.importeSolicitado)
        Next

    End Sub
End Class