<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValidaCfdi
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
        Me.btnSeleccionarArchivos = New System.Windows.Forms.Button()
        Me.dgvCfdi = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ofdSeleccionarArchivos = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estatusUuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estatusXsd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCfdi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSeleccionarArchivos
        '
        Me.btnSeleccionarArchivos.Location = New System.Drawing.Point(264, 12)
        Me.btnSeleccionarArchivos.Name = "btnSeleccionarArchivos"
        Me.btnSeleccionarArchivos.Size = New System.Drawing.Size(228, 36)
        Me.btnSeleccionarArchivos.TabIndex = 0
        Me.btnSeleccionarArchivos.Text = "Seleccionar Archivos (solo XML y PDF)"
        Me.btnSeleccionarArchivos.UseVisualStyleBackColor = True
        '
        'dgvCfdi
        '
        Me.dgvCfdi.AllowUserToAddRows = False
        Me.dgvCfdi.AllowUserToDeleteRows = False
        Me.dgvCfdi.AllowUserToOrderColumns = True
        Me.dgvCfdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCfdi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serie, Me.folio, Me.uuid, Me.estatusUuid, Me.estatusXsd})
        Me.dgvCfdi.Location = New System.Drawing.Point(12, 56)
        Me.dgvCfdi.Name = "dgvCfdi"
        Me.dgvCfdi.ReadOnly = True
        Me.dgvCfdi.Size = New System.Drawing.Size(776, 238)
        Me.dgvCfdi.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(713, 300)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ofdSeleccionarArchivos
        '
        Me.ofdSeleccionarArchivos.FileName = "OpenFileDialog1"
        Me.ofdSeleccionarArchivos.Multiselect = True
        Me.ofdSeleccionarArchivos.SupportMultiDottedExtensions = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Serie"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn3.HeaderText = "UUID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 5
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Estatus UUID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "estatus XSD"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'serie
        '
        Me.serie.HeaderText = "Serie"
        Me.serie.Name = "serie"
        Me.serie.ReadOnly = True
        '
        'folio
        '
        Me.folio.HeaderText = "Folio"
        Me.folio.Name = "folio"
        Me.folio.ReadOnly = True
        '
        'uuid
        '
        Me.uuid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.uuid.HeaderText = "UUID"
        Me.uuid.Name = "uuid"
        Me.uuid.ReadOnly = True
        Me.uuid.Width = 5
        '
        'estatusUuid
        '
        Me.estatusUuid.HeaderText = "Estatus UUID"
        Me.estatusUuid.Name = "estatusUuid"
        Me.estatusUuid.ReadOnly = True
        '
        'estatusXsd
        '
        Me.estatusXsd.HeaderText = "estatus XSD"
        Me.estatusXsd.Name = "estatusXsd"
        Me.estatusXsd.ReadOnly = True
        Me.estatusXsd.Width = 150
        '
        'frmValidaCfdi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 329)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvCfdi)
        Me.Controls.Add(Me.btnSeleccionarArchivos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmValidaCfdi"
        Me.Text = "Valida CFDI"
        CType(Me.dgvCfdi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSeleccionarArchivos As Button
    Friend WithEvents dgvCfdi As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents ofdSeleccionarArchivos As OpenFileDialog
    Friend WithEvents serie As DataGridViewTextBoxColumn
    Friend WithEvents folio As DataGridViewTextBoxColumn
    Friend WithEvents uuid As DataGridViewTextBoxColumn
    Friend WithEvents estatusUuid As DataGridViewTextBoxColumn
    Friend WithEvents estatusXsd As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
