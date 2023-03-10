<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPersonal
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
        Dim IdPersonalLabel As System.Windows.Forms.Label
        Dim NumEmpleadoLabel As System.Windows.Forms.Label
        Dim NombreEmpleadoLabel As System.Windows.Forms.Label
        Dim ApellidosEmpLabel As System.Windows.Forms.Label
        Dim PuestoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPersonal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RoquinDBDataSet = New SisRoquinProduce.RoquinDBDataSet()
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonalTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.PersonalTableAdapter()
        Me.TableAdapterManager = New SisRoquinProduce.RoquinDBDataSetTableAdapters.TableAdapterManager()
        Me.PersonalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IdPersonalTextBox = New System.Windows.Forms.TextBox()
        Me.NumEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosEmpTextBox = New System.Windows.Forms.TextBox()
        Me.PuestoTextBox = New System.Windows.Forms.TextBox()
        Me.PersonalDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelPersonal = New System.Windows.Forms.Label()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.LabelListado = New System.Windows.Forms.Label()
        IdPersonalLabel = New System.Windows.Forms.Label()
        NumEmpleadoLabel = New System.Windows.Forms.Label()
        NombreEmpleadoLabel = New System.Windows.Forms.Label()
        ApellidosEmpLabel = New System.Windows.Forms.Label()
        PuestoLabel = New System.Windows.Forms.Label()
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PersonalBindingNavigator.SuspendLayout()
        CType(Me.PersonalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdPersonalLabel
        '
        IdPersonalLabel.AutoSize = True
        IdPersonalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        IdPersonalLabel.Location = New System.Drawing.Point(68, 270)
        IdPersonalLabel.Name = "IdPersonalLabel"
        IdPersonalLabel.Size = New System.Drawing.Size(141, 29)
        IdPersonalLabel.TabIndex = 1
        IdPersonalLabel.Text = "Id Personal:"
        '
        'NumEmpleadoLabel
        '
        NumEmpleadoLabel.AutoSize = True
        NumEmpleadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        NumEmpleadoLabel.Location = New System.Drawing.Point(22, 320)
        NumEmpleadoLabel.Name = "NumEmpleadoLabel"
        NumEmpleadoLabel.Size = New System.Drawing.Size(187, 29)
        NumEmpleadoLabel.TabIndex = 3
        NumEmpleadoLabel.Text = "Num Empleado:"
        '
        'NombreEmpleadoLabel
        '
        NombreEmpleadoLabel.AutoSize = True
        NombreEmpleadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        NombreEmpleadoLabel.Location = New System.Drawing.Point(102, 370)
        NombreEmpleadoLabel.Name = "NombreEmpleadoLabel"
        NombreEmpleadoLabel.Size = New System.Drawing.Size(107, 29)
        NombreEmpleadoLabel.TabIndex = 5
        NombreEmpleadoLabel.Text = "Nombre:"
        '
        'ApellidosEmpLabel
        '
        ApellidosEmpLabel.AutoSize = True
        ApellidosEmpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        ApellidosEmpLabel.Location = New System.Drawing.Point(89, 420)
        ApellidosEmpLabel.Name = "ApellidosEmpLabel"
        ApellidosEmpLabel.Size = New System.Drawing.Size(120, 29)
        ApellidosEmpLabel.TabIndex = 7
        ApellidosEmpLabel.Text = "Apellidos:"
        '
        'PuestoLabel
        '
        PuestoLabel.AutoSize = True
        PuestoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        PuestoLabel.Location = New System.Drawing.Point(115, 470)
        PuestoLabel.Name = "PuestoLabel"
        PuestoLabel.Size = New System.Drawing.Size(94, 29)
        PuestoLabel.TabIndex = 9
        PuestoLabel.Text = "Puesto:"
        '
        'RoquinDBDataSet
        '
        Me.RoquinDBDataSet.DataSetName = "RoquinDBDataSet"
        Me.RoquinDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonalBindingSource
        '
        Me.PersonalBindingSource.DataMember = "Personal"
        Me.PersonalBindingSource.DataSource = Me.RoquinDBDataSet
        '
        'PersonalTableAdapter
        '
        Me.PersonalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DetalleFolioTableAdapter = Nothing
        Me.TableAdapterManager.PersonalTableAdapter = Me.PersonalTableAdapter
        Me.TableAdapterManager.ProduccionTableAdapter = Nothing
        Me.TableAdapterManager.ProductoresTableAdapter = Nothing
        Me.TableAdapterManager.SectoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SisRoquinProduce.RoquinDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'PersonalBindingNavigator
        '
        Me.PersonalBindingNavigator.AddNewItem = Nothing
        Me.PersonalBindingNavigator.BindingSource = Me.PersonalBindingSource
        Me.PersonalBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PersonalBindingNavigator.DeleteItem = Nothing
        Me.PersonalBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PersonalBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PersonalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.PersonalBindingNavigator.Location = New System.Drawing.Point(0, 626)
        Me.PersonalBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PersonalBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PersonalBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PersonalBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PersonalBindingNavigator.Name = "PersonalBindingNavigator"
        Me.PersonalBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PersonalBindingNavigator.Size = New System.Drawing.Size(982, 27)
        Me.PersonalBindingNavigator.TabIndex = 0
        Me.PersonalBindingNavigator.Text = "BindingNavigator1"
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
        'IdPersonalTextBox
        '
        Me.IdPersonalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdPersonalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "IdPersonal", True))
        Me.IdPersonalTextBox.Enabled = False
        Me.IdPersonalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.IdPersonalTextBox.Location = New System.Drawing.Point(227, 270)
        Me.IdPersonalTextBox.Name = "IdPersonalTextBox"
        Me.IdPersonalTextBox.ReadOnly = True
        Me.IdPersonalTextBox.Size = New System.Drawing.Size(100, 34)
        Me.IdPersonalTextBox.TabIndex = 2
        '
        'NumEmpleadoTextBox
        '
        Me.NumEmpleadoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "NumEmpleado", True))
        Me.NumEmpleadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.NumEmpleadoTextBox.Location = New System.Drawing.Point(227, 320)
        Me.NumEmpleadoTextBox.MaxLength = 20
        Me.NumEmpleadoTextBox.Name = "NumEmpleadoTextBox"
        Me.NumEmpleadoTextBox.Size = New System.Drawing.Size(100, 34)
        Me.NumEmpleadoTextBox.TabIndex = 4
        '
        'NombreEmpleadoTextBox
        '
        Me.NombreEmpleadoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "NombreEmpleado", True))
        Me.NombreEmpleadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.NombreEmpleadoTextBox.Location = New System.Drawing.Point(227, 370)
        Me.NombreEmpleadoTextBox.MaxLength = 50
        Me.NombreEmpleadoTextBox.Name = "NombreEmpleadoTextBox"
        Me.NombreEmpleadoTextBox.Size = New System.Drawing.Size(150, 34)
        Me.NombreEmpleadoTextBox.TabIndex = 6
        '
        'ApellidosEmpTextBox
        '
        Me.ApellidosEmpTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApellidosEmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "ApellidosEmp", True))
        Me.ApellidosEmpTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ApellidosEmpTextBox.Location = New System.Drawing.Point(227, 420)
        Me.ApellidosEmpTextBox.MaxLength = 100
        Me.ApellidosEmpTextBox.Name = "ApellidosEmpTextBox"
        Me.ApellidosEmpTextBox.Size = New System.Drawing.Size(150, 34)
        Me.ApellidosEmpTextBox.TabIndex = 8
        '
        'PuestoTextBox
        '
        Me.PuestoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "Puesto", True))
        Me.PuestoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.PuestoTextBox.Location = New System.Drawing.Point(227, 470)
        Me.PuestoTextBox.MaxLength = 100
        Me.PuestoTextBox.Name = "PuestoTextBox"
        Me.PuestoTextBox.Size = New System.Drawing.Size(150, 34)
        Me.PuestoTextBox.TabIndex = 10
        '
        'PersonalDataGridView
        '
        Me.PersonalDataGridView.AllowUserToAddRows = False
        Me.PersonalDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PersonalDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PersonalDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersonalDataGridView.AutoGenerateColumns = False
        Me.PersonalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PersonalDataGridView.BackgroundColor = System.Drawing.Color.LightGreen
        Me.PersonalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PersonalDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonalDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PersonalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PersonalDataGridView.DataSource = Me.PersonalBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PersonalDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.PersonalDataGridView.GridColor = System.Drawing.Color.Black
        Me.PersonalDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PersonalDataGridView.Location = New System.Drawing.Point(410, 253)
        Me.PersonalDataGridView.Name = "PersonalDataGridView"
        Me.PersonalDataGridView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonalDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.PersonalDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PersonalDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.PersonalDataGridView.RowTemplate.Height = 24
        Me.PersonalDataGridView.Size = New System.Drawing.Size(560, 314)
        Me.PersonalDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdPersonal"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Personal"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NumEmpleado"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Num Empleado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NombreEmpleado"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ApellidosEmp"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Puesto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Puesto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
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
        Me.Panel1.TabIndex = 13
        '
        'LabelPersonal
        '
        Me.LabelPersonal.AutoSize = True
        Me.LabelPersonal.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPersonal.Location = New System.Drawing.Point(350, 80)
        Me.LabelPersonal.Name = "LabelPersonal"
        Me.LabelPersonal.Size = New System.Drawing.Size(415, 48)
        Me.LabelPersonal.TabIndex = 0
        Me.LabelPersonal.Text = "𝔸𝕕𝕞𝕚𝕟𝕚𝕤𝕥𝕣𝕒𝕣 ℙ𝕖𝕣𝕤𝕠𝕟𝕒𝕝"
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BEliminar.Image = CType(resources.GetObject("BEliminar.Image"), System.Drawing.Image)
        Me.BEliminar.Location = New System.Drawing.Point(910, 573)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BEliminar.Size = New System.Drawing.Size(60, 60)
        Me.BEliminar.TabIndex = 17
        Me.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BCancelar.Image = CType(resources.GetObject("BCancelar.Image"), System.Drawing.Image)
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCancelar.Location = New System.Drawing.Point(139, 529)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BCancelar.Size = New System.Drawing.Size(150, 60)
        Me.BCancelar.TabIndex = 16
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
        Me.BGuardar.Location = New System.Drawing.Point(844, 573)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BGuardar.Size = New System.Drawing.Size(60, 60)
        Me.BGuardar.TabIndex = 15
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'BNuevo
        '
        Me.BNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BNuevo.Image = CType(resources.GetObject("BNuevo.Image"), System.Drawing.Image)
        Me.BNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BNuevo.Location = New System.Drawing.Point(68, 529)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BNuevo.Size = New System.Drawing.Size(140, 60)
        Me.BNuevo.TabIndex = 14
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BNuevo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGreen
        Me.PictureBox1.Image = Global.SisRoquinProduce.My.Resources.Resources.Roquin_logo6
        Me.PictureBox1.Location = New System.Drawing.Point(50, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'BEditar
        '
        Me.BEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BEditar.Image = CType(resources.GetObject("BEditar.Image"), System.Drawing.Image)
        Me.BEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEditar.Location = New System.Drawing.Point(225, 530)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BEditar.Size = New System.Drawing.Size(150, 60)
        Me.BEditar.TabIndex = 18
        Me.BEditar.Text = "Editar"
        Me.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEditar.UseVisualStyleBackColor = False
        '
        'BBuscar
        '
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BBuscar.Location = New System.Drawing.Point(860, 208)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(110, 40)
        Me.BBuscar.TabIndex = 81
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TextBoxBuscar.Location = New System.Drawing.Point(696, 210)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(160, 34)
        Me.TextBoxBuscar.TabIndex = 80
        '
        'LabelListado
        '
        Me.LabelListado.AutoSize = True
        Me.LabelListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelListado.Location = New System.Drawing.Point(405, 212)
        Me.LabelListado.Name = "LabelListado"
        Me.LabelListado.Size = New System.Drawing.Size(246, 29)
        Me.LabelListado.TabIndex = 79
        Me.LabelListado.Text = "Listado de Personal"
        '
        'FPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.LabelListado)
        Me.Controls.Add(Me.BEditar)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PersonalDataGridView)
        Me.Controls.Add(IdPersonalLabel)
        Me.Controls.Add(Me.IdPersonalTextBox)
        Me.Controls.Add(NumEmpleadoLabel)
        Me.Controls.Add(Me.NumEmpleadoTextBox)
        Me.Controls.Add(NombreEmpleadoLabel)
        Me.Controls.Add(Me.NombreEmpleadoTextBox)
        Me.Controls.Add(ApellidosEmpLabel)
        Me.Controls.Add(Me.ApellidosEmpTextBox)
        Me.Controls.Add(PuestoLabel)
        Me.Controls.Add(Me.PuestoTextBox)
        Me.Controls.Add(Me.PersonalBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FPersonal"
        Me.Text = "Administración de Personal"
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PersonalBindingNavigator.ResumeLayout(False)
        Me.PersonalBindingNavigator.PerformLayout()
        CType(Me.PersonalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RoquinDBDataSet As RoquinDBDataSet
    Friend WithEvents PersonalBindingSource As BindingSource
    Friend WithEvents PersonalTableAdapter As RoquinDBDataSetTableAdapters.PersonalTableAdapter
    Friend WithEvents TableAdapterManager As RoquinDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PersonalBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents IdPersonalTextBox As TextBox
    Friend WithEvents NumEmpleadoTextBox As TextBox
    Friend WithEvents NombreEmpleadoTextBox As TextBox
    Friend WithEvents ApellidosEmpTextBox As TextBox
    Friend WithEvents PuestoTextBox As TextBox
    Friend WithEvents PersonalDataGridView As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelPersonal As Label
    Friend WithEvents BNuevo As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BEditar As Button
    Friend WithEvents BBuscar As Button
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents LabelListado As Label
End Class
