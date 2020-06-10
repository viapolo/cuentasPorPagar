Public Class frmTesSolicitudesDePago
    Private Sub frmTesSolicitudesDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsTesoreria.Vw_CXP_SugerenciasPago' Puede moverla o quitarla según sea necesario.
        Me.Vw_CXP_SugerenciasPagoTableAdapter.SugPagos_FillBy(Me.DsTesoreria.Vw_CXP_SugerenciasPago, varGlobal_IdEmpresa)

        Try
            Me.CXP_CuentasBancariasTableAdapter.Fill(Me.DsProduction.CXP_CuentasBancarias, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa, Decimal)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class