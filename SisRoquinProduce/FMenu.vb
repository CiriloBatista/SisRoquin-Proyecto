Public Class FMenu

    'Private Sub FMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'FLogin.Visible = False  ' Ocultará el formulario de login mientras está abierto el menu '
    'End Sub
    'Private Sub FMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    'FLogin.Visible = True   ' Abrirá el formulario de login mientras se cierra el menu '
    'End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        GlobalVariables.accionForm = "salirMenu"
        FAlertQuestion.Show()
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalToolStripMenuItem.Click
        Dim NewMdiChild As New FPersonal 'Se crea una instancia en donde se abrira el form dentro de la ventana del menu'
        NewMdiChild.MdiParent = Me       '
        NewMdiChild.Show()
    End Sub

    Private Sub ProductoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoresToolStripMenuItem.Click
        Dim NewMdiChild As New FProductores 'Se crea una instancia en donde se abrira el form dentro de la ventana del menu'
        NewMdiChild.MdiParent = Me       '
        NewMdiChild.Show()
    End Sub

    Private Sub ProduccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduccionToolStripMenuItem.Click
        Dim NewMdiChild As New FProduccion 'Se crea una instancia en donde se abrira el form dentro de la ventana del menu'
        NewMdiChild.MdiParent = Me       '
        NewMdiChild.Show()
    End Sub

    Private Sub SectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectoresToolStripMenuItem.Click
        Dim NewMdiChild As New FSectores 'Se crea una instancia en donde se abrira el form dentro de la ventana del menu'
        NewMdiChild.MdiParent = Me       '
        NewMdiChild.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim NewMdiChild As New FUsuarios 'Se crea una instancia en donde se abrira el form dentro de la ventana del menu'
        NewMdiChild.MdiParent = Me       '
        NewMdiChild.Show()
    End Sub

End Class