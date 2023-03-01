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
        Dim IdProductorLabel As System.Windows.Forms.Label
        Dim NumProductorLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FProductores))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.IdProductorTextBox = New System.Windows.Forms.TextBox()
        Me.NumProductorTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.ProductoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        IdProductorLabel = New System.Windows.Forms.Label()
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
        'IdProductorLabel
        '
        IdProductorLabel.AutoSize = True
        IdProductorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        IdProductorLabel.Location = New System.Drawing.Point(38, 253)
        IdProductorLabel.Name = "IdProductorLabel"
        IdProductorLabel.Size = New System.Drawing.Size(150, 29)
        IdProductorLabel.TabIndex = 16
        IdProductorLabel.Text = "Id Productor:"
        '
        'NumProductorLabel
        '
        NumProductorLabel.AutoSize = True
        NumProductorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        NumProductorLabel.Location = New System.Drawing.Point(7, 303)
        NumProductorLabel.Name = "NumProductorLabel"
        NumProductorLabel.Size = New System.Drawing.Size(181, 29)
        NumProductorLabel.TabIndex = 18
        NumProductorLabel.Text = "Num Productor:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        NombreLabel.Location = New System.Drawing.Point(81, 353)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(107, 29)
        NombreLabel.TabIndex = 20
        NombreLabel.Text = "Nombre:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        TelefonoLabel.Location = New System.Drawing.Point(72, 403)
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
        'IdProductorTextBox
        '
        Me.IdProductorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdProductorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoresBindingSource, "IdProductor", True))
        Me.IdProductorTextBox.Enabled = False
        Me.IdProductorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.IdProductorTextBox.Location = New System.Drawing.Point(198, 253)
        Me.IdProductorTextBox.Name = "IdProductorTextBox"
        Me.IdProductorTextBox.ReadOnly = True
        Me.IdProductorTextBox.Size = New System.Drawing.Size(100, 34)
        Me.IdProductorTextBox.TabIndex = 17
        '
        'NumProductorTextBox
        '
        Me.NumProductorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumProductorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoresBindingSource, "NumProductor", True))
        Me.NumProductorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.NumProductorTextBox.Location = New System.Drawing.Point(198, 303)
        Me.NumProductorTextBox.MaxLength = 3
        Me.NumProductorTextBox.Name = "NumProductorTextBox"
        Me.NumProductorTextBox.Size = New System.Drawing.Size(100, 34)
        Me.NumProductorTextBox.TabIndex = 19
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoresBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.NombreTextBox.Location = New System.Drawing.Point(198, 353)
        Me.NombreTextBox.MaxLength = 255
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(195, 34)
        Me.NombreTextBox.TabIndex = 21
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoresBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TelefonoTextBox.Location = New System.Drawing.Point(198, 403)
        Me.TelefonoTextBox.MaxLength = 10
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(138, 34)
        Me.TelefonoTextBox.TabIndex = 23
        '
        'ProductoresDataGridView
        '
        Me.ProductoresDataGridView.AllowUserToAddRows = False
        Me.ProductoresDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ProductoresDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ProductoresDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductoresDataGridView.AutoGenerateColumns = False
        Me.ProductoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductoresDataGridView.BackgroundColor = System.Drawing.Color.LightGreen
        Me.ProductoresDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProductoresDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductoresDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ProductoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ProductoresDataGridView.DataSource = Me.ProductoresBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductoresDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ProductoresDataGridView.GridColor = System.Drawing.Color.Black
        Me.ProductoresDataGridView.Location = New System.Drawing.Point(410, 208)
        Me.ProductoresDataGridView.Name = "ProductoresDataGridView"
        Me.ProductoresDataGridView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductoresDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ProductoresDataGridView.RowHeadersVisible = False
        Me.ProductoresDataGridView.RowTemplate.Height = 24
        Me.ProductoresDataGridView.Size = New System.Drawing.Size(560, 314)
        Me.ProductoresDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdProductor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Productor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NumProductor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Num Productor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
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
        Me.BEliminar.Location = New System.Drawing.Point(894, 528)
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
        Me.BCancelar.Location = New System.Drawing.Point(160, 462)
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
        Me.BGuardar.Location = New System.Drawing.Point(828, 528)
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
        Me.BNuevo.Location = New System.Drawing.Point(86, 462)
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
        Me.BEditar.Location = New System.Drawing.Point(243, 462)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BEditar.Size = New System.Drawing.Size(150, 60)
        Me.BEditar.TabIndex = 28
        Me.BEditar.Text = "Editar"
        Me.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEditar.UseVisualStyleBackColor = False
        '
        'FProductores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(982, 603)
        Me.Controls.Add(Me.BEditar)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.ProductoresDataGridView)
        Me.Controls.Add(IdProductorLabel)
        Me.Controls.Add(Me.IdProductorTextBox)
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
    Friend WithEvents IdProductorTextBox As TextBox
    Friend WithEvents NumProductorTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents ProductoresDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents BEliminar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BNuevo As Button
    Friend WithEvents BEditar As Button
End Class
