Public Class FSectores
    Private Sub SectoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SectoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RoquinDBDataSet)

    End Sub

    Private Sub FSectores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.Sectores' Puede moverla o quitarla según sea necesario.
        Actualiza()
        DesBlock()
    End Sub

    Public Sub Actualiza()
        Try 'Es una funcion que nos ayuda a controlar que no caiga el sistema'
            Me.SectoresTableAdapter.Fill(Me.RoquinDBDataSet.Sectores) 'Actualiza el los datos de la tabla'
        Catch ex As Exception
            GlobalVariables.accionForm = "falloConexion"
            FAlertInfo.Show()
        End Try
    End Sub

    Private Sub Block()
        SectoresDataGridView.Enabled = False
        BNuevo.Visible = False
        BEditar.Visible = False
        BEliminar.Visible = False
        BGuardar.Visible = True
        BCancelar.Visible = True
        NumSectorTextBox.Enabled = True
        NombreSecTextBox.Enabled = True
    End Sub
    Private Sub DesBlock()
        SectoresDataGridView.Enabled = True
        BNuevo.Visible = True
        BEditar.Visible = True
        BEliminar.Visible = True
        BGuardar.Visible = False
        BCancelar.Visible = False
        NumSectorTextBox.Enabled = False
        NombreSecTextBox.Enabled = False
    End Sub

    Function Completo() As Boolean 'Valida que no esté vacío'
        If NumSectorTextBox.Text = Nothing Then
            Return False
        End If
        Return True
    End Function

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        SectoresBindingSource.AddNew() 'Se selecciona la tabla a la que haremos referencia y añadimos una nueva fila'
        Block()
        NumSectorTextBox.Focus()     'Apuntaremos a la caja de texto de ID_Personal'
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        SectoresBindingSource.CancelEdit() 'Se selecciona la tabla a la que haremos referencia y ponemos para cancelar'
        DesBlock()
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        Block()
        BCancelar.Visible = True
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If Completo() Then
            Try
                SectoresBindingSource.EndEdit()  'Termina de guardar los datos que se ingresaron en la tabla'
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
        GlobalVariables.accionForm = "borrarRegistroSector"
        FAlertErr.Show()
    End Sub

    Public Sub EliminarRegistro()
        Try
            SectoresBindingSource.RemoveCurrent()  'Elimina los datos de la tabla de personal'
            SectoresTableAdapter.Update(RoquinDBDataSet.Sectores) 'Actualiza los datos que se ingresaron en este caso se elimina'
            Actualiza()
        Catch ex As Exception
            GlobalVariables.accionForm = "falloEliminar"
            FAlertInfo.Show()
        End Try
    End Sub

    Private Sub NumSectorTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumSectorTextBox.KeyPress
        e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub NombreSecTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreSecTextBox.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

End Class