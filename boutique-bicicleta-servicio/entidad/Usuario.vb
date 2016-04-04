Public Class Usuario

    Private _id As Long
    Private _nombre As String
    Private _clave As String
    Private _intentos As Integer = 0
    Private _activo As Boolean

    Private _correoElectronico As String
    Private _idioma As Idioma = New Idioma()

    Private _perfil As PermisoBase
    Private _dvh As String

    Public Property id() As Long
        Get
            Return _id
        End Get
        Set(ByVal value As Long)
            _id = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property clave() As String
        Get
            Return _clave
        End Get
        Set(ByVal value As String)
            _clave = value
        End Set
    End Property

    Public Property intentos() As Integer
        Get
            Return _intentos
        End Get
        Set(ByVal value As Integer)
            _intentos = value
        End Set
    End Property

    Public Property activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    Public Property correoElectronico() As String
        Get
            Return _correoElectronico
        End Get
        Set(ByVal value As String)
            _correoElectronico = value
        End Set
    End Property

    Public Property perfil() As PermisoBase
        Get
            Return _perfil
        End Get
        Set(ByVal value As PermisoBase)
            _perfil = value
        End Set
    End Property

   

    Public Property idioma() As Idioma
        Get
            Return _idioma
        End Get
        Set(ByVal value As Idioma)
            _idioma = value
        End Set
    End Property

    Public Property dvh() As String
        Get
            Return _dvh
        End Get
        Set(ByVal value As String)
            _dvh = value
        End Set
    End Property
End Class
