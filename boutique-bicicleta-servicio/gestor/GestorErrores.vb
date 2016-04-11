Imports System.Text

Public Class GestorErrores

    Private Shared instance As GestorErrores = New GestorErrores()

    Private Sub New()

    End Sub

    Public Shared Function getInstance() As GestorErrores
        Return instance
    End Function

    Public Sub gestionarError(ex As Exception)

        Dim type As String = ex.GetType().Name

        Select Case type
            Case "BitacoraDaoException"
                enviarCorreo(ex)

            Case "IntegracionException"
                enviarCorreo(ex)
                regsitrarBitacora(ex)

            Case "DaoException"
                regsitrarBitacora(ex)
                enviarCorreo(ex)

            Case "UsuarioException"
                enviarCorreo(ex)

            Case "SeguridadException"
                enviarCorreo(ex)

            Case Else
                regsitrarBitacora(ex)
                enviarCorreo(ex)

        End Select

    End Sub

    Private Sub regsitrarBitacora(ex As Exception)

        Dim bitacora As Bitacora = New Bitacora()
        bitacora.accion = Log.accion.ERRORES.ToString()
        bitacora.descripcion = ex.Message
        bitacora.fecha = New DateTime()
        bitacora.pila = ex.StackTrace
        bitacora.usuario = Sesion.getInstance.obtenerUsuarioActual()
        GestorBitacora.getInstance().agregar(bitacora)

    End Sub

    Private Sub enviarCorreo(ex As Exception)

        Try
            GestorCorreoElecronico.getInstance().enviarCorreo(GestorCorreoElecronico.getInstance().configurarCorreo(crearMensajeError(ex)))
        Catch e As Exception
            Console.WriteLine(e.Message)
        End Try
    End Sub

    Private Function crearMensajeError(ex As Exception) As String
        Dim mensaje As StringBuilder = New StringBuilder()
        Dim now As DateTime = DateTime.Today

        mensaje.Append(" Ha ocurrio un error en la aplicacion \r\n")
        mensaje.Append(" hora       : " + String.Format("{0:dddd, MMMM d, yyyy}", now) + " \r\n  ")
        mensaje.Append("------------------------------------------ \r\n")
        mensaje.Append(" Mensaje    : " + ex.Message + " \r\n ")
        mensaje.Append(" Origen     : " + ex.Source + " \r\n ")
        mensaje.Append(" Exception  : " + ex.TargetSite.GetType().Name + " \r\n ")
        mensaje.Append(" Clase      : " + ex.GetType().Name + " \r\n  ")
        mensaje.Append("------------------------------------------ \r\n")
        mensaje.Append(" StakeTrace : " + ex.StackTrace + " \r\n ")
        mensaje.Append("------------------------------------------ \r\n")
        Return mensaje.ToString()
    End Function


End Class
