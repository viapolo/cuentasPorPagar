<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContabilizaComprobaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContabilizaComprobaciones))
        Me.DsContabilidad = New cuentasPorPagar.dsContabilidad()
        Me.Vw_CXP_MisComprobacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_CXP_MisComprobacionesTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.Vw_CXP_MisComprobacionesTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager()
        Me.Vw_CXP_MisComprobacionesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Vw_CXP_MisComprobacionesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Vw_CXP_MisComprobacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_CXP_MisComprobacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_CXP_MisComprobacionesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vw_CXP_MisComprobacionesBindingNavigator.SuspendLayout()
        CType(Me.Vw_CXP_MisComprobacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "dsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_CXP_MisComprobacionesBindingSource
        '
        Me.Vw_CXP_MisComprobacionesBindingSource.DataMember = "Vw_CXP_MisComprobaciones"
        Me.Vw_CXP_MisComprobacionesBindingSource.DataSource = Me.DsContabilidad
        '
        'Vw_CXP_MisComprobacionesTableAdapter
        '
        Me.Vw_CXP_MisComprobacionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EstatusTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PeriodosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PolizaMovimientosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoDeSolicitudTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Vw_CXP_MisComprobacionesBindingNavigator
        '
        Me.Vw_CXP_MisComprobacionesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Vw_CXP_MisComprobacionesBindingNavigator.BindingSource = Me.Vw_CXP_MisComprobacionesBindingSource
        Me.Vw_CXP_MisComprobacionesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Vw_CXP_MisComprobacionesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Vw_CXP_MisComprobacionesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Vw_CXP_MisComprobacionesBindingNavigatorSaveItem})
        Me.Vw_CXP_MisComprobacionesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Vw_CXP_MisComprobacionesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Vw_CXP_MisComprobacionesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Vw_CXP_MisComprobacionesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Vw_CXP_MisComprobacionesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Vw_CXP_MisComprobacionesBindingNavigator.Name = "Vw_CXP_MisComprobacionesBindingNavigator"
        Me.Vw_CXP_MisComprobacionesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Vw_CXP_MisComprobacionesBindingNavigator.Size = New System.Drawing.Size(1084, 25)
        Me.Vw_CXP_MisComprobacionesBindingNavigator.TabIndex = 0
        Me.Vw_CXP_MisComprobacionesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
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
        'Vw_CXP_MisComprobacionesBindingNavigatorSaveItem
        '
        Me.Vw_CXP_MisComprobacionesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Vw_CXP_MisComprobacionesBindingNavigatorSaveItem.Enabled = False
        Me.Vw_CXP_MisComprobacionesBindingNavigatorSaveItem.Image = CType(resources.GetObject("Vw_CXP_MisComprobacionesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Vw_CXP_MisComprobacionesBindingNavigatorSaveItem.Name = "Vw_CXP_MisComprobacionesBindingNavigatorSaveItem"
        Me.Vw_CXP_MisComprobacionesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Vw_CXP_MisComprobacionesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Vw_CXP_MisComprobacionesDataGridView
        '
        Me.Vw_CXP_MisComprobacionesDataGridView.AllowUserToAddRows = False
        Me.Vw_CXP_MisComprobacionesDataGridView.AllowUserToDeleteRows = False
        Me.Vw_CXP_MisComprobacionesDataGridView.AllowUserToOrderColumns = True
        Me.Vw_CXP_MisComprobacionesDataGridView.AutoGenerateColumns = False
        Me.Vw_CXP_MisComprobacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vw_CXP_MisComprobacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn11})
        Me.Vw_CXP_MisComprobacionesDataGridView.DataSource = Me.Vw_CXP_MisComprobacionesBindingSource
        Me.Vw_CXP_MisComprobacionesDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.Vw_CXP_MisComprobacionesDataGridView.Name = "Vw_CXP_MisComprobacionesDataGridView"
        Me.Vw_CXP_MisComprobacionesDataGridView.ReadOnly = True
        Me.Vw_CXP_MisComprobacionesDataGridView.Size = New System.Drawing.Size(1060, 334)
        Me.Vw_CXP_MisComprobacionesDataGridView.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(997, 368)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idFolioSolicitud"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fol Sol"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 64
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "folioComprobacion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fol Comp"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 76
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "saldoSolicitud"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sal X Comp"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 87
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "impDepositado"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Imp Dep"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "estatus"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 67
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "decripcion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 88
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "razonSocial"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Beneficiario"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 300
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "usuario"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Solicitó"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 66
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idEmpresa"
        Me.DataGridViewTextBoxColumn8.HeaderText = "idEmpresa"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "totalPagado"
        Me.DataGridViewTextBoxColumn9.HeaderText = "totalPagado"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "fechaComprobacion"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Fech Comp"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'frmContabilizaComprobaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 401)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Vw_CXP_MisComprobacionesDataGridView)
        Me.Controls.Add(Me.Vw_CXP_MisComprobacionesBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmContabilizaComprobaciones"
        Me.Text = "Evento Contable Comprobaciones"
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_CXP_MisComprobacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_CXP_MisComprobacionesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vw_CXP_MisComprobacionesBindingNavigator.ResumeLayout(False)
        Me.Vw_CXP_MisComprobacionesBindingNavigator.PerformLayout()
        CType(Me.Vw_CXP_MisComprobacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsContabilidad As dsContabilidad
    Friend WithEvents Vw_CXP_MisComprobacionesBindingSource As BindingSource
    Friend WithEvents Vw_CXP_MisComprobacionesTableAdapter As dsContabilidadTableAdapters.Vw_CXP_MisComprobacionesTableAdapter
    Friend WithEvents TableAdapterManager As dsContabilidadTableAdapters.TableAdapterManager
    Friend WithEvents Vw_CXP_MisComprobacionesBindingNavigator As BindingNavigator
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
    Friend WithEvents Vw_CXP_MisComprobacionesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Vw_CXP_MisComprobacionesDataGridView As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
End Class
