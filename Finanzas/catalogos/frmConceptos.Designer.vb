<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConceptos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConceptos))
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CuentasCargoLabel As System.Windows.Forms.Label
        Dim CuentasAbonoLabel As System.Windows.Forms.Label
        Dim ImpuestoLabel As System.Windows.Forms.Label
        Dim UnidadSatLabel As System.Windows.Forms.Label
        Dim ClaveSatLabel As System.Windows.Forms.Label
        Dim UnidadComLabel As System.Windows.Forms.Label
        Dim TipoProductoLabel As System.Windows.Forms.Label
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_ConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_ConceptosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ConceptosTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_ConceptosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CXP_ConceptosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadSatTextBox = New System.Windows.Forms.TextBox()
        Me.ClaveSatTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadComTextBox = New System.Windows.Forms.TextBox()
        Me.TipoProductoTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        NombreLabel = New System.Windows.Forms.Label()
        CuentasCargoLabel = New System.Windows.Forms.Label()
        CuentasAbonoLabel = New System.Windows.Forms.Label()
        ImpuestoLabel = New System.Windows.Forms.Label()
        UnidadSatLabel = New System.Windows.Forms.Label()
        ClaveSatLabel = New System.Windows.Forms.Label()
        UnidadComLabel = New System.Windows.Forms.Label()
        TipoProductoLabel = New System.Windows.Forms.Label()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ConceptosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_ConceptosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_ConceptosBindingSource
        '
        Me.CXP_ConceptosBindingSource.DataMember = "CXP_Conceptos"
        Me.CXP_ConceptosBindingSource.DataSource = Me.DsProduction
        '
        'CXP_ConceptosTableAdapter
        '
        Me.CXP_ConceptosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Me.CXP_ConceptosTableAdapter
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.CXP_ConceptosBindingNavigator.Size = New System.Drawing.Size(819, 25)
        Me.CXP_ConceptosBindingNavigator.TabIndex = 0
        Me.CXP_ConceptosBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CXP_ConceptosBindingNavigatorSaveItem
        '
        Me.CXP_ConceptosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_ConceptosBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_ConceptosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_ConceptosBindingNavigatorSaveItem.Name = "CXP_ConceptosBindingNavigatorSaveItem"
        Me.CXP_ConceptosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CXP_ConceptosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(55, 42)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ConceptosBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(106, 39)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(280, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'CuentasCargoLabel
        '
        CuentasCargoLabel.AutoSize = True
        CuentasCargoLabel.Location = New System.Drawing.Point(21, 68)
        CuentasCargoLabel.Name = "CuentasCargoLabel"
        CuentasCargoLabel.Size = New System.Drawing.Size(79, 13)
        CuentasCargoLabel.TabIndex = 3
        CuentasCargoLabel.Text = "cuentas Cargo:"
        '
        'CuentasAbonoLabel
        '
        CuentasAbonoLabel.AutoSize = True
        CuentasAbonoLabel.Location = New System.Drawing.Point(402, 68)
        CuentasAbonoLabel.Name = "CuentasAbonoLabel"
        CuentasAbonoLabel.Size = New System.Drawing.Size(82, 13)
        CuentasAbonoLabel.TabIndex = 5
        CuentasAbonoLabel.Text = "cuentas Abono:"
        '
        'ImpuestoLabel
        '
        ImpuestoLabel.AutoSize = True
        ImpuestoLabel.Location = New System.Drawing.Point(48, 94)
        ImpuestoLabel.Name = "ImpuestoLabel"
        ImpuestoLabel.Size = New System.Drawing.Size(52, 13)
        ImpuestoLabel.TabIndex = 7
        ImpuestoLabel.Text = "impuesto:"
        '
        'UnidadSatLabel
        '
        UnidadSatLabel.AutoSize = True
        UnidadSatLabel.Location = New System.Drawing.Point(39, 123)
        UnidadSatLabel.Name = "UnidadSatLabel"
        UnidadSatLabel.Size = New System.Drawing.Size(61, 13)
        UnidadSatLabel.TabIndex = 9
        UnidadSatLabel.Text = "unidad Sat:"
        '
        'UnidadSatTextBox
        '
        Me.UnidadSatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ConceptosBindingSource, "unidadSat", True))
        Me.UnidadSatTextBox.Location = New System.Drawing.Point(106, 120)
        Me.UnidadSatTextBox.Name = "UnidadSatTextBox"
        Me.UnidadSatTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UnidadSatTextBox.TabIndex = 10
        '
        'ClaveSatLabel
        '
        ClaveSatLabel.AutoSize = True
        ClaveSatLabel.Location = New System.Drawing.Point(225, 123)
        ClaveSatLabel.Name = "ClaveSatLabel"
        ClaveSatLabel.Size = New System.Drawing.Size(55, 13)
        ClaveSatLabel.TabIndex = 11
        ClaveSatLabel.Text = "clave Sat:"
        '
        'ClaveSatTextBox
        '
        Me.ClaveSatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ConceptosBindingSource, "claveSat", True))
        Me.ClaveSatTextBox.Location = New System.Drawing.Point(286, 120)
        Me.ClaveSatTextBox.Name = "ClaveSatTextBox"
        Me.ClaveSatTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClaveSatTextBox.TabIndex = 12
        '
        'UnidadComLabel
        '
        UnidadComLabel.AutoSize = True
        UnidadComLabel.Location = New System.Drawing.Point(401, 123)
        UnidadComLabel.Name = "UnidadComLabel"
        UnidadComLabel.Size = New System.Drawing.Size(66, 13)
        UnidadComLabel.TabIndex = 13
        UnidadComLabel.Text = "unidad Com:"
        '
        'UnidadComTextBox
        '
        Me.UnidadComTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ConceptosBindingSource, "unidadCom", True))
        Me.UnidadComTextBox.Location = New System.Drawing.Point(473, 120)
        Me.UnidadComTextBox.Name = "UnidadComTextBox"
        Me.UnidadComTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UnidadComTextBox.TabIndex = 14
        '
        'TipoProductoLabel
        '
        TipoProductoLabel.AutoSize = True
        TipoProductoLabel.Location = New System.Drawing.Point(605, 123)
        TipoProductoLabel.Name = "TipoProductoLabel"
        TipoProductoLabel.Size = New System.Drawing.Size(73, 13)
        TipoProductoLabel.TabIndex = 15
        TipoProductoLabel.Text = "tipo Producto:"
        '
        'TipoProductoTextBox
        '
        Me.TipoProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ConceptosBindingSource, "tipoProducto", True))
        Me.TipoProductoTextBox.Location = New System.Drawing.Point(684, 120)
        Me.TipoProductoTextBox.Name = "TipoProductoTextBox"
        Me.TipoProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TipoProductoTextBox.TabIndex = 16
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(106, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(280, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'frmConceptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 391)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(TipoProductoLabel)
        Me.Controls.Add(Me.TipoProductoTextBox)
        Me.Controls.Add(UnidadComLabel)
        Me.Controls.Add(Me.UnidadComTextBox)
        Me.Controls.Add(ClaveSatLabel)
        Me.Controls.Add(Me.ClaveSatTextBox)
        Me.Controls.Add(UnidadSatLabel)
        Me.Controls.Add(Me.UnidadSatTextBox)
        Me.Controls.Add(ImpuestoLabel)
        Me.Controls.Add(CuentasAbonoLabel)
        Me.Controls.Add(CuentasCargoLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.CXP_ConceptosBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmConceptos"
        Me.Text = "Conceptos"
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_ConceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_ConceptosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_ConceptosBindingNavigator.ResumeLayout(False)
        Me.CXP_ConceptosBindingNavigator.PerformLayout()
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
    Friend WithEvents UnidadSatTextBox As TextBox
    Friend WithEvents ClaveSatTextBox As TextBox
    Friend WithEvents UnidadComTextBox As TextBox
    Friend WithEvents TipoProductoTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
