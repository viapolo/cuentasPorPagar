<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeridos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPeridos))
        Me.CXP_PeriodosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.CXP_PeriodosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CXP_PeriodosDataGridView = New System.Windows.Forms.DataGridView()
        Me.CXP_PeriodosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContabilidad = New cuentasPorPagar.dsContabilidad()
        Me.CXP_PeriodosTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_PeriodosTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager()
        Me.CXPEstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_EstatusTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_EstatusTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.CXP_PeriodosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_PeriodosBindingNavigator.SuspendLayout()
        CType(Me.CXP_PeriodosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_PeriodosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPEstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CXP_PeriodosBindingNavigator
        '
        Me.CXP_PeriodosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_PeriodosBindingNavigator.BindingSource = Me.CXP_PeriodosBindingSource
        Me.CXP_PeriodosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_PeriodosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_PeriodosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_PeriodosBindingNavigatorSaveItem})
        Me.CXP_PeriodosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_PeriodosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_PeriodosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_PeriodosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_PeriodosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_PeriodosBindingNavigator.Name = "CXP_PeriodosBindingNavigator"
        Me.CXP_PeriodosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_PeriodosBindingNavigator.Size = New System.Drawing.Size(910, 25)
        Me.CXP_PeriodosBindingNavigator.TabIndex = 0
        Me.CXP_PeriodosBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
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
        'CXP_PeriodosBindingNavigatorSaveItem
        '
        Me.CXP_PeriodosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_PeriodosBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_PeriodosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_PeriodosBindingNavigatorSaveItem.Name = "CXP_PeriodosBindingNavigatorSaveItem"
        Me.CXP_PeriodosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_PeriodosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CXP_PeriodosDataGridView
        '
        Me.CXP_PeriodosDataGridView.AllowUserToAddRows = False
        Me.CXP_PeriodosDataGridView.AllowUserToDeleteRows = False
        Me.CXP_PeriodosDataGridView.AutoGenerateColumns = False
        Me.CXP_PeriodosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CXP_PeriodosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CXP_PeriodosDataGridView.DataSource = Me.CXP_PeriodosBindingSource
        Me.CXP_PeriodosDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.CXP_PeriodosDataGridView.Name = "CXP_PeriodosDataGridView"
        Me.CXP_PeriodosDataGridView.Size = New System.Drawing.Size(886, 382)
        Me.CXP_PeriodosDataGridView.TabIndex = 1
        '
        'CXP_PeriodosBindingSource
        '
        Me.CXP_PeriodosBindingSource.DataMember = "CXP_Periodos"
        Me.CXP_PeriodosBindingSource.DataSource = Me.DsContabilidad
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "dsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_PeriodosTableAdapter
        '
        Me.CXP_PeriodosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CXP_EstatusTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PeriodosTableAdapter = Me.CXP_PeriodosTableAdapter
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXPEstatusBindingSource
        '
        Me.CXPEstatusBindingSource.DataMember = "CXP_Estatus"
        Me.CXPEstatusBindingSource.DataSource = Me.DsContabilidad
        Me.CXPEstatusBindingSource.Filter = "grupoEstatus='EJERCICIOS'"
        '
        'CXP_EstatusTableAdapter
        '
        Me.CXP_EstatusTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idPeriodo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idPeriodo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "inicioPeriodo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Inicio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "finPeriodo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fin"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "estatus"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.CXPEstatusBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "descripcion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "idEstatus"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ejercicio"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ejercicio"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idEmpresa"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idEmpresa"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(823, 416)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmPeridos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CXP_PeriodosDataGridView)
        Me.Controls.Add(Me.CXP_PeriodosBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPeridos"
        Me.Text = "frmPeridos"
        CType(Me.CXP_PeriodosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_PeriodosBindingNavigator.ResumeLayout(False)
        Me.CXP_PeriodosBindingNavigator.PerformLayout()
        CType(Me.CXP_PeriodosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_PeriodosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPEstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsContabilidad As dsContabilidad
    Friend WithEvents CXP_PeriodosBindingSource As BindingSource
    Friend WithEvents CXP_PeriodosTableAdapter As dsContabilidadTableAdapters.CXP_PeriodosTableAdapter
    Friend WithEvents TableAdapterManager As dsContabilidadTableAdapters.TableAdapterManager
    Friend WithEvents CXP_PeriodosBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_PeriodosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CXP_PeriodosDataGridView As DataGridView
    Friend WithEvents CXPEstatusBindingSource As BindingSource
    Friend WithEvents CXP_EstatusTableAdapter As dsContabilidadTableAdapters.CXP_EstatusTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
End Class
