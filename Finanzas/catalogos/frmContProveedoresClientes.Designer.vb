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
        Dim UsuarioSolicitaLabel As System.Windows.Forms.Label
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
        Me.UsuarioSolicitaTextBox = New System.Windows.Forms.TextBox()
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
        UsuarioSolicitaLabel = New System.Windows.Forms.Label()
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
        RazonSocialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RazonSocialLabel.Location = New System.Drawing.Point(15, 129)
        RazonSocialLabel.Name = "RazonSocialLabel"
        RazonSocialLabel.Size = New System.Drawing.Size(95, 17)
        RazonSocialLabel.TabIndex = 1
        RazonSocialLabel.Text = "Razón Social:"
        '
        'RfcLabel
        '
        RfcLabel.AutoSize = True
        RfcLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RfcLabel.Location = New System.Drawing.Point(56, 155)
        RfcLabel.Name = "RfcLabel"
        RfcLabel.Size = New System.Drawing.Size(39, 17)
        RfcLabel.TabIndex = 3
        RfcLabel.Text = "RFC:"
        '
        'CurpLabel
        '
        CurpLabel.AutoSize = True
        CurpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CurpLabel.Location = New System.Drawing.Point(222, 153)
        CurpLabel.Name = "CurpLabel"
        CurpLabel.Size = New System.Drawing.Size(50, 17)
        CurpLabel.TabIndex = 5
        CurpLabel.Text = "CURP:"
        '
        'NitLabel
        '
        NitLabel.AutoSize = True
        NitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NitLabel.Location = New System.Drawing.Point(263, 180)
        NitLabel.Name = "NitLabel"
        NitLabel.Size = New System.Drawing.Size(34, 17)
        NitLabel.TabIndex = 9
        NitLabel.Text = "NIT:"
        '
        'RelacionadoLabel
        '
        RelacionadoLabel.AutoSize = True
        RelacionadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RelacionadoLabel.Location = New System.Drawing.Point(520, 153)
        RelacionadoLabel.Name = "RelacionadoLabel"
        RelacionadoLabel.Size = New System.Drawing.Size(91, 17)
        RelacionadoLabel.TabIndex = 13
        RelacionadoLabel.Text = "Relacionado:"
        AddHandler RelacionadoLabel.Click, AddressOf Me.RelacionadoLabel_Click
        '
        'MontoMaxTransaccionLabel
        '
        MontoMaxTransaccionLabel.AutoSize = True
        MontoMaxTransaccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MontoMaxTransaccionLabel.Location = New System.Drawing.Point(814, 154)
        MontoMaxTransaccionLabel.Name = "MontoMaxTransaccionLabel"
        MontoMaxTransaccionLabel.Size = New System.Drawing.Size(80, 17)
        MontoMaxTransaccionLabel.TabIndex = 19
        MontoMaxTransaccionLabel.Text = "Monto Max:"
        '
        'NacionalidadLabel
        '
        NacionalidadLabel.AutoSize = True
        NacionalidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NacionalidadLabel.Location = New System.Drawing.Point(16, 181)
        NacionalidadLabel.Name = "NacionalidadLabel"
        NacionalidadLabel.Size = New System.Drawing.Size(94, 17)
        NacionalidadLabel.TabIndex = 21
        NacionalidadLabel.Text = "Nacionalidad:"
        '
        'FechaRegistroLabel
        '
        FechaRegistroLabel.AutoSize = True
        FechaRegistroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaRegistroLabel.Location = New System.Drawing.Point(497, 130)
        FechaRegistroLabel.Name = "FechaRegistroLabel"
        FechaRegistroLabel.Size = New System.Drawing.Size(128, 17)
        FechaRegistroLabel.TabIndex = 23
        FechaRegistroLabel.Text = "Fecha de Registro:"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MailLabel.Location = New System.Drawing.Point(57, 206)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(37, 17)
        MailLabel.TabIndex = 25
        MailLabel.Text = "mail:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(494, 21)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(160, 17)
        Label2.TabIndex = 43
        Label2.Text = "Estatus de autorización:"
        '
        'CalleLabel
        '
        CalleLabel.AutoSize = True
        CalleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CalleLabel.Location = New System.Drawing.Point(56, 232)
        CalleLabel.Name = "CalleLabel"
        CalleLabel.Size = New System.Drawing.Size(41, 17)
        CalleLabel.TabIndex = 45
        CalleLabel.Text = "calle:"
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColoniaLabel.Location = New System.Drawing.Point(44, 258)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(57, 17)
        ColoniaLabel.TabIndex = 46
        ColoniaLabel.Text = "colonia:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocalidadLabel.Location = New System.Drawing.Point(36, 284)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(68, 17)
        LocalidadLabel.TabIndex = 47
        LocalidadLabel.Text = "localidad:"
        '
        'DelegacionLabel
        '
        DelegacionLabel.AutoSize = True
        DelegacionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DelegacionLabel.Location = New System.Drawing.Point(529, 179)
        DelegacionLabel.Name = "DelegacionLabel"
        DelegacionLabel.Size = New System.Drawing.Size(81, 17)
        DelegacionLabel.TabIndex = 48
        DelegacionLabel.Text = "delegacion:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(549, 205)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(55, 17)
        EstadoLabel.TabIndex = 49
        EstadoLabel.Text = "estado:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaisLabel.Location = New System.Drawing.Point(562, 231)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(38, 17)
        PaisLabel.TabIndex = 50
        PaisLabel.Text = "pais:"
        '
        'CpLabel
        '
        CpLabel.AutoSize = True
        CpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CpLabel.Location = New System.Drawing.Point(569, 257)
        CpLabel.Name = "CpLabel"
        CpLabel.Size = New System.Drawing.Size(27, 17)
        CpLabel.TabIndex = 51
        CpLabel.Text = "cp:"
        '
        'IdProveedorLabel
        '
        IdProveedorLabel.AutoSize = True
        IdProveedorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdProveedorLabel.Location = New System.Drawing.Point(18, 310)
        IdProveedorLabel.Name = "IdProveedorLabel"
        IdProveedorLabel.Size = New System.Drawing.Size(93, 17)
        IdProveedorLabel.TabIndex = 58
        IdProveedorLabel.Text = "id Proveedor:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(108, 340)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(50, 17)
        Label3.TabIndex = 60
        Label3.Text = "Activo:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(365, 335)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(80, 17)
        Label4.TabIndex = 61
        Label4.Text = "Autorizado:"
        '
        'UsuarioSolicitaLabel
        '
        UsuarioSolicitaLabel.AutoSize = True
        UsuarioSolicitaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        UsuarioSolicitaLabel.Location = New System.Drawing.Point(18, 392)
        UsuarioSolicitaLabel.Name = "UsuarioSolicitaLabel"
        UsuarioSolicitaLabel.Size = New System.Drawing.Size(83, 17)
        UsuarioSolicitaLabel.TabIndex = 62
        UsuarioSolicitaLabel.Text = "Usuario sol:"
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
        Me.CXP_ProveedoresBindingSource.Filter = "autorizadoS='EN PROCESO' OR autorizadoS='PENDIENTE'"
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
        Me.CXP_ProveedoresBindingNavigator.AutoSize = False
        Me.CXP_ProveedoresBindingNavigator.BindingSource = Me.CXP_ProveedoresBindingSource
        Me.CXP_ProveedoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_ProveedoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_ProveedoresBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CXP_ProveedoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_ProveedoresBindingNavigatorSaveItem})
        Me.CXP_ProveedoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_ProveedoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_ProveedoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_ProveedoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_ProveedoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_ProveedoresBindingNavigator.Name = "CXP_ProveedoresBindingNavigator"
        Me.CXP_ProveedoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_ProveedoresBindingNavigator.Size = New System.Drawing.Size(1033, 49)
        Me.CXP_ProveedoresBindingNavigator.TabIndex = 0
        Me.CXP_ProveedoresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.Padding = New System.Windows.Forms.Padding(10)
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(40, 46)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 46)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.Padding = New System.Windows.Forms.Padding(10)
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(40, 46)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.Padding = New System.Windows.Forms.Padding(10)
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(40, 46)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.Padding = New System.Windows.Forms.Padding(10)
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(40, 46)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 49)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 25)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 49)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.Padding = New System.Windows.Forms.Padding(10)
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(40, 46)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.Padding = New System.Windows.Forms.Padding(10)
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(40, 46)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 49)
        '
        'CXP_ProveedoresBindingNavigatorSaveItem
        '
        Me.CXP_ProveedoresBindingNavigatorSaveItem.AutoSize = False
        Me.CXP_ProveedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_ProveedoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Name = "CXP_ProveedoresBindingNavigatorSaveItem"
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Padding = New System.Windows.Forms.Padding(10)
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(40, 46)
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "razonSocial", True))
        Me.RazonSocialTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(111, 126)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.ReadOnly = True
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(378, 23)
        Me.RazonSocialTextBox.TabIndex = 2
        '
        'RfcTextBox
        '
        Me.RfcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "rfc", True))
        Me.RfcTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RfcTextBox.Location = New System.Drawing.Point(111, 152)
        Me.RfcTextBox.Name = "RfcTextBox"
        Me.RfcTextBox.ReadOnly = True
        Me.RfcTextBox.Size = New System.Drawing.Size(111, 23)
        Me.RfcTextBox.TabIndex = 4
        '
        'CurpTextBox
        '
        Me.CurpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "curp", True))
        Me.CurpTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurpTextBox.Location = New System.Drawing.Point(274, 152)
        Me.CurpTextBox.Name = "CurpTextBox"
        Me.CurpTextBox.ReadOnly = True
        Me.CurpTextBox.Size = New System.Drawing.Size(215, 23)
        Me.CurpTextBox.TabIndex = 6
        '
        'NitTextBox
        '
        Me.NitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "nit", True))
        Me.NitTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NitTextBox.Location = New System.Drawing.Point(299, 178)
        Me.NitTextBox.Name = "NitTextBox"
        Me.NitTextBox.ReadOnly = True
        Me.NitTextBox.Size = New System.Drawing.Size(190, 23)
        Me.NitTextBox.TabIndex = 10
        '
        'RelacionadoCheckBox
        '
        Me.RelacionadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CXP_ProveedoresBindingSource, "relacionado", True))
        Me.RelacionadoCheckBox.Location = New System.Drawing.Point(634, 150)
        Me.RelacionadoCheckBox.Name = "RelacionadoCheckBox"
        Me.RelacionadoCheckBox.Size = New System.Drawing.Size(44, 24)
        Me.RelacionadoCheckBox.TabIndex = 14
        Me.RelacionadoCheckBox.UseVisualStyleBackColor = True
        '
        'MontoMaxTransaccionTextBox
        '
        Me.MontoMaxTransaccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "montoMaxTransaccion", True))
        Me.MontoMaxTransaccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoMaxTransaccionTextBox.Location = New System.Drawing.Point(900, 152)
        Me.MontoMaxTransaccionTextBox.Name = "MontoMaxTransaccionTextBox"
        Me.MontoMaxTransaccionTextBox.ReadOnly = True
        Me.MontoMaxTransaccionTextBox.Size = New System.Drawing.Size(112, 23)
        Me.MontoMaxTransaccionTextBox.TabIndex = 20
        '
        'FechaRegistroDateTimePicker
        '
        Me.FechaRegistroDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CXP_ProveedoresBindingSource, "fechaRegistro", True))
        Me.FechaRegistroDateTimePicker.Enabled = False
        Me.FechaRegistroDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaRegistroDateTimePicker.Location = New System.Drawing.Point(635, 126)
        Me.FechaRegistroDateTimePicker.Name = "FechaRegistroDateTimePicker"
        Me.FechaRegistroDateTimePicker.Size = New System.Drawing.Size(377, 23)
        Me.FechaRegistroDateTimePicker.TabIndex = 24
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "mail", True))
        Me.MailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MailTextBox.Location = New System.Drawing.Point(111, 203)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.ReadOnly = True
        Me.MailTextBox.Size = New System.Drawing.Size(378, 23)
        Me.MailTextBox.TabIndex = 26
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(900, 352)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 30)
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
        Me.cmbNacionalida.Location = New System.Drawing.Point(111, 178)
        Me.cmbNacionalida.Name = "cmbNacionalida"
        Me.cmbNacionalida.Size = New System.Drawing.Size(146, 21)
        Me.cmbNacionalida.TabIndex = 33
        Me.cmbNacionalida.ValueMember = "c_Pais"
        '
        'txtBuscaProveedor
        '
        Me.txtBuscaProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtBuscaProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscaProveedor.Location = New System.Drawing.Point(17, 19)
        Me.txtBuscaProveedor.Name = "txtBuscaProveedor"
        Me.txtBuscaProveedor.Size = New System.Drawing.Size(228, 23)
        Me.txtBuscaProveedor.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(254, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 26)
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
        Me.cmbBuscaAutorizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBuscaAutorizado.FormattingEnabled = True
        Me.cmbBuscaAutorizado.Location = New System.Drawing.Point(667, 19)
        Me.cmbBuscaAutorizado.Name = "cmbBuscaAutorizado"
        Me.cmbBuscaAutorizado.Size = New System.Drawing.Size(121, 24)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(963, 59)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar:"
        '
        'btnBuscarCmbs
        '
        Me.btnBuscarCmbs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCmbs.Location = New System.Drawing.Point(797, 18)
        Me.btnBuscarCmbs.Name = "btnBuscarCmbs"
        Me.btnBuscarCmbs.Size = New System.Drawing.Size(75, 25)
        Me.btnBuscarCmbs.TabIndex = 3
        Me.btnBuscarCmbs.Text = "Buscar"
        Me.btnBuscarCmbs.UseVisualStyleBackColor = True
        '
        'CalleTextBox
        '
        Me.CalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "calle", True))
        Me.CalleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalleTextBox.Location = New System.Drawing.Point(111, 229)
        Me.CalleTextBox.Name = "CalleTextBox"
        Me.CalleTextBox.ReadOnly = True
        Me.CalleTextBox.Size = New System.Drawing.Size(378, 23)
        Me.CalleTextBox.TabIndex = 46
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "colonia", True))
        Me.ColoniaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColoniaTextBox.Location = New System.Drawing.Point(111, 255)
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.ReadOnly = True
        Me.ColoniaTextBox.Size = New System.Drawing.Size(378, 23)
        Me.ColoniaTextBox.TabIndex = 47
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "localidad", True))
        Me.LocalidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalidadTextBox.Location = New System.Drawing.Point(111, 281)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.ReadOnly = True
        Me.LocalidadTextBox.Size = New System.Drawing.Size(378, 23)
        Me.LocalidadTextBox.TabIndex = 48
        '
        'DelegacionTextBox
        '
        Me.DelegacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "delegacion", True))
        Me.DelegacionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelegacionTextBox.Location = New System.Drawing.Point(634, 178)
        Me.DelegacionTextBox.Name = "DelegacionTextBox"
        Me.DelegacionTextBox.ReadOnly = True
        Me.DelegacionTextBox.Size = New System.Drawing.Size(378, 23)
        Me.DelegacionTextBox.TabIndex = 49
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "estado", True))
        Me.EstadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoTextBox.Location = New System.Drawing.Point(634, 204)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.ReadOnly = True
        Me.EstadoTextBox.Size = New System.Drawing.Size(378, 23)
        Me.EstadoTextBox.TabIndex = 50
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "pais", True))
        Me.PaisTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaisTextBox.Location = New System.Drawing.Point(634, 230)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.ReadOnly = True
        Me.PaisTextBox.Size = New System.Drawing.Size(378, 23)
        Me.PaisTextBox.TabIndex = 51
        '
        'CpTextBox
        '
        Me.CpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "cp", True))
        Me.CpTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpTextBox.Location = New System.Drawing.Point(634, 256)
        Me.CpTextBox.Name = "CpTextBox"
        Me.CpTextBox.ReadOnly = True
        Me.CpTextBox.Size = New System.Drawing.Size(100, 23)
        Me.CpTextBox.TabIndex = 52
        '
        'btnCtasBancarias
        '
        Me.btnCtasBancarias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCtasBancarias.Location = New System.Drawing.Point(597, 284)
        Me.btnCtasBancarias.Name = "btnCtasBancarias"
        Me.btnCtasBancarias.Size = New System.Drawing.Size(165, 39)
        Me.btnCtasBancarias.TabIndex = 6
        Me.btnCtasBancarias.Text = "Cuentas Bancarias"
        Me.btnCtasBancarias.UseVisualStyleBackColor = True
        '
        'btnDocumentacion
        '
        Me.btnDocumentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocumentacion.Location = New System.Drawing.Point(810, 284)
        Me.btnDocumentacion.Name = "btnDocumentacion"
        Me.btnDocumentacion.Size = New System.Drawing.Size(165, 39)
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
        Me.cmbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbActivo.FormattingEnabled = True
        Me.cmbActivo.Location = New System.Drawing.Point(111, 361)
        Me.cmbActivo.Name = "cmbActivo"
        Me.cmbActivo.Size = New System.Drawing.Size(121, 24)
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
        Me.cmbAutorizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAutorizado.FormattingEnabled = True
        Me.cmbAutorizado.Location = New System.Drawing.Point(368, 361)
        Me.cmbAutorizado.Name = "cmbAutorizado"
        Me.cmbAutorizado.Size = New System.Drawing.Size(121, 24)
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
        Me.IdProveedorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProveedorTextBox.Location = New System.Drawing.Point(111, 307)
        Me.IdProveedorTextBox.Name = "IdProveedorTextBox"
        Me.IdProveedorTextBox.ReadOnly = True
        Me.IdProveedorTextBox.Size = New System.Drawing.Size(100, 23)
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
        Me.lblTipoPersona.Location = New System.Drawing.Point(599, 364)
        Me.lblTipoPersona.Name = "lblTipoPersona"
        Me.lblTipoPersona.Size = New System.Drawing.Size(45, 13)
        Me.lblTipoPersona.TabIndex = 62
        Me.lblTipoPersona.Text = "Label1"
        '
        'UsuarioSolicitaTextBox
        '
        Me.UsuarioSolicitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "usuarioSolicita", True))
        Me.UsuarioSolicitaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UsuarioSolicitaTextBox.Location = New System.Drawing.Point(111, 391)
        Me.UsuarioSolicitaTextBox.Name = "UsuarioSolicitaTextBox"
        Me.UsuarioSolicitaTextBox.ReadOnly = True
        Me.UsuarioSolicitaTextBox.Size = New System.Drawing.Size(378, 23)
        Me.UsuarioSolicitaTextBox.TabIndex = 63
        '
        'frmContProveedoresClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 441)
        Me.Controls.Add(UsuarioSolicitaLabel)
        Me.Controls.Add(Me.UsuarioSolicitaTextBox)
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
        Me.KeyPreview = True
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
    Friend WithEvents CXP_ProveedoresBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UsuarioSolicitaTextBox As TextBox
End Class
