Imports System.Text
Imports System.Security.Cryptography

Public Class GestorDigitoVerificador

    Private Shared instance As GestorDigitoVerificador = New GestorDigitoVerificador()

    Private Sub New()

    End Sub

    Public Shared Function getInstance() As GestorDigitoVerificador
        Return instance
    End Function

    Public Sub verificarIntegridad()

        Dim dvv As StringBuilder = New StringBuilder()
        Try

            Dim usuarios As List(Of Usuario) = GestorUsuario.getInstance().listarTodos()
            Dim dvvUsuario As DigitoVerificadorVertical = DigitoVerificadorVerticalDao.getInstance().consultar(New DigitoVerificadorVertical(ServicioConstante.TABLA_USUARIO_ENCRITADA))
            For Each item As Usuario In usuarios
                Dim dvh As String = gethash(item)
                If (Not dvh.Equals(item.dvh)) Then

                    Throw New IntegracionException(Mensaje.ERROR_IN_301)
                    dvv.Append(dvh)
                End If

            Next
            ' comparo el digito verificador vertical
            If (Not dvvUsuario.dvv.Equals(getHashSha1(dvv.ToString()))) Then

                Throw New IntegracionException(Mensaje.ERROR_IN_301)
            End If
        Catch ex As Exception
            Throw New IntegracionException(Mensaje.ERROR_IN_301, ex)
        End Try
        GestorBitacora.getInstance().agregar(GestorBitacora.getInstance().generarBitacora(Mensaje.MESSAGE_INTEGRACION_OK, Log.accion.INTEGRACION, Sesion.getInstance().obtenerUsuarioActual()))
    End Sub

    Public Function calcularDVH(usuario As Usuario) As String
        Return gethash(usuario)
    End Function

    Public Function calcularDVV(listado As List(Of Usuario)) As String

        Dim key As StringBuilder = New StringBuilder()
        For Each usuario As Usuario In listado
            key.Append(calcularDVH(usuario))
        Next

        Return getHashSha1(key.ToString())
    End Function

    Public Sub modificarDigitoVerificadorVertical()

        Dim dvv As StringBuilder = New StringBuilder()
        Try

            Dim usuarios As List(Of Usuario) = GestorUsuario.getInstance().listarTodos()
            dvv.Append(calcularDVV(usuarios))

            DigitoVerificadorVerticalDao.getInstance().modificar(New DigitoVerificadorVertical(ServicioConstante.TABLA_USUARIO_ENCRITADA, dvv.ToString()))

        Catch ex As Exception
            Throw New IntegracionException(Mensaje.ERROR_IN_301, ex)
        End Try
        GestorBitacora.getInstance().agregar(GestorBitacora.getInstance().generarBitacora(Mensaje.MESSAGE_UPDATE_DVV_USER, Log.accion.INTEGRACION, Sesion.getInstance().obtenerUsuarioActual()))
    End Sub

    Private Function gethash(usuario As Usuario) As String

        Dim hash As StringBuilder = New StringBuilder()
        hash.Append(usuario.nombre)
        hash.Append(usuario.clave)
        hash.Append(usuario.perfil.codigo)
        hash.Append(usuario.intentos.ToString())
        hash.Append(usuario.activo)

        Return getHashSha1(hash.ToString())
    End Function

    Private Function getHashSha1(value As String) As String

        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(value)
        Dim strResult As String = String.Empty

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function

End Class
