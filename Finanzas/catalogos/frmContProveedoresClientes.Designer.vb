<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContProveedoresClientes
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
        Dim RazonSocialLabel As System.Windows.Forms.Label
        Dim RfcLabel As System.Windows.Forms.Label
        Dim CurpLabel As System.Windows.Forms.Label
        Dim NitLabel As System.Windows.Forms.Label
        Dim RelacionadoLabel As System.Windows.Forms.Label
        Dim MontoMaxTransaccionLabel As System.Windows.Forms.Label
        Dim NacionalidadLabel As System.Windows.Forms.Label
        Dim FechaRegistroLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim CalleLabel As System.Windows.Forms.Label
        Dim ColoniaLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim DelegacionLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim CpLabel As System.Windows.Forms.Label
        Dim IdProveedorLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContProveedoresClientes))
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_ProveedoresTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ProveedoresTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_ProveedoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CXP_ProveedoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RazonSocialTextBox = New System.Windows.Forms.TextBox()
        Me.RfcTextBox = New System.Windows.Forms.TextBox()
        Me.CurpTextBox = New System.Windows.Forms.TextBox()
        Me.NitTextBox = New System.Windows.Forms.TextBox()
        Me.RelacionadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.MontoMaxTransaccionTextBox = New System.Windows.Forms.TextBox()
        Me.FechaRegistroDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cmbNacionalida = New System.Windows.Forms.ComboBox()
        Me.txtBuscaProveedor = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.CXPcMonedaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_BancosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_BancosTableAdapter()
        Me.cmbBuscaAutorizado = New System.Windows.Forms.ComboBox()
        Me.CXPEstatusBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCmbs = New System.Windows.Forms.Button()
        Me.CalleTextBox = New System.Windows.Forms.TextBox()
        Me.ColoniaTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.DelegacionTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.CpTextBox = New System.Windows.Forms.TextBox()
        Me.btnCtasBancarias = New System.Windows.Forms.Button()
        Me.btnDocumentacion = New System.Windows.Forms.Button()
        Me.cmbActivo = New System.Windows.Forms.ComboBox()
        Me.CXPEstatus1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction1 = New cuentasPorPagar.dsProduction()
        Me.cmbAutorizado = New System.Windows.Forms.ComboBox()
        Me.CXPEstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.CXP_EstatusTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_EstatusTableAdapter()
        Me.CXP_Estatus1TableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_Estatus1TableAdapter()
        Me.CXPEstatus1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTipoPersona = New System.Windows.Forms.Label()
        RazonSocialLabel = New System.Windows.Forms.Label()
        RfcLabel = New System.Windows.Forms.Label()
        CurpLabel = New System.Windows.Forms.Label()
        NitLabel = New System.Windows.Forms.Label()
        RelacionadoLabel = New System.Windows.Forms.Label()
        MontoMaxTransaccionLabel = New System.Windows.Forms.Label()
        NacionalidadLabel = New System.Windows.Forms.Label()
        FechaRegistroLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CalleLabel = New System.Windows.Forms.Label()
        ColoniaLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        DelegacionLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        CpLabel = New System.Windows.Forms.Label()
        IdProveedorLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_ProveedoresBindingNavigator.SuspendLayout()
        CType(Me.CXPcMonedaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPEstatusBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CXPEstatus1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPEstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPEstatus1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RazonSocialLabel
        '
        RazonSocialLabel.AutoSize = True
        RazonSocialLabel.Location = New System.Drawing.Point(32, 97)
        RazonSocialLabel.Name = "RazonSocialLabel"
        RazonSocialLabel.Size = New System.Drawing.Size(73, 13)
        RazonSocialLabel.TabIndex = 1
        RazonSocialLabel.Text = "Razón Social:"
        '
        'RfcLabel
        '
        RfcLabel.AutoSize = True
        RfcLabel.Location = New System.Drawing.Point(73, 123)
        RfcLabel.Name = "RfcLabel"
        RfcLabel.Size = New System.Drawing.Size(31, 13)
        RfcLabel.TabIndex = 3
        RfcLabel.Text = "RFC:"
        '
        'CurpLabel
        '
        CurpLabel.AutoSize = True
        CurpLabel.Location = New System.Drawing.Point(228, 123)
        CurpLabel.Name = "CurpLabel"
        CurpLabel.Size = New System.Drawing.Size(40, 13)
        CurpLabel.TabIndex = 5
        CurpLabel.Text = "CURP:"
        '
        'NitLabel
        '
        NitLabel.AutoSize = True
        NitLabel.Location = New System.Drawing.Point(271, 149)
        NitLabel.Name = "NitLabel"
        NitLabel.Size = New System.Drawing.Size(28, 13)
        NitLabel.TabIndex = 9
        NitLabel.Text = "NIT:"
        '
        'RelacionadoLabel
        '
        RelacionadoLabel.AutoSize = True
        RelacionadoLabel.Location = New System.Drawing.Point(524, 123)
        RelacionadoLabel.Name = "RelacionadoLabel"
        RelacionadoLabel.Size = New System.Drawing.Size(70, 13)
        RelacionadoLabel.TabIndex = 13
        RelacionadoLabel.Text = "Relacionado:"
        AddHandler RelacionadoLabel.Click, AddressOf Me.RelacionadoLabel_Click
        '
        'MontoMaxTransaccionLabel
        '
        MontoMaxTransaccionLabel.AutoSize = True
        MontoMaxTransaccionLabel.Location = New System.Drawing.Point(801, 97)
        MontoMaxTransaccionLabel.Name = "MontoMaxTransaccionLabel"
        MontoMaxTransaccionLabel.Size = New System.Drawing.Size(63, 13)
        MontoMaxTransaccionLabel.TabIndex = 19
        MontoMaxTransaccionLabel.Text = "Monto Max:"
        '
        'NacionalidadLabel
        '
        NacionalidadLabel.AutoSize = True
        NacionalidadLabel.Location = New System.Drawing.Point(33, 149)
        NacionalidadLabel.Name = "NacionalidadLabel"
        NacionalidadLabel.Size = New System.Drawing.Size(72, 13)
        NacionalidadLabel.TabIndex = 21
        NacionalidadLabel.Text = "Nacionalidad:"
        '
        'FechaRegistroLabel
        '
        FechaRegistroLabel.AutoSize = True
        FechaRegistroLabel.Location = New System.Drawing.Point(497, 100)
        FechaRegistroLabel.Name = "FechaRegistroLabel"
        FechaRegistroLabel.Size = New System.Drawing.Size(97, 13)
        FechaRegistroLabel.TabIndex = 23
        FechaRegistroLabel.Text = "Fecha de Registro:"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(74, 174)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(28, 13)
        MailLabel.TabIndex = 25
        MailLabel.Text = "mail:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(544, 22)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(117, 13)
        Label2.TabIndex = 43
        Label2.Text = "Estatus deautorización:"
        '
        'CalleLabel
        '
        CalleLabel.AutoSize = True
        CalleLabel.Location = New System.Drawing.Point(73, 200)
        CalleLabel.Name = "CalleLabel"
        CalleLabel.Size = New System.Drawing.Size(32, 13)
        CalleLabel.TabIndex = 45
        CalleLabel.Text = "calle:"
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.Location = New System.Drawing.Point(61, 226)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(44, 13)
        ColoniaLabel.TabIndex = 46
        ColoniaLabel.Text = "colonia:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Location = New System.Drawing.Point(53, 252)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(52, 13)
        LocalidadLabel.TabIndex = 47
        LocalidadLabel.Text = "localidad:"
        '
        'DelegacionLabel
        '
        DelegacionLabel.AutoSize = True
        DelegacionLabel.Location = New System.Drawing.Point(529, 149)
        DelegacionLabel.Name = "DelegacionLabel"
        DelegacionLabel.Size = New System.Drawing.Size(62, 13)
        DelegacionLabel.TabIndex = 48
        DelegacionLabel.Text = "delegacion:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(549, 175)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(42, 13)
        EstadoLabel.TabIndex = 49
        EstadoLabel.Text = "estado:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(562, 201)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(29, 13)
        PaisLabel.TabIndex = 50
        PaisLabel.Text = "pais:"
        '
        'CpLabel
        '
        CpLabel.AutoSize = True
        CpLabel.Location = New System.Drawing.Point(569, 227)
        CpLabel.Name = "CpLabel"
        CpLabel.Size = New System.Drawing.Size(22, 13)
        CpLabel.TabIndex = 51
        CpLabel.Text = "cp:"
        '
        'IdProveedorLabel
        '
        IdProveedorLabel.AutoSize = True
        IdProveedorLabel.Location = New System.Drawing.Point(35, 278)
        IdProveedorLabel.Name = "IdProveedorLabel"
        IdProveedorLabel.Size = New System.Drawing.Size(70, 13)
        IdProveedorLabel.TabIndex = 58
        IdProveedorLabel.Text = "id Proveedor:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(108, 308)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(40, 13)
        Label3.TabIndex = 60
        Label3.Text = "Activo:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(365, 303)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(60, 13)
        Label4.TabIndex = 61
        Label4.Text = "Autorizado:"
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_ProveedoresBindingSource
        '
        Me.CXP_ProveedoresBindingSource.DataMember = "CXP_Proveedores"
        Me.CXP_ProveedoresBindingSource.DataSource = Me.DsProduction
        '
        'CXP_ProveedoresTableAdapter
        '
        Me.CXP_ProveedoresTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Me.CXP_ProveedoresTableAdapter
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
        'CXP_ProveedoresBindingNavigator
        '
        Me.CXP_ProveedoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_ProveedoresBindingNavigator.BindingSource = Me.CXP_ProveedoresBindingSource
        Me.CXP_ProveedoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_ProveedoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_ProveedoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_ProveedoresBindingNavigatorSaveItem})
        Me.CXP_ProveedoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_ProveedoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_ProveedoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_ProveedoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_ProveedoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_ProveedoresBindingNavigator.Name = "CXP_ProveedoresBindingNavigator"
        Me.CXP_ProveedoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_ProveedoresBindingNavigator.Size = New System.Drawing.Size(989, 25)
        Me.CXP_ProveedoresBindingNavigator.TabIndex = 0
        Me.CXP_ProveedoresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        Me.BindingNavigatorDeleteItem.Enabled = False
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
        'CXP_ProveedoresBindingNavigatorSaveItem
        '
        Me.CXP_ProveedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_ProveedoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Name = "CXP_ProveedoresBindingNavigatorSaveItem"
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Text = "e"
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "razonSocial", True))
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(111, 94)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.ReadOnly = True
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(378, 20)
        Me.RazonSocialTextBox.TabIndex = 2
        '
        'RfcTextBox
        '
        Me.RfcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "rfc", True))
        Me.RfcTextBox.Location = New System.Drawing.Point(111, 120)
        Me.RfcTextBox.Name = "RfcTextBox"
        Me.RfcTextBox.ReadOnly = True
        Me.RfcTextBox.Size = New System.Drawing.Size(111, 20)
        Me.RfcTextBox.TabIndex = 4
        '
        'CurpTextBox
        '
        Me.CurpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "curp", True))
        Me.CurpTextBox.Location = New System.Drawing.Point(274, 120)
        Me.CurpTextBox.Name = "CurpTextBox"
        Me.CurpTextBox.ReadOnly = True
        Me.CurpTextBox.Size = New System.Drawing.Size(215, 20)
        Me.CurpTextBox.TabIndex = 6
        '
        'NitTextBox
        '
        Me.NitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "nit", True))
        Me.NitTextBox.Location = New System.Drawing.Point(299, 146)
        Me.NitTextBox.Name = "NitTextBox"
        Me.NitTextBox.ReadOnly = True
        Me.NitTextBox.Size = New System.Drawing.Size(190, 20)
        Me.NitTextBox.TabIndex = 10
        '
        'RelacionadoCheckBox
        '
        Me.RelacionadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CXP_ProveedoresBindingSource, "relacionado", True))
        Me.RelacionadoCheckBox.Location = New System.Drawing.Point(600, 118)
        Me.RelacionadoCheckBox.Name = "RelacionadoCheckBox"
        Me.RelacionadoCheckBox.Size = New System.Drawing.Size(44, 24)
        Me.RelacionadoCheckBox.TabIndex = 14
        Me.RelacionadoCheckBox.UseVisualStyleBackColor = True
        '
        'MontoMaxTransaccionTextBox
        '
        Me.MontoMaxTransaccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "montoMaxTransaccion", True))
        Me.MontoMaxTransaccionTextBox.Location = New System.Drawing.Point(864, 94)
        Me.MontoMaxTransaccionTextBox.Name = "MontoMaxTransaccionTextBox"
        Me.MontoMaxTransaccionTextBox.ReadOnly = True
        Me.MontoMaxTransaccionTextBox.Size = New System.Drawing.Size(111, 20)
        Me.MontoMaxTransaccionTextBox.TabIndex = 20
        '
        'FechaRegistroDateTimePicker
        '
        Me.FechaRegistroDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CXP_ProveedoresBindingSource, "fechaRegistro", True))
        Me.FechaRegistroDateTimePicker.Enabled = False
        Me.FechaRegistroDateTimePicker.Location = New System.Drawing.Point(597, 94)
        Me.FechaRegistroDateTimePicker.Name = "FechaRegistroDateTimePicker"
        Me.FechaRegistroDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaRegistroDateTimePicker.TabIndex = 24
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(111, 171)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.ReadOnly = True
        Me.MailTextBox.Size = New System.Drawing.Size(378, 20)
        Me.MailTextBox.TabIndex = 26
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(900, 327)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'cmbNacionalida
        '
        Me.cmbNacionalida.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ProveedoresBindingSource, "nacionalidad", True))
        Me.cmbNacionalida.DisplayMember = "c_Pais"
        Me.cmbNacionalida.Enabled = False
        Me.cmbNacionalida.FormattingEnabled = True
        Me.cmbNacionalida.Location = New System.Drawing.Point(111, 146)
        Me.cmbNacionalida.Name = "cmbNacionalida"
        Me.cmbNacionalida.Size = New System.Drawing.Size(146, 21)
        Me.cmbNacionalida.TabIndex = 33
        Me.cmbNacionalida.ValueMember = "c_Pais"
        '
        'txtBuscaProveedor
        '
        Me.txtBuscaProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtBuscaProveedor.Location = New System.Drawing.Point(17, 19)
        Me.txtBuscaProveedor.Name = "txtBuscaProveedor"
        Me.txtBuscaProveedor.Size = New System.Drawing.Size(228, 20)
        Me.txtBuscaProveedor.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(254, 18)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'CXPcMonedaBindingSource
        '
        Me.CXPcMonedaBindingSource.DataMember = "CXP_c_Moneda"
        Me.CXPcMonedaBindingSource.DataSource = Me.DsProduction
        '
        'CXP_BancosTableAdapter
        '
        Me.CXP_BancosTableAdapter.ClearBeforeFill = True
        '
        'cmbBuscaAutorizado
        '
        Me.cmbBuscaAutorizado.DataSource = Me.CXPEstatusBindingSource1
        Me.cmbBuscaAutorizado.DisplayMember = "descripcion"
        Me.cmbBuscaAutorizado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuscaAutorizado.FormattingEnabled = True
        Me.cmbBuscaAutorizado.Location = New System.Drawing.Point(667, 19)
        Me.cmbBuscaAutorizado.Name = "cmbBuscaAutorizado"
        Me.cmbBuscaAutorizado.Size = New System.Drawing.Size(121, 21)
        Me.cmbBuscaAutorizado.TabIndex = 2
        Me.cmbBuscaAutorizado.ValueMember = "descripcion"
        '
        'CXPEstatusBindingSource1
        '
        Me.CXPEstatusBindingSource1.DataMember = "CXP_Estatus"
        Me.CXPEstatusBindingSource1.DataSource = Me.DsProduction
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarCmbs)
        Me.GroupBox1.Controls.Add(Me.txtBuscaProveedor)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.cmbBuscaAutorizado)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(963, 59)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar:"
        '
        'btnBuscarCmbs
        '
        Me.btnBuscarCmbs.Location = New System.Drawing.Point(797, 18)
        Me.btnBuscarCmbs.Name = "btnBuscarCmbs"
        Me.btnBuscarCmbs.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCmbs.TabIndex = 3
        Me.btnBuscarCmbs.Text = "Buscar"
        Me.btnBuscarCmbs.UseVisualStyleBackColor = True
        '
        'CalleTextBox
        '
        Me.CalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "calle", True))
        Me.CalleTextBox.Location = New System.Drawing.Point(111, 197)
        Me.CalleTextBox.Name = "CalleTextBox"
        Me.CalleTextBox.ReadOnly = True
        Me.CalleTextBox.Size = New System.Drawing.Size(378, 20)
        Me.CalleTextBox.TabIndex = 46
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "colonia", True))
        Me.ColoniaTextBox.Location = New System.Drawing.Point(111, 223)
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.ReadOnly = True
        Me.ColoniaTextBox.Size = New System.Drawing.Size(378, 20)
        Me.ColoniaTextBox.TabIndex = 47
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "localidad", True))
        Me.LocalidadTextBox.Location = New System.Drawing.Point(111, 249)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.ReadOnly = True
        Me.LocalidadTextBox.Size = New System.Drawing.Size(378, 20)
        Me.LocalidadTextBox.TabIndex = 48
        '
        'DelegacionTextBox
        '
        Me.DelegacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "delegacion", True))
        Me.DelegacionTextBox.Location = New System.Drawing.Point(597, 146)
        Me.DelegacionTextBox.Name = "DelegacionTextBox"
        Me.DelegacionTextBox.ReadOnly = True
        Me.DelegacionTextBox.Size = New System.Drawing.Size(378, 20)
        Me.DelegacionTextBox.TabIndex = 49
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(597, 172)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.ReadOnly = True
        Me.EstadoTextBox.Size = New System.Drawing.Size(378, 20)
        Me.EstadoTextBox.TabIndex = 50
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(597, 198)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.ReadOnly = True
        Me.PaisTextBox.Size = New System.Drawing.Size(378, 20)
        Me.PaisTextBox.TabIndex = 51
        '
        'CpTextBox
        '
        Me.CpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "cp", True))
        Me.CpTextBox.Location = New System.Drawing.Point(597, 224)
        Me.CpTextBox.Name = "CpTextBox"
        Me.CpTextBox.ReadOnly = True
        Me.CpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CpTextBox.TabIndex = 52
        '
        'btnCtasBancarias
        '
        Me.btnCtasBancarias.Location = New System.Drawing.Point(597, 252)
        Me.btnCtasBancarias.Name = "btnCtasBancarias"
        Me.btnCtasBancarias.Size = New System.Drawing.Size(165, 23)
        Me.btnCtasBancarias.TabIndex = 6
        Me.btnCtasBancarias.Text = "Cuentas Bancarias"
        Me.btnCtasBancarias.UseVisualStyleBackColor = True
        '
        'btnDocumentacion
        '
        Me.btnDocumentacion.Location = New System.Drawing.Point(810, 252)
        Me.btnDocumentacion.Name = "btnDocumentacion"
        Me.btnDocumentacion.Size = New System.Drawing.Size(165, 23)
        Me.btnDocumentacion.TabIndex = 7
        Me.btnDocumentacion.Text = "Documentación"
        Me.btnDocumentacion.UseVisualStyleBackColor = True
        '
        'cmbActivo
        '
        Me.cmbActivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "activoS", True))
        Me.cmbActivo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ProveedoresBindingSource, "activoS", True))
        Me.cmbActivo.DataSource = Me.CXPEstatus1BindingSource
        Me.cmbActivo.DisplayMember = "descripcion"
        Me.cmbActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActivo.FormattingEnabled = True
        Me.cmbActivo.Location = New System.Drawing.Point(111, 329)
        Me.cmbActivo.Name = "cmbActivo"
        Me.cmbActivo.Size = New System.Drawing.Size(121, 21)
        Me.cmbActivo.TabIndex = 4
        Me.cmbActivo.ValueMember = "descripcion"
        '
        'CXPEstatus1BindingSource
        '
        Me.CXPEstatus1BindingSource.DataMember = "CXP_Estatus1"
        Me.CXPEstatus1BindingSource.DataSource = Me.DsProduction1
        '
        'DsProduction1
        '
        Me.DsProduction1.DataSetName = "dsProduction"
        Me.DsProduction1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbAutorizado
        '
        Me.cmbAutorizado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "autorizadoS", True))
        Me.cmbAutorizado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ProveedoresBindingSource, "autorizadoS", True))
        Me.cmbAutorizado.DataSource = Me.CXPEstatusBindingSource
        Me.cmbAutorizado.DisplayMember = "descripcion"
        Me.cmbAutorizado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAutorizado.FormattingEnabled = True
        Me.cmbAutorizado.Location = New System.Drawing.Point(368, 329)
        Me.cmbAutorizado.Name = "cmbAutorizado"
        Me.cmbAutorizado.Size = New System.Drawing.Size(121, 21)
        Me.cmbAutorizado.TabIndex = 5
        Me.cmbAutorizado.ValueMember = "descripcion"
        '
        'CXPEstatusBindingSource
        '
        Me.CXPEstatusBindingSource.DataMember = "CXP_Estatus"
        Me.CXPEstatusBindingSource.DataSource = Me.DsProduction
        '
        'IdProveedorTextBox
        '
        Me.IdProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "idProveedor", True))
        Me.IdProveedorTextBox.Enabled = False
        Me.IdProveedorTextBox.Location = New System.Drawing.Point(111, 275)
        Me.IdProveedorTextBox.Name = "IdProveedorTextBox"
        Me.IdProveedorTextBox.ReadOnly = True
        Me.IdProveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdProveedorTextBox.TabIndex = 59
        '
        'CXP_EstatusTableAdapter
        '
        Me.CXP_EstatusTableAdapter.ClearBeforeFill = True
        '
        'CXP_Estatus1TableAdapter
        '
        Me.CXP_Estatus1TableAdapter.ClearBeforeFill = True
        '
        'CXPEstatus1BindingSource1
        '
        Me.CXPEstatus1BindingSource1.DataMember = "CXP_Estatus1"
        Me.CXPEstatus1BindingSource1.DataSource = Me.DsProduction
        '
        'lblTipoPersona
        '
        Me.lblTipoPersona.AutoSize = True
        Me.lblTipoPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPersona.Location = New System.Drawing.Point(599, 332)
        Me.lblTipoPersona.Name = "lblTipoPersona"
        Me.lblTipoPersona.Size = New System.Drawing.Size(45, 13)
        Me.lblTipoPersona.TabIndex = 62
        Me.lblTipoPersona.Text = "Label1"
        '
        'frmContProveedoresClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 365)
        Me.Controls.Add(Me.lblTipoPersona)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(IdProveedorLabel)
        Me.Controls.Add(Me.IdProveedorTextBox)
        Me.Controls.Add(Me.cmbAutorizado)
        Me.Controls.Add(Me.cmbActivo)
        Me.Controls.Add(Me.btnDocumentacion)
        Me.Controls.Add(Me.btnCtasBancarias)
        Me.Controls.Add(CpLabel)
        Me.Controls.Add(Me.CpTextBox)
        Me.Controls.Add(PaisLabel)
        Me.Controls.Add(Me.PaisTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(DelegacionLabel)
        Me.Controls.Add(Me.DelegacionTextBox)
        Me.Controls.Add(LocalidadLabel)
        Me.Controls.Add(Me.LocalidadTextBox)
        Me.Controls.Add(ColoniaLabel)
        Me.Controls.Add(Me.ColoniaTextBox)
        Me.Controls.Add(CalleLabel)
        Me.Controls.Add(Me.CalleTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbNacionalida)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.Controls.Add(FechaRegistroLabel)
        Me.Controls.Add(Me.FechaRegistroDateTimePicker)
        Me.Controls.Add(NacionalidadLabel)
        Me.Controls.Add(MontoMaxTransaccionLabel)
        Me.Controls.Add(Me.MontoMaxTransaccionTextBox)
        Me.Controls.Add(RelacionadoLabel)
        Me.Controls.Add(Me.RelacionadoCheckBox)
        Me.Controls.Add(NitLabel)
        Me.Controls.Add(Me.NitTextBox)
        Me.Controls.Add(CurpLabel)
        Me.Controls.Add(Me.CurpTextBox)
        Me.Controls.Add(RfcLabel)
        Me.Controls.Add(Me.RfcTextBox)
        Me.Controls.Add(RazonSocialLabel)
        Me.Controls.Add(Me.RazonSocialTextBox)
        Me.Controls.Add(Me.CXP_ProveedoresBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmContProveedoresClientes"
        Me.Text = "Proveedores"
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_ProveedoresBindingNavigator.ResumeLayout(False)
        Me.CXP_ProveedoresBindingNavigator.PerformLayout()
        CType(Me.CXPcMonedaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPEstatusBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CXPEstatus1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPEstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPEstatus1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_ProveedoresBindingSource As BindingSource
    Friend WithEvents CXP_ProveedoresTableAdapter As dsProductionTableAdapters.CXP_ProveedoresTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_ProveedoresBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_ProveedoresBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents RazonSocialTextBox As TextBox
    Friend WithEvents RfcTextBox As TextBox
    Friend WithEvents CurpTextBox As TextBox
    Friend WithEvents NitTextBox As TextBox
    Friend WithEvents RelacionadoCheckBox As CheckBox
    Friend WithEvents MontoMaxTransaccionTextBox As TextBox
    Friend WithEvents FechaRegistroDateTimePicker As DateTimePicker
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents cmbNacionalida As ComboBox
    Friend WithEvents txtBuscaProveedor As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents CXP_BancosTableAdapter As dsProductionTableAdapters.CXP_BancosTableAdapter
    Friend WithEvents cmbBuscaAutorizado As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CXPcMonedaBindingSource As BindingSource
    Friend WithEvents CalleTextBox As TextBox
    Friend WithEvents ColoniaTextBox As TextBox
    Friend WithEvents LocalidadTextBox As TextBox
    Friend WithEvents DelegacionTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents PaisTextBox As TextBox
    Friend WithEvents CpTextBox As TextBox
    Friend WithEvents btnCtasBancarias As Button
    Friend WithEvents btnDocumentacion As Button
    Friend WithEvents cmbActivo As ComboBox
    Friend WithEvents cmbAutorizado As ComboBox
    Friend WithEvents IdProveedorTextBox As TextBox
    Friend WithEvents CXPEstatusBindingSource As BindingSource
    Friend WithEvents CXP_EstatusTableAdapter As dsProductionTableAdapters.CXP_EstatusTableAdapter
    Friend WithEvents DsProduction1 As dsProduction
    Friend WithEvents CXPEstatus1BindingSource As BindingSource
    Friend WithEvents CXP_Estatus1TableAdapter As dsProductionTableAdapters.CXP_Estatus1TableAdapter
    Friend WithEvents btnBuscarCmbs As Button
    Friend WithEvents CXPEstatus1BindingSource1 As BindingSource
    Friend WithEvents CXPEstatusBindingSource1 As BindingSource
    Friend WithEvents lblTipoPersona As Label
End Class
