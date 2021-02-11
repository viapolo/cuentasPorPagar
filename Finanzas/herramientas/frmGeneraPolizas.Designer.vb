<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneraPolizas
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
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.txtTipoSolicitud = New System.Windows.Forms.TextBox()
        Me.txtFolioSolicitud = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNotificaPago = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(274, 12)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(117, 23)
        Me.btnProcesar.TabIndex = 0
        Me.btnProcesar.Text = "Genera Póliza"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'txtTipoSolicitud
        '
        Me.txtTipoSolicitud.Location = New System.Drawing.Point(134, 16)
        Me.txtTipoSolicitud.Name = "txtTipoSolicitud"
        Me.txtTipoSolicitud.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoSolicitud.TabIndex = 1
        '
        'txtFolioSolicitud
        '
        Me.txtFolioSolicitud.Location = New System.Drawing.Point(134, 43)
        Me.txtFolioSolicitud.Name = "txtFolioSolicitud"
        Me.txtFolioSolicitud.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioSolicitud.TabIndex = 2
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(134, 70)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tipo Sol:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Folio Solicitud:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Importe:"
        '
        'btnNotificaPago
        '
        Me.btnNotificaPago.Location = New System.Drawing.Point(274, 66)
        Me.btnNotificaPago.Name = "btnNotificaPago"
        Me.btnNotificaPago.Size = New System.Drawing.Size(117, 23)
        Me.btnNotificaPago.TabIndex = 7
        Me.btnNotificaPago.Text = "Notifica pago"
        Me.btnNotificaPago.UseVisualStyleBackColor = True
        '
        'frmGeneraPolizas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 274)
        Me.Controls.Add(Me.btnNotificaPago)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.txtFolioSolicitud)
        Me.Controls.Add(Me.txtTipoSolicitud)
        Me.Controls.Add(Me.btnProcesar)
        Me.Name = "frmGeneraPolizas"
        Me.Text = "frmGeneraPolizas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProcesar As Button
    Friend WithEvents txtTipoSolicitud As TextBox
    Friend WithEvents txtFolioSolicitud As TextBox
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNotificaPago As Button
End Class
