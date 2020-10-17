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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.idCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(121, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(572, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(121, 40)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(572, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cuenta cargo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cuenta abono:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCuenta, Me.cuentaContable, Me.cargo, Me.abono, Me.referencia, Me.concepto})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1005, 348)
        Me.DataGridView1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(716, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Solicitud"
        '
        'idCuenta
        '
        Me.idCuenta.HeaderText = "Id Cta"
        Me.idCuenta.Name = "idCuenta"
        Me.idCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cuentaContable
        '
        Me.cuentaContable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cuentaContable.HeaderText = "Cuenta Contable"
        Me.cuentaContable.Name = "cuentaContable"
        Me.cuentaContable.Width = 102
        '
        'cargo
        '
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.Name = "cargo"
        '
        'abono
        '
        Me.abono.HeaderText = "Abono"
        Me.abono.Name = "abono"
        '
        'referencia
        '
        Me.referencia.HeaderText = "Referencia"
        Me.referencia.Name = "referencia"
        Me.referencia.Width = 200
        '
        'concepto
        '
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.Width = 250
        '
        'frmDetalleComprobaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDetalleComprobaciones"
        Me.Text = "Detalle Comprobaciones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents idCuenta As DataGridViewTextBoxColumn
    Friend WithEvents cuentaContable As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents abono As DataGridViewTextBoxColumn
    Friend WithEvents referencia As DataGridViewTextBoxColumn
    Friend WithEvents concepto As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
End Class
