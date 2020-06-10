<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutorizarCuentasBancarias
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
        Dim NombreCortoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim C_NombreMonedaLabel As System.Windows.Forms.Label
        Dim CuentaLabel As System.Windows.Forms.Label
        Dim ClabeLabel As System.Windows.Forms.Label
        Dim DescEstatusLabel As System.Windows.Forms.Label
        Dim Sn1Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutorizarCuentasBancarias))
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.Vw_CXP_CuentasBancariasProvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_CXP_CuentasBancariasProvTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.Vw_CXP_CuentasBancariasProvTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.Vw_CXP_CuentasBancariasProvBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreCortoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.C_NombreMonedaTextBox = New System.Windows.Forms.TextBox()
        Me.ClabeTextBox = New System.Windows.Forms.TextBox()
        Me.DescEstatusTextBox = New System.Windows.Forms.TextBox()
        Me.Sn1TextBox = New System.Windows.Forms.TextBox()
        Me.btnAutorizar = New System.Windows.Forms.Button()
        Me.btnRechazar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lnkCuenta = New System.Windows.Forms.LinkLabel()
        NombreCortoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        C_NombreMonedaLabel = New System.Windows.Forms.Label()
        CuentaLabel = New System.Windows.Forms.Label()
        ClabeLabel = New System.Windows.Forms.Label()
        DescEstatusLabel = New System.Windows.Forms.Label()
        Sn1Label = New System.Windows.Forms.Label()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_CXP_CuentasBancariasProvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_CXP_CuentasBancariasProvBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreCortoLabel
        '
        NombreCortoLabel.AutoSize = True
        NombreCortoLabel.Location = New System.Drawing.Point(70, 56)
        NombreCortoLabel.Name = "NombreCortoLabel"
        NombreCortoLabel.Size = New System.Drawing.Size(41, 13)
        NombreCortoLabel.TabIndex = 2
        NombreCortoLabel.Text = "Banco:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(45, 82)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripción:"
        '
        'C_NombreMonedaLabel
        '
        C_NombreMonedaLabel.AutoSize = True
        C_NombreMonedaLabel.Location = New System.Drawing.Point(62, 108)
        C_NombreMonedaLabel.Name = "C_NombreMonedaLabel"
        C_NombreMonedaLabel.Size = New System.Drawing.Size(49, 13)
        C_NombreMonedaLabel.TabIndex = 6
        C_NombreMonedaLabel.Text = "Moneda:"
        '
        'CuentaLabel
        '
        CuentaLabel.AutoSize = True
        CuentaLabel.Location = New System.Drawing.Point(270, 108)
        CuentaLabel.Name = "CuentaLabel"
        CuentaLabel.Size = New System.Drawing.Size(44, 13)
        CuentaLabel.TabIndex = 8
        CuentaLabel.Text = "Cuenta:"
        '
        'ClabeLabel
        '
        ClabeLabel.AutoSize = True
        ClabeLabel.Location = New System.Drawing.Point(67, 134)
        ClabeLabel.Name = "ClabeLabel"
        ClabeLabel.Size = New System.Drawing.Size(44, 13)
        ClabeLabel.TabIndex = 10
        ClabeLabel.Text = "CLABE:"
        '
        'DescEstatusLabel
        '
        DescEstatusLabel.AutoSize = True
        DescEstatusLabel.Location = New System.Drawing.Point(66, 160)
        DescEstatusLabel.Name = "DescEstatusLabel"
        DescEstatusLabel.Size = New System.Drawing.Size(45, 13)
        DescEstatusLabel.TabIndex = 12
        DescEstatusLabel.Text = "Estatus:"
        '
        'Sn1Label
        '
        Sn1Label.AutoSize = True
        Sn1Label.Location = New System.Drawing.Point(52, 186)
        Sn1Label.Name = "Sn1Label"
        Sn1Label.Size = New System.Drawing.Size(59, 13)
        Sn1Label.TabIndex = 14
        Sn1Label.Text = "Solicitante:"
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_CXP_CuentasBancariasProvBindingSource
        '
        Me.Vw_CXP_CuentasBancariasProvBindingSource.DataMember = "Vw_CXP_CuentasBancariasProv"
        Me.Vw_CXP_CuentasBancariasProvBindingSource.DataSource = Me.DsProduction
        '
        'Vw_CXP_CuentasBancariasProvTableAdapter
        '
        Me.Vw_CXP_CuentasBancariasProvTableAdapter.ClearBeforeFill = True
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
        'Vw_CXP_CuentasBancariasProvBindingNavigator
        '
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.BindingSource = Me.Vw_CXP_CuentasBancariasProvBindingSource
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.Enabled = False
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Vw_CXP_CuentasBancariasProvBindingNavigatorSaveItem})
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.Name = "Vw_CXP_CuentasBancariasProvBindingNavigator"
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.Size = New System.Drawing.Size(537, 25)
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.TabIndex = 0
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.Text = "BindingNavigator1"
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
        'Vw_CXP_CuentasBancariasProvBindingNavigatorSaveItem
        '
        Me.Vw_CXP_CuentasBancariasProvBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Vw_CXP_CuentasBancariasProvBindingNavigatorSaveItem.Enabled = False
        Me.Vw_CXP_CuentasBancariasProvBindingNavigatorSaveItem.Image = CType(resources.GetObject("Vw_CXP_CuentasBancariasProvBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Vw_CXP_CuentasBancariasProvBindingNavigatorSaveItem.Name = "Vw_CXP_CuentasBancariasProvBindingNavigatorSaveItem"
        Me.Vw_CXP_CuentasBancariasProvBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Vw_CXP_CuentasBancariasProvBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreCortoTextBox
        '
        Me.NombreCortoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CXP_CuentasBancariasProvBindingSource, "nombreCorto", True))
        Me.NombreCortoTextBox.Location = New System.Drawing.Point(117, 53)
        Me.NombreCortoTextBox.Name = "NombreCortoTextBox"
        Me.NombreCortoTextBox.ReadOnly = True
        Me.NombreCortoTextBox.Size = New System.Drawing.Size(365, 20)
        Me.NombreCortoTextBox.TabIndex = 3
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CXP_CuentasBancariasProvBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(117, 79)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.ReadOnly = True
        Me.DescripcionTextBox.Size = New System.Drawing.Size(365, 20)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'C_NombreMonedaTextBox
        '
        Me.C_NombreMonedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CXP_CuentasBancariasProvBindingSource, "c_NombreMoneda", True))
        Me.C_NombreMonedaTextBox.Location = New System.Drawing.Point(117, 105)
        Me.C_NombreMonedaTextBox.Name = "C_NombreMonedaTextBox"
        Me.C_NombreMonedaTextBox.ReadOnly = True
        Me.C_NombreMonedaTextBox.Size = New System.Drawing.Size(147, 20)
        Me.C_NombreMonedaTextBox.TabIndex = 7
        '
        'ClabeTextBox
        '
        Me.ClabeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CXP_CuentasBancariasProvBindingSource, "clabe", True))
        Me.ClabeTextBox.Location = New System.Drawing.Point(117, 131)
        Me.ClabeTextBox.Name = "ClabeTextBox"
        Me.ClabeTextBox.ReadOnly = True
        Me.ClabeTextBox.Size = New System.Drawing.Size(262, 20)
        Me.ClabeTextBox.TabIndex = 11
        '
        'DescEstatusTextBox
        '
        Me.DescEstatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CXP_CuentasBancariasProvBindingSource, "descEstatus", True))
        Me.DescEstatusTextBox.Location = New System.Drawing.Point(117, 157)
        Me.DescEstatusTextBox.Name = "DescEstatusTextBox"
        Me.DescEstatusTextBox.ReadOnly = True
        Me.DescEstatusTextBox.Size = New System.Drawing.Size(262, 20)
        Me.DescEstatusTextBox.TabIndex = 13
        '
        'Sn1TextBox
        '
        Me.Sn1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CXP_CuentasBancariasProvBindingSource, "sn1", True))
        Me.Sn1TextBox.Location = New System.Drawing.Point(117, 183)
        Me.Sn1TextBox.Name = "Sn1TextBox"
        Me.Sn1TextBox.ReadOnly = True
        Me.Sn1TextBox.Size = New System.Drawing.Size(262, 20)
        Me.Sn1TextBox.TabIndex = 15
        '
        'btnAutorizar
        '
        Me.btnAutorizar.Location = New System.Drawing.Point(117, 220)
        Me.btnAutorizar.Name = "btnAutorizar"
        Me.btnAutorizar.Size = New System.Drawing.Size(147, 23)
        Me.btnAutorizar.TabIndex = 16
        Me.btnAutorizar.Text = "Autorizar"
        Me.btnAutorizar.UseVisualStyleBackColor = True
        '
        'btnRechazar
        '
        Me.btnRechazar.Location = New System.Drawing.Point(335, 220)
        Me.btnRechazar.Name = "btnRechazar"
        Me.btnRechazar.Size = New System.Drawing.Size(147, 23)
        Me.btnRechazar.TabIndex = 17
        Me.btnRechazar.Text = "Rechazar"
        Me.btnRechazar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(407, 264)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lnkCuenta
        '
        Me.lnkCuenta.AutoSize = True
        Me.lnkCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CXP_CuentasBancariasProvBindingSource, "cuenta", True))
        Me.lnkCuenta.Location = New System.Drawing.Point(320, 108)
        Me.lnkCuenta.Name = "lnkCuenta"
        Me.lnkCuenta.Size = New System.Drawing.Size(59, 13)
        Me.lnkCuenta.TabIndex = 19
        Me.lnkCuenta.TabStop = True
        Me.lnkCuenta.Text = "LinkLabel1"
        '
        'frmAutorizarCuentasBancarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 299)
        Me.Controls.Add(Me.lnkCuenta)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRechazar)
        Me.Controls.Add(Me.btnAutorizar)
        Me.Controls.Add(Sn1Label)
        Me.Controls.Add(Me.Sn1TextBox)
        Me.Controls.Add(DescEstatusLabel)
        Me.Controls.Add(Me.DescEstatusTextBox)
        Me.Controls.Add(ClabeLabel)
        Me.Controls.Add(Me.ClabeTextBox)
        Me.Controls.Add(CuentaLabel)
        Me.Controls.Add(C_NombreMonedaLabel)
        Me.Controls.Add(Me.C_NombreMonedaTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(NombreCortoLabel)
        Me.Controls.Add(Me.NombreCortoTextBox)
        Me.Controls.Add(Me.Vw_CXP_CuentasBancariasProvBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmAutorizarCuentasBancarias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorizar Cuentas Bancarias"
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_CXP_CuentasBancariasProvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_CXP_CuentasBancariasProvBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.ResumeLayout(False)
        Me.Vw_CXP_CuentasBancariasProvBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents Vw_CXP_CuentasBancariasProvBindingSource As BindingSource
    Friend WithEvents Vw_CXP_CuentasBancariasProvTableAdapter As dsProductionTableAdapters.Vw_CXP_CuentasBancariasProvTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents Vw_CXP_CuentasBancariasProvBindingNavigator As BindingNavigator
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
    Friend WithEvents Vw_CXP_CuentasBancariasProvBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NombreCortoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents C_NombreMonedaTextBox As TextBox
    Friend WithEvents ClabeTextBox As TextBox
    Friend WithEvents DescEstatusTextBox As TextBox
    Friend WithEvents Sn1TextBox As TextBox
    Friend WithEvents btnAutorizar As Button
    Friend WithEvents btnRechazar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lnkCuenta As LinkLabel
End Class
