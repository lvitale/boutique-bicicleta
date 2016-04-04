Public Class Idioma
    Private _cultura As String
    Private _descripcion As String
    Private _leyendas As IEnumerable(Of Leyenda)

    Public Property cultura() As String
        Get
            Return _cultura
        End Get
        Set(ByVal value As String)
            _cultura = value
        End Set
    End Property

    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property leyendas() As IEnumerable(Of Leyenda)
        Get
            Return _leyendas
        End Get
        Set(ByVal value As IEnumerable(Of Leyenda))
            _leyendas = value
        End Set
    End Property
End Class
