<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEspecificaTipoDocumento
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CXPtipoDeDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CXP_tipoDeDocumentoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.CXPtipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CXPtipoDeDocumentoBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(120, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(219, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "idTipoDeDocumento"
        '
        'CXPtipoDeDocumentoBindingSource
        '
        Me.CXPtipoDeDocumentoBindingSource.DataMember = "CXP_tipoDeDocumento"
        Me.CXPtipoDeDocumentoBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de dcoumento:"
        '
        'CXP_tipoDeDocumentoTableAdapter
        '
        Me.CXP_tipoDeDocumentoTableAdapter.ClearBeforeFill = True
        '
        'txtClave
        '
        Me.txtClave.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXPtipoDeDocumentoBindingSource, "claveTipoDocumento", True))
        Me.txtClave.Location = New System.Drawing.Point(120, 39)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.ReadOnly = True
        Me.txtClave.Size = New System.Drawing.Size(79, 20)
        Me.txtClave.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Clave:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmEspecificaTipoDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 121)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEspecificaTipoDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Documento"
        CType(Me.CXPtipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXPtipoDeDocumentoBindingSource As BindingSource
    Friend WithEvents CXP_tipoDeDocumentoTableAdapter As dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter
    Friend WithEvents txtClave As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
