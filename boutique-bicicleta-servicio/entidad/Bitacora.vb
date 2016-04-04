Public Class Bitacora

    Private _accion As String
    Private _descripcion As String
    Private _fecha As DateTime
    Private _usuario As Usuario
    Private _pila As String
    Private _fechaDesde As DateTime
    Private _fechaHasta As DateTime

    Public Property accion() As String
        Get
            Return _accion
        End Get
        Set(ByVal value As String)
            _accion = value
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

    Public Property fecha() As DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As DateTime)
            _fecha = value
        End Set
    End Property

    Public Property usuario() As Usuario
        Get
            Return _usuario
        End Get
        Set(ByVal value As Usuario)
            _usuario = value
        End Set
    End Property

    Public Property pila() As String
        Get
            Return _pila
        End Get
        Set(ByVal value As String)
            _pila = value
        End Set
    End Property

    Public Property fechaDesde() As DateTime
        Get
            Return _fechaDesde
        End Get
        Set(ByVal value As DateTime)
            _fechaDesde = value
        End Set
    End Property

    Public Property fechaHasta() As DateTime
        Get
            Return _fechaHasta
        End Get
        Set(ByVal value As DateTime)
            _fechaHasta = value
        End Set
    End Property

End Class
