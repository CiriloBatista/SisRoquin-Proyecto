Public Class FAlertInfo
    Private Sub FAlertInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim opAccion
        opAccion = GlobalVariables.accionForm
        If opAccion = "falloConexion" Then
            LTitle.Text = GlobalVariables.falloConexion
        ElseIf opAccion.Text = "falloGuardar" Then
            LTitle.Text = GlobalVariables.falloGuardar
        ElseIf opAccion.Text = "falloEliminar" Then
            LTitle.Text = GlobalVariables.falloEliminar
        ElseIf opAccion.Text = "falloVacio" Then
            LTitle.Text = GlobalVariables.falloVacio
        ElseIf opAccion.Text = "bienvenido" Then
            LTitle.Text = GlobalVariables.bienvenido
        End If

    End Sub
    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        Me.Close()
    End Sub
End Class