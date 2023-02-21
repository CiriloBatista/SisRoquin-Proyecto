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
        Dim accion = GlobalVariables.accionForm
        If accion = "borrarRegistroPersonal" Then
            FPersonal.EliminarRegistro()
        ElseIf accion = "borrarRegistroProduccion" Then
            FProduccion.EliminarRegistro()
        ElseIf accion = "borrarRegistroProductor" Then
            FProductores.EliminarRegistro()
        ElseIf accion = "borrarRegistroSector" Then
            FSectores.EliminarRegistro()
        ElseIf accion = "borrarRegistroUsuario" Then
            FUsuarios.EliminarRegistro()
        End If
        Me.Close()
        'FMenu.Close()
    End Sub

    Private Sub BNo_Click(sender As Object, e As EventArgs) Handles BNo.Click
        Me.Close()
    End Sub

End Class