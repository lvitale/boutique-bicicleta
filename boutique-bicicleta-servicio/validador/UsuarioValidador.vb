Imports boutique_bicicleta_utils

Public Class UsuarioValidador

    Private Shared instance As UsuarioValidador = New UsuarioValidador()

    Private Sub New()

    End Sub

    Public Shared Function getInstance() As UsuarioValidador
        Return instance
    End Function

    Public Sub validar(usuario As Usuario)
        If (usuario Is Nothing) Then
            Throw New UsuarioException(Mensaje.WARNING_GENERAL_601)
        End If
        If (StringUtils.isNullOrEmpty(usuario.nombre) Or StringUtils.isNullOrEmpty(usuario.clave)) Then

            Throw New UsuarioException(Mensaje.WARNING_USUARIO_503)

        End If
    End Sub

    Public Sub validarExistente(usuario As Usuario)
        If (usuario Is Nothing) Then
            Throw New UsuarioException(Mensaje.WARNING_GENERAL_601)
        End If

        If (StringUtils.isNullOrEmpty(usuario.nombre) Or StringUtils.isNullOrEmpty(usuario.clave) Or StringUtils.isNullOrEmpty(usuario.intentos.ToString())) Then

            Throw New UsuarioException(Mensaje.WARNING_GENERAL_601)
        End If

        If (StringUtils.isNullOrEmpty(usuario.idioma.cultura) Or StringUtils.isNullOrEmpty(usuario.perfil.codigo)) Then

            Throw New UsuarioException(Mensaje.WARNING_GENERAL_601)

        End If

    End Sub


End Class
