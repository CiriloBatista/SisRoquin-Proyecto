Public Class FRProduccion
    Private Sub FRProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.Produccion' Puede moverla o quitarla según sea necesario.
        Me.ProduccionTableAdapter.Fill(Me.RoquinDBDataSet.Produccion)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TextBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBuscar.KeyPress
        e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click 'Boton de busqueda por folio'
        If TextBuscar.Text <> "" Then
            Me.ProduccionTableAdapter.FillByFolio(Me.RoquinDBDataSet.Produccion, Val(TextBuscar.Text))
            Me.ReportViewer1.RefreshReport()
        Else
            Me.ProduccionTableAdapter.Fill(Me.RoquinDBDataSet.Produccion)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

End Class