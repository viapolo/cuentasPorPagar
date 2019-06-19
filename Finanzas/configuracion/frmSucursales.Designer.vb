<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSucursales
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
        Dim NombreSucursalLabel As System.Windows.Forms.Label
        Dim Id_SucursalLabel As System.Windows.Forms.Label
        Dim IdSucLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSucursales))
        Me.CXP_SucursalesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CXP_SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CXP_SucursalesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_SucursalTextBox = New System.Windows.Forms.TextBox()
        Me.IdSucTextBox = New System.Windows.Forms.TextBox()
        Me.CXP_SucursalesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_SucursalesTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SucursalesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.SucursalesTableAdapter()
        NombreSucursalLabel = New System.Windows.Forms.Label()
        Id_SucursalLabel = New System.Windows.Forms.Label()
        IdSucLabel = New System.Windows.Forms.Label()
        CType(Me.CXP_SucursalesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_SucursalesBindingNavigator.SuspendLayout()
        CType(Me.CXP_SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreSucursalLabel
        '
        NombreSucursalLabel.AutoSize = True
        NombreSucursalLabel.Location = New System.Drawing.Point(6, 48)
        NombreSucursalLabel.Name = "NombreSucursalLabel"
        NombreSucursalLabel.Size = New System.Drawing.Size(117, 13)
        NombreSucursalLabel.TabIndex = 1
        NombreSucursalLabel.Text = "Nombre de la Sucursal:"
        '
        'Id_SucursalLabel
        '
        Id_SucursalLabel.AutoSize = True
        Id_SucursalLabel.Location = New System.Drawing.Point(55, 74)
        Id_SucursalLabel.Name = "Id_SucursalLabel"
        Id_SucursalLabel.Size = New System.Drawing.Size(68, 13)
        Id_SucursalLabel.TabIndex = 3
        Id_SucursalLabel.Text = "Id alfebetico:"
        '
        'IdSucLabel
        '
        IdSucLabel.AutoSize = True
        IdSucLabel.Location = New System.Drawing.Point(58, 100)
        IdSucLabel.Name = "IdSucLabel"
        IdSucLabel.Size = New System.Drawing.Size(65, 13)
        IdSucLabel.TabIndex = 5
        IdSucLabel.Text = "Id numerico:"
        '
        'CXP_SucursalesBindingNavigator
        '
        Me.CXP_SucursalesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_SucursalesBindingNavigator.BindingSource = Me.CXP_SucursalesBindingSource
        Me.CXP_SucursalesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_SucursalesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_SucursalesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_SucursalesBindingNavigatorSaveItem})
        Me.CXP_SucursalesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_SucursalesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_SucursalesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_SucursalesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_SucursalesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_SucursalesBindingNavigator.Name = "CXP_SucursalesBindingNavigator"
        Me.CXP_SucursalesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_SucursalesBindingNavigator.Size = New System.Drawing.Size(467, 25)
        Me.CXP_SucursalesBindingNavigator.TabIndex = 0
        Me.CXP_SucursalesBindingNavigator.Text = "BindingNavigator1"
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
        'CXP_SucursalesBindingSource
        '
        Me.CXP_SucursalesBindingSource.DataMember = "CXP_Sucursales"
        Me.CXP_SucursalesBindingSource.DataSource = Me.DsProduction
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
        'CXP_SucursalesBindingNavigatorSaveItem
        '
        Me.CXP_SucursalesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_SucursalesBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_SucursalesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_SucursalesBindingNavigatorSaveItem.Name = "CXP_SucursalesBindingNavigatorSaveItem"
        Me.CXP_SucursalesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_SucursalesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Id_SucursalTextBox
        '
        Me.Id_SucursalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_SucursalesBindingSource, "id_Sucursal", True))
        Me.Id_SucursalTextBox.Location = New System.Drawing.Point(129, 71)
        Me.Id_SucursalTextBox.Name = "Id_SucursalTextBox"
        Me.Id_SucursalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_SucursalTextBox.TabIndex = 4
        '
        'IdSucTextBox
        '
        Me.IdSucTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_SucursalesBindingSource, "idSuc", True))
        Me.IdSucTextBox.Location = New System.Drawing.Point(129, 97)
        Me.IdSucTextBox.Name = "IdSucTextBox"
        Me.IdSucTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdSucTextBox.TabIndex = 6
        '
        'CXP_SucursalesTableAdapter
        '
        Me.CXP_SucursalesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Me.CXP_SucursalesTableAdapter
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoGastoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdiTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_SucursalesBindingSource, "nombreSucursal", True))
        Me.ComboBox1.DataSource = Me.SucursalesBindingSource
        Me.ComboBox1.DisplayMember = "Nombre_Sucursal"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(129, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(304, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.ValueMember = "Nombre_Sucursal"
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.DsProduction
        '
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
        '
        'frmSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 142)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(IdSucLabel)
        Me.Controls.Add(Me.IdSucTextBox)
        Me.Controls.Add(Id_SucursalLabel)
        Me.Controls.Add(Me.Id_SucursalTextBox)
        Me.Controls.Add(NombreSucursalLabel)
        Me.Controls.Add(Me.CXP_SucursalesBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSucursales"
        Me.Text = "Sucursales"
        CType(Me.CXP_SucursalesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_SucursalesBindingNavigator.ResumeLayout(False)
        Me.CXP_SucursalesBindingNavigator.PerformLayout()
        CType(Me.CXP_SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_SucursalesBindingSource As BindingSource
    Friend WithEvents CXP_SucursalesTableAdapter As dsProductionTableAdapters.CXP_SucursalesTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_SucursalesBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_SucursalesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Id_SucursalTextBox As TextBox
    Friend WithEvents IdSucTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SucursalesBindingSource As BindingSource
    Friend WithEvents SucursalesTableAdapter As dsProductionTableAdapters.SucursalesTableAdapter
End Class
