<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProductores
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
        Dim NumProductorLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FProductores))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelPersonal = New System.Windows.Forms.Label()
        Me.ProductoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ProductoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoquinDBDataSet = New SisRoquinProduce.RoquinDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NumProductorTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.ProductoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.NumProductor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProductoresTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.ProductoresTableAdapter()
        Me.TableAdapterManager = New SisRoquinProduce.RoquinDBDataSetTableAdapters.TableAdapterManager()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.LabelListado = New System.Windows.Forms.Label()
        NumProductorLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductoresBindingNavigator.SuspendLayout()
        CType(Me.ProductoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumProductorLabel
        '
        NumProductorLabel.AutoSize = True
        NumProductorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        NumProductorLabel.Location = New System.Drawing.Point(51, 247)
        NumProductorLabel.Name = "NumProductorLabel"
        NumProductorLabel.Size = New System.Drawing.Size(181, 29)
        NumProductorLabel.TabIndex = 18
        NumProductorLabel.Text = "Num Productor:"
        AddHandler NumProductorLabel.Click, AddressOf Me.NumProductorLabel_Click
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        NombreLabel.Location = New System.Drawing.Point(53, 289)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(107, 29)
        NombreLabel.TabIndex = 20
        NombreLabel.Text = "Nombre:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        TelefonoLabel.Location = New System.Drawing.Point(52, 376)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(116, 29)
        TelefonoLabel.TabIndex = 22
        TelefonoLabel.Text = "Teléfono:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.LabelPersonal)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel1.Size = New System.Drawing.Size(980, 200)
        Me.Panel1.TabIndex = 14
        '
        'LabelPersonal
        '
        Me.LabelPersonal.AutoSize = True
        Me.LabelPersonal.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPersonal.Location = New System.Drawing.Point(350, 80)
        Me.LabelPersonal.Name = "LabelPersonal"
        Me.LabelPersonal.Size = New System.Drawing.Size(478, 48)
        Me.LabelPersonal.TabIndex = 0
        Me.LabelPersonal.Text = "𝔸𝕕𝕞𝕚𝕟𝕚𝕤𝕥𝕣𝕒𝕣 ℙ𝕣𝕠𝕕𝕦𝕔𝕥𝕠𝕣𝕖𝕤"
        '
        'ProductoresBindingNavigator
        '
        Me.ProductoresBindingNavigator.AddNewItem = Nothing
        Me.ProductoresBindingNavigator.BindingSource = Me.ProductoresBindingSource
        Me.ProductoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductoresBindingNavigator.DeleteItem = Nothing
        Me.ProductoresBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProductoresBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ProductoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.ProductoresBindingNavigator.Location = New System.Drawing.Point(0, 576)
        Me.ProductoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductoresBindingNavigator.Name = "ProductoresBindingNavigator"
        Me.ProductoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductoresBindingNavigator.Size = New System.Drawing.Size(982, 27)
        Me.ProductoresBindingNavigator.TabIndex = 16
        Me.ProductoresBindingNavigator.Text = "BindingNavigator1"
        '
        'ProductoresBindingSource
        '
        Me.ProductoresBindingSource.DataMember = "Productores"
        Me.ProductoresBindingSource.DataSource = Me.RoquinDBDataSet
        '
        'RoquinDBDataSet
        '
        Me.RoquinDBDataSet.DataSetName = "RoquinDBDataSet"
        Me.RoquinDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(30, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'NumProductorTextBox
        '
        Me.NumProductorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumProductorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoresBindingSource, "NumProductor", True))
        Me.NumProductorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.NumProductorTextBox.Location = New System.Drawing.Point(243, 246)
        Me.NumProductorTextBox.MaxLength = 3
        Me.NumProductorTextBox.Name = "NumProductorTextBox"
        Me.NumProductorTextBox.Size = New System.Drawing.Size(118, 34)
        Me.NumProductorTextBox.TabIndex = 19
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoresBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.NombreTextBox.Location = New System.Drawing.Point(60, 325)
        Me.NombreTextBox.MaxLength = 255
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(301, 34)
        Me.NombreTextBox.TabIndex = 21
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoresBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TelefonoTextBox.Location = New System.Drawing.Point(178, 376)
        Me.TelefonoTextBox.MaxLength = 10
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(183, 34)
        Me.TelefonoTextBox.TabIndex = 23
        '
        'ProductoresDataGridView
        '
        Me.ProductoresDataGridView.AllowUserToAddRows = False
        Me.ProductoresDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ProductoresDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.ProductoresDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductoresDataGridView.AutoGenerateColumns = False
        Me.ProductoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductoresDataGridView.BackgroundColor = System.Drawing.Color.LightGreen
        Me.ProductoresDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProductoresDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductoresDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.ProductoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumProductor, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ProductoresDataGridView.DataSource = Me.ProductoresBindingSource
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductoresDataGridView.DefaultCellStyle = DataGridViewCellStyle15
        Me.ProductoresDataGridView.GridColor = System.Drawing.Color.Black
        Me.ProductoresDataGridView.Location = New System.Drawing.Point(410, 246)
        Me.ProductoresDataGridView.Name = "ProductoresDataGridView"
        Me.ProductoresDataGridView.ReadOnly = True
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductoresDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.ProductoresDataGridView.RowHeadersVisible = False
        Me.ProductoresDataGridView.RowTemplate.Height = 24
        Me.ProductoresDataGridView.Size = New System.Drawing.Size(560, 276)
        Me.ProductoresDataGridView.TabIndex = 23
        '
        'NumProductor
        '
        Me.NumProductor.DataPropertyName = "NumProductor"
        Me.NumProductor.FillWeight = 60.0!
        Me.NumProductor.HeaderText = "NumProductor"
        Me.NumProductor.Name = "NumProductor"
        Me.NumProductor.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn4.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGreen
        Me.PictureBox1.Image = Global.SisRoquinProduce.My.Resources.Resources.Roquin_logo6
        Me.PictureBox1.Location = New System.Drawing.Point(50, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'ProductoresTableAdapter
        '
        Me.ProductoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DetalleFolioTableAdapter = Nothing
        Me.TableAdapterManager.PersonalTableAdapter = Nothing
        Me.TableAdapterManager.ProduccionTableAdapter = Nothing
        Me.TableAdapterManager.ProductoresTableAdapter = Me.ProductoresTableAdapter
        Me.TableAdapterManager.SectoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SisRoquinProduce.RoquinDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BEliminar.Image = CType(resources.GetObject("BEliminar.Image"), System.Drawing.Image)
        Me.BEliminar.Location = New System.Drawing.Point(911, 528)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BEliminar.Size = New System.Drawing.Size(60, 60)
        Me.BEliminar.TabIndex = 27
        Me.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BCancelar.Image = CType(resources.GetObject("BCancelar.Image"), System.Drawing.Image)
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCancelar.Location = New System.Drawing.Point(217, 462)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BCancelar.Size = New System.Drawing.Size(150, 60)
        Me.BCancelar.TabIndex = 26
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), System.Drawing.Image)
        Me.BGuardar.Location = New System.Drawing.Point(140, 462)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BGuardar.Size = New System.Drawing.Size(60, 60)
        Me.BGuardar.TabIndex = 25
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'BNuevo
        '
        Me.BNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BNuevo.Image = CType(resources.GetObject("BNuevo.Image"), System.Drawing.Image)
        Me.BNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BNuevo.Location = New System.Drawing.Point(60, 462)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BNuevo.Size = New System.Drawing.Size(140, 60)
        Me.BNuevo.TabIndex = 24
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BNuevo.UseVisualStyleBackColor = False
        '
        'BEditar
        '
        Me.BEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BEditar.Image = CType(resources.GetObject("BEditar.Image"), System.Drawing.Image)
        Me.BEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEditar.Location = New System.Drawing.Point(217, 462)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BEditar.Size = New System.Drawing.Size(150, 60)
        Me.BEditar.TabIndex = 28
        Me.BEditar.Text = "Editar"
        Me.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEditar.UseVisualStyleBackColor = False
        '
        'BBuscar
        '
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BBuscar.Location = New System.Drawing.Point(861, 204)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(110, 40)
        Me.BBuscar.TabIndex = 84
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TextBoxBuscar.Location = New System.Drawing.Point(694, 206)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(160, 34)
        Me.TextBoxBuscar.TabIndex = 83
        '
        'LabelListado
        '
        Me.LabelListado.AutoSize = True
        Me.LabelListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelListado.Location = New System.Drawing.Point(398, 208)
        Me.LabelListado.Name = "LabelListado"
        Me.LabelListado.Size = New System.Drawing.Size(284, 29)
        Me.LabelListado.TabIndex = 82
        Me.LabelListado.Text = "Listado de Productores"
        '
        'FProductores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(982, 603)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.LabelListado)
        Me.Controls.Add(Me.BEditar)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.ProductoresDataGridView)
        Me.Controls.Add(NumProductorLabel)
        Me.Controls.Add(Me.NumProductorTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Me.ProductoresBindingNavigator)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FProductores"
        Me.Text = "Administración de Productores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProductoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductoresBindingNavigator.ResumeLayout(False)
        Me.ProductoresBindingNavigator.PerformLayout()
        CType(Me.ProductoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelPersonal As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RoquinDBDataSet As RoquinDBDataSet
    Friend WithEvents ProductoresBindingSource As BindingSource
    Friend WithEvents ProductoresTableAdapter As RoquinDBDataSetTableAdapters.ProductoresTableAdapter
    Friend WithEvents TableAdapterManager As RoquinDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductoresBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents NumProductorTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents ProductoresDataGridView As DataGridView
    Friend WithEvents BEliminar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BNuevo As Button
    Friend WithEvents BEditar As Button
    Friend WithEvents BBuscar As Button
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents LabelListado As Label
    Friend WithEvents NumProductor As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
