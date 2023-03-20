Public Module ModuleVariables

    Public IdUsr
    Public User
    Public Niv

    Dim usuario = FLogin.NombreUserTextBox
    Public Class GlobalVariables
        Public Shared borrarRegistro As String = "¿Desea borrar el registro?"   'Error
        Public Shared bienvenido As String = "¡ B i e n v e n i d o " + usuario.text + " !"          'Info
        Public Shared falloConexion As String = "Falló la conexión"             'Info
        Public Shared falloGuardar As String = "Falló al tratar de guardar"     'Info
        Public Shared falloEliminar As String = "Falló al tratar de eliminar"   'Info
        Public Shared falloVacio As String = "¡Aún hay campos vacíos!"          'Info
        Public Shared datosMal As String = "¡Usuario o Contraseña no validos!"  'Info
        Public Shared falloUsuarioVacio As String = "¡No existe el Usuario!"    'Info
        Public Shared sinpermiso As String = "¡Usuario sin permisos!"    'Info
        Public Shared questSalir As String = "¿Desea cerrar sesión?"            'Question
        Public Shared salirMenu As String = "¿Desea cerrar el sistema?" 'Question

        Public Shared accionForm As String = ""
        Public Shared autorizar As String = ""
    End Class
End Module
