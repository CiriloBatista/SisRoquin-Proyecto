Public Class FAlertErr
    Private Sub FAlertError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BNo.Focus()
        'Dim opAccion
        'opAccion = GlobalVariables.accionForm
        'If opAccion = "borrar" Then
        LTitle.Text = GlobalVariables.borrarRegistro
        'ElseIf opAccion.Text = "cerrarSesion" Then
        'LTitle.Text = GlobalVariables.questSalir
        'End If
    End Sub

    Private Sub BSi_Click(sender As Object, e As EventArgs) Handles BSi.Click
        'PersonalBindingSource.RemoveCurrent()  'Elimina los datos de la tabla de personal'
        'PersonalTableAdapter.Update(RoquinDBDataSet.Personal) 'Actualiza los datos que se ingresaron en este caso se elimina'
        'Me.Close()
        'FMenu.Close()
    End Sub

    Private Sub BNo_Click(sender As Object, e As EventArgs) Handles BNo.Click
        Me.Close()
    End Sub

End Class