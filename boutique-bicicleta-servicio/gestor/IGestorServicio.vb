Public Interface IGestorServicio(Of T)
    Sub agregar(valor As T)
    Sub modificar(valor As T)
    Sub eliminar(valor As T)
    Function listarTodos() As List(Of T)
    Function buscar(filtro As T) As List(Of T)
    Function buscarUno(filtro As T) As T

End Interface
