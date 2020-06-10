<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutorizarDocumentacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim DescEstatusLabel As System.Windows.Forms.Label
        Dim UsuarioSolicita1Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutorizarDocumentacion))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Vw_CXP_DocumentacionProvBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Vw_CXP_DocumentacionProvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Vw_CXP_DocumentacionProvBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DescEstatusTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioSolicita1TextBox = New System.Windows.Forms.TextBox()
        Me.lnkDocumento = New System.Windows.Forms.LinkLabel()
        Me.btnAutorizar = New System.Windows.Forms.Button()
        Me.btnRechazar = New System.Windows.Forms.Button()
        Me.Vw_CXP_DocumentacionProvTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.Vw_CXP_DocumentacionProvTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        DescripcionLabel = New System.Windows.Forms.Label()
        DescEstatusLabel = New System.Windows.Forms.Label()
        UsuarioSolicita1Label = New System.Windows.Forms.Label()
        CType(Me.Vw_CXP_DocumentacionProvBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vw_CXP_DocumentacionProvBindingNavigator.SuspendLayout()
        CType(Me.Vw_CXP_DocumentacionProvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(47, 54)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(65, 13)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Documento:"
        '
        'DescEstatusLabel
        '
        DescEstatusLabel.AutoSize = True
        DescEstatusLabel.Location = New System.Drawing.Point(34, 80)
        DescEstatusLabel.Name = "DescEstatusLabel"
        DescEstatusLabel.Size = New System.Drawing.Size(77, 13)
        DescEstatusLabel.TabIndex = 5
        DescEstatusLabel.Text = "Estatus actual:"
        '
        'UsuarioSolicita1Label
        '
        UsuarioSolicita1Label.AutoSize = True
        UsuarioSolicita1Label.Location = New System.Drawing.Point(9, 106)
        UsuarioSolicita1Label.Name = "UsuarioSolicita1Label"
        UsuarioSolicita1Label.Size = New System.Drawing.Size(102, 13)
        UsuarioSolicita1Label.TabIndex = 6
        UsuarioSolicita1Label.Text = "Usuario que solicita:"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(294, 187)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Vw_CXP_DocumentacionProvBindingNavigator
        '
        Me.Vw_CXP_DocumentacionProvBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Vw_CXP_DocumentacionProvBindingNavigator.BindingSource = Me.Vw_CXP_DocumentacionProvBindingSource
        Me.Vw_CXP_DocumentacionProvBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Vw_CXP_DocumentacionProvBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Vw_CXP_DocumentacionProvBindingNavigator.Enabled = False
        Me.Vw_CXP_DocumentacionProvBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Vw_CXP_DocumentacionProvBindingNavigatorSaveItem})
        Me.Vw_CXP_DocumentacionProvBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Vw_CXP_DocumentacionProvBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Vw_CXP_DocumentacionProvBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Vw_CXP_DocumentacionProvBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Vw_CXP_DocumentacionProvBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Vw_CXP_DocumentacionProvBindingNavigator.Name = "Vw_CXP_DocumentacionProvBindingNavigator"
        Me.Vw_CXP_DocumentacionProvBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Vw_CXP_DocumentacionProvBindingNavigator.Size = New System.Drawing.Size(413, 25)
        Me.Vw_CXP_DocumentacionProvBindingNavigator.TabIndex = 3
        Me.Vw_CXP_DocumentacionProvBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'Vw_CXP_DocumentacionProvBindingSource
        '
        Me.Vw_CXP_DocumentacionProvBindingSource.DataMember = "Vw_CXP_DocumentacionProv"
        Me.Vw_CXP_DocumentacionProvBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Vw_CXP_DocumentacionProvBindingNavigatorSaveItem
        '
        Me.Vw_CXP_DocumentacionProvBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Vw_CXP_DocumentacionProvBindingNavigatorSaveItem.Enabled = False
        Me.Vw_CXP_DocumentacionProvBindingNavigatorSaveItem.Image = CType(resources.GetObject("Vw_CXP_DocumentacionProvBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Vw_CXP_DocumentacionProvBindingNavigatorSaveItem.Name = "Vw_CXP_DocumentacionProvBindingNavigatorSaveItem"
        Me.Vw_CXP_DocumentacionProvBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Vw_CXP_DocumentacionProvBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'DescEstatusTextBox
        '
        Me.DescEstatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CXP_DocumentacionProvBindingSource, "descEstatus", True))
        Me.DescEstatusTextBox.Location = New System.Drawing.Point(117, 77)
        Me.DescEstatusTextBox.Name = "DescEstatusTextBox"
        Me.DescEstatusTextBox.ReadOnly = True
        Me.DescEstatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescEstatusTextBox.TabIndex = 6
        '
        'UsuarioSolicita1TextBox
        '
        Me.UsuarioSolicita1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CXP_DocumentacionProvBindingSource, "sn1", True))
        Me.UsuarioSolicita1TextBox.Location = New System.Drawing.Point(117, 103)
        Me.UsuarioSolicita1TextBox.Name = "UsuarioSolicita1TextBox"
        Me.UsuarioSolicita1TextBox.ReadOnly = True
        Me.UsuarioSolicita1TextBox.Size = New System.Drawing.Size(200, 20)
        Me.UsuarioSolicita1TextBox.TabIndex = 7
        '
        'lnkDocumento
        '
        Me.lnkDocumento.AutoSize = True
        Me.lnkDocumento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CXP_DocumentacionProvBindingSource, "descripcion", True))
        Me.lnkDocumento.Location = New System.Drawing.Point(119, 54)
        Me.lnkDocumento.Name = "lnkDocumento"
        Me.lnkDocumento.Size = New System.Drawing.Size(59, 13)
        Me.lnkDocumento.TabIndex = 11
        Me.lnkDocumento.TabStop = True
        Me.lnkDocumento.Text = "LinkLabel1"
        '
        'btnAutorizar
        '
        Me.btnAutorizar.Location = New System.Drawing.Point(37, 149)
        Me.btnAutorizar.Name = "btnAutorizar"
        Me.btnAutorizar.Size = New System.Drawing.Size(141, 23)
        Me.btnAutorizar.TabIndex = 12
        Me.btnAutorizar.Text = "Autorizar"
        Me.btnAutorizar.UseVisualStyleBackColor = True
        '
        'btnRechazar
        '
        Me.btnRechazar.Location = New System.Drawing.Point(228, 149)
        Me.btnRechazar.Name = "btnRechazar"
        Me.btnRechazar.Size = New System.Drawing.Size(141, 23)
        Me.btnRechazar.TabIndex = 13
        Me.btnRechazar.Text = "Rechazar"
        Me.btnRechazar.UseVisualStyleBackColor = True
        '
        'Vw_CXP_DocumentacionProvTableAdapter
        '
        Me.Vw_CXP_DocumentacionProvTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CFDI_Estado_NominaTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CXP_AutorizacionesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_BancosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_CodigoPostalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_EstadoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_PaisTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_RegimenFiscalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CodigoAgrupadorTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ComprobGtosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasProvTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DocumentacionProvTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_Estatus1TableAdapter = Nothing
        Me.TableAdapterManager.CXP_Estatus2TableAdapter = Nothing
        Me.TableAdapterManager.CXP_EstatusTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpConTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PagosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresArchTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_RegContTableAdapter = Nothing
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoConceptoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoCuentaContableTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoGastoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdi2TableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdiTableAdapter = Nothing
        Me.TableAdapterManager.GEN_Correos_SistemaFinagilTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmAutorizarDocumentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 222)
        Me.Controls.Add(Me.btnRechazar)
        Me.Controls.Add(Me.btnAutorizar)
        Me.Controls.Add(Me.lnkDocumento)
        Me.Controls.Add(UsuarioSolicita1Label)
        Me.Controls.Add(Me.UsuarioSolicita1TextBox)
        Me.Controls.Add(DescEstatusLabel)
        Me.Controls.Add(Me.DescEstatusTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.Vw_CXP_DocumentacionProvBindingNavigator)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmAutorizarDocumentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorizar Documentación"
        Me.TopMost = True
        CType(Me.Vw_CXP_DocumentacionProvBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vw_CXP_DocumentacionProvBindingNavigator.ResumeLayout(False)
        Me.Vw_CXP_DocumentacionProvBindingNavigator.PerformLayout()
        CType(Me.Vw_CXP_DocumentacionProvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As Button
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents Vw_CXP_DocumentacionProvBindingSource As BindingSource
    Friend WithEvents Vw_CXP_DocumentacionProvTableAdapter As dsProductionTableAdapters.Vw_CXP_DocumentacionProvTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents Vw_CXP_DocumentacionProvBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Vw_CXP_DocumentacionProvBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DescEstatusTextBox As TextBox
    Friend WithEvents UsuarioSolicita1TextBox As TextBox
    Friend WithEvents lnkDocumento As LinkLabel
    Friend WithEvents btnAutorizar As Button
    Friend WithEvents btnRechazar As Button
End Class
