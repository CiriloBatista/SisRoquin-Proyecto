Public Class FRCosecha
    Private Sub FRCosecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.ConsultDetallePersonal' Puede moverla o quitarla según sea necesario.
        Me.ConsultDetallePersonalTableAdapter.Fill(Me.RoquinDBDataSet.ConsultDetallePersonal)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class