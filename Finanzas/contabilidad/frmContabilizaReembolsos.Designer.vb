<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContabilizaReembolsos
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
        Me.Vw_CXP_MisSolicitudesSCDataGridView = New System.Windows.Forms.DataGridView()
        Me.Vw_CXP_MisSolicitudesSCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContabilidad = New cuentasPorPagar.dsContabilidad()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vw_CXP_MisSolicitudesSCTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.Vw_CXP_MisSolicitudesSCTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.idFolioSolicitud = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.razonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monedaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Vw_CXP_MisSolicitudesSCDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_CXP_MisSolicitudesSCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Vw_CXP_MisSolicitudesSCDataGridView
        '
        Me.Vw_CXP_MisSolicitudesSCDataGridView.AllowUserToAddRows = False
        Me.Vw_CXP_MisSolicitudesSCDataGridView.AllowUserToDeleteRows = False
        Me.Vw_CXP_MisSolicitudesSCDataGridView.AutoGenerateColumns = False
        Me.Vw_CXP_MisSolicitudesSCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vw_CXP_MisSolicitudesSCDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idFolioSolicitud, Me.fecha, Me.total, Me.razonSocial, Me.usuario, Me.fechaSolicitud, Me.fPago, Me.monedaPago})
        Me.Vw_CXP_MisSolicitudesSCDataGridView.DataSource = Me.Vw_CXP_MisSolicitudesSCBindingSource
        Me.Vw_CXP_MisSolicitudesSCDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.Vw_CXP_MisSolicitudesSCDataGridView.Name = "Vw_CXP_MisSolicitudesSCDataGridView"
        Me.Vw_CXP_MisSolicitudesSCDataGridView.ReadOnly = True
        Me.Vw_CXP_MisSolicitudesSCDataGridView.Size = New System.Drawing.Size(976, 305)
        Me.Vw_CXP_MisSolicitudesSCDataGridView.TabIndex = 2
        '
        'Vw_CXP_MisSolicitudesSCBindingSource
        '
        Me.Vw_CXP_MisSolicitudesSCBindingSource.DataMember = "Vw_CXP_MisSolicitudesSC"
        Me.Vw_CXP_MisSolicitudesSCBindingSource.DataSource = Me.DsContabilidad
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "dsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "folioSolicitud"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fol Solicitud"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fechaSolicitud"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "totalPagado"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "razonSocial"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "usuario"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Vw_CXP_MisSolicitudesSCTableAdapter
        '
        Me.Vw_CXP_MisSolicitudesSCTableAdapter.ClearBeforeFill = True
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
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(913, 339)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'idFolioSolicitud
        '
        Me.idFolioSolicitud.DataPropertyName = "folioSolicitud"
        Me.idFolioSolicitud.HeaderText = "Fol Solicitud"
        Me.idFolioSolicitud.Name = "idFolioSolicitud"
        Me.idFolioSolicitud.ReadOnly = True
        Me.idFolioSolicitud.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idFolioSolicitud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fechaSolicitud"
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'total
        '
        Me.total.DataPropertyName = "totalPagado"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.total.DefaultCellStyle = DataGridViewCellStyle1
        Me.total.HeaderText = "Importe"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'razonSocial
        '
        Me.razonSocial.DataPropertyName = "razonSocial"
        Me.razonSocial.HeaderText = "Razón Social"
        Me.razonSocial.Name = "razonSocial"
        Me.razonSocial.ReadOnly = True
        Me.razonSocial.Width = 300
        '
        'usuario
        '
        Me.usuario.DataPropertyName = "usuario"
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'fechaSolicitud
        '
        Me.fechaSolicitud.DataPropertyName = "fechaSolicitud"
        Me.fechaSolicitud.HeaderText = "fechaSolicitud"
        Me.fechaSolicitud.Name = "fechaSolicitud"
        Me.fechaSolicitud.ReadOnly = True
        Me.fechaSolicitud.Visible = False
        '
        'fPago
        '
        Me.fPago.DataPropertyName = "fPago"
        Me.fPago.HeaderText = "fPago"
        Me.fPago.Name = "fPago"
        Me.fPago.ReadOnly = True
        Me.fPago.Visible = False
        '
        'monedaPago
        '
        Me.monedaPago.DataPropertyName = "monedaPago"
        Me.monedaPago.HeaderText = "monedaPago"
        Me.monedaPago.Name = "monedaPago"
        Me.monedaPago.ReadOnly = True
        Me.monedaPago.Visible = False
        '
        'frmContabilizaReembolsos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 374)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Vw_CXP_MisSolicitudesSCDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmContabilizaReembolsos"
        Me.Text = "Evento Contable Reembolsos"
        CType(Me.Vw_CXP_MisSolicitudesSCDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_CXP_MisSolicitudesSCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsContabilidad As dsContabilidad
    Friend WithEvents Vw_CXP_MisSolicitudesSCBindingSource As BindingSource
    Friend WithEvents Vw_CXP_MisSolicitudesSCTableAdapter As dsContabilidadTableAdapters.Vw_CXP_MisSolicitudesSCTableAdapter
    Friend WithEvents TableAdapterManager As dsContabilidadTableAdapters.TableAdapterManager
    Friend WithEvents Vw_CXP_MisSolicitudesSCDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents idFolioSolicitud As DataGridViewLinkColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents razonSocial As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents fechaSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents fPago As DataGridViewTextBoxColumn
    Friend WithEvents monedaPago As DataGridViewTextBoxColumn
End Class
