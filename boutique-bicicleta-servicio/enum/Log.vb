Public Class Log
    Public Enum accion
        ERRORES
        LOGIN
        LOGOUT
        BACKUP
        RESTORE
        MODIFICAR
        ELIMINAR
        INSERTAR
        INTEGRACION

    End Enum

    Public Shared Function getAllActions() As IEnumerable(Of String)

        Static listado As List(Of String) = New List(Of String)

        listado.Add(accion.ERRORES.ToString())
        listado.Add(accion.LOGIN.ToString())
        listado.Add(accion.LOGOUT.ToString())

        listado.Add(accion.BACKUP.ToString())
        listado.Add(accion.RESTORE.ToString())

        listado.Add(accion.MODIFICAR.ToString())
        listado.Add(accion.ELIMINAR.ToString())
        listado.Add(accion.INSERTAR.ToString())
        listado.Add(accion.INSERTAR.ToString())
        Return listado
    End Function
End Class
