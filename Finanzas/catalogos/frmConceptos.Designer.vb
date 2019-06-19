<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConceptos
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ImpuestoLabel As System.Windows.Forms.Label
        Dim TipoProductoLabel As System.Windows.Forms.Label
        Dim CuentaProvLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim IdConceptoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConceptos))
        Me.CXP_ConceptosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CXP_ConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
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
        Me.CXP_ConceptosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.cmbCuentaEgreso = New System.Windows.Forms.ComboBox()
        Me.CXPCuentasContablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbImpuesto = New System.Windows.Forms.ComboBox()
        Me.CXPImpuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbTipoProducto = New System.Windows.Forms.ComboBox()
        Me.CXPTipoGastoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvImpuestos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.idImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CXPCuentasContablesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction1 = New cuentasPorPagar.dsProduction()
        Me.IdConceptoTextBox = New System.Windows.Forms.TextBox()
        Me.VwCXPImpConBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction2 = New cuentasPorPagar.dsProduction()
        Me.CXP_ConceptosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ConceptosTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_CuentasContablesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_CuentasContablesTableAdapter()
        Me.CXP_ImpuestoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ImpuestoTableAdapter()
        Me.CXP_TipoGastoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_TipoGastoTableAdapter()
        Me.Vw_CXP_ImpConTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.Vw_CXP_ImpConTableAdapter()
        Me.cmbTipoPoliza = New System.Windows.Forms.ComboBox()
        Me.CXPtipoDeDocumentoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_tipoDeDocumentoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter()
        NombreLabel = New System.Windows.Forms.Label()
        ImpuestoLabel = New System.Windows.Forms.Label()
        TipoProductoLabel = New System.Windows.Forms.Label()
        CuentaProvLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        IdConceptoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.CXP_ConceptosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_ConceptosBindingNavigator.SuspendLayout()
        CType(Me.CXP_ConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPCuentasContablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPImpuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPTipoGastoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPCuentasContablesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCXPImpConBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPtipoDeDocumentoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(49, 37)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(56, 13)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "Concepto:"
        '
        'ImpuestoLabel
        '
        ImpuestoLabel.AutoSize = True
        ImpuestoLabel.Location = New System.Drawing.Point(20, 192)
        ImpuestoLabel.Name = "ImpuestoLabel"
        ImpuestoLabel.Size = New System.Drawing.Size(53, 13)
        ImpuestoLabel.TabIndex = 7
        ImpuestoLabel.Text = "Impuesto:"
        '
        'TipoProductoLabel
        '
        TipoProductoLabel.AutoSize = True
        TipoProductoLabel.Location = New System.Drawing.Point(13, 63)
        TipoProductoLabel.Name = "TipoProductoLabel"
        TipoProductoLabel.Size = New System.Drawing.Size(92, 13)
        TipoProductoLabel.TabIndex = 15
        TipoProductoLabel.Text = "Tipo de Producto:"
        '
        'CuentaProvLabel
        '
        CuentaProvLabel.AutoSize = True
        CuentaProvLabel.Location = New System.Drawing.Point(28, 116)
        CuentaProvLabel.Name = "CuentaProvLabel"
        CuentaProvLabel.Size = New System.Drawing.Size(78, 13)
        CuentaProvLabel.TabIndex = 22
        CuentaProvLabel.Text = "Cuenta Abono:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(28, 89)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(75, 13)
        Label1.TabIndex = 25
        Label1.Text = "Cuenta Cargo:"
        '
        'IdConceptoLabel
        '
        IdConceptoLabel.AutoSize = True
        IdConceptoLabel.Location = New System.Drawing.Point(20, 366)
        IdConceptoLabel.Name = "IdConceptoLabel"
        IdConceptoLabel.Size = New System.Drawing.Size(68, 13)
        IdConceptoLabel.TabIndex = 26
        IdConceptoLabel.Text = "Id Concepto:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(17, 143)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(89, 13)
        Label2.TabIndex = 29
        Label2.Text = "Poliza de Egreso:"
        '
        'CXP_ConceptosBindingNavigator
        '
        Me.CXP_ConceptosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_ConceptosBindingNavigator.BindingSource = Me.CXP_ConceptosBindingSource
        Me.CXP_ConceptosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_ConceptosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_ConceptosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_ConceptosBindingNavigatorSaveItem})
        Me.CXP_ConceptosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_ConceptosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_ConceptosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_ConceptosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_ConceptosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_ConceptosBindingNavigator.Name = "CXP_ConceptosBindingNavigator"
        Me.CXP_ConceptosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_ConceptosBindingNavigator.Size = New System.Drawing.Size(492, 25)
        Me.CXP_ConceptosBindingNavigator.TabIndex = 0
        Me.CXP_ConceptosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'CXP_ConceptosBindingSource
        '
        Me.CXP_ConceptosBindingSource.DataMember = "CXP_Conceptos"
        Me.CXP_ConceptosBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
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
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CXP_ConceptosBindingNavigatorSaveItem
        '
        Me.CXP_ConceptosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_ConceptosBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_ConceptosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_ConceptosBindingNavigatorSaveItem.Name = "CXP_ConceptosBindingNavigatorSaveItem"
        Me.CXP_ConceptosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_ConceptosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ConceptosBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(112, 34)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(362, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'cmbCuentaEgreso
        '
        Me.cmbCuentaEgreso.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ConceptosBindingSource, "cuentaEgreso", True))
        Me.cmbCuentaEgreso.DataSource = Me.CXPCuentasContablesBindingSource
        Me.cmbCuentaEgreso.DisplayMember = "nombre"
        Me.cmbCuentaEgreso.FormattingEnabled = True
        Me.cmbCuentaEgreso.Location = New System.Drawing.Point(112, 86)
        Me.cmbCuentaEgreso.Name = "cmbCuentaEgreso"
        Me.cmbCuentaEgreso.Size = New System.Drawing.Size(362, 21)
        Me.cmbCuentaEgreso.TabIndex = 17
        Me.cmbCuentaEgreso.ValueMember = "idCuentaContable"
        '
        'CXPCuentasContablesBindingSource
        '
        Me.CXPCuentasContablesBindingSource.DataMember = "CXP_CuentasContables"
        Me.CXPCuentasContablesBindingSource.DataSource = Me.DsProduction
        Me.CXPCuentasContablesBindingSource.Filter = "tipo='Gasto'"
        '
        'cmbImpuesto
        '
        Me.cmbImpuesto.DataSource = Me.CXPImpuestoBindingSource
        Me.cmbImpuesto.DisplayMember = "descripcionLarga"
        Me.cmbImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbImpuesto.FormattingEnabled = True
        Me.cmbImpuesto.Location = New System.Drawing.Point(79, 189)
        Me.cmbImpuesto.Name = "cmbImpuesto"
        Me.cmbImpuesto.Size = New System.Drawing.Size(327, 21)
        Me.cmbImpuesto.TabIndex = 18
        Me.cmbImpuesto.ValueMember = "idImpuesto"
        '
        'CXPImpuestoBindingSource
        '
        Me.CXPImpuestoBindingSource.DataMember = "CXP_Impuesto"
        Me.CXPImpuestoBindingSource.DataSource = Me.DsProduction
        '
        'cmbTipoProducto
        '
        Me.cmbTipoProducto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ConceptosBindingSource, "impuesto", True))
        Me.cmbTipoProducto.DataSource = Me.CXPTipoGastoBindingSource
        Me.cmbTipoProducto.DisplayMember = "nombre"
        Me.cmbTipoProducto.FormattingEnabled = True
        Me.cmbTipoProducto.Location = New System.Drawing.Point(112, 60)
        Me.cmbTipoProducto.Name = "cmbTipoProducto"
        Me.cmbTipoProducto.Size = New System.Drawing.Size(362, 21)
        Me.cmbTipoProducto.TabIndex = 19
        Me.cmbTipoProducto.ValueMember = "idTipoGasto"
        '
        'CXPTipoGastoBindingSource
        '
        Me.CXPTipoGastoBindingSource.DataMember = "CXP_TipoGasto"
        Me.CXPTipoGastoBindingSource.DataSource = Me.DsProduction
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(399, 363)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dgvImpuestos
        '
        Me.dgvImpuestos.AllowUserToAddRows = False
        Me.dgvImpuestos.AllowUserToDeleteRows = False
        Me.dgvImpuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImpuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.impuesto, Me.cuenta, Me.eliminar, Me.idImpuesto})
        Me.dgvImpuestos.Location = New System.Drawing.Point(14, 216)
        Me.dgvImpuestos.Name = "dgvImpuestos"
        Me.dgvImpuestos.ReadOnly = True
        Me.dgvImpuestos.RowHeadersVisible = False
        Me.dgvImpuestos.Size = New System.Drawing.Size(460, 138)
        Me.dgvImpuestos.TabIndex = 21
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 41
        '
        'impuesto
        '
        Me.impuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.impuesto.HeaderText = "Impuesto"
        Me.impuesto.Name = "impuesto"
        Me.impuesto.ReadOnly = True
        Me.impuesto.Width = 75
        '
        'cuenta
        '
        Me.cuenta.HeaderText = "Cuenta"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        '
        'idImpuesto
        '
        Me.idImpuesto.HeaderText = "IdImpuesto"
        Me.idImpuesto.Name = "idImpuesto"
        Me.idImpuesto.ReadOnly = True
        Me.idImpuesto.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(412, 188)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(62, 23)
        Me.btnAgregar.TabIndex = 22
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ConceptosBindingSource, "cuentaProv", True))
        Me.ComboBox1.DataSource = Me.CXPCuentasContablesBindingSource1
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(112, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(362, 21)
        Me.ComboBox1.TabIndex = 23
        Me.ComboBox1.ValueMember = "idCuentaContable"
        '
        'CXPCuentasContablesBindingSource1
        '
        Me.CXPCuentasContablesBindingSource1.DataMember = "CXP_CuentasContables"
        Me.CXPCuentasContablesBindingSource1.DataSource = Me.DsProduction1
        Me.CXPCuentasContablesBindingSource1.Filter = ""
        '
        'DsProduction1
        '
        Me.DsProduction1.DataSetName = "dsProduction"
        Me.DsProduction1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdConceptoTextBox
        '
        Me.IdConceptoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ConceptosBindingSource, "idConcepto", True))
        Me.IdConceptoTextBox.Location = New System.Drawing.Point(93, 363)
        Me.IdConceptoTextBox.Name = "IdConceptoTextBox"
        Me.IdConceptoTextBox.ReadOnly = True
        Me.IdConceptoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdConceptoTextBox.TabIndex = 27
        '
        'VwCXPImpConBindingSource
        '
        Me.VwCXPImpConBindingSource.DataMember = "Vw_CXP_ImpCon"
        Me.VwCXPImpConBindingSource.DataSource = Me.DsProduction2
        '
        'DsProduction2
        '
        Me.DsProduction2.DataSetName = "dsProduction"
        Me.DsProduction2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_ConceptosTableAdapter
        '
        Me.CXP_ConceptosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CXP_AutorizacionesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_BancosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_CodigoPostalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_EstadoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_PaisTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_RegimenFiscalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CodigoAgrupadorTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Me.CXP_ConceptosTableAdapter
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpConTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoGastoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdiTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_CuentasContablesTableAdapter
        '
        Me.CXP_CuentasContablesTableAdapter.ClearBeforeFill = True
        '
        'CXP_ImpuestoTableAdapter
        '
        Me.CXP_ImpuestoTableAdapter.ClearBeforeFill = True
        '
        'CXP_TipoGastoTableAdapter
        '
        Me.CXP_TipoGastoTableAdapter.ClearBeforeFill = True
        '
        'Vw_CXP_ImpConTableAdapter
        '
        Me.Vw_CXP_ImpConTableAdapter.ClearBeforeFill = True
        '
        'cmbTipoPoliza
        '
        Me.cmbTipoPoliza.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ConceptosBindingSource, "tipoProducto", True))
        Me.cmbTipoPoliza.DataSource = Me.CXPtipoDeDocumentoBindingSource1
        Me.cmbTipoPoliza.DisplayMember = "claveTipoDocumento"
        Me.cmbTipoPoliza.FormattingEnabled = True
        Me.cmbTipoPoliza.Location = New System.Drawing.Point(112, 140)
        Me.cmbTipoPoliza.Name = "cmbTipoPoliza"
        Me.cmbTipoPoliza.Size = New System.Drawing.Size(362, 21)
        Me.cmbTipoPoliza.TabIndex = 28
        Me.cmbTipoPoliza.ValueMember = "idTipoDeDocumento"
        '
        'CXPtipoDeDocumentoBindingSource1
        '
        Me.CXPtipoDeDocumentoBindingSource1.DataMember = "CXP_tipoDeDocumento"
        Me.CXPtipoDeDocumentoBindingSource1.DataSource = Me.DsProduction
        Me.CXPtipoDeDocumentoBindingSource1.Filter = "documentoDe = 'Egreso'"
        '
        'CXP_tipoDeDocumentoTableAdapter
        '
        Me.CXP_tipoDeDocumentoTableAdapter.ClearBeforeFill = True
        '
        'frmConceptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 398)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.cmbTipoPoliza)
        Me.Controls.Add(IdConceptoLabel)
        Me.Controls.Add(Me.IdConceptoTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(CuentaProvLabel)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvImpuestos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cmbTipoProducto)
        Me.Controls.Add(Me.cmbImpuesto)
        Me.Controls.Add(Me.cmbCuentaEgreso)
        Me.Controls.Add(TipoProductoLabel)
        Me.Controls.Add(ImpuestoLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.CXP_ConceptosBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmConceptos"
        Me.Text = "Conceptos"
        CType(Me.CXP_ConceptosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_ConceptosBindingNavigator.ResumeLayout(False)
        Me.CXP_ConceptosBindingNavigator.PerformLayout()
        CType(Me.CXP_ConceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPCuentasContablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPImpuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPTipoGastoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPCuentasContablesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCXPImpConBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPtipoDeDocumentoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_ConceptosBindingSource As BindingSource
    Friend WithEvents CXP_ConceptosTableAdapter As dsProductionTableAdapters.CXP_ConceptosTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_ConceptosBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_ConceptosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents cmbCuentaEgreso As ComboBox
    Friend WithEvents CXPCuentasContablesBindingSource As BindingSource
    Friend WithEvents CXP_CuentasContablesTableAdapter As dsProductionTableAdapters.CXP_CuentasContablesTableAdapter
    Friend WithEvents cmbImpuesto As ComboBox
    Friend WithEvents cmbTipoProducto As ComboBox
    Friend WithEvents CXPImpuestoBindingSource As BindingSource
    Friend WithEvents CXP_ImpuestoTableAdapter As dsProductionTableAdapters.CXP_ImpuestoTableAdapter
    Friend WithEvents btnSalir As Button
    Friend WithEvents CXPTipoGastoBindingSource As BindingSource
    Friend WithEvents CXP_TipoGastoTableAdapter As dsProductionTableAdapters.CXP_TipoGastoTableAdapter
    Friend WithEvents dgvImpuestos As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DsProduction1 As dsProduction
    Friend WithEvents CXPCuentasContablesBindingSource1 As BindingSource
    Friend WithEvents IdConceptoTextBox As TextBox
    Friend WithEvents DsProduction2 As dsProduction
    Friend WithEvents VwCXPImpConBindingSource As BindingSource
    Friend WithEvents Vw_CXP_ImpConTableAdapter As dsProductionTableAdapters.Vw_CXP_ImpConTableAdapter
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents impuesto As DataGridViewTextBoxColumn
    Friend WithEvents cuenta As DataGridViewTextBoxColumn
    Friend WithEvents eliminar As DataGridViewLinkColumn
    Friend WithEvents idImpuesto As DataGridViewTextBoxColumn
    Friend WithEvents cmbTipoPoliza As ComboBox
    Friend WithEvents CXPtipoDeDocumentoBindingSource1 As BindingSource
    Friend WithEvents CXP_tipoDeDocumentoTableAdapter As dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter
End Class
