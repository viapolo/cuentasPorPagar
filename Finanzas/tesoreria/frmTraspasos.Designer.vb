<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraspasos
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
        Me.cmbCuentaOrdenante = New System.Windows.Forms.ComboBox()
        Me.CXPCuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTesoreria = New cuentasPorPagar.dsTesoreria()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCuentaBeneficiaria = New System.Windows.Forms.ComboBox()
        Me.CXPCuentasBancariasProvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXPCuentasBancariasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnVistPrevia = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CXP_CuentasBancariasTableAdapter = New cuentasPorPagar.dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.CXPcMonedaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DsContabilidad = New cuentasPorPagar.dsContabilidad()
        Me.CXP_c_MonedaTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_MonedaTableAdapter()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.CXPtipoDocumentoSatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CXP_tipoDocumentoSatTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_tipoDocumentoSatTableAdapter()
        Me.CXP_CuentasBancariasProvTableAdapter = New cuentasPorPagar.dsTesoreriaTableAdapters.CXP_CuentasBancariasProvTableAdapter()
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTesoreria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPCuentasBancariasProvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPCuentasBancariasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcMonedaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPtipoDocumentoSatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCuentaOrdenante
        '
        Me.cmbCuentaOrdenante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCuentaOrdenante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCuentaOrdenante.DataSource = Me.CXPCuentasBancariasBindingSource
        Me.cmbCuentaOrdenante.DisplayMember = "nombre"
        Me.cmbCuentaOrdenante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCuentaOrdenante.FormattingEnabled = True
        Me.cmbCuentaOrdenante.Location = New System.Drawing.Point(113, 6)
        Me.cmbCuentaOrdenante.Name = "cmbCuentaOrdenante"
        Me.cmbCuentaOrdenante.Size = New System.Drawing.Size(345, 21)
        Me.cmbCuentaOrdenante.TabIndex = 0
        Me.cmbCuentaOrdenante.ValueMember = "idCuentaBancaria"
        '
        'CXPCuentasBancariasBindingSource
        '
        Me.CXPCuentasBancariasBindingSource.DataMember = "CXP_CuentasBancarias"
        Me.CXPCuentasBancariasBindingSource.DataSource = Me.DsTesoreria
        '
        'DsTesoreria
        '
        Me.DsTesoreria.DataSetName = "dsTesoreria"
        Me.DsTesoreria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cuenta ordenante:"
        '
        'cmbCuentaBeneficiaria
        '
        Me.cmbCuentaBeneficiaria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCuentaBeneficiaria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCuentaBeneficiaria.DataSource = Me.CXPCuentasBancariasProvBindingSource
        Me.cmbCuentaBeneficiaria.DisplayMember = "descripcion"
        Me.cmbCuentaBeneficiaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCuentaBeneficiaria.FormattingEnabled = True
        Me.cmbCuentaBeneficiaria.Location = New System.Drawing.Point(113, 33)
        Me.cmbCuentaBeneficiaria.Name = "cmbCuentaBeneficiaria"
        Me.cmbCuentaBeneficiaria.Size = New System.Drawing.Size(345, 21)
        Me.cmbCuentaBeneficiaria.TabIndex = 2
        Me.cmbCuentaBeneficiaria.ValueMember = "idCuentas"
        '
        'CXPCuentasBancariasProvBindingSource
        '
        Me.CXPCuentasBancariasProvBindingSource.DataMember = "CXP_CuentasBancariasProv"
        Me.CXPCuentasBancariasProvBindingSource.DataSource = Me.DsTesoreria
        '
        'CXPCuentasBancariasBindingSource1
        '
        Me.CXPCuentasBancariasBindingSource1.DataMember = "CXP_CuentasBancarias"
        Me.CXPCuentasBancariasBindingSource1.DataSource = Me.DsTesoreria
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cuenta beneficiaria:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(515, 7)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(464, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(113, 60)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(345, 97)
        Me.txtDescripcion.TabIndex = 6
        '
        'btnVistPrevia
        '
        Me.btnVistPrevia.Location = New System.Drawing.Point(487, 134)
        Me.btnVistPrevia.Name = "btnVistPrevia"
        Me.btnVistPrevia.Size = New System.Drawing.Size(75, 23)
        Me.btnVistPrevia.TabIndex = 7
        Me.btnVistPrevia.Text = "Vista Previa"
        Me.btnVistPrevia.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(464, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Importe:"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(515, 33)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(200, 20)
        Me.txtImporte.TabIndex = 9
        Me.txtImporte.Text = "0"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(636, 181)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(636, 134)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 11
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Descripción:"
        '
        'CXP_CuentasBancariasTableAdapter
        '
        Me.CXP_CuentasBancariasTableAdapter.ClearBeforeFill = True
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DataSource = Me.CXPcMonedaBindingSource
        Me.cmbMoneda.DisplayMember = "c_NombreMoneda"
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(515, 59)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(200, 21)
        Me.cmbMoneda.TabIndex = 13
        Me.cmbMoneda.ValueMember = "c_Moneda"
        '
        'CXPcMonedaBindingSource
        '
        Me.CXPcMonedaBindingSource.DataMember = "CXP_c_Moneda"
        Me.CXPcMonedaBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(464, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Moneda:"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Location = New System.Drawing.Point(553, 87)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(162, 20)
        Me.txtTipoCambio.TabIndex = 15
        Me.txtTipoCambio.Text = "1.000000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(464, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tipo de cambio:"
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "dsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_c_MonedaTableAdapter
        '
        Me.CXP_c_MonedaTableAdapter.ClearBeforeFill = True
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbFormaPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFormaPago.DataSource = Me.CXPtipoDocumentoSatBindingSource
        Me.cmbFormaPago.DisplayMember = "descripcion"
        Me.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Location = New System.Drawing.Point(113, 164)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(345, 21)
        Me.cmbFormaPago.TabIndex = 17
        Me.cmbFormaPago.ValueMember = "idTipoDocumento"
        '
        'CXPtipoDocumentoSatBindingSource
        '
        Me.CXPtipoDocumentoSatBindingSource.DataMember = "CXP_tipoDocumentoSat"
        Me.CXPtipoDocumentoSatBindingSource.DataSource = Me.DsContabilidad
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Forma de pago:"
        '
        'CXP_tipoDocumentoSatTableAdapter
        '
        Me.CXP_tipoDocumentoSatTableAdapter.ClearBeforeFill = True
        '
        'CXP_CuentasBancariasProvTableAdapter
        '
        Me.CXP_CuentasBancariasProvTableAdapter.ClearBeforeFill = True
        '
        'frmTraspasos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 212)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbFormaPago)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTipoCambio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbMoneda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnVistPrevia)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCuentaBeneficiaria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCuentaOrdenante)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTraspasos"
        Me.Text = "Traspasos"
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTesoreria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPCuentasBancariasProvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPCuentasBancariasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcMonedaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPtipoDocumentoSatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCuentaOrdenante As ComboBox
    Friend WithEvents CXPCuentasBancariasBindingSource As BindingSource
    Friend WithEvents DsTesoreria As dsTesoreria
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCuentaBeneficiaria As ComboBox
    Friend WithEvents CXPCuentasBancariasBindingSource1 As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnVistPrevia As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnProcesar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents CXP_CuentasBancariasTableAdapter As dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter
    Friend WithEvents cmbMoneda As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTipoCambio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DsContabilidad As dsContabilidad
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXPcMonedaBindingSource As BindingSource
    Friend WithEvents CXP_c_MonedaTableAdapter As dsProductionTableAdapters.CXP_c_MonedaTableAdapter
    Friend WithEvents cmbFormaPago As ComboBox
    Friend WithEvents CXPtipoDocumentoSatBindingSource As BindingSource
    Friend WithEvents Label8 As Label
    Friend WithEvents CXP_tipoDocumentoSatTableAdapter As dsContabilidadTableAdapters.CXP_tipoDocumentoSatTableAdapter
    Friend WithEvents CXPCuentasBancariasProvBindingSource As BindingSource
    Friend WithEvents CXP_CuentasBancariasProvTableAdapter As dsTesoreriaTableAdapters.CXP_CuentasBancariasProvTableAdapter
End Class
