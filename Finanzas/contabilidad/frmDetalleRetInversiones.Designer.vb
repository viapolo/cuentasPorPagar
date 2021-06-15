<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleRetInversiones
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
        Me.dtpFechaRetiro = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtInteres = New System.Windows.Forms.TextBox()
        Me.txtTipoFira = New System.Windows.Forms.TextBox()
        Me.cmbBancoOrigen = New System.Windows.Forms.ComboBox()
        Me.CXPCuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContabilidad = New cuentasPorPagar.dsContabilidad()
        Me.CXP_CuentasBancariasTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_CuentasBancariasTableAdapter()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslIdInversion = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpFechaRetiro
        '
        Me.dtpFechaRetiro.Location = New System.Drawing.Point(121, 12)
        Me.dtpFechaRetiro.Name = "dtpFechaRetiro"
        Me.dtpFechaRetiro.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaRetiro.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha de retiro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Banco de retiro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Monto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Interes:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tipo Fira:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(121, 66)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(200, 20)
        Me.txtMonto.TabIndex = 7
        '
        'txtInteres
        '
        Me.txtInteres.Location = New System.Drawing.Point(121, 93)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(200, 20)
        Me.txtInteres.TabIndex = 8
        '
        'txtTipoFira
        '
        Me.txtTipoFira.Location = New System.Drawing.Point(121, 120)
        Me.txtTipoFira.Name = "txtTipoFira"
        Me.txtTipoFira.ReadOnly = True
        Me.txtTipoFira.Size = New System.Drawing.Size(200, 20)
        Me.txtTipoFira.TabIndex = 9
        '
        'cmbBancoOrigen
        '
        Me.cmbBancoOrigen.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXPCuentasBancariasBindingSource, "idCuentaBancaria", True))
        Me.cmbBancoOrigen.DataSource = Me.CXPCuentasBancariasBindingSource
        Me.cmbBancoOrigen.DisplayMember = "nombre"
        Me.cmbBancoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBancoOrigen.Enabled = False
        Me.cmbBancoOrigen.FormattingEnabled = True
        Me.cmbBancoOrigen.Location = New System.Drawing.Point(121, 39)
        Me.cmbBancoOrigen.Name = "cmbBancoOrigen"
        Me.cmbBancoOrigen.Size = New System.Drawing.Size(200, 21)
        Me.cmbBancoOrigen.TabIndex = 10
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
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(427, 123)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(427, 12)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(75, 23)
        Me.btnRetirar.TabIndex = 12
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslIdInversion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 189)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(535, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslIdInversion
        '
        Me.tsslIdInversion.Name = "tsslIdInversion"
        Me.tsslIdInversion.Size = New System.Drawing.Size(119, 17)
        Me.tsslIdInversion.Text = "ToolStripStatusLabel1"
        '
        'frmDetalleRetInversiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 211)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnRetirar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cmbBancoOrigen)
        Me.Controls.Add(Me.txtTipoFira)
        Me.Controls.Add(Me.txtInteres)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFechaRetiro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDetalleRetInversiones"
        Me.Text = "Detalle del Retiro de Inversión"
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpFechaRetiro As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtInteres As TextBox
    Friend WithEvents txtTipoFira As TextBox
    Friend WithEvents cmbBancoOrigen As ComboBox
    Friend WithEvents CXPCuentasBancariasBindingSource As BindingSource
    Friend WithEvents DsContabilidad As dsContabilidad
    Friend WithEvents CXP_CuentasBancariasTableAdapter As dsContabilidadTableAdapters.CXP_CuentasBancariasTableAdapter
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnRetirar As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsslIdInversion As ToolStripStatusLabel
End Class
