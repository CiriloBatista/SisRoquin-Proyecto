Public Class FProductores
    Private Sub ProductoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RoquinDBDataSet)

    End Sub

    Private Sub FProductores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.Productores' Puede moverla o quitarla según sea necesario.
        Me.ProductoresTableAdapter.Fill(Me.RoquinDBDataSet.Productores)
        DesBlock()
        Actualiza()
    End Sub

    Public Sub Actualiza()
        Try 'Es una funcion que nos ayuda a controlar que no caiga el sistema'
            Me.ProductoresTableAdapter.Fill(Me.RoquinDBDataSet.Productores) 'Actualiza el los datos de la tabla'
        Catch ex As Exception
            MsgBox("Fallo la conexión", vbCritical)
        End Try
    End Sub

    Private Sub Block()
        ProductoresDataGridView.Enabled = False
        BNuevo.Visible = False
        BEditar.Visible = False
        BEliminar.Visible = False
        BGuardar.Visible = True
        BCancelar.Visible = True
        IdProductorTextBox.Enabled = True
        NumProductorTextBox.Enabled = True
        NombreTextBox.Enabled = True
        TelefonoTextBox.Enabled = True
    End Sub
    Private Sub DesBlock()
        ProductoresDataGridView.Enabled = True
        BNuevo.Visible = True
        BEditar.Visible = True
        BEliminar.Visible = True
        BGuardar.Visible = False
        BCancelar.Visible = False
        IdProductorTextBox.Enabled = False
        NumProductorTextBox.Enabled = False
        NombreTextBox.Enabled = False
        TelefonoTextBox.Enabled = False
    End Sub

    Function Completo() As Boolean 'Valida que no esté vacío'
        If NumProductorTextBox.Text = Nothing Then
            Return False
        End If
        Return True
    End Function

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        ProductoresBindingSource.AddNew() 'Se selecciona la tabla a la que haremos referencia y añadimos una nueva fila'
        Block()
        NumProductorTextBox.Focus()     'Apuntaremos a la caja de texto de ID_Personal'
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        ProductoresBindingSource.CancelEdit() 'Se selecciona la tabla a la que haremos referencia y ponemos para cancelar'
        DesBlock()
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        Block()
        BCancelar.Visible = True
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If Completo() Then
            Try
                ProductoresBindingSource.EndEdit()  'Termina de guardar los datos que se ingresaron en la tabla'
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
        GlobalVariables.accionForm = "borrarRegistroProductor"
        FAlertErr.Show()
    End Sub

    Public Sub EliminarRegistro()
        Try
            ProductoresBindingSource.RemoveCurrent()  'Elimina los datos de la tabla de personal'
            ProductoresTableAdapter.Update(RoquinDBDataSet.Productores) 'Actualiza los datos que se ingresaron en este caso se elimina'
            Actualiza()
        Catch ex As Exception
            GlobalVariables.accionForm = "falloEliminar"
            FAlertInfo.Show()
        End Try
    End Sub

    Private Sub NumProductorTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumProductorTextBox.KeyPress
        e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub NombreTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreTextBox.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub TelefonoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelefonoTextBox.KeyPress
        e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub TextBoxBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxBuscar.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click 'Boton de busqueda por nombre productor'
        If TextBoxBuscar.Text <> "" Then
            Me.ProductoresTableAdapter.FillByNomProd(Me.RoquinDBDataSet.Productores, Val(TextBoxBuscar.Text))
        Else
            Me.ProductoresTableAdapter.Fill(Me.RoquinDBDataSet.Productores)
        End If
    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged

    End Sub
End Class