<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCuentasBancarias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuentasBancarias))
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_CuentasBancariasProvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_CuentasBancariasProvTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_CuentasBancariasProvTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_BancosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_BancosTableAdapter()
        Me.CXP_c_MonedaTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_MonedaTableAdapter()
        Me.CXP_CuentasBancariasProvBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CXP_CuentasBancariasProvBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CXP_CuentasBancariasProvDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CXPBancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CXPcMonedaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.verPdf = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.estatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CXPEstatus2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.autorizar = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.idCuentas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CXP_Estatus2TableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_Estatus2TableAdapter()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_CuentasBancariasProvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_CuentasBancariasProvBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_CuentasBancariasProvBindingNavigator.SuspendLayout()
        CType(Me.CXP_CuentasBancariasProvDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPBancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcMonedaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPEstatus2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_CuentasBancariasProvBindingSource
        '
        Me.CXP_CuentasBancariasProvBindingSource.DataMember = "CXP_CuentasBancariasProv"
        Me.CXP_CuentasBancariasProvBindingSource.DataSource = Me.DsProduction
        '
        'CXP_CuentasBancariasProvTableAdapter
        '
        Me.CXP_CuentasBancariasProvTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CFDI_Estado_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_AutorizacionesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_BancosTableAdapter = Me.CXP_BancosTableAdapter
        Me.TableAdapterManager.CXP_c_CodigoPostalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_EstadoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Me.CXP_c_MonedaTableAdapter
        Me.TableAdapterManager.CXP_c_PaisTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_RegimenFiscalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CodigoAgrupadorTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ComprobGtosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasProvTableAdapter = Me.CXP_CuentasBancariasProvTableAdapter
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DocumentacionProvTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_Estatus1TableAdapter = Nothing
        Me.TableAdapterManager.CXP_Estatus2TableAdapter = Nothing
        Me.TableAdapterManager.CXP_EstatusTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpConTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PagosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresArchTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_RegContTableAdapter = Nothing
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoConceptoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoCuentaContableTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoGastoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdi2TableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdiTableAdapter = Nothing
        Me.TableAdapterManager.GEN_Correos_SistemaFinagilTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_BancosTableAdapter
        '
        Me.CXP_BancosTableAdapter.ClearBeforeFill = True
        '
        'CXP_c_MonedaTableAdapter
        '
        Me.CXP_c_MonedaTableAdapter.ClearBeforeFill = True
        '
        'CXP_CuentasBancariasProvBindingNavigator
        '
        Me.CXP_CuentasBancariasProvBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_CuentasBancariasProvBindingNavigator.BindingSource = Me.CXP_CuentasBancariasProvBindingSource
        Me.CXP_CuentasBancariasProvBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_CuentasBancariasProvBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_CuentasBancariasProvBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_CuentasBancariasProvBindingNavigatorSaveItem})
        Me.CXP_CuentasBancariasProvBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_CuentasBancariasProvBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_CuentasBancariasProvBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_CuentasBancariasProvBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_CuentasBancariasProvBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_CuentasBancariasProvBindingNavigator.Name = "CXP_CuentasBancariasProvBindingNavigator"
        Me.CXP_CuentasBancariasProvBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_CuentasBancariasProvBindingNavigator.Size = New System.Drawing.Size(1242, 25)
        Me.CXP_CuentasBancariasProvBindingNavigator.TabIndex = 0
        Me.CXP_CuentasBancariasProvBindingNavigator.Text = "BindingNavigator1"
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
        'CXP_CuentasBancariasProvBindingNavigatorSaveItem
        '
        Me.CXP_CuentasBancariasProvBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_CuentasBancariasProvBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_CuentasBancariasProvBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_CuentasBancariasProvBindingNavigatorSaveItem.Name = "CXP_CuentasBancariasProvBindingNavigatorSaveItem"
        Me.CXP_CuentasBancariasProvBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_CuentasBancariasProvBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CXP_CuentasBancariasProvDataGridView
        '
        Me.CXP_CuentasBancariasProvDataGridView.AllowUserToAddRows = False
        Me.CXP_CuentasBancariasProvDataGridView.AutoGenerateColumns = False
        Me.CXP_CuentasBancariasProvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CXP_CuentasBancariasProvDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.verPdf, Me.estatus, Me.autorizar, Me.idCuentas})
        Me.CXP_CuentasBancariasProvDataGridView.DataSource = Me.CXP_CuentasBancariasProvBindingSource
        Me.CXP_CuentasBancariasProvDataGridView.Location = New System.Drawing.Point(12, 39)
        Me.CXP_CuentasBancariasProvDataGridView.Name = "CXP_CuentasBancariasProvDataGridView"
        Me.CXP_CuentasBancariasProvDataGridView.ReadOnly = True
        Me.CXP_CuentasBancariasProvDataGridView.Size = New System.Drawing.Size(1222, 335)
        Me.CXP_CuentasBancariasProvDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idBanco"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.CXPBancosBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "nombreCorto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Banco"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "idBancos"
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'CXPBancosBindingSource
        '
        Me.CXPBancosBindingSource.DataMember = "CXP_Bancos"
        Me.CXPBancosBindingSource.DataSource = Me.DsProduction
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 220
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cuenta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cuenta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "clabe"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CLABE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "moneda"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.CXPcMonedaBindingSource
        Me.DataGridViewTextBoxColumn7.DisplayMember = "c_NombreMoneda"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "c_Moneda"
        '
        'CXPcMonedaBindingSource
        '
        Me.CXPcMonedaBindingSource.DataMember = "CXP_c_Moneda"
        Me.CXPcMonedaBindingSource.DataSource = Me.DsProduction
        '
        'verPdf
        '
        Me.verPdf.DataPropertyName = "archivo1"
        Me.verPdf.HeaderText = "Archivo"
        Me.verPdf.Name = "verPdf"
        Me.verPdf.ReadOnly = True
        Me.verPdf.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.verPdf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.verPdf.Text = "Archivo"
        '
        'estatus
        '
        Me.estatus.DataPropertyName = "estatus"
        Me.estatus.DataSource = Me.CXPEstatus2BindingSource
        Me.estatus.DisplayMember = "descripcion"
        Me.estatus.HeaderText = "estatus"
        Me.estatus.Name = "estatus"
        Me.estatus.ReadOnly = True
        Me.estatus.ValueMember = "idEstatus"
        Me.estatus.Width = 180
        '
        'CXPEstatus2BindingSource
        '
        Me.CXPEstatus2BindingSource.DataMember = "CXP_Estatus2"
        Me.CXPEstatus2BindingSource.DataSource = Me.DsProduction
        Me.CXPEstatus2BindingSource.Filter = "grupoEstatus='CTASBANCARIAS'"
        '
        'autorizar
        '
        Me.autorizar.HeaderText = "autorizar"
        Me.autorizar.Name = "autorizar"
        Me.autorizar.ReadOnly = True
        '
        'idCuentas
        '
        Me.idCuentas.DataPropertyName = "idCuentas"
        Me.idCuentas.HeaderText = "idCuentas"
        Me.idCuentas.Name = "idCuentas"
        Me.idCuentas.ReadOnly = True
        Me.idCuentas.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1159, 380)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CXP_Estatus2TableAdapter
        '
        Me.CXP_Estatus2TableAdapter.ClearBeforeFill = True
        '
        'frmCuentasBancarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 417)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CXP_CuentasBancariasProvDataGridView)
        Me.Controls.Add(Me.CXP_CuentasBancariasProvBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmCuentasBancarias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas Bancarias "
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_CuentasBancariasProvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_CuentasBancariasProvBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_CuentasBancariasProvBindingNavigator.ResumeLayout(False)
        Me.CXP_CuentasBancariasProvBindingNavigator.PerformLayout()
        CType(Me.CXP_CuentasBancariasProvDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPBancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcMonedaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPEstatus2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_CuentasBancariasProvBindingSource As BindingSource
    Friend WithEvents CXP_CuentasBancariasProvTableAdapter As dsProductionTableAdapters.CXP_CuentasBancariasProvTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_CuentasBancariasProvBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_CuentasBancariasProvBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CXP_BancosTableAdapter As dsProductionTableAdapters.CXP_BancosTableAdapter
    Friend WithEvents CXP_CuentasBancariasProvDataGridView As DataGridView
    Friend WithEvents CXPBancosBindingSource As BindingSource
    Friend WithEvents btnSalir As Button
    Friend WithEvents CXP_c_MonedaTableAdapter As dsProductionTableAdapters.CXP_c_MonedaTableAdapter
    Friend WithEvents CXPcMonedaBindingSource As BindingSource
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CXPEstatus2BindingSource As BindingSource
    Friend WithEvents CXP_Estatus2TableAdapter As dsProductionTableAdapters.CXP_Estatus2TableAdapter
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewComboBoxColumn
    Friend WithEvents verPdf As DataGridViewLinkColumn
    Friend WithEvents estatus As DataGridViewComboBoxColumn
    Friend WithEvents autorizar As DataGridViewLinkColumn
    Friend WithEvents idCuentas As DataGridViewTextBoxColumn
End Class
