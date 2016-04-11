Public Class DaoException
    Inherits Exception
    Public Sub New(message As String)
        MyBase.New(message)
    End Sub
    Public Sub New(message As String, ex As Exception)
        MyBase.New(message, ex)
    End Sub
End Class
