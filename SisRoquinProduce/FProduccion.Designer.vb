<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FProduccion
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
        Dim FolioLabel As System.Windows.Forms.Label
        Dim FechaProdLabel As System.Windows.Forms.Label
        Dim NumProdLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim HuertoLabel As System.Windows.Forms.Label
        Dim TemporadaLabel As System.Windows.Forms.Label
        Dim CajasLabel As System.Windows.Forms.Label
        Dim KilosLabel As System.Windows.Forms.Label
        Dim NumSectorLabel As System.Windows.Forms.Label
        Dim KGCampoLabel As System.Windows.Forms.Label
        Dim GaleraLabel As System.Windows.Forms.Label
        Dim ClamshellLabel As System.Windows.Forms.Label
        Dim CubetasSinEmpLabel As System.Windows.Forms.Label
        Dim DiasCorteLabel As System.Windows.Forms.Label
        Dim DefectoLabel As System.Windows.Forms.Label
        Dim TotCubetasLabel As System.Windows.Forms.Label
        Dim CortesiasLabel As System.Windows.Forms.Label
        Dim EncargadoLabel As System.Windows.Forms.Label
        Dim EmbalajeLabel As System.Windows.Forms.Label
        Dim VariedadLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FProduccion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelPersonal = New System.Windows.Forms.Label()
        Me.FolioTextBox = New System.Windows.Forms.TextBox()
        Me.ProduccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoquinDBDataSet = New SisRoquinProduce.RoquinDBDataSet()
        Me.FechaProdDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NumProdTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.HuertoTextBox = New System.Windows.Forms.TextBox()
        Me.TemporadaTextBox = New System.Windows.Forms.TextBox()
        Me.CajasTextBox = New System.Windows.Forms.TextBox()
        Me.KilosTextBox = New System.Windows.Forms.TextBox()
        Me.NumSectorTextBox = New System.Windows.Forms.TextBox()
        Me.KGCampoTextBox = New System.Windows.Forms.TextBox()
        Me.GaleraTextBox = New System.Windows.Forms.TextBox()
        Me.ClamshellTextBox = New System.Windows.Forms.TextBox()
        Me.CubetasSinEmpTextBox = New System.Windows.Forms.TextBox()
        Me.DiasCorteTextBox = New System.Windows.Forms.TextBox()
        Me.DefectoTextBox = New System.Windows.Forms.TextBox()
        Me.TotCubetasTextBox = New System.Windows.Forms.TextBox()
        Me.CortesiasTextBox = New System.Windows.Forms.TextBox()
        Me.EncargadoTextBox = New System.Windows.Forms.TextBox()
        Me.ProduccionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProduccionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.EmbalajeComboBox = New System.Windows.Forms.ComboBox()
        Me.VariedadComboBox = New System.Windows.Forms.ComboBox()
        Me.ProduccionTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.ProduccionTableAdapter()
        Me.TableAdapterManager = New SisRoquinProduce.RoquinDBDataSetTableAdapters.TableAdapterManager()
        Me.ProductoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoresTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.ProductoresTableAdapter()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultDetallePersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultDetallePersonalTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.ConsultDetallePersonalTableAdapter()
        Me.ConsultDetallePersonalDataGridView = New System.Windows.Forms.DataGridView()
        Me.NumEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectoresTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.SectoresTableAdapter()
        Me.SectoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreSecComboBox = New System.Windows.Forms.ComboBox()
        Me.DataGridDetalle = New System.Windows.Forms.DataGridView()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kilos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gramos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cubetas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BEditar = New System.Windows.Forms.Button()
        FolioLabel = New System.Windows.Forms.Label()
        FechaProdLabel = New System.Windows.Forms.Label()
        NumProdLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        HuertoLabel = New System.Windows.Forms.Label()
        TemporadaLabel = New System.Windows.Forms.Label()
        CajasLabel = New System.Windows.Forms.Label()
        KilosLabel = New System.Windows.Forms.Label()
        NumSectorLabel = New System.Windows.Forms.Label()
        KGCampoLabel = New System.Windows.Forms.Label()
        GaleraLabel = New System.Windows.Forms.Label()
        ClamshellLabel = New System.Windows.Forms.Label()
        CubetasSinEmpLabel = New System.Windows.Forms.Label()
        DiasCorteLabel = New System.Windows.Forms.Label()
        DefectoLabel = New System.Windows.Forms.Label()
        TotCubetasLabel = New System.Windows.Forms.Label()
        CortesiasLabel = New System.Windows.Forms.Label()
        EncargadoLabel = New System.Windows.Forms.Label()
        EmbalajeLabel = New System.Windows.Forms.Label()
        VariedadLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProduccionBindingNavigator.SuspendLayout()
        CType(Me.ProductoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultDetallePersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultDetallePersonalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FolioLabel
        '
        FolioLabel.AutoSize = True
        FolioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        FolioLabel.Location = New System.Drawing.Point(138, 227)
        FolioLabel.Name = "FolioLabel"
        FolioLabel.Size = New System.Drawing.Size(74, 29)
        FolioLabel.TabIndex = 17
        FolioLabel.Text = "Folio:"
        '
        'FechaProdLabel
        '
        FechaProdLabel.AutoSize = True
        FechaProdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        FechaProdLabel.Location = New System.Drawing.Point(126, 277)
        FechaProdLabel.Name = "FechaProdLabel"
        FechaProdLabel.Size = New System.Drawing.Size(86, 29)
        FechaProdLabel.TabIndex = 19
        FechaProdLabel.Text = "Fecha:"
        '
        'NumProdLabel
        '
        NumProdLabel.AutoSize = True
        NumProdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        NumProdLabel.Location = New System.Drawing.Point(88, 326)
        NumProdLabel.Name = "NumProdLabel"
        NumProdLabel.Size = New System.Drawing.Size(124, 29)
        NumProdLabel.TabIndex = 21
        NumProdLabel.Text = "Productor:"
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        CodigoLabel.Location = New System.Drawing.Point(114, 377)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(98, 29)
        CodigoLabel.TabIndex = 23
        CodigoLabel.Text = "Código:"
        '
        'HuertoLabel
        '
        HuertoLabel.AutoSize = True
        HuertoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        HuertoLabel.Location = New System.Drawing.Point(121, 427)
        HuertoLabel.Name = "HuertoLabel"
        HuertoLabel.Size = New System.Drawing.Size(91, 29)
        HuertoLabel.TabIndex = 25
        HuertoLabel.Text = "Huerto:"
        '
        'TemporadaLabel
        '
        TemporadaLabel.AutoSize = True
        TemporadaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        TemporadaLabel.Location = New System.Drawing.Point(67, 477)
        TemporadaLabel.Name = "TemporadaLabel"
        TemporadaLabel.Size = New System.Drawing.Size(145, 29)
        TemporadaLabel.TabIndex = 27
        TemporadaLabel.Text = "Temporada:"
        '
        'CajasLabel
        '
        CajasLabel.AutoSize = True
        CajasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        CajasLabel.Location = New System.Drawing.Point(132, 527)
        CajasLabel.Name = "CajasLabel"
        CajasLabel.Size = New System.Drawing.Size(80, 29)
        CajasLabel.TabIndex = 29
        CajasLabel.Text = "Cajas:"
        '
        'KilosLabel
        '
        KilosLabel.AutoSize = True
        KilosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        KilosLabel.Location = New System.Drawing.Point(139, 577)
        KilosLabel.Name = "KilosLabel"
        KilosLabel.Size = New System.Drawing.Size(73, 29)
        KilosLabel.TabIndex = 31
        KilosLabel.Text = "Kilos:"
        '
        'NumSectorLabel
        '
        NumSectorLabel.AutoSize = True
        NumSectorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        NumSectorLabel.Location = New System.Drawing.Point(121, 627)
        NumSectorLabel.Name = "NumSectorLabel"
        NumSectorLabel.Size = New System.Drawing.Size(89, 29)
        NumSectorLabel.TabIndex = 33
        NumSectorLabel.Text = "Sector:"
        '
        'KGCampoLabel
        '
        KGCampoLabel.AutoSize = True
        KGCampoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        KGCampoLabel.Location = New System.Drawing.Point(553, 276)
        KGCampoLabel.Name = "KGCampoLabel"
        KGCampoLabel.Size = New System.Drawing.Size(137, 29)
        KGCampoLabel.TabIndex = 39
        KGCampoLabel.Text = "KG Campo:"
        '
        'GaleraLabel
        '
        GaleraLabel.AutoSize = True
        GaleraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        GaleraLabel.Location = New System.Drawing.Point(598, 326)
        GaleraLabel.Name = "GaleraLabel"
        GaleraLabel.Size = New System.Drawing.Size(91, 29)
        GaleraLabel.TabIndex = 41
        GaleraLabel.Text = "Galera:"
        '
        'ClamshellLabel
        '
        ClamshellLabel.AutoSize = True
        ClamshellLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        ClamshellLabel.Location = New System.Drawing.Point(563, 376)
        ClamshellLabel.Name = "ClamshellLabel"
        ClamshellLabel.Size = New System.Drawing.Size(126, 29)
        ClamshellLabel.TabIndex = 43
        ClamshellLabel.Text = "Clamshell:"
        '
        'CubetasSinEmpLabel
        '
        CubetasSinEmpLabel.AutoSize = True
        CubetasSinEmpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        CubetasSinEmpLabel.Location = New System.Drawing.Point(440, 426)
        CubetasSinEmpLabel.Name = "CubetasSinEmpLabel"
        CubetasSinEmpLabel.Size = New System.Drawing.Size(255, 33)
        CubetasSinEmpLabel.TabIndex = 45
        CubetasSinEmpLabel.Text = "Cubetas Sin Empaque:"
        CubetasSinEmpLabel.UseCompatibleTextRendering = True
        '
        'DiasCorteLabel
        '
        DiasCorteLabel.AutoSize = True
        DiasCorteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DiasCorteLabel.Location = New System.Drawing.Point(538, 476)
        DiasCorteLabel.Name = "DiasCorteLabel"
        DiasCorteLabel.Size = New System.Drawing.Size(151, 29)
        DiasCorteLabel.TabIndex = 47
        DiasCorteLabel.Text = "Días a Corte:"
        '
        'DefectoLabel
        '
        DefectoLabel.AutoSize = True
        DefectoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DefectoLabel.Location = New System.Drawing.Point(587, 526)
        DefectoLabel.Name = "DefectoLabel"
        DefectoLabel.Size = New System.Drawing.Size(102, 29)
        DefectoLabel.TabIndex = 49
        DefectoLabel.Text = "Defecto:"
        '
        'TotCubetasLabel
        '
        TotCubetasLabel.AutoSize = True
        TotCubetasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        TotCubetasLabel.Location = New System.Drawing.Point(520, 576)
        TotCubetasLabel.Name = "TotCubetasLabel"
        TotCubetasLabel.Size = New System.Drawing.Size(169, 29)
        TotCubetasLabel.TabIndex = 51
        TotCubetasLabel.Text = "Total Cubetas:"
        '
        'CortesiasLabel
        '
        CortesiasLabel.AutoSize = True
        CortesiasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        CortesiasLabel.Location = New System.Drawing.Point(568, 626)
        CortesiasLabel.Name = "CortesiasLabel"
        CortesiasLabel.Size = New System.Drawing.Size(121, 29)
        CortesiasLabel.TabIndex = 53
        CortesiasLabel.Text = "Cortesías:"
        '
        'EncargadoLabel
        '
        EncargadoLabel.AutoSize = True
        EncargadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        EncargadoLabel.Location = New System.Drawing.Point(553, 676)
        EncargadoLabel.Name = "EncargadoLabel"
        EncargadoLabel.Size = New System.Drawing.Size(136, 29)
        EncargadoLabel.TabIndex = 55
        EncargadoLabel.Text = "Encargado:"
        '
        'EmbalajeLabel
        '
        EmbalajeLabel.AutoSize = True
        EmbalajeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        EmbalajeLabel.Location = New System.Drawing.Point(92, 679)
        EmbalajeLabel.Name = "EmbalajeLabel"
        EmbalajeLabel.Size = New System.Drawing.Size(121, 29)
        EmbalajeLabel.TabIndex = 60
        EmbalajeLabel.Text = "Embalaje:"
        '
        'VariedadLabel
        '
        VariedadLabel.AutoSize = True
        VariedadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        VariedadLabel.Location = New System.Drawing.Point(574, 228)
        VariedadLabel.Name = "VariedadLabel"
        VariedadLabel.Size = New System.Drawing.Size(116, 29)
        VariedadLabel.TabIndex = 61
        VariedadLabel.Text = "Variedad:"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LabelPersonal)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel1.Size = New System.Drawing.Size(1790, 200)
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
        Me.LabelPersonal.Size = New System.Drawing.Size(460, 48)
        Me.LabelPersonal.TabIndex = 0
        Me.LabelPersonal.Text = "𝔸𝕕𝕞𝕚𝕟𝕚𝕤𝕥𝕣𝕒𝕣 ℙ𝕣𝕠𝕕𝕦𝕔𝕔𝕚ó𝕟"
        '
        'FolioTextBox
        '
        Me.FolioTextBox.BackColor = System.Drawing.Color.White
        Me.FolioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FolioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Folio", True))
        Me.FolioTextBox.Enabled = False
        Me.FolioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.FolioTextBox.Location = New System.Drawing.Point(227, 227)
        Me.FolioTextBox.Name = "FolioTextBox"
        Me.FolioTextBox.ReadOnly = True
        Me.FolioTextBox.Size = New System.Drawing.Size(200, 34)
        Me.FolioTextBox.TabIndex = 18
        '
        'ProduccionBindingSource
        '
        Me.ProduccionBindingSource.DataMember = "Produccion"
        Me.ProduccionBindingSource.DataSource = Me.RoquinDBDataSet
        '
        'RoquinDBDataSet
        '
        Me.RoquinDBDataSet.DataSetName = "RoquinDBDataSet"
        Me.RoquinDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FechaProdDateTimePicker
        '
        Me.FechaProdDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProduccionBindingSource, "FechaProd", True))
        Me.FechaProdDateTimePicker.Enabled = False
        Me.FechaProdDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.FechaProdDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaProdDateTimePicker.Location = New System.Drawing.Point(227, 277)
        Me.FechaProdDateTimePicker.Name = "FechaProdDateTimePicker"
        Me.FechaProdDateTimePicker.Size = New System.Drawing.Size(200, 34)
        Me.FechaProdDateTimePicker.TabIndex = 20
        '
        'NumProdTextBox
        '
        Me.NumProdTextBox.BackColor = System.Drawing.Color.White
        Me.NumProdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "NumProd", True))
        Me.NumProdTextBox.Enabled = False
        Me.NumProdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.NumProdTextBox.Location = New System.Drawing.Point(227, 327)
        Me.NumProdTextBox.Name = "NumProdTextBox"
        Me.NumProdTextBox.Size = New System.Drawing.Size(100, 34)
        Me.NumProdTextBox.TabIndex = 22
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.BackColor = System.Drawing.Color.White
        Me.CodigoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Codigo", True))
        Me.CodigoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.CodigoTextBox.Location = New System.Drawing.Point(227, 377)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(200, 34)
        Me.CodigoTextBox.TabIndex = 24
        '
        'HuertoTextBox
        '
        Me.HuertoTextBox.BackColor = System.Drawing.Color.White
        Me.HuertoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HuertoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Huerto", True))
        Me.HuertoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.HuertoTextBox.Location = New System.Drawing.Point(227, 427)
        Me.HuertoTextBox.Name = "HuertoTextBox"
        Me.HuertoTextBox.Size = New System.Drawing.Size(200, 34)
        Me.HuertoTextBox.TabIndex = 26
        '
        'TemporadaTextBox
        '
        Me.TemporadaTextBox.BackColor = System.Drawing.Color.White
        Me.TemporadaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TemporadaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Temporada", True))
        Me.TemporadaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TemporadaTextBox.Location = New System.Drawing.Point(227, 477)
        Me.TemporadaTextBox.Name = "TemporadaTextBox"
        Me.TemporadaTextBox.Size = New System.Drawing.Size(200, 34)
        Me.TemporadaTextBox.TabIndex = 28
        '
        'CajasTextBox
        '
        Me.CajasTextBox.BackColor = System.Drawing.Color.White
        Me.CajasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CajasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Cajas", True))
        Me.CajasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.CajasTextBox.Location = New System.Drawing.Point(227, 527)
        Me.CajasTextBox.Name = "CajasTextBox"
        Me.CajasTextBox.Size = New System.Drawing.Size(200, 34)
        Me.CajasTextBox.TabIndex = 30
        '
        'KilosTextBox
        '
        Me.KilosTextBox.BackColor = System.Drawing.Color.White
        Me.KilosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KilosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Kilos", True))
        Me.KilosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.KilosTextBox.Location = New System.Drawing.Point(227, 577)
        Me.KilosTextBox.Name = "KilosTextBox"
        Me.KilosTextBox.Size = New System.Drawing.Size(200, 34)
        Me.KilosTextBox.TabIndex = 32
        '
        'NumSectorTextBox
        '
        Me.NumSectorTextBox.BackColor = System.Drawing.Color.White
        Me.NumSectorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumSectorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "NumSector", True))
        Me.NumSectorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.NumSectorTextBox.Location = New System.Drawing.Point(227, 627)
        Me.NumSectorTextBox.Name = "NumSectorTextBox"
        Me.NumSectorTextBox.Size = New System.Drawing.Size(100, 34)
        Me.NumSectorTextBox.TabIndex = 34
        '
        'KGCampoTextBox
        '
        Me.KGCampoTextBox.BackColor = System.Drawing.Color.White
        Me.KGCampoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KGCampoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "KGCampo", True))
        Me.KGCampoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.KGCampoTextBox.Location = New System.Drawing.Point(711, 276)
        Me.KGCampoTextBox.Name = "KGCampoTextBox"
        Me.KGCampoTextBox.Size = New System.Drawing.Size(200, 34)
        Me.KGCampoTextBox.TabIndex = 40
        '
        'GaleraTextBox
        '
        Me.GaleraTextBox.BackColor = System.Drawing.Color.White
        Me.GaleraTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GaleraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Galera", True))
        Me.GaleraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GaleraTextBox.Location = New System.Drawing.Point(711, 326)
        Me.GaleraTextBox.Name = "GaleraTextBox"
        Me.GaleraTextBox.Size = New System.Drawing.Size(200, 34)
        Me.GaleraTextBox.TabIndex = 42
        '
        'ClamshellTextBox
        '
        Me.ClamshellTextBox.BackColor = System.Drawing.Color.White
        Me.ClamshellTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClamshellTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Clamshell", True))
        Me.ClamshellTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ClamshellTextBox.Location = New System.Drawing.Point(711, 376)
        Me.ClamshellTextBox.Name = "ClamshellTextBox"
        Me.ClamshellTextBox.Size = New System.Drawing.Size(200, 34)
        Me.ClamshellTextBox.TabIndex = 44
        '
        'CubetasSinEmpTextBox
        '
        Me.CubetasSinEmpTextBox.BackColor = System.Drawing.Color.White
        Me.CubetasSinEmpTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CubetasSinEmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "CubetasSinEmp", True))
        Me.CubetasSinEmpTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.CubetasSinEmpTextBox.Location = New System.Drawing.Point(711, 426)
        Me.CubetasSinEmpTextBox.Name = "CubetasSinEmpTextBox"
        Me.CubetasSinEmpTextBox.Size = New System.Drawing.Size(200, 34)
        Me.CubetasSinEmpTextBox.TabIndex = 46
        '
        'DiasCorteTextBox
        '
        Me.DiasCorteTextBox.BackColor = System.Drawing.Color.White
        Me.DiasCorteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiasCorteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "DiasCorte", True))
        Me.DiasCorteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.DiasCorteTextBox.Location = New System.Drawing.Point(711, 476)
        Me.DiasCorteTextBox.Name = "DiasCorteTextBox"
        Me.DiasCorteTextBox.Size = New System.Drawing.Size(200, 34)
        Me.DiasCorteTextBox.TabIndex = 48
        '
        'DefectoTextBox
        '
        Me.DefectoTextBox.BackColor = System.Drawing.Color.White
        Me.DefectoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Defecto", True))
        Me.DefectoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.DefectoTextBox.Location = New System.Drawing.Point(711, 526)
        Me.DefectoTextBox.Name = "DefectoTextBox"
        Me.DefectoTextBox.Size = New System.Drawing.Size(200, 34)
        Me.DefectoTextBox.TabIndex = 50
        '
        'TotCubetasTextBox
        '
        Me.TotCubetasTextBox.BackColor = System.Drawing.Color.White
        Me.TotCubetasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotCubetasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "TotCubetas", True))
        Me.TotCubetasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TotCubetasTextBox.Location = New System.Drawing.Point(711, 576)
        Me.TotCubetasTextBox.Name = "TotCubetasTextBox"
        Me.TotCubetasTextBox.Size = New System.Drawing.Size(200, 34)
        Me.TotCubetasTextBox.TabIndex = 52
        '
        'CortesiasTextBox
        '
        Me.CortesiasTextBox.BackColor = System.Drawing.Color.White
        Me.CortesiasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CortesiasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Cortesias", True))
        Me.CortesiasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.CortesiasTextBox.Location = New System.Drawing.Point(711, 626)
        Me.CortesiasTextBox.Name = "CortesiasTextBox"
        Me.CortesiasTextBox.Size = New System.Drawing.Size(200, 34)
        Me.CortesiasTextBox.TabIndex = 54
        '
        'EncargadoTextBox
        '
        Me.EncargadoTextBox.BackColor = System.Drawing.Color.White
        Me.EncargadoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EncargadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Encargado", True))
        Me.EncargadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.EncargadoTextBox.Location = New System.Drawing.Point(711, 676)
        Me.EncargadoTextBox.Name = "EncargadoTextBox"
        Me.EncargadoTextBox.Size = New System.Drawing.Size(200, 34)
        Me.EncargadoTextBox.TabIndex = 56
        '
        'ProduccionDataGridView
        '
        Me.ProduccionDataGridView.AllowUserToAddRows = False
        Me.ProduccionDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ProduccionDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ProduccionDataGridView.AutoGenerateColumns = False
        Me.ProduccionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProduccionDataGridView.BackgroundColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProduccionDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ProduccionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProduccionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn21})
        Me.ProduccionDataGridView.DataSource = Me.ProduccionBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProduccionDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ProduccionDataGridView.GridColor = System.Drawing.Color.Black
        Me.ProduccionDataGridView.Location = New System.Drawing.Point(933, 206)
        Me.ProduccionDataGridView.Name = "ProduccionDataGridView"
        Me.ProduccionDataGridView.ReadOnly = True
        Me.ProduccionDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProduccionDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProduccionDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ProduccionDataGridView.RowHeadersVisible = False
        Me.ProduccionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ProduccionDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.ProduccionDataGridView.RowTemplate.Height = 24
        Me.ProduccionDataGridView.Size = New System.Drawing.Size(845, 149)
        Me.ProduccionDataGridView.TabIndex = 56
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Folio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FechaProd"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha Producción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Huerto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Huerto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Temporada"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Temporada"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Cajas"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cajas"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Kilos"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NumSector"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Número de Sector"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Clamshell"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Clamshell"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Encargado"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Encargado"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'ProduccionBindingNavigator
        '
        Me.ProduccionBindingNavigator.AddNewItem = Nothing
        Me.ProduccionBindingNavigator.BindingSource = Me.ProduccionBindingSource
        Me.ProduccionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProduccionBindingNavigator.DeleteItem = Nothing
        Me.ProduccionBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProduccionBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ProduccionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.ProduccionBindingNavigator.Location = New System.Drawing.Point(0, 826)
        Me.ProduccionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProduccionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProduccionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProduccionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProduccionBindingNavigator.Name = "ProduccionBindingNavigator"
        Me.ProduccionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProduccionBindingNavigator.Size = New System.Drawing.Size(1810, 27)
        Me.ProduccionBindingNavigator.TabIndex = 15
        Me.ProduccionBindingNavigator.Text = "BindingNavigator1"
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BEliminar.Image = CType(resources.GetObject("BEliminar.Image"), System.Drawing.Image)
        Me.BEliminar.Location = New System.Drawing.Point(1714, 742)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BEliminar.Size = New System.Drawing.Size(60, 60)
        Me.BEliminar.TabIndex = 60
        Me.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BCancelar.Image = CType(resources.GetObject("BCancelar.Image"), System.Drawing.Image)
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCancelar.Location = New System.Drawing.Point(669, 742)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BCancelar.Size = New System.Drawing.Size(150, 60)
        Me.BCancelar.TabIndex = 59
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
        Me.BGuardar.Location = New System.Drawing.Point(1689, 742)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BGuardar.Size = New System.Drawing.Size(60, 60)
        Me.BGuardar.TabIndex = 58
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'BNuevo
        '
        Me.BNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BNuevo.Image = CType(resources.GetObject("BNuevo.Image"), System.Drawing.Image)
        Me.BNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BNuevo.Location = New System.Drawing.Point(592, 742)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BNuevo.Size = New System.Drawing.Size(140, 60)
        Me.BNuevo.TabIndex = 57
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BNuevo.UseVisualStyleBackColor = False
        '
        'EmbalajeComboBox
        '
        Me.EmbalajeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Embalaje", True))
        Me.EmbalajeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.EmbalajeComboBox.FormattingEnabled = True
        Me.EmbalajeComboBox.Items.AddRange(New Object() {"4x4", "18oz", "6oz", "pinta"})
        Me.EmbalajeComboBox.Location = New System.Drawing.Point(227, 676)
        Me.EmbalajeComboBox.Name = "EmbalajeComboBox"
        Me.EmbalajeComboBox.Size = New System.Drawing.Size(200, 37)
        Me.EmbalajeComboBox.TabIndex = 61
        '
        'VariedadComboBox
        '
        Me.VariedadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Variedad", True))
        Me.VariedadComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.VariedadComboBox.FormattingEnabled = True
        Me.VariedadComboBox.Items.AddRange(New Object() {"Jupiter", "Atlas", "Biloxi"})
        Me.VariedadComboBox.Location = New System.Drawing.Point(711, 225)
        Me.VariedadComboBox.Name = "VariedadComboBox"
        Me.VariedadComboBox.Size = New System.Drawing.Size(200, 37)
        Me.VariedadComboBox.TabIndex = 62
        '
        'ProduccionTableAdapter
        '
        Me.ProduccionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DetalleFolioTableAdapter = Nothing
        Me.TableAdapterManager.PersonalTableAdapter = Nothing
        Me.TableAdapterManager.ProduccionTableAdapter = Me.ProduccionTableAdapter
        Me.TableAdapterManager.ProductoresTableAdapter = Nothing
        Me.TableAdapterManager.SectoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SisRoquinProduce.RoquinDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'ProductoresBindingSource
        '
        Me.ProductoresBindingSource.DataMember = "Produccion_Productores"
        Me.ProductoresBindingSource.DataSource = Me.ProduccionBindingSource
        '
        'ProductoresTableAdapter
        '
        Me.ProductoresTableAdapter.ClearBeforeFill = True
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoresBindingSource, "Nombre", True))
        Me.NombreComboBox.DataSource = Me.ProductoresBindingSource1
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(227, 326)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(200, 37)
        Me.NombreComboBox.TabIndex = 63
        Me.NombreComboBox.ValueMember = "NumProductor"
        '
        'ProductoresBindingSource1
        '
        Me.ProductoresBindingSource1.DataMember = "Productores"
        Me.ProductoresBindingSource1.DataSource = Me.RoquinDBDataSet
        '
        'ConsultDetallePersonalBindingSource
        '
        Me.ConsultDetallePersonalBindingSource.DataMember = "Produccion_ConsultDetallePersonal"
        Me.ConsultDetallePersonalBindingSource.DataSource = Me.ProduccionBindingSource
        '
        'ConsultDetallePersonalTableAdapter
        '
        Me.ConsultDetallePersonalTableAdapter.ClearBeforeFill = True
        '
        'ConsultDetallePersonalDataGridView
        '
        Me.ConsultDetallePersonalDataGridView.AllowUserToAddRows = False
        Me.ConsultDetallePersonalDataGridView.AllowUserToDeleteRows = False
        Me.ConsultDetallePersonalDataGridView.AutoGenerateColumns = False
        Me.ConsultDetallePersonalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ConsultDetallePersonalDataGridView.BackgroundColor = System.Drawing.Color.LightGreen
        Me.ConsultDetallePersonalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsultDetallePersonalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumEmpleado, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.ConsultDetallePersonalDataGridView.DataSource = Me.ConsultDetallePersonalBindingSource
        Me.ConsultDetallePersonalDataGridView.EnableHeadersVisualStyles = False
        Me.ConsultDetallePersonalDataGridView.Location = New System.Drawing.Point(933, 365)
        Me.ConsultDetallePersonalDataGridView.Name = "ConsultDetallePersonalDataGridView"
        Me.ConsultDetallePersonalDataGridView.ReadOnly = True
        Me.ConsultDetallePersonalDataGridView.RowHeadersVisible = False
        Me.ConsultDetallePersonalDataGridView.RowTemplate.Height = 24
        Me.ConsultDetallePersonalDataGridView.Size = New System.Drawing.Size(800, 168)
        Me.ConsultDetallePersonalDataGridView.TabIndex = 63
        '
        'NumEmpleado
        '
        Me.NumEmpleado.DataPropertyName = "NumEmpleado"
        Me.NumEmpleado.FillWeight = 78.53723!
        Me.NumEmpleado.HeaderText = "Empleado"
        Me.NumEmpleado.Name = "NumEmpleado"
        Me.NumEmpleado.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "ApellidosEmp"
        Me.DataGridViewTextBoxColumn18.FillWeight = 133.5668!
        Me.DataGridViewTextBoxColumn18.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NombreEmpleado"
        Me.DataGridViewTextBoxColumn17.FillWeight = 152.2842!
        Me.DataGridViewTextBoxColumn17.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Kilos"
        Me.DataGridViewTextBoxColumn11.FillWeight = 78.53723!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Gramos"
        Me.DataGridViewTextBoxColumn12.FillWeight = 78.53723!
        Me.DataGridViewTextBoxColumn12.HeaderText = "Gramos"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Cubetas"
        Me.DataGridViewTextBoxColumn13.FillWeight = 78.53723!
        Me.DataGridViewTextBoxColumn13.HeaderText = "Cubetas"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'SectoresBindingSource
        '
        Me.SectoresBindingSource.DataMember = "Sectores"
        Me.SectoresBindingSource.DataSource = Me.RoquinDBDataSet
        '
        'SectoresTableAdapter
        '
        Me.SectoresTableAdapter.ClearBeforeFill = True
        '
        'SectoresBindingSource1
        '
        Me.SectoresBindingSource1.DataMember = "Produccion_Sectores"
        Me.SectoresBindingSource1.DataSource = Me.ProduccionBindingSource
        '
        'NombreSecComboBox
        '
        Me.NombreSecComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SectoresBindingSource1, "NombreSec", True))
        Me.NombreSecComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.NombreSecComboBox.FormattingEnabled = True
        Me.NombreSecComboBox.Location = New System.Drawing.Point(227, 627)
        Me.NombreSecComboBox.Name = "NombreSecComboBox"
        Me.NombreSecComboBox.Size = New System.Drawing.Size(200, 37)
        Me.NombreSecComboBox.TabIndex = 65
        '
        'DataGridDetalle
        '
        Me.DataGridDetalle.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Empleado, Me.Apellido, Me.Nom, Me.kilos, Me.gramos, Me.cubetas})
        Me.DataGridDetalle.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridDetalle.Location = New System.Drawing.Point(933, 555)
        Me.DataGridDetalle.Name = "DataGridDetalle"
        Me.DataGridDetalle.RowHeadersVisible = False
        Me.DataGridDetalle.RowTemplate.Height = 24
        Me.DataGridDetalle.Size = New System.Drawing.Size(800, 150)
        Me.DataGridDetalle.TabIndex = 66
        '
        'Empleado
        '
        Me.Empleado.HeaderText = "Empleado"
        Me.Empleado.Name = "Empleado"
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellidos"
        Me.Apellido.Name = "Apellido"
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nombre"
        Me.Nom.Name = "Nom"
        '
        'kilos
        '
        Me.kilos.HeaderText = "Kilos"
        Me.kilos.Name = "kilos"
        '
        'gramos
        '
        Me.gramos.HeaderText = "Gramos"
        Me.gramos.Name = "gramos"
        '
        'cubetas
        '
        Me.cubetas.HeaderText = "Cubetas"
        Me.cubetas.Name = "cubetas"
        '
        'BEditar
        '
        Me.BEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BEditar.Image = CType(resources.GetObject("BEditar.Image"), System.Drawing.Image)
        Me.BEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEditar.Location = New System.Drawing.Point(761, 742)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BEditar.Size = New System.Drawing.Size(150, 60)
        Me.BEditar.TabIndex = 67
        Me.BEditar.Text = "Editar"
        Me.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEditar.UseVisualStyleBackColor = False
        '
        'FProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1810, 853)
        Me.Controls.Add(Me.BEditar)
        Me.Controls.Add(Me.DataGridDetalle)
        Me.Controls.Add(Me.NombreSecComboBox)
        Me.Controls.Add(Me.ConsultDetallePersonalDataGridView)
        Me.Controls.Add(Me.NombreComboBox)
        Me.Controls.Add(VariedadLabel)
        Me.Controls.Add(Me.VariedadComboBox)
        Me.Controls.Add(EmbalajeLabel)
        Me.Controls.Add(Me.EmbalajeComboBox)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.ProduccionDataGridView)
        Me.Controls.Add(FolioLabel)
        Me.Controls.Add(Me.FolioTextBox)
        Me.Controls.Add(FechaProdLabel)
        Me.Controls.Add(Me.FechaProdDateTimePicker)
        Me.Controls.Add(NumProdLabel)
        Me.Controls.Add(Me.NumProdTextBox)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(HuertoLabel)
        Me.Controls.Add(Me.HuertoTextBox)
        Me.Controls.Add(TemporadaLabel)
        Me.Controls.Add(Me.TemporadaTextBox)
        Me.Controls.Add(CajasLabel)
        Me.Controls.Add(Me.CajasTextBox)
        Me.Controls.Add(KilosLabel)
        Me.Controls.Add(Me.KilosTextBox)
        Me.Controls.Add(NumSectorLabel)
        Me.Controls.Add(Me.NumSectorTextBox)
        Me.Controls.Add(KGCampoLabel)
        Me.Controls.Add(Me.KGCampoTextBox)
        Me.Controls.Add(GaleraLabel)
        Me.Controls.Add(Me.GaleraTextBox)
        Me.Controls.Add(ClamshellLabel)
        Me.Controls.Add(Me.ClamshellTextBox)
        Me.Controls.Add(CubetasSinEmpLabel)
        Me.Controls.Add(Me.CubetasSinEmpTextBox)
        Me.Controls.Add(DiasCorteLabel)
        Me.Controls.Add(Me.DiasCorteTextBox)
        Me.Controls.Add(DefectoLabel)
        Me.Controls.Add(Me.DefectoTextBox)
        Me.Controls.Add(TotCubetasLabel)
        Me.Controls.Add(Me.TotCubetasTextBox)
        Me.Controls.Add(CortesiasLabel)
        Me.Controls.Add(Me.CortesiasTextBox)
        Me.Controls.Add(EncargadoLabel)
        Me.Controls.Add(Me.EncargadoTextBox)
        Me.Controls.Add(Me.ProduccionBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FProduccion"
        Me.Text = "Administración de Producción"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProduccionBindingNavigator.ResumeLayout(False)
        Me.ProduccionBindingNavigator.PerformLayout()
        CType(Me.ProductoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultDetallePersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultDetallePersonalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelPersonal As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RoquinDBDataSet As RoquinDBDataSet
    Friend WithEvents ProduccionBindingSource As BindingSource
    Friend WithEvents ProduccionTableAdapter As RoquinDBDataSetTableAdapters.ProduccionTableAdapter
    Friend WithEvents TableAdapterManager As RoquinDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FolioTextBox As TextBox
    Friend WithEvents FechaProdDateTimePicker As DateTimePicker
    Friend WithEvents NumProdTextBox As TextBox
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents HuertoTextBox As TextBox
    Friend WithEvents TemporadaTextBox As TextBox
    Friend WithEvents CajasTextBox As TextBox
    Friend WithEvents KilosTextBox As TextBox
    Friend WithEvents NumSectorTextBox As TextBox
    Friend WithEvents KGCampoTextBox As TextBox
    Friend WithEvents GaleraTextBox As TextBox
    Friend WithEvents ClamshellTextBox As TextBox
    Friend WithEvents CubetasSinEmpTextBox As TextBox
    Friend WithEvents DiasCorteTextBox As TextBox
    Friend WithEvents DefectoTextBox As TextBox
    Friend WithEvents TotCubetasTextBox As TextBox
    Friend WithEvents CortesiasTextBox As TextBox
    Friend WithEvents EncargadoTextBox As TextBox
    Friend WithEvents ProduccionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProduccionBindingNavigator As BindingNavigator
    Friend WithEvents BEliminar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BNuevo As Button
    Friend WithEvents EmbalajeComboBox As ComboBox
    Friend WithEvents VariedadComboBox As ComboBox
    Friend WithEvents ProductoresBindingSource As BindingSource
    Friend WithEvents ProductoresTableAdapter As RoquinDBDataSetTableAdapters.ProductoresTableAdapter
    Friend WithEvents NombreComboBox As ComboBox
    Friend WithEvents ProductoresBindingSource1 As BindingSource
    Friend WithEvents ConsultDetallePersonalBindingSource As BindingSource
    Friend WithEvents ConsultDetallePersonalTableAdapter As RoquinDBDataSetTableAdapters.ConsultDetallePersonalTableAdapter
    Friend WithEvents ConsultDetallePersonalDataGridView As DataGridView
    Friend WithEvents SectoresBindingSource As BindingSource
    Friend WithEvents SectoresTableAdapter As RoquinDBDataSetTableAdapters.SectoresTableAdapter
    Friend WithEvents SectoresBindingSource1 As BindingSource
    Friend WithEvents NombreSecComboBox As ComboBox
    Friend WithEvents NumEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridDetalle As DataGridView
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents kilos As DataGridViewTextBoxColumn
    Friend WithEvents gramos As DataGridViewTextBoxColumn
    Friend WithEvents cubetas As DataGridViewTextBoxColumn
    Friend WithEvents BEditar As Button
End Class
