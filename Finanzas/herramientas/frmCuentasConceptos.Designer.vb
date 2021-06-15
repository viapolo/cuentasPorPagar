<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentasConceptos
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
        Me.mtbCuentas = New System.Windows.Forms.MaskedTextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.DsContabilidad = New cuentasPorPagar.dsContabilidad()
        Me.CXP_ConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_ConceptosTableAdapter = New cuentasPorPagar.dsContabilidadTableAdapters.CXP_ConceptosTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.CXP_ConceptosDataGridView = New System.Windows.Forms.DataGridView()
        Me.CXP_ConceptosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsHerramientas = New cuentasPorPagar.dsHerramientas()
        Me.CXP_ConceptosTableAdapter1 = New cuentasPorPagar.dsHerramientasTableAdapters.CXP_ConceptosTableAdapter()
        Me.TableAdapterManager1 = New cuentasPorPagar.dsHerramientasTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ConceptosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ConceptosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHerramientas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtbCuentas
        '
        Me.mtbCuentas.Location = New System.Drawing.Point(12, 12)
        Me.mtbCuentas.Mask = "0000-00-00-0000-0000"
        Me.mtbCuentas.Name = "mtbCuentas"
        Me.mtbCuentas.Size = New System.Drawing.Size(198, 20)
        Me.mtbCuentas.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(901, 293)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "dsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_ConceptosBindingSource
        '
        Me.CXP_ConceptosBindingSource.DataMember = "CXP_Conceptos"
        Me.CXP_ConceptosBindingSource.DataSource = Me.DsContabilidad
        '
        'CXP_ConceptosTableAdapter
        '
        Me.CXP_ConceptosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONT_TiposDeCambioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ComprobGtos1TableAdapter = Nothing
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Me.CXP_ConceptosTableAdapter
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EstatusTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PagosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PagosTesoreriaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PeriodosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PolizaMovimientosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoDeSolicitudTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsContabilidadTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(216, 9)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'CXP_ConceptosDataGridView
        '
        Me.CXP_ConceptosDataGridView.AllowUserToAddRows = False
        Me.CXP_ConceptosDataGridView.AllowUserToDeleteRows = False
        Me.CXP_ConceptosDataGridView.AllowUserToOrderColumns = True
        Me.CXP_ConceptosDataGridView.AutoGenerateColumns = False
        Me.CXP_ConceptosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CXP_ConceptosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.CXP_ConceptosDataGridView.DataSource = Me.CXP_ConceptosBindingSource1
        Me.CXP_ConceptosDataGridView.Location = New System.Drawing.Point(12, 48)
        Me.CXP_ConceptosDataGridView.Name = "CXP_ConceptosDataGridView"
        Me.CXP_ConceptosDataGridView.ReadOnly = True
        Me.CXP_ConceptosDataGridView.Size = New System.Drawing.Size(964, 239)
        Me.CXP_ConceptosDataGridView.TabIndex = 4
        '
        'CXP_ConceptosBindingSource1
        '
        Me.CXP_ConceptosBindingSource1.DataMember = "CXP_Conceptos"
        Me.CXP_ConceptosBindingSource1.DataSource = Me.DsHerramientas
        '
        'DsHerramientas
        '
        Me.DsHerramientas.DataSetName = "dsHerramientas"
        Me.DsHerramientas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_ConceptosTableAdapter1
        '
        Me.CXP_ConceptosTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CXP_BancosTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_ConceptosTableAdapter = Me.CXP_ConceptosTableAdapter1
        Me.TableAdapterManager1.CXP_CorreosProveedoresTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_CuentasBancariasProvTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = cuentasPorPagar.dsHerramientasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cuentaProv"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cuentaProv"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "idEmpresa"
        Me.DataGridViewTextBoxColumn5.HeaderText = "idEmpresa"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idConcepto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idConcepto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cuentaEgreso"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cuentaEgreso"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "eventoContable"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "eventoContable"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cuentaProv"
        Me.DataGridViewTextBoxColumn6.HeaderText = "cuentaProv"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "omisionEC"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "omisionEC"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idEmpresa"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idEmpresa"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "tipoConcepto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "tipoConcepto"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ctaCargoPago"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ctaCargoPago"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ctaAbonoPago"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ctaAbonoPago"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'frmCuentasConceptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 328)
        Me.Controls.Add(Me.CXP_ConceptosDataGridView)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.mtbCuentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCuentasConceptos"
        Me.Text = "Cuentas - Conceptos"
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_ConceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_ConceptosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_ConceptosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHerramientas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtbCuentas As MaskedTextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents DsContabilidad As dsContabilidad
    Friend WithEvents CXP_ConceptosBindingSource As BindingSource
    Friend WithEvents CXP_ConceptosTableAdapter As dsContabilidadTableAdapters.CXP_ConceptosTableAdapter
    Friend WithEvents TableAdapterManager As dsContabilidadTableAdapters.TableAdapterManager
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DsHerramientas As dsHerramientas
    Friend WithEvents CXP_ConceptosBindingSource1 As BindingSource
    Friend WithEvents CXP_ConceptosTableAdapter1 As dsHerramientasTableAdapters.CXP_ConceptosTableAdapter
    Friend WithEvents TableAdapterManager1 As dsHerramientasTableAdapters.TableAdapterManager
    Friend WithEvents CXP_ConceptosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
