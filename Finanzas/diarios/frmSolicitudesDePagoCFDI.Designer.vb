<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolicitudesDePagoCFDI
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CXP_XmlCfdiDataGridView = New System.Windows.Forms.DataGridView()
        Me.VwCXPXmlCfdi2grpUuidBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXPXmlCfdiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_XmlCfdiTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_XmlCfdiTableAdapter()
        Me.Vw_CXP_XmlCfdi2_grpUuidTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.vw_CXP_XmlCfdi2_grpUuidTableAdapter()
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UuidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RfcEmisorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.CXP_XmlCfdiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCXPXmlCfdi2grpUuidBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPXmlCfdiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CXP_XmlCfdiDataGridView
        '
        Me.CXP_XmlCfdiDataGridView.AllowUserToAddRows = False
        Me.CXP_XmlCfdiDataGridView.AllowUserToDeleteRows = False
        Me.CXP_XmlCfdiDataGridView.AllowUserToOrderColumns = True
        Me.CXP_XmlCfdiDataGridView.AllowUserToResizeColumns = False
        Me.CXP_XmlCfdiDataGridView.AllowUserToResizeRows = False
        Me.CXP_XmlCfdiDataGridView.AutoGenerateColumns = False
        Me.CXP_XmlCfdiDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.CXP_XmlCfdiDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CXP_XmlCfdiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CXP_XmlCfdiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.UuidDataGridViewTextBoxColumn, Me.RfcEmisorDataGridViewTextBoxColumn, Me.NombreProvDataGridViewTextBoxColumn, Me.Column2, Me.impIva, Me.seleccionar})
        Me.CXP_XmlCfdiDataGridView.DataSource = Me.VwCXPXmlCfdi2grpUuidBindingSource
        Me.CXP_XmlCfdiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CXP_XmlCfdiDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.CXP_XmlCfdiDataGridView.Name = "CXP_XmlCfdiDataGridView"
        Me.CXP_XmlCfdiDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CXP_XmlCfdiDataGridView.RowHeadersVisible = False
        Me.CXP_XmlCfdiDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CXP_XmlCfdiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CXP_XmlCfdiDataGridView.Size = New System.Drawing.Size(1152, 361)
        Me.CXP_XmlCfdiDataGridView.TabIndex = 7
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
        'CXPXmlCfdiBindingSource
        '
        Me.CXPXmlCfdiBindingSource.DataMember = "CXP_XmlCfdi"
        Me.CXPXmlCfdiBindingSource.DataSource = Me.DsProduction
        '
        'CXP_XmlCfdiTableAdapter
        '
        Me.CXP_XmlCfdiTableAdapter.ClearBeforeFill = True
        '
        'Vw_CXP_XmlCfdi2_grpUuidTableAdapter
        '
        Me.Vw_CXP_XmlCfdi2_grpUuidTableAdapter.ClearBeforeFill = True
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "folio"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FolioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "Folio Int"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        Me.SerieDataGridViewTextBoxColumn.ReadOnly = True
        Me.SerieDataGridViewTextBoxColumn.Width = 50
        '
        'UuidDataGridViewTextBoxColumn
        '
        Me.UuidDataGridViewTextBoxColumn.DataPropertyName = "uuid"
        Me.UuidDataGridViewTextBoxColumn.HeaderText = "UUID / Fol Fiscal"
        Me.UuidDataGridViewTextBoxColumn.Name = "UuidDataGridViewTextBoxColumn"
        Me.UuidDataGridViewTextBoxColumn.ReadOnly = True
        Me.UuidDataGridViewTextBoxColumn.Width = 250
        '
        'RfcEmisorDataGridViewTextBoxColumn
        '
        Me.RfcEmisorDataGridViewTextBoxColumn.DataPropertyName = "rfcEmisor"
        Me.RfcEmisorDataGridViewTextBoxColumn.HeaderText = "RFC Emisor"
        Me.RfcEmisorDataGridViewTextBoxColumn.Name = "RfcEmisorDataGridViewTextBoxColumn"
        Me.RfcEmisorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreProvDataGridViewTextBoxColumn
        '
        Me.NombreProvDataGridViewTextBoxColumn.DataPropertyName = "nombreProv"
        Me.NombreProvDataGridViewTextBoxColumn.HeaderText = "Razón Social"
        Me.NombreProvDataGridViewTextBoxColumn.Name = "NombreProvDataGridViewTextBoxColumn"
        Me.NombreProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreProvDataGridViewTextBoxColumn.Width = 250
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "subTotal"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "Sub Total"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'impIva
        '
        Me.impIva.DataPropertyName = "total"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.impIva.DefaultCellStyle = DataGridViewCellStyle3
        Me.impIva.HeaderText = "Total"
        Me.impIva.Name = "impIva"
        Me.impIva.ReadOnly = True
        '
        'seleccionar
        '
        Me.seleccionar.HeaderText = "Seleccionar"
        Me.seleccionar.Name = "seleccionar"
        '
        'frmSolicitudesDePagoCFDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 361)
        Me.Controls.Add(Me.CXP_XmlCfdiDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmSolicitudesDePagoCFDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobantes del Proveedor"
        CType(Me.CXP_XmlCfdiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCXPXmlCfdi2grpUuidBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPXmlCfdiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CXP_XmlCfdiDataGridView As DataGridView
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXPXmlCfdiBindingSource As BindingSource
    Friend WithEvents CXP_XmlCfdiTableAdapter As dsProductionTableAdapters.CXP_XmlCfdiTableAdapter
    Friend WithEvents VwCXPXmlCfdi2grpUuidBindingSource As BindingSource
    Friend WithEvents Vw_CXP_XmlCfdi2_grpUuidTableAdapter As dsProductionTableAdapters.vw_CXP_XmlCfdi2_grpUuidTableAdapter
    Friend WithEvents FolioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UuidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RfcEmisorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents impIva As DataGridViewTextBoxColumn
    Friend WithEvents seleccionar As DataGridViewCheckBoxColumn
End Class
