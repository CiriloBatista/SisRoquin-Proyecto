﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProducciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightGreen
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoToolStripMenuItem, Me.OperacionToolStripMenuItem, Me.UtiToolStripMenuItem, Me.InformesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 10, 6, 10)
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 74)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatalogoToolStripMenuItem
        '
        Me.CatalogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalToolStripMenuItem, Me.ProductoresToolStripMenuItem, Me.ProduccionToolStripMenuItem, Me.SectoresToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.CatalogoToolStripMenuItem.Image = CType(resources.GetObject("CatalogoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CatalogoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        Me.CatalogoToolStripMenuItem.Size = New System.Drawing.Size(204, 54)
        Me.CatalogoToolStripMenuItem.Text = "Catálogo"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(269, 40)
        Me.PersonalToolStripMenuItem.Text = "Personal"
        '
        'ProductoresToolStripMenuItem
        '
        Me.ProductoresToolStripMenuItem.Name = "ProductoresToolStripMenuItem"
        Me.ProductoresToolStripMenuItem.Size = New System.Drawing.Size(269, 40)
        Me.ProductoresToolStripMenuItem.Text = "Productores"
        '
        'ProduccionToolStripMenuItem
        '
        Me.ProduccionToolStripMenuItem.Name = "ProduccionToolStripMenuItem"
        Me.ProduccionToolStripMenuItem.Size = New System.Drawing.Size(269, 40)
        Me.ProduccionToolStripMenuItem.Text = "Producción"
        '
        'SectoresToolStripMenuItem
        '
        Me.SectoresToolStripMenuItem.Name = "SectoresToolStripMenuItem"
        Me.SectoresToolStripMenuItem.Size = New System.Drawing.Size(269, 40)
        Me.SectoresToolStripMenuItem.Text = "Sectores"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(269, 40)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'OperacionToolStripMenuItem
        '
        Me.OperacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradasToolStripMenuItem, Me.SalidasToolStripMenuItem, Me.InventariosToolStripMenuItem})
        Me.OperacionToolStripMenuItem.Image = CType(resources.GetObject("OperacionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OperacionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OperacionToolStripMenuItem.Name = "OperacionToolStripMenuItem"
        Me.OperacionToolStripMenuItem.Size = New System.Drawing.Size(223, 54)
        Me.OperacionToolStripMenuItem.Text = "Operación"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(253, 40)
        Me.EntradasToolStripMenuItem.Text = "Entradas"
        '
        'SalidasToolStripMenuItem
        '
        Me.SalidasToolStripMenuItem.Name = "SalidasToolStripMenuItem"
        Me.SalidasToolStripMenuItem.Size = New System.Drawing.Size(253, 40)
        Me.SalidasToolStripMenuItem.Text = "Salidas"
        '
        'InventariosToolStripMenuItem
        '
        Me.InventariosToolStripMenuItem.Name = "InventariosToolStripMenuItem"
        Me.InventariosToolStripMenuItem.Size = New System.Drawing.Size(253, 40)
        Me.InventariosToolStripMenuItem.Text = "Inventarios"
        '
        'UtiToolStripMenuItem
        '
        Me.UtiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarToolStripMenuItem, Me.CapturasToolStripMenuItem})
        Me.UtiToolStripMenuItem.Image = CType(resources.GetObject("UtiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UtiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UtiToolStripMenuItem.Name = "UtiToolStripMenuItem"
        Me.UtiToolStripMenuItem.Size = New System.Drawing.Size(194, 54)
        Me.UtiToolStripMenuItem.Text = "Utilerías"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(224, 40)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        '
        'CapturasToolStripMenuItem
        '
        Me.CapturasToolStripMenuItem.Name = "CapturasToolStripMenuItem"
        Me.CapturasToolStripMenuItem.Size = New System.Drawing.Size(224, 40)
        Me.CapturasToolStripMenuItem.Text = "Capturas"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProducciónToolStripMenuItem1})
        Me.InformesToolStripMenuItem.Image = CType(resources.GetObject("InformesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InformesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(199, 54)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(258, 40)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProducciónToolStripMenuItem1
        '
        Me.ProducciónToolStripMenuItem1.Name = "ProducciónToolStripMenuItem1"
        Me.ProducciónToolStripMenuItem1.Size = New System.Drawing.Size(258, 40)
        Me.ProducciónToolStripMenuItem1.Text = "Producción"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.LightCoral
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(142, 54)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SisRoquinProduce.My.Resources.Resources.back_roquin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(982, 603)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FMenu"
        Me.Text = "Roquin Produce"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatalogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CapturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProducciónToolStripMenuItem1 As ToolStripMenuItem
End Class
