﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSCPDF
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FolioSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.FechaSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPagadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwCXPMisSolicitudesSCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.Vw_CXP_MisSolicitudesSCTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.Vw_CXP_MisSolicitudesSCTableAdapter()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCXPMisSolicitudesSCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioSolicitudDataGridViewTextBoxColumn, Me.FechaSolicitudDataGridViewTextBoxColumn, Me.TotalPagadoDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VwCXPMisSolicitudesSCBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(631, 272)
        Me.DataGridView1.TabIndex = 0
        '
        'FolioSolicitudDataGridViewTextBoxColumn
        '
        Me.FolioSolicitudDataGridViewTextBoxColumn.DataPropertyName = "folioSolicitud"
        Me.FolioSolicitudDataGridViewTextBoxColumn.HeaderText = "Folio Solicitud"
        Me.FolioSolicitudDataGridViewTextBoxColumn.Name = "FolioSolicitudDataGridViewTextBoxColumn"
        Me.FolioSolicitudDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioSolicitudDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FolioSolicitudDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'FechaSolicitudDataGridViewTextBoxColumn
        '
        Me.FechaSolicitudDataGridViewTextBoxColumn.DataPropertyName = "fechaSolicitud"
        Me.FechaSolicitudDataGridViewTextBoxColumn.HeaderText = "Fecha Solicitud"
        Me.FechaSolicitudDataGridViewTextBoxColumn.Name = "FechaSolicitudDataGridViewTextBoxColumn"
        Me.FechaSolicitudDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalPagadoDataGridViewTextBoxColumn
        '
        Me.TotalPagadoDataGridViewTextBoxColumn.DataPropertyName = "totalPagado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TotalPagadoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TotalPagadoDataGridViewTextBoxColumn.HeaderText = "Total Pagado"
        Me.TotalPagadoDataGridViewTextBoxColumn.Name = "TotalPagadoDataGridViewTextBoxColumn"
        Me.TotalPagadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "razonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "Razón Social"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.ReadOnly = True
        Me.RazonSocialDataGridViewTextBoxColumn.Width = 200
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwCXPMisSolicitudesSCBindingSource
        '
        Me.VwCXPMisSolicitudesSCBindingSource.DataMember = "Vw_CXP_MisSolicitudesSC"
        Me.VwCXPMisSolicitudesSCBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_CXP_MisSolicitudesSCTableAdapter
        '
        Me.Vw_CXP_MisSolicitudesSCTableAdapter.ClearBeforeFill = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(12, 11)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(199, 20)
        Me.txtBuscar.TabIndex = 1
        Me.txtBuscar.Text = "Buscar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(226, 8)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(568, 315)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmSCPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 345)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSCPDF"
        Me.Text = "Solicitudes de Pago Sin Comprobante Fiscal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCXPMisSolicitudesSCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VwCXPMisSolicitudesSCBindingSource As BindingSource
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents Vw_CXP_MisSolicitudesSCTableAdapter As dsProductionTableAdapters.Vw_CXP_MisSolicitudesSCTableAdapter
    Friend WithEvents FolioSolicitudDataGridViewTextBoxColumn As DataGridViewLinkColumn
    Friend WithEvents FechaSolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPagadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSalir As Button
End Class
