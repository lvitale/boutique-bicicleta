Imports boutique_bicicleta_conectordb

Public Class UsuarioDao
    Inherits DBConector
    Implements IDao(Of Usuario)
    Private Shared instance As UsuarioDao = New UsuarioDao()

    Private Sub New()

    End Sub

    Public Shared Function getInstance() As UsuarioDao
        Return instance
    End Function

    Public Function consultar(id As Integer) As Usuario Implements IDao(Of Usuario).consultar
        Return Nothing
    End Function

    Public Function consultar(filtro As Usuario) As IEnumerable(Of Usuario) Implements IDao(Of Usuario).consultar
        Return Nothing
    End Function

    Public Function consultarUno(filtro As Usuario) As Usuario Implements IDao(Of Usuario).consultarUno
        Return Nothing
    End Function

    Public Sub eliminar(filtro As Usuario) Implements IDao(Of Usuario).eliminar

    End Sub

    Public Sub insertar(filtro As Usuario) Implements IDao(Of Usuario).insertar

    End Sub

    Public Sub modificar(filtro As Usuario) Implements IDao(Of Usuario).modificar

    End Sub
End Class
