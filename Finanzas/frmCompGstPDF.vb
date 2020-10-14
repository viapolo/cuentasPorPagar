Public Class frmCompGstPDF
    Private Sub frmCompGstPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Vw_CXP_MisComprobacionesTableAdapter.Fill(Me.DsProduction.Vw_CXP_MisComprobaciones, varGlobal_IdEmpresa)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            'System.Diagnostics.Process.Start("\\server-raid2\TmpFinagil\CXP\" & varGlobal_IdEmpresa & "-" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & ".pdf")

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
        If e.ColumnIndex = 6 Then
            System.Diagnostics.Process.Start(My.Settings.fileNas & "GTS\" & varGlobal_IdEmpresa & "-" & DataGridView1.Rows(e.RowIndex).Cells(6).Value & ".pdf")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            VwCXPMisComprobacionesBindingSource.Filter = "idFolioSolicitud = '" & txtBuscar.Text.Trim & "'"
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub
End Class