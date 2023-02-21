<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FUsuarios
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
        Dim IdUserLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim NombreUserLabel As System.Windows.Forms.Label
        Dim NivelLabel As System.Windows.Forms.Label
        Dim ContrasenaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FUsuarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelPersonal = New System.Windows.Forms.Label()
        Me.RoquinDBDataSet = New SisRoquinProduce.RoquinDBDataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New SisRoquinProduce.RoquinDBDataSetTableAdapters.TableAdapterManager()
        Me.UsuariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IdUserTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.NombreUserTextBox = New System.Windows.Forms.TextBox()
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contrasena = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContrasenaTextBox = New System.Windows.Forms.TextBox()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.NivelComboBox = New System.Windows.Forms.ComboBox()
        Me.BEditar = New System.Windows.Forms.Button()
        IdUserLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        NombreUserLabel = New System.Windows.Forms.Label()
        NivelLabel = New System.Windows.Forms.Label()
        ContrasenaLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsuariosBindingNavigator.SuspendLayout()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdUserLabel
        '
        IdUserLabel.AutoSize = True
        IdUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        IdUserLabel.Location = New System.Drawing.Point(40, 255)
        IdUserLabel.Name = "IdUserLabel"
        IdUserLabel.Size = New System.Drawing.Size(128, 29)
        IdUserLabel.TabIndex = 15
        IdUserLabel.Text = "Id Usuario:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        UsuarioLabel.Location = New System.Drawing.Point(66, 305)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(102, 29)
        UsuarioLabel.TabIndex = 17
        UsuarioLabel.Text = "Usuario:"
        '
        'NombreUserLabel
        '
        NombreUserLabel.AutoSize = True
        NombreUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        NombreUserLabel.Location = New System.Drawing.Point(61, 355)
        NombreUserLabel.Name = "NombreUserLabel"
        NombreUserLabel.Size = New System.Drawing.Size(107, 29)
        NombreUserLabel.TabIndex = 19
        NombreUserLabel.Text = "Nombre:"
        '
        'NivelLabel
        '
        NivelLabel.AutoSize = True
        NivelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        NivelLabel.Location = New System.Drawing.Point(94, 458)
        NivelLabel.Name = "NivelLabel"
        NivelLabel.Size = New System.Drawing.Size(74, 29)
        NivelLabel.TabIndex = 23
        NivelLabel.Text = "Nivel:"
        '
        'ContrasenaLabel
        '
        ContrasenaLabel.AutoSize = True
        ContrasenaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        ContrasenaLabel.Location = New System.Drawing.Point(26, 405)
        ContrasenaLabel.Name = "ContrasenaLabel"
        ContrasenaLabel.Size = New System.Drawing.Size(142, 29)
        ContrasenaLabel.TabIndex = 24
        ContrasenaLabel.Text = "Contraseña:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LabelPersonal)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel1.Size = New System.Drawing.Size(980, 200)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SisRoquinProduce.My.Resources.Resources.back_roquin_icon
        Me.PictureBox1.Location = New System.Drawing.Point(50, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'LabelPersonal
        '
        Me.LabelPersonal.AutoSize = True
        Me.LabelPersonal.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPersonal.Location = New System.Drawing.Point(350, 80)
        Me.LabelPersonal.Name = "LabelPersonal"
        Me.LabelPersonal.Size = New System.Drawing.Size(416, 48)
        Me.LabelPersonal.TabIndex = 0
        Me.LabelPersonal.Text = "𝔸𝕕𝕞𝕚𝕟𝕚𝕤𝕥𝕣𝕒𝕣 𝕌𝕤𝕦𝕒𝕣𝕚𝕠𝕤"
        '
        'RoquinDBDataSet
        '
        Me.RoquinDBDataSet.DataSetName = "RoquinDBDataSet"
        Me.RoquinDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.RoquinDBDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DetalleFolioTableAdapter = Nothing
        Me.TableAdapterManager.PersonalTableAdapter = Nothing
        Me.TableAdapterManager.ProduccionTableAdapter = Nothing
        Me.TableAdapterManager.ProductoresTableAdapter = Nothing
        Me.TableAdapterManager.SectoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SisRoquinProduce.RoquinDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'UsuariosBindingNavigator
        '
        Me.UsuariosBindingNavigator.AddNewItem = Nothing
        Me.UsuariosBindingNavigator.BindingSource = Me.UsuariosBindingSource
        Me.UsuariosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsuariosBindingNavigator.DeleteItem = Nothing
        Me.UsuariosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UsuariosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.UsuariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.UsuariosBindingNavigator.Location = New System.Drawing.Point(0, 649)
        Me.UsuariosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsuariosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsuariosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsuariosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsuariosBindingNavigator.Name = "UsuariosBindingNavigator"
        Me.UsuariosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsuariosBindingNavigator.Size = New System.Drawing.Size(1000, 27)
        Me.UsuariosBindingNavigator.TabIndex = 15
        Me.UsuariosBindingNavigator.Text = "BindingNavigator1"
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
        'IdUserTextBox
        '
        Me.IdUserTextBox.BackColor = System.Drawing.Color.White
        Me.IdUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdUserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "IdUser", True))
        Me.IdUserTextBox.Enabled = False
        Me.IdUserTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.IdUserTextBox.Location = New System.Drawing.Point(187, 255)
        Me.IdUserTextBox.Name = "IdUserTextBox"
        Me.IdUserTextBox.ReadOnly = True
        Me.IdUserTextBox.Size = New System.Drawing.Size(100, 34)
        Me.IdUserTextBox.TabIndex = 16
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.BackColor = System.Drawing.Color.White
        Me.UsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.UsuarioTextBox.Location = New System.Drawing.Point(187, 305)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(117, 34)
        Me.UsuarioTextBox.TabIndex = 18
        '
        'NombreUserTextBox
        '
        Me.NombreUserTextBox.BackColor = System.Drawing.Color.White
        Me.NombreUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreUserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "NombreUser", True))
        Me.NombreUserTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.NombreUserTextBox.Location = New System.Drawing.Point(187, 355)
        Me.NombreUserTextBox.Name = "NombreUserTextBox"
        Me.NombreUserTextBox.Size = New System.Drawing.Size(151, 34)
        Me.NombreUserTextBox.TabIndex = 20
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.AllowUserToAddRows = False
        Me.UsuariosDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UsuariosDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.UsuariosDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuariosDataGridView.AutoGenerateColumns = False
        Me.UsuariosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UsuariosDataGridView.BackgroundColor = System.Drawing.Color.LightGreen
        Me.UsuariosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UsuariosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UsuariosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Contrasena, Me.DataGridViewTextBoxColumn5})
        Me.UsuariosDataGridView.DataSource = Me.UsuariosBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UsuariosDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.UsuariosDataGridView.EnableHeadersVisualStyles = False
        Me.UsuariosDataGridView.GridColor = System.Drawing.Color.Black
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(410, 225)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UsuariosDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.UsuariosDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UsuariosDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.UsuariosDataGridView.RowTemplate.Height = 24
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(560, 338)
        Me.UsuariosDataGridView.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdUser"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Usuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Usuario"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NombreUser"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Contrasena
        '
        Me.Contrasena.DataPropertyName = "Contrasena"
        Me.Contrasena.HeaderText = "Contraseña"
        Me.Contrasena.Name = "Contrasena"
        Me.Contrasena.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nivel"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nivel"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'ContrasenaTextBox
        '
        Me.ContrasenaTextBox.BackColor = System.Drawing.Color.White
        Me.ContrasenaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContrasenaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Contrasena", True))
        Me.ContrasenaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ContrasenaTextBox.Location = New System.Drawing.Point(187, 405)
        Me.ContrasenaTextBox.Name = "ContrasenaTextBox"
        Me.ContrasenaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ContrasenaTextBox.Size = New System.Drawing.Size(128, 34)
        Me.ContrasenaTextBox.TabIndex = 25
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BEliminar.Image = CType(resources.GetObject("BEliminar.Image"), System.Drawing.Image)
        Me.BEliminar.Location = New System.Drawing.Point(897, 569)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BEliminar.Size = New System.Drawing.Size(60, 60)
        Me.BEliminar.TabIndex = 29
        Me.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BCancelar.Image = CType(resources.GetObject("BCancelar.Image"), System.Drawing.Image)
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCancelar.Location = New System.Drawing.Point(126, 525)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BCancelar.Size = New System.Drawing.Size(150, 60)
        Me.BCancelar.TabIndex = 28
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
        Me.BGuardar.Location = New System.Drawing.Point(831, 569)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BGuardar.Size = New System.Drawing.Size(60, 60)
        Me.BGuardar.TabIndex = 27
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'BNuevo
        '
        Me.BNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BNuevo.Image = CType(resources.GetObject("BNuevo.Image"), System.Drawing.Image)
        Me.BNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BNuevo.Location = New System.Drawing.Point(55, 525)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BNuevo.Size = New System.Drawing.Size(140, 60)
        Me.BNuevo.TabIndex = 26
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BNuevo.UseVisualStyleBackColor = False
        '
        'NivelComboBox
        '
        Me.NivelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Nivel", True))
        Me.NivelComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.NivelComboBox.FormattingEnabled = True
        Me.NivelComboBox.Items.AddRange(New Object() {"01", "02", "03", "04"})
        Me.NivelComboBox.Location = New System.Drawing.Point(187, 455)
        Me.NivelComboBox.Name = "NivelComboBox"
        Me.NivelComboBox.Size = New System.Drawing.Size(200, 37)
        Me.NivelComboBox.TabIndex = 30
        '
        'BEditar
        '
        Me.BEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BEditar.Image = CType(resources.GetObject("BEditar.Image"), System.Drawing.Image)
        Me.BEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEditar.Location = New System.Drawing.Point(199, 525)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BEditar.Size = New System.Drawing.Size(150, 60)
        Me.BEditar.TabIndex = 31
        Me.BEditar.Text = "Editar"
        Me.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEditar.UseVisualStyleBackColor = False
        '
        'FUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1000, 676)
        Me.Controls.Add(Me.BEditar)
        Me.Controls.Add(Me.NivelComboBox)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(ContrasenaLabel)
        Me.Controls.Add(Me.ContrasenaTextBox)
        Me.Controls.Add(Me.UsuariosDataGridView)
        Me.Controls.Add(IdUserLabel)
        Me.Controls.Add(Me.IdUserTextBox)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(NombreUserLabel)
        Me.Controls.Add(Me.NombreUserTextBox)
        Me.Controls.Add(NivelLabel)
        Me.Controls.Add(Me.UsuariosBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FUsuarios"
        Me.Text = "Administración de Usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsuariosBindingNavigator.ResumeLayout(False)
        Me.UsuariosBindingNavigator.PerformLayout()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelPersonal As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RoquinDBDataSet As RoquinDBDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As RoquinDBDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As RoquinDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuariosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents IdUserTextBox As TextBox
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents NombreUserTextBox As TextBox
    Friend WithEvents UsuariosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ContrasenaTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Contrasena As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents BEliminar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BNuevo As Button
    Friend WithEvents NivelComboBox As ComboBox
    Friend WithEvents BEditar As Button
End Class
