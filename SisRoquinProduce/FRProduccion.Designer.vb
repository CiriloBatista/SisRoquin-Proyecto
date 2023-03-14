<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRProduccion
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRProduccion))
        Me.ProduccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoquinDBDataSet = New SisRoquinProduce.RoquinDBDataSet()
        Me.ConsultDetallePersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultDetallePersonalTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.ConsultDetallePersonalTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProduccionTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.ProduccionTableAdapter()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TextBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ProduccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultDetallePersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ConsultDetallePersonalBindingSource
        '
        Me.ConsultDetallePersonalBindingSource.DataMember = "ConsultDetallePersonal"
        Me.ConsultDetallePersonalBindingSource.DataSource = Me.RoquinDBDataSet
        '
        'ConsultDetallePersonalTableAdapter
        '
        Me.ConsultDetallePersonalTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ProduccionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SisRoquinProduce.ReportProd.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-2, 61)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1588, 800)
        Me.ReportViewer1.TabIndex = 0
        '
        'ProduccionTableAdapter
        '
        Me.ProduccionTableAdapter.ClearBeforeFill = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BtnBuscar.Location = New System.Drawing.Point(482, 9)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(133, 43)
        Me.BtnBuscar.TabIndex = 1
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TextBuscar
        '
        Me.TextBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TextBuscar.Location = New System.Drawing.Point(290, 9)
        Me.TextBuscar.Name = "TextBuscar"
        Me.TextBuscar.Size = New System.Drawing.Size(157, 41)
        Me.TextBuscar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar por Folio:"
        '
        'FRProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(1582, 953)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBuscar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Producción"
        CType(Me.ProduccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultDetallePersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConsultDetallePersonalBindingSource As BindingSource
    Friend WithEvents RoquinDBDataSet As RoquinDBDataSet
    Friend WithEvents ConsultDetallePersonalTableAdapter As RoquinDBDataSetTableAdapters.ConsultDetallePersonalTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProduccionBindingSource As BindingSource
    Friend WithEvents ProduccionTableAdapter As RoquinDBDataSetTableAdapters.ProduccionTableAdapter
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TextBuscar As TextBox
    Friend WithEvents Label1 As Label
End Class
