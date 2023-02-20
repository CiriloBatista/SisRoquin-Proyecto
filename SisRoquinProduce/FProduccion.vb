Public Class FProduccion
    Private Sub ProduccionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProduccionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RoquinDBDataSet)

    End Sub

    Private Sub FProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NombreComboBox.Focus()
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.Sectores' Puede moverla o quitarla según sea necesario.
        Me.SectoresTableAdapter.Fill(Me.RoquinDBDataSet.Sectores)
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.ConsultDetallePersonal' Puede moverla o quitarla según sea necesario.
        Me.ConsultDetallePersonalTableAdapter.Fill(Me.RoquinDBDataSet.ConsultDetallePersonal)
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.Productores' Puede moverla o quitarla según sea necesario.
        Me.ProductoresTableAdapter.Fill(Me.RoquinDBDataSet.Productores)
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.Produccion' Puede moverla o quitarla según sea necesario.
        Actualiza()

    End Sub

    Private Sub Actualiza()
        Try 'Es una funcion que nos ayuda a controlar que no caiga el sistema'
            Me.ProduccionTableAdapter.Fill(Me.RoquinDBDataSet.Produccion) 'Actualiza el los datos de la tabla'
        Catch ex As Exception
            MsgBox("Fallo la conexion", vbCritical)
        End Try
    End Sub

    Private Sub Block()
        ProduccionDataGridView.Enabled = False
        BNuevo.Visible = False
        BEliminar.Visible = False
        FolioTextBox.Enabled = True
    End Sub
    Private Sub DesBlock()
        ProduccionDataGridView.Enabled = True
        BNuevo.Visible = True
        BEliminar.Visible = True
        FolioTextBox.Enabled = False
    End Sub

    Function Completo() As Boolean 'Valida que no esté vacío'
        If FolioTextBox.Text = Nothing Then
            Return False
        End If
        Return True
    End Function

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        ProduccionBindingSource.AddNew() 'Se selecciona la tabla a la que haremos referencia y añadimos una nueva fila'
        FolioTextBox.Focus()     'Apuntaremos a la caja de texto de ID_Personal'
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        ProduccionBindingSource.CancelEdit() 'Se selecciona la tabla a la que haremos referencia y ponemos para cancelar'
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If Completo() Then
            Try
                ProduccionBindingSource.EndEdit()  'Termina de guardar los datos que se ingresaron en la tabla'
                TableAdapterManager.UpdateAll(Me.RoquinDBDataSet) 'Actualiza los datos ingresados'
                Actualiza()
            Catch ex As Exception
                MsgBox("Fallo al tratar de Guardar", vbCritical)
            End Try
        Else
            MsgBox("Aún hay campos vacíos!", vbCritical)
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim OpBorra
        OpBorra = MsgBox("¿Borrar el registro?", vbCritical + vbYesNo, "A T E N C I O N") 'Cuadro de texto de pregunta a usuario '
        If OpBorra = vbYes Then
            Try
                ProduccionBindingSource.RemoveCurrent()  'Elimina los datos de la tabla de personal'
                ProduccionTableAdapter.Update(RoquinDBDataSet.Produccion) 'Actualiza los datos que se ingresaron en este caso se elimina'
                Actualiza()
            Catch ex As Exception
                MsgBox("Fallo al tratar de Eliminar", vbCritical)
            End Try
        End If
    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NombreComboBox.SelectedIndexChanged
        NumProdTextBox.Text = NombreComboBox.SelectedValue 'Indica que se haga el cambio al mismo tiempo en el otro textbox
    End Sub

    Private Sub NombreSecComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        NumSectorTextBox.Text = NombreSecComboBox.SelectedValue 'Indica que se haga el cambio al mismo tiempo en el otro textbox
    End Sub

End Class