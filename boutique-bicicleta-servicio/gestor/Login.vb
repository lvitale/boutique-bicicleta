Public Class Login

    Private Shared instance As Login = New Login()

    Private Sub New()

    End Sub

    Public Shared Function getInstance() As Login
        Return instance
    End Function

    Public Sub ingresar(ingresado As Usuario)

        Dim encontrado As Usuario = Nothing

        Try
            ' usuario o clave vacias
            UsuarioValidador.getInstance().validar(ingresado)
            'verifico la integridad de la base de datos
            GestorDigitoVerificador.getInstance().verificarIntegridad()
            encontrado = GestorUsuario.getInstance().buscarUno(ingresado)
            ' clave invalida
            If (Not encontrado.clave.Equals(Encriptador.getInstance().encriptar(ingresado.clave))) Then
                'Incremento en uno el intento fallido
                GestorUsuario.getInstance().incrementarIntentos(encontrado)
                Throw New UsuarioException(Mensaje.WARNING_USUARIO_501.ToString())
            End If
            ' usuario bloqueado
            If (Not encontrado.activo) Then
                Throw New UsuarioException(Mensaje.WARNING_USUARIO_502.ToString())
            End If
            ' El usuario se autentico correctamente
            Sesion.getInstance().abrir(encontrado)
            GestorBitacora.getInstance().agregar(GestorBitacora.getInstance().generarBitacora(Mensaje.MESSAGE_LOGIN_OK, Log.accion.LOGIN, Sesion.getInstance().obtenerUsuarioActual()))

        Catch ex As IntegracionException
            GestorErrores.getInstance().gestionarError(ex)
            Throw New ServicioException(ex.Message, ex)
        Catch ex As UsuarioException
            GestorErrores.getInstance().gestionarError(ex)
            Throw New ServicioException(ex.Message, ex)
        Catch ex As DaoException
            GestorErrores.getInstance().gestionarError(ex)
            Throw New ServicioException(ex.Message, ex)
        Catch ex As Exception
            GestorErrores.getInstance().gestionarError(ex)
            Throw New ServicioException(Mensaje.ERROR_EXCEPTION_FORMULARIO, ex)

        End Try
    End Sub
    Public Sub salir()

    End Sub

End Class
