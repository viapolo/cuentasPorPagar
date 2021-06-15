<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetiroDeInversion
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
        Me.DsContabilidad = New cuentasPorPagar.dsContabilidad()
        Me.CXP_InversionesTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_InversionesTableAdapter()
        Me.CXP_InversionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.CXPCuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_InversionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.CXP_CuentasBancariasTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_CuentasBancariasTableAdapter()
        Me.CXP_EstatusTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_EstatusTableAdapter()
        Me.CXPEstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idInversion = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.idBancoOrigen = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.fechaInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoFira = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_InversionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_InversionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPEstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "dsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_InversionesTableAdapter
        '
        Me.CXP_InversionesTableAdapter.ClearBeforeFill = True
        '
        'CXP_InversionesDataGridView
        '
        Me.CXP_InversionesDataGridView.AllowUserToAddRows = False
        Me.CXP_InversionesDataGridView.AllowUserToDeleteRows = False
        Me.CXP_InversionesDataGridView.AllowUserToOrderColumns = True
        Me.CXP_InversionesDataGridView.AutoGenerateColumns = False
        Me.CXP_InversionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CXP_InversionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idInversion, Me.idBancoOrigen, Me.fechaInicial, Me.tasa, Me.monto, Me.estatus, Me.tipoFira})
        Me.CXP_InversionesDataGridView.DataSource = Me.CXP_InversionesBindingSource
        Me.CXP_InversionesDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.CXP_InversionesDataGridView.Name = "CXP_InversionesDataGridView"
        Me.CXP_InversionesDataGridView.ReadOnly = True
        Me.CXP_InversionesDataGridView.Size = New System.Drawing.Size(1032, 302)
        Me.CXP_InversionesDataGridView.TabIndex = 2
        '
        'CXPCuentasBancariasBindingSource
        '
        Me.CXPCuentasBancariasBindingSource.DataMember = "CXP_CuentasBancarias"
        Me.CXPCuentasBancariasBindingSource.DataSource = Me.DsContabilidad
        '
        'CXP_InversionesBindingSource
        '
        Me.CXP_InversionesBindingSource.DataMember = "CXP_Inversiones"
        Me.CXP_InversionesBindingSource.DataSource = Me.DsContabilidad
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(969, 329)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'CXP_CuentasBancariasTableAdapter
        '
        Me.CXP_CuentasBancariasTableAdapter.ClearBeforeFill = True
        '
        'CXP_EstatusTableAdapter
        '
        Me.CXP_EstatusTableAdapter.ClearBeforeFill = True
        '
        'CXPEstatusBindingSource
        '
        Me.CXPEstatusBindingSource.DataMember = "CXP_Estatus"
        Me.CXPEstatusBindingSource.DataSource = Me.DsContabilidad
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CONT_TiposDeCambioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ComprobGtos1TableAdapter = Nothing
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fechaInicial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fechaInicial"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tasa"
        Me.DataGridViewTextBoxColumn3.HeaderText = "tasa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "monto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "monto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tipoFira"
        Me.DataGridViewTextBoxColumn5.HeaderText = "tipoFira"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "estatus"
        Me.DataGridViewTextBoxColumn6.HeaderText = "estatus"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'idInversion
        '
        Me.idInversion.DataPropertyName = "idInversion"
        Me.idInversion.HeaderText = "idInversion"
        Me.idInversion.Name = "idInversion"
        Me.idInversion.ReadOnly = True
        Me.idInversion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idInversion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'idBancoOrigen
        '
        Me.idBancoOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.idBancoOrigen.DataPropertyName = "bancoOrigen"
        Me.idBancoOrigen.DataSource = Me.CXPCuentasBancariasBindingSource
        Me.idBancoOrigen.DisplayMember = "nombre"
        Me.idBancoOrigen.HeaderText = "bancoOrigen"
        Me.idBancoOrigen.Name = "idBancoOrigen"
        Me.idBancoOrigen.ReadOnly = True
        Me.idBancoOrigen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idBancoOrigen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.idBancoOrigen.ValueMember = "idCuentaBancaria"
        Me.idBancoOrigen.Width = 5
        '
        'fechaInicial
        '
        Me.fechaInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.fechaInicial.DataPropertyName = "fechaInicial"
        Me.fechaInicial.HeaderText = "fechaInicial"
        Me.fechaInicial.Name = "fechaInicial"
        Me.fechaInicial.ReadOnly = True
        Me.fechaInicial.Width = 5
        '
        'tasa
        '
        Me.tasa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.tasa.DataPropertyName = "tasa"
        Me.tasa.HeaderText = "tasa"
        Me.tasa.Name = "tasa"
        Me.tasa.ReadOnly = True
        Me.tasa.Width = 5
        '
        'monto
        '
        Me.monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.monto.DataPropertyName = "monto"
        Me.monto.HeaderText = "monto"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        Me.monto.Width = 5
        '
        'estatus
        '
        Me.estatus.DataPropertyName = "descripcion"
        Me.estatus.HeaderText = "estatus"
        Me.estatus.Name = "estatus"
        Me.estatus.ReadOnly = True
        '
        'tipoFira
        '
        Me.tipoFira.DataPropertyName = "tipoFira"
        Me.tipoFira.HeaderText = "tipoFira"
        Me.tipoFira.Name = "tipoFira"
        Me.tipoFira.ReadOnly = True
        '
        'frmRetiroDeInversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 364)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CXP_InversionesDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRetiroDeInversion"
        Me.Text = "Retiro de Inversiones"
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_InversionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_InversionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPEstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsContabilidad As dsContabilidad
    Friend WithEvents CXP_InversionesBindingSource As BindingSource
    Friend WithEvents CXP_InversionesTableAdapter As dsContabilidadTableAdapters.CXP_InversionesTableAdapter
    Friend WithEvents TableAdapterManager As dsContabilidadTableAdapters.TableAdapterManager
    Friend WithEvents CXP_InversionesDataGridView As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents CXPCuentasBancariasBindingSource As BindingSource
    Friend WithEvents CXP_CuentasBancariasTableAdapter As dsContabilidadTableAdapters.CXP_CuentasBancariasTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents CXPEstatusBindingSource As BindingSource
    Friend WithEvents CXP_EstatusTableAdapter As dsContabilidadTableAdapters.CXP_EstatusTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents idInversion As DataGridViewLinkColumn
    Friend WithEvents idBancoOrigen As DataGridViewComboBoxColumn
    Friend WithEvents fechaInicial As DataGridViewTextBoxColumn
    Friend WithEvents tasa As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents estatus As DataGridViewTextBoxColumn
    Friend WithEvents tipoFira As DataGridViewTextBoxColumn
End Class
