Public Class DigitoVerificadorVertical
    Private _id As Int32
    Private _nombreTabla As String
    Private _dvv As String


    Public Property id() As Int32
        Get
            Return _id
        End Get
        Set(ByVal value As Int32)
            _id = value
        End Set
    End Property

    Public Property nombreTabla() As String
        Get
            Return _nombreTabla
        End Get
        Set(ByVal value As String)
            _nombreTabla = value
        End Set
    End Property

    Public Property dvv() As String
        Get
            Return _dvv
        End Get
        Set(ByVal value As String)
            _dvv = value
        End Set
    End Property
End Class
