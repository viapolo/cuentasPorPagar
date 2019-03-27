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
        Dim CuentaEgresoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConceptos))
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_ConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_ConceptosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ConceptosTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_ConceptosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CXP_ConceptosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.cmbCuentaEgreso = New System.Windows.Forms.ComboBox()
        Me.CXPCuentasContablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_CuentasContablesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_CuentasContablesTableAdapter()
        Me.cmbImpuesto = New System.Windows.Forms.ComboBox()
        Me.CXPImpuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbTipoProducto = New System.Windows.Forms.ComboBox()
        Me.CXPTipoGastoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction1 = New cuentasPorPagar.dsProduction()
        Me.CXP_ImpuestoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ImpuestoTableAdapter()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.CXP_TipoGastoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_TipoGastoTableAdapter()
        NombreLabel = New System.Windows.Forms.Label()
        ImpuestoLabel = New System.Windows.Forms.Label()
        TipoProductoLabel = New System.Windows.Forms.Label()
        CuentaEgresoLabel = New System.Windows.Forms.Label()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ConceptosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_ConceptosBindingNavigator.SuspendLayout()
        CType(Me.CXPCuentasContablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPImpuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPTipoGastoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(14, 42)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(56, 13)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "Concepto:"
        '
        'ImpuestoLabel
        '
        ImpuestoLabel.AutoSize = True
        ImpuestoLabel.Location = New System.Drawing.Point(18, 68)
        ImpuestoLabel.Name = "ImpuestoLabel"
        ImpuestoLabel.Size = New System.Drawing.Size(53, 13)
        ImpuestoLabel.TabIndex = 7
        ImpuestoLabel.Text = "Impuesto:"
        '
        'TipoProductoLabel
        '
        TipoProductoLabel.AutoSize = True
        TipoProductoLabel.Location = New System.Drawing.Point(362, 68)
        TipoProductoLabel.Name = "TipoProductoLabel"
        TipoProductoLabel.Size = New System.Drawing.Size(92, 13)
        TipoProductoLabel.TabIndex = 15
        TipoProductoLabel.Text = "Tipo de Producto:"
        '
        'CuentaEgresoLabel
        '
        CuentaEgresoLabel.AutoSize = True
        CuentaEgresoLabel.Location = New System.Drawing.Point(374, 42)
        CuentaEgresoLabel.Name = "CuentaEgresoLabel"
        CuentaEgresoLabel.Size = New System.Drawing.Size(80, 13)
        CuentaEgresoLabel.TabIndex = 16
        CuentaEgresoLabel.Text = "Cuenta Egreso:"
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
        Me.TableAdapterManager.CXP_TipoGastoTableAdapter = Nothing
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
        Me.CXP_ConceptosBindingNavigator.Size = New System.Drawing.Size(774, 25)
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
        Me.NombreTextBox.Location = New System.Drawing.Point(76, 39)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(280, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'cmbCuentaEgreso
        '
        Me.cmbCuentaEgreso.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ConceptosBindingSource, "cuentaEgreso", True))
        Me.cmbCuentaEgreso.DataSource = Me.CXPCuentasContablesBindingSource
        Me.cmbCuentaEgreso.DisplayMember = "nombre"
        Me.cmbCuentaEgreso.FormattingEnabled = True
        Me.cmbCuentaEgreso.Location = New System.Drawing.Point(460, 38)
        Me.cmbCuentaEgreso.Name = "cmbCuentaEgreso"
        Me.cmbCuentaEgreso.Size = New System.Drawing.Size(294, 21)
        Me.cmbCuentaEgreso.TabIndex = 17
        Me.cmbCuentaEgreso.ValueMember = "idCuentaContable"
        '
        'CXPCuentasContablesBindingSource
        '
        Me.CXPCuentasContablesBindingSource.DataMember = "CXP_CuentasContables"
        Me.CXPCuentasContablesBindingSource.DataSource = Me.DsProduction
        Me.CXPCuentasContablesBindingSource.Filter = "tipo='Gasto'"
        '
        'CXP_CuentasContablesTableAdapter
        '
        Me.CXP_CuentasContablesTableAdapter.ClearBeforeFill = True
        '
        'cmbImpuesto
        '
        Me.cmbImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ConceptosBindingSource, "impuesto", True))
        Me.cmbImpuesto.DataSource = Me.CXPImpuestoBindingSource
        Me.cmbImpuesto.DisplayMember = "descripcion"
        Me.cmbImpuesto.FormattingEnabled = True
        Me.cmbImpuesto.Location = New System.Drawing.Point(76, 65)
        Me.cmbImpuesto.Name = "cmbImpuesto"
        Me.cmbImpuesto.Size = New System.Drawing.Size(280, 21)
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
        Me.cmbTipoProducto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ConceptosBindingSource, "tipoProducto", True))
        Me.cmbTipoProducto.DataSource = Me.CXPTipoGastoBindingSource
        Me.cmbTipoProducto.DisplayMember = "nombre"
        Me.cmbTipoProducto.FormattingEnabled = True
        Me.cmbTipoProducto.Location = New System.Drawing.Point(460, 65)
        Me.cmbTipoProducto.Name = "cmbTipoProducto"
        Me.cmbTipoProducto.Size = New System.Drawing.Size(294, 21)
        Me.cmbTipoProducto.TabIndex = 19
        Me.cmbTipoProducto.ValueMember = "idTipoGasto"
        '
        'CXPTipoGastoBindingSource
        '
        Me.CXPTipoGastoBindingSource.DataMember = "CXP_TipoGasto"
        Me.CXPTipoGastoBindingSource.DataSource = Me.DsProduction1
        '
        'DsProduction1
        '
        Me.DsProduction1.DataSetName = "dsProduction"
        Me.DsProduction1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_ImpuestoTableAdapter
        '
        Me.CXP_ImpuestoTableAdapter.ClearBeforeFill = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(679, 92)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'CXP_TipoGastoTableAdapter
        '
        Me.CXP_TipoGastoTableAdapter.ClearBeforeFill = True
        '
        'frmConceptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 138)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cmbTipoProducto)
        Me.Controls.Add(Me.cmbImpuesto)
        Me.Controls.Add(Me.cmbCuentaEgreso)
        Me.Controls.Add(CuentaEgresoLabel)
        Me.Controls.Add(TipoProductoLabel)
        Me.Controls.Add(ImpuestoLabel)
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
        CType(Me.CXPCuentasContablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPImpuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPTipoGastoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DsProduction1 As dsProduction
    Friend WithEvents CXPTipoGastoBindingSource As BindingSource
    Friend WithEvents CXP_TipoGastoTableAdapter As dsProductionTableAdapters.CXP_TipoGastoTableAdapter
End Class
