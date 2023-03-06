Public Class FProduccion

    Dim Col, Ren
    Private Sub ProduccionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProduccionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RoquinDBDataSet)

    End Sub

    Private Sub FProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.ConsultDetallePersonal' Puede moverla o quitarla según sea necesario.
        Me.ConsultDetallePersonalTableAdapter.Fill(Me.RoquinDBDataSet.ConsultDetallePersonal)
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.DetalleFolio' Puede moverla o quitarla según sea necesario.
        Me.DetalleFolioTableAdapter.Fill(Me.RoquinDBDataSet.DetalleFolio)
        DataGridDetalle.Focus()
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.Personal' Puede moverla o quitarla según sea necesario.
        Me.PersonalTableAdapter.Fill(Me.RoquinDBDataSet.Personal)
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.Sectores' Puede moverla o quitarla según sea necesario.
        Me.SectoresTableAdapter.Fill(Me.RoquinDBDataSet.Sectores)
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.ConsultDetallePersonal' Puede moverla o quitarla según sea necesario.
        Me.ConsultDetallePersonalTableAdapter.Fill(Me.RoquinDBDataSet.ConsultDetallePersonal)
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.Productores' Puede moverla o quitarla según sea necesario.
        Me.ProductoresTableAdapter.Fill(Me.RoquinDBDataSet.Productores)
        'TODO: esta línea de código carga datos en la tabla 'RoquinDBDataSet.Produccion' Puede moverla o quitarla según sea necesario.
        ProduccionDataGridView.Enabled = True
        ConsultDetallePersonalDataGridView.Enabled = True
        DesBlock()
        Actualiza()
    End Sub

    Public Sub Actualiza()
        Try 'Es una funcion que nos ayuda a controlar que no caiga el sistema'
            Me.ProduccionTableAdapter.Fill(Me.RoquinDBDataSet.Produccion) 'Actualiza el los datos de la tabla'
            Me.ConsultDetallePersonalTableAdapter.Fill(Me.RoquinDBDataSet.ConsultDetallePersonal)
        Catch ex As Exception
            MsgBox("Fallo la conexion", vbCritical)
        End Try
    End Sub

    Private Sub Block()
        BNuevo.Visible = False
        BEditar.Visible = False
        BEliminar.Visible = False
        BGuardar.Visible = True
        BCancelar.Visible = True
        LabelRegFolio.Visible = True
        FolioTextBox.Enabled = True
        FechaProdDateTimePicker.Enabled = True
        NumProdTextBox.Enabled = True
        NombreComboBox.Enabled = True
        CodigoTextBox.Enabled = True
        HuertoTextBox.Enabled = True
        TemporadaTextBox.Enabled = True
        CajasTextBox.Enabled = True
        KilosTextBox.Enabled = True
        NumSectorTextBox.Enabled = True
        NombreSecComboBox.Enabled = True
        EmbalajeComboBox.Enabled = True
        VariedadComboBox.Enabled = True
        KGCampoTextBox.Enabled = True
        GaleraTextBox.Enabled = True
        ClamshellTextBox.Enabled = True
        CubetasSinEmpTextBox.Enabled = True
        DiasCorteTextBox.Enabled = True
        DefectoTextBox.Enabled = True
        TotCubetasTextBox.Enabled = True
        CortesiasTextBox.Enabled = True
        EncargadoTextBox.Enabled = True
    End Sub
    Private Sub DesBlock()
        BNuevo.Visible = True
        BEditar.Visible = True
        BEliminar.Visible = True
        BGuardar.Visible = False
        BCancelar.Visible = False
        LabelRegFolio.Visible = False
        FolioTextBox.Enabled = False
        FechaProdDateTimePicker.Enabled = False
        NumProdTextBox.Enabled = False
        NombreComboBox.Enabled = False
        CodigoTextBox.Enabled = False
        HuertoTextBox.Enabled = False
        TemporadaTextBox.Enabled = False
        CajasTextBox.Enabled = False
        KilosTextBox.Enabled = False
        NumSectorTextBox.Enabled = False
        NombreSecComboBox.Enabled = False
        EmbalajeComboBox.Enabled = False
        VariedadComboBox.Enabled = False
        KGCampoTextBox.Enabled = False
        GaleraTextBox.Enabled = False
        ClamshellTextBox.Enabled = False
        CubetasSinEmpTextBox.Enabled = False
        DiasCorteTextBox.Enabled = False
        DefectoTextBox.Enabled = False
        TotCubetasTextBox.Enabled = False
        CortesiasTextBox.Enabled = False
        EncargadoTextBox.Enabled = False
    End Sub

    Function Completo() As Boolean 'Valida que no esté vacío'
        If FolioTextBox.Text = Nothing Then
            Return False
        End If
        Return True
    End Function

    Dim ValLblList As Point
    Dim ValProdDGV As Point
    Dim ValTxBus As Point
    Dim ValBtnBus As Point
    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        ProduccionBindingSource.AddNew() 'Se selecciona la tabla a la que haremos referencia y añadimos una nueva fila'
        FolioTextBox.Focus()     'Apuntaremos a la caja de texto de ID_Personal'
        Block()
        ProduccionDataGridView.Enabled = False
        ValLblList = LabelListadoFolios.Location
        ValProdDGV = ProduccionDataGridView.Location
        ValTxBus = TextBoxBuscar.Location
        ValBtnBus = BBuscar.Location
        LabelListadoFolios.Location = New Point(700, 160)
        ProduccionDataGridView.Location = New Point(700, 200)
        TextBoxBuscar.Location = New Point(1135, 158)
        BBuscar.Location = New Point(1260, 156)
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        Block()
        ProduccionDataGridView.Enabled = False
        BCancelar.Visible = True
        ValLblList = LabelListadoFolios.Location
        ValProdDGV = ProduccionDataGridView.Location
        ValTxBus = TextBoxBuscar.Location
        ValBtnBus = BBuscar.Location
        LabelListadoFolios.Location = New Point(700, 160)
        ProduccionDataGridView.Location = New Point(700, 200)
        TextBoxBuscar.Location = New Point(1135, 158)
        BBuscar.Location = New Point(1260, 156)
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        ProduccionBindingSource.CancelEdit() 'Se selecciona la tabla a la que haremos referencia y ponemos para cancelar'
        DesBlock()
        ProduccionDataGridView.Enabled = True
        LabelListadoFolios.Location = ValLblList
        ProduccionDataGridView.Location = ValProdDGV
        TextBoxBuscar.Location = ValTxBus
        BBuscar.Location = ValBtnBus
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If Completo() Then
            Try
                ProduccionBindingSource.EndEdit()  'Termina de guardar los datos que se ingresaron en la tabla'
                TableAdapterManager.UpdateAll(Me.RoquinDBDataSet) 'Actualiza los datos ingresados'
                Actualiza()
                ProduccionDataGridView.Enabled = True
                LabelListadoFolios.Location = ValLblList
                ProduccionDataGridView.Location = ValProdDGV
                TextBoxBuscar.Location = ValTxBus
                BBuscar.Location = ValBtnBus
            Catch ex As Exception
                MsgBox("Fallo al tratar de Guardar", vbCritical)
            End Try
        Else
            MsgBox("Aún hay campos vacíos!", vbCritical)
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        GlobalVariables.accionForm = "borrarRegistroProduccion"
        FAlertErr.Show()
    End Sub

    Public Sub EliminarRegistro()
        Try
            ProduccionBindingSource.RemoveCurrent()  'Elimina los datos de la tabla de personal'
            ProduccionTableAdapter.Update(RoquinDBDataSet.Produccion) 'Actualiza los datos que se ingresaron en este caso se elimina'
            Actualiza()
        Catch ex As Exception
            GlobalVariables.accionForm = "falloEliminar"
            FAlertInfo.Show()
        End Try
    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NombreComboBox.SelectedIndexChanged
        NumProdTextBox.Text = NombreComboBox.SelectedValue 'Indica que se haga el cambio al mismo tiempo en el otro textbox
    End Sub

    Private Sub NombreSecComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        NumSectorTextBox.Text = NombreSecComboBox.SelectedValue 'Indica que se haga el cambio al mismo tiempo en el otro textbox
    End Sub

    Private Sub DataGridDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridDetalle.CellEndEdit
        ' Para saber en donde ingreso el dato una vez termine de ingresar en la celda 
        ProduccionDataGridView.Enabled = False
        ConsultDetallePersonalDataGridView.Enabled = False

        Dim NuEm, Kil, Res

        Col = e.ColumnIndex
        Ren = e.RowIndex

        NuEm = DataGridDetalle.Item(0, Ren).Value
        If NuEm <> "" Then
            If Col = 0 Then
                Me.PersonalTableAdapter.FillByNumPersonal(Me.RoquinDBDataSet.Personal, NuEm) 'Hace la consulta para buscar el numero que se escribio
                If NumEmpleadoTextBox.Text <> "" Then
                    DataGridDetalle.Item(1, Ren).Value = ApellidosEmpTextBox.Text
                    DataGridDetalle.Item(2, Ren).Value = NombreEmpleadoTextBox.Text
                    DataGridDetalle.CurrentCell = DataGridDetalle.Item(3, Ren) ' indicar la posicion para ir a la posicion
                    DataGridDetalle.BeginEdit(True)
                End If
            End If
            If Col = 3 Then
                If DataGridDetalle.Item(3, Ren).Value <> "" Then
                    Kil = DataGridDetalle.Item(3, Ren).Value * 2.5
                    Res = Kil Mod 2
                    If Res = 0 Then
                        DataGridDetalle.Item(4, Ren).Value = Kil
                        DataGridDetalle.Item(5, Ren).Value = 0
                    ElseIf Res = 1 Then
                        DataGridDetalle.Item(4, Ren).Value = Kil - 0.5
                        DataGridDetalle.Item(5, Ren).Value = 500
                    End If
                End If
            End If
            BSave.Focus()
        End If
    End Sub


    Private Sub BSave_Click_1(sender As Object, e As EventArgs) Handles BSave.Click
        GrabaDetalle()
        ProduccionDataGridView.Enabled = False
        ConsultDetallePersonalDataGridView.Enabled = False
    End Sub

    Private Sub GrabaDetalle()
        Dim Fol, NEmp As String
        Dim Cub, Kil, Gra As Integer


        For R = 0 To DataGridDetalle.RowCount - 2
            Fol = FolioTextBox.Text
            NEmp = DataGridDetalle.Item(0, R).Value
            Cub = DataGridDetalle.Item(3, R).Value
            Kil = DataGridDetalle.Item(4, R).Value
            Gra = DataGridDetalle.Item(5, R).Value

            Me.DetalleFolioTableAdapter.Nuevo(Fol, NEmp, Kil, Gra, Cub)
        Next
    End Sub


    Private Sub ConsultDetallePersonalDataGridView_Click(sender As Object, e As EventArgs) Handles ConsultDetallePersonalDataGridView.Click
        ConsultDetallePersonalDataGridView.Enabled = True
    End Sub

    Private Sub TextBoxBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxBuscar.KeyPress
        e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click 'Boton de busqueda por folio'
        If TextBoxBuscar.Text <> "" Then
            Me.ProduccionTableAdapter.FillByFolio(Me.RoquinDBDataSet.Produccion, Val(TextBoxBuscar.Text))
        Else
            Me.ProduccionTableAdapter.Fill(Me.RoquinDBDataSet.Produccion)
        End If
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ConsultDetallePersonalTableAdapter.FillBy(Me.RoquinDBDataSet.ConsultDetallePersonal)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub ProduccionDataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        ProduccionDataGridView.Enabled = True
    End Sub

End Class