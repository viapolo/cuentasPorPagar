Public Class frmCCPDF
    Private Sub frmCCPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.Vw_CXP_MisSolicitudes' Puede moverla o quitarla según sea necesario.
        Me.Vw_CXP_MisSolicitudesTableAdapter.Fill(Me.DsProduction.Vw_CXP_MisSolicitudes, varGlobal_IdEmpresa)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            'System.IO.File.Copy(My.Settings.fileNas & "CXP\" & varGlobal_IdEmpresa & "-" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & ".pdf", "C:\Files\" & varGlobal_IdEmpresa & "-" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & ".pdf", True)
            'System.Diagnostics.Process.Start("C:\Files\" & varGlobal_IdEmpresa & "-" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & ".pdf")

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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If IsNumeric(txtBuscar.Text) Then
                VwCXPMisSolicitudesBindingSource.Filter = "folioSolicitud = '" & txtBuscar.Text.Trim & "'"
            Else
                VwCXPMisSolicitudesBindingSource.Filter = "razonSocial like '%" & txtBuscar.Text.Trim & "%'"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        End Try
    End Sub
End Class