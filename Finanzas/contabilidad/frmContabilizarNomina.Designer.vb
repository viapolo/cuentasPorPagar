<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContabilizarNomina
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
        Me.Vw_CXP_ContabilizarNominaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_CXP_ContabilizarNominaTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.Vw_CXP_ContabilizarNominaTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager()
        Me.Vw_CXP_ContabilizarNominaDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idFolioSolicitud = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_CXP_ContabilizarNominaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_CXP_ContabilizarNominaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "dsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_CXP_ContabilizarNominaBindingSource
        '
        Me.Vw_CXP_ContabilizarNominaBindingSource.DataMember = "Vw_CXP_ContabilizarNomina"
        Me.Vw_CXP_ContabilizarNominaBindingSource.DataSource = Me.DsContabilidad
        '
        'Vw_CXP_ContabilizarNominaTableAdapter
        '
        Me.Vw_CXP_ContabilizarNominaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ComprobGtos1TableAdapter = Nothing
        Me.TableAdapterManager.CXP_EstatusTableAdapter = Nothing
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
        'Vw_CXP_ContabilizarNominaDataGridView
        '
        Me.Vw_CXP_ContabilizarNominaDataGridView.AllowUserToAddRows = False
        Me.Vw_CXP_ContabilizarNominaDataGridView.AllowUserToDeleteRows = False
        Me.Vw_CXP_ContabilizarNominaDataGridView.AllowUserToOrderColumns = True
        Me.Vw_CXP_ContabilizarNominaDataGridView.AutoGenerateColumns = False
        Me.Vw_CXP_ContabilizarNominaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vw_CXP_ContabilizarNominaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idFolioSolicitud, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27})
        Me.Vw_CXP_ContabilizarNominaDataGridView.DataSource = Me.Vw_CXP_ContabilizarNominaBindingSource
        Me.Vw_CXP_ContabilizarNominaDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.Vw_CXP_ContabilizarNominaDataGridView.Name = "Vw_CXP_ContabilizarNominaDataGridView"
        Me.Vw_CXP_ContabilizarNominaDataGridView.ReadOnly = True
        Me.Vw_CXP_ContabilizarNominaDataGridView.Size = New System.Drawing.Size(776, 309)
        Me.Vw_CXP_ContabilizarNominaDataGridView.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(713, 333)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "importeSolicitado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "importeSolicitado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "razonSocial"
        Me.DataGridViewTextBoxColumn3.HeaderText = "razonSocial"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechaPago"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fechaPago"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "referencia"
        Me.DataGridViewTextBoxColumn5.HeaderText = "referencia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fechaSolicitud"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fechaSolicitud"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "estatusReemb"
        Me.DataGridViewTextBoxColumn8.HeaderText = "estatusReemb"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'idFolioSolicitud
        '
        Me.idFolioSolicitud.DataPropertyName = "folioSolicitud"
        Me.idFolioSolicitud.HeaderText = "folioSolicitud"
        Me.idFolioSolicitud.Name = "idFolioSolicitud"
        Me.idFolioSolicitud.ReadOnly = True
        Me.idFolioSolicitud.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idFolioSolicitud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "importeSolicitado"
        Me.DataGridViewTextBoxColumn7.HeaderText = "importeSolicitado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "razonSocial"
        Me.DataGridViewTextBoxColumn12.HeaderText = "razonSocial"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "fechaPago"
        Me.DataGridViewTextBoxColumn17.HeaderText = "fechaPago"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "referencia"
        Me.DataGridViewTextBoxColumn21.HeaderText = "referencia"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "fechaSolicitud"
        Me.DataGridViewTextBoxColumn25.HeaderText = "fechaSolicitud"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "ref"
        Me.DataGridViewTextBoxColumn26.HeaderText = "ref"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "estatusReemb"
        Me.DataGridViewTextBoxColumn27.HeaderText = "estatusReemb"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'frmContabilizarNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 368)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Vw_CXP_ContabilizarNominaDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmContabilizarNomina"
        Me.Text = "Contabilizar Nomina"
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_CXP_ContabilizarNominaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_CXP_ContabilizarNominaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsContabilidad As dsContabilidad
    Friend WithEvents Vw_CXP_ContabilizarNominaBindingSource As BindingSource
    Friend WithEvents Vw_CXP_ContabilizarNominaTableAdapter As dsContabilidadTableAdapters.Vw_CXP_ContabilizarNominaTableAdapter
    Friend WithEvents TableAdapterManager As dsContabilidadTableAdapters.TableAdapterManager
    Friend WithEvents Vw_CXP_ContabilizarNominaDataGridView As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents idFolioSolicitud As DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
