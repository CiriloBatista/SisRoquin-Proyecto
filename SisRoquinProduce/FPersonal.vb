Public Class FPersonal

    Private Sub PersonalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PersonalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RoquinDBDataSet)

    End Sub

    Private Sub FPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.Personal' Puede moverla o quitarla según sea necesario.
        DesBlock()
        If GlobalVariables.accionForm = "borrarRegistro" Then
            Try
                PersonalBindingSource.RemoveCurrent()  'Elimina los datos de la tabla de personal'
                PersonalTableAdapter.Update(RoquinDBDataSet.Personal) 'Actualiza los datos que se ingresaron en este caso se elimina'
                Actualiza()
            Catch ex As Exception
                GlobalVariables.accionForm = "falloEliminar"
                FAlertInfo.Show()
            End Try
        End If
        Actualiza()
    End Sub
    Public Sub Actualiza()
        Try 'Es una funcion que nos ayuda a controlar que no caiga el sistema'
            Me.PersonalTableAdapter.Fill(Me.RoquinDBDataSet.Personal) 'Actualiza el los datos de la tabla'
        Catch ex As Exception
            GlobalVariables.accionForm = "falloConexion"
            FAlertInfo.Show()
        End Try
    End Sub

    Private Sub Block() 'Bloquea el DataGrid para no cometer errores al ingresar datos
        PersonalDataGridView.Enabled = False
        BNuevo.Visible = False
        BEditar.Visible = False
        BEliminar.Visible = False
        BGuardar.Visible = True
        BCancelar.Visible = True
        NumEmpleadoTextBox.Enabled = True
        NombreEmpleadoTextBox.Enabled = True
        ApellidosEmpTextBox.Enabled = True
        PuestoTextBox.Enabled = True
        TextBoxBuscar.Enabled = False
        BBuscar.Enabled = False
    End Sub
    Private Sub DesBlock() 'Desbloquea el DataGrid para consultar y navegar dentro
        PersonalDataGridView.Enabled = True
        BNuevo.Visible = True
        BEditar.Visible = True
        BEliminar.Visible = True
        BGuardar.Visible = False
        BCancelar.Visible = False
        NumEmpleadoTextBox.Enabled = False
        NombreEmpleadoTextBox.Enabled = False
        ApellidosEmpTextBox.Enabled = False
        PuestoTextBox.Enabled = False
        TextBoxBuscar.Enabled = True
        BBuscar.Enabled = True
    End Sub

    Function Completo() As Boolean 'Valida que no esté vacío'
        If NumEmpleadoTextBox.Text = Nothing Then
            Return False
        End If
        Return True
    End Function

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        PersonalBindingSource.AddNew() 'Se selecciona la tabla a la que haremos referencia y añadimos una nueva fila'
        Block()
        BEditar.Visible = False
        BCancelar.Visible = True
        NumEmpleadoTextBox.Enabled = True
        NumEmpleadoTextBox.Focus()     'Apuntaremos a la caja de texto de ID_Personal'
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        PersonalBindingSource.CancelEdit() 'Se selecciona la tabla a la que haremos referencia y ponemos para cancelar'
        DesBlock()
        NumEmpleadoTextBox.Enabled = True
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        Block()
        BCancelar.Visible = True
        NumEmpleadoTextBox.Enabled = False
        NombreEmpleadoTextBox.Focus()
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If Completo() Then
            Try
                PersonalBindingSource.EndEdit()  'Termina de guardar los datos que se ingresaron en la tabla'
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

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click 'Funcion de prueba ¡No se debe eliminar ningún dato!
        GlobalVariables.accionForm = "borrarRegistroPersonal"
        FAlertErr.Show()
    End Sub

    Public Sub EliminarRegistro()
        Try
            PersonalBindingSource.RemoveCurrent()  'Elimina los datos de la tabla de personal'
            PersonalTableAdapter.Update(RoquinDBDataSet.Personal) 'Actualiza los datos que se ingresaron en este caso se elimina'
            Actualiza()
        Catch ex As Exception
            GlobalVariables.accionForm = "falloEliminar"
            FAlertInfo.Show()
        End Try
    End Sub

    Private Sub NumEmpleadoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumEmpleadoTextBox.KeyPress
        e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub NombreEmpleadoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreEmpleadoTextBox.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub ApellidosEmpTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ApellidosEmpTextBox.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub PuestoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PuestoTextBox.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub


    Private Sub TextBoxBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxBuscar.KeyPress
        e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click 'Boton de busqueda por folio'
        If TextBoxBuscar.Text <> "" Then
            Me.PersonalTableAdapter.FillByNumPersonal(Me.RoquinDBDataSet.Personal, Val(TextBoxBuscar.Text))
        Else
            Me.PersonalTableAdapter.Fill(Me.RoquinDBDataSet.Personal)
        End If
    End Sub

    Private Sub NumEmpleadoTextBox_TextChanged(sender As Object, e As EventArgs) Handles NumEmpleadoTextBox.TextChanged

    End Sub
End Class
