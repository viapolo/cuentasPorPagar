﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContProveedoresClientes
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
        Dim RazonSocialLabel As System.Windows.Forms.Label
        Dim RfcLabel As System.Windows.Forms.Label
        Dim CurpLabel As System.Windows.Forms.Label
        Dim ExtranjeroLabel As System.Windows.Forms.Label
        Dim NitLabel As System.Windows.Forms.Label
        Dim IdSucursalLabel As System.Windows.Forms.Label
        Dim RelacionadoLabel As System.Windows.Forms.Label
        Dim CuentaContablePagarLabel As System.Windows.Forms.Label
        Dim MontoMaxTransaccionLabel As System.Windows.Forms.Label
        Dim NacionalidadLabel As System.Windows.Forms.Label
        Dim FechaRegistroLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim EmpresaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContProveedoresClientes))
        Dim CuentaBancariaLabel As System.Windows.Forms.Label
        Dim ClabeLabel As System.Windows.Forms.Label
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_ProveedoresTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ProveedoresTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_CuentasContablesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_CuentasContablesTableAdapter()
        Me.CXP_SucursalesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_SucursalesTableAdapter()
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
        Me.ExtranjeroCheckBox = New System.Windows.Forms.CheckBox()
        Me.NitTextBox = New System.Windows.Forms.TextBox()
        Me.RelacionadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.MontoMaxTransaccionTextBox = New System.Windows.Forms.TextBox()
        Me.FechaRegistroDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.CXPSucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbCuentaContable = New System.Windows.Forms.ComboBox()
        Me.CXPCuentasContablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CXPEmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_EmpresasTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_EmpresasTableAdapter()
        Me.cmbNacionalida = New System.Windows.Forms.ComboBox()
        Me.CXPcPaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_c_PaisTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_PaisTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CuentaBancariaTextBox = New System.Windows.Forms.TextBox()
        Me.ClabeTextBox = New System.Windows.Forms.TextBox()
        Me.CXPBancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_BancosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_BancosTableAdapter()
        RazonSocialLabel = New System.Windows.Forms.Label()
        RfcLabel = New System.Windows.Forms.Label()
        CurpLabel = New System.Windows.Forms.Label()
        ExtranjeroLabel = New System.Windows.Forms.Label()
        NitLabel = New System.Windows.Forms.Label()
        IdSucursalLabel = New System.Windows.Forms.Label()
        RelacionadoLabel = New System.Windows.Forms.Label()
        CuentaContablePagarLabel = New System.Windows.Forms.Label()
        MontoMaxTransaccionLabel = New System.Windows.Forms.Label()
        NacionalidadLabel = New System.Windows.Forms.Label()
        FechaRegistroLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        EmpresaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CuentaBancariaLabel = New System.Windows.Forms.Label()
        ClabeLabel = New System.Windows.Forms.Label()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_ProveedoresBindingNavigator.SuspendLayout()
        CType(Me.CXPSucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPCuentasContablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPEmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcPaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPBancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RazonSocialLabel
        '
        RazonSocialLabel.AutoSize = True
        RazonSocialLabel.Location = New System.Drawing.Point(32, 31)
        RazonSocialLabel.Name = "RazonSocialLabel"
        RazonSocialLabel.Size = New System.Drawing.Size(73, 13)
        RazonSocialLabel.TabIndex = 1
        RazonSocialLabel.Text = "Razón Social:"
        '
        'RfcLabel
        '
        RfcLabel.AutoSize = True
        RfcLabel.Location = New System.Drawing.Point(73, 57)
        RfcLabel.Name = "RfcLabel"
        RfcLabel.Size = New System.Drawing.Size(31, 13)
        RfcLabel.TabIndex = 3
        RfcLabel.Text = "RFC:"
        '
        'CurpLabel
        '
        CurpLabel.AutoSize = True
        CurpLabel.Location = New System.Drawing.Point(228, 57)
        CurpLabel.Name = "CurpLabel"
        CurpLabel.Size = New System.Drawing.Size(40, 13)
        CurpLabel.TabIndex = 5
        CurpLabel.Text = "CURP:"
        '
        'ExtranjeroLabel
        '
        ExtranjeroLabel.AutoSize = True
        ExtranjeroLabel.Location = New System.Drawing.Point(49, 83)
        ExtranjeroLabel.Name = "ExtranjeroLabel"
        ExtranjeroLabel.Size = New System.Drawing.Size(57, 13)
        ExtranjeroLabel.TabIndex = 7
        ExtranjeroLabel.Text = "Extranjero:"
        '
        'NitLabel
        '
        NitLabel.AutoSize = True
        NitLabel.Location = New System.Drawing.Point(377, 83)
        NitLabel.Name = "NitLabel"
        NitLabel.Size = New System.Drawing.Size(28, 13)
        NitLabel.TabIndex = 9
        NitLabel.Text = "NIT:"
        '
        'IdSucursalLabel
        '
        IdSucursalLabel.AutoSize = True
        IdSucursalLabel.Location = New System.Drawing.Point(282, 188)
        IdSucursalLabel.Name = "IdSucursalLabel"
        IdSucursalLabel.Size = New System.Drawing.Size(51, 13)
        IdSucursalLabel.TabIndex = 11
        IdSucursalLabel.Text = "Sucursal:"
        '
        'RelacionadoLabel
        '
        RelacionadoLabel.AutoSize = True
        RelacionadoLabel.Location = New System.Drawing.Point(35, 270)
        RelacionadoLabel.Name = "RelacionadoLabel"
        RelacionadoLabel.Size = New System.Drawing.Size(70, 13)
        RelacionadoLabel.TabIndex = 13
        RelacionadoLabel.Text = "Relacionado:"
        AddHandler RelacionadoLabel.Click, AddressOf Me.RelacionadoLabel_Click
        '
        'CuentaContablePagarLabel
        '
        CuentaContablePagarLabel.AutoSize = True
        CuentaContablePagarLabel.Location = New System.Drawing.Point(16, 133)
        CuentaContablePagarLabel.Name = "CuentaContablePagarLabel"
        CuentaContablePagarLabel.Size = New System.Drawing.Size(89, 13)
        CuentaContablePagarLabel.TabIndex = 17
        CuentaContablePagarLabel.Text = "Cuenta Contable:"
        '
        'MontoMaxTransaccionLabel
        '
        MontoMaxTransaccionLabel.AutoSize = True
        MontoMaxTransaccionLabel.Location = New System.Drawing.Point(315, 160)
        MontoMaxTransaccionLabel.Name = "MontoMaxTransaccionLabel"
        MontoMaxTransaccionLabel.Size = New System.Drawing.Size(63, 13)
        MontoMaxTransaccionLabel.TabIndex = 19
        MontoMaxTransaccionLabel.Text = "Monto Max:"
        '
        'NacionalidadLabel
        '
        NacionalidadLabel.AutoSize = True
        NacionalidadLabel.Location = New System.Drawing.Point(145, 83)
        NacionalidadLabel.Name = "NacionalidadLabel"
        NacionalidadLabel.Size = New System.Drawing.Size(72, 13)
        NacionalidadLabel.TabIndex = 21
        NacionalidadLabel.Text = "Nacionalidad:"
        '
        'FechaRegistroLabel
        '
        FechaRegistroLabel.AutoSize = True
        FechaRegistroLabel.Location = New System.Drawing.Point(11, 163)
        FechaRegistroLabel.Name = "FechaRegistroLabel"
        FechaRegistroLabel.Size = New System.Drawing.Size(97, 13)
        FechaRegistroLabel.TabIndex = 23
        FechaRegistroLabel.Text = "Fecha de Registro:"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(74, 108)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(28, 13)
        MailLabel.TabIndex = 25
        MailLabel.Text = "mail:"
        '
        'EmpresaLabel
        '
        EmpresaLabel.AutoSize = True
        EmpresaLabel.Location = New System.Drawing.Point(57, 188)
        EmpresaLabel.Name = "EmpresaLabel"
        EmpresaLabel.Size = New System.Drawing.Size(51, 13)
        EmpresaLabel.TabIndex = 27
        EmpresaLabel.Text = "Empresa:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(65, 215)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(41, 13)
        Label1.TabIndex = 35
        Label1.Text = "Banco:"
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
        Me.TableAdapterManager.CXP_BancosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_CodigoPostalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_EstadoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_PaisTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_RegimenFiscalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CodigoAgrupadorTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Me.CXP_CuentasContablesTableAdapter
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Me.CXP_ProveedoresTableAdapter
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Me.CXP_SucursalesTableAdapter
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoGastoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_CuentasContablesTableAdapter
        '
        Me.CXP_CuentasContablesTableAdapter.ClearBeforeFill = True
        '
        'CXP_SucursalesTableAdapter
        '
        Me.CXP_SucursalesTableAdapter.ClearBeforeFill = True
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
        Me.CXP_ProveedoresBindingNavigator.Size = New System.Drawing.Size(506, 25)
        Me.CXP_ProveedoresBindingNavigator.TabIndex = 0
        Me.CXP_ProveedoresBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
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
        'CXP_ProveedoresBindingNavigatorSaveItem
        '
        Me.CXP_ProveedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Enabled = False
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_ProveedoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Name = "CXP_ProveedoresBindingNavigatorSaveItem"
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "razonSocial", True))
        Me.RazonSocialTextBox.Enabled = False
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(111, 28)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(378, 20)
        Me.RazonSocialTextBox.TabIndex = 2
        '
        'RfcTextBox
        '
        Me.RfcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "rfc", True))
        Me.RfcTextBox.Enabled = False
        Me.RfcTextBox.Location = New System.Drawing.Point(111, 54)
        Me.RfcTextBox.Name = "RfcTextBox"
        Me.RfcTextBox.Size = New System.Drawing.Size(111, 20)
        Me.RfcTextBox.TabIndex = 4
        '
        'CurpTextBox
        '
        Me.CurpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "curp", True))
        Me.CurpTextBox.Enabled = False
        Me.CurpTextBox.Location = New System.Drawing.Point(274, 54)
        Me.CurpTextBox.Name = "CurpTextBox"
        Me.CurpTextBox.Size = New System.Drawing.Size(215, 20)
        Me.CurpTextBox.TabIndex = 6
        '
        'ExtranjeroCheckBox
        '
        Me.ExtranjeroCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CXP_ProveedoresBindingSource, "extranjero", True))
        Me.ExtranjeroCheckBox.Enabled = False
        Me.ExtranjeroCheckBox.Location = New System.Drawing.Point(111, 78)
        Me.ExtranjeroCheckBox.Name = "ExtranjeroCheckBox"
        Me.ExtranjeroCheckBox.Size = New System.Drawing.Size(36, 24)
        Me.ExtranjeroCheckBox.TabIndex = 8
        Me.ExtranjeroCheckBox.UseVisualStyleBackColor = True
        '
        'NitTextBox
        '
        Me.NitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "nit", True))
        Me.NitTextBox.Enabled = False
        Me.NitTextBox.Location = New System.Drawing.Point(410, 80)
        Me.NitTextBox.Name = "NitTextBox"
        Me.NitTextBox.Size = New System.Drawing.Size(79, 20)
        Me.NitTextBox.TabIndex = 10
        '
        'RelacionadoCheckBox
        '
        Me.RelacionadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CXP_ProveedoresBindingSource, "relacionado", True))
        Me.RelacionadoCheckBox.Enabled = False
        Me.RelacionadoCheckBox.Location = New System.Drawing.Point(111, 265)
        Me.RelacionadoCheckBox.Name = "RelacionadoCheckBox"
        Me.RelacionadoCheckBox.Size = New System.Drawing.Size(44, 24)
        Me.RelacionadoCheckBox.TabIndex = 14
        Me.RelacionadoCheckBox.UseVisualStyleBackColor = True
        '
        'MontoMaxTransaccionTextBox
        '
        Me.MontoMaxTransaccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "montoMaxTransaccion", True))
        Me.MontoMaxTransaccionTextBox.Enabled = False
        Me.MontoMaxTransaccionTextBox.Location = New System.Drawing.Point(378, 157)
        Me.MontoMaxTransaccionTextBox.Name = "MontoMaxTransaccionTextBox"
        Me.MontoMaxTransaccionTextBox.Size = New System.Drawing.Size(111, 20)
        Me.MontoMaxTransaccionTextBox.TabIndex = 20
        '
        'FechaRegistroDateTimePicker
        '
        Me.FechaRegistroDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CXP_ProveedoresBindingSource, "fechaRegistro", True))
        Me.FechaRegistroDateTimePicker.Enabled = False
        Me.FechaRegistroDateTimePicker.Location = New System.Drawing.Point(111, 157)
        Me.FechaRegistroDateTimePicker.Name = "FechaRegistroDateTimePicker"
        Me.FechaRegistroDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaRegistroDateTimePicker.TabIndex = 24
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "mail", True))
        Me.MailTextBox.Enabled = False
        Me.MailTextBox.Location = New System.Drawing.Point(111, 105)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(378, 20)
        Me.MailTextBox.TabIndex = 26
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ProveedoresBindingSource, "idSucursal", True))
        Me.cmbSucursal.DataSource = Me.CXPSucursalesBindingSource
        Me.cmbSucursal.DisplayMember = "nombreSucursal"
        Me.cmbSucursal.Enabled = False
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(337, 184)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(152, 21)
        Me.cmbSucursal.TabIndex = 29
        Me.cmbSucursal.ValueMember = "idSucursal"
        '
        'CXPSucursalesBindingSource
        '
        Me.CXPSucursalesBindingSource.DataMember = "CXP_Sucursales"
        Me.CXPSucursalesBindingSource.DataSource = Me.DsProduction
        '
        'cmbCuentaContable
        '
        Me.cmbCuentaContable.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ProveedoresBindingSource, "cuentaContablePagar", True))
        Me.cmbCuentaContable.DataSource = Me.CXPCuentasContablesBindingSource
        Me.cmbCuentaContable.DisplayMember = "nombre"
        Me.cmbCuentaContable.Enabled = False
        Me.cmbCuentaContable.FormattingEnabled = True
        Me.cmbCuentaContable.Location = New System.Drawing.Point(111, 130)
        Me.cmbCuentaContable.Name = "cmbCuentaContable"
        Me.cmbCuentaContable.Size = New System.Drawing.Size(378, 21)
        Me.cmbCuentaContable.TabIndex = 30
        Me.cmbCuentaContable.ValueMember = "idCuentaContable"
        '
        'CXPCuentasContablesBindingSource
        '
        Me.CXPCuentasContablesBindingSource.DataMember = "CXP_CuentasContables"
        Me.CXPCuentasContablesBindingSource.DataSource = Me.DsProduction
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(416, 288)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ProveedoresBindingSource, "empresa", True))
        Me.ComboBox1.DataSource = Me.CXPEmpresasBindingSource
        Me.ComboBox1.DisplayMember = "razonSocial"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(111, 184)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(157, 21)
        Me.ComboBox1.TabIndex = 32
        Me.ComboBox1.ValueMember = "idEmpresas"
        '
        'CXPEmpresasBindingSource
        '
        Me.CXPEmpresasBindingSource.DataMember = "CXP_Empresas"
        Me.CXPEmpresasBindingSource.DataSource = Me.DsProduction
        '
        'CXP_EmpresasTableAdapter
        '
        Me.CXP_EmpresasTableAdapter.ClearBeforeFill = True
        '
        'cmbNacionalida
        '
        Me.cmbNacionalida.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ProveedoresBindingSource, "nacionalidad", True))
        Me.cmbNacionalida.DataSource = Me.CXPcPaisBindingSource
        Me.cmbNacionalida.DisplayMember = "nacionalidad"
        Me.cmbNacionalida.Enabled = False
        Me.cmbNacionalida.FormattingEnabled = True
        Me.cmbNacionalida.Location = New System.Drawing.Point(223, 80)
        Me.cmbNacionalida.Name = "cmbNacionalida"
        Me.cmbNacionalida.Size = New System.Drawing.Size(146, 21)
        Me.cmbNacionalida.TabIndex = 33
        Me.cmbNacionalida.ValueMember = "c_Pais"
        '
        'CXPcPaisBindingSource
        '
        Me.CXPcPaisBindingSource.DataMember = "CXP_c_Pais"
        Me.CXPcPaisBindingSource.DataSource = Me.DsProduction
        '
        'CXP_c_PaisTableAdapter
        '
        Me.CXP_c_PaisTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ProveedoresBindingSource, "banco", True))
        Me.ComboBox2.DataSource = Me.CXPBancosBindingSource
        Me.ComboBox2.DisplayMember = "razonSocial"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(111, 212)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(378, 21)
        Me.ComboBox2.TabIndex = 34
        Me.ComboBox2.ValueMember = "claveBanco"
        '
        'CuentaBancariaLabel
        '
        CuentaBancariaLabel.AutoSize = True
        CuentaBancariaLabel.Location = New System.Drawing.Point(17, 242)
        CuentaBancariaLabel.Name = "CuentaBancariaLabel"
        CuentaBancariaLabel.Size = New System.Drawing.Size(89, 13)
        CuentaBancariaLabel.TabIndex = 35
        CuentaBancariaLabel.Text = "Cuenta Bancaria:"
        '
        'CuentaBancariaTextBox
        '
        Me.CuentaBancariaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "cuentaBancaria", True))
        Me.CuentaBancariaTextBox.Location = New System.Drawing.Point(111, 239)
        Me.CuentaBancariaTextBox.Name = "CuentaBancariaTextBox"
        Me.CuentaBancariaTextBox.Size = New System.Drawing.Size(166, 20)
        Me.CuentaBancariaTextBox.TabIndex = 36
        '
        'ClabeLabel
        '
        ClabeLabel.AutoSize = True
        ClabeLabel.Location = New System.Drawing.Point(283, 242)
        ClabeLabel.Name = "ClabeLabel"
        ClabeLabel.Size = New System.Drawing.Size(37, 13)
        ClabeLabel.TabIndex = 36
        ClabeLabel.Text = "Clabe:"
        '
        'ClabeTextBox
        '
        Me.ClabeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "Clabe", True))
        Me.ClabeTextBox.Location = New System.Drawing.Point(326, 239)
        Me.ClabeTextBox.Name = "ClabeTextBox"
        Me.ClabeTextBox.Size = New System.Drawing.Size(165, 20)
        Me.ClabeTextBox.TabIndex = 37
        '
        'CXPBancosBindingSource
        '
        Me.CXPBancosBindingSource.DataMember = "CXP_Bancos"
        Me.CXPBancosBindingSource.DataSource = Me.DsProduction
        '
        'CXP_BancosTableAdapter
        '
        Me.CXP_BancosTableAdapter.ClearBeforeFill = True
        '
        'frmContProveedoresClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 325)
        Me.Controls.Add(ClabeLabel)
        Me.Controls.Add(Me.ClabeTextBox)
        Me.Controls.Add(CuentaBancariaLabel)
        Me.Controls.Add(Me.CuentaBancariaTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.cmbNacionalida)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cmbCuentaContable)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(EmpresaLabel)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.Controls.Add(FechaRegistroLabel)
        Me.Controls.Add(Me.FechaRegistroDateTimePicker)
        Me.Controls.Add(NacionalidadLabel)
        Me.Controls.Add(MontoMaxTransaccionLabel)
        Me.Controls.Add(Me.MontoMaxTransaccionTextBox)
        Me.Controls.Add(CuentaContablePagarLabel)
        Me.Controls.Add(RelacionadoLabel)
        Me.Controls.Add(Me.RelacionadoCheckBox)
        Me.Controls.Add(IdSucursalLabel)
        Me.Controls.Add(NitLabel)
        Me.Controls.Add(Me.NitTextBox)
        Me.Controls.Add(ExtranjeroLabel)
        Me.Controls.Add(Me.ExtranjeroCheckBox)
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
        CType(Me.CXPSucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPCuentasContablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPEmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcPaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPBancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ExtranjeroCheckBox As CheckBox
    Friend WithEvents NitTextBox As TextBox
    Friend WithEvents RelacionadoCheckBox As CheckBox
    Friend WithEvents MontoMaxTransaccionTextBox As TextBox
    Friend WithEvents FechaRegistroDateTimePicker As DateTimePicker
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents CXP_SucursalesTableAdapter As dsProductionTableAdapters.CXP_SucursalesTableAdapter
    Friend WithEvents cmbSucursal As ComboBox
    Friend WithEvents CXPSucursalesBindingSource As BindingSource
    Friend WithEvents CXP_CuentasContablesTableAdapter As dsProductionTableAdapters.CXP_CuentasContablesTableAdapter
    Friend WithEvents cmbCuentaContable As ComboBox
    Friend WithEvents CXPCuentasContablesBindingSource As BindingSource
    Friend WithEvents btnSalir As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CXPEmpresasBindingSource As BindingSource
    Friend WithEvents CXP_EmpresasTableAdapter As dsProductionTableAdapters.CXP_EmpresasTableAdapter
    Friend WithEvents cmbNacionalida As ComboBox
    Friend WithEvents CXPcPaisBindingSource As BindingSource
    Friend WithEvents CXP_c_PaisTableAdapter As dsProductionTableAdapters.CXP_c_PaisTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CuentaBancariaTextBox As TextBox
    Friend WithEvents ClabeTextBox As TextBox
    Friend WithEvents CXPBancosBindingSource As BindingSource
    Friend WithEvents CXP_BancosTableAdapter As dsProductionTableAdapters.CXP_BancosTableAdapter
End Class
