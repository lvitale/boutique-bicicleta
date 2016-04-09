Public Class StringUtils

    Public Shared Function isNullOrEmpty(value As String) As Boolean
        Dim nullOrEmpty As Boolean = False
        If isNull(value) Then
            nullOrEmpty = True
            If value = String.Empty Then
                nullOrEmpty = True
            End If
        End If

        Return nullOrEmpty
    End Function

    Public Shared Function isNull(value As String) As Boolean
        Dim isnullable As Boolean = False
        If value Is Nothing Then
            isnullable = True

        End If
        Return isnullable
    End Function
End Class
