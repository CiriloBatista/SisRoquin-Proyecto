<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FLogin))
        Me.RoquinDBDataSet = New SisRoquinProduce.RoquinDBDataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New SisRoquinProduce.RoquinDBDataSetTableAdapters.TableAdapterManager()
        Me.IdUserTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.NombreUserTextBox = New System.Windows.Forms.TextBox()
        Me.NivelComboBox = New System.Windows.Forms.ComboBox()
        Me.ContrasenaTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BIngresar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        IdUserLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        NombreUserLabel = New System.Windows.Forms.Label()
        NivelLabel = New System.Windows.Forms.Label()
        ContrasenaLabel = New System.Windows.Forms.Label()
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdUserLabel
        '
        IdUserLabel.AutoSize = True
        IdUserLabel.Location = New System.Drawing.Point(217, 63)
        IdUserLabel.Name = "IdUserLabel"
        IdUserLabel.Size = New System.Drawing.Size(57, 17)
        IdUserLabel.TabIndex = 1
        IdUserLabel.Text = "Id User:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(213, 91)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(61, 17)
        UsuarioLabel.TabIndex = 3
        UsuarioLabel.Text = "Usuario:"
        '
        'NombreUserLabel
        '
        NombreUserLabel.AutoSize = True
        NombreUserLabel.Location = New System.Drawing.Point(213, 119)
        NombreUserLabel.Name = "NombreUserLabel"
        NombreUserLabel.Size = New System.Drawing.Size(62, 17)
        NombreUserLabel.TabIndex = 5
        NombreUserLabel.Text = "Nombre:"
        '
        'NivelLabel
        '
        NivelLabel.AutoSize = True
        NivelLabel.Location = New System.Drawing.Point(231, 144)
        NivelLabel.Name = "NivelLabel"
        NivelLabel.Size = New System.Drawing.Size(43, 17)
        NivelLabel.TabIndex = 7
        NivelLabel.Text = "Nivel:"
        '
        'ContrasenaLabel
        '
        ContrasenaLabel.AutoSize = True
        ContrasenaLabel.Location = New System.Drawing.Point(214, 178)
        ContrasenaLabel.Name = "ContrasenaLabel"
        ContrasenaLabel.Size = New System.Drawing.Size(60, 17)
        ContrasenaLabel.TabIndex = 9
        ContrasenaLabel.Text = "Passwd:"
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
        'IdUserTextBox
        '
        Me.IdUserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "IdUser", True))
        Me.IdUserTextBox.Enabled = False
        Me.IdUserTextBox.Location = New System.Drawing.Point(280, 60)
        Me.IdUserTextBox.Name = "IdUserTextBox"
        Me.IdUserTextBox.Size = New System.Drawing.Size(83, 22)
        Me.IdUserTextBox.TabIndex = 5
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Enabled = False
        Me.UsuarioTextBox.Location = New System.Drawing.Point(280, 88)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(83, 22)
        Me.UsuarioTextBox.TabIndex = 6
        '
        'NombreUserTextBox
        '
        Me.NombreUserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "NombreUser", True))
        Me.NombreUserTextBox.Enabled = False
        Me.NombreUserTextBox.Location = New System.Drawing.Point(280, 116)
        Me.NombreUserTextBox.Name = "NombreUserTextBox"
        Me.NombreUserTextBox.Size = New System.Drawing.Size(83, 22)
        Me.NombreUserTextBox.TabIndex = 7
        '
        'NivelComboBox
        '
        Me.NivelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Nivel", True))
        Me.NivelComboBox.Enabled = False
        Me.NivelComboBox.FormattingEnabled = True
        Me.NivelComboBox.Location = New System.Drawing.Point(280, 144)
        Me.NivelComboBox.Name = "NivelComboBox"
        Me.NivelComboBox.Size = New System.Drawing.Size(83, 24)
        Me.NivelComboBox.TabIndex = 8
        '
        'ContrasenaTextBox
        '
        Me.ContrasenaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Contrasena", True))
        Me.ContrasenaTextBox.Enabled = False
        Me.ContrasenaTextBox.Location = New System.Drawing.Point(280, 175)
        Me.ContrasenaTextBox.Name = "ContrasenaTextBox"
        Me.ContrasenaTextBox.Size = New System.Drawing.Size(83, 22)
        Me.ContrasenaTextBox.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SisRoquinProduce.My.Resources.Resources.Roquin_logo6
        Me.PictureBox1.Location = New System.Drawing.Point(191, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'BIngresar
        '
        Me.BIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BIngresar.Image = CType(resources.GetObject("BIngresar.Image"), System.Drawing.Image)
        Me.BIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BIngresar.Location = New System.Drawing.Point(74, 376)
        Me.BIngresar.Name = "BIngresar"
        Me.BIngresar.Padding = New System.Windows.Forms.Padding(10, 8, 8, 8)
        Me.BIngresar.Size = New System.Drawing.Size(210, 80)
        Me.BIngresar.TabIndex = 3
        Me.BIngresar.Text = "Ingresar"
        Me.BIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BIngresar.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.Location = New System.Drawing.Point(336, 376)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(10, 10, 8, 10)
        Me.BSalir.Size = New System.Drawing.Size(180, 80)
        Me.BSalir.TabIndex = 4
        Me.BSalir.Text = "Salir"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxUsuario.Location = New System.Drawing.Point(314, 250)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(150, 38)
        Me.TextBoxUsuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(175, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 31)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(125, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 31)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Contraseña:"
        '
        'TextBoxPass
        '
        Me.TextBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxPass.Location = New System.Drawing.Point(314, 300)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPass.Size = New System.Drawing.Size(150, 38)
        Me.TextBoxPass.TabIndex = 2
        '
        'FLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(600, 500)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxUsuario)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BIngresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(IdUserLabel)
        Me.Controls.Add(Me.IdUserTextBox)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(NombreUserLabel)
        Me.Controls.Add(Me.NombreUserTextBox)
        Me.Controls.Add(NivelLabel)
        Me.Controls.Add(Me.NivelComboBox)
        Me.Controls.Add(ContrasenaLabel)
        Me.Controls.Add(Me.ContrasenaTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FLogin"
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RoquinDBDataSet As RoquinDBDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As RoquinDBDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As RoquinDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdUserTextBox As TextBox
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents NombreUserTextBox As TextBox
    Friend WithEvents NivelComboBox As ComboBox
    Friend WithEvents ContrasenaTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BIngresar As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPass As TextBox
End Class
