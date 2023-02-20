Public Class FPersonal

    Private Sub PersonalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PersonalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RoquinDBDataSet)

    End Sub

    Private Sub FPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.Personal' Puede moverla o quitarla según sea necesario.
        DesBlock()
        Actualiza()
    End Sub
    Private Sub Actualiza()
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
        BEliminar.Visible = False
        NumEmpleadoTextBox.Enabled = True
        NombreEmpleadoTextBox.Enabled = True
        ApellidosEmpTextBox.Enabled = True
        PuestoTextBox.Enabled = True
    End Sub
    Private Sub DesBlock() 'Desbloquea el DataGrid para consultar y navegar dentro
        PersonalDataGridView.Enabled = True
        BNuevo.Visible = True
        BEliminar.Visible = True
        NumEmpleadoTextBox.Enabled = False
        NombreEmpleadoTextBox.Enabled = False
        ApellidosEmpTextBox.Enabled = False
        PuestoTextBox.Enabled = False
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
        NumEmpleadoTextBox.Focus()     'Apuntaremos a la caja de texto de ID_Personal'
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        PersonalBindingSource.CancelEdit() 'Se selecciona la tabla a la que haremos referencia y ponemos para cancelar'
        DesBlock()
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
        Dim OpBorra
        OpBorra = MsgBox("¿Borrar el registro?", vbCritical + vbYesNo, "A T E N C I O N") 'Cuadro de texto de pregunta a usuario '
        If OpBorra = vbYes Then
            Try
                PersonalBindingSource.RemoveCurrent()  'Elimina los datos de la tabla de personal'
                PersonalTableAdapter.Update(RoquinDBDataSet.Personal) 'Actualiza los datos que se ingresaron en este caso se elimina'
                Actualiza()
            Catch ex As Exception
                GlobalVariables.accionForm = "falloEliminar"
                FAlertInfo.Show()
            End Try
        End If
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
End Class
