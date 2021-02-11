Public Class frmCorreosNotificacionesPago
    Public idProveedor As Integer
    Private Sub CXP_CorreosProveedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_CorreosProveedoresBindingNavigatorSaveItem.Click
        CXP_CorreosProveedoresBindingSource.Current("idProveedor") = idProveedor
        Me.Validate()
        Me.CXP_CorreosProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsHerramientas)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub frmCorreosNotificacionesPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CXP_CorreosProveedoresTableAdapter.Fill(Me.DsHerramientas.CXP_CorreosProveedores, New System.Nullable(Of Decimal)(CType(idProveedor, Decimal)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        DireccionCorreoTextBox.Focus()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class