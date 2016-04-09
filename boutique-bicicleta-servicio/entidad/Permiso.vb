Public Class Permiso
    Inherits PermisoBase

    Public Overrides Function tieneHijos() As Boolean
        Return False
    End Function

    Public Overrides Function verificar(_codigo As String) As Boolean
        If (codigo.Equals(codigo)) Then
            Return True
        End If
        Return False
    End Function
End Class
