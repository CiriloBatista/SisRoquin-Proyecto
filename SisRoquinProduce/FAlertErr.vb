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
        GlobalVariables.autorizar = "autorizar"
        FLogin.Show()
        Me.Close()
    End Sub

    Private Sub BNo_Click(sender As Object, e As EventArgs) Handles BNo.Click
        Me.Close()
    End Sub

End Class