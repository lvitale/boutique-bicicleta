Public  MustInherit Class PermisoBase
    Private _codigo As String
    Private _descripcion As String

    Public MustOverride Function tieneHijos() As Boolean
    Public MustOverride Function verificar(codigo As String) As Boolean

    Public Property codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
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

End Class
