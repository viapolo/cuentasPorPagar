<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentosAdjuntos
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
        Me.lnkFolioSolicitud = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DsTesoreria = New cuentasPorPagar.dsTesoreria()
        Me.CXP_PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_PagosTableAdapter = New cuentasPorPagar.dsTesoreriaTableAdapters.CXP_PagosTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsTesoreriaTableAdapters.TableAdapterManager()
        Me.CXP_PagosDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.decripcion = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.IdPagosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UuidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalPagadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPagadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrasladosPagadosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetencionesPagadasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DecripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdConceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParcialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpresasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Autoriza1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Autoriza2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ok1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ok2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContratoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NoContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAutoriza2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NaAutoriza2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NaAutoriza1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCostosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCuentasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDeCambioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonedaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DsTesoreria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_PagosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnkFolioSolicitud
        '
        Me.lnkFolioSolicitud.AutoSize = True
        Me.lnkFolioSolicitud.Location = New System.Drawing.Point(68, 13)
        Me.lnkFolioSolicitud.Name = "lnkFolioSolicitud"
        Me.lnkFolioSolicitud.Size = New System.Drawing.Size(59, 13)
        Me.lnkFolioSolicitud.TabIndex = 1
        Me.lnkFolioSolicitud.TabStop = True
        Me.lnkFolioSolicitud.Text = "LinkLabel1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Solicitud:"
        '
        'DsTesoreria
        '
        Me.DsTesoreria.DataSetName = "dsTesoreria"
        Me.DsTesoreria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_PagosBindingSource
        '
        Me.CXP_PagosBindingSource.DataMember = "CXP_Pagos"
        Me.CXP_PagosBindingSource.DataSource = Me.DsTesoreria
        '
        'CXP_PagosTableAdapter
        '
        Me.CXP_PagosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CXP_CuentasBancariasProvTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PagosTableAdapter = Me.CXP_PagosTableAdapter
        Me.TableAdapterManager.CXP_PagosTesoreriaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_RegContTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsTesoreriaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_PagosDataGridView
        '
        Me.CXP_PagosDataGridView.AllowUserToAddRows = False
        Me.CXP_PagosDataGridView.AllowUserToDeleteRows = False
        Me.CXP_PagosDataGridView.AutoGenerateColumns = False
        Me.CXP_PagosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CXP_PagosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CXP_PagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CXP_PagosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serie, Me.folio, Me.uuid, Me.decripcion, Me.IdPagosDataGridViewTextBoxColumn, Me.IdProveedorDataGridViewTextBoxColumn, Me.IdUsuarioDataGridViewTextBoxColumn, Me.FolioSolicitudDataGridViewTextBoxColumn, Me.FechaSolicitudDataGridViewTextBoxColumn, Me.FechaFacturaDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.FolioDataGridViewTextBoxColumn, Me.UuidDataGridViewTextBoxColumn, Me.SubtotalPagadoDataGridViewTextBoxColumn, Me.TotalPagadoDataGridViewTextBoxColumn, Me.TrasladosPagadosDataGridViewTextBoxColumn, Me.RetencionesPagadasDataGridViewTextBoxColumn, Me.DecripcionDataGridViewTextBoxColumn, Me.IdConceptoDataGridViewTextBoxColumn, Me.ParcialidadDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.IdEmpresasDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.Autoriza1DataGridViewTextBoxColumn, Me.Autoriza2DataGridViewTextBoxColumn, Me.Ok1DataGridViewTextBoxColumn, Me.Ok2DataGridViewTextBoxColumn, Me.MonedaDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn, Me.ContratoDataGridViewCheckBoxColumn, Me.NoContratoDataGridViewTextBoxColumn, Me.IdAutoriza2DataGridViewTextBoxColumn, Me.NaAutoriza2DataGridViewTextBoxColumn, Me.NaAutoriza1DataGridViewTextBoxColumn, Me.CCostosDataGridViewTextBoxColumn, Me.FPagoDataGridViewTextBoxColumn, Me.IdCuentasDataGridViewTextBoxColumn, Me.TipoDeCambioDataGridViewTextBoxColumn, Me.MonedaPagoDataGridViewTextBoxColumn})
        Me.CXP_PagosDataGridView.DataSource = Me.CXP_PagosBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CXP_PagosDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.CXP_PagosDataGridView.Location = New System.Drawing.Point(12, 41)
        Me.CXP_PagosDataGridView.Name = "CXP_PagosDataGridView"
        Me.CXP_PagosDataGridView.ReadOnly = True
        Me.CXP_PagosDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CXP_PagosDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.CXP_PagosDataGridView.RowHeadersVisible = False
        Me.CXP_PagosDataGridView.Size = New System.Drawing.Size(526, 184)
        Me.CXP_PagosDataGridView.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(463, 231)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "serie"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Serie"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "folio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "decripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Decripción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'serie
        '
        Me.serie.DataPropertyName = "serie"
        Me.serie.HeaderText = "Serie"
        Me.serie.Name = "serie"
        Me.serie.ReadOnly = True
        Me.serie.Width = 50
        '
        'folio
        '
        Me.folio.DataPropertyName = "folio"
        Me.folio.HeaderText = "Folio"
        Me.folio.Name = "folio"
        Me.folio.ReadOnly = True
        Me.folio.Width = 50
        '
        'uuid
        '
        Me.uuid.DataPropertyName = "uuid"
        Me.uuid.HeaderText = "uuid"
        Me.uuid.Name = "uuid"
        Me.uuid.ReadOnly = True
        Me.uuid.Width = 50
        '
        'decripcion
        '
        Me.decripcion.DataPropertyName = "decripcion"
        Me.decripcion.HeaderText = "Decripción"
        Me.decripcion.Name = "decripcion"
        Me.decripcion.ReadOnly = True
        Me.decripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.decripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.decripcion.Width = 350
        '
        'IdPagosDataGridViewTextBoxColumn
        '
        Me.IdPagosDataGridViewTextBoxColumn.DataPropertyName = "idPagos"
        Me.IdPagosDataGridViewTextBoxColumn.HeaderText = "idPagos"
        Me.IdPagosDataGridViewTextBoxColumn.Name = "IdPagosDataGridViewTextBoxColumn"
        Me.IdPagosDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPagosDataGridViewTextBoxColumn.Visible = False
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "idProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        Me.IdProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProveedorDataGridViewTextBoxColumn.Visible = False
        '
        'IdUsuarioDataGridViewTextBoxColumn
        '
        Me.IdUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.Name = "IdUsuarioDataGridViewTextBoxColumn"
        Me.IdUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdUsuarioDataGridViewTextBoxColumn.Visible = False
        '
        'FolioSolicitudDataGridViewTextBoxColumn
        '
        Me.FolioSolicitudDataGridViewTextBoxColumn.DataPropertyName = "folioSolicitud"
        Me.FolioSolicitudDataGridViewTextBoxColumn.HeaderText = "folioSolicitud"
        Me.FolioSolicitudDataGridViewTextBoxColumn.Name = "FolioSolicitudDataGridViewTextBoxColumn"
        Me.FolioSolicitudDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioSolicitudDataGridViewTextBoxColumn.Visible = False
        '
        'FechaSolicitudDataGridViewTextBoxColumn
        '
        Me.FechaSolicitudDataGridViewTextBoxColumn.DataPropertyName = "fechaSolicitud"
        Me.FechaSolicitudDataGridViewTextBoxColumn.HeaderText = "fechaSolicitud"
        Me.FechaSolicitudDataGridViewTextBoxColumn.Name = "FechaSolicitudDataGridViewTextBoxColumn"
        Me.FechaSolicitudDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaSolicitudDataGridViewTextBoxColumn.Visible = False
        '
        'FechaFacturaDataGridViewTextBoxColumn
        '
        Me.FechaFacturaDataGridViewTextBoxColumn.DataPropertyName = "fechaFactura"
        Me.FechaFacturaDataGridViewTextBoxColumn.HeaderText = "fechaFactura"
        Me.FechaFacturaDataGridViewTextBoxColumn.Name = "FechaFacturaDataGridViewTextBoxColumn"
        Me.FechaFacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaFacturaDataGridViewTextBoxColumn.Visible = False
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        Me.SerieDataGridViewTextBoxColumn.ReadOnly = True
        Me.SerieDataGridViewTextBoxColumn.Visible = False
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "folio"
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "folio"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioDataGridViewTextBoxColumn.Visible = False
        '
        'UuidDataGridViewTextBoxColumn
        '
        Me.UuidDataGridViewTextBoxColumn.DataPropertyName = "uuid"
        Me.UuidDataGridViewTextBoxColumn.HeaderText = "uuid"
        Me.UuidDataGridViewTextBoxColumn.Name = "UuidDataGridViewTextBoxColumn"
        Me.UuidDataGridViewTextBoxColumn.ReadOnly = True
        Me.UuidDataGridViewTextBoxColumn.Visible = False
        '
        'SubtotalPagadoDataGridViewTextBoxColumn
        '
        Me.SubtotalPagadoDataGridViewTextBoxColumn.DataPropertyName = "subtotalPagado"
        Me.SubtotalPagadoDataGridViewTextBoxColumn.HeaderText = "subtotalPagado"
        Me.SubtotalPagadoDataGridViewTextBoxColumn.Name = "SubtotalPagadoDataGridViewTextBoxColumn"
        Me.SubtotalPagadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubtotalPagadoDataGridViewTextBoxColumn.Visible = False
        '
        'TotalPagadoDataGridViewTextBoxColumn
        '
        Me.TotalPagadoDataGridViewTextBoxColumn.DataPropertyName = "totalPagado"
        Me.TotalPagadoDataGridViewTextBoxColumn.HeaderText = "totalPagado"
        Me.TotalPagadoDataGridViewTextBoxColumn.Name = "TotalPagadoDataGridViewTextBoxColumn"
        Me.TotalPagadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalPagadoDataGridViewTextBoxColumn.Visible = False
        '
        'TrasladosPagadosDataGridViewTextBoxColumn
        '
        Me.TrasladosPagadosDataGridViewTextBoxColumn.DataPropertyName = "trasladosPagados"
        Me.TrasladosPagadosDataGridViewTextBoxColumn.HeaderText = "trasladosPagados"
        Me.TrasladosPagadosDataGridViewTextBoxColumn.Name = "TrasladosPagadosDataGridViewTextBoxColumn"
        Me.TrasladosPagadosDataGridViewTextBoxColumn.ReadOnly = True
        Me.TrasladosPagadosDataGridViewTextBoxColumn.Visible = False
        '
        'RetencionesPagadasDataGridViewTextBoxColumn
        '
        Me.RetencionesPagadasDataGridViewTextBoxColumn.DataPropertyName = "retencionesPagadas"
        Me.RetencionesPagadasDataGridViewTextBoxColumn.HeaderText = "retencionesPagadas"
        Me.RetencionesPagadasDataGridViewTextBoxColumn.Name = "RetencionesPagadasDataGridViewTextBoxColumn"
        Me.RetencionesPagadasDataGridViewTextBoxColumn.ReadOnly = True
        Me.RetencionesPagadasDataGridViewTextBoxColumn.Visible = False
        '
        'DecripcionDataGridViewTextBoxColumn
        '
        Me.DecripcionDataGridViewTextBoxColumn.DataPropertyName = "decripcion"
        Me.DecripcionDataGridViewTextBoxColumn.HeaderText = "decripcion"
        Me.DecripcionDataGridViewTextBoxColumn.Name = "DecripcionDataGridViewTextBoxColumn"
        Me.DecripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DecripcionDataGridViewTextBoxColumn.Visible = False
        '
        'IdConceptoDataGridViewTextBoxColumn
        '
        Me.IdConceptoDataGridViewTextBoxColumn.DataPropertyName = "idConcepto"
        Me.IdConceptoDataGridViewTextBoxColumn.HeaderText = "idConcepto"
        Me.IdConceptoDataGridViewTextBoxColumn.Name = "IdConceptoDataGridViewTextBoxColumn"
        Me.IdConceptoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdConceptoDataGridViewTextBoxColumn.Visible = False
        '
        'ParcialidadDataGridViewTextBoxColumn
        '
        Me.ParcialidadDataGridViewTextBoxColumn.DataPropertyName = "parcialidad"
        Me.ParcialidadDataGridViewTextBoxColumn.HeaderText = "parcialidad"
        Me.ParcialidadDataGridViewTextBoxColumn.Name = "ParcialidadDataGridViewTextBoxColumn"
        Me.ParcialidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.ParcialidadDataGridViewTextBoxColumn.Visible = False
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Visible = False
        '
        'IdEmpresasDataGridViewTextBoxColumn
        '
        Me.IdEmpresasDataGridViewTextBoxColumn.DataPropertyName = "idEmpresas"
        Me.IdEmpresasDataGridViewTextBoxColumn.HeaderText = "idEmpresas"
        Me.IdEmpresasDataGridViewTextBoxColumn.Name = "IdEmpresasDataGridViewTextBoxColumn"
        Me.IdEmpresasDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdEmpresasDataGridViewTextBoxColumn.Visible = False
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Visible = False
        '
        'Autoriza1DataGridViewTextBoxColumn
        '
        Me.Autoriza1DataGridViewTextBoxColumn.DataPropertyName = "autoriza1"
        Me.Autoriza1DataGridViewTextBoxColumn.HeaderText = "autoriza1"
        Me.Autoriza1DataGridViewTextBoxColumn.Name = "Autoriza1DataGridViewTextBoxColumn"
        Me.Autoriza1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Autoriza1DataGridViewTextBoxColumn.Visible = False
        '
        'Autoriza2DataGridViewTextBoxColumn
        '
        Me.Autoriza2DataGridViewTextBoxColumn.DataPropertyName = "autoriza2"
        Me.Autoriza2DataGridViewTextBoxColumn.HeaderText = "autoriza2"
        Me.Autoriza2DataGridViewTextBoxColumn.Name = "Autoriza2DataGridViewTextBoxColumn"
        Me.Autoriza2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Autoriza2DataGridViewTextBoxColumn.Visible = False
        '
        'Ok1DataGridViewTextBoxColumn
        '
        Me.Ok1DataGridViewTextBoxColumn.DataPropertyName = "ok1"
        Me.Ok1DataGridViewTextBoxColumn.HeaderText = "ok1"
        Me.Ok1DataGridViewTextBoxColumn.Name = "Ok1DataGridViewTextBoxColumn"
        Me.Ok1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Ok1DataGridViewTextBoxColumn.Visible = False
        '
        'Ok2DataGridViewTextBoxColumn
        '
        Me.Ok2DataGridViewTextBoxColumn.DataPropertyName = "ok2"
        Me.Ok2DataGridViewTextBoxColumn.HeaderText = "ok2"
        Me.Ok2DataGridViewTextBoxColumn.Name = "Ok2DataGridViewTextBoxColumn"
        Me.Ok2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Ok2DataGridViewTextBoxColumn.Visible = False
        '
        'MonedaDataGridViewTextBoxColumn
        '
        Me.MonedaDataGridViewTextBoxColumn.DataPropertyName = "moneda"
        Me.MonedaDataGridViewTextBoxColumn.HeaderText = "moneda"
        Me.MonedaDataGridViewTextBoxColumn.Name = "MonedaDataGridViewTextBoxColumn"
        Me.MonedaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MonedaDataGridViewTextBoxColumn.Visible = False
        '
        'FechaPagoDataGridViewTextBoxColumn
        '
        Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "fechaPago"
        Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "fechaPago"
        Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
        Me.FechaPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaPagoDataGridViewTextBoxColumn.Visible = False
        '
        'ContratoDataGridViewCheckBoxColumn
        '
        Me.ContratoDataGridViewCheckBoxColumn.DataPropertyName = "contrato"
        Me.ContratoDataGridViewCheckBoxColumn.HeaderText = "contrato"
        Me.ContratoDataGridViewCheckBoxColumn.Name = "ContratoDataGridViewCheckBoxColumn"
        Me.ContratoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ContratoDataGridViewCheckBoxColumn.Visible = False
        '
        'NoContratoDataGridViewTextBoxColumn
        '
        Me.NoContratoDataGridViewTextBoxColumn.DataPropertyName = "noContrato"
        Me.NoContratoDataGridViewTextBoxColumn.HeaderText = "noContrato"
        Me.NoContratoDataGridViewTextBoxColumn.Name = "NoContratoDataGridViewTextBoxColumn"
        Me.NoContratoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoContratoDataGridViewTextBoxColumn.Visible = False
        '
        'IdAutoriza2DataGridViewTextBoxColumn
        '
        Me.IdAutoriza2DataGridViewTextBoxColumn.DataPropertyName = "idAutoriza2"
        Me.IdAutoriza2DataGridViewTextBoxColumn.HeaderText = "idAutoriza2"
        Me.IdAutoriza2DataGridViewTextBoxColumn.Name = "IdAutoriza2DataGridViewTextBoxColumn"
        Me.IdAutoriza2DataGridViewTextBoxColumn.ReadOnly = True
        Me.IdAutoriza2DataGridViewTextBoxColumn.Visible = False
        '
        'NaAutoriza2DataGridViewTextBoxColumn
        '
        Me.NaAutoriza2DataGridViewTextBoxColumn.DataPropertyName = "naAutoriza2"
        Me.NaAutoriza2DataGridViewTextBoxColumn.HeaderText = "naAutoriza2"
        Me.NaAutoriza2DataGridViewTextBoxColumn.Name = "NaAutoriza2DataGridViewTextBoxColumn"
        Me.NaAutoriza2DataGridViewTextBoxColumn.ReadOnly = True
        Me.NaAutoriza2DataGridViewTextBoxColumn.Visible = False
        '
        'NaAutoriza1DataGridViewTextBoxColumn
        '
        Me.NaAutoriza1DataGridViewTextBoxColumn.DataPropertyName = "naAutoriza1"
        Me.NaAutoriza1DataGridViewTextBoxColumn.HeaderText = "naAutoriza1"
        Me.NaAutoriza1DataGridViewTextBoxColumn.Name = "NaAutoriza1DataGridViewTextBoxColumn"
        Me.NaAutoriza1DataGridViewTextBoxColumn.ReadOnly = True
        Me.NaAutoriza1DataGridViewTextBoxColumn.Visible = False
        '
        'CCostosDataGridViewTextBoxColumn
        '
        Me.CCostosDataGridViewTextBoxColumn.DataPropertyName = "cCostos"
        Me.CCostosDataGridViewTextBoxColumn.HeaderText = "cCostos"
        Me.CCostosDataGridViewTextBoxColumn.Name = "CCostosDataGridViewTextBoxColumn"
        Me.CCostosDataGridViewTextBoxColumn.ReadOnly = True
        Me.CCostosDataGridViewTextBoxColumn.Visible = False
        '
        'FPagoDataGridViewTextBoxColumn
        '
        Me.FPagoDataGridViewTextBoxColumn.DataPropertyName = "fPago"
        Me.FPagoDataGridViewTextBoxColumn.HeaderText = "fPago"
        Me.FPagoDataGridViewTextBoxColumn.Name = "FPagoDataGridViewTextBoxColumn"
        Me.FPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FPagoDataGridViewTextBoxColumn.Visible = False
        '
        'IdCuentasDataGridViewTextBoxColumn
        '
        Me.IdCuentasDataGridViewTextBoxColumn.DataPropertyName = "idCuentas"
        Me.IdCuentasDataGridViewTextBoxColumn.HeaderText = "idCuentas"
        Me.IdCuentasDataGridViewTextBoxColumn.Name = "IdCuentasDataGridViewTextBoxColumn"
        Me.IdCuentasDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCuentasDataGridViewTextBoxColumn.Visible = False
        '
        'TipoDeCambioDataGridViewTextBoxColumn
        '
        Me.TipoDeCambioDataGridViewTextBoxColumn.DataPropertyName = "tipoDeCambio"
        Me.TipoDeCambioDataGridViewTextBoxColumn.HeaderText = "tipoDeCambio"
        Me.TipoDeCambioDataGridViewTextBoxColumn.Name = "TipoDeCambioDataGridViewTextBoxColumn"
        Me.TipoDeCambioDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDeCambioDataGridViewTextBoxColumn.Visible = False
        '
        'MonedaPagoDataGridViewTextBoxColumn
        '
        Me.MonedaPagoDataGridViewTextBoxColumn.DataPropertyName = "monedaPago"
        Me.MonedaPagoDataGridViewTextBoxColumn.HeaderText = "monedaPago"
        Me.MonedaPagoDataGridViewTextBoxColumn.Name = "MonedaPagoDataGridViewTextBoxColumn"
        Me.MonedaPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MonedaPagoDataGridViewTextBoxColumn.Visible = False
        '
        'frmDocumentosAdjuntos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 266)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CXP_PagosDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lnkFolioSolicitud)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmDocumentosAdjuntos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Documentos adjuntos"
        CType(Me.DsTesoreria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_PagosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lnkFolioSolicitud As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents DsTesoreria As dsTesoreria
    Friend WithEvents CXP_PagosTableAdapter As dsTesoreriaTableAdapters.CXP_PagosTableAdapter
    Friend WithEvents TableAdapterManager As dsTesoreriaTableAdapters.TableAdapterManager
    Friend WithEvents CXP_PagosDataGridView As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Protected WithEvents CXP_PagosBindingSource As BindingSource
    Friend WithEvents serie As DataGridViewTextBoxColumn
    Friend WithEvents folio As DataGridViewTextBoxColumn
    Friend WithEvents uuid As DataGridViewTextBoxColumn
    Friend WithEvents decripcion As DataGridViewLinkColumn
    Friend WithEvents IdPagosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FolioSolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FolioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UuidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalPagadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPagadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrasladosPagadosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RetencionesPagadasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DecripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdConceptoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ParcialidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpresasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Autoriza1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Autoriza2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Ok1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Ok2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonedaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContratoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents NoContratoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdAutoriza2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NaAutoriza2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NaAutoriza1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CCostosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCuentasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDeCambioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonedaPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
