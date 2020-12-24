<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaCuentas
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
        Me.btnSeleccionarArchivo = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnProcesar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSeleccionarArchivo
        '
        Me.btnSeleccionarArchivo.Location = New System.Drawing.Point(12, 12)
        Me.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo"
        Me.btnSeleccionarArchivo.Size = New System.Drawing.Size(122, 23)
        Me.btnSeleccionarArchivo.TabIndex = 0
        Me.btnSeleccionarArchivo.Text = "Archivo Origen"
        Me.btnSeleccionarArchivo.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1250, 329)
        Me.DataGridView1.TabIndex = 1
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(12, 376)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 2
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'frmCargaCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 411)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSeleccionarArchivo)
        Me.Name = "frmCargaCuentas"
        Me.Text = "Carga datos bancarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSeleccionarArchivo As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnProcesar As Button
End Class
