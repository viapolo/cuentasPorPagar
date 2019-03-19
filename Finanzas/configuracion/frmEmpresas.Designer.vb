<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresas
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
        Dim IdRegimenFiscalLabel As System.Windows.Forms.Label
        Dim CondicionesDePagoLabel As System.Windows.Forms.Label
        Dim IdMonedaLabel As System.Windows.Forms.Label
        Dim CodigoPostalLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim DelegacionLabel As System.Windows.Forms.Label
        Dim ColoniaLabel As System.Windows.Forms.Label
        Dim NumeroExteriorLabel As System.Windows.Forms.Label
        Dim NumeroInteriorLabel As System.Windows.Forms.Label
        Dim CalleLabel As System.Windows.Forms.Label
        Dim RfcLabel As System.Windows.Forms.Label
        Dim RazonSocialLabel As System.Windows.Forms.Label
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.CXP_EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_EmpresasTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_EmpresasTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.gbxInformaciongeneral = New System.Windows.Forms.GroupBox()
        Me.IdRegimenFiscalTextBox = New System.Windows.Forms.TextBox()
        Me.CondicionesDePagoTextBox = New System.Windows.Forms.TextBox()
        Me.IdMonedaTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoPostalTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.DelegacionTextBox = New System.Windows.Forms.TextBox()
        Me.ColoniaTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroExteriorTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroInteriorTextBox = New System.Windows.Forms.TextBox()
        Me.CalleTextBox = New System.Windows.Forms.TextBox()
        Me.RfcTextBox = New System.Windows.Forms.TextBox()
        Me.cmbRazonSocial = New System.Windows.Forms.ComboBox()
        IdRegimenFiscalLabel = New System.Windows.Forms.Label()
        CondicionesDePagoLabel = New System.Windows.Forms.Label()
        IdMonedaLabel = New System.Windows.Forms.Label()
        CodigoPostalLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        DelegacionLabel = New System.Windows.Forms.Label()
        ColoniaLabel = New System.Windows.Forms.Label()
        NumeroExteriorLabel = New System.Windows.Forms.Label()
        NumeroInteriorLabel = New System.Windows.Forms.Label()
        CalleLabel = New System.Windows.Forms.Label()
        RfcLabel = New System.Windows.Forms.Label()
        RazonSocialLabel = New System.Windows.Forms.Label()
        CType(Me.CXP_EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInformaciongeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(28, 217)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 26
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(109, 217)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 27
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(285, 217)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 28
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(625, 217)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 29
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'CXP_EmpresasBindingSource
        '
        Me.CXP_EmpresasBindingSource.DataMember = "CXP_Empresas"
        Me.CXP_EmpresasBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_EmpresasTableAdapter
        '
        Me.CXP_EmpresasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Me.CXP_EmpresasTableAdapter
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'gbxInformaciongeneral
        '
        Me.gbxInformaciongeneral.Controls.Add(IdRegimenFiscalLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.IdRegimenFiscalTextBox)
        Me.gbxInformaciongeneral.Controls.Add(CondicionesDePagoLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.CondicionesDePagoTextBox)
        Me.gbxInformaciongeneral.Controls.Add(IdMonedaLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.IdMonedaTextBox)
        Me.gbxInformaciongeneral.Controls.Add(CodigoPostalLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.CodigoPostalTextBox)
        Me.gbxInformaciongeneral.Controls.Add(PaisLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.PaisTextBox)
        Me.gbxInformaciongeneral.Controls.Add(EstadoLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.EstadoTextBox)
        Me.gbxInformaciongeneral.Controls.Add(DelegacionLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.DelegacionTextBox)
        Me.gbxInformaciongeneral.Controls.Add(ColoniaLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.ColoniaTextBox)
        Me.gbxInformaciongeneral.Controls.Add(NumeroExteriorLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.NumeroExteriorTextBox)
        Me.gbxInformaciongeneral.Controls.Add(NumeroInteriorLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.NumeroInteriorTextBox)
        Me.gbxInformaciongeneral.Controls.Add(CalleLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.CalleTextBox)
        Me.gbxInformaciongeneral.Controls.Add(RfcLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.RfcTextBox)
        Me.gbxInformaciongeneral.Location = New System.Drawing.Point(12, 46)
        Me.gbxInformaciongeneral.Name = "gbxInformaciongeneral"
        Me.gbxInformaciongeneral.Size = New System.Drawing.Size(688, 165)
        Me.gbxInformaciongeneral.TabIndex = 30
        Me.gbxInformaciongeneral.TabStop = False
        Me.gbxInformaciongeneral.Text = "Información General:"
        '
        'IdRegimenFiscalLabel
        '
        IdRegimenFiscalLabel.AutoSize = True
        IdRegimenFiscalLabel.Location = New System.Drawing.Point(469, 52)
        IdRegimenFiscalLabel.Name = "IdRegimenFiscalLabel"
        IdRegimenFiscalLabel.Size = New System.Drawing.Size(82, 13)
        IdRegimenFiscalLabel.TabIndex = 50
        IdRegimenFiscalLabel.Text = "Regimen Fiscal:"
        '
        'IdRegimenFiscalTextBox
        '
        Me.IdRegimenFiscalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "idRegimenFiscal", True))
        Me.IdRegimenFiscalTextBox.Location = New System.Drawing.Point(557, 49)
        Me.IdRegimenFiscalTextBox.Name = "IdRegimenFiscalTextBox"
        Me.IdRegimenFiscalTextBox.Size = New System.Drawing.Size(116, 20)
        Me.IdRegimenFiscalTextBox.TabIndex = 51
        '
        'CondicionesDePagoLabel
        '
        CondicionesDePagoLabel.AutoSize = True
        CondicionesDePagoLabel.Location = New System.Drawing.Point(439, 130)
        CondicionesDePagoLabel.Name = "CondicionesDePagoLabel"
        CondicionesDePagoLabel.Size = New System.Drawing.Size(111, 13)
        CondicionesDePagoLabel.TabIndex = 48
        CondicionesDePagoLabel.Text = "Condiciones de Pago:"
        '
        'CondicionesDePagoTextBox
        '
        Me.CondicionesDePagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "condicionesDePago", True))
        Me.CondicionesDePagoTextBox.Location = New System.Drawing.Point(557, 127)
        Me.CondicionesDePagoTextBox.Name = "CondicionesDePagoTextBox"
        Me.CondicionesDePagoTextBox.Size = New System.Drawing.Size(116, 20)
        Me.CondicionesDePagoTextBox.TabIndex = 49
        '
        'IdMonedaLabel
        '
        IdMonedaLabel.AutoSize = True
        IdMonedaLabel.Location = New System.Drawing.Point(502, 78)
        IdMonedaLabel.Name = "IdMonedaLabel"
        IdMonedaLabel.Size = New System.Drawing.Size(49, 13)
        IdMonedaLabel.TabIndex = 46
        IdMonedaLabel.Text = "Moneda:"
        '
        'IdMonedaTextBox
        '
        Me.IdMonedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "idMoneda", True))
        Me.IdMonedaTextBox.Location = New System.Drawing.Point(557, 75)
        Me.IdMonedaTextBox.Name = "IdMonedaTextBox"
        Me.IdMonedaTextBox.Size = New System.Drawing.Size(116, 20)
        Me.IdMonedaTextBox.TabIndex = 47
        '
        'CodigoPostalLabel
        '
        CodigoPostalLabel.AutoSize = True
        CodigoPostalLabel.Location = New System.Drawing.Point(477, 104)
        CodigoPostalLabel.Name = "CodigoPostalLabel"
        CodigoPostalLabel.Size = New System.Drawing.Size(75, 13)
        CodigoPostalLabel.TabIndex = 44
        CodigoPostalLabel.Text = "Código Postal:"
        '
        'CodigoPostalTextBox
        '
        Me.CodigoPostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "codigoPostal", True))
        Me.CodigoPostalTextBox.Location = New System.Drawing.Point(557, 101)
        Me.CodigoPostalTextBox.Name = "CodigoPostalTextBox"
        Me.CodigoPostalTextBox.Size = New System.Drawing.Size(116, 20)
        Me.CodigoPostalTextBox.TabIndex = 45
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(270, 130)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(30, 13)
        PaisLabel.TabIndex = 42
        PaisLabel.Text = "Pais:"
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(306, 127)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaisTextBox.TabIndex = 43
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(50, 130)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 40
        EstadoLabel.Text = "Estado:"
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(98, 127)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(166, 20)
        Me.EstadoTextBox.TabIndex = 41
        '
        'DelegacionLabel
        '
        DelegacionLabel.AutoSize = True
        DelegacionLabel.Location = New System.Drawing.Point(30, 104)
        DelegacionLabel.Name = "DelegacionLabel"
        DelegacionLabel.Size = New System.Drawing.Size(62, 13)
        DelegacionLabel.TabIndex = 38
        DelegacionLabel.Text = "Deegación:"
        '
        'DelegacionTextBox
        '
        Me.DelegacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "delegacion", True))
        Me.DelegacionTextBox.Location = New System.Drawing.Point(98, 101)
        Me.DelegacionTextBox.Name = "DelegacionTextBox"
        Me.DelegacionTextBox.Size = New System.Drawing.Size(308, 20)
        Me.DelegacionTextBox.TabIndex = 39
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.Location = New System.Drawing.Point(48, 78)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(45, 13)
        ColoniaLabel.TabIndex = 36
        ColoniaLabel.Text = "Colonia:"
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "colonia", True))
        Me.ColoniaTextBox.Location = New System.Drawing.Point(98, 75)
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.Size = New System.Drawing.Size(308, 20)
        Me.ColoniaTextBox.TabIndex = 37
        '
        'NumeroExteriorLabel
        '
        NumeroExteriorLabel.AutoSize = True
        NumeroExteriorLabel.Location = New System.Drawing.Point(215, 52)
        NumeroExteriorLabel.Name = "NumeroExteriorLabel"
        NumeroExteriorLabel.Size = New System.Drawing.Size(85, 13)
        NumeroExteriorLabel.TabIndex = 34
        NumeroExteriorLabel.Text = "Número Exterior:"
        '
        'NumeroExteriorTextBox
        '
        Me.NumeroExteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "numeroExterior", True))
        Me.NumeroExteriorTextBox.Location = New System.Drawing.Point(306, 49)
        Me.NumeroExteriorTextBox.Name = "NumeroExteriorTextBox"
        Me.NumeroExteriorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroExteriorTextBox.TabIndex = 35
        '
        'NumeroInteriorLabel
        '
        NumeroInteriorLabel.AutoSize = True
        NumeroInteriorLabel.Location = New System.Drawing.Point(10, 52)
        NumeroInteriorLabel.Name = "NumeroInteriorLabel"
        NumeroInteriorLabel.Size = New System.Drawing.Size(82, 13)
        NumeroInteriorLabel.TabIndex = 32
        NumeroInteriorLabel.Text = "Número Interior:"
        '
        'NumeroInteriorTextBox
        '
        Me.NumeroInteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "numeroInterior", True))
        Me.NumeroInteriorTextBox.Location = New System.Drawing.Point(98, 49)
        Me.NumeroInteriorTextBox.Name = "NumeroInteriorTextBox"
        Me.NumeroInteriorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroInteriorTextBox.TabIndex = 33
        '
        'CalleLabel
        '
        CalleLabel.AutoSize = True
        CalleLabel.Location = New System.Drawing.Point(59, 26)
        CalleLabel.Name = "CalleLabel"
        CalleLabel.Size = New System.Drawing.Size(33, 13)
        CalleLabel.TabIndex = 30
        CalleLabel.Text = "Calle:"
        '
        'CalleTextBox
        '
        Me.CalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "calle", True))
        Me.CalleTextBox.Location = New System.Drawing.Point(98, 23)
        Me.CalleTextBox.Name = "CalleTextBox"
        Me.CalleTextBox.Size = New System.Drawing.Size(308, 20)
        Me.CalleTextBox.TabIndex = 31
        '
        'RfcLabel
        '
        RfcLabel.AutoSize = True
        RfcLabel.Location = New System.Drawing.Point(520, 26)
        RfcLabel.Name = "RfcLabel"
        RfcLabel.Size = New System.Drawing.Size(31, 13)
        RfcLabel.TabIndex = 28
        RfcLabel.Text = "RFC:"
        AddHandler RfcLabel.Click, AddressOf Me.RfcLabel_Click
        '
        'RfcTextBox
        '
        Me.RfcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "rfc", True))
        Me.RfcTextBox.Location = New System.Drawing.Point(557, 23)
        Me.RfcTextBox.Name = "RfcTextBox"
        Me.RfcTextBox.Size = New System.Drawing.Size(116, 20)
        Me.RfcTextBox.TabIndex = 29
        '
        'RazonSocialLabel
        '
        RazonSocialLabel.AutoSize = True
        RazonSocialLabel.Location = New System.Drawing.Point(30, 15)
        RazonSocialLabel.Name = "RazonSocialLabel"
        RazonSocialLabel.Size = New System.Drawing.Size(73, 13)
        RazonSocialLabel.TabIndex = 26
        RazonSocialLabel.Text = "Razón Social:"
        '
        'cmbRazonSocial
        '
        Me.cmbRazonSocial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "razonSocial", True))
        Me.cmbRazonSocial.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_EmpresasBindingSource, "razonSocial", True))
        Me.cmbRazonSocial.DataSource = Me.CXP_EmpresasBindingSource
        Me.cmbRazonSocial.DisplayMember = "razonSocial"
        Me.cmbRazonSocial.FormattingEnabled = True
        Me.cmbRazonSocial.Location = New System.Drawing.Point(110, 15)
        Me.cmbRazonSocial.Name = "cmbRazonSocial"
        Me.cmbRazonSocial.Size = New System.Drawing.Size(575, 21)
        Me.cmbRazonSocial.TabIndex = 31
        Me.cmbRazonSocial.ValueMember = "idEmpresas"
        '
        'frmEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(712, 252)
        Me.Controls.Add(Me.cmbRazonSocial)
        Me.Controls.Add(Me.gbxInformaciongeneral)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(RazonSocialLabel)
        Me.Name = "frmEmpresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresa"
        CType(Me.CXP_EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInformaciongeneral.ResumeLayout(False)
        Me.gbxInformaciongeneral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_EmpresasBindingSource As BindingSource
    Friend WithEvents CXP_EmpresasTableAdapter As dsProductionTableAdapters.CXP_EmpresasTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents gbxInformaciongeneral As GroupBox
    Friend WithEvents IdRegimenFiscalTextBox As TextBox
    Friend WithEvents CondicionesDePagoTextBox As TextBox
    Friend WithEvents IdMonedaTextBox As TextBox
    Friend WithEvents CodigoPostalTextBox As TextBox
    Friend WithEvents PaisTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents DelegacionTextBox As TextBox
    Friend WithEvents ColoniaTextBox As TextBox
    Friend WithEvents NumeroExteriorTextBox As TextBox
    Friend WithEvents NumeroInteriorTextBox As TextBox
    Friend WithEvents CalleTextBox As TextBox
    Friend WithEvents RfcTextBox As TextBox
    Friend WithEvents cmbRazonSocial As ComboBox
End Class
