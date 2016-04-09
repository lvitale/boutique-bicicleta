Public Class BoutiqueException
    Inherits Exception

    Public Sub New()

    End Sub
    Public Sub HotelException(ex As Exception)

    End Sub



    Public Sub HotelException(code As String, message As String)

    End Sub
    Private _code As String
    Public Property code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
        End Set
    End Property




End Class
