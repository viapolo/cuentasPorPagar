Public Class frmGeneraPdfExpediente
    Private Sub frmGeneraPdfExpediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim taUsuarios As New dsSeguridadTableAdapters.USUARIOTableAdapter
        Dim taProveedores As New dsProductionTableAdapters.CXP_ProveedoresTableAdapter
        Dim tipoPersona As String = ""

        If taUsuarios.ExisteRfc_ScalarQuery(txtRfc.Text.Trim) = "NE" Or IsNothing(taUsuarios.ExisteRfc_ScalarQuery(txtRfc.Text.Trim)) Then
            If taProveedores.ObtClientProv_ScalarQuery(txtRfc.Text.Trim) = False Then
                If txtRfc.Text.Trim.Length = 12 Then
                    tipoPersona = "M"
                    Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "M")
                ElseIf txtRfc.Text.Trim.Length = 13 Then
                    If txtRfc.Text.Trim = "XAXX010101000" Then
                        tipoPersona = "C"
                        Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "C")
                    Else
                        tipoPersona = "F"
                        Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "F")
                    End If

                End If
            ElseIf txtRfc.Text.Trim = "XAXX010101000" Then
                tipoPersona = "C"
                Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "C")
            Else
                tipoPersona = "C"
                Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "C")
            End If
        Else
            tipoPersona = "E"
            Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "E")
        End If

        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Proveedores' Puede moverla o quitarla según sea necesario.
        Me.CXP_ProveedoresTableAdapter.Fill(Me.DsProduction.CXP_Proveedores)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CXPProveedoresBindingSource.Filter = "razonSocial like '%" & txtBuscar.Text.Trim & "%'"
    End Sub

    Private Sub txtRfc_TextChanged(sender As Object, e As EventArgs) Handles txtRfc.TextChanged
        Dim taUsuarios As New dsSeguridadTableAdapters.USUARIOTableAdapter
        Dim taProveedores As New dsProductionTableAdapters.CXP_ProveedoresTableAdapter
        Dim tipoPersona As String = ""
        Dim cont As Integer = 0

        If taUsuarios.ExisteRfc_ScalarQuery(txtRfc.Text.Trim) = "NE" Or IsNothing(taUsuarios.ExisteRfc_ScalarQuery(txtRfc.Text.Trim)) Then
            If taProveedores.ObtClientProv_ScalarQuery(txtRfc.Text.Trim) = False Or IsNothing(taProveedores.ObtClientProv_ScalarQuery(txtRfc.Text.Trim)) Then
                If txtRfc.Text.Trim.Length = 12 Then
                    tipoPersona = "M"
                    Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "M")
                ElseIf txtRfc.Text.Trim.Length = 13 Then
                    If txtRfc.Text.Trim = "XAXX010101000" Then
                        tipoPersona = "C"
                        Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "C")
                    Else
                        tipoPersona = "F"
                        Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "F")
                    End If
                End If
            ElseIf txtRfc.Text.Trim = "XAXX010101000" Then
                tipoPersona = "C"
                Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "C")
            Else
                tipoPersona = "C"
                Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "C")
            End If
        Else
            tipoPersona = "E"
            Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "E")
        End If

        For Each row As DataGridViewRow In dgvDocumentacion.Rows
            dgvDocumentacion.Item("generaPdf", cont).Value = "Generar PDF"
            cont += 1
        Next

    End Sub

    Private Sub dgvDocumentacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocumentacion.CellContentClick
        If e.ColumnIndex = 4 Then
            frmGeneraPdfExpedienteView.var_autorizante = varGlobal_NombreCompletoUsuario
            frmGeneraPdfExpedienteView.var_documento = dgvDocumentacion.Item(3, e.RowIndex).Value
            frmGeneraPdfExpedienteView.var_proveedor = CXPProveedoresBindingSource.Current("razonSocial")
            frmGeneraPdfExpedienteView.Show()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProveedor.SelectedIndexChanged
        Dim taUsuarios As New dsSeguridadTableAdapters.USUARIOTableAdapter
        Dim taProveedores As New dsProductionTableAdapters.CXP_ProveedoresTableAdapter
        Dim tipoPersona As String = ""
        Dim cont As Integer = 0

        If taUsuarios.ExisteRfc_ScalarQuery(txtRfc.Text.Trim) = "NE" Or IsNothing(taUsuarios.ExisteRfc_ScalarQuery(txtRfc.Text.Trim)) Then
            If taProveedores.ObtClientProv_ScalarQuery(txtRfc.Text.Trim) = False Then
                If txtRfc.Text.Trim.Length = 12 Then
                    tipoPersona = "M"
                    Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "M")
                ElseIf txtRfc.Text.Trim.Length = 13 Then
                    If txtRfc.Text.Trim = "XAXX010101000" Then
                        tipoPersona = "C"
                        Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "C")
                    Else
                        tipoPersona = "F"
                        Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "F")
                    End If
                End If
            ElseIf txtRfc.Text.Trim = "XAXX010101000" Then
                tipoPersona = "C"
                Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "C")
            Else
                tipoPersona = "C"
                Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "C")
            End If
        Else
            tipoPersona = "E"
            Me.CXP_DocumentacionProvTableAdapter.TipoPersona_FillBy(Me.DsProduction.CXP_DocumentacionProv, "E")
        End If

        For Each row As DataGridViewRow In dgvDocumentacion.Rows
            dgvDocumentacion.Item("generaPdf", cont).Value = "Generar PDF"
            cont += 1
        Next
    End Sub
End Class