<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowMsgForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextLabel = New System.Windows.Forms.Label()
        Me.MessagePictureBox = New System.Windows.Forms.PictureBox()
        Me.QuestionTextLabel = New System.Windows.Forms.Label()
        Me.PrintLabel = New System.Windows.Forms.LinkLabel()
        CType(Me.MessagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(324, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(243, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(162, 89)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextLabel
        '
        Me.TextLabel.AutoSize = True
        Me.TextLabel.Location = New System.Drawing.Point(88, 9)
        Me.TextLabel.Name = "TextLabel"
        Me.TextLabel.Size = New System.Drawing.Size(39, 13)
        Me.TextLabel.TabIndex = 3
        Me.TextLabel.Text = "Label1"
        '
        'MessagePictureBox
        '
        Me.MessagePictureBox.Location = New System.Drawing.Point(12, 9)
        Me.MessagePictureBox.Name = "MessagePictureBox"
        Me.MessagePictureBox.Size = New System.Drawing.Size(67, 68)
        Me.MessagePictureBox.TabIndex = 4
        Me.MessagePictureBox.TabStop = False
        '
        'QuestionTextLabel
        '
        Me.QuestionTextLabel.AutoSize = True
        Me.QuestionTextLabel.Location = New System.Drawing.Point(88, 35)
        Me.QuestionTextLabel.Name = "QuestionTextLabel"
        Me.QuestionTextLabel.Size = New System.Drawing.Size(39, 13)
        Me.QuestionTextLabel.TabIndex = 5
        Me.QuestionTextLabel.Text = "Label2"
        '
        'PrintLabel
        '
        Me.PrintLabel.AutoSize = True
        Me.PrintLabel.Location = New System.Drawing.Point(88, 63)
        Me.PrintLabel.Name = "PrintLabel"
        Me.PrintLabel.Size = New System.Drawing.Size(59, 13)
        Me.PrintLabel.TabIndex = 6
        Me.PrintLabel.TabStop = True
        Me.PrintLabel.Text = "LinkLabel1"
        '
        'ShowMsgForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 124)
        Me.Controls.Add(Me.PrintLabel)
        Me.Controls.Add(Me.QuestionTextLabel)
        Me.Controls.Add(Me.MessagePictureBox)
        Me.Controls.Add(Me.TextLabel)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ShowMsgForm"
        Me.Text = "ShowMsgForm"
        CType(Me.MessagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextLabel As Label
    Friend WithEvents MessagePictureBox As PictureBox
    Friend WithEvents QuestionTextLabel As Label
    Friend WithEvents PrintLabel As LinkLabel
End Class
