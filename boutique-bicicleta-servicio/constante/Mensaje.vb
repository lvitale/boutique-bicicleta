Public Class Mensaje
    Public Shared ERROR_EXCEPTION_NO_ESPERADA_101 As String = "Exception no esperada"
    'Error de base de datos
    Public Shared ERROR_DB_201 As String = "No se puede conectar a la base de datos"
    Public Shared ERROR_IN_301 As String = "Base de datos corrupta"
    'Error de idioma
    Public Shared ERROR_IDIOMA_401 As String = "No se pudo actualizar el idioma"
    Public Shared ERROR_IDIOMA_402 As String = "Idioma ya existe"
    Public Shared ERROR_IDIOMA_404 As String = "Idioma No existe"
    Public Shared ERROR_IDIOMA_405 As String = "No se puede eliminar el idioma.Hay usuarios que poseen este idioma"
    ' Error de usuario
    Public Shared WARNING_USUARIO_501 As String = "Usuario o clave invalida"
    Public Shared WARNING_USUARIO_502 As String = "Usuario bloqueado , por favor contactese con el administrador"
    Public Shared WARNING_USUARIO_503 As String = "Por favor complete el usuario o la clave"
    Public Shared WARNING_USUARIO_504 As String = "El usuario no existe"
    Public Shared WARNING_USUARIO_505 As String = "El usuario ya existe"
    Public Shared WARNING_USUARIO_506 As String = "No se ha modificado ningun dato "
    'Error de Leyenda
    Public Shared ERROR_LEYENDA_601 As String = "No se pudo actualizar La leyenda"
    Public Shared ERROR_LEYENDA_602 As String = "Leyenda ya existe"
    Public Shared ERROR_LEYENDA_602_NAME As String = "Leyenda_existe"

    Public Shared ERROR_LEYENDA_603 As String = "Leyenda No existe"
    ' Error general de formulario
    Public Shared ERROR_EXCEPTION_FORMULARIO As String = "Por favor vuelva a intertarlo mas tarde"
    Public Shared ERROR_EXCEPTION_INSERT_DELETE_UPDATE As String = "No se pudo ejecutar la operacion"
    ' errores de BACKUP
    Public Shared WARNING_BACKUP_401 As String = "Direccion o nombre invalido"
    Public Shared WARNING_BACKUP_402 As String = "No se pudo ejecutar el backup"
    ' warning generales
    Public Shared WARNING_GENERAL_601 As String = "Por favor complete los casilleros "

    Public Shared WARNING_PERMISO_701 As String = "No se modifcaron los permisos"
    Public Shared WARNING_PERMISO_702 As String = "Por favor agregue los permisos"
    Public Shared WARNING_PERMISO_703 As String = "No esta el permiso en la base"
    Public Shared WARNING_PERMISO_704 As String = "No se puede eliminar el perfil.Hay usuarios que poseen este perfil"

    Public Shared WARNING_PERFIL_EXISTE As String = "El perfil no existe"
    Public Shared WARNING_PERFIL_EXISTE_MESSAGE As String = "perfilExiste"

    'Diferentes mensajes mostrados por la aplicacion
    Public Shared MESSAGE_OK_OPERACION = "La operacion se ejecuto con exito"
    Public Shared MESSAGE_OK_OPERACION_NAME = "mensaje_ok"

    Public Shared MESSAGE_UPDATE_DVV_USER = "Se modifico el dvv calculado de la tabla usuario"
    Public Shared MESSAGE_INTEGRACION_OK = "Se verifico correctamente la integridad"
    Public Shared MESSAGE_LOGIN_OK = "El usuario ingreso correctamente"
    Public Shared MESSAGE_ERROR = "Error"

End Class
