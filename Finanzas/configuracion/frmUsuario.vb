Public Class frmUsuario

    Dim taDatosUsuarios As New dsSeguridadTableAdapters.USUARIOTableAdapter
    Dim taUsuarios As New dsProductionTableAdapters.CXP_UsuariosTableAdapter
    Dim taEmpresas As New dsProductionTableAdapters.CXP_EmpresasTableAdapter
    Dim Hash As New ClaseHash
    Dim arrayEmpresas() As String
    Dim concatEmpresas As String = ""
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction2.CXP_Perfiles' Puede moverla o quitarla según sea necesario.
        Me.CXP_PerfilesTableAdapter.Fill(Me.DsProduction2.CXP_Perfiles)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction1.Vw_CXP_NombrePerfiles' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Empresas' Puede moverla o quitarla según sea necesario.
        Me.CXP_EmpresasTableAdapter.Fill(Me.DsProduction.CXP_Empresas)
        'TODO: esta línea de código carga datos en la tabla 'DsSeguridad.USUARIO' Puede moverla o quitarla según sea necesario.
        Me.USUARIOTableAdapter.Fill(Me.DsSeguridad.USUARIO)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Usuarios' Puede moverla o quitarla según sea necesario.
        Me.CXP_UsuariosTableAdapter.Fill(Me.DsProduction.CXP_Usuarios)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Usuarios' Puede moverla o quitarla según sea necesario.
        Me.CXP_UsuariosTableAdapter.Fill(Me.DsProduction.CXP_Usuarios)
        'TODO: esta línea de código carga datos en la tabla 'DsSeguridad.USUARIO' Puede moverla o quitarla según sea necesario.
        Me.USUARIOTableAdapter.Fill(Me.DsSeguridad.USUARIO)

        actualiza()
    End Sub

    Private Sub CXP_UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_UsuariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

        Dim contador As Integer = 0
        For Each rows As DataGridViewRow In dgvEmpresas.Rows
            concatEmpresas = concatEmpresas & dgvEmpresas.Item(0, contador).Value & ","
            contador = contador + 1
        Next
        taUsuarios.ActEmpresas_UpdateQuery(concatEmpresas, CXP_UsuariosBindingSource.Current("idUsuario"))
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuarioActual.SelectedIndexChanged

        If Not cmbUsuarioActual.SelectedValue Is Nothing Then
            taDatosUsuarios.ObtDatos_FillBy(DsSeguridad.USUARIO, cmbUsuarioActual.SelectedValue)
            If DsSeguridad.USUARIO.Rows.Count > 0 Then
                For Each rows As dsSeguridad.USUARIORow In DsSeguridad.USUARIO.Rows
                    NombreTextBox.Text = rows.nombrecompleto
                    UsuarioTextBox.Text = rows.id_usuario
                    MailTextBox.Text = rows.correo
                    DepartamentoTextBox.Text = rows.id_depto
                    SucursalTextBox.Text = rows.id_sucursal
                    PwTextBox.Text = rows.password
                Next
            End If
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCambiarPw_Click(sender As Object, e As EventArgs) Handles btnCambiarPw.Click
        Dim NewPWD As String = utilerias.Genera_Pass(8, "", False, True, True, False, False, False)
        NewPWD = InputBox("Dame la nueva Contraseña", "Cambio de Contraseña", NewPWD)
        If NewPWD <> "" Then
            NewPWD = getMd5Hash(NewPWD)
            taUsuarios.PW_UpdateQuery(NewPWD, cmbUsuarioActual.SelectedValue)
            MessageBox.Show("Cambio de contraseña exitoso", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim valor As Integer = cmbEmpresas.SelectedValue
        Dim cont As Integer = 0

        For Each rows As DataGridViewRow In dgvEmpresas.Rows
            If dgvEmpresas.Item(0, cont).Value = valor Then
                MsgBox("Ya se encuentra la empresa actual...", MsgBoxStyle.Critical)
                Exit Sub
            End If
            cont = cont + 1
        Next

        dgvEmpresas.Rows.Add(cmbEmpresas.SelectedValue, cmbEmpresas.Text, "Eliminar")

    End Sub

    Private Sub dgvEmpresas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpresas.CellContentClick
        If e.ColumnIndex = 2 Then
            dgvEmpresas.Rows.Remove(dgvEmpresas.CurrentRow)
        End If
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub UsuarioTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsuarioTextBox.TextChanged


    End Sub

    Public Sub actualiza()
        If UsuarioTextBox.Text <> "" Then
            dgvEmpresas.Rows.Clear()
            arrayEmpresas = taUsuarios.ObtEmpr_ScalarQuery(UsuarioTextBox.Text).ToString.Split(",") 'CXP_UsuariosBindingSource.Current("empresas").ToString.Split(",")
            For i As Integer = 0 To arrayEmpresas.Length - 1
                If arrayEmpresas(i) <> "" Then
                    dgvEmpresas.Rows.Add()
                    dgvEmpresas.Item(0, i).Value = arrayEmpresas(i)
                    dgvEmpresas.Item(1, i).Value = taEmpresas.ObtEmpresa_ScalarQuery(arrayEmpresas(i))
                    dgvEmpresas.Item(2, i).Value = "Eliminar"
                End If
            Next
        End If
    End Sub
End Class