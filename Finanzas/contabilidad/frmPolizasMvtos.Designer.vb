<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPolizasMvtos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPolizasMvtos))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.CXP_PolizaMovimientosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CXP_PolizaMovimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContabilidad = New cuentasPorPagar.dsContabilidad()
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
        Me.CXP_PolizaMovimientosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CXPtipoDeDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXPtipoDocumentoSatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXPcMonedaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_PolizaMovimientosTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_PolizaMovimientosTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager()
        Me.CXP_tipoDeDocumentoTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_tipoDeDocumentoTableAdapter()
        Me.CXP_tipoDocumentoSatTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_tipoDocumentoSatTableAdapter()
        Me.CXP_c_MonedaTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_c_MonedaTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsContabilidad1 = New cuentasPorPagar.dsContabilidad()
        Me.CXPTipoDeSolicitudBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_TipoDeSolicitudTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_TipoDeSolicitudTableAdapter()
        Me.tipoSolicitud = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TipoPolizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FormPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IdPolizaMvtosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CXP_PolizaMovimientosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_PolizaMovimientosBindingNavigator.SuspendLayout()
        CType(Me.CXP_PolizaMovimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPtipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPtipoDocumentoSatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcMonedaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContabilidad1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPTipoDeSolicitudBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(650, 184)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'CXP_PolizaMovimientosBindingNavigator
        '
        Me.CXP_PolizaMovimientosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_PolizaMovimientosBindingNavigator.BindingSource = Me.CXP_PolizaMovimientosBindingSource
        Me.CXP_PolizaMovimientosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_PolizaMovimientosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_PolizaMovimientosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_PolizaMovimientosBindingNavigatorSaveItem})
        Me.CXP_PolizaMovimientosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_PolizaMovimientosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_PolizaMovimientosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_PolizaMovimientosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_PolizaMovimientosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_PolizaMovimientosBindingNavigator.Name = "CXP_PolizaMovimientosBindingNavigator"
        Me.CXP_PolizaMovimientosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_PolizaMovimientosBindingNavigator.Size = New System.Drawing.Size(737, 25)
        Me.CXP_PolizaMovimientosBindingNavigator.TabIndex = 1
        Me.CXP_PolizaMovimientosBindingNavigator.Text = "BindingNavigator1"
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
        'CXP_PolizaMovimientosBindingSource
        '
        Me.CXP_PolizaMovimientosBindingSource.DataMember = "CXP_PolizaMovimientos"
        Me.CXP_PolizaMovimientosBindingSource.DataSource = Me.DsContabilidad
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "dsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CXP_PolizaMovimientosBindingNavigatorSaveItem
        '
        Me.CXP_PolizaMovimientosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_PolizaMovimientosBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_PolizaMovimientosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_PolizaMovimientosBindingNavigatorSaveItem.Name = "CXP_PolizaMovimientosBindingNavigatorSaveItem"
        Me.CXP_PolizaMovimientosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_PolizaMovimientosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipoSolicitud, Me.TipoPolizaDataGridViewTextBoxColumn, Me.FormPagoDataGridViewTextBoxColumn, Me.MonedaDataGridViewTextBoxColumn, Me.IdPolizaMvtosDataGridViewTextBoxColumn, Me.IdEmpresaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CXP_PolizaMovimientosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(713, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'CXPtipoDeDocumentoBindingSource
        '
        Me.CXPtipoDeDocumentoBindingSource.DataMember = "CXP_tipoDeDocumento"
        Me.CXPtipoDeDocumentoBindingSource.DataSource = Me.DsContabilidad
        Me.CXPtipoDeDocumentoBindingSource.Filter = "documentoDe='Egreso'"
        '
        'CXPtipoDocumentoSatBindingSource
        '
        Me.CXPtipoDocumentoSatBindingSource.DataMember = "CXP_tipoDocumentoSat"
        Me.CXPtipoDocumentoSatBindingSource.DataSource = Me.DsContabilidad
        Me.CXPtipoDocumentoSatBindingSource.Filter = "tipo='Egreso'"
        '
        'CXPcMonedaBindingSource
        '
        Me.CXPcMonedaBindingSource.DataMember = "CXP_c_Moneda"
        Me.CXPcMonedaBindingSource.DataSource = Me.DsContabilidad
        '
        'CXP_PolizaMovimientosTableAdapter
        '
        Me.CXP_PolizaMovimientosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EstatusTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PeriodosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PolizaMovimientosTableAdapter = Me.CXP_PolizaMovimientosTableAdapter
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Me.CXP_tipoDeDocumentoTableAdapter
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Me.CXP_tipoDocumentoSatTableAdapter
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_tipoDeDocumentoTableAdapter
        '
        Me.CXP_tipoDeDocumentoTableAdapter.ClearBeforeFill = True
        '
        'CXP_tipoDocumentoSatTableAdapter
        '
        Me.CXP_tipoDocumentoSatTableAdapter.ClearBeforeFill = True
        '
        'CXP_c_MonedaTableAdapter
        '
        Me.CXP_c_MonedaTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idPolizaMvtos"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idPolizaMvtos"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "formPago"
        Me.DataGridViewTextBoxColumn2.HeaderText = "formPago"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "moneda"
        Me.DataGridViewTextBoxColumn3.HeaderText = "moneda"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idEmpresa"
        Me.DataGridViewTextBoxColumn4.HeaderText = "idEmpresa"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tipoSolicitud"
        Me.DataGridViewTextBoxColumn5.HeaderText = "tipoSolicitud"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DsContabilidad1
        '
        Me.DsContabilidad1.DataSetName = "dsContabilidad"
        Me.DsContabilidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXPTipoDeSolicitudBindingSource
        '
        Me.CXPTipoDeSolicitudBindingSource.DataMember = "CXP_TipoDeSolicitud"
        Me.CXPTipoDeSolicitudBindingSource.DataSource = Me.DsContabilidad1
        '
        'CXP_TipoDeSolicitudTableAdapter
        '
        Me.CXP_TipoDeSolicitudTableAdapter.ClearBeforeFill = True
        '
        'tipoSolicitud
        '
        Me.tipoSolicitud.DataPropertyName = "tipoSolicitud"
        Me.tipoSolicitud.DataSource = Me.CXPTipoDeSolicitudBindingSource
        Me.tipoSolicitud.DisplayMember = "tipoSolicitud"
        Me.tipoSolicitud.HeaderText = "Tipo Solicitud"
        Me.tipoSolicitud.Name = "tipoSolicitud"
        Me.tipoSolicitud.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tipoSolicitud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.tipoSolicitud.ValueMember = "idTipoSolicitud"
        '
        'TipoPolizaDataGridViewTextBoxColumn
        '
        Me.TipoPolizaDataGridViewTextBoxColumn.DataPropertyName = "tipoPoliza"
        Me.TipoPolizaDataGridViewTextBoxColumn.DataSource = Me.CXPtipoDeDocumentoBindingSource
        Me.TipoPolizaDataGridViewTextBoxColumn.DisplayMember = "nombre"
        Me.TipoPolizaDataGridViewTextBoxColumn.HeaderText = "Tipo Póliza"
        Me.TipoPolizaDataGridViewTextBoxColumn.Name = "TipoPolizaDataGridViewTextBoxColumn"
        Me.TipoPolizaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TipoPolizaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TipoPolizaDataGridViewTextBoxColumn.ValueMember = "idTipoDeDocumento"
        Me.TipoPolizaDataGridViewTextBoxColumn.Width = 250
        '
        'FormPagoDataGridViewTextBoxColumn
        '
        Me.FormPagoDataGridViewTextBoxColumn.DataPropertyName = "formPago"
        Me.FormPagoDataGridViewTextBoxColumn.DataSource = Me.CXPtipoDocumentoSatBindingSource
        Me.FormPagoDataGridViewTextBoxColumn.DisplayMember = "descripcion"
        Me.FormPagoDataGridViewTextBoxColumn.HeaderText = "Forma Pago"
        Me.FormPagoDataGridViewTextBoxColumn.Name = "FormPagoDataGridViewTextBoxColumn"
        Me.FormPagoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FormPagoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FormPagoDataGridViewTextBoxColumn.ValueMember = "idTipoDocumento"
        Me.FormPagoDataGridViewTextBoxColumn.Width = 250
        '
        'MonedaDataGridViewTextBoxColumn
        '
        Me.MonedaDataGridViewTextBoxColumn.DataPropertyName = "moneda"
        Me.MonedaDataGridViewTextBoxColumn.DataSource = Me.CXPcMonedaBindingSource
        Me.MonedaDataGridViewTextBoxColumn.DisplayMember = "c_Moneda"
        Me.MonedaDataGridViewTextBoxColumn.HeaderText = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.Name = "MonedaDataGridViewTextBoxColumn"
        Me.MonedaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MonedaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MonedaDataGridViewTextBoxColumn.ValueMember = "c_Moneda"
        Me.MonedaDataGridViewTextBoxColumn.Width = 60
        '
        'IdPolizaMvtosDataGridViewTextBoxColumn
        '
        Me.IdPolizaMvtosDataGridViewTextBoxColumn.DataPropertyName = "idPolizaMvtos"
        Me.IdPolizaMvtosDataGridViewTextBoxColumn.HeaderText = "idPolizaMvtos"
        Me.IdPolizaMvtosDataGridViewTextBoxColumn.Name = "IdPolizaMvtosDataGridViewTextBoxColumn"
        Me.IdPolizaMvtosDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPolizaMvtosDataGridViewTextBoxColumn.Visible = False
        '
        'IdEmpresaDataGridViewTextBoxColumn
        '
        Me.IdEmpresaDataGridViewTextBoxColumn.DataPropertyName = "idEmpresa"
        Me.IdEmpresaDataGridViewTextBoxColumn.HeaderText = "idEmpresa"
        Me.IdEmpresaDataGridViewTextBoxColumn.Name = "IdEmpresaDataGridViewTextBoxColumn"
        Me.IdEmpresaDataGridViewTextBoxColumn.Visible = False
        '
        'frmPolizasMvtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 215)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CXP_PolizaMovimientosBindingNavigator)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPolizasMvtos"
        Me.Text = "Pólizas Movimientos"
        CType(Me.CXP_PolizaMovimientosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_PolizaMovimientosBindingNavigator.ResumeLayout(False)
        Me.CXP_PolizaMovimientosBindingNavigator.PerformLayout()
        CType(Me.CXP_PolizaMovimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPtipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPtipoDocumentoSatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcMonedaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContabilidad1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPTipoDeSolicitudBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DsContabilidad As dsContabilidad
    Friend WithEvents CXP_PolizaMovimientosBindingSource As BindingSource
    Friend WithEvents CXP_PolizaMovimientosTableAdapter As dsContabilidadTableAdapters.CXP_PolizaMovimientosTableAdapter
    Friend WithEvents TableAdapterManager As dsContabilidadTableAdapters.TableAdapterManager
    Friend WithEvents CXP_PolizaMovimientosBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_PolizaMovimientosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CXP_tipoDocumentoSatTableAdapter As dsContabilidadTableAdapters.CXP_tipoDocumentoSatTableAdapter
    Friend WithEvents CXPtipoDocumentoSatBindingSource As BindingSource
    Friend WithEvents CXP_tipoDeDocumentoTableAdapter As dsContabilidadTableAdapters.CXP_tipoDeDocumentoTableAdapter
    Friend WithEvents CXPtipoDeDocumentoBindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents CXPcMonedaBindingSource As BindingSource
    Friend WithEvents CXP_c_MonedaTableAdapter As dsContabilidadTableAdapters.CXP_c_MonedaTableAdapter
    Friend WithEvents DsContabilidad1 As dsContabilidad
    Friend WithEvents CXPTipoDeSolicitudBindingSource As BindingSource
    Friend WithEvents CXP_TipoDeSolicitudTableAdapter As dsContabilidadTableAdapters.CXP_TipoDeSolicitudTableAdapter
    Friend WithEvents tipoSolicitud As DataGridViewComboBoxColumn
    Friend WithEvents TipoPolizaDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents FormPagoDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents MonedaDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents IdPolizaMvtosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpresaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
