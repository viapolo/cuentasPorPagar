<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteInversiones
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
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.crvInversiones = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptInversiones1 = New cuentasPorPagar.rptInversiones()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "MMMM yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(64, 6)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(136, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Periodo:"
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(221, 6)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 2
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'crvInversiones
        '
        Me.crvInversiones.ActiveViewIndex = 0
        Me.crvInversiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvInversiones.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvInversiones.Location = New System.Drawing.Point(12, 32)
        Me.crvInversiones.Name = "crvInversiones"
        Me.crvInversiones.ReportSource = Me.rptInversiones1
        Me.crvInversiones.Size = New System.Drawing.Size(1146, 406)
        Me.crvInversiones.TabIndex = 3
        Me.crvInversiones.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1085, 444)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmReporteInversiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 477)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.crvInversiones)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmReporteInversiones"
        Me.Text = "Inversiones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnProcesar As Button
    Friend WithEvents crvInversiones As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptInversiones1 As rptInversiones
    Friend WithEvents btnSalir As Button
End Class
