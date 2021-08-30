<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInversion
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
        Me.cmbBancoOrigen = New System.Windows.Forms.ComboBox()
        Me.CXPCuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTesoreria = New cuentasPorPagar.dsTesoreria()
        Me.CXP_InversionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContabilidad = New cuentasPorPagar.dsContabilidad()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.chkFira = New System.Windows.Forms.CheckBox()
        Me.chkFiraGarantia = New System.Windows.Forms.CheckBox()
        Me.CXP_InversionesTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_InversionesTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager()
        Me.CXP_CuentasBancariasTableAdapter = New cuentasPorPagar.dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtTasa = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTesoreria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_InversionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbBancoOrigen
        '
        Me.cmbBancoOrigen.DataSource = Me.CXPCuentasBancariasBindingSource
        Me.cmbBancoOrigen.DisplayMember = "nombre"
        Me.cmbBancoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBancoOrigen.FormattingEnabled = True
        Me.cmbBancoOrigen.Location = New System.Drawing.Point(91, 13)
        Me.cmbBancoOrigen.Name = "cmbBancoOrigen"
        Me.cmbBancoOrigen.Size = New System.Drawing.Size(272, 21)
        Me.cmbBancoOrigen.TabIndex = 0
        Me.cmbBancoOrigen.ValueMember = "idCuentaBancaria"
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
        'CXP_InversionesBindingSource
        '
        Me.CXP_InversionesBindingSource.DataMember = "CXP_Inversiones"
        Me.CXP_InversionesBindingSource.DataSource = Me.DsContabilidad
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "dsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Banco origen:"
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Location = New System.Drawing.Point(500, 13)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaInicial.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(425, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha inicial:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tasa:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Monto:"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(625, 126)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'chkFira
        '
        Me.chkFira.AutoSize = True
        Me.chkFira.Enabled = False
        Me.chkFira.Location = New System.Drawing.Point(497, 43)
        Me.chkFira.Name = "chkFira"
        Me.chkFira.Size = New System.Drawing.Size(94, 17)
        Me.chkFira.TabIndex = 9
        Me.chkFira.Text = "Bancomer Fira"
        Me.chkFira.UseVisualStyleBackColor = True
        '
        'chkFiraGarantia
        '
        Me.chkFiraGarantia.AutoSize = True
        Me.chkFiraGarantia.Enabled = False
        Me.chkFiraGarantia.Location = New System.Drawing.Point(497, 72)
        Me.chkFiraGarantia.Name = "chkFiraGarantia"
        Me.chkFiraGarantia.Size = New System.Drawing.Size(156, 17)
        Me.chkFiraGarantia.TabIndex = 10
        Me.chkFiraGarantia.Text = "Bancomer Garantía Liquida"
        Me.chkFiraGarantia.UseVisualStyleBackColor = True
        '
        'CXP_InversionesTableAdapter
        '
        Me.CXP_InversionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONT_TiposDeCambioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ComprobGtos1TableAdapter = Nothing
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasInversionesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EstatusTableAdapter = Nothing
        Me.TableAdapterManager.CXP_InversionesTableAdapter = Me.CXP_InversionesTableAdapter
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
        'CXP_CuentasBancariasTableAdapter
        '
        Me.CXP_CuentasBancariasTableAdapter.ClearBeforeFill = True
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(91, 67)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(100, 20)
        Me.txtMonto.TabIndex = 6
        '
        'txtTasa
        '
        Me.txtTasa.Location = New System.Drawing.Point(91, 40)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Size = New System.Drawing.Size(100, 20)
        Me.txtTasa.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(516, 126)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmInversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 158)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.chkFiraGarantia)
        Me.Controls.Add(Me.chkFira)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTasa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFechaInicial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbBancoOrigen)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_InversionesBindingSource, "fechaInicial", True))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInversion"
        Me.Text = "Inversiones"
        CType(Me.CXPCuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTesoreria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_InversionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbBancoOrigen As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents chkFira As CheckBox
    Friend WithEvents chkFiraGarantia As CheckBox
    Friend WithEvents DsContabilidad As dsContabilidad
    Friend WithEvents CXP_InversionesBindingSource As BindingSource
    Friend WithEvents CXP_InversionesTableAdapter As dsContabilidadTableAdapters.CXP_InversionesTableAdapter
    Friend WithEvents TableAdapterManager As dsContabilidadTableAdapters.TableAdapterManager
    Friend WithEvents CXPCuentasBancariasBindingSource As BindingSource
    Friend WithEvents DsTesoreria As dsTesoreria
    Friend WithEvents CXP_CuentasBancariasTableAdapter As dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtTasa As TextBox
    Friend WithEvents btnGuardar As Button
End Class
