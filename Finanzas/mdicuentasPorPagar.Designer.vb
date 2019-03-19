<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdicuentasPorPagar
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonedasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasBancariasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasContablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConceptosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeDiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SugerenciaDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraciónToolStripMenuItem, Me.CatálogosToolStripMenuItem, Me.RegistroDeDiarioToolStripMenuItem, Me.SugerenciaDePagoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.PerfilesToolStripMenuItem, Me.EmpresasToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "&Configuración"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'PerfilesToolStripMenuItem
        '
        Me.PerfilesToolStripMenuItem.Name = "PerfilesToolStripMenuItem"
        Me.PerfilesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PerfilesToolStripMenuItem.Text = "Perfiles"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EmpresasToolStripMenuItem.Text = "Empresas"
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SATToolStripMenuItem, Me.ContabilidadToolStripMenuItem, Me.ConceptosToolStripMenuItem})
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.CatálogosToolStripMenuItem.Text = "C&atálogos"
        '
        'SATToolStripMenuItem
        '
        Me.SATToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BancosToolStripMenuItem, Me.ImpuestosToolStripMenuItem, Me.TipoDeDocumentosToolStripMenuItem, Me.MonedasToolStripMenuItem})
        Me.SATToolStripMenuItem.Name = "SATToolStripMenuItem"
        Me.SATToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SATToolStripMenuItem.Text = "SAT"
        '
        'BancosToolStripMenuItem
        '
        Me.BancosToolStripMenuItem.Name = "BancosToolStripMenuItem"
        Me.BancosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.BancosToolStripMenuItem.Text = "Bancos"
        '
        'ImpuestosToolStripMenuItem
        '
        Me.ImpuestosToolStripMenuItem.Name = "ImpuestosToolStripMenuItem"
        Me.ImpuestosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ImpuestosToolStripMenuItem.Text = "Impuestos"
        '
        'TipoDeDocumentosToolStripMenuItem
        '
        Me.TipoDeDocumentosToolStripMenuItem.Name = "TipoDeDocumentosToolStripMenuItem"
        Me.TipoDeDocumentosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.TipoDeDocumentosToolStripMenuItem.Text = "Tipo de Documentos"
        '
        'MonedasToolStripMenuItem
        '
        Me.MonedasToolStripMenuItem.Name = "MonedasToolStripMenuItem"
        Me.MonedasToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.MonedasToolStripMenuItem.Text = "Monedas"
        '
        'ContabilidadToolStripMenuItem
        '
        Me.ContabilidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentasBancariasToolStripMenuItem, Me.CuentasContablesToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
        Me.ContabilidadToolStripMenuItem.Name = "ContabilidadToolStripMenuItem"
        Me.ContabilidadToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ContabilidadToolStripMenuItem.Text = "Contabilidad"
        '
        'CuentasBancariasToolStripMenuItem
        '
        Me.CuentasBancariasToolStripMenuItem.Name = "CuentasBancariasToolStripMenuItem"
        Me.CuentasBancariasToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CuentasBancariasToolStripMenuItem.Text = "Cuentas Bancarias"
        '
        'CuentasContablesToolStripMenuItem
        '
        Me.CuentasContablesToolStripMenuItem.Name = "CuentasContablesToolStripMenuItem"
        Me.CuentasContablesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CuentasContablesToolStripMenuItem.Text = "Cuentas Contables"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ConceptosToolStripMenuItem
        '
        Me.ConceptosToolStripMenuItem.Name = "ConceptosToolStripMenuItem"
        Me.ConceptosToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ConceptosToolStripMenuItem.Text = "Conceptos"
        '
        'RegistroDeDiarioToolStripMenuItem
        '
        Me.RegistroDeDiarioToolStripMenuItem.Name = "RegistroDeDiarioToolStripMenuItem"
        Me.RegistroDeDiarioToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.RegistroDeDiarioToolStripMenuItem.Text = "&Registro de diario"
        '
        'SugerenciaDePagoToolStripMenuItem
        '
        Me.SugerenciaDePagoToolStripMenuItem.Name = "SugerenciaDePagoToolStripMenuItem"
        Me.SugerenciaDePagoToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.SugerenciaDePagoToolStripMenuItem.Text = "&Sugerencia de pago"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Sa&lir"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 189)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'mdicuentasPorPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 211)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdicuentasPorPagar"
        Me.Text = "Cuentas por Pagar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatálogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeDiarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SugerenciaDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerfilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SATToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BancosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDeDocumentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonedasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContabilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentasBancariasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentasContablesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConceptosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
