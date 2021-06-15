<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetalleNomina
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
        Me.dgvDetalleNomina = New System.Windows.Forms.DataGridView()
        Me.idCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpFechaProceso = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCuentaAbono = New System.Windows.Forms.ComboBox()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Contpaq = New cuentasPorPagar.contpaq()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentasTableAdapter = New cuentasPorPagar.contpaqTableAdapters.CuentasTableAdapter()
        Me.CuentasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCuentaCargo = New System.Windows.Forms.ComboBox()
        Me.CXPCuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContabilidad = New cuentasPorPagar.dsContabilidad()
        Me.CXP_CuentasBancariasTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_CuentasBancariasTableAdapter()
        Me.btnAplicCuenta = New System.Windows.Forms.Button()
        CType(Me.dgvDetalleNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDetalleNomina
        '
        Me.dgvDetalleNomina.AllowUserToAddRows = False
        Me.dgvDetalleNomina.AllowUserToDeleteRows = False
        Me.dgvDetalleNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleNomina.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCuenta, Me.cuentaContable, Me.cargo, Me.abono, Me.referencia, Me.concepto, Me.uuid})
        Me.dgvDetalleNomina.Location = New System.Drawing.Point(10, 66)
        Me.dgvDetalleNomina.Name = "dgvDetalleNomina"
        Me.dgvDetalleNomina.ReadOnly = True
        Me.dgvDetalleNomina.Size = New System.Drawing.Size(1005, 329)
        Me.dgvDetalleNomina.TabIndex = 1
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
        'dtpFechaProceso
        '
        Me.dtpFechaProceso.Enabled = False
        Me.dtpFechaProceso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaProceso.Location = New System.Drawing.Point(916, 12)
        Me.dtpFechaProceso.Name = "dtpFechaProceso"
        Me.dtpFechaProceso.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaProceso.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cuenta cargo:"
        '
        'cmbCuentaAbono
        '
        Me.cmbCuentaAbono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCuentaAbono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCuentaAbono.DataSource = Me.CuentasBindingSource
        Me.cmbCuentaAbono.DisplayMember = "nCuenta"
        Me.cmbCuentaAbono.Enabled = False
        Me.cmbCuentaAbono.FormattingEnabled = True
        Me.cmbCuentaAbono.Location = New System.Drawing.Point(120, 12)
        Me.cmbCuentaAbono.Name = "cmbCuentaAbono"
        Me.cmbCuentaAbono.Size = New System.Drawing.Size(790, 21)
        Me.cmbCuentaAbono.TabIndex = 4
        Me.cmbCuentaAbono.ValueMember = "Id"
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "Cuentas"
        Me.CuentasBindingSource.DataSource = Me.Contpaq
        '
        'Contpaq
        '
        Me.Contpaq.DataSetName = "contpaq"
        Me.Contpaq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(940, 420)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(13, 420)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 8
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
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
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'CuentasBindingSource1
        '
        Me.CuentasBindingSource1.DataMember = "Cuentas"
        Me.CuentasBindingSource1.DataSource = Me.Contpaq
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cuenta abono:"
        '
        'cmbCuentaCargo
        '
        Me.cmbCuentaCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCuentaCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCuentaCargo.DataSource = Me.CXPCuentasBancariasBindingSource
        Me.cmbCuentaCargo.DisplayMember = "nombre"
        Me.cmbCuentaCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCuentaCargo.FormattingEnabled = True
        Me.cmbCuentaCargo.Location = New System.Drawing.Point(120, 39)
        Me.cmbCuentaCargo.Name = "cmbCuentaCargo"
        Me.cmbCuentaCargo.Size = New System.Drawing.Size(790, 21)
        Me.cmbCuentaCargo.TabIndex = 9
        Me.cmbCuentaCargo.ValueMember = "cuentaCont"
        '
        'CXPCuentasBancariasBindingSource
        '
        Me.CXPCuentasBancariasBindingSource.DataMember = "CXP_CuentasBancarias"
        Me.CXPCuentasBancariasBindingSource.DataSource = Me.DsContabilidad
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "dsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_CuentasBancariasTableAdapter
        '
        Me.CXP_CuentasBancariasTableAdapter.ClearBeforeFill = True
        '
        'btnAplicCuenta
        '
        Me.btnAplicCuenta.Location = New System.Drawing.Point(916, 36)
        Me.btnAplicCuenta.Name = "btnAplicCuenta"
        Me.btnAplicCuenta.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicCuenta.TabIndex = 11
        Me.btnAplicCuenta.Text = "Aplic Cuenta"
        Me.btnAplicCuenta.UseVisualStyleBackColor = True
        '
        'frmDetalleNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 463)
        Me.Controls.Add(Me.btnAplicCuenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCuentaCargo)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dtpFechaProceso)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCuentaAbono)
        Me.Controls.Add(Me.dgvDetalleNomina)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDetalleNomina"
        Me.Text = "Detella Nómina"
        CType(Me.dgvDetalleNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDetalleNomina As DataGridView
    Friend WithEvents idCuenta As DataGridViewTextBoxColumn
    Friend WithEvents cuentaContable As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents abono As DataGridViewTextBoxColumn
    Friend WithEvents referencia As DataGridViewTextBoxColumn
    Friend WithEvents concepto As DataGridViewTextBoxColumn
    Friend WithEvents uuid As DataGridViewTextBoxColumn
    Friend WithEvents dtpFechaProceso As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCuentaAbono As ComboBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnProcesar As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents CuentasTableAdapter As contpaqTableAdapters.CuentasTableAdapter
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents Contpaq As contpaq
    Friend WithEvents CuentasBindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCuentaCargo As ComboBox
    Friend WithEvents CXPCuentasBancariasBindingSource As BindingSource
    Friend WithEvents DsContabilidad As dsContabilidad
    Friend WithEvents CXP_CuentasBancariasTableAdapter As dsContabilidadTableAdapters.CXP_CuentasBancariasTableAdapter
    Friend WithEvents btnAplicCuenta As Button
End Class
