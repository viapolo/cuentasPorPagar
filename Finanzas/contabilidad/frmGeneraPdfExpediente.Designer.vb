<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneraPdfExpediente
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
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.CXPProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.CXP_ProveedoresTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ProveedoresTableAdapter()
        Me.dgvDocumentacion = New System.Windows.Forms.DataGridView()
        Me.ObligatorioDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ActivoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TipoPersonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.generaPdf = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.CXPDocumentacionProvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.CXP_DocumentacionProvTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_DocumentacionProvTableAdapter()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CXPProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDocumentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPDocumentacionProvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DataSource = Me.CXPProveedoresBindingSource
        Me.cmbProveedor.DisplayMember = "razonSocial"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(330, 12)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(388, 21)
        Me.cmbProveedor.TabIndex = 0
        '
        'CXPProveedoresBindingSource
        '
        Me.CXPProveedoresBindingSource.DataMember = "CXP_Proveedores"
        Me.CXPProveedoresBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(12, 12)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(214, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(233, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'CXP_ProveedoresTableAdapter
        '
        Me.CXP_ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'dgvDocumentacion
        '
        Me.dgvDocumentacion.AllowUserToAddRows = False
        Me.dgvDocumentacion.AllowUserToDeleteRows = False
        Me.dgvDocumentacion.AutoGenerateColumns = False
        Me.dgvDocumentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ObligatorioDataGridViewCheckBoxColumn, Me.ActivoDataGridViewCheckBoxColumn, Me.TipoPersonaDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.generaPdf})
        Me.dgvDocumentacion.DataSource = Me.CXPDocumentacionProvBindingSource
        Me.dgvDocumentacion.Location = New System.Drawing.Point(12, 62)
        Me.dgvDocumentacion.Name = "dgvDocumentacion"
        Me.dgvDocumentacion.ReadOnly = True
        Me.dgvDocumentacion.Size = New System.Drawing.Size(706, 214)
        Me.dgvDocumentacion.TabIndex = 3
        '
        'ObligatorioDataGridViewCheckBoxColumn
        '
        Me.ObligatorioDataGridViewCheckBoxColumn.DataPropertyName = "obligatorio"
        Me.ObligatorioDataGridViewCheckBoxColumn.HeaderText = "Obligatorio"
        Me.ObligatorioDataGridViewCheckBoxColumn.Name = "ObligatorioDataGridViewCheckBoxColumn"
        Me.ObligatorioDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ObligatorioDataGridViewCheckBoxColumn.Width = 60
        '
        'ActivoDataGridViewCheckBoxColumn
        '
        Me.ActivoDataGridViewCheckBoxColumn.DataPropertyName = "activo"
        Me.ActivoDataGridViewCheckBoxColumn.HeaderText = "Activo"
        Me.ActivoDataGridViewCheckBoxColumn.Name = "ActivoDataGridViewCheckBoxColumn"
        Me.ActivoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ActivoDataGridViewCheckBoxColumn.Width = 40
        '
        'TipoPersonaDataGridViewTextBoxColumn
        '
        Me.TipoPersonaDataGridViewTextBoxColumn.DataPropertyName = "tipoPersona"
        Me.TipoPersonaDataGridViewTextBoxColumn.HeaderText = "Tipo Persona"
        Me.TipoPersonaDataGridViewTextBoxColumn.Name = "TipoPersonaDataGridViewTextBoxColumn"
        Me.TipoPersonaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 350
        '
        'generaPdf
        '
        Me.generaPdf.HeaderText = "Generar PDF"
        Me.generaPdf.Name = "generaPdf"
        Me.generaPdf.ReadOnly = True
        Me.generaPdf.Width = 80
        '
        'CXPDocumentacionProvBindingSource
        '
        Me.CXPDocumentacionProvBindingSource.DataMember = "CXP_DocumentacionProv"
        Me.CXPDocumentacionProvBindingSource.DataSource = Me.DsProduction
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(643, 282)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'CXP_DocumentacionProvTableAdapter
        '
        Me.CXP_DocumentacionProvTableAdapter.ClearBeforeFill = True
        '
        'txtRfc
        '
        Me.txtRfc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXPProveedoresBindingSource, "rfc", True))
        Me.txtRfc.Location = New System.Drawing.Point(330, 36)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.ReadOnly = True
        Me.txtRfc.Size = New System.Drawing.Size(203, 20)
        Me.txtRfc.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tipoPersona"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo Persona"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 350
        '
        'frmGeneraPdfExpediente
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 317)
        Me.Controls.Add(Me.txtRfc)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvDocumentacion)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.cmbProveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmGeneraPdfExpediente"
        Me.Text = "Generar PDF Expediente"
        CType(Me.CXPProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDocumentacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPDocumentacionProvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXPProveedoresBindingSource As BindingSource
    Friend WithEvents CXP_ProveedoresTableAdapter As dsProductionTableAdapters.CXP_ProveedoresTableAdapter
    Friend WithEvents dgvDocumentacion As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents CXPDocumentacionProvBindingSource As BindingSource
    Friend WithEvents CXP_DocumentacionProvTableAdapter As dsProductionTableAdapters.CXP_DocumentacionProvTableAdapter
    Friend WithEvents txtRfc As TextBox
    Friend WithEvents TipoPersonaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObligatorioDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ActivoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents generaPdf As DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
