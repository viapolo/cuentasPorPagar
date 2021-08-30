<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogoInversiones
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim IdCuentaContableLabel As System.Windows.Forms.Label
        Dim IdCuentaBancariaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatalogoInversiones))
        Me.CXP_CuentasInversionesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CXP_CuentasInversionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CXP_CuentasInversionesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Contpaq = New cuentasPorPagar.contpaq()
        Me.CXPCuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasTableAdapter = New cuentasPorPagar.contpaqTableAdapters.CuentasTableAdapter()
        Me.CXP_CuentasInversionesTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_CuentasInversionesTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager()
        Me.CXP_CuentasBancariasTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_CuentasBancariasTableAdapter()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.cmbCuentaDestino = New System.Windows.Forms.ComboBox()
        Me.CXPCuentasBancariasProvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsConfiguracion = New cuentasPorPagar.dsConfiguracion()
        Me.CXP_CuentasBancariasProvTableAdapter = New cuentasPorPagar.dsConfiguracionTableAdapters.CXP_CuentasBancariasProvTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tltTipoFira = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbTipoFira = New System.Windows.Forms.ComboBox()
        NombreLabel = New System.Windows.Forms.Label()
        IdCuentaContableLabel = New System.Windows.Forms.Label()
        IdCuentaBancariaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.CXP_CuentasInversionesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_CuentasInversionesBindingNavigator.SuspendLayout()
        CType(Me.CXP_CuentasInversionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPCuentasBancariasProvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsConfiguracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(101, 40)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'IdCuentaContableLabel
        '
        IdCuentaContableLabel.AutoSize = True
        IdCuentaContableLabel.Location = New System.Drawing.Point(59, 66)
        IdCuentaContableLabel.Name = "IdCuentaContableLabel"
        IdCuentaContableLabel.Size = New System.Drawing.Size(89, 13)
        IdCuentaContableLabel.TabIndex = 4
        IdCuentaContableLabel.Text = "Cuenta Contable:"
        '
        'IdCuentaBancariaLabel
        '
        IdCuentaBancariaLabel.AutoSize = True
        IdCuentaBancariaLabel.Location = New System.Drawing.Point(30, 93)
        IdCuentaBancariaLabel.Name = "IdCuentaBancariaLabel"
        IdCuentaBancariaLabel.Size = New System.Drawing.Size(120, 13)
        IdCuentaBancariaLabel.TabIndex = 6
        IdCuentaBancariaLabel.Text = "Cuenta bancaria origen:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(25, 120)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(125, 13)
        Label1.TabIndex = 10
        Label1.Text = "Cuenta bancaria destino:"
        '
        'CXP_CuentasInversionesBindingNavigator
        '
        Me.CXP_CuentasInversionesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_CuentasInversionesBindingNavigator.BindingSource = Me.CXP_CuentasInversionesBindingSource
        Me.CXP_CuentasInversionesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_CuentasInversionesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_CuentasInversionesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_CuentasInversionesBindingNavigatorSaveItem})
        Me.CXP_CuentasInversionesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_CuentasInversionesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_CuentasInversionesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_CuentasInversionesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_CuentasInversionesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_CuentasInversionesBindingNavigator.Name = "CXP_CuentasInversionesBindingNavigator"
        Me.CXP_CuentasInversionesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_CuentasInversionesBindingNavigator.Size = New System.Drawing.Size(552, 25)
        Me.CXP_CuentasInversionesBindingNavigator.TabIndex = 0
        Me.CXP_CuentasInversionesBindingNavigator.Text = "BindingNavigator1"
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
        'CXP_CuentasInversionesBindingSource
        '
        Me.CXP_CuentasInversionesBindingSource.DataMember = "CXP_CuentasInversiones"
        Me.CXP_CuentasInversionesBindingSource.DataSource = Me.DsContabilidad
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
        'CXP_CuentasInversionesBindingNavigatorSaveItem
        '
        Me.CXP_CuentasInversionesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_CuentasInversionesBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_CuentasInversionesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_CuentasInversionesBindingNavigatorSaveItem.Name = "CXP_CuentasInversionesBindingNavigatorSaveItem"
        Me.CXP_CuentasInversionesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_CuentasInversionesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "Cuentas"
        Me.CuentasBindingSource.DataSource = Me.Contpaq
        '
        'Contpaq
        '
        Me.Contpaq.DataSetName = "contpaq"
        Me.Contpaq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXPCuentasBancariasBindingSource
        '
        Me.CXPCuentasBancariasBindingSource.DataMember = "CXP_CuentasBancarias"
        Me.CXPCuentasBancariasBindingSource.DataSource = Me.DsContabilidad
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'CXP_CuentasInversionesTableAdapter
        '
        Me.CXP_CuentasInversionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONT_TiposDeCambioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ComprobGtos1TableAdapter = Nothing
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Me.CXP_CuentasBancariasTableAdapter
        Me.TableAdapterManager.CXP_CuentasInversionesTableAdapter = Me.CXP_CuentasInversionesTableAdapter
        Me.TableAdapterManager.CXP_EstatusTableAdapter = Nothing
        Me.TableAdapterManager.CXP_InversionesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PagosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PagosTesoreriaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PeriodosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PolizaMovimientosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoDeSolicitudTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_CuentasBancariasTableAdapter
        '
        Me.CXP_CuentasBancariasTableAdapter.ClearBeforeFill = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(433, 182)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(107, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_CuentasInversionesBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(154, 37)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(386, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_CuentasInversionesBindingSource, "idCuentaContable", True))
        Me.ComboBox1.DataSource = Me.CuentasBindingSource
        Me.ComboBox1.DisplayMember = "nCuenta"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(154, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(386, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.ValueMember = "Id"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_CuentasInversionesBindingSource, "idCuentaBancaria", True))
        Me.ComboBox2.DataSource = Me.CXPCuentasBancariasBindingSource
        Me.ComboBox2.DisplayMember = "nombre"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(154, 90)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(386, 21)
        Me.ComboBox2.TabIndex = 8
        Me.ComboBox2.ValueMember = "idCuentaBancaria"
        '
        'cmbCuentaDestino
        '
        Me.cmbCuentaDestino.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_CuentasInversionesBindingSource, "idCuentaDestino", True))
        Me.cmbCuentaDestino.DataSource = Me.CXPCuentasBancariasProvBindingSource
        Me.cmbCuentaDestino.DisplayMember = "descripcion"
        Me.cmbCuentaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCuentaDestino.FormattingEnabled = True
        Me.cmbCuentaDestino.Location = New System.Drawing.Point(154, 117)
        Me.cmbCuentaDestino.Name = "cmbCuentaDestino"
        Me.cmbCuentaDestino.Size = New System.Drawing.Size(386, 21)
        Me.cmbCuentaDestino.TabIndex = 9
        Me.cmbCuentaDestino.ValueMember = "idCuentas"
        '
        'CXPCuentasBancariasProvBindingSource
        '
        Me.CXPCuentasBancariasProvBindingSource.DataMember = "CXP_CuentasBancariasProv"
        Me.CXPCuentasBancariasProvBindingSource.DataSource = Me.DsConfiguracion
        '
        'DsConfiguracion
        '
        Me.DsConfiguracion.DataSetName = "dsConfiguracion"
        Me.DsConfiguracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_CuentasBancariasProvTableAdapter
        '
        Me.CXP_CuentasBancariasProvTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tipo Fira:"
        '
        'cmbTipoFira
        '
        Me.cmbTipoFira.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_CuentasInversionesBindingSource, "tipoFira", True))
        Me.cmbTipoFira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoFira.FormattingEnabled = True
        Me.cmbTipoFira.Items.AddRange(New Object() {"NAPL", "FIRA", "GLIQ"})
        Me.cmbTipoFira.Location = New System.Drawing.Point(154, 144)
        Me.cmbTipoFira.Name = "cmbTipoFira"
        Me.cmbTipoFira.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoFira.TabIndex = 13
        '
        'frmCatalogoInversiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 217)
        Me.Controls.Add(Me.cmbTipoFira)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.cmbCuentaDestino)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(IdCuentaBancariaLabel)
        Me.Controls.Add(IdCuentaContableLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CXP_CuentasInversionesBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCatalogoInversiones"
        Me.Text = "Catálogo cuentas de inversiones"
        CType(Me.CXP_CuentasInversionesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_CuentasInversionesBindingNavigator.ResumeLayout(False)
        Me.CXP_CuentasInversionesBindingNavigator.PerformLayout()
        CType(Me.CXP_CuentasInversionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPCuentasBancariasProvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsConfiguracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsContabilidad As dsContabilidad
    Friend WithEvents CXP_CuentasInversionesBindingSource As BindingSource
    Friend WithEvents CXP_CuentasInversionesTableAdapter As dsContabilidadTableAdapters.CXP_CuentasInversionesTableAdapter
    Friend WithEvents TableAdapterManager As dsContabilidadTableAdapters.TableAdapterManager
    Friend WithEvents CXP_CuentasInversionesBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_CuentasInversionesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Contpaq As contpaq
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents CuentasTableAdapter As contpaqTableAdapters.CuentasTableAdapter
    Friend WithEvents CXP_CuentasBancariasTableAdapter As dsContabilidadTableAdapters.CXP_CuentasBancariasTableAdapter
    Friend WithEvents CXPCuentasBancariasBindingSource As BindingSource
    Friend WithEvents btnSalir As Button
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents cmbCuentaDestino As ComboBox
    Friend WithEvents DsConfiguracion As dsConfiguracion
    Friend WithEvents CXPCuentasBancariasProvBindingSource As BindingSource
    Friend WithEvents CXP_CuentasBancariasProvTableAdapter As dsConfiguracionTableAdapters.CXP_CuentasBancariasProvTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents tltTipoFira As ToolTip
    Friend WithEvents cmbTipoFira As ComboBox
End Class
