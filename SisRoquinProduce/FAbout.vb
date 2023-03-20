Public Class FAbout
    Private Sub FAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BAceptar.Focus()
    End Sub

    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        Me.Close()
    End Sub
End Class