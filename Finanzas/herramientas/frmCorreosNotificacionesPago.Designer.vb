<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorreosNotificacionesPago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DireccionCorreoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCorreosNotificacionesPago))
        Me.DsHerramientas = New cuentasPorPagar.dsHerramientas()
        Me.CXP_CorreosProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_CorreosProveedoresTableAdapter = New cuentasPorPagar.dsHerramientasTableAdapters.CXP_CorreosProveedoresTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsHerramientasTableAdapters.TableAdapterManager()
        Me.CXP_CorreosProveedoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CXP_CorreosProveedoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CXP_CorreosProveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionCorreoTextBox = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        DireccionCorreoLabel = New System.Windows.Forms.Label()
        CType(Me.DsHerramientas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_CorreosProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_CorreosProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_CorreosProveedoresBindingNavigator.SuspendLayout()
        CType(Me.CXP_CorreosProveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DireccionCorreoLabel
        '
        DireccionCorreoLabel.AutoSize = True
        DireccionCorreoLabel.Location = New System.Drawing.Point(14, 31)
        DireccionCorreoLabel.Name = "DireccionCorreoLabel"
        DireccionCorreoLabel.Size = New System.Drawing.Size(103, 13)
        DireccionCorreoLabel.TabIndex = 2
        DireccionCorreoLabel.Text = "Dirección de correo:"
        '
        'DsHerramientas
        '
        Me.DsHerramientas.DataSetName = "dsHerramientas"
        Me.DsHerramientas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_CorreosProveedoresBindingSource
        '
        Me.CXP_CorreosProveedoresBindingSource.DataMember = "CXP_CorreosProveedores"
        Me.CXP_CorreosProveedoresBindingSource.DataSource = Me.DsHerramientas
        '
        'CXP_CorreosProveedoresTableAdapter
        '
        Me.CXP_CorreosProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CXP_BancosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CorreosProveedoresTableAdapter = Me.CXP_CorreosProveedoresTableAdapter
        Me.TableAdapterManager.CXP_CuentasBancariasProvTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsHerramientasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_CorreosProveedoresBindingNavigator
        '
        Me.CXP_CorreosProveedoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_CorreosProveedoresBindingNavigator.BindingSource = Me.CXP_CorreosProveedoresBindingSource
        Me.CXP_CorreosProveedoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_CorreosProveedoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_CorreosProveedoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_CorreosProveedoresBindingNavigatorSaveItem})
        Me.CXP_CorreosProveedoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_CorreosProveedoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_CorreosProveedoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_CorreosProveedoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_CorreosProveedoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_CorreosProveedoresBindingNavigator.Name = "CXP_CorreosProveedoresBindingNavigator"
        Me.CXP_CorreosProveedoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_CorreosProveedoresBindingNavigator.Size = New System.Drawing.Size(642, 25)
        Me.CXP_CorreosProveedoresBindingNavigator.TabIndex = 0
        Me.CXP_CorreosProveedoresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CXP_CorreosProveedoresBindingNavigatorSaveItem
        '
        Me.CXP_CorreosProveedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_CorreosProveedoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_CorreosProveedoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_CorreosProveedoresBindingNavigatorSaveItem.Name = "CXP_CorreosProveedoresBindingNavigatorSaveItem"
        Me.CXP_CorreosProveedoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_CorreosProveedoresBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CXP_CorreosProveedoresDataGridView
        '
        Me.CXP_CorreosProveedoresDataGridView.AllowUserToAddRows = False
        Me.CXP_CorreosProveedoresDataGridView.AllowUserToDeleteRows = False
        Me.CXP_CorreosProveedoresDataGridView.AllowUserToOrderColumns = True
        Me.CXP_CorreosProveedoresDataGridView.AutoGenerateColumns = False
        Me.CXP_CorreosProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CXP_CorreosProveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.CXP_CorreosProveedoresDataGridView.DataSource = Me.CXP_CorreosProveedoresBindingSource
        Me.CXP_CorreosProveedoresDataGridView.Location = New System.Drawing.Point(12, 64)
        Me.CXP_CorreosProveedoresDataGridView.Name = "CXP_CorreosProveedoresDataGridView"
        Me.CXP_CorreosProveedoresDataGridView.ReadOnly = True
        Me.CXP_CorreosProveedoresDataGridView.Size = New System.Drawing.Size(610, 195)
        Me.CXP_CorreosProveedoresDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idCorreo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idCorreo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idProveedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idProveedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccionCorreo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 400
        '
        'DireccionCorreoTextBox
        '
        Me.DireccionCorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_CorreosProveedoresBindingSource, "direccionCorreo", True))
        Me.DireccionCorreoTextBox.Location = New System.Drawing.Point(123, 28)
        Me.DireccionCorreoTextBox.Name = "DireccionCorreoTextBox"
        Me.DireccionCorreoTextBox.Size = New System.Drawing.Size(499, 20)
        Me.DireccionCorreoTextBox.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(547, 280)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmCorreosNotificacionesPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 315)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(DireccionCorreoLabel)
        Me.Controls.Add(Me.DireccionCorreoTextBox)
        Me.Controls.Add(Me.CXP_CorreosProveedoresDataGridView)
        Me.Controls.Add(Me.CXP_CorreosProveedoresBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCorreosNotificacionesPago"
        Me.Text = "Direcciones de correo"
        CType(Me.DsHerramientas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_CorreosProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_CorreosProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_CorreosProveedoresBindingNavigator.ResumeLayout(False)
        Me.CXP_CorreosProveedoresBindingNavigator.PerformLayout()
        CType(Me.CXP_CorreosProveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsHerramientas As dsHerramientas
    Friend WithEvents CXP_CorreosProveedoresBindingSource As BindingSource
    Friend WithEvents CXP_CorreosProveedoresTableAdapter As dsHerramientasTableAdapters.CXP_CorreosProveedoresTableAdapter
    Friend WithEvents TableAdapterManager As dsHerramientasTableAdapters.TableAdapterManager
    Friend WithEvents CXP_CorreosProveedoresBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CXP_CorreosProveedoresBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CXP_CorreosProveedoresDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DireccionCorreoTextBox As TextBox
    Friend WithEvents btnSalir As Button
End Class
