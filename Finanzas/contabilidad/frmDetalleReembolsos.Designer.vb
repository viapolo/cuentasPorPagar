<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetalleReembolsos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvDetalleReembolsos = New System.Windows.Forms.DataGridView()
        Me.idCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contpaq = New cuentasPorPagar.contpaq()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasTableAdapter = New cuentasPorPagar.contpaqTableAdapters.CuentasTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCuentaAbono = New System.Windows.Forms.ComboBox()
        Me.CuentasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpFechaProceso = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlCuentasContpaq = New System.Windows.Forms.Panel()
        Me.cmbCuentasContpaq = New System.Windows.Forms.ComboBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lblFechaPago = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvDetalleReembolsos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCuentasContpaq.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDetalleReembolsos
        '
        Me.dgvDetalleReembolsos.AllowUserToAddRows = False
        Me.dgvDetalleReembolsos.AllowUserToDeleteRows = False
        Me.dgvDetalleReembolsos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleReembolsos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCuenta, Me.cuentaContable, Me.cargo, Me.abono, Me.referencia, Me.concepto, Me.uuid})
        Me.dgvDetalleReembolsos.Location = New System.Drawing.Point(12, 41)
        Me.dgvDetalleReembolsos.Name = "dgvDetalleReembolsos"
        Me.dgvDetalleReembolsos.ReadOnly = True
        Me.dgvDetalleReembolsos.Size = New System.Drawing.Size(1005, 364)
        Me.dgvDetalleReembolsos.TabIndex = 1
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
        'Contpaq
        '
        Me.Contpaq.DataSetName = "contpaq"
        Me.Contpaq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cuenta abono:"
        '
        'cmbCuentaAbono
        '
        Me.cmbCuentaAbono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCuentaAbono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCuentaAbono.DataSource = Me.CuentasBindingSource1
        Me.cmbCuentaAbono.DisplayMember = "nCuenta"
        Me.cmbCuentaAbono.FormattingEnabled = True
        Me.cmbCuentaAbono.Location = New System.Drawing.Point(123, 12)
        Me.cmbCuentaAbono.Name = "cmbCuentaAbono"
        Me.cmbCuentaAbono.Size = New System.Drawing.Size(495, 21)
        Me.cmbCuentaAbono.TabIndex = 4
        Me.cmbCuentaAbono.ValueMember = "Id"
        '
        'CuentasBindingSource1
        '
        Me.CuentasBindingSource1.DataMember = "Cuentas"
        Me.CuentasBindingSource1.DataSource = Me.Contpaq
        '
        'dtpFechaProceso
        '
        Me.dtpFechaProceso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaProceso.Location = New System.Drawing.Point(919, 12)
        Me.dtpFechaProceso.Name = "dtpFechaProceso"
        Me.dtpFechaProceso.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaProceso.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Cta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cuenta Contable"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "Abono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Concepto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 250
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "uuid"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'pnlCuentasContpaq
        '
        Me.pnlCuentasContpaq.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlCuentasContpaq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCuentasContpaq.Controls.Add(Me.cmbCuentasContpaq)
        Me.pnlCuentasContpaq.Location = New System.Drawing.Point(280, 196)
        Me.pnlCuentasContpaq.Name = "pnlCuentasContpaq"
        Me.pnlCuentasContpaq.Size = New System.Drawing.Size(469, 62)
        Me.pnlCuentasContpaq.TabIndex = 7
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
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(942, 420)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(12, 420)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 9
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'lblFechaPago
        '
        Me.lblFechaPago.AutoSize = True
        Me.lblFechaPago.Location = New System.Drawing.Point(815, 15)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Size = New System.Drawing.Size(82, 13)
        Me.lblFechaPago.TabIndex = 10
        Me.lblFechaPago.Text = "Fecha de pago:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(624, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Fecha solicitud:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(711, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'frmDetalleReembolsos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 455)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFechaPago)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.pnlCuentasContpaq)
        Me.Controls.Add(Me.dtpFechaProceso)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCuentaAbono)
        Me.Controls.Add(Me.dgvDetalleReembolsos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDetalleReembolsos"
        Me.Text = "Detalle Reembolsos"
        CType(Me.dgvDetalleReembolsos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCuentasContpaq.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDetalleReembolsos As DataGridView
    Friend WithEvents idCuenta As DataGridViewTextBoxColumn
    Friend WithEvents cuentaContable As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents abono As DataGridViewTextBoxColumn
    Friend WithEvents referencia As DataGridViewTextBoxColumn
    Friend WithEvents concepto As DataGridViewTextBoxColumn
    Friend WithEvents uuid As DataGridViewTextBoxColumn
    Friend WithEvents Contpaq As contpaq
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents CuentasTableAdapter As contpaqTableAdapters.CuentasTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCuentaAbono As ComboBox
    Friend WithEvents dtpFechaProceso As DateTimePicker
    Friend WithEvents CuentasBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents pnlCuentasContpaq As Panel
    Friend WithEvents cmbCuentasContpaq As ComboBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnProcesar As Button
    Friend WithEvents lblFechaPago As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
