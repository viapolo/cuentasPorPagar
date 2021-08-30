Public Class frmCatalogoInversiones
    Private Sub CXP_CuentasInversionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_CuentasInversionesBindingNavigatorSaveItem.Click
        Me.CXP_CuentasInversionesBindingSource.Current("idEmpresa") = varGlobal_IdEmpresa
        Me.CXP_CuentasInversionesBindingSource.Current("tipoFira") = cmbTipoFira.SelectedText
        Me.Validate()
        Me.CXP_CuentasInversionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsContabilidad)

    End Sub

    Private Sub frmCatalogoInversiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsConfiguracion.CXP_CuentasBancariasProv' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasBancariasProvTableAdapter.Fill(Me.DsConfiguracion.CXP_CuentasBancariasProv)
        Try
            If varGlobal_IdEmpresa = "24" Then
                CuentasTableAdapter.Connection.ConnectionString = My.Settings.csContpaqArfin
            Else
                CuentasTableAdapter.Connection.ConnectionString = My.Settings.csContpaqFinagil
            End If

            Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)
            Me.CXPCuentasBancariasProvBindingSource.Filter = "idProveedor=9"
            Me.CXP_CuentasBancariasTableAdapter.Fill(Me.DsContabilidad.CXP_CuentasBancarias, varGlobal_IdEmpresa)
            Me.CXP_CuentasInversionesTableAdapter.Fill(Me.DsContabilidad.CXP_CuentasInversiones, varGlobal_IdEmpresa)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        cmbTipoFira.Text = "NAPL"
        mensajesEmergentes()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub mensajesEmergentes()
        'Me.tltTipoFira.ToolTipTitle = "*"
        tltTipoFira.SetToolTip(Me.cmbTipoFira, "NAPL=No aplica" & vbNewLine & "FIRA=Bancomer Fira" & vbNewLine & "GLIQ=Garantía Líquida")
    End Sub
End Class