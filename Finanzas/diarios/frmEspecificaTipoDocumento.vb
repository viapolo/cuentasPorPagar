Public Class frmEspecificaTipoDocumento
    Private Sub frmEspecificaTipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_tipoDeDocumento' Puede moverla o quitarla según sea necesario.
        Me.CXP_tipoDeDocumentoTableAdapter.Fill(Me.DsProduction.CXP_tipoDeDocumento)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim formDiariosFeChild As New frmDiariosFe
        frmDiariosFe.MdiParent = Me.MdiParent
        frmDiariosFe.Show()
    End Sub
End Class