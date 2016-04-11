Imports System.Net.Mail
Imports System.Text

Public Class GestorCorreoElecronico

    Private Shared instance As GestorCorreoElecronico = New GestorCorreoElecronico()

    Private Sub New()

    End Sub

    Public Shared Function getInstance() As GestorCorreoElecronico
        Return instance
    End Function

    Public Sub enviarCorreo(correo As Correo)
        Dim mailMessage As MailMessage = New MailMessage()
        Try

            mailMessage.From = correo.origen
            mailMessage.To.Add(correo.destino)
            mailMessage.Subject = correo.titulo
            mailMessage.Body = correo.cuerpo
            Dim client As SmtpClient = New SmtpClient()
            client.EnableSsl = True
            client.DeliveryMethod = SmtpDeliveryMethod.Network
            client.Send(mailMessage)
            ' envia el correo
            ' <network host="smtp.gmail.com" userName="reserva.hotel.california@gmail.com" password="campo2014" port="587" />
            ' https://www.google.com/settings/security  

        Catch ex As Exception
            GestorErrores.getInstance().gestionarError(ex)
        End Try

    End Sub

    Public Function configurarCorreo(body As String) As Correo
        Dim newMail As Correo = New Correo()
        newMail.origen = New MailAddress(ServicioConstante.EMAIL_CORREO_APLICACION)
        newMail.destino = New MailAddress(ServicioConstante.EMAIL_ADMINISTRADOR_APLICACION)
        newMail.titulo = ServicioConstante.MAIL_MESSAGE_SUBJECT
        newMail.cuerpo = body
        Return newMail

    End Function

    


End Class
