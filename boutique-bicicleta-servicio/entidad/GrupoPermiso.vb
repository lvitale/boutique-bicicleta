Public Class GrupoPermiso
    Inherits PermisoBase


    Private _permisos As IEnumerable(Of PermisoBase) = New List(Of PermisoBase)


    Public Overrides Function tieneHijos() As Boolean
        If _permisos IsNot Nothing Or _permisos.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Overrides Function verificar(codigo As String) As Boolean
        For Each item As PermisoBase In _permisos
            If item.verificar(codigo) Then
                Return True
            End If

        Next
        Return False
    End Function
End Class
