Public Class FAlertQuestion
    Private Sub FAlertQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BNo.Focus()
        Dim opAccion
        opAccion = GlobalVariables.accionForm
        If opAccion = "salirMenu" Then
            LTitle.Text = GlobalVariables.questCloseSistema
        ElseIf opAccion.Text = "cerrarSesion" Then
            LTitle.Text = GlobalVariables.questSalir
        End If
    End Sub

    Private Sub BSi_Click(sender As Object, e As EventArgs) Handles BSi.Click
        'FLogin.Visible = True  ' Abrirá el formulario de login mientras se cierra el menu '
        Me.Close()
        FMenu.Close()
    End Sub

    Private Sub BNo_Click(sender As Object, e As EventArgs) Handles BNo.Click
        Me.Close()
    End Sub
End Class