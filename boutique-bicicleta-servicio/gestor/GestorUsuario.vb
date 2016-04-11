Public Class GestorUsuario
    Implements IGestorServicio(Of Usuario)

    Private Shared instance As GestorUsuario = New GestorUsuario()
    Private Sub New()

    End Sub

    Public Shared Function getInstance() As GestorUsuario
        Return instance
    End Function
    Public Sub agregar(valor As Usuario) Implements IGestorServicio(Of Usuario).agregar

    End Sub

    Public Function buscar(filtro As Usuario) As List(Of Usuario) Implements IGestorServicio(Of Usuario).buscar
        Return Nothing
    End Function

    Public Function buscarUno(filtro As Usuario) As Usuario Implements IGestorServicio(Of Usuario).buscarUno
        Return Nothing
    End Function

    Public Sub eliminar(valor As Usuario) Implements IGestorServicio(Of Usuario).eliminar

    End Sub

    Public Function listarTodos() As List(Of Usuario) Implements IGestorServicio(Of Usuario).listarTodos
        Return Nothing
    End Function

    Public Sub modificar(valor As Usuario) Implements IGestorServicio(Of Usuario).modificar

    End Sub

    Public Sub incrementarIntentos(filtro As Usuario)
        Try
            filtro.incrementarIntentos()
            filtro.dvh = GestorDigitoVerificador.getInstance().calcularDVH(filtro)
            UsuarioDao.getInstance().modificar(filtro)
            GestorDigitoVerificador.getInstance().modificarDigitoVerificadorVertical()

        Catch ex As Exception

            GestorErrores.getInstance().gestionarError(ex)
        End Try

    End Sub
End Class
