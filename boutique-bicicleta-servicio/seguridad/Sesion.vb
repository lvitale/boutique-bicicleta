Public Class Sesion

    Private Shared instance As Sesion = New Sesion()

    Private Sub New()

    End Sub

    Public Shared Function getInstance() As Sesion
        Return instance
    End Function


End Class
