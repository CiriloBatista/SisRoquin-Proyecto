<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAlertQuestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAlertQuestion))
        Me.BNo = New System.Windows.Forms.Button()
        Me.BSi = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LTitle = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BNo
        '
        Me.BNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BNo.BackColor = System.Drawing.Color.White
        Me.BNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BNo.ForeColor = System.Drawing.Color.Black
        Me.BNo.Location = New System.Drawing.Point(218, 293)
        Me.BNo.Name = "BNo"
        Me.BNo.Size = New System.Drawing.Size(120, 50)
        Me.BNo.TabIndex = 7
        Me.BNo.Text = "No"
        Me.BNo.UseVisualStyleBackColor = False
        '
        'BSi
        '
        Me.BSi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSi.BackColor = System.Drawing.Color.White
        Me.BSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BSi.ForeColor = System.Drawing.Color.Black
        Me.BSi.Location = New System.Drawing.Point(57, 293)
        Me.BSi.Name = "BSi"
        Me.BSi.Size = New System.Drawing.Size(120, 50)
        Me.BSi.TabIndex = 6
        Me.BSi.Text = "Sí"
        Me.BSi.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(150, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LTitle
        '
        Me.LTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LTitle.AutoSize = True
        Me.LTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LTitle.Location = New System.Drawing.Point(30, 210)
        Me.LTitle.MaximumSize = New System.Drawing.Size(350, 100)
        Me.LTitle.MinimumSize = New System.Drawing.Size(300, 20)
        Me.LTitle.Name = "LTitle"
        Me.LTitle.Size = New System.Drawing.Size(300, 29)
        Me.LTitle.TabIndex = 8
        Me.LTitle.Text = "texto"
        Me.LTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FAlertQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.Add(Me.LTitle)
        Me.Controls.Add(Me.BNo)
        Me.Controls.Add(Me.BSi)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FAlertQuestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FAlertQuestion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BNo As Button
    Friend WithEvents BSi As Button
    Friend WithEvents LTitle As Label
End Class
