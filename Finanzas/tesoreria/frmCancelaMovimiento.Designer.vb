<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelaMovimiento
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblLeyenda = New System.Windows.Forms.Label()
        Me.chkNotificaCancelacion = New System.Windows.Forms.CheckBox()
        Me.txtMotivoRechazo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(92, 125)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(284, 125)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblLeyenda
        '
        Me.lblLeyenda.AutoSize = True
        Me.lblLeyenda.Location = New System.Drawing.Point(12, 9)
        Me.lblLeyenda.Name = "lblLeyenda"
        Me.lblLeyenda.Size = New System.Drawing.Size(39, 13)
        Me.lblLeyenda.TabIndex = 0
        Me.lblLeyenda.Text = "Label1"
        '
        'chkNotificaCancelacion
        '
        Me.chkNotificaCancelacion.AutoSize = True
        Me.chkNotificaCancelacion.Location = New System.Drawing.Point(253, 90)
        Me.chkNotificaCancelacion.Name = "chkNotificaCancelacion"
        Me.chkNotificaCancelacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkNotificaCancelacion.Size = New System.Drawing.Size(182, 17)
        Me.chkNotificaCancelacion.TabIndex = 2
        Me.chkNotificaCancelacion.Text = "Notificar cancelación de solicitud"
        Me.chkNotificaCancelacion.UseVisualStyleBackColor = True
        '
        'txtMotivoRechazo
        '
        Me.txtMotivoRechazo.Location = New System.Drawing.Point(12, 39)
        Me.txtMotivoRechazo.Multiline = True
        Me.txtMotivoRechazo.Name = "txtMotivoRechazo"
        Me.txtMotivoRechazo.Size = New System.Drawing.Size(423, 45)
        Me.txtMotivoRechazo.TabIndex = 1
        '
        'frmCancelaMovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 160)
        Me.Controls.Add(Me.txtMotivoRechazo)
        Me.Controls.Add(Me.chkNotificaCancelacion)
        Me.Controls.Add(Me.lblLeyenda)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCancelaMovimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelación de Movimientos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblLeyenda As Label
    Friend WithEvents chkNotificaCancelacion As CheckBox
    Friend WithEvents txtMotivoRechazo As TextBox
End Class
