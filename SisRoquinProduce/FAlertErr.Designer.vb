<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAlertErr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAlertErr))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BSi = New System.Windows.Forms.Button()
        Me.BNo = New System.Windows.Forms.Button()
        Me.LTitle = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(140, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 48)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "¡ A t e n c i ó n !"
        '
        'BSi
        '
        Me.BSi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSi.BackColor = System.Drawing.Color.White
        Me.BSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BSi.ForeColor = System.Drawing.Color.Black
        Me.BSi.Location = New System.Drawing.Point(56, 303)
        Me.BSi.Name = "BSi"
        Me.BSi.Size = New System.Drawing.Size(120, 50)
        Me.BSi.TabIndex = 4
        Me.BSi.Text = "Sí"
        Me.BSi.UseVisualStyleBackColor = False
        '
        'BNo
        '
        Me.BNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BNo.BackColor = System.Drawing.Color.White
        Me.BNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BNo.ForeColor = System.Drawing.Color.Black
        Me.BNo.Location = New System.Drawing.Point(217, 303)
        Me.BNo.Name = "BNo"
        Me.BNo.Size = New System.Drawing.Size(120, 50)
        Me.BNo.TabIndex = 5
        Me.BNo.Text = "No"
        Me.BNo.UseVisualStyleBackColor = False
        '
        'LTitle
        '
        Me.LTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LTitle.AutoSize = True
        Me.LTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LTitle.ForeColor = System.Drawing.Color.White
        Me.LTitle.Location = New System.Drawing.Point(51, 235)
        Me.LTitle.MaximumSize = New System.Drawing.Size(350, 100)
        Me.LTitle.MinimumSize = New System.Drawing.Size(300, 20)
        Me.LTitle.Name = "LTitle"
        Me.LTitle.Size = New System.Drawing.Size(300, 29)
        Me.LTitle.TabIndex = 9
        Me.LTitle.Text = "texto"
        Me.LTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FAlertErr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.Add(Me.LTitle)
        Me.Controls.Add(Me.BNo)
        Me.Controls.Add(Me.BSi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FAlertErr"
        Me.Text = "FAlertError"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BSi As Button
    Friend WithEvents BNo As Button
    Friend WithEvents LTitle As Label
End Class
