<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiariosFe
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
        Dim IdUsuarioLabel As System.Windows.Forms.Label
        Dim FechaHoraProcesoLabel As System.Windows.Forms.Label
        Dim NumeroDePolizaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiariosFe))
        Me.CXP_DiariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CXP_DiariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CXP_DiariosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.FechaHoraProcesoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NumeroDePolizaTextBox = New System.Windows.Forms.TextBox()
        Me.CXP_DiariosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_DiariosTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.CXPProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_ProveedoresTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ProveedoresTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        IdUsuarioLabel = New System.Windows.Forms.Label()
        FechaHoraProcesoLabel = New System.Windows.Forms.Label()
        NumeroDePolizaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.CXP_DiariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_DiariosBindingNavigator.SuspendLayout()
        CType(Me.CXP_DiariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdUsuarioLabel
        '
        IdUsuarioLabel.AutoSize = True
        IdUsuarioLabel.Location = New System.Drawing.Point(17, 31)
        IdUsuarioLabel.Name = "IdUsuarioLabel"
        IdUsuarioLabel.Size = New System.Drawing.Size(46, 13)
        IdUsuarioLabel.TabIndex = 1
        IdUsuarioLabel.Text = "Usuario:"
        '
        'FechaHoraProcesoLabel
        '
        FechaHoraProcesoLabel.AutoSize = True
        FechaHoraProcesoLabel.Location = New System.Drawing.Point(201, 32)
        FechaHoraProcesoLabel.Name = "FechaHoraProcesoLabel"
        FechaHoraProcesoLabel.Size = New System.Drawing.Size(105, 13)
        FechaHoraProcesoLabel.TabIndex = 3
        FechaHoraProcesoLabel.Text = "fecha Hora Proceso:"
        '
        'NumeroDePolizaLabel
        '
        NumeroDePolizaLabel.AutoSize = True
        NumeroDePolizaLabel.Location = New System.Drawing.Point(532, 31)
        NumeroDePolizaLabel.Name = "NumeroDePolizaLabel"
        NumeroDePolizaLabel.Size = New System.Drawing.Size(93, 13)
        NumeroDePolizaLabel.TabIndex = 5
        NumeroDePolizaLabel.Text = "numero De Poliza:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 57)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(82, 13)
        Label1.TabIndex = 8
        Label1.Text = "RFC proveedor:"
        '
        'CXP_DiariosBindingNavigator
        '
        Me.CXP_DiariosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_DiariosBindingNavigator.BindingSource = Me.CXP_DiariosBindingSource
        Me.CXP_DiariosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_DiariosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_DiariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_DiariosBindingNavigatorSaveItem})
        Me.CXP_DiariosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_DiariosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_DiariosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_DiariosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_DiariosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_DiariosBindingNavigator.Name = "CXP_DiariosBindingNavigator"
        Me.CXP_DiariosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_DiariosBindingNavigator.Size = New System.Drawing.Size(906, 25)
        Me.CXP_DiariosBindingNavigator.TabIndex = 0
        Me.CXP_DiariosBindingNavigator.Text = "BindingNavigator1"
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
        'CXP_DiariosBindingSource
        '
        Me.CXP_DiariosBindingSource.DataMember = "CXP_Diarios"
        Me.CXP_DiariosBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CXP_DiariosBindingNavigatorSaveItem
        '
        Me.CXP_DiariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_DiariosBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_DiariosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_DiariosBindingNavigatorSaveItem.Name = "CXP_DiariosBindingNavigatorSaveItem"
        Me.CXP_DiariosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_DiariosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdUsuarioTextBox
        '
        Me.IdUsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_DiariosBindingSource, "idUsuario", True))
        Me.IdUsuarioTextBox.Location = New System.Drawing.Point(69, 28)
        Me.IdUsuarioTextBox.Name = "IdUsuarioTextBox"
        Me.IdUsuarioTextBox.ReadOnly = True
        Me.IdUsuarioTextBox.Size = New System.Drawing.Size(126, 20)
        Me.IdUsuarioTextBox.TabIndex = 2
        '
        'FechaHoraProcesoDateTimePicker
        '
        Me.FechaHoraProcesoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CXP_DiariosBindingSource, "fechaHoraProceso", True))
        Me.FechaHoraProcesoDateTimePicker.Location = New System.Drawing.Point(312, 28)
        Me.FechaHoraProcesoDateTimePicker.Name = "FechaHoraProcesoDateTimePicker"
        Me.FechaHoraProcesoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaHoraProcesoDateTimePicker.TabIndex = 4
        '
        'NumeroDePolizaTextBox
        '
        Me.NumeroDePolizaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_DiariosBindingSource, "numeroDePoliza", True))
        Me.NumeroDePolizaTextBox.Location = New System.Drawing.Point(631, 28)
        Me.NumeroDePolizaTextBox.Name = "NumeroDePolizaTextBox"
        Me.NumeroDePolizaTextBox.ReadOnly = True
        Me.NumeroDePolizaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroDePolizaTextBox.TabIndex = 6
        '
        'CXP_DiariosTableAdapter
        '
        Me.CXP_DiariosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Me.CXP_DiariosTableAdapter
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
        'cmbProveedor
        '
        Me.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProveedor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_DiariosBindingSource, "idProveedor", True))
        Me.cmbProveedor.DataSource = Me.CXPProveedoresBindingSource
        Me.cmbProveedor.DisplayMember = "rfc"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(100, 54)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(166, 21)
        Me.cmbProveedor.TabIndex = 7
        Me.cmbProveedor.ValueMember = "idProveedor"
        '
        'CXPProveedoresBindingSource
        '
        Me.CXPProveedoresBindingSource.DataMember = "CXP_Proveedores"
        Me.CXPProveedoresBindingSource.DataSource = Me.DsProduction
        '
        'CXP_ProveedoresTableAdapter
        '
        Me.CXP_ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXPProveedoresBindingSource, "razonSocial", True))
        Me.TextBox1.Location = New System.Drawing.Point(272, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(459, 20)
        Me.TextBox1.TabIndex = 9
        '
        'frmDiariosFe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 349)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(NumeroDePolizaLabel)
        Me.Controls.Add(Me.NumeroDePolizaTextBox)
        Me.Controls.Add(FechaHoraProcesoLabel)
        Me.Controls.Add(Me.FechaHoraProcesoDateTimePicker)
        Me.Controls.Add(IdUsuarioLabel)
        Me.Controls.Add(Me.IdUsuarioTextBox)
        Me.Controls.Add(Me.CXP_DiariosBindingNavigator)
        Me.Name = "frmDiariosFe"
        Me.Text = "Diarios"
        CType(Me.CXP_DiariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_DiariosBindingNavigator.ResumeLayout(False)
        Me.CXP_DiariosBindingNavigator.PerformLayout()
        CType(Me.CXP_DiariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_DiariosBindingSource As BindingSource
    Friend WithEvents CXP_DiariosTableAdapter As dsProductionTableAdapters.CXP_DiariosTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_DiariosBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_DiariosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdUsuarioTextBox As TextBox
    Friend WithEvents FechaHoraProcesoDateTimePicker As DateTimePicker
    Friend WithEvents NumeroDePolizaTextBox As TextBox
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents CXPProveedoresBindingSource As BindingSource
    Friend WithEvents CXP_ProveedoresTableAdapter As dsProductionTableAdapters.CXP_ProveedoresTableAdapter
    Friend WithEvents TextBox1 As TextBox
End Class
