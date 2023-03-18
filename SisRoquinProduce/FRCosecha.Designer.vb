<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRCosecha
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRCosecha))
        Me.ConsultDetallePersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoquinDBDataSet = New SisRoquinProduce.RoquinDBDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ConsultDetallePersonalTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.ConsultDetallePersonalTableAdapter()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TextBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ConsultDetallePersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsultDetallePersonalBindingSource
        '
        Me.ConsultDetallePersonalBindingSource.DataMember = "ConsultDetallePersonal"
        Me.ConsultDetallePersonalBindingSource.DataSource = Me.RoquinDBDataSet
        '
        'RoquinDBDataSet
        '
        Me.RoquinDBDataSet.DataSetName = "RoquinDBDataSet"
        Me.RoquinDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ConsultDetallePersonalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SisRoquinProduce.ReportCose.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 59)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1285, 692)
        Me.ReportViewer1.TabIndex = 0
        '
        'ConsultDetallePersonalTableAdapter
        '
        Me.ConsultDetallePersonalTableAdapter.ClearBeforeFill = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BtnBuscar.Location = New System.Drawing.Point(588, 6)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(135, 42)
        Me.BtnBuscar.TabIndex = 1
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TextBuscar
        '
        Me.TextBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TextBuscar.Location = New System.Drawing.Point(356, 7)
        Me.TextBuscar.Name = "TextBuscar"
        Me.TextBuscar.Size = New System.Drawing.Size(209, 41)
        Me.TextBuscar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar por Personal:"
        '
        'FRCosecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(1282, 753)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBuscar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRCosecha"
        Me.Text = "Reporte de Cosechas"
        CType(Me.ConsultDetallePersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ConsultDetallePersonalBindingSource As BindingSource
    Friend WithEvents RoquinDBDataSet As RoquinDBDataSet
    Friend WithEvents ConsultDetallePersonalTableAdapter As RoquinDBDataSetTableAdapters.ConsultDetallePersonalTableAdapter
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TextBuscar As TextBox
    Friend WithEvents Label1 As Label
End Class
