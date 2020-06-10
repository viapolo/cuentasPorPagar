<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDocumentosProv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocumentosProv))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_ProveedoresArchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_ProveedoresArchTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ProveedoresArchTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_DocumentacionProvTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_DocumentacionProvTableAdapter()
        Me.CXP_ProveedoresArchBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CXP_ProveedoresArchBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CXP_ProveedoresArchDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CXPDocumentacionProvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.idDocAdjunto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CXPEstatus2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.usuarioSolicita1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuarioSolicita2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaSolicita1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaSolicita2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.autorizar1 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.autorizar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.CXP_Estatus2TableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_Estatus2TableAdapter()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ProveedoresArchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ProveedoresArchBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_ProveedoresArchBindingNavigator.SuspendLayout()
        CType(Me.CXP_ProveedoresArchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPDocumentacionProvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPEstatus2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_ProveedoresArchBindingSource
        '
        Me.CXP_ProveedoresArchBindingSource.DataMember = "CXP_ProveedoresArch"
        Me.CXP_ProveedoresArchBindingSource.DataSource = Me.DsProduction
        Me.CXP_ProveedoresArchBindingSource.Sort = "estatus asc,idDocAdjunto asc"
        '
        'CXP_ProveedoresArchTableAdapter
        '
        Me.CXP_ProveedoresArchTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CFDI_Estado_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_AutorizacionesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_BancosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_CodigoPostalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_EstadoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_PaisTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_RegimenFiscalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CodigoAgrupadorTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ComprobGtosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasProvTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DocumentacionProvTableAdapter = Me.CXP_DocumentacionProvTableAdapter
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_Estatus1TableAdapter = Nothing
        Me.TableAdapterManager.CXP_Estatus2TableAdapter = Nothing
        Me.TableAdapterManager.CXP_EstatusTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpConTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PagosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresArchTableAdapter = Me.CXP_ProveedoresArchTableAdapter
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
        'CXP_DocumentacionProvTableAdapter
        '
        Me.CXP_DocumentacionProvTableAdapter.ClearBeforeFill = True
        '
        'CXP_ProveedoresArchBindingNavigator
        '
        Me.CXP_ProveedoresArchBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_ProveedoresArchBindingNavigator.BindingSource = Me.CXP_ProveedoresArchBindingSource
        Me.CXP_ProveedoresArchBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_ProveedoresArchBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_ProveedoresArchBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_ProveedoresArchBindingNavigatorSaveItem})
        Me.CXP_ProveedoresArchBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_ProveedoresArchBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_ProveedoresArchBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_ProveedoresArchBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_ProveedoresArchBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_ProveedoresArchBindingNavigator.Name = "CXP_ProveedoresArchBindingNavigator"
        Me.CXP_ProveedoresArchBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_ProveedoresArchBindingNavigator.Size = New System.Drawing.Size(776, 25)
        Me.CXP_ProveedoresArchBindingNavigator.TabIndex = 0
        Me.CXP_ProveedoresArchBindingNavigator.Text = "BindingNavigator1"
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
        'CXP_ProveedoresArchBindingNavigatorSaveItem
        '
        Me.CXP_ProveedoresArchBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_ProveedoresArchBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_ProveedoresArchBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_ProveedoresArchBindingNavigatorSaveItem.Name = "CXP_ProveedoresArchBindingNavigatorSaveItem"
        Me.CXP_ProveedoresArchBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_ProveedoresArchBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CXP_ProveedoresArchDataGridView
        '
        Me.CXP_ProveedoresArchDataGridView.AllowUserToAddRows = False
        Me.CXP_ProveedoresArchDataGridView.AllowUserToDeleteRows = False
        Me.CXP_ProveedoresArchDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CXP_ProveedoresArchDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CXP_ProveedoresArchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CXP_ProveedoresArchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.idDocAdjunto, Me.estatus, Me.usuarioSolicita1, Me.usuarioSolicita2, Me.fechaSolicita1, Me.fechaSolicita2, Me.autorizar1, Me.autorizar})
        Me.CXP_ProveedoresArchDataGridView.DataSource = Me.CXP_ProveedoresArchBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CXP_ProveedoresArchDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.CXP_ProveedoresArchDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.CXP_ProveedoresArchDataGridView.Name = "CXP_ProveedoresArchDataGridView"
        Me.CXP_ProveedoresArchDataGridView.ReadOnly = True
        Me.CXP_ProveedoresArchDataGridView.Size = New System.Drawing.Size(752, 389)
        Me.CXP_ProveedoresArchDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "idDocAdjunto"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.CXPDocumentacionProvBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "descripcion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tipo de Documento"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "idDocAdjunto"
        Me.DataGridViewTextBoxColumn5.Width = 300
        '
        'CXPDocumentacionProvBindingSource
        '
        Me.CXPDocumentacionProvBindingSource.DataMember = "CXP_DocumentacionProv"
        Me.CXPDocumentacionProvBindingSource.DataSource = Me.DsProduction
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "uuid"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Archivo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'idDocAdjunto
        '
        Me.idDocAdjunto.DataPropertyName = "idDocAdjunto"
        Me.idDocAdjunto.HeaderText = "idDocAdjunto"
        Me.idDocAdjunto.Name = "idDocAdjunto"
        Me.idDocAdjunto.ReadOnly = True
        Me.idDocAdjunto.Visible = False
        '
        'estatus
        '
        Me.estatus.DataPropertyName = "estatus"
        Me.estatus.DataSource = Me.CXPEstatus2BindingSource
        Me.estatus.DisplayMember = "descripcion"
        Me.estatus.HeaderText = "Estatus"
        Me.estatus.Name = "estatus"
        Me.estatus.ReadOnly = True
        Me.estatus.ValueMember = "idEstatus"
        Me.estatus.Width = 160
        '
        'CXPEstatus2BindingSource
        '
        Me.CXPEstatus2BindingSource.DataMember = "CXP_Estatus2"
        Me.CXPEstatus2BindingSource.DataSource = Me.DsProduction
        Me.CXPEstatus2BindingSource.Filter = "grupoEstatus='PROVEEDORESARCH'"
        '
        'usuarioSolicita1
        '
        Me.usuarioSolicita1.DataPropertyName = "usuarioSolicita1"
        Me.usuarioSolicita1.HeaderText = "Solic Alta"
        Me.usuarioSolicita1.Name = "usuarioSolicita1"
        Me.usuarioSolicita1.ReadOnly = True
        Me.usuarioSolicita1.Visible = False
        '
        'usuarioSolicita2
        '
        Me.usuarioSolicita2.DataPropertyName = "usuarioSolicita2"
        Me.usuarioSolicita2.HeaderText = "Sol Bloq"
        Me.usuarioSolicita2.Name = "usuarioSolicita2"
        Me.usuarioSolicita2.ReadOnly = True
        Me.usuarioSolicita2.Visible = False
        '
        'fechaSolicita1
        '
        Me.fechaSolicita1.DataPropertyName = "fechaSolicita1"
        Me.fechaSolicita1.HeaderText = "Fecha Alta"
        Me.fechaSolicita1.Name = "fechaSolicita1"
        Me.fechaSolicita1.ReadOnly = True
        Me.fechaSolicita1.Visible = False
        Me.fechaSolicita1.Width = 140
        '
        'fechaSolicita2
        '
        Me.fechaSolicita2.DataPropertyName = "fechaSolicita2"
        Me.fechaSolicita2.HeaderText = "Fecha Bloq"
        Me.fechaSolicita2.Name = "fechaSolicita2"
        Me.fechaSolicita2.ReadOnly = True
        Me.fechaSolicita2.Visible = False
        Me.fechaSolicita2.Width = 140
        '
        'autorizar1
        '
        Me.autorizar1.HeaderText = "Autorizar"
        Me.autorizar1.Name = "autorizar1"
        Me.autorizar1.ReadOnly = True
        Me.autorizar1.Text = "Autorizar"
        '
        'autorizar
        '
        Me.autorizar.DataPropertyName = "idProveedoresArch"
        Me.autorizar.HeaderText = "idProveedoresArch"
        Me.autorizar.Name = "autorizar"
        Me.autorizar.ReadOnly = True
        Me.autorizar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.autorizar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.autorizar.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(689, 423)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'CXP_Estatus2TableAdapter
        '
        Me.CXP_Estatus2TableAdapter.ClearBeforeFill = True
        '
        'frmDocumentosProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(776, 452)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CXP_ProveedoresArchDataGridView)
        Me.Controls.Add(Me.CXP_ProveedoresArchBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmDocumentosProv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos proveedores"
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_ProveedoresArchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_ProveedoresArchBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_ProveedoresArchBindingNavigator.ResumeLayout(False)
        Me.CXP_ProveedoresArchBindingNavigator.PerformLayout()
        CType(Me.CXP_ProveedoresArchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPDocumentacionProvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPEstatus2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_ProveedoresArchBindingSource As BindingSource
    Friend WithEvents CXP_ProveedoresArchTableAdapter As dsProductionTableAdapters.CXP_ProveedoresArchTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_ProveedoresArchBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_ProveedoresArchBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CXP_DocumentacionProvTableAdapter As dsProductionTableAdapters.CXP_DocumentacionProvTableAdapter
    Friend WithEvents CXP_ProveedoresArchDataGridView As DataGridView
    Friend WithEvents CXPDocumentacionProvBindingSource As BindingSource
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSalir As Button
    Friend WithEvents CXPEstatus2BindingSource As BindingSource
    Friend WithEvents CXP_Estatus2TableAdapter As dsProductionTableAdapters.CXP_Estatus2TableAdapter
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewLinkColumn
    Friend WithEvents idDocAdjunto As DataGridViewTextBoxColumn
    Friend WithEvents estatus As DataGridViewComboBoxColumn
    Friend WithEvents usuarioSolicita1 As DataGridViewTextBoxColumn
    Friend WithEvents usuarioSolicita2 As DataGridViewTextBoxColumn
    Friend WithEvents fechaSolicita1 As DataGridViewTextBoxColumn
    Friend WithEvents fechaSolicita2 As DataGridViewTextBoxColumn
    Friend WithEvents autorizar1 As DataGridViewLinkColumn
    Friend WithEvents autorizar As DataGridViewTextBoxColumn
End Class
