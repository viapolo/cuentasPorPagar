<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotificacionesPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotificacionesPago))
        Me.dgvNotificaProveedores = New System.Windows.Forms.DataGridView()
        Me.CXPProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsHerramientas = New cuentasPorPagar.dsHerramientas()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.CXP_ProveedoresTableAdapter = New cuentasPorPagar.dsHerramientasTableAdapters.CXP_ProveedoresTableAdapter()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterManager = New cuentasPorPagar.dsHerramientasTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.razonSocial = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.notificaPago = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.adjuntaComprobante = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.notificaContabilidad = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RfcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutorizadoSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvNotificaProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHerramientas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvNotificaProveedores
        '
        Me.dgvNotificaProveedores.AllowUserToAddRows = False
        Me.dgvNotificaProveedores.AllowUserToDeleteRows = False
        Me.dgvNotificaProveedores.AllowUserToOrderColumns = True
        Me.dgvNotificaProveedores.AutoGenerateColumns = False
        Me.dgvNotificaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotificaProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorDataGridViewTextBoxColumn, Me.razonSocial, Me.notificaPago, Me.adjuntaComprobante, Me.notificaContabilidad, Me.RfcDataGridViewTextBoxColumn, Me.ActivoSDataGridViewTextBoxColumn, Me.AutorizadoSDataGridViewTextBoxColumn})
        Me.dgvNotificaProveedores.DataSource = Me.CXPProveedoresBindingSource
        Me.dgvNotificaProveedores.Location = New System.Drawing.Point(12, 64)
        Me.dgvNotificaProveedores.Name = "dgvNotificaProveedores"
        Me.dgvNotificaProveedores.Size = New System.Drawing.Size(976, 392)
        Me.dgvNotificaProveedores.TabIndex = 0
        '
        'CXPProveedoresBindingSource
        '
        Me.CXPProveedoresBindingSource.DataMember = "CXP_Proveedores"
        Me.CXPProveedoresBindingSource.DataSource = Me.DsHerramientas
        '
        'DsHerramientas
        '
        Me.DsHerramientas.DataSetName = "dsHerramientas"
        Me.DsHerramientas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(913, 462)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(277, 35)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(13, 37)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(258, 20)
        Me.txtBuscar.TabIndex = 3
        '
        'CXP_ProveedoresTableAdapter
        '
        Me.CXP_ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.CXPProveedoresBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1000, 25)
        Me.BindingNavigator1.TabIndex = 5
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CXP_BancosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CorreosProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasProvTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Me.CXP_ProveedoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsHerramientasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idProveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 300
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "razonSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "rfc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RFC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "activoS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Activo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "autorizadoS"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Autorizado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        Me.IdProveedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'razonSocial
        '
        Me.razonSocial.DataPropertyName = "razonSocial"
        Me.razonSocial.HeaderText = "Razón Social"
        Me.razonSocial.Name = "razonSocial"
        Me.razonSocial.ReadOnly = True
        Me.razonSocial.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.razonSocial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.razonSocial.Width = 300
        '
        'notificaPago
        '
        Me.notificaPago.DataPropertyName = "notificaPago"
        Me.notificaPago.HeaderText = "Notifica Pago"
        Me.notificaPago.Name = "notificaPago"
        Me.notificaPago.Width = 80
        '
        'adjuntaComprobante
        '
        Me.adjuntaComprobante.DataPropertyName = "adjuntaComprobante"
        Me.adjuntaComprobante.HeaderText = "Adjunta Comprobante"
        Me.adjuntaComprobante.Name = "adjuntaComprobante"
        '
        'notificaContabilidad
        '
        Me.notificaContabilidad.DataPropertyName = "notificaContabilidad"
        Me.notificaContabilidad.HeaderText = "Notifica Contabilidad"
        Me.notificaContabilidad.Name = "notificaContabilidad"
        Me.notificaContabilidad.Width = 80
        '
        'RfcDataGridViewTextBoxColumn
        '
        Me.RfcDataGridViewTextBoxColumn.DataPropertyName = "rfc"
        Me.RfcDataGridViewTextBoxColumn.HeaderText = "RFC"
        Me.RfcDataGridViewTextBoxColumn.Name = "RfcDataGridViewTextBoxColumn"
        Me.RfcDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActivoSDataGridViewTextBoxColumn
        '
        Me.ActivoSDataGridViewTextBoxColumn.DataPropertyName = "activoS"
        Me.ActivoSDataGridViewTextBoxColumn.HeaderText = "Activo"
        Me.ActivoSDataGridViewTextBoxColumn.Name = "ActivoSDataGridViewTextBoxColumn"
        Me.ActivoSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AutorizadoSDataGridViewTextBoxColumn
        '
        Me.AutorizadoSDataGridViewTextBoxColumn.DataPropertyName = "autorizadoS"
        Me.AutorizadoSDataGridViewTextBoxColumn.HeaderText = "Autorizado"
        Me.AutorizadoSDataGridViewTextBoxColumn.Name = "AutorizadoSDataGridViewTextBoxColumn"
        Me.AutorizadoSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmNotificacionesPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 497)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvNotificaProveedores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmNotificacionesPago"
        Me.Text = "Notificaciones de pago a proveedores"
        CType(Me.dgvNotificaProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHerramientas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvNotificaProveedores As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents DsHerramientas As dsHerramientas
    Friend WithEvents CXPProveedoresBindingSource As BindingSource
    Friend WithEvents CXP_ProveedoresTableAdapter As dsHerramientasTableAdapters.CXP_ProveedoresTableAdapter
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator1 As BindingNavigator
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
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TableAdapterManager As dsHerramientasTableAdapters.TableAdapterManager
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents razonSocial As DataGridViewLinkColumn
    Friend WithEvents notificaPago As DataGridViewCheckBoxColumn
    Friend WithEvents adjuntaComprobante As DataGridViewCheckBoxColumn
    Friend WithEvents notificaContabilidad As DataGridViewCheckBoxColumn
    Friend WithEvents RfcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActivoSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AutorizadoSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
