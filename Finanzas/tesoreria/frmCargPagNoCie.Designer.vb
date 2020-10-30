<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargPagNoCie
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
        Me.btnSubirComprobante = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ofdPdfConfirmacion = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnSubirComprobante
        '
        Me.btnSubirComprobante.Location = New System.Drawing.Point(12, 12)
        Me.btnSubirComprobante.Name = "btnSubirComprobante"
        Me.btnSubirComprobante.Size = New System.Drawing.Size(118, 23)
        Me.btnSubirComprobante.TabIndex = 0
        Me.btnSubirComprobante.Text = "Subir Comprobante"
        Me.btnSubirComprobante.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(198, 63)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ofdPdfConfirmacion
        '
        Me.ofdPdfConfirmacion.FileName = "OpenFileDialog1"
        '
        'frmCargPagNoCie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 98)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSubirComprobante)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCargPagNoCie"
        Me.Text = "Cargar comprobantes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSubirComprobante As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents ofdPdfConfirmacion As OpenFileDialog
End Class
