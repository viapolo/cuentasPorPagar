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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Vw_CXP_SugPagoTesoreriaDataGridView = New System.Windows.Forms.DataGridView()
        Me.folioSolicitud = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estatusPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importeSolicitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bancoBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuentaBeneficiaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clabeBeneficiaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.convenio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaProgPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.razonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formaDePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idBancoBen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noContrato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaProceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vw_CXP_SugPagoTesoreriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTesoreria = New cuentasPorPagar.dsTesoreria()
        Me.dtpFechaPagoInicial = New System.Windows.Forms.DateTimePicker()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnSeleccionarTodo = New System.Windows.Forms.Button()
        Me.btnGenerarLayOut = New System.Windows.Forms.Button()
        Me.btnSeleccionarNada = New System.Windows.Forms.Button()
        Me.gbxSeleccionar = New System.Windows.Forms.GroupBox()
        Me.gbxLayout = New System.Windows.Forms.GroupBox()
        Me.sfdTxtBancario = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ofdComprobantePago = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPdfConfirmacion = New System.Windows.Forms.Button()
        Me.ofdPdfConfirmacion = New System.Windows.Forms.OpenFileDialog()
        Me.dtpFechaPagoFinal = New System.Windows.Forms.DateTimePicker()
        Me.gpbFechas = New System.Windows.Forms.GroupBox()
        Me.gpbEstatus = New System.Windows.Forms.GroupBox()
        Me.rbtnPagada = New System.Windows.Forms.RadioButton()
        Me.rbtnNoPagada = New System.Windows.Forms.RadioButton()
        Me.rbtnProcesoPago = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkConvenio = New System.Windows.Forms.CheckBox()
        Me.chkTranferencia = New System.Windows.Forms.CheckBox()
        Me.pbxCargando = New System.Windows.Forms.PictureBox()
        Me.cblTipoSolicitud = New System.Windows.Forms.CheckedListBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaPersonalizada1 = New cuentasPorPagar.ColumnaPersonalizada()
        Me.CXPCuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_CXP_SugPagoTesoreriaTableAdapter = New cuentasPorPagar.dsTesoreriaTableAdapters.Vw_CXP_SugPagoTesoreriaTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsTesoreriaTableAdapters.TableAdapterManager()
        Me.CXP_CuentasBancariasTableAdapter = New cuentasPorPagar.dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter()
        CType(Me.Vw_CXP_SugPagoTesoreriaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_CXP_SugPagoTesoreriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTesoreria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxSeleccionar.SuspendLayout()
        Me.gbxLayout.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gpbFechas.SuspendLayout()
        Me.gpbEstatus.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbxCargando, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Vw_CXP_SugPagoTesoreriaDataGridView
        '
        Me.Vw_CXP_SugPagoTesoreriaDataGridView.AllowUserToAddRows = False
        Me.Vw_CXP_SugPagoTesoreriaDataGridView.AllowUserToDeleteRows = False
        Me.Vw_CXP_SugPagoTesoreriaDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Vw_CXP_SugPagoTesoreriaDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Vw_CXP_SugPagoTesoreriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vw_CXP_SugPagoTesoreriaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.folioSolicitud, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn21, Me.estatusPago, Me.tipoSolicitud, Me.idEmpresa, Me.importeSolicitado, Me.Tipar, Me.moneda, Me.seleccionar, Me.bancoBeneficiario, Me.cuentaBeneficiaria, Me.clabeBeneficiaria, Me.convenio, Me.referencia, Me.DataGridViewTextBoxColumn20, Me.fechaProgPago, Me.razonSocial, Me.formaDePago, Me.idBancoBen, Me.noContrato, Me.nombre, Me.fechaPago, Me.fechaProceso})
        Me.Vw_CXP_SugPagoTesoreriaDataGridView.DataSource = Me.Vw_CXP_SugPagoTesoreriaBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Vw_CXP_SugPagoTesoreriaDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.Vw_CXP_SugPagoTesoreriaDataGridView.Location = New System.Drawing.Point(12, 68)
        Me.Vw_CXP_SugPagoTesoreriaDataGridView.Name = "Vw_CXP_SugPagoTesoreriaDataGridView"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Vw_CXP_SugPagoTesoreriaDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Vw_CXP_SugPagoTesoreriaDataGridView.Size = New System.Drawing.Size(1224, 375)
        Me.Vw_CXP_SugPagoTesoreriaDataGridView.TabIndex = 2
        '
        'folioSolicitud
        '
        Me.folioSolicitud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.folioSolicitud.DataPropertyName = "folioSolicitud"
        Me.folioSolicitud.Frozen = True
        Me.folioSolicitud.HeaderText = "Folio Solicitud"
        Me.folioSolicitud.Name = "folioSolicitud"
        Me.folioSolicitud.ReadOnly = True
        Me.folioSolicitud.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.folioSolicitud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.folioSolicitud.Width = 5
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "importe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn7.Frozen = True
        Me.DataGridViewTextBoxColumn7.HeaderText = "importe"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "estatusSolicitud"
        Me.DataGridViewTextBoxColumn17.Frozen = True
        Me.DataGridViewTextBoxColumn17.HeaderText = "estatusSolicitud"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "ok2"
        Me.DataGridViewTextBoxColumn21.HeaderText = "ok2"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'estatusPago
        '
        Me.estatusPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.estatusPago.DataPropertyName = "estatusPago"
        Me.estatusPago.Frozen = True
        Me.estatusPago.HeaderText = "estatusPago"
        Me.estatusPago.Name = "estatusPago"
        Me.estatusPago.ReadOnly = True
        Me.estatusPago.Visible = False
        '
        'tipoSolicitud
        '
        Me.tipoSolicitud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.tipoSolicitud.DataPropertyName = "tipoSolicitud"
        Me.tipoSolicitud.Frozen = True
        Me.tipoSolicitud.HeaderText = "Tipo Sol"
        Me.tipoSolicitud.Name = "tipoSolicitud"
        Me.tipoSolicitud.ReadOnly = True
        Me.tipoSolicitud.Width = 5
        '
        'idEmpresa
        '
        Me.idEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.idEmpresa.DataPropertyName = "idEmpresa"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.idEmpresa.DefaultCellStyle = DataGridViewCellStyle3
        Me.idEmpresa.Frozen = True
        Me.idEmpresa.HeaderText = "idEmpresa"
        Me.idEmpresa.Name = "idEmpresa"
        Me.idEmpresa.ReadOnly = True
        Me.idEmpresa.Visible = False
        '
        'importeSolicitado
        '
        Me.importeSolicitado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.importeSolicitado.DataPropertyName = "importeSolicitado"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.importeSolicitado.DefaultCellStyle = DataGridViewCellStyle4
        Me.importeSolicitado.Frozen = True
        Me.importeSolicitado.HeaderText = "Imp Solicitado"
        Me.importeSolicitado.Name = "importeSolicitado"
        Me.importeSolicitado.ReadOnly = True
        Me.importeSolicitado.Width = 5
        '
        'Tipar
        '
        Me.Tipar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Tipar.DataPropertyName = "Tipar"
        Me.Tipar.Frozen = True
        Me.Tipar.HeaderText = "C"
        Me.Tipar.Name = "Tipar"
        Me.Tipar.ReadOnly = True
        Me.Tipar.Width = 39
        '
        'moneda
        '
        Me.moneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.moneda.DataPropertyName = "monedaPago"
        Me.moneda.Frozen = True
        Me.moneda.HeaderText = "Moneda"
        Me.moneda.Name = "moneda"
        Me.moneda.Width = 5
        '
        'seleccionar
        '
        Me.seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.seleccionar.Frozen = True
        Me.seleccionar.HeaderText = "Seleccionar"
        Me.seleccionar.Name = "seleccionar"
        Me.seleccionar.Width = 69
        '
        'bancoBeneficiario
        '
        Me.bancoBeneficiario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.bancoBeneficiario.Frozen = True
        Me.bancoBeneficiario.HeaderText = "Banco Beneficiario"
        Me.bancoBeneficiario.Name = "bancoBeneficiario"
        Me.bancoBeneficiario.ReadOnly = True
        Me.bancoBeneficiario.Width = 5
        '
        'cuentaBeneficiaria
        '
        Me.cuentaBeneficiaria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.cuentaBeneficiaria.Frozen = True
        Me.cuentaBeneficiaria.HeaderText = "Cuenta Beneficiaria"
        Me.cuentaBeneficiaria.Name = "cuentaBeneficiaria"
        Me.cuentaBeneficiaria.ReadOnly = True
        Me.cuentaBeneficiaria.Width = 5
        '
        'clabeBeneficiaria
        '
        Me.clabeBeneficiaria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.clabeBeneficiaria.Frozen = True
        Me.clabeBeneficiaria.HeaderText = "CLABE"
        Me.clabeBeneficiaria.Name = "clabeBeneficiaria"
        Me.clabeBeneficiaria.ReadOnly = True
        Me.clabeBeneficiaria.Width = 5
        '
        'convenio
        '
        Me.convenio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.convenio.HeaderText = "Convenio"
        Me.convenio.Name = "convenio"
        Me.convenio.ReadOnly = True
        Me.convenio.Width = 5
        '
        'referencia
        '
        Me.referencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.referencia.HeaderText = "Referencia"
        Me.referencia.Name = "referencia"
        Me.referencia.ReadOnly = True
        Me.referencia.Width = 5
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "ok1"
        Me.DataGridViewTextBoxColumn20.HeaderText = "ok1"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'fechaProgPago
        '
        Me.fechaProgPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.fechaProgPago.DataPropertyName = "fechaProgPago"
        Me.fechaProgPago.HeaderText = "Fecha Solicitud"
        Me.fechaProgPago.Name = "fechaProgPago"
        Me.fechaProgPago.Width = 5
        '
        'razonSocial
        '
        Me.razonSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.razonSocial.DataPropertyName = "razonSocial"
        Me.razonSocial.HeaderText = "Beneficiario"
        Me.razonSocial.Name = "razonSocial"
        Me.razonSocial.Width = 5
        '
        'formaDePago
        '
        Me.formaDePago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.formaDePago.DataPropertyName = "fPago"
        Me.formaDePago.HeaderText = "Forma de Pago"
        Me.formaDePago.Name = "formaDePago"
        Me.formaDePago.Width = 5
        '
        'idBancoBen
        '
        Me.idBancoBen.DataPropertyName = "destinoRecurso"
        Me.idBancoBen.HeaderText = "idBancoBen"
        Me.idBancoBen.Name = "idBancoBen"
        Me.idBancoBen.Visible = False
        '
        'noContrato
        '
        Me.noContrato.HeaderText = "noContrato"
        Me.noContrato.Name = "noContrato"
        Me.noContrato.Visible = False
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Visible = False
        '
        'fechaPago
        '
        Me.fechaPago.DataPropertyName = "fechaPago"
        Me.fechaPago.HeaderText = "fechaPago"
        Me.fechaPago.Name = "fechaPago"
        Me.fechaPago.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaPago.Visible = False
        '
        'fechaProceso
        '
        Me.fechaProceso.DataPropertyName = "fechaProceso"
        Me.fechaProceso.HeaderText = "fechaProceso"
        Me.fechaProceso.Name = "fechaProceso"
        Me.fechaProceso.Visible = False
        '
        'Vw_CXP_SugPagoTesoreriaBindingSource
        '
        Me.Vw_CXP_SugPagoTesoreriaBindingSource.DataMember = "Vw_CXP_SugPagoTesoreria"
        Me.Vw_CXP_SugPagoTesoreriaBindingSource.DataSource = Me.DsTesoreria
        '
        'DsTesoreria
        '
        Me.DsTesoreria.DataSetName = "dsTesoreria"
        Me.DsTesoreria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpFechaPagoInicial
        '
        Me.dtpFechaPagoInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPagoInicial.Location = New System.Drawing.Point(6, 19)
        Me.dtpFechaPagoInicial.Name = "dtpFechaPagoInicial"
        Me.dtpFechaPagoInicial.Size = New System.Drawing.Size(86, 20)
        Me.dtpFechaPagoInicial.TabIndex = 3
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(874, 35)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1161, 475)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        '
        'btnSeleccionarTodo
        '
        Me.btnSeleccionarTodo.Location = New System.Drawing.Point(6, 19)
        Me.btnSeleccionarTodo.Name = "btnSeleccionarTodo"
        Me.btnSeleccionarTodo.Size = New System.Drawing.Size(80, 23)
        Me.btnSeleccionarTodo.TabIndex = 8
        Me.btnSeleccionarTodo.Text = "Todo"
        Me.btnSeleccionarTodo.UseVisualStyleBackColor = True
        '
        'btnGenerarLayOut
        '
        Me.btnGenerarLayOut.Location = New System.Drawing.Point(8, 19)
        Me.btnGenerarLayOut.Name = "btnGenerarLayOut"
        Me.btnGenerarLayOut.Size = New System.Drawing.Size(137, 23)
        Me.btnGenerarLayOut.TabIndex = 9
        Me.btnGenerarLayOut.Text = "Generar txt"
        Me.btnGenerarLayOut.UseVisualStyleBackColor = True
        '
        'btnSeleccionarNada
        '
        Me.btnSeleccionarNada.Location = New System.Drawing.Point(92, 19)
        Me.btnSeleccionarNada.Name = "btnSeleccionarNada"
        Me.btnSeleccionarNada.Size = New System.Drawing.Size(80, 23)
        Me.btnSeleccionarNada.TabIndex = 10
        Me.btnSeleccionarNada.Text = "Nada"
        Me.btnSeleccionarNada.UseVisualStyleBackColor = True
        '
        'gbxSeleccionar
        '
        Me.gbxSeleccionar.Controls.Add(Me.btnSeleccionarTodo)
        Me.gbxSeleccionar.Controls.Add(Me.btnSeleccionarNada)
        Me.gbxSeleccionar.Enabled = False
        Me.gbxSeleccionar.Location = New System.Drawing.Point(12, 449)
        Me.gbxSeleccionar.Name = "gbxSeleccionar"
        Me.gbxSeleccionar.Size = New System.Drawing.Size(182, 53)
        Me.gbxSeleccionar.TabIndex = 11
        Me.gbxSeleccionar.TabStop = False
        Me.gbxSeleccionar.Text = "Selección:"
        '
        'gbxLayout
        '
        Me.gbxLayout.Controls.Add(Me.btnGenerarLayOut)
        Me.gbxLayout.Enabled = False
        Me.gbxLayout.Location = New System.Drawing.Point(240, 449)
        Me.gbxLayout.Name = "gbxLayout"
        Me.gbxLayout.Size = New System.Drawing.Size(155, 53)
        Me.gbxLayout.TabIndex = 12
        Me.gbxLayout.TabStop = False
        Me.gbxLayout.Text = "Layout Bancario:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPdfConfirmacion)
        Me.GroupBox1.Location = New System.Drawing.Point(518, 449)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 53)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comprobante de pago:"
        '
        'btnPdfConfirmacion
        '
        Me.btnPdfConfirmacion.Location = New System.Drawing.Point(8, 19)
        Me.btnPdfConfirmacion.Name = "btnPdfConfirmacion"
        Me.btnPdfConfirmacion.Size = New System.Drawing.Size(137, 23)
        Me.btnPdfConfirmacion.TabIndex = 9
        Me.btnPdfConfirmacion.Text = "Subir PDF"
        Me.btnPdfConfirmacion.UseVisualStyleBackColor = True
        '
        'ofdPdfConfirmacion
        '
        Me.ofdPdfConfirmacion.FileName = "OpenFileDialog1"
        '
        'dtpFechaPagoFinal
        '
        Me.dtpFechaPagoFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPagoFinal.Location = New System.Drawing.Point(122, 19)
        Me.dtpFechaPagoFinal.Name = "dtpFechaPagoFinal"
        Me.dtpFechaPagoFinal.Size = New System.Drawing.Size(86, 20)
        Me.dtpFechaPagoFinal.TabIndex = 15
        '
        'gpbFechas
        '
        Me.gpbFechas.Controls.Add(Me.dtpFechaPagoFinal)
        Me.gpbFechas.Controls.Add(Me.dtpFechaPagoInicial)
        Me.gpbFechas.Location = New System.Drawing.Point(12, 8)
        Me.gpbFechas.Name = "gpbFechas"
        Me.gpbFechas.Size = New System.Drawing.Size(214, 54)
        Me.gpbFechas.TabIndex = 16
        Me.gpbFechas.TabStop = False
        Me.gpbFechas.Text = "Fecha Inicial - Fecha final:"
        '
        'gpbEstatus
        '
        Me.gpbEstatus.Controls.Add(Me.rbtnPagada)
        Me.gpbEstatus.Controls.Add(Me.rbtnNoPagada)
        Me.gpbEstatus.Controls.Add(Me.rbtnProcesoPago)
        Me.gpbEstatus.Location = New System.Drawing.Point(446, 8)
        Me.gpbEstatus.Name = "gpbEstatus"
        Me.gpbEstatus.Size = New System.Drawing.Size(254, 54)
        Me.gpbEstatus.TabIndex = 17
        Me.gpbEstatus.TabStop = False
        Me.gpbEstatus.Text = "Estatus:"
        '
        'rbtnPagada
        '
        Me.rbtnPagada.AutoSize = True
        Me.rbtnPagada.Location = New System.Drawing.Point(145, 13)
        Me.rbtnPagada.Name = "rbtnPagada"
        Me.rbtnPagada.Size = New System.Drawing.Size(62, 17)
        Me.rbtnPagada.TabIndex = 22
        Me.rbtnPagada.Text = "Pagada"
        Me.rbtnPagada.UseVisualStyleBackColor = True
        '
        'rbtnNoPagada
        '
        Me.rbtnNoPagada.AutoSize = True
        Me.rbtnNoPagada.Checked = True
        Me.rbtnNoPagada.Location = New System.Drawing.Point(16, 13)
        Me.rbtnNoPagada.Name = "rbtnNoPagada"
        Me.rbtnNoPagada.Size = New System.Drawing.Size(79, 17)
        Me.rbtnNoPagada.TabIndex = 20
        Me.rbtnNoPagada.TabStop = True
        Me.rbtnNoPagada.Text = "No Pagada"
        Me.rbtnNoPagada.UseVisualStyleBackColor = True
        '
        'rbtnProcesoPago
        '
        Me.rbtnProcesoPago.AutoSize = True
        Me.rbtnProcesoPago.Location = New System.Drawing.Point(16, 31)
        Me.rbtnProcesoPago.Name = "rbtnProcesoPago"
        Me.rbtnProcesoPago.Size = New System.Drawing.Size(123, 17)
        Me.rbtnProcesoPago.TabIndex = 21
        Me.rbtnProcesoPago.Text = "En Proceso de Pago"
        Me.rbtnProcesoPago.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkConvenio)
        Me.GroupBox2.Controls.Add(Me.chkTranferencia)
        Me.GroupBox2.Location = New System.Drawing.Point(706, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 54)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forma de Pago:"
        '
        'chkConvenio
        '
        Me.chkConvenio.AutoSize = True
        Me.chkConvenio.Checked = True
        Me.chkConvenio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConvenio.Location = New System.Drawing.Point(6, 31)
        Me.chkConvenio.Name = "chkConvenio"
        Me.chkConvenio.Size = New System.Drawing.Size(114, 17)
        Me.chkConvenio.TabIndex = 2
        Me.chkConvenio.Text = "Conv / Referencia"
        Me.chkConvenio.UseVisualStyleBackColor = True
        '
        'chkTranferencia
        '
        Me.chkTranferencia.AutoSize = True
        Me.chkTranferencia.Checked = True
        Me.chkTranferencia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTranferencia.Location = New System.Drawing.Point(6, 14)
        Me.chkTranferencia.Name = "chkTranferencia"
        Me.chkTranferencia.Size = New System.Drawing.Size(86, 17)
        Me.chkTranferencia.TabIndex = 1
        Me.chkTranferencia.Text = "Tranferencia"
        Me.chkTranferencia.UseVisualStyleBackColor = True
        '
        'pbxCargando
        '
        Me.pbxCargando.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbxCargando.Image = Global.cuentasPorPagar.My.Resources.Resources.tenor
        Me.pbxCargando.Location = New System.Drawing.Point(12, 68)
        Me.pbxCargando.Name = "pbxCargando"
        Me.pbxCargando.Size = New System.Drawing.Size(1224, 375)
        Me.pbxCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxCargando.TabIndex = 19
        Me.pbxCargando.TabStop = False
        Me.pbxCargando.Visible = False
        '
        'cblTipoSolicitud
        '
        Me.cblTipoSolicitud.CheckOnClick = True
        Me.cblTipoSolicitud.FormattingEnabled = True
        Me.cblTipoSolicitud.Location = New System.Drawing.Point(233, 13)
        Me.cblTipoSolicitud.Name = "cblTipoSolicitud"
        Me.cblTipoSolicitud.Size = New System.Drawing.Size(207, 49)
        Me.cblTipoSolicitud.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tipoSolicitud"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo Sol"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tipoSolicitud"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "folioSolicitud"
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "folioSolicitud"
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn4.Frozen = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "importeSolicitado"
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn5.Frozen = True
        Me.DataGridViewTextBoxColumn5.HeaderText = "Imp Solicitado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "importeSolicitado"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn6.Frozen = True
        Me.DataGridViewTextBoxColumn6.HeaderText = "Imp Solicitado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idEmpresa"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "C2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn8.Frozen = True
        Me.DataGridViewTextBoxColumn8.HeaderText = "idEmpresa"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "moneda"
        DataGridViewCellStyle14.Format = "C2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn9.Frozen = True
        Me.DataGridViewTextBoxColumn9.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "bancoDestino"
        Me.DataGridViewTextBoxColumn10.Frozen = True
        Me.DataGridViewTextBoxColumn10.HeaderText = "Banco Destino"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "cuenta"
        Me.DataGridViewTextBoxColumn11.Frozen = True
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cuenta"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "clabe"
        Me.DataGridViewTextBoxColumn12.Frozen = True
        Me.DataGridViewTextBoxColumn12.HeaderText = "CLABE"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "convenio"
        Me.DataGridViewTextBoxColumn13.Frozen = True
        Me.DataGridViewTextBoxColumn13.HeaderText = "Convenio"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "referencia"
        Me.DataGridViewTextBoxColumn14.Frozen = True
        Me.DataGridViewTextBoxColumn14.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "estatusAutorizacion"
        Me.DataGridViewTextBoxColumn15.Frozen = True
        Me.DataGridViewTextBoxColumn15.HeaderText = "Autorizado"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ok2"
        Me.DataGridViewTextBoxColumn16.Frozen = True
        Me.DataGridViewTextBoxColumn16.HeaderText = "ok2"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "razonSocial"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Beneficiario"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "fPago"
        Me.DataGridViewTextBoxColumn19.Frozen = True
        Me.DataGridViewTextBoxColumn19.HeaderText = "Forma de Pago"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "fechaPago"
        Me.DataGridViewTextBoxColumn23.HeaderText = "fechaPago"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "fechaProceso"
        Me.DataGridViewTextBoxColumn24.HeaderText = "fechaProceso"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'ColumnaPersonalizada1
        '
        Me.ColumnaPersonalizada1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.ColumnaPersonalizada1.HeaderText = "Banco Ordenante"
        Me.ColumnaPersonalizada1.Name = "ColumnaPersonalizada1"
        Me.ColumnaPersonalizada1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'CXPCuentasBancariasBindingSource
        '
        Me.CXPCuentasBancariasBindingSource.DataMember = "CXP_CuentasBancarias"
        Me.CXPCuentasBancariasBindingSource.DataSource = Me.DsTesoreria
        '
        'Vw_CXP_SugPagoTesoreriaTableAdapter
        '
        Me.Vw_CXP_SugPagoTesoreriaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasProvTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PagosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PagosTesoreriaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_RegContTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoDeSolicitudTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsTesoreriaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_CuentasBancariasTableAdapter
        '
        Me.CXP_CuentasBancariasTableAdapter.ClearBeforeFill = True
        '
        'frmTesSolicitudesDePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 509)
        Me.Controls.Add(Me.cblTipoSolicitud)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gpbEstatus)
        Me.Controls.Add(Me.gpbFechas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxLayout)
        Me.Controls.Add(Me.gbxSeleccionar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.pbxCargando)
        Me.Controls.Add(Me.Vw_CXP_SugPagoTesoreriaDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmTesSolicitudesDePago"
        Me.Text = "Pagos por tranferencia electrónica y convenio"
        CType(Me.Vw_CXP_SugPagoTesoreriaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_CXP_SugPagoTesoreriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTesoreria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxSeleccionar.ResumeLayout(False)
        Me.gbxLayout.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gpbFechas.ResumeLayout(False)
        Me.gpbEstatus.ResumeLayout(False)
        Me.gpbEstatus.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbxCargando, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DsTesoreria As dsTesoreria
    Friend WithEvents Vw_CXP_SugPagoTesoreriaBindingSource As BindingSource
    Friend WithEvents Vw_CXP_SugPagoTesoreriaTableAdapter As dsTesoreriaTableAdapters.Vw_CXP_SugPagoTesoreriaTableAdapter
    Friend WithEvents TableAdapterManager As dsTesoreriaTableAdapters.TableAdapterManager
    Friend WithEvents Vw_CXP_SugPagoTesoreriaDataGridView As DataGridView
    Friend WithEvents dtpFechaPagoInicial As DateTimePicker
    Friend WithEvents btnConsultar As Button
    Friend WithEvents CXPCuentasBancariasBindingSource As BindingSource
    Friend WithEvents CXP_CuentasBancariasTableAdapter As dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaPersonalizada1 As ColumnaPersonalizada
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnSeleccionarTodo As Button
    Friend WithEvents btnGenerarLayOut As Button
    Friend WithEvents btnSeleccionarNada As Button
    Friend WithEvents gbxSeleccionar As GroupBox
    Friend WithEvents gbxLayout As GroupBox
    Friend WithEvents sfdTxtBancario As SaveFileDialog
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ofdComprobantePago As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPdfConfirmacion As Button
    Friend WithEvents ofdPdfConfirmacion As OpenFileDialog
    Friend WithEvents dtpFechaPagoFinal As DateTimePicker
    Friend WithEvents gpbFechas As GroupBox
    Friend WithEvents gpbEstatus As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkConvenio As CheckBox
    Friend WithEvents chkTranferencia As CheckBox
    Friend WithEvents pbxCargando As PictureBox
    Friend WithEvents rbtnNoPagada As RadioButton
    Friend WithEvents rbtnProcesoPago As RadioButton
    Friend WithEvents rbtnPagada As RadioButton
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents cblTipoSolicitud As CheckedListBox
    Friend WithEvents folioSolicitud As DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents estatusPago As DataGridViewTextBoxColumn
    Friend WithEvents tipoSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents idEmpresa As DataGridViewTextBoxColumn
    Friend WithEvents importeSolicitado As DataGridViewTextBoxColumn
    Friend WithEvents Tipar As DataGridViewTextBoxColumn
    Friend WithEvents moneda As DataGridViewTextBoxColumn
    Friend WithEvents seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents bancoBeneficiario As DataGridViewTextBoxColumn
    Friend WithEvents cuentaBeneficiaria As DataGridViewTextBoxColumn
    Friend WithEvents clabeBeneficiaria As DataGridViewTextBoxColumn
    Friend WithEvents convenio As DataGridViewTextBoxColumn
    Friend WithEvents referencia As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents fechaProgPago As DataGridViewTextBoxColumn
    Friend WithEvents razonSocial As DataGridViewTextBoxColumn
    Friend WithEvents formaDePago As DataGridViewTextBoxColumn
    Friend WithEvents idBancoBen As DataGridViewTextBoxColumn
    Friend WithEvents noContrato As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents fechaPago As DataGridViewTextBoxColumn
    Friend WithEvents fechaProceso As DataGridViewTextBoxColumn
End Class
