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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RoquinDBDataSet = New SisRoquinProduce.RoquinDBDataSet()
        Me.ConsultDetallePersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultDetallePersonalTableAdapter = New SisRoquinProduce.RoquinDBDataSetTableAdapters.ConsultDetallePersonalTableAdapter()
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultDetallePersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.ConsultDetallePersonalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SisRoquinProduce.ReportProd.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1082, 446)
        Me.ReportViewer1.TabIndex = 0
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
        'FRProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FRProduccion"
        Me.Text = "Reporte de Producción"
        CType(Me.RoquinDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultDetallePersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ConsultDetallePersonalBindingSource As BindingSource
    Friend WithEvents RoquinDBDataSet As RoquinDBDataSet
    Friend WithEvents ConsultDetallePersonalTableAdapter As RoquinDBDataSetTableAdapters.ConsultDetallePersonalTableAdapter
End Class
