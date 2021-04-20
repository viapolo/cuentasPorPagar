<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContabilizaCheques
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
        Me.PagosConChequeDataGridView = New System.Windows.Forms.DataGridView()
        Me.PagosConChequeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContabilidad = New cuentasPorPagar.dsContabilidad()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PagosConChequeTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.PagosConChequeTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager()
        Me.tipoSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folioSolicitud = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estatusReemb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PagosConChequeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosConChequeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PagosConChequeDataGridView
        '
        Me.PagosConChequeDataGridView.AllowUserToAddRows = False
        Me.PagosConChequeDataGridView.AllowUserToDeleteRows = False
        Me.PagosConChequeDataGridView.AllowUserToOrderColumns = True
        Me.PagosConChequeDataGridView.AutoGenerateColumns = False
        Me.PagosConChequeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosConChequeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipoSolicitud, Me.folioSolicitud, Me.importe, Me.DataGridViewTextBoxColumn11, Me.idProveedor, Me.idConcepto, Me.nombre, Me.estatusReemb})
        Me.PagosConChequeDataGridView.DataSource = Me.PagosConChequeBindingSource
        Me.PagosConChequeDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.PagosConChequeDataGridView.Name = "PagosConChequeDataGridView"
        Me.PagosConChequeDataGridView.ReadOnly = True
        Me.PagosConChequeDataGridView.Size = New System.Drawing.Size(792, 400)
        Me.PagosConChequeDataGridView.TabIndex = 2
        '
        'PagosConChequeBindingSource
        '
        Me.PagosConChequeBindingSource.DataMember = "PagosConCheque"
        Me.PagosConChequeBindingSource.DataSource = Me.DsContabilidad
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "dsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(729, 418)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PagosConChequeTableAdapter
        '
        Me.PagosConChequeTableAdapter.ClearBeforeFill = True
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
        'tipoSolicitud
        '
        Me.tipoSolicitud.DataPropertyName = "tipoSolicitud"
        Me.tipoSolicitud.HeaderText = "Tipo Solicitud"
        Me.tipoSolicitud.Name = "tipoSolicitud"
        Me.tipoSolicitud.ReadOnly = True
        '
        'folioSolicitud
        '
        Me.folioSolicitud.DataPropertyName = "folioSolicitud"
        Me.folioSolicitud.HeaderText = "Folio Solicitud"
        Me.folioSolicitud.Name = "folioSolicitud"
        Me.folioSolicitud.ReadOnly = True
        Me.folioSolicitud.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.folioSolicitud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'importe
        '
        Me.importe.DataPropertyName = "importe"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.importe.DefaultCellStyle = DataGridViewCellStyle1
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "fechaProgPago"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Fecha Prog de Pago"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'idProveedor
        '
        Me.idProveedor.DataPropertyName = "idProveedor"
        Me.idProveedor.HeaderText = "idProveedor"
        Me.idProveedor.Name = "idProveedor"
        Me.idProveedor.ReadOnly = True
        '
        'idConcepto
        '
        Me.idConcepto.DataPropertyName = "idConcepto"
        Me.idConcepto.HeaderText = "idConcepto"
        Me.idConcepto.Name = "idConcepto"
        Me.idConcepto.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'estatusReemb
        '
        Me.estatusReemb.DataPropertyName = "estatusReemb"
        Me.estatusReemb.HeaderText = "estatusReemb"
        Me.estatusReemb.Name = "estatusReemb"
        Me.estatusReemb.ReadOnly = True
        '
        'frmContabilizaCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.PagosConChequeDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmContabilizaCheques"
        Me.Text = "Contabilizar Cheques"
        CType(Me.PagosConChequeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosConChequeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsContabilidad As dsContabilidad
    Friend WithEvents PagosConChequeBindingSource As BindingSource
    Friend WithEvents PagosConChequeTableAdapter As dsContabilidadTableAdapters.PagosConChequeTableAdapter
    Friend WithEvents TableAdapterManager As dsContabilidadTableAdapters.TableAdapterManager
    Friend WithEvents PagosConChequeDataGridView As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents tipoSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents folioSolicitud As DataGridViewLinkColumn
    Friend WithEvents importe As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents idProveedor As DataGridViewTextBoxColumn
    Friend WithEvents idConcepto As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents estatusReemb As DataGridViewTextBoxColumn
End Class
