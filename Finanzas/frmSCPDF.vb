Public Class frmSCPDF
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            'System.Diagnostics.Process.Start("\\server-nas\TmpFinagil\CXP\" & varGlobal_IdEmpresa & "-" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & ".pdf")

            Dim mdiFrmDocumentosAdjuntos As New frmDocumentosAdjuntos
            Dim mdiSolicitudesPago As New mdicuentasPorPagar
            Me.Enabled = False
            mdiSolicitudesPago = MdiParent
            mdiFrmDocumentosAdjuntos.MdiParent = mdiSolicitudesPago
            Me.Cursor = Cursors.WaitCursor
            mdiFrmDocumentosAdjuntos.idSolPago = DataGridView1.Item(0, e.RowIndex).Value
            mdiFrmDocumentosAdjuntos.Show()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub frmSCPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Vw_CXP_MisSolicitudesSCTableAdapter.Fill(Me.DsProduction.Vw_CXP_MisSolicitudesSC, varGlobal_IdEmpresa)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            VwCXPMisSolicitudesSCBindingSource.Filter = "folioSolicitud = '" & txtBuscar.Text.Trim & "'"
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub
End Class