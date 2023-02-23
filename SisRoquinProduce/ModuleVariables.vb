Public Module ModuleVariables

    Public IdUsr
    Public User
    Public Niv

    Public Class GlobalVariables
        Public Shared borrarRegistro As String = "¿Desea borrar el registro?"   'Error
        Public Shared bienvenido As String = "¡ B i e n v e n i d o " + User + " !"          'Info
        Public Shared falloConexion As String = "Falló la conexión"             'Info
        Public Shared falloGuardar As String = "Falló al tratar de guardar"     'Info
        Public Shared falloEliminar As String = "Falló al tratar de eliminar"   'Info
        Public Shared falloVacio As String = "¡Aún hay campos vacíos!"          'Info
        Public Shared datosMal As String = "¡Usuario o Contraseña no validos!"  'Info
        Public Shared falloUsuarioVacio As String = "¡No existe el Usuario!"    'Info
        Public Shared questSalir As String = "¿Desea cerrar sesión?"            'Question
        Public Shared salirMenu As String = "¿Desea cerrar el sistema?" 'Question

        Public Shared accionForm As String = ""
    End Class
End Module
