Public Interface IDao(Of T)

    Function consultar(filtro As T) As IEnumerable(Of T)
    Function consultar(id As Integer) As T
    Function consultarUno(filtro As T) As T

    Sub insertar(filtro As T)
    Sub modificar(filtro As T)
    Sub eliminar(filtro As T)

End Interface
