﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompGstPDF
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
        Me.IdFolioSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DecripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpDepositadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPagadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioComprobacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwCXPMisComprobacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.Vw_CXP_MisComprobacionesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.Vw_CXP_MisComprobacionesTableAdapter()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCXPMisComprobacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFolioSolicitudDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn, Me.DecripcionDataGridViewTextBoxColumn, Me.ImpDepositadoDataGridViewTextBoxColumn, Me.SaldoSolicitudDataGridViewTextBoxColumn, Me.TotalPagadoDataGridViewTextBoxColumn, Me.FolioComprobacionDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VwCXPMisComprobacionesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(921, 293)
        Me.DataGridView1.TabIndex = 0
        '
        'IdFolioSolicitudDataGridViewTextBoxColumn
        '
        Me.IdFolioSolicitudDataGridViewTextBoxColumn.DataPropertyName = "idFolioSolicitud"
        Me.IdFolioSolicitudDataGridViewTextBoxColumn.HeaderText = "Folio Solicitud"
        Me.IdFolioSolicitudDataGridViewTextBoxColumn.Name = "IdFolioSolicitudDataGridViewTextBoxColumn"
        Me.IdFolioSolicitudDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdFolioSolicitudDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "razonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "Beneficiario"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.Width = 200
        '
        'DecripcionDataGridViewTextBoxColumn
        '
        Me.DecripcionDataGridViewTextBoxColumn.DataPropertyName = "decripcion"
        Me.DecripcionDataGridViewTextBoxColumn.HeaderText = "Decripcion"
        Me.DecripcionDataGridViewTextBoxColumn.Name = "DecripcionDataGridViewTextBoxColumn"
        Me.DecripcionDataGridViewTextBoxColumn.Width = 250
        '
        'ImpDepositadoDataGridViewTextBoxColumn
        '
        Me.ImpDepositadoDataGridViewTextBoxColumn.DataPropertyName = "impDepositado"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ImpDepositadoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ImpDepositadoDataGridViewTextBoxColumn.HeaderText = "Importe Depositado"
        Me.ImpDepositadoDataGridViewTextBoxColumn.Name = "ImpDepositadoDataGridViewTextBoxColumn"
        '
        'SaldoSolicitudDataGridViewTextBoxColumn
        '
        Me.SaldoSolicitudDataGridViewTextBoxColumn.DataPropertyName = "saldoSolicitud"
        Me.SaldoSolicitudDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoSolicitudDataGridViewTextBoxColumn.Name = "SaldoSolicitudDataGridViewTextBoxColumn"
        '
        'TotalPagadoDataGridViewTextBoxColumn
        '
        Me.TotalPagadoDataGridViewTextBoxColumn.DataPropertyName = "totalPagado"
        Me.TotalPagadoDataGridViewTextBoxColumn.HeaderText = "Comprobado"
        Me.TotalPagadoDataGridViewTextBoxColumn.Name = "TotalPagadoDataGridViewTextBoxColumn"
        Me.TotalPagadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FolioComprobacionDataGridViewTextBoxColumn
        '
        Me.FolioComprobacionDataGridViewTextBoxColumn.DataPropertyName = "folioComprobacion"
        Me.FolioComprobacionDataGridViewTextBoxColumn.HeaderText = "Folio Comprobación"
        Me.FolioComprobacionDataGridViewTextBoxColumn.Name = "FolioComprobacionDataGridViewTextBoxColumn"
        Me.FolioComprobacionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FolioComprobacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario Emisor"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        '
        'VwCXPMisComprobacionesBindingSource
        '
        Me.VwCXPMisComprobacionesBindingSource.DataMember = "Vw_CXP_MisComprobaciones"
        Me.VwCXPMisComprobacionesBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_CXP_MisComprobacionesTableAdapter
        '
        Me.Vw_CXP_MisComprobacionesTableAdapter.ClearBeforeFill = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(13, 7)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(230, 20)
        Me.txtBuscar.TabIndex = 1
        Me.txtBuscar.Text = "Buscar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(249, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(858, 332)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmCompGstPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 363)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCompGstPDF"
        Me.Text = "Comprobación de Gastos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCXPMisComprobacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VwCXPMisComprobacionesBindingSource As BindingSource
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents Vw_CXP_MisComprobacionesTableAdapter As dsProductionTableAdapters.Vw_CXP_MisComprobacionesTableAdapter
    Friend WithEvents IdFolioSolicitudDataGridViewTextBoxColumn As DataGridViewLinkColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DecripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpDepositadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoSolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPagadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FolioComprobacionDataGridViewTextBoxColumn As DataGridViewLinkColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSalir As Button
End Class
