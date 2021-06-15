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
        Me.components = New System.ComponentModel.Container()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.txtTipoSolicitud = New System.Windows.Forms.TextBox()
        Me.txtFolioSolicitud = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNotificaPago = New System.Windows.Forms.Button()
        Me.btnGeneraPolizaDiario = New System.Windows.Forms.Button()
        Me.txtUuid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ddlConc = New System.Windows.Forms.ComboBox()
        Me.CXPConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.ddlProveedores = New System.Windows.Forms.ComboBox()
        Me.CXPProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CXP_ConceptosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ConceptosTableAdapter()
        Me.CXP_ProveedoresTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ProveedoresTableAdapter()
        CType(Me.CXPConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnGeneraPolizaDiario
        '
        Me.btnGeneraPolizaDiario.Location = New System.Drawing.Point(527, 199)
        Me.btnGeneraPolizaDiario.Name = "btnGeneraPolizaDiario"
        Me.btnGeneraPolizaDiario.Size = New System.Drawing.Size(117, 23)
        Me.btnGeneraPolizaDiario.TabIndex = 8
        Me.btnGeneraPolizaDiario.Text = "Genera Pólizas Diario"
        Me.btnGeneraPolizaDiario.UseVisualStyleBackColor = True
        '
        'txtUuid
        '
        Me.txtUuid.Location = New System.Drawing.Point(134, 123)
        Me.txtUuid.Name = "txtUuid"
        Me.txtUuid.Size = New System.Drawing.Size(257, 20)
        Me.txtUuid.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "UUUID:"
        '
        'ddlConc
        '
        Me.ddlConc.DataSource = Me.CXPConceptosBindingSource
        Me.ddlConc.DisplayMember = "nombre"
        Me.ddlConc.FormattingEnabled = True
        Me.ddlConc.Location = New System.Drawing.Point(134, 159)
        Me.ddlConc.Name = "ddlConc"
        Me.ddlConc.Size = New System.Drawing.Size(374, 21)
        Me.ddlConc.TabIndex = 11
        Me.ddlConc.ValueMember = "idConcepto"
        '
        'CXPConceptosBindingSource
        '
        Me.CXPConceptosBindingSource.DataMember = "CXP_Conceptos"
        Me.CXPConceptosBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ddlProveedores
        '
        Me.ddlProveedores.DataSource = Me.CXPProveedoresBindingSource
        Me.ddlProveedores.DisplayMember = "razonSocial"
        Me.ddlProveedores.FormattingEnabled = True
        Me.ddlProveedores.Location = New System.Drawing.Point(134, 199)
        Me.ddlProveedores.Name = "ddlProveedores"
        Me.ddlProveedores.Size = New System.Drawing.Size(374, 21)
        Me.ddlProveedores.TabIndex = 12
        Me.ddlProveedores.ValueMember = "idProveedor"
        '
        'CXPProveedoresBindingSource
        '
        Me.CXPProveedoresBindingSource.DataMember = "CXP_Proveedores"
        Me.CXPProveedoresBindingSource.DataSource = Me.DsProduction
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Concepto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Proveedor:"
        '
        'CXP_ConceptosTableAdapter
        '
        Me.CXP_ConceptosTableAdapter.ClearBeforeFill = True
        '
        'CXP_ProveedoresTableAdapter
        '
        Me.CXP_ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'frmGeneraPolizas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 245)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ddlProveedores)
        Me.Controls.Add(Me.ddlConc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUuid)
        Me.Controls.Add(Me.btnGeneraPolizaDiario)
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
        CType(Me.CXPConceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnGeneraPolizaDiario As Button
    Friend WithEvents txtUuid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ddlConc As ComboBox
    Friend WithEvents ddlProveedores As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CXPConceptosBindingSource As BindingSource
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_ConceptosTableAdapter As dsProductionTableAdapters.CXP_ConceptosTableAdapter
    Friend WithEvents CXPProveedoresBindingSource As BindingSource
    Friend WithEvents CXP_ProveedoresTableAdapter As dsProductionTableAdapters.CXP_ProveedoresTableAdapter
End Class
