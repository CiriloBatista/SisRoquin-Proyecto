Public Class FLogin

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RoquinDBDataSet)

    End Sub

    Private Sub FLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.RoquinDBDataSet.Usuarios)
        TextBoxUsuario.Focus()
        Actualiza()
    End Sub

    Public Sub Actualiza()
        Try 'Es una funcion que nos ayuda a controlar que no caiga el sistema'
            Me.UsuariosTableAdapter.Fill(Me.RoquinDBDataSet.Usuarios) 'Actualiza el los datos de la tabla'
        Catch ex As Exception
            GlobalVariables.accionForm = "falloConexion"
            FAlertInfo.Show()
            TextBoxUsuario.Focus()
        End Try
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        GlobalVariables.accionForm = "questSalir"
        FAlertQuestion.Show()
    End Sub

    Private Sub BIngresar_Click(sender As Object, e As EventArgs) Handles BIngresar.Click
        Busca()
    End Sub

    Private Sub Busca()
        If TextBoxUsuario.Text <> "" And TextBoxPass.Text <> "" Then
            Me.UsuariosTableAdapter.Fill(Me.RoquinDBDataSet.Usuarios) 'Actualiza el los datos de la tabla'
            Compara()
        Else
            GlobalVariables.accionForm = "falloVacio"
            FAlertInfo.Show()
        End If
    End Sub

    Private Sub Compara()
        If TextBoxUsuario.Text = "" Then
            GlobalVariables.accionForm = "falloUsuarioVacio"
            FAlertInfo.Show()
        ElseIf TextBoxPass.Text = ContrasenaTextBox.Text Then
            GlobalVariables.accionForm = "bienvenido"
            FAlertInfo.Show()
            IdUsr = IdUserTextBox.Text
            User = UsuarioTextBox.Text
            Niv = NivelComboBox.Text
            TextBoxUsuario.Text = ""
            TextBoxPass.Text = ""
        Else
            GlobalVariables.accionForm = "datosMal"
            FAlertInfo.Show()
        End If
    End Sub

    Private Sub FLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Enter Then
            Busca()
        End If
    End Sub

    Private Sub TextBoxUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxUsuario.KeyDown
        If e.KeyData = Keys.Enter Then
            TextBoxPass.Focus()
        End If
    End Sub
    Private Sub TextBoxPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPass.KeyDown
        If e.KeyData = Keys.Enter Then
            Busca()
        End If
    End Sub
End Class