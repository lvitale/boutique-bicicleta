Public Class GestorBitacora
    Implements IGestorServicio(Of Bitacora)

    Private Shared instance As GestorBitacora = New GestorBitacora()

    Private Sub New()

    End Sub

    Public Shared Function getInstance() As GestorBitacora
        Return instance
    End Function
    Public Sub agregar(valor As Bitacora) Implements IGestorServicio(Of Bitacora).agregar

    End Sub

    Public Function buscar(filtro As Bitacora) As List(Of Bitacora) Implements IGestorServicio(Of Bitacora).buscar
        Return Nothing
    End Function

    Public Function buscarUno(filtro As Bitacora) As Bitacora Implements IGestorServicio(Of Bitacora).buscarUno
        Return Nothing
    End Function

    Public Sub eliminar(valor As Bitacora) Implements IGestorServicio(Of Bitacora).eliminar

    End Sub

    Public Function listarTodos() As List(Of Bitacora) Implements IGestorServicio(Of Bitacora).listarTodos
        Return Nothing
    End Function

    Public Sub modificar(valor As Bitacora) Implements IGestorServicio(Of Bitacora).modificar

    End Sub

    Public Function generarBitacora(accion As Log.accion, descripcion As String, usuario As Usuario) As Bitacora
        Dim bitacora As Bitacora = New Bitacora()
        bitacora.fecha = DateTime.Now
        bitacora.accion = accion.ToString()
        bitacora.accion = descripcion
        bitacora.usuario = usuario
        Return bitacora
    End Function
End Class
