<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneraPdfExpedienteView
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
        Me.crvGeneraPdf = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptPdfDocumentacion1 = New cuentasPorPagar.rptPdfDocumentacion()
        Me.SuspendLayout()
        '
        'crvGeneraPdf
        '
        Me.crvGeneraPdf.ActiveViewIndex = 0
        Me.crvGeneraPdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvGeneraPdf.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvGeneraPdf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvGeneraPdf.Location = New System.Drawing.Point(0, 0)
        Me.crvGeneraPdf.Name = "crvGeneraPdf"
        Me.crvGeneraPdf.ReportSource = Me.rptPdfDocumentacion1
        Me.crvGeneraPdf.Size = New System.Drawing.Size(800, 450)
        Me.crvGeneraPdf.TabIndex = 0
        Me.crvGeneraPdf.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmGeneraPdfExpedienteView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.crvGeneraPdf)
        Me.Name = "frmGeneraPdfExpedienteView"
        Me.Text = "Archivo PDF"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvGeneraPdf As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptPdfDocumentacion1 As rptPdfDocumentacion
End Class
