Public Class frmCuentasConceptos
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim taCuentas As New contpaqTableAdapters.CuentasTableAdapter
        Try
            Me.CXP_ConceptosTableAdapter1.ObtieneCuentas_FillBy(Me.DsHerramientas.CXP_Conceptos, varGlobal_IdEmpresa, taCuentas.ObtieneIdCta_ScalarQuery(mtbCuentas.Text.Trim.Replace("-", "")))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class