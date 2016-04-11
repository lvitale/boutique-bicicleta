Imports boutique_bicicleta_conectordb

Public Class DigitoVerificadorVerticalDao
    Inherits DBConector
    Implements IDao(Of DigitoVerificadorVertical)
    Private Shared instance As DigitoVerificadorVerticalDao = New DigitoVerificadorVerticalDao()

    Private Sub New()

    End Sub

    Public Shared Function getInstance() As DigitoVerificadorVerticalDao
        Return instance
    End Function
    Public Function consultar(id As Integer) As DigitoVerificadorVertical Implements IDao(Of DigitoVerificadorVertical).consultar
        Return Nothing
    End Function

    Public Function consultar(filtro As DigitoVerificadorVertical) As IEnumerable(Of DigitoVerificadorVertical) Implements IDao(Of DigitoVerificadorVertical).consultar
        Return Nothing
    End Function

    Public Function consultarUno(filtro As DigitoVerificadorVertical) As DigitoVerificadorVertical Implements IDao(Of DigitoVerificadorVertical).consultarUno
        Return Nothing
    End Function

    Public Sub eliminar(filtro As DigitoVerificadorVertical) Implements IDao(Of DigitoVerificadorVertical).eliminar

    End Sub

    Public Sub insertar(filtro As DigitoVerificadorVertical) Implements IDao(Of DigitoVerificadorVertical).insertar

    End Sub

    Public Sub modificar(filtro As DigitoVerificadorVertical) Implements IDao(Of DigitoVerificadorVertical).modificar

    End Sub
End Class
