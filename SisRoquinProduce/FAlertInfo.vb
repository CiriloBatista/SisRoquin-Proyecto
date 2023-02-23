Public Class FAlertInfo

    Dim opAccion
    Private Sub FAlertInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opAccion = GlobalVariables.accionForm
        If opAccion = "falloConexion" Then
            LTitle.Text = GlobalVariables.falloConexion
        ElseIf opAccion = "falloGuardar" Then
            LTitle.Text = GlobalVariables.falloGuardar
        ElseIf opAccion = "falloEliminar" Then
            LTitle.Text = GlobalVariables.falloEliminar
        ElseIf opAccion = "falloVacio" Then
            LTitle.Text = GlobalVariables.falloVacio
        ElseIf opAccion = "bienvenido" Then
            LTitle.Text = GlobalVariables.bienvenido
        ElseIf opAccion = "falloUsuarioVacio" Then
            LTitle.Text = GlobalVariables.falloUsuarioVacio
        ElseIf opAccion = "datosMal" Then
            LTitle.Text = GlobalVariables.datosMal
        End If

    End Sub
    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        Me.Close()
        If opAccion = "bienvenido" Then
            FMenu.Show()
        End If
    End Sub

End Class