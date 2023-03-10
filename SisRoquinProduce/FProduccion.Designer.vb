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
        Dim NumEmpleadoLabel As System.Windows.Forms.Label
        Dim NombreEmpleadoLabel As System.Windows.Forms.Label
        Dim ApellidosEmpLabel As System.Windows.Forms.Label
        Dim FolioDetaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FProduccion))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.ConsultDetallePersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultDetallePersonalTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.ConsultDetallePersonalTableAdapter()
        Me.ConsultDetallePersonalDataGridView = New System.Windows.Forms.DataGridView()
        Me.NumEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectoresTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.SectoresTableAdapter()
        Me.SectoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreSecComboBox = New System.Windows.Forms.ComboBox()
        Me.DataGridDetalle = New System.Windows.Forms.DataGridView()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cubetas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kilos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gramos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonalTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.PersonalTableAdapter()
        Me.NumEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosEmpTextBox = New System.Windows.Forms.TextBox()
        Me.DetalleFolioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleFolioTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.DetalleFolioTableAdapter()
        Me.FolioDetaTextBox = New System.Windows.Forms.TextBox()
        Me.BSave = New System.Windows.Forms.Button()
        Me.LabelListadoFolios = New System.Windows.Forms.Label()
        Me.LabelRegistroCosecha = New System.Windows.Forms.Label()
        Me.LabelListadoCosechas = New System.Windows.Forms.Label()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.LabelRegFolio = New System.Windows.Forms.Label()
        Me.ProduccionConsultDetallePersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DateTimeFolio = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HuertoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemporadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumSectorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EncargadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        NumEmpleadoLabel = New System.Windows.Forms.Label()
        NombreEmpleadoLabel = New System.Windows.Forms.Label()
        ApellidosEmpLabel = New System.Windows.Forms.Label()
        FolioDetaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProduccionBindingNavigator.SuspendLayout()
        CType(Me.ProductoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultDetallePersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultDetallePersonalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFolioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionConsultDetallePersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FolioLabel
        '
        FolioLabel.AutoSize = True
        FolioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        FolioLabel.Location = New System.Drawing.Point(83, 241)
        FolioLabel.Name = "FolioLabel"
        FolioLabel.Size = New System.Drawing.Size(74, 29)
        FolioLabel.TabIndex = 17
        FolioLabel.Text = "Folio:"
        '
        'FechaProdLabel
        '
        FechaProdLabel.AutoSize = True
        FechaProdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        FechaProdLabel.Location = New System.Drawing.Point(71, 291)
        FechaProdLabel.Name = "FechaProdLabel"
        FechaProdLabel.Size = New System.Drawing.Size(86, 29)
        FechaProdLabel.TabIndex = 19
        FechaProdLabel.Text = "Fecha:"
        '
        'NumProdLabel
        '
        NumProdLabel.AutoSize = True
        NumProdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        NumProdLabel.Location = New System.Drawing.Point(33, 340)
        NumProdLabel.Name = "NumProdLabel"
        NumProdLabel.Size = New System.Drawing.Size(124, 29)
        NumProdLabel.TabIndex = 21
        NumProdLabel.Text = "Productor:"
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        CodigoLabel.Location = New System.Drawing.Point(59, 391)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(98, 29)
        CodigoLabel.TabIndex = 23
        CodigoLabel.Text = "Código:"
        '
        'HuertoLabel
        '
        HuertoLabel.AutoSize = True
        HuertoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        HuertoLabel.Location = New System.Drawing.Point(66, 441)
        HuertoLabel.Name = "HuertoLabel"
        HuertoLabel.Size = New System.Drawing.Size(91, 29)
        HuertoLabel.TabIndex = 25
        HuertoLabel.Text = "Huerto:"
        '
        'TemporadaLabel
        '
        TemporadaLabel.AutoSize = True
        TemporadaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        TemporadaLabel.Location = New System.Drawing.Point(12, 491)
        TemporadaLabel.Name = "TemporadaLabel"
        TemporadaLabel.Size = New System.Drawing.Size(145, 29)
        TemporadaLabel.TabIndex = 27
        TemporadaLabel.Text = "Temporada:"
        '
        'CajasLabel
        '
        CajasLabel.AutoSize = True
        CajasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        CajasLabel.Location = New System.Drawing.Point(77, 541)
        CajasLabel.Name = "CajasLabel"
        CajasLabel.Size = New System.Drawing.Size(80, 29)
        CajasLabel.TabIndex = 29
        CajasLabel.Text = "Cajas:"
        '
        'KilosLabel
        '
        KilosLabel.AutoSize = True
        KilosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        KilosLabel.Location = New System.Drawing.Point(84, 591)
        KilosLabel.Name = "KilosLabel"
        KilosLabel.Size = New System.Drawing.Size(73, 29)
        KilosLabel.TabIndex = 31
        KilosLabel.Text = "Kilos:"
        '
        'NumSectorLabel
        '
        NumSectorLabel.AutoSize = True
        NumSectorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        NumSectorLabel.Location = New System.Drawing.Point(66, 641)
        NumSectorLabel.Name = "NumSectorLabel"
        NumSectorLabel.Size = New System.Drawing.Size(89, 29)
        NumSectorLabel.TabIndex = 33
        NumSectorLabel.Text = "Sector:"
        '
        'KGCampoLabel
        '
        KGCampoLabel.AutoSize = True
        KGCampoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        KGCampoLabel.Location = New System.Drawing.Point(502, 291)
        KGCampoLabel.Name = "KGCampoLabel"
        KGCampoLabel.Size = New System.Drawing.Size(137, 29)
        KGCampoLabel.TabIndex = 39
        KGCampoLabel.Text = "KG Campo:"
        '
        'GaleraLabel
        '
        GaleraLabel.AutoSize = True
        GaleraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        GaleraLabel.Location = New System.Drawing.Point(547, 341)
        GaleraLabel.Name = "GaleraLabel"
        GaleraLabel.Size = New System.Drawing.Size(91, 29)
        GaleraLabel.TabIndex = 41
        GaleraLabel.Text = "Galera:"
        '
        'ClamshellLabel
        '
        ClamshellLabel.AutoSize = True
        ClamshellLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        ClamshellLabel.Location = New System.Drawing.Point(512, 391)
        ClamshellLabel.Name = "ClamshellLabel"
        ClamshellLabel.Size = New System.Drawing.Size(126, 29)
        ClamshellLabel.TabIndex = 43
        ClamshellLabel.Text = "Clamshell:"
        '
        'CubetasSinEmpLabel
        '
        CubetasSinEmpLabel.AutoSize = True
        CubetasSinEmpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        CubetasSinEmpLabel.Location = New System.Drawing.Point(386, 441)
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
        DiasCorteLabel.Location = New System.Drawing.Point(487, 491)
        DiasCorteLabel.Name = "DiasCorteLabel"
        DiasCorteLabel.Size = New System.Drawing.Size(151, 29)
        DiasCorteLabel.TabIndex = 47
        DiasCorteLabel.Text = "Días a Corte:"
        '
        'DefectoLabel
        '
        DefectoLabel.AutoSize = True
        DefectoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DefectoLabel.Location = New System.Drawing.Point(536, 541)
        DefectoLabel.Name = "DefectoLabel"
        DefectoLabel.Size = New System.Drawing.Size(102, 29)
        DefectoLabel.TabIndex = 49
        DefectoLabel.Text = "Defecto:"
        '
        'TotCubetasLabel
        '
        TotCubetasLabel.AutoSize = True
        TotCubetasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        TotCubetasLabel.Location = New System.Drawing.Point(469, 591)
        TotCubetasLabel.Name = "TotCubetasLabel"
        TotCubetasLabel.Size = New System.Drawing.Size(169, 29)
        TotCubetasLabel.TabIndex = 51
        TotCubetasLabel.Text = "Total Cubetas:"
        '
        'CortesiasLabel
        '
        CortesiasLabel.AutoSize = True
        CortesiasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        CortesiasLabel.Location = New System.Drawing.Point(517, 641)
        CortesiasLabel.Name = "CortesiasLabel"
        CortesiasLabel.Size = New System.Drawing.Size(121, 29)
        CortesiasLabel.TabIndex = 53
        CortesiasLabel.Text = "Cortesías:"
        '
        'EncargadoLabel
        '
        EncargadoLabel.AutoSize = True
        EncargadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        EncargadoLabel.Location = New System.Drawing.Point(502, 691)
        EncargadoLabel.Name = "EncargadoLabel"
        EncargadoLabel.Size = New System.Drawing.Size(136, 29)
        EncargadoLabel.TabIndex = 55
        EncargadoLabel.Text = "Encargado:"
        '
        'EmbalajeLabel
        '
        EmbalajeLabel.AutoSize = True
        EmbalajeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        EmbalajeLabel.Location = New System.Drawing.Point(37, 693)
        EmbalajeLabel.Name = "EmbalajeLabel"
        EmbalajeLabel.Size = New System.Drawing.Size(121, 29)
        EmbalajeLabel.TabIndex = 60
        EmbalajeLabel.Text = "Embalaje:"
        '
        'VariedadLabel
        '
        VariedadLabel.AutoSize = True
        VariedadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        VariedadLabel.Location = New System.Drawing.Point(523, 243)
        VariedadLabel.Name = "VariedadLabel"
        VariedadLabel.Size = New System.Drawing.Size(116, 29)
        VariedadLabel.TabIndex = 61
        VariedadLabel.Text = "Variedad:"
        '
        'NumEmpleadoLabel
        '
        NumEmpleadoLabel.AutoSize = True
        NumEmpleadoLabel.Location = New System.Drawing.Point(1173, 575)
        NumEmpleadoLabel.Name = "NumEmpleadoLabel"
        NumEmpleadoLabel.Size = New System.Drawing.Size(108, 17)
        NumEmpleadoLabel.TabIndex = 67
        NumEmpleadoLabel.Text = "Num Empleado:"
        '
        'NombreEmpleadoLabel
        '
        NombreEmpleadoLabel.AutoSize = True
        NombreEmpleadoLabel.Location = New System.Drawing.Point(1152, 610)
        NombreEmpleadoLabel.Name = "NombreEmpleadoLabel"
        NombreEmpleadoLabel.Size = New System.Drawing.Size(129, 17)
        NombreEmpleadoLabel.TabIndex = 68
        NombreEmpleadoLabel.Text = "Nombre Empleado:"
        '
        'ApellidosEmpLabel
        '
        ApellidosEmpLabel.AutoSize = True
        ApellidosEmpLabel.Location = New System.Drawing.Point(1180, 646)
        ApellidosEmpLabel.Name = "ApellidosEmpLabel"
        ApellidosEmpLabel.Size = New System.Drawing.Size(101, 17)
        ApellidosEmpLabel.TabIndex = 69
        ApellidosEmpLabel.Text = "Apellidos Emp:"
        '
        'FolioDetaLabel
        '
        FolioDetaLabel.AutoSize = True
        FolioDetaLabel.Location = New System.Drawing.Point(1419, 575)
        FolioDetaLabel.Name = "FolioDetaLabel"
        FolioDetaLabel.Size = New System.Drawing.Size(76, 17)
        FolioDetaLabel.TabIndex = 70
        FolioDetaLabel.Text = "Folio Deta:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Label1.Location = New System.Drawing.Point(1620, 311)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(80, 29)
        Label1.TabIndex = 82
        Label1.Text = "Folio:"
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
        Me.Panel1.Size = New System.Drawing.Size(1900, 180)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SisRoquinProduce.My.Resources.Resources.Roquin_logo6
        Me.PictureBox1.Location = New System.Drawing.Point(50, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'LabelPersonal
        '
        Me.LabelPersonal.AutoSize = True
        Me.LabelPersonal.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPersonal.Location = New System.Drawing.Point(350, 60)
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
        Me.FolioTextBox.Location = New System.Drawing.Point(172, 241)
        Me.FolioTextBox.Name = "FolioTextBox"
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
        Me.FechaProdDateTimePicker.Location = New System.Drawing.Point(172, 291)
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
        Me.NumProdTextBox.Location = New System.Drawing.Point(172, 341)
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
        Me.CodigoTextBox.Location = New System.Drawing.Point(172, 391)
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
        Me.HuertoTextBox.Location = New System.Drawing.Point(172, 441)
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
        Me.TemporadaTextBox.Location = New System.Drawing.Point(172, 491)
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
        Me.CajasTextBox.Location = New System.Drawing.Point(172, 541)
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
        Me.KilosTextBox.Location = New System.Drawing.Point(172, 591)
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
        Me.NumSectorTextBox.Location = New System.Drawing.Point(172, 641)
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
        Me.KGCampoTextBox.Location = New System.Drawing.Point(660, 291)
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
        Me.GaleraTextBox.Location = New System.Drawing.Point(660, 341)
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
        Me.ClamshellTextBox.Location = New System.Drawing.Point(660, 391)
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
        Me.CubetasSinEmpTextBox.Location = New System.Drawing.Point(660, 441)
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
        Me.DiasCorteTextBox.Location = New System.Drawing.Point(660, 491)
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
        Me.DefectoTextBox.Location = New System.Drawing.Point(660, 541)
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
        Me.TotCubetasTextBox.Location = New System.Drawing.Point(660, 591)
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
        Me.CortesiasTextBox.Location = New System.Drawing.Point(660, 641)
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
        Me.EncargadoTextBox.Location = New System.Drawing.Point(660, 691)
        Me.EncargadoTextBox.Name = "EncargadoTextBox"
        Me.EncargadoTextBox.Size = New System.Drawing.Size(200, 34)
        Me.EncargadoTextBox.TabIndex = 56
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
        Me.ProduccionBindingNavigator.Location = New System.Drawing.Point(0, 834)
        Me.ProduccionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProduccionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProduccionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProduccionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProduccionBindingNavigator.Name = "ProduccionBindingNavigator"
        Me.ProduccionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProduccionBindingNavigator.Size = New System.Drawing.Size(1920, 27)
        Me.ProduccionBindingNavigator.TabIndex = 15
        Me.ProduccionBindingNavigator.Text = "BindingNavigator1"
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BEliminar.Image = CType(resources.GetObject("BEliminar.Image"), System.Drawing.Image)
        Me.BEliminar.Location = New System.Drawing.Point(867, 733)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BEliminar.Size = New System.Drawing.Size(60, 60)
        Me.BEliminar.TabIndex = 60
        Me.BEliminar.Text = "  "
        Me.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BCancelar.Image = CType(resources.GetObject("BCancelar.Image"), System.Drawing.Image)
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCancelar.Location = New System.Drawing.Point(576, 733)
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
        Me.BGuardar.Location = New System.Drawing.Point(842, 733)
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
        Me.BNuevo.Location = New System.Drawing.Point(482, 733)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BNuevo.Size = New System.Drawing.Size(180, 60)
        Me.BNuevo.TabIndex = 57
        Me.BNuevo.Text = "Nuevo Folio"
        Me.BNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BNuevo.UseVisualStyleBackColor = False
        '
        'EmbalajeComboBox
        '
        Me.EmbalajeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Embalaje", True))
        Me.EmbalajeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.EmbalajeComboBox.FormattingEnabled = True
        Me.EmbalajeComboBox.Items.AddRange(New Object() {"4x4", "18oz", "6oz", "pinta"})
        Me.EmbalajeComboBox.Location = New System.Drawing.Point(172, 690)
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
        Me.VariedadComboBox.Location = New System.Drawing.Point(660, 240)
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
        Me.NombreComboBox.DisplayMember = "NumProductor"
        Me.NombreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(172, 340)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(200, 37)
        Me.NombreComboBox.TabIndex = 63
        Me.NombreComboBox.ValueMember = "NumProductor"
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ConsultDetallePersonalDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.ConsultDetallePersonalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsultDetallePersonalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumEmpleado, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.ConsultDetallePersonalDataGridView.DataSource = Me.ConsultDetallePersonalBindingSource
        Me.ConsultDetallePersonalDataGridView.EnableHeadersVisualStyles = False
        Me.ConsultDetallePersonalDataGridView.Location = New System.Drawing.Point(1000, 534)
        Me.ConsultDetallePersonalDataGridView.Name = "ConsultDetallePersonalDataGridView"
        Me.ConsultDetallePersonalDataGridView.ReadOnly = True
        Me.ConsultDetallePersonalDataGridView.RowHeadersVisible = False
        Me.ConsultDetallePersonalDataGridView.RowTemplate.Height = 24
        Me.ConsultDetallePersonalDataGridView.Size = New System.Drawing.Size(839, 186)
        Me.ConsultDetallePersonalDataGridView.TabIndex = 63
        '
        'NumEmpleado
        '
        Me.NumEmpleado.DataPropertyName = "NumEmpleado"
        Me.NumEmpleado.FillWeight = 50.0!
        Me.NumEmpleado.HeaderText = "Empleado"
        Me.NumEmpleado.Name = "NumEmpleado"
        Me.NumEmpleado.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "ApellidosEmp"
        Me.DataGridViewTextBoxColumn18.FillWeight = 75.67144!
        Me.DataGridViewTextBoxColumn18.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NombreEmpleado"
        Me.DataGridViewTextBoxColumn17.FillWeight = 86.27567!
        Me.DataGridViewTextBoxColumn17.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Cubetas"
        Me.DataGridViewTextBoxColumn13.FillWeight = 44.49478!
        Me.DataGridViewTextBoxColumn13.HeaderText = "Cubetas"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Kilos"
        Me.DataGridViewTextBoxColumn11.FillWeight = 44.49478!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Gramos"
        Me.DataGridViewTextBoxColumn12.FillWeight = 44.49478!
        Me.DataGridViewTextBoxColumn12.HeaderText = "Gramos"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
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
        Me.NombreSecComboBox.Location = New System.Drawing.Point(172, 640)
        Me.NombreSecComboBox.Name = "NombreSecComboBox"
        Me.NombreSecComboBox.Size = New System.Drawing.Size(200, 37)
        Me.NombreSecComboBox.TabIndex = 65
        '
        'DataGridDetalle
        '
        Me.DataGridDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridDetalle.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Empleado, Me.Apellido, Me.Nom, Me.cubetas, Me.kilos, Me.gramos})
        Me.DataGridDetalle.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridDetalle.Location = New System.Drawing.Point(1000, 359)
        Me.DataGridDetalle.Name = "DataGridDetalle"
        Me.DataGridDetalle.RowHeadersVisible = False
        Me.DataGridDetalle.RowTemplate.Height = 24
        Me.DataGridDetalle.Size = New System.Drawing.Size(769, 104)
        Me.DataGridDetalle.TabIndex = 1
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
        'cubetas
        '
        Me.cubetas.HeaderText = "Cubetas"
        Me.cubetas.Name = "cubetas"
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
        'BEditar
        '
        Me.BEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BEditar.Image = CType(resources.GetObject("BEditar.Image"), System.Drawing.Image)
        Me.BEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEditar.Location = New System.Drawing.Point(668, 733)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BEditar.Size = New System.Drawing.Size(180, 60)
        Me.BEditar.TabIndex = 67
        Me.BEditar.Text = "Editar Folio"
        Me.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEditar.UseVisualStyleBackColor = False
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
        'NumEmpleadoTextBox
        '
        Me.NumEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "NumEmpleado", True))
        Me.NumEmpleadoTextBox.Location = New System.Drawing.Point(1287, 572)
        Me.NumEmpleadoTextBox.Name = "NumEmpleadoTextBox"
        Me.NumEmpleadoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NumEmpleadoTextBox.TabIndex = 68
        '
        'NombreEmpleadoTextBox
        '
        Me.NombreEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "NombreEmpleado", True))
        Me.NombreEmpleadoTextBox.Location = New System.Drawing.Point(1287, 607)
        Me.NombreEmpleadoTextBox.Name = "NombreEmpleadoTextBox"
        Me.NombreEmpleadoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NombreEmpleadoTextBox.TabIndex = 69
        '
        'ApellidosEmpTextBox
        '
        Me.ApellidosEmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "ApellidosEmp", True))
        Me.ApellidosEmpTextBox.Location = New System.Drawing.Point(1287, 643)
        Me.ApellidosEmpTextBox.Name = "ApellidosEmpTextBox"
        Me.ApellidosEmpTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ApellidosEmpTextBox.TabIndex = 70
        '
        'DetalleFolioBindingSource
        '
        Me.DetalleFolioBindingSource.DataMember = "DetalleFolio"
        Me.DetalleFolioBindingSource.DataSource = Me.RoquinDBDataSet
        '
        'DetalleFolioTableAdapter
        '
        Me.DetalleFolioTableAdapter.ClearBeforeFill = True
        '
        'FolioDetaTextBox
        '
        Me.FolioDetaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleFolioBindingSource, "FolioDeta", True))
        Me.FolioDetaTextBox.Location = New System.Drawing.Point(1501, 572)
        Me.FolioDetaTextBox.Name = "FolioDetaTextBox"
        Me.FolioDetaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FolioDetaTextBox.TabIndex = 71
        '
        'BSave
        '
        Me.BSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BSave.Image = CType(resources.GetObject("BSave.Image"), System.Drawing.Image)
        Me.BSave.Location = New System.Drawing.Point(1779, 384)
        Me.BSave.Name = "BSave"
        Me.BSave.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BSave.Size = New System.Drawing.Size(60, 60)
        Me.BSave.TabIndex = 2
        Me.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BSave.UseVisualStyleBackColor = False
        '
        'LabelListadoFolios
        '
        Me.LabelListadoFolios.AutoSize = True
        Me.LabelListadoFolios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelListadoFolios.Location = New System.Drawing.Point(20, 192)
        Me.LabelListadoFolios.Name = "LabelListadoFolios"
        Me.LabelListadoFolios.Size = New System.Drawing.Size(391, 29)
        Me.LabelListadoFolios.TabIndex = 74
        Me.LabelListadoFolios.Text = "Listado de Folios de Producción"
        '
        'LabelRegistroCosecha
        '
        Me.LabelRegistroCosecha.AutoSize = True
        Me.LabelRegistroCosecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelRegistroCosecha.Location = New System.Drawing.Point(995, 311)
        Me.LabelRegistroCosecha.Name = "LabelRegistroCosecha"
        Me.LabelRegistroCosecha.Size = New System.Drawing.Size(392, 29)
        Me.LabelRegistroCosecha.TabIndex = 75
        Me.LabelRegistroCosecha.Text = "Registrar Cosecha de Empleado"
        '
        'LabelListadoCosechas
        '
        Me.LabelListadoCosechas.AutoSize = True
        Me.LabelListadoCosechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelListadoCosechas.Location = New System.Drawing.Point(995, 489)
        Me.LabelListadoCosechas.Name = "LabelListadoCosechas"
        Me.LabelListadoCosechas.Size = New System.Drawing.Size(257, 29)
        Me.LabelListadoCosechas.TabIndex = 76
        Me.LabelListadoCosechas.Text = "Listado de Cosechas"
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TextBoxBuscar.Location = New System.Drawing.Point(601, 192)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(160, 34)
        Me.TextBoxBuscar.TabIndex = 77
        '
        'BBuscar
        '
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BBuscar.Location = New System.Drawing.Point(767, 190)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(100, 40)
        Me.BBuscar.TabIndex = 78
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'LabelRegFolio
        '
        Me.LabelRegFolio.AutoSize = True
        Me.LabelRegFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelRegFolio.Location = New System.Drawing.Point(20, 190)
        Me.LabelRegFolio.Name = "LabelRegFolio"
        Me.LabelRegFolio.Size = New System.Drawing.Size(363, 29)
        Me.LabelRegFolio.TabIndex = 79
        Me.LabelRegFolio.Text = "Registrar Folio de Producción"
        '
        'ProduccionConsultDetallePersonalBindingSource
        '
        Me.ProduccionConsultDetallePersonalBindingSource.DataMember = "Produccion_ConsultDetallePersonal"
        Me.ProduccionConsultDetallePersonalBindingSource.DataSource = Me.ProduccionBindingSource
        '
        'ProduccionDataGridView
        '
        Me.ProduccionDataGridView.AllowUserToAddRows = False
        Me.ProduccionDataGridView.AllowUserToDeleteRows = False
        Me.ProduccionDataGridView.AutoGenerateColumns = False
        Me.ProduccionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProduccionDataGridView.BackgroundColor = System.Drawing.Color.LightGreen
        Me.ProduccionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SpringGreen
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProduccionDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.ProduccionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProduccionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioDataGridViewTextBoxColumn, Me.FechaProdDataGridViewTextBoxColumn, Me.HuertoDataGridViewTextBoxColumn, Me.TemporadaDataGridViewTextBoxColumn, Me.CajasDataGridViewTextBoxColumn, Me.KilosDataGridViewTextBoxColumn, Me.NumSectorDataGridViewTextBoxColumn, Me.EncargadoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.ProduccionDataGridView.DataSource = Me.ProduccionBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProduccionDataGridView.DefaultCellStyle = DataGridViewCellStyle9
        Me.ProduccionDataGridView.GridColor = System.Drawing.Color.Black
        Me.ProduccionDataGridView.Location = New System.Drawing.Point(11, 236)
        Me.ProduccionDataGridView.Name = "ProduccionDataGridView"
        Me.ProduccionDataGridView.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProduccionDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.ProduccionDataGridView.RowHeadersVisible = False
        Me.ProduccionDataGridView.RowTemplate.Height = 24
        Me.ProduccionDataGridView.Size = New System.Drawing.Size(916, 491)
        Me.ProduccionDataGridView.TabIndex = 79
        '
        'DateTimeFolio
        '
        Me.DateTimeFolio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProduccionBindingSource, "FechaProd", True))
        Me.DateTimeFolio.Enabled = False
        Me.DateTimeFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.DateTimeFolio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFolio.Location = New System.Drawing.Point(1688, 271)
        Me.DateTimeFolio.Name = "DateTimeFolio"
        Me.DateTimeFolio.Size = New System.Drawing.Size(151, 34)
        Me.DateTimeFolio.TabIndex = 81
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Folio", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(1709, 311)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 34)
        Me.TextBox1.TabIndex = 83
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "Folio"
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "Folio"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaProdDataGridViewTextBoxColumn
        '
        Me.FechaProdDataGridViewTextBoxColumn.DataPropertyName = "FechaProd"
        Me.FechaProdDataGridViewTextBoxColumn.HeaderText = "Fecha de Producción"
        Me.FechaProdDataGridViewTextBoxColumn.Name = "FechaProdDataGridViewTextBoxColumn"
        Me.FechaProdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HuertoDataGridViewTextBoxColumn
        '
        Me.HuertoDataGridViewTextBoxColumn.DataPropertyName = "Huerto"
        Me.HuertoDataGridViewTextBoxColumn.HeaderText = "Huerto"
        Me.HuertoDataGridViewTextBoxColumn.Name = "HuertoDataGridViewTextBoxColumn"
        Me.HuertoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TemporadaDataGridViewTextBoxColumn
        '
        Me.TemporadaDataGridViewTextBoxColumn.DataPropertyName = "Temporada"
        Me.TemporadaDataGridViewTextBoxColumn.HeaderText = "Temporada"
        Me.TemporadaDataGridViewTextBoxColumn.Name = "TemporadaDataGridViewTextBoxColumn"
        Me.TemporadaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CajasDataGridViewTextBoxColumn
        '
        Me.CajasDataGridViewTextBoxColumn.DataPropertyName = "Cajas"
        Me.CajasDataGridViewTextBoxColumn.HeaderText = "Cajas"
        Me.CajasDataGridViewTextBoxColumn.Name = "CajasDataGridViewTextBoxColumn"
        Me.CajasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KilosDataGridViewTextBoxColumn
        '
        Me.KilosDataGridViewTextBoxColumn.DataPropertyName = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.HeaderText = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.Name = "KilosDataGridViewTextBoxColumn"
        Me.KilosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumSectorDataGridViewTextBoxColumn
        '
        Me.NumSectorDataGridViewTextBoxColumn.DataPropertyName = "NumSector"
        Me.NumSectorDataGridViewTextBoxColumn.HeaderText = "Sector"
        Me.NumSectorDataGridViewTextBoxColumn.Name = "NumSectorDataGridViewTextBoxColumn"
        Me.NumSectorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EncargadoDataGridViewTextBoxColumn
        '
        Me.EncargadoDataGridViewTextBoxColumn.DataPropertyName = "Encargado"
        Me.EncargadoDataGridViewTextBoxColumn.HeaderText = "Encargado"
        Me.EncargadoDataGridViewTextBoxColumn.Name = "EncargadoDataGridViewTextBoxColumn"
        Me.EncargadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1920, 861)
        Me.Controls.Add(Me.ProduccionDataGridView)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimeFolio)
        Me.Controls.Add(Me.LabelRegFolio)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.LabelListadoCosechas)
        Me.Controls.Add(Me.LabelRegistroCosecha)
        Me.Controls.Add(Me.BSave)
        Me.Controls.Add(Me.DataGridDetalle)
        Me.Controls.Add(Me.BEditar)
        Me.Controls.Add(Me.NombreSecComboBox)
        Me.Controls.Add(Me.NombreComboBox)
        Me.Controls.Add(VariedadLabel)
        Me.Controls.Add(Me.VariedadComboBox)
        Me.Controls.Add(EmbalajeLabel)
        Me.Controls.Add(Me.EmbalajeComboBox)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BNuevo)
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
        Me.Controls.Add(Me.ConsultDetallePersonalDataGridView)
        Me.Controls.Add(FolioDetaLabel)
        Me.Controls.Add(Me.FolioDetaTextBox)
        Me.Controls.Add(ApellidosEmpLabel)
        Me.Controls.Add(Me.ApellidosEmpTextBox)
        Me.Controls.Add(NombreEmpleadoLabel)
        Me.Controls.Add(Me.NombreEmpleadoTextBox)
        Me.Controls.Add(NumEmpleadoLabel)
        Me.Controls.Add(Me.NumEmpleadoTextBox)
        Me.Controls.Add(Me.LabelListadoFolios)
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
        CType(Me.ProduccionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProduccionBindingNavigator.ResumeLayout(False)
        Me.ProduccionBindingNavigator.PerformLayout()
        CType(Me.ProductoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultDetallePersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultDetallePersonalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFolioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionConsultDetallePersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ConsultDetallePersonalBindingSource As BindingSource
    Friend WithEvents ConsultDetallePersonalTableAdapter As RoquinDBDataSetTableAdapters.ConsultDetallePersonalTableAdapter
    Friend WithEvents ConsultDetallePersonalDataGridView As DataGridView
    Friend WithEvents SectoresBindingSource As BindingSource
    Friend WithEvents SectoresTableAdapter As RoquinDBDataSetTableAdapters.SectoresTableAdapter
    Friend WithEvents SectoresBindingSource1 As BindingSource
    Friend WithEvents NombreSecComboBox As ComboBox
    Friend WithEvents DataGridDetalle As DataGridView
    Friend WithEvents BEditar As Button
    Friend WithEvents NumEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents PersonalBindingSource As BindingSource
    Friend WithEvents PersonalTableAdapter As RoquinDBDataSetTableAdapters.PersonalTableAdapter
    Friend WithEvents NumEmpleadoTextBox As TextBox
    Friend WithEvents NombreEmpleadoTextBox As TextBox
    Friend WithEvents ApellidosEmpTextBox As TextBox
    Friend WithEvents DetalleFolioBindingSource As BindingSource
    Friend WithEvents DetalleFolioTableAdapter As RoquinDBDataSetTableAdapters.DetalleFolioTableAdapter
    Friend WithEvents FolioDetaTextBox As TextBox
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents cubetas As DataGridViewTextBoxColumn
    Friend WithEvents kilos As DataGridViewTextBoxColumn
    Friend WithEvents gramos As DataGridViewTextBoxColumn
    Friend WithEvents BSave As Button
    Friend WithEvents LabelListadoFolios As Label
    Friend WithEvents LabelRegistroCosecha As Label
    Friend WithEvents LabelListadoCosechas As Label
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents LabelRegFolio As Label
    Friend WithEvents ProduccionConsultDetallePersonalBindingSource As BindingSource
    Friend WithEvents ProduccionDataGridView As DataGridView
    Friend WithEvents DateTimeFolio As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FolioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HuertoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TemporadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CajasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumSectorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EncargadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
