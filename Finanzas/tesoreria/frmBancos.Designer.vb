<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBancos
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
        Me.crvBancos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptBancos_11 = New cuentasPorPagar.rptBancos_1()
        Me.SuspendLayout()
        '
        'crvBancos
        '
        Me.crvBancos.ActiveViewIndex = 0
        Me.crvBancos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvBancos.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvBancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvBancos.Location = New System.Drawing.Point(0, 0)
        Me.crvBancos.Name = "crvBancos"
        Me.crvBancos.ReportSource = Me.rptBancos_11
        Me.crvBancos.Size = New System.Drawing.Size(1016, 719)
        Me.crvBancos.TabIndex = 0
        '
        'frmBancos
        '
        Me.ClientSize = New System.Drawing.Size(1016, 719)
        Me.Controls.Add(Me.crvBancos)
        Me.Name = "frmBancos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crvBancos As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptBancos_11 As rptBancos_1
End Class
