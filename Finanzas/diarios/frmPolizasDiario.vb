Public Class frmPolizasDiario
    Private Sub frmPolizasDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.Vw_CXP_RegContable' Puede moverla o quitarla según sea necesario.
        Me.Vw_CXP_RegContableTableAdapter.Fill(Me.DsProduction.Vw_CXP_RegContable, varGlobal_IdEmpresa)
    End Sub
End Class