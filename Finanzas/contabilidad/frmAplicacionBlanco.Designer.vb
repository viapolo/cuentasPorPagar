<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAplicacionBlanco
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
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.CXPProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContabilidad = New cuentasPorPagar.dsContabilidad()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvFacturasCfdi = New System.Windows.Forms.DataGridView()
        Me.seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FechaEmisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UuidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParcialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoImpuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoImpuestoRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpLocTraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpLocRetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCambioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwCXPXmlCfdi2grpUuidBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.Vw_CXP_XmlCfdi2_grpUuidTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.vw_CXP_XmlCfdi2_grpUuidTableAdapter()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.txtNoProveedor = New System.Windows.Forms.TextBox()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.cmbConcepto = New System.Windows.Forms.ComboBox()
        Me.CXPConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_ProveedoresTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_ProveedoresTableAdapter()
        Me.CXP_ConceptosTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_ConceptosTableAdapter()
        Me.dgvVistaPrevia = New System.Windows.Forms.DataGridView()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoAPagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVistaPrevia = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.CXPProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFacturasCfdi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCXPXmlCfdi2grpUuidBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVistaPrevia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProveedor.DataSource = Me.CXPProveedoresBindingSource
        Me.cmbProveedor.DisplayMember = "razonSocial"
        Me.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(77, 12)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(403, 21)
        Me.cmbProveedor.TabIndex = 0
        Me.cmbProveedor.ValueMember = "idProveedor"
        '
        'CXPProveedoresBindingSource
        '
        Me.CXPProveedoresBindingSource.DataMember = "CXP_Proveedores"
        Me.CXPProveedoresBindingSource.DataSource = Me.DsContabilidad
        Me.CXPProveedoresBindingSource.Sort = "idProveedor"
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "dsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Proveedor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Facturas:"
        '
        'dgvFacturasCfdi
        '
        Me.dgvFacturasCfdi.AllowUserToAddRows = False
        Me.dgvFacturasCfdi.AllowUserToDeleteRows = False
        Me.dgvFacturasCfdi.AllowUserToOrderColumns = True
        Me.dgvFacturasCfdi.AutoGenerateColumns = False
        Me.dgvFacturasCfdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturasCfdi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seleccionar, Me.FechaEmisionDataGridViewTextBoxColumn, Me.UuidDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.FolioDataGridViewTextBoxColumn, Me.ParcialidadDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.total, Me.MontoImpuestoDataGridViewTextBoxColumn, Me.MontoImpuestoRDataGridViewTextBoxColumn, Me.ImpLocTraDataGridViewTextBoxColumn, Me.ImpLocRetDataGridViewTextBoxColumn, Me.MonedaDataGridViewTextBoxColumn, Me.MPagoDataGridViewTextBoxColumn, Me.FPagoDataGridViewTextBoxColumn, Me.TipoCambioDataGridViewTextBoxColumn})
        Me.dgvFacturasCfdi.DataSource = Me.VwCXPXmlCfdi2grpUuidBindingSource
        Me.dgvFacturasCfdi.Location = New System.Drawing.Point(12, 95)
        Me.dgvFacturasCfdi.Name = "dgvFacturasCfdi"
        Me.dgvFacturasCfdi.Size = New System.Drawing.Size(1071, 150)
        Me.dgvFacturasCfdi.TabIndex = 3
        '
        'seleccionar
        '
        Me.seleccionar.HeaderText = "Seleccionar"
        Me.seleccionar.Name = "seleccionar"
        '
        'FechaEmisionDataGridViewTextBoxColumn
        '
        Me.FechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "fechaEmision"
        Me.FechaEmisionDataGridViewTextBoxColumn.HeaderText = "F Emision"
        Me.FechaEmisionDataGridViewTextBoxColumn.Name = "FechaEmisionDataGridViewTextBoxColumn"
        Me.FechaEmisionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UuidDataGridViewTextBoxColumn
        '
        Me.UuidDataGridViewTextBoxColumn.DataPropertyName = "uuid"
        Me.UuidDataGridViewTextBoxColumn.HeaderText = "UUID"
        Me.UuidDataGridViewTextBoxColumn.Name = "UuidDataGridViewTextBoxColumn"
        Me.UuidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        Me.SerieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "folio"
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "Folio"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ParcialidadDataGridViewTextBoxColumn
        '
        Me.ParcialidadDataGridViewTextBoxColumn.DataPropertyName = "Parcialidad"
        Me.ParcialidadDataGridViewTextBoxColumn.HeaderText = "Parcialidad"
        Me.ParcialidadDataGridViewTextBoxColumn.Name = "ParcialidadDataGridViewTextBoxColumn"
        Me.ParcialidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "subTotal"
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "Sub Total"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        Me.SubTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "Sug Pago"
        Me.total.Name = "total"
        '
        'MontoImpuestoDataGridViewTextBoxColumn
        '
        Me.MontoImpuestoDataGridViewTextBoxColumn.DataPropertyName = "montoImpuesto"
        Me.MontoImpuestoDataGridViewTextBoxColumn.HeaderText = "Imp Tras"
        Me.MontoImpuestoDataGridViewTextBoxColumn.Name = "MontoImpuestoDataGridViewTextBoxColumn"
        Me.MontoImpuestoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoImpuestoRDataGridViewTextBoxColumn
        '
        Me.MontoImpuestoRDataGridViewTextBoxColumn.DataPropertyName = "montoImpuestoR"
        Me.MontoImpuestoRDataGridViewTextBoxColumn.HeaderText = "Imp Ret"
        Me.MontoImpuestoRDataGridViewTextBoxColumn.Name = "MontoImpuestoRDataGridViewTextBoxColumn"
        Me.MontoImpuestoRDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImpLocTraDataGridViewTextBoxColumn
        '
        Me.ImpLocTraDataGridViewTextBoxColumn.DataPropertyName = "impLocTra"
        Me.ImpLocTraDataGridViewTextBoxColumn.HeaderText = "Imp Loc Tras"
        Me.ImpLocTraDataGridViewTextBoxColumn.Name = "ImpLocTraDataGridViewTextBoxColumn"
        Me.ImpLocTraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImpLocRetDataGridViewTextBoxColumn
        '
        Me.ImpLocRetDataGridViewTextBoxColumn.DataPropertyName = "impLocRet"
        Me.ImpLocRetDataGridViewTextBoxColumn.HeaderText = "Imp Loc Ret"
        Me.ImpLocRetDataGridViewTextBoxColumn.Name = "ImpLocRetDataGridViewTextBoxColumn"
        Me.ImpLocRetDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MonedaDataGridViewTextBoxColumn
        '
        Me.MonedaDataGridViewTextBoxColumn.DataPropertyName = "moneda"
        Me.MonedaDataGridViewTextBoxColumn.HeaderText = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.Name = "MonedaDataGridViewTextBoxColumn"
        Me.MonedaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MPagoDataGridViewTextBoxColumn
        '
        Me.MPagoDataGridViewTextBoxColumn.DataPropertyName = "mPago"
        Me.MPagoDataGridViewTextBoxColumn.HeaderText = "MPago"
        Me.MPagoDataGridViewTextBoxColumn.Name = "MPagoDataGridViewTextBoxColumn"
        Me.MPagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FPagoDataGridViewTextBoxColumn
        '
        Me.FPagoDataGridViewTextBoxColumn.DataPropertyName = "fPago"
        Me.FPagoDataGridViewTextBoxColumn.HeaderText = "FPago"
        Me.FPagoDataGridViewTextBoxColumn.Name = "FPagoDataGridViewTextBoxColumn"
        Me.FPagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoCambioDataGridViewTextBoxColumn
        '
        Me.TipoCambioDataGridViewTextBoxColumn.DataPropertyName = "tipoCambio"
        Me.TipoCambioDataGridViewTextBoxColumn.HeaderText = "TipoCambio"
        Me.TipoCambioDataGridViewTextBoxColumn.Name = "TipoCambioDataGridViewTextBoxColumn"
        Me.TipoCambioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwCXPXmlCfdi2grpUuidBindingSource
        '
        Me.VwCXPXmlCfdi2grpUuidBindingSource.DataMember = "vw_CXP_XmlCfdi2_grpUuid"
        Me.VwCXPXmlCfdi2grpUuidBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_CXP_XmlCfdi2_grpUuidTableAdapter
        '
        Me.Vw_CXP_XmlCfdi2_grpUuidTableAdapter.ClearBeforeFill = True
        '
        'txtRfc
        '
        Me.txtRfc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXPProveedoresBindingSource, "rfc", True))
        Me.txtRfc.Location = New System.Drawing.Point(486, 12)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.ReadOnly = True
        Me.txtRfc.Size = New System.Drawing.Size(111, 20)
        Me.txtRfc.TabIndex = 4
        '
        'txtNoProveedor
        '
        Me.txtNoProveedor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXPProveedoresBindingSource, "idProveedor", True))
        Me.txtNoProveedor.Location = New System.Drawing.Point(603, 12)
        Me.txtNoProveedor.Name = "txtNoProveedor"
        Me.txtNoProveedor.ReadOnly = True
        Me.txtNoProveedor.Size = New System.Drawing.Size(100, 20)
        Me.txtNoProveedor.TabIndex = 7
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(709, 10)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar.TabIndex = 8
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'cmbConcepto
        '
        Me.cmbConcepto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbConcepto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbConcepto.DataSource = Me.CXPConceptosBindingSource
        Me.cmbConcepto.DisplayMember = "nombre"
        Me.cmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConcepto.FormattingEnabled = True
        Me.cmbConcepto.Location = New System.Drawing.Point(77, 39)
        Me.cmbConcepto.Name = "cmbConcepto"
        Me.cmbConcepto.Size = New System.Drawing.Size(403, 21)
        Me.cmbConcepto.TabIndex = 9
        Me.cmbConcepto.ValueMember = "idConcepto"
        '
        'CXPConceptosBindingSource
        '
        Me.CXPConceptosBindingSource.DataMember = "CXP_Conceptos"
        Me.CXPConceptosBindingSource.DataSource = Me.DsContabilidad
        '
        'CXP_ProveedoresTableAdapter
        '
        Me.CXP_ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'CXP_ConceptosTableAdapter
        '
        Me.CXP_ConceptosTableAdapter.ClearBeforeFill = True
        '
        'dgvVistaPrevia
        '
        Me.dgvVistaPrevia.AllowUserToAddRows = False
        Me.dgvVistaPrevia.AllowUserToDeleteRows = False
        Me.dgvVistaPrevia.BackgroundColor = System.Drawing.Color.BlanchedAlmond
        Me.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVistaPrevia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serie, Me.folio, Me.uuid, Me.montoAPagar, Me.concepto})
        Me.dgvVistaPrevia.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvVistaPrevia.Location = New System.Drawing.Point(179, 191)
        Me.dgvVistaPrevia.Name = "dgvVistaPrevia"
        Me.dgvVistaPrevia.ReadOnly = True
        Me.dgvVistaPrevia.RowHeadersVisible = False
        Me.dgvVistaPrevia.Size = New System.Drawing.Size(704, 150)
        Me.dgvVistaPrevia.TabIndex = 10
        Me.dgvVistaPrevia.Visible = False
        '
        'serie
        '
        Me.serie.HeaderText = "Serie"
        Me.serie.Name = "serie"
        Me.serie.ReadOnly = True
        '
        'folio
        '
        Me.folio.HeaderText = "Folio"
        Me.folio.Name = "folio"
        Me.folio.ReadOnly = True
        '
        'uuid
        '
        Me.uuid.HeaderText = "UUID"
        Me.uuid.Name = "uuid"
        Me.uuid.ReadOnly = True
        '
        'montoAPagar
        '
        Me.montoAPagar.HeaderText = "Monto a Pagar Sugerido"
        Me.montoAPagar.Name = "montoAPagar"
        Me.montoAPagar.ReadOnly = True
        '
        'concepto
        '
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.ReadOnly = True
        Me.concepto.Width = 300
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Location = New System.Drawing.Point(1008, 251)
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        Me.btnVistaPrevia.Size = New System.Drawing.Size(75, 23)
        Me.btnVistaPrevia.TabIndex = 11
        Me.btnVistaPrevia.Text = "Vista Previa"
        Me.btnVistaPrevia.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(453, 352)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 12
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        Me.btnProcesar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(534, 352)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Concepto:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(558, 38)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(525, 20)
        Me.txtDescripcion.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(486, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Descripción:"
        '
        'frmAplicacionBlanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 387)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.btnVistaPrevia)
        Me.Controls.Add(Me.dgvVistaPrevia)
        Me.Controls.Add(Me.cmbConcepto)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.txtNoProveedor)
        Me.Controls.Add(Me.txtRfc)
        Me.Controls.Add(Me.dgvFacturasCfdi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbProveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAplicacionBlanco"
        Me.Text = "Aplicaciones en Blanco"
        CType(Me.CXPProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFacturasCfdi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCXPXmlCfdi2grpUuidBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPConceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVistaPrevia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvFacturasCfdi As DataGridView
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents VwCXPXmlCfdi2grpUuidBindingSource As BindingSource
    Friend WithEvents Vw_CXP_XmlCfdi2_grpUuidTableAdapter As dsProductionTableAdapters.vw_CXP_XmlCfdi2_grpUuidTableAdapter
    Friend WithEvents txtRfc As TextBox
    Friend WithEvents txtNoProveedor As TextBox
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents cmbConcepto As ComboBox
    Friend WithEvents DsContabilidad As dsContabilidad
    Friend WithEvents CXPProveedoresBindingSource As BindingSource
    Friend WithEvents CXP_ProveedoresTableAdapter As dsContabilidadTableAdapters.CXP_ProveedoresTableAdapter
    Friend WithEvents CXPConceptosBindingSource As BindingSource
    Friend WithEvents CXP_ConceptosTableAdapter As dsContabilidadTableAdapters.CXP_ConceptosTableAdapter
    Friend WithEvents seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents FechaEmisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UuidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FolioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ParcialidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents MontoImpuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoImpuestoRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpLocTraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpLocRetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonedaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCambioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvVistaPrevia As DataGridView
    Friend WithEvents serie As DataGridViewTextBoxColumn
    Friend WithEvents folio As DataGridViewTextBoxColumn
    Friend WithEvents uuid As DataGridViewTextBoxColumn
    Friend WithEvents montoAPagar As DataGridViewTextBoxColumn
    Friend WithEvents concepto As DataGridViewTextBoxColumn
    Friend WithEvents btnVistaPrevia As Button
    Friend WithEvents btnProcesar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label4 As Label
End Class
