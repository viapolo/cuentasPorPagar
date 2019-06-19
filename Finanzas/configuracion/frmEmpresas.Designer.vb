<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpresas
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
        Dim IdRegimenFiscalLabel As System.Windows.Forms.Label
        Dim CondicionesDePagoLabel As System.Windows.Forms.Label
        Dim IdMonedaLabel As System.Windows.Forms.Label
        Dim CodigoPostalLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim DelegacionLabel As System.Windows.Forms.Label
        Dim ColoniaLabel As System.Windows.Forms.Label
        Dim NumeroExteriorLabel As System.Windows.Forms.Label
        Dim NumeroInteriorLabel As System.Windows.Forms.Label
        Dim CalleLabel As System.Windows.Forms.Label
        Dim RfcLabel As System.Windows.Forms.Label
        Dim RazonSocialLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresas))
        Dim FolioSolLabel As System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_EmpresasTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_EmpresasTableAdapter()
        Me.gbxInformaciongeneral = New System.Windows.Forms.GroupBox()
        Me.cmbRegimenFiscal = New System.Windows.Forms.ComboBox()
        Me.CXP_EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXPcRegimenFiscalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction2 = New cuentasPorPagar.dsProduction()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.CXPcMonedaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction3 = New cuentasPorPagar.dsProduction()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.CXPcEstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction1 = New cuentasPorPagar.dsProduction()
        Me.CodigoPostalTextBox = New System.Windows.Forms.TextBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.CXPcPaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CondicionesDePagoTextBox = New System.Windows.Forms.TextBox()
        Me.DelegacionTextBox = New System.Windows.Forms.TextBox()
        Me.ColoniaTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroExteriorTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroInteriorTextBox = New System.Windows.Forms.TextBox()
        Me.CalleTextBox = New System.Windows.Forms.TextBox()
        Me.RfcTextBox = New System.Windows.Forms.TextBox()
        Me.cmbRazonSocial = New System.Windows.Forms.ComboBox()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CXP_EmpresasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.CXP_SucursalesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RazonSocialTextBox = New System.Windows.Forms.TextBox()
        Me.CXP_c_CodigoPostalTableAdapter1 = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_CodigoPostalTableAdapter()
        Me.CXP_c_EstadoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_EstadoTableAdapter()
        Me.CXP_c_RegimenFiscalTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_RegimenFiscalTableAdapter()
        Me.CXP_c_MonedaTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_MonedaTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_c_CodigoPostalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXPcMonedaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_c_PaisTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_PaisTableAdapter()
        Me.FolioSolTextBox = New System.Windows.Forms.TextBox()
        IdRegimenFiscalLabel = New System.Windows.Forms.Label()
        CondicionesDePagoLabel = New System.Windows.Forms.Label()
        IdMonedaLabel = New System.Windows.Forms.Label()
        CodigoPostalLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        DelegacionLabel = New System.Windows.Forms.Label()
        ColoniaLabel = New System.Windows.Forms.Label()
        NumeroExteriorLabel = New System.Windows.Forms.Label()
        NumeroInteriorLabel = New System.Windows.Forms.Label()
        CalleLabel = New System.Windows.Forms.Label()
        RfcLabel = New System.Windows.Forms.Label()
        RazonSocialLabel = New System.Windows.Forms.Label()
        FolioSolLabel = New System.Windows.Forms.Label()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInformaciongeneral.SuspendLayout()
        CType(Me.CXP_EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcRegimenFiscalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcMonedaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcEstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcPaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_EmpresasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_EmpresasBindingNavigator.SuspendLayout()
        CType(Me.CXP_c_CodigoPostalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcMonedaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdRegimenFiscalLabel
        '
        IdRegimenFiscalLabel.AutoSize = True
        IdRegimenFiscalLabel.Location = New System.Drawing.Point(348, 133)
        IdRegimenFiscalLabel.Name = "IdRegimenFiscalLabel"
        IdRegimenFiscalLabel.Size = New System.Drawing.Size(82, 13)
        IdRegimenFiscalLabel.TabIndex = 50
        IdRegimenFiscalLabel.Text = "Regimen Fiscal:"
        '
        'CondicionesDePagoLabel
        '
        CondicionesDePagoLabel.AutoSize = True
        CondicionesDePagoLabel.Location = New System.Drawing.Point(439, 107)
        CondicionesDePagoLabel.Name = "CondicionesDePagoLabel"
        CondicionesDePagoLabel.Size = New System.Drawing.Size(111, 13)
        CondicionesDePagoLabel.TabIndex = 48
        CondicionesDePagoLabel.Text = "Condiciones de Pago:"
        '
        'IdMonedaLabel
        '
        IdMonedaLabel.AutoSize = True
        IdMonedaLabel.Location = New System.Drawing.Point(43, 130)
        IdMonedaLabel.Name = "IdMonedaLabel"
        IdMonedaLabel.Size = New System.Drawing.Size(49, 13)
        IdMonedaLabel.TabIndex = 46
        IdMonedaLabel.Text = "Moneda:"
        '
        'CodigoPostalLabel
        '
        CodigoPostalLabel.AutoSize = True
        CodigoPostalLabel.Location = New System.Drawing.Point(270, 78)
        CodigoPostalLabel.Name = "CodigoPostalLabel"
        CodigoPostalLabel.Size = New System.Drawing.Size(75, 13)
        CodigoPostalLabel.TabIndex = 44
        CodigoPostalLabel.Text = "Código Postal:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(451, 52)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(30, 13)
        PaisLabel.TabIndex = 42
        PaisLabel.Text = "Pais:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(439, 77)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 40
        EstadoLabel.Text = "Estado:"
        '
        'DelegacionLabel
        '
        DelegacionLabel.AutoSize = True
        DelegacionLabel.Location = New System.Drawing.Point(29, 104)
        DelegacionLabel.Name = "DelegacionLabel"
        DelegacionLabel.Size = New System.Drawing.Size(64, 13)
        DelegacionLabel.TabIndex = 38
        DelegacionLabel.Text = "Delegación:"
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.Location = New System.Drawing.Point(48, 78)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(45, 13)
        ColoniaLabel.TabIndex = 36
        ColoniaLabel.Text = "Colonia:"
        '
        'NumeroExteriorLabel
        '
        NumeroExteriorLabel.AutoSize = True
        NumeroExteriorLabel.Location = New System.Drawing.Point(215, 52)
        NumeroExteriorLabel.Name = "NumeroExteriorLabel"
        NumeroExteriorLabel.Size = New System.Drawing.Size(85, 13)
        NumeroExteriorLabel.TabIndex = 34
        NumeroExteriorLabel.Text = "Número Exterior:"
        '
        'NumeroInteriorLabel
        '
        NumeroInteriorLabel.AutoSize = True
        NumeroInteriorLabel.Location = New System.Drawing.Point(10, 52)
        NumeroInteriorLabel.Name = "NumeroInteriorLabel"
        NumeroInteriorLabel.Size = New System.Drawing.Size(82, 13)
        NumeroInteriorLabel.TabIndex = 32
        NumeroInteriorLabel.Text = "Número Interior:"
        '
        'CalleLabel
        '
        CalleLabel.AutoSize = True
        CalleLabel.Location = New System.Drawing.Point(59, 26)
        CalleLabel.Name = "CalleLabel"
        CalleLabel.Size = New System.Drawing.Size(33, 13)
        CalleLabel.TabIndex = 30
        CalleLabel.Text = "Calle:"
        '
        'RfcLabel
        '
        RfcLabel.AutoSize = True
        RfcLabel.Location = New System.Drawing.Point(520, 26)
        RfcLabel.Name = "RfcLabel"
        RfcLabel.Size = New System.Drawing.Size(31, 13)
        RfcLabel.TabIndex = 28
        RfcLabel.Text = "RFC:"
        AddHandler RfcLabel.Click, AddressOf Me.RfcLabel_Click
        '
        'RazonSocialLabel
        '
        RazonSocialLabel.AutoSize = True
        RazonSocialLabel.Location = New System.Drawing.Point(30, 36)
        RazonSocialLabel.Name = "RazonSocialLabel"
        RazonSocialLabel.Size = New System.Drawing.Size(73, 13)
        RazonSocialLabel.TabIndex = 26
        RazonSocialLabel.Text = "Razón Social:"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(625, 261)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 29
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_EmpresasTableAdapter
        '
        Me.CXP_EmpresasTableAdapter.ClearBeforeFill = True
        '
        'gbxInformaciongeneral
        '
        Me.gbxInformaciongeneral.Controls.Add(Me.cmbRegimenFiscal)
        Me.gbxInformaciongeneral.Controls.Add(Me.cmbMoneda)
        Me.gbxInformaciongeneral.Controls.Add(Me.cmbEstado)
        Me.gbxInformaciongeneral.Controls.Add(Me.CodigoPostalTextBox)
        Me.gbxInformaciongeneral.Controls.Add(Me.cmbPais)
        Me.gbxInformaciongeneral.Controls.Add(IdRegimenFiscalLabel)
        Me.gbxInformaciongeneral.Controls.Add(CondicionesDePagoLabel)
        Me.gbxInformaciongeneral.Controls.Add(IdMonedaLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.CondicionesDePagoTextBox)
        Me.gbxInformaciongeneral.Controls.Add(CodigoPostalLabel)
        Me.gbxInformaciongeneral.Controls.Add(PaisLabel)
        Me.gbxInformaciongeneral.Controls.Add(EstadoLabel)
        Me.gbxInformaciongeneral.Controls.Add(DelegacionLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.DelegacionTextBox)
        Me.gbxInformaciongeneral.Controls.Add(ColoniaLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.ColoniaTextBox)
        Me.gbxInformaciongeneral.Controls.Add(NumeroExteriorLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.NumeroExteriorTextBox)
        Me.gbxInformaciongeneral.Controls.Add(NumeroInteriorLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.NumeroInteriorTextBox)
        Me.gbxInformaciongeneral.Controls.Add(CalleLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.CalleTextBox)
        Me.gbxInformaciongeneral.Controls.Add(RfcLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.RfcTextBox)
        Me.gbxInformaciongeneral.Location = New System.Drawing.Point(12, 62)
        Me.gbxInformaciongeneral.Name = "gbxInformaciongeneral"
        Me.gbxInformaciongeneral.Size = New System.Drawing.Size(688, 165)
        Me.gbxInformaciongeneral.TabIndex = 30
        Me.gbxInformaciongeneral.TabStop = False
        Me.gbxInformaciongeneral.Text = "Información General:"
        '
        'cmbRegimenFiscal
        '
        Me.cmbRegimenFiscal.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_EmpresasBindingSource, "idRegimenFiscal", True))
        Me.cmbRegimenFiscal.DataSource = Me.CXPcRegimenFiscalBindingSource
        Me.cmbRegimenFiscal.DisplayMember = "c_NombreRegimenfiscal"
        Me.cmbRegimenFiscal.FormattingEnabled = True
        Me.cmbRegimenFiscal.Location = New System.Drawing.Point(436, 130)
        Me.cmbRegimenFiscal.Name = "cmbRegimenFiscal"
        Me.cmbRegimenFiscal.Size = New System.Drawing.Size(237, 21)
        Me.cmbRegimenFiscal.TabIndex = 55
        Me.cmbRegimenFiscal.ValueMember = "c_RegimenFiscal"
        '
        'CXP_EmpresasBindingSource
        '
        Me.CXP_EmpresasBindingSource.DataMember = "CXP_Empresas"
        Me.CXP_EmpresasBindingSource.DataSource = Me.DsProduction
        '
        'CXPcRegimenFiscalBindingSource
        '
        Me.CXPcRegimenFiscalBindingSource.DataMember = "CXP_c_RegimenFiscal"
        Me.CXPcRegimenFiscalBindingSource.DataSource = Me.DsProduction2
        '
        'DsProduction2
        '
        Me.DsProduction2.DataSetName = "dsProduction"
        Me.DsProduction2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_EmpresasBindingSource, "idMoneda", True))
        Me.cmbMoneda.DataSource = Me.CXPcMonedaBindingSource1
        Me.cmbMoneda.DisplayMember = "c_NombreMoneda"
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(99, 128)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(243, 21)
        Me.cmbMoneda.TabIndex = 54
        Me.cmbMoneda.ValueMember = "c_Moneda"
        '
        'CXPcMonedaBindingSource1
        '
        Me.CXPcMonedaBindingSource1.DataMember = "CXP_c_Moneda"
        Me.CXPcMonedaBindingSource1.DataSource = Me.DsProduction3
        '
        'DsProduction3
        '
        Me.DsProduction3.DataSetName = "dsProduction"
        Me.DsProduction3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbEstado
        '
        Me.cmbEstado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_EmpresasBindingSource, "estado", True))
        Me.cmbEstado.DataSource = Me.CXPcEstadoBindingSource
        Me.cmbEstado.DisplayMember = "c_NombreEstado"
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(487, 74)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(186, 21)
        Me.cmbEstado.TabIndex = 53
        Me.cmbEstado.ValueMember = "c_Estado"
        '
        'CXPcEstadoBindingSource
        '
        Me.CXPcEstadoBindingSource.DataMember = "CXP_c_Estado"
        Me.CXPcEstadoBindingSource.DataSource = Me.DsProduction1
        '
        'DsProduction1
        '
        Me.DsProduction1.DataSetName = "dsProduction"
        Me.DsProduction1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CodigoPostalTextBox
        '
        Me.CodigoPostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "codigoPostal", True))
        Me.CodigoPostalTextBox.Location = New System.Drawing.Point(351, 75)
        Me.CodigoPostalTextBox.Name = "CodigoPostalTextBox"
        Me.CodigoPostalTextBox.Size = New System.Drawing.Size(72, 20)
        Me.CodigoPostalTextBox.TabIndex = 34
        '
        'cmbPais
        '
        Me.cmbPais.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_EmpresasBindingSource, "pais", True))
        Me.cmbPais.DataSource = Me.CXPcPaisBindingSource
        Me.cmbPais.DisplayMember = "Descripcion"
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(487, 49)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(186, 21)
        Me.cmbPais.TabIndex = 52
        Me.cmbPais.ValueMember = "c_Pais"
        '
        'CXPcPaisBindingSource
        '
        Me.CXPcPaisBindingSource.DataMember = "CXP_c_Pais"
        Me.CXPcPaisBindingSource.DataSource = Me.DsProduction
        '
        'CondicionesDePagoTextBox
        '
        Me.CondicionesDePagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "condicionesDePago", True))
        Me.CondicionesDePagoTextBox.Location = New System.Drawing.Point(557, 104)
        Me.CondicionesDePagoTextBox.Name = "CondicionesDePagoTextBox"
        Me.CondicionesDePagoTextBox.Size = New System.Drawing.Size(116, 20)
        Me.CondicionesDePagoTextBox.TabIndex = 49
        '
        'DelegacionTextBox
        '
        Me.DelegacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "delegacion", True))
        Me.DelegacionTextBox.Location = New System.Drawing.Point(98, 101)
        Me.DelegacionTextBox.Name = "DelegacionTextBox"
        Me.DelegacionTextBox.Size = New System.Drawing.Size(325, 20)
        Me.DelegacionTextBox.TabIndex = 39
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "colonia", True))
        Me.ColoniaTextBox.Location = New System.Drawing.Point(98, 75)
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.Size = New System.Drawing.Size(166, 20)
        Me.ColoniaTextBox.TabIndex = 37
        '
        'NumeroExteriorTextBox
        '
        Me.NumeroExteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "numeroExterior", True))
        Me.NumeroExteriorTextBox.Location = New System.Drawing.Point(306, 49)
        Me.NumeroExteriorTextBox.Name = "NumeroExteriorTextBox"
        Me.NumeroExteriorTextBox.Size = New System.Drawing.Size(117, 20)
        Me.NumeroExteriorTextBox.TabIndex = 35
        '
        'NumeroInteriorTextBox
        '
        Me.NumeroInteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "numeroInterior", True))
        Me.NumeroInteriorTextBox.Location = New System.Drawing.Point(98, 49)
        Me.NumeroInteriorTextBox.Name = "NumeroInteriorTextBox"
        Me.NumeroInteriorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroInteriorTextBox.TabIndex = 33
        '
        'CalleTextBox
        '
        Me.CalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "calle", True))
        Me.CalleTextBox.Location = New System.Drawing.Point(98, 23)
        Me.CalleTextBox.Name = "CalleTextBox"
        Me.CalleTextBox.Size = New System.Drawing.Size(325, 20)
        Me.CalleTextBox.TabIndex = 31
        '
        'RfcTextBox
        '
        Me.RfcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "rfc", True))
        Me.RfcTextBox.Location = New System.Drawing.Point(557, 23)
        Me.RfcTextBox.Name = "RfcTextBox"
        Me.RfcTextBox.Size = New System.Drawing.Size(116, 20)
        Me.RfcTextBox.TabIndex = 29
        '
        'cmbRazonSocial
        '
        Me.cmbRazonSocial.DataSource = Me.CXP_EmpresasBindingSource
        Me.cmbRazonSocial.DisplayMember = "razonSocial"
        Me.cmbRazonSocial.FormattingEnabled = True
        Me.cmbRazonSocial.Location = New System.Drawing.Point(110, 33)
        Me.cmbRazonSocial.Name = "cmbRazonSocial"
        Me.cmbRazonSocial.Size = New System.Drawing.Size(287, 21)
        Me.cmbRazonSocial.TabIndex = 31
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CXP_EmpresasBindingNavigator
        '
        Me.CXP_EmpresasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_EmpresasBindingNavigator.BindingSource = Me.CXP_EmpresasBindingSource
        Me.CXP_EmpresasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_EmpresasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_EmpresasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_SucursalesBindingNavigatorSaveItem})
        Me.CXP_EmpresasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_EmpresasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_EmpresasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_EmpresasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_EmpresasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_EmpresasBindingNavigator.Name = "CXP_EmpresasBindingNavigator"
        Me.CXP_EmpresasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_EmpresasBindingNavigator.Size = New System.Drawing.Size(720, 25)
        Me.CXP_EmpresasBindingNavigator.TabIndex = 32
        Me.CXP_EmpresasBindingNavigator.Text = "BindingNavigator1"
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
        'CXP_SucursalesBindingNavigatorSaveItem
        '
        Me.CXP_SucursalesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_SucursalesBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_SucursalesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_SucursalesBindingNavigatorSaveItem.Name = "CXP_SucursalesBindingNavigatorSaveItem"
        Me.CXP_SucursalesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_SucursalesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "razonSocial", True))
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(403, 33)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(297, 20)
        Me.RazonSocialTextBox.TabIndex = 33
        '
        'CXP_c_CodigoPostalTableAdapter1
        '
        Me.CXP_c_CodigoPostalTableAdapter1.ClearBeforeFill = True
        '
        'CXP_c_EstadoTableAdapter
        '
        Me.CXP_c_EstadoTableAdapter.ClearBeforeFill = True
        '
        'CXP_c_RegimenFiscalTableAdapter
        '
        Me.CXP_c_RegimenFiscalTableAdapter.ClearBeforeFill = True
        '
        'CXP_c_MonedaTableAdapter
        '
        Me.CXP_c_MonedaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CXP_AutorizacionesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_BancosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_CodigoPostalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_EstadoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_PaisTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_RegimenFiscalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CodigoAgrupadorTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
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
        'CXP_c_CodigoPostalBindingSource
        '
        Me.CXP_c_CodigoPostalBindingSource.DataMember = "CXP_c_CodigoPostal"
        Me.CXP_c_CodigoPostalBindingSource.DataSource = Me.DsProduction
        '
        'CXPcMonedaBindingSource
        '
        Me.CXPcMonedaBindingSource.DataMember = "CXP_c_Moneda"
        Me.CXPcMonedaBindingSource.DataSource = Me.DsProduction2
        '
        'CXP_c_PaisTableAdapter
        '
        Me.CXP_c_PaisTableAdapter.ClearBeforeFill = True
        '
        'FolioSolLabel
        '
        FolioSolLabel.AutoSize = True
        FolioSolLabel.Location = New System.Drawing.Point(58, 236)
        FolioSolLabel.Name = "FolioSolLabel"
        FolioSolLabel.Size = New System.Drawing.Size(118, 13)
        FolioSolLabel.TabIndex = 33
        FolioSolLabel.Text = "Folio Solicitud de Pago:"
        '
        'FolioSolTextBox
        '
        Me.FolioSolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "folioSol", True))
        Me.FolioSolTextBox.Location = New System.Drawing.Point(176, 233)
        Me.FolioSolTextBox.Name = "FolioSolTextBox"
        Me.FolioSolTextBox.ReadOnly = True
        Me.FolioSolTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FolioSolTextBox.TabIndex = 34
        '
        'frmEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(720, 304)
        Me.Controls.Add(FolioSolLabel)
        Me.Controls.Add(Me.FolioSolTextBox)
        Me.Controls.Add(Me.RazonSocialTextBox)
        Me.Controls.Add(Me.CXP_EmpresasBindingNavigator)
        Me.Controls.Add(Me.cmbRazonSocial)
        Me.Controls.Add(Me.gbxInformaciongeneral)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(RazonSocialLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEmpresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresa"
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInformaciongeneral.ResumeLayout(False)
        Me.gbxInformaciongeneral.PerformLayout()
        CType(Me.CXP_EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcRegimenFiscalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcMonedaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcEstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcPaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_EmpresasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_EmpresasBindingNavigator.ResumeLayout(False)
        Me.CXP_EmpresasBindingNavigator.PerformLayout()
        CType(Me.CXP_c_CodigoPostalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcMonedaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_EmpresasBindingSource As BindingSource
    Friend WithEvents CXP_EmpresasTableAdapter As dsProductionTableAdapters.CXP_EmpresasTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents btnSalir As Button
    Friend WithEvents gbxInformaciongeneral As GroupBox
    Friend WithEvents CondicionesDePagoTextBox As TextBox
    Friend WithEvents DelegacionTextBox As TextBox
    Friend WithEvents ColoniaTextBox As TextBox
    Friend WithEvents NumeroExteriorTextBox As TextBox
    Friend WithEvents NumeroInteriorTextBox As TextBox
    Friend WithEvents CalleTextBox As TextBox
    Friend WithEvents RfcTextBox As TextBox
    Friend WithEvents cmbRazonSocial As ComboBox
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents CXP_EmpresasBindingNavigator As BindingNavigator
    Friend WithEvents CXP_SucursalesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents CXP_c_CodigoPostalTableAdapter As dsProductionTableAdapters.CXP_c_CodigoPostalTableAdapter
    Friend WithEvents RazonSocialTextBox As TextBox
    Friend WithEvents CXP_c_CodigoPostalBindingSource As BindingSource
    Friend WithEvents CXP_c_CodigoPostalTableAdapter1 As dsProductionTableAdapters.CXP_c_CodigoPostalTableAdapter
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents CodigoPostalTextBox As TextBox
    Friend WithEvents DsProduction1 As dsProduction
    Friend WithEvents CXPcEstadoBindingSource As BindingSource
    Friend WithEvents CXP_c_EstadoTableAdapter As dsProductionTableAdapters.CXP_c_EstadoTableAdapter
    Friend WithEvents DsProduction2 As dsProduction
    Friend WithEvents CXPcRegimenFiscalBindingSource As BindingSource
    Friend WithEvents CXP_c_RegimenFiscalTableAdapter As dsProductionTableAdapters.CXP_c_RegimenFiscalTableAdapter
    Friend WithEvents CXPcMonedaBindingSource As BindingSource
    Friend WithEvents CXP_c_MonedaTableAdapter As dsProductionTableAdapters.CXP_c_MonedaTableAdapter
    Friend WithEvents cmbMoneda As ComboBox
    Friend WithEvents DsProduction3 As dsProduction
    Friend WithEvents CXPcMonedaBindingSource1 As BindingSource
    Friend WithEvents cmbRegimenFiscal As ComboBox
    Friend WithEvents CXPcPaisBindingSource As BindingSource
    Friend WithEvents CXP_c_PaisTableAdapter As dsProductionTableAdapters.CXP_c_PaisTableAdapter
    Friend WithEvents FolioSolTextBox As TextBox
End Class
