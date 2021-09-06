<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleComprobaciones
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
        Me.cmbCuentaAbono = New System.Windows.Forms.ComboBox()
        Me.CuentasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Contpaq = New cuentasPorPagar.contpaq()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDetalleComprobaciones = New System.Windows.Forms.DataGridView()
        Me.idCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlCuentasContpaq = New System.Windows.Forms.Panel()
        Me.cmbCuentasContpaq = New System.Windows.Forms.ComboBox()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasTableAdapter = New cuentasPorPagar.contpaqTableAdapters.CuentasTableAdapter()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.dtpFechaProceso = New System.Windows.Forms.DateTimePicker()
        Me.cmbNoDeducibles = New System.Windows.Forms.ComboBox()
        Me.CuentasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCargos = New System.Windows.Forms.Label()
        Me.lblAbonos = New System.Windows.Forms.Label()
        Me.gpbDiferencia = New System.Windows.Forms.GroupBox()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.txtAbono = New System.Windows.Forms.TextBox()
        Me.cmbCuentaContableDif = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CuentasBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.CuentasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleComprobaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCuentasContpaq.SuspendLayout()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDiferencia.SuspendLayout()
        CType(Me.CuentasBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCuentaAbono
        '
        Me.cmbCuentaAbono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCuentaAbono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCuentaAbono.DataSource = Me.CuentasBindingSource1
        Me.cmbCuentaAbono.DisplayMember = "nCuenta"
        Me.cmbCuentaAbono.Enabled = False
        Me.cmbCuentaAbono.FormattingEnabled = True
        Me.cmbCuentaAbono.Location = New System.Drawing.Point(122, 15)
        Me.cmbCuentaAbono.Name = "cmbCuentaAbono"
        Me.cmbCuentaAbono.Size = New System.Drawing.Size(369, 21)
        Me.cmbCuentaAbono.TabIndex = 1
        Me.cmbCuentaAbono.ValueMember = "Id"
        '
        'CuentasBindingSource1
        '
        Me.CuentasBindingSource1.DataMember = "Cuentas"
        Me.CuentasBindingSource1.DataSource = Me.Contpaq
        '
        'Contpaq
        '
        Me.Contpaq.DataSetName = "contpaq"
        Me.Contpaq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cuenta abono:"
        '
        'dgvDetalleComprobaciones
        '
        Me.dgvDetalleComprobaciones.AllowUserToAddRows = False
        Me.dgvDetalleComprobaciones.AllowUserToDeleteRows = False
        Me.dgvDetalleComprobaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleComprobaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCuenta, Me.cuentaContable, Me.cargo, Me.abono, Me.referencia, Me.concepto, Me.uuid})
        Me.dgvDetalleComprobaciones.Location = New System.Drawing.Point(12, 75)
        Me.dgvDetalleComprobaciones.Name = "dgvDetalleComprobaciones"
        Me.dgvDetalleComprobaciones.ReadOnly = True
        Me.dgvDetalleComprobaciones.Size = New System.Drawing.Size(1005, 331)
        Me.dgvDetalleComprobaciones.TabIndex = 0
        '
        'idCuenta
        '
        Me.idCuenta.HeaderText = "Id Cta"
        Me.idCuenta.Name = "idCuenta"
        Me.idCuenta.ReadOnly = True
        Me.idCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cuentaContable
        '
        Me.cuentaContable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cuentaContable.HeaderText = "Cuenta Contable"
        Me.cuentaContable.Name = "cuentaContable"
        Me.cuentaContable.ReadOnly = True
        Me.cuentaContable.Width = 102
        '
        'cargo
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.cargo.DefaultCellStyle = DataGridViewCellStyle1
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.Name = "cargo"
        Me.cargo.ReadOnly = True
        '
        'abono
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.abono.DefaultCellStyle = DataGridViewCellStyle2
        Me.abono.HeaderText = "Abono"
        Me.abono.Name = "abono"
        Me.abono.ReadOnly = True
        '
        'referencia
        '
        Me.referencia.HeaderText = "Referencia"
        Me.referencia.Name = "referencia"
        Me.referencia.ReadOnly = True
        Me.referencia.Width = 200
        '
        'concepto
        '
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.ReadOnly = True
        Me.concepto.Width = 250
        '
        'uuid
        '
        Me.uuid.HeaderText = "uuid"
        Me.uuid.Name = "uuid"
        Me.uuid.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Cta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cuenta Contable"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Abono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Concepto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 250
        '
        'pnlCuentasContpaq
        '
        Me.pnlCuentasContpaq.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlCuentasContpaq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCuentasContpaq.Controls.Add(Me.cmbCuentasContpaq)
        Me.pnlCuentasContpaq.Location = New System.Drawing.Point(269, 204)
        Me.pnlCuentasContpaq.Name = "pnlCuentasContpaq"
        Me.pnlCuentasContpaq.Size = New System.Drawing.Size(469, 62)
        Me.pnlCuentasContpaq.TabIndex = 6
        Me.pnlCuentasContpaq.Visible = False
        '
        'cmbCuentasContpaq
        '
        Me.cmbCuentasContpaq.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCuentasContpaq.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCuentasContpaq.DataSource = Me.CuentasBindingSource
        Me.cmbCuentasContpaq.DisplayMember = "nCuenta"
        Me.cmbCuentasContpaq.FormattingEnabled = True
        Me.cmbCuentasContpaq.Location = New System.Drawing.Point(12, 12)
        Me.cmbCuentasContpaq.Name = "cmbCuentasContpaq"
        Me.cmbCuentasContpaq.Size = New System.Drawing.Size(440, 21)
        Me.cmbCuentasContpaq.TabIndex = 0
        Me.cmbCuentasContpaq.ValueMember = "Id"
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "Cuentas"
        Me.CuentasBindingSource.DataSource = Me.Contpaq
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(942, 498)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(942, 469)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 3
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'dtpFechaProceso
        '
        Me.dtpFechaProceso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaProceso.Location = New System.Drawing.Point(918, 15)
        Me.dtpFechaProceso.Name = "dtpFechaProceso"
        Me.dtpFechaProceso.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaProceso.TabIndex = 2
        '
        'cmbNoDeducibles
        '
        Me.cmbNoDeducibles.DataSource = Me.CuentasBindingSource2
        Me.cmbNoDeducibles.DisplayMember = "nCuenta"
        Me.cmbNoDeducibles.Enabled = False
        Me.cmbNoDeducibles.FormattingEnabled = True
        Me.cmbNoDeducibles.Location = New System.Drawing.Point(122, 43)
        Me.cmbNoDeducibles.Name = "cmbNoDeducibles"
        Me.cmbNoDeducibles.Size = New System.Drawing.Size(369, 21)
        Me.cmbNoDeducibles.TabIndex = 7
        Me.cmbNoDeducibles.ValueMember = "Id"
        '
        'CuentasBindingSource2
        '
        Me.CuentasBindingSource2.DataMember = "Cuentas"
        Me.CuentasBindingSource2.DataSource = Me.Contpaq
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "No deducibles:"
        '
        'lblCargos
        '
        Me.lblCargos.AutoSize = True
        Me.lblCargos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargos.Location = New System.Drawing.Point(688, 479)
        Me.lblCargos.Name = "lblCargos"
        Me.lblCargos.Size = New System.Drawing.Size(50, 13)
        Me.lblCargos.TabIndex = 9
        Me.lblCargos.Text = "Cargos:"
        '
        'lblAbonos
        '
        Me.lblAbonos.AutoSize = True
        Me.lblAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbonos.Location = New System.Drawing.Point(688, 508)
        Me.lblAbonos.Name = "lblAbonos"
        Me.lblAbonos.Size = New System.Drawing.Size(53, 13)
        Me.lblAbonos.TabIndex = 10
        Me.lblAbonos.Text = "Abonos:"
        '
        'gpbDiferencia
        '
        Me.gpbDiferencia.Controls.Add(Me.btnAgregar)
        Me.gpbDiferencia.Controls.Add(Me.Label5)
        Me.gpbDiferencia.Controls.Add(Me.Label4)
        Me.gpbDiferencia.Controls.Add(Me.Label3)
        Me.gpbDiferencia.Controls.Add(Me.cmbCuentaContableDif)
        Me.gpbDiferencia.Controls.Add(Me.txtAbono)
        Me.gpbDiferencia.Controls.Add(Me.txtCargo)
        Me.gpbDiferencia.Enabled = False
        Me.gpbDiferencia.Location = New System.Drawing.Point(16, 416)
        Me.gpbDiferencia.Name = "gpbDiferencia"
        Me.gpbDiferencia.Size = New System.Drawing.Size(560, 105)
        Me.gpbDiferencia.TabIndex = 11
        Me.gpbDiferencia.TabStop = False
        Me.gpbDiferencia.Text = "Cargo/Abono por diferencia"
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(100, 19)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(100, 20)
        Me.txtCargo.TabIndex = 0
        Me.txtCargo.Text = "0"
        '
        'txtAbono
        '
        Me.txtAbono.Location = New System.Drawing.Point(100, 46)
        Me.txtAbono.Name = "txtAbono"
        Me.txtAbono.Size = New System.Drawing.Size(100, 20)
        Me.txtAbono.TabIndex = 1
        Me.txtAbono.Text = "0"
        '
        'cmbCuentaContableDif
        '
        Me.cmbCuentaContableDif.DataSource = Me.CuentasBindingSource3
        Me.cmbCuentaContableDif.DisplayMember = "nCuenta"
        Me.cmbCuentaContableDif.FormattingEnabled = True
        Me.cmbCuentaContableDif.Location = New System.Drawing.Point(100, 73)
        Me.cmbCuentaContableDif.Name = "cmbCuentaContableDif"
        Me.cmbCuentaContableDif.Size = New System.Drawing.Size(361, 21)
        Me.cmbCuentaContableDif.TabIndex = 2
        Me.cmbCuentaContableDif.ValueMember = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cargo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Abono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cuenta contable:"
        '
        'CuentasBindingSource3
        '
        Me.CuentasBindingSource3.DataMember = "Cuentas"
        Me.CuentasBindingSource3.DataSource = Me.Contpaq
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(479, 73)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmDetalleComprobaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 533)
        Me.Controls.Add(Me.gpbDiferencia)
        Me.Controls.Add(Me.lblAbonos)
        Me.Controls.Add(Me.lblCargos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNoDeducibles)
        Me.Controls.Add(Me.dtpFechaProceso)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.pnlCuentasContpaq)
        Me.Controls.Add(Me.dgvDetalleComprobaciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCuentaAbono)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDetalleComprobaciones"
        Me.Text = "Detalle Comprobaciones"
        CType(Me.CuentasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleComprobaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCuentasContpaq.ResumeLayout(False)
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDiferencia.ResumeLayout(False)
        Me.gpbDiferencia.PerformLayout()
        CType(Me.CuentasBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCuentaAbono As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDetalleComprobaciones As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents pnlCuentasContpaq As Panel
    Friend WithEvents cmbCuentasContpaq As ComboBox
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents Contpaq As contpaq
    Friend WithEvents CuentasTableAdapter As contpaqTableAdapters.CuentasTableAdapter
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnProcesar As Button
    Friend WithEvents CuentasBindingSource1 As BindingSource
    Friend WithEvents dtpFechaProceso As DateTimePicker
    Friend WithEvents idCuenta As DataGridViewTextBoxColumn
    Friend WithEvents cuentaContable As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents abono As DataGridViewTextBoxColumn
    Friend WithEvents referencia As DataGridViewTextBoxColumn
    Friend WithEvents concepto As DataGridViewTextBoxColumn
    Friend WithEvents uuid As DataGridViewTextBoxColumn
    Friend WithEvents cmbNoDeducibles As ComboBox
    Friend WithEvents CuentasBindingSource2 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCargos As Label
    Friend WithEvents lblAbonos As Label
    Friend WithEvents gpbDiferencia As GroupBox
    Friend WithEvents cmbCuentaContableDif As ComboBox
    Friend WithEvents txtAbono As TextBox
    Friend WithEvents txtCargo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CuentasBindingSource3 As BindingSource
    Friend WithEvents btnAgregar As Button
End Class
