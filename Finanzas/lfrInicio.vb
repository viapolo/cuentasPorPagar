Public Class lfrInicio

    Dim Hash As New ClaseHash
    Dim taUsuarios As New dsProductionTableAdapters.CXP_UsuariosTableAdapter
    Dim taEmpresas As New dsProductionTableAdapters.CXP_EmpresasTableAdapter
    Dim arrayEmpresas() As String
    Dim t As New dsProduction.CXP_UsuariosDataTable
    Dim dtUsuarios As New DataTable
    Dim rowUsuarios As DataRow
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        taUsuarios.ObtEmpresas_FillBy(t, UsernameTextBox.Text)

        If t.Rows.Count > 0 Then
            rowUsuarios = t.Rows(0)
            If CBool(rowUsuarios.Item("activo")) = True Then
                If (UsernameTextBox.Text = rowUsuarios.Item("usuario")) And (Hash.verifyMd5Hash(PasswordTextBox.Text, rowUsuarios("pw").ToString)) Then
                    Me.Hide()
                    Dim f As New mdicuentasPorPagar
                    f.varGlUser = rowUsuarios.Item("usuario")
                    f.varGlIdUser = rowUsuarios.Item("idUsuario")
                    f.varGlPerfil = rowUsuarios.Item("perfil")
                    f.varGlEmpresa = cmbEmpresa.SelectedValue
                    f.ShowDialog()
                Else
                    MsgBox("La contraseña son incorrecta...", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub UsernameTextBox_LostFocus(sender As Object, e As EventArgs) Handles UsernameTextBox.LostFocus
        If UsernameTextBox.Text <> "" Then
            taUsuarios.ObtEmpresas_FillBy(t, UsernameTextBox.Text)
            If t.Rows.Count > 0 Then
                rowUsuarios = t.Rows(0)
                arrayEmpresas = rowUsuarios.Item("empresas").Split(",")
                CXPEmpresasBindingSource.Filter = "idEmpresas IN (" & rowUsuarios.Item("empresas").ToString & ")"
            Else
                MsgBox("El usuario no existe...", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub lfrInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CXP_EmpresasTableAdapter.Fill(Me.DsProduction.CXP_Empresas)
    End Sub
End Class
