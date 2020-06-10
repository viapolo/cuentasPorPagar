<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTesSolicitudesDePago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTesSolicitudesDePago))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Vw_CXP_SugerenciasPagoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Vw_CXP_SugerenciasPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTesoreria = New cuentasPorPagar.dsTesoreria()
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
        Me.Vw_CXP_SugerenciasPagoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Vw_CXP_SugerenciasPagoDataGridView = New System.Windows.Forms.DataGridView()
        Me.Vw_CXP_SugerenciasPagoTableAdapter = New cuentasPorPagar.dsTesoreriaTableAdapters.Vw_CXP_SugerenciasPagoTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsTesoreriaTableAdapters.TableAdapterManager()
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXPCuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_CuentasBancariasTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_CuentasBancariasTableAdapter()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbBancoOrdenante = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Vw_CXP_SugerenciasPagoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.SuspendLayout()
        CType(Me.Vw_CXP_SugerenciasPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTesoreria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_CXP_SugerenciasPagoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Vw_CXP_SugerenciasPagoBindingNavigator
        '
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.BindingSource = Me.Vw_CXP_SugerenciasPagoBindingSource
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Vw_CXP_SugerenciasPagoBindingNavigatorSaveItem})
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.Name = "Vw_CXP_SugerenciasPagoBindingNavigator"
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.Size = New System.Drawing.Size(1202, 25)
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.TabIndex = 0
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'Vw_CXP_SugerenciasPagoBindingSource
        '
        Me.Vw_CXP_SugerenciasPagoBindingSource.DataMember = "Vw_CXP_SugerenciasPago"
        Me.Vw_CXP_SugerenciasPagoBindingSource.DataSource = Me.DsTesoreria
        '
        'DsTesoreria
        '
        Me.DsTesoreria.DataSetName = "dsTesoreria"
        Me.DsTesoreria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorDeleteItem.Enabled = False
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
        'Vw_CXP_SugerenciasPagoBindingNavigatorSaveItem
        '
        Me.Vw_CXP_SugerenciasPagoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Vw_CXP_SugerenciasPagoBindingNavigatorSaveItem.Enabled = False
        Me.Vw_CXP_SugerenciasPagoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Vw_CXP_SugerenciasPagoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Vw_CXP_SugerenciasPagoBindingNavigatorSaveItem.Name = "Vw_CXP_SugerenciasPagoBindingNavigatorSaveItem"
        Me.Vw_CXP_SugerenciasPagoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Vw_CXP_SugerenciasPagoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Vw_CXP_SugerenciasPagoDataGridView
        '
        Me.Vw_CXP_SugerenciasPagoDataGridView.AllowUserToAddRows = False
        Me.Vw_CXP_SugerenciasPagoDataGridView.AllowUserToDeleteRows = False
        Me.Vw_CXP_SugerenciasPagoDataGridView.AutoGenerateColumns = False
        Me.Vw_CXP_SugerenciasPagoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vw_CXP_SugerenciasPagoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.descripcion, Me.DataGridViewTextBoxColumn3, Me.cmbBancoOrdenante, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn16})
        Me.Vw_CXP_SugerenciasPagoDataGridView.DataSource = Me.Vw_CXP_SugerenciasPagoBindingSource
        Me.Vw_CXP_SugerenciasPagoDataGridView.Location = New System.Drawing.Point(13, 39)
        Me.Vw_CXP_SugerenciasPagoDataGridView.Name = "Vw_CXP_SugerenciasPagoDataGridView"
        Me.Vw_CXP_SugerenciasPagoDataGridView.Size = New System.Drawing.Size(1177, 423)
        Me.Vw_CXP_SugerenciasPagoDataGridView.TabIndex = 1
        '
        'Vw_CXP_SugerenciasPagoTableAdapter
        '
        Me.Vw_CXP_SugerenciasPagoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsTesoreriaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXPCuentasBancariasBindingSource
        '
        Me.CXPCuentasBancariasBindingSource.DataMember = "CXP_CuentasBancarias"
        Me.CXPCuentasBancariasBindingSource.DataSource = Me.DsProduction
        '
        'CXP_CuentasBancariasTableAdapter
        '
        Me.CXP_CuentasBancariasTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "fechaSolicitud"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn13.HeaderText = "Fecha Solicitud"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 70
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "folioSolicitud"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio Sol"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "totalPagado"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Imp Solic"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Forma de Pago"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 220
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "moneda"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Moneda S"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 45
        '
        'cmbBancoOrdenante
        '
        Me.cmbBancoOrdenante.DataSource = Me.CXPCuentasBancariasBindingSource
        Me.cmbBancoOrdenante.DisplayMember = "nombre"
        Me.cmbBancoOrdenante.HeaderText = "Banco Ordenante"
        Me.cmbBancoOrdenante.Name = "cmbBancoOrdenante"
        Me.cmbBancoOrdenante.ValueMember = "idCuentaBancaria"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nombreCorto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Banco Ben"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cuenta"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cuenta Ben"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "clabe"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CLABE Ben"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "c_Moneda"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Moneda Ben"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 45
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "nombreSucursal"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Sucursal"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 120
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "usuario"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Solicita"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 90
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "fechaPago"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn16.HeaderText = "Fecha Pago"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 70
        '
        'frmTesSolicitudesDePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 534)
        Me.Controls.Add(Me.Vw_CXP_SugerenciasPagoDataGridView)
        Me.Controls.Add(Me.Vw_CXP_SugerenciasPagoBindingNavigator)
        Me.Name = "frmTesSolicitudesDePago"
        Me.Text = "Pagos (Solicitudes de pago)"
        CType(Me.Vw_CXP_SugerenciasPagoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.ResumeLayout(False)
        Me.Vw_CXP_SugerenciasPagoBindingNavigator.PerformLayout()
        CType(Me.Vw_CXP_SugerenciasPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTesoreria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_CXP_SugerenciasPagoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsTesoreria As dsTesoreria
    Friend WithEvents Vw_CXP_SugerenciasPagoBindingSource As BindingSource
    Friend WithEvents Vw_CXP_SugerenciasPagoTableAdapter As dsTesoreriaTableAdapters.Vw_CXP_SugerenciasPagoTableAdapter
    Friend WithEvents TableAdapterManager As dsTesoreriaTableAdapters.TableAdapterManager
    Friend WithEvents Vw_CXP_SugerenciasPagoBindingNavigator As BindingNavigator
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
    Friend WithEvents Vw_CXP_SugerenciasPagoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Vw_CXP_SugerenciasPagoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents cmbBancoOrdenante As DataGridViewComboBoxColumn
    Friend WithEvents CXPCuentasBancariasBindingSource As BindingSource
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents CXP_CuentasBancariasTableAdapter As dsProductionTableAdapters.CXP_CuentasBancariasTableAdapter
End Class
