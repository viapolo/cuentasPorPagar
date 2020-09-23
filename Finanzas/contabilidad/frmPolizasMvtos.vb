Public Class frmPolizasMvtos

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmPolizasMvtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsContabilidad1.CXP_TipoDeSolicitud' Puede moverla o quitarla según sea necesario.
        Me.CXP_TipoDeSolicitudTableAdapter.Fill(Me.DsContabilidad1.CXP_TipoDeSolicitud)

        'TODO: esta línea de código carga datos en la tabla 'DsContabilidad.CXP_c_Moneda' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_MonedaTableAdapter.Fill(Me.DsContabilidad.CXP_c_Moneda)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_c_Moneda' Puede moverla o quitarla según sea necesario.
        'Me.CXP_c_MonedaTableAdapter.Fill(Me.DsProduction.CXP_c_Moneda)
        Me.CXP_tipoDeDocumentoTableAdapter.Fill(Me.DsContabilidad.CXP_tipoDeDocumento, varGlobal_IdEmpresa)
        Me.CXP_tipoDocumentoSatTableAdapter.Fill(Me.DsContabilidad.CXP_tipoDocumentoSat, varGlobal_IdEmpresa)
        Try
            Me.CXP_PolizaMovimientosTableAdapter.Fill(Me.DsContabilidad.CXP_PolizaMovimientos, New System.Nullable(Of Decimal)(CType(varGlobal_IdEmpresa.ToString, Decimal)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CXP_PolizaMovimientosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CXP_PolizaMovimientosBindingNavigatorSaveItem.Click
        Me.CXP_PolizaMovimientosBindingSource.Current("idEmpresa") = varGlobal_IdEmpresa
        Me.Validate()
        Me.CXP_PolizaMovimientosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsContabilidad)

    End Sub


End Class