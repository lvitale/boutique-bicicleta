Public Class Sesion

    Private Shared instance As Sesion = New Sesion()
    Private _usuarioActual As Usuario = Nothing
    Private Sub New()

    End Sub

    Public Shared Function getInstance() As Sesion
        Return instance
    End Function

    Public Sub abrir(actual As Usuario)
        _usuarioActual = actual
    End Sub

    Public Sub CerrarSesion()
        _usuarioActual = Nothing
    End Sub

    Public Function obtenerUsuarioActual() As Usuario
        Return _usuarioActual
    End Function
End Class
