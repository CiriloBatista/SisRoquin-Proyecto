Public Class FUsuarios
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RoquinDBDataSet)

    End Sub

    Private Sub FUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Actualiza()
        DesBlock()
    End Sub

    Public Sub Actualiza()
        Try 'Es una funcion que nos ayuda a controlar que no caiga el sistema'
            Me.UsuariosTableAdapter.Fill(Me.RoquinDBDataSet.Usuarios) 'Actualiza el los datos de la tabla'
        Catch ex As Exception
            GlobalVariables.accionForm = "falloConexion"
            FAlertInfo.Show()
        End Try
    End Sub

    Private Sub Block()
        UsuariosDataGridView.Enabled = False
        BNuevo.Visible = False
        BEditar.Visible = False
        BEliminar.Visible = False
        BGuardar.Visible = True
        BCancelar.Visible = True
        UsuarioTextBox.Enabled = True
        NombreUserTextBox.Enabled = True
        ContrasenaTextBox.Enabled = True
        NivelComboBox.Enabled = True
    End Sub
    Private Sub DesBlock()
        UsuariosDataGridView.Enabled = True
        BNuevo.Visible = True
        BEditar.Visible = True
        BEliminar.Visible = True
        BGuardar.Visible = False
        BCancelar.Visible = False
        UsuarioTextBox.Enabled = False
        NombreUserTextBox.Enabled = False
        ContrasenaTextBox.Enabled = False
        NivelComboBox.Enabled = False
    End Sub

    Function Completo() As Boolean 'Valida que no esté vacío'
        If UsuarioTextBox.Text = Nothing Then
            Return False
        End If
        Return True
    End Function

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        UsuariosBindingSource.AddNew() 'Se selecciona la tabla a la que haremos referencia y añadimos una nueva fila'
        Block()
        UsuarioTextBox.Focus()     'Apuntaremos a la caja de texto de ID_Personal'
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        UsuariosBindingSource.CancelEdit() 'Se selecciona la tabla a la que haremos referencia y ponemos para cancelar'
        DesBlock()
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        Block()
        BCancelar.Visible = True
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If Completo() Then
            Try
                UsuariosBindingSource.EndEdit()  'Termina de guardar los datos que se ingresaron en la tabla'
                TableAdapterManager.UpdateAll(Me.RoquinDBDataSet) 'Actualiza los datos ingresados'
                Actualiza()
                DesBlock()
            Catch ex As Exception
                GlobalVariables.accionForm = "falloGuardar"
                FAlertInfo.Show()
                Block()
            End Try
        Else
            GlobalVariables.accionForm = "falloVacio"
            FAlertInfo.Show()
            Block()
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        GlobalVariables.accionForm = "borrarRegistroUsuario"
        FAlertErr.Show()
    End Sub

    Public Sub EliminarRegistro()
        Try
            UsuariosBindingSource.RemoveCurrent()  'Elimina los datos de la tabla de personal'
            UsuariosTableAdapter.Update(RoquinDBDataSet.Usuarios) 'Actualiza los datos que se ingresaron en este caso se elimina'
            Actualiza()
        Catch ex As Exception
            GlobalVariables.accionForm = "falloEliminar"
            FAlertInfo.Show()
        End Try
    End Sub

    Private Sub UsuarioTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsuarioTextBox.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub NombreUserTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreUserTextBox.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub ContrasenaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContrasenaTextBox.KeyPress
        e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    'Private Sub TextBoxBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxBuscar.KeyPress
    '   e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    'End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click 'Boton de busqueda por folio'
        If TextBoxBuscar.Text <> "" Then
            Me.UsuariosTableAdapter.FillByUser(Me.RoquinDBDataSet.Usuarios, TextBoxBuscar.Text)
        Else
            Me.UsuariosTableAdapter.Fill(Me.RoquinDBDataSet.Usuarios)
        End If
    End Sub

End Class