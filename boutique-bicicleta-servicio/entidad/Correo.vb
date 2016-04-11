Imports System.Net.Mail

Public Class Correo
    Private _origen As MailAddress
    Private _destino As MailAddress
    Private _titulo As String
    Private _cuerpo As String

    Public Property origen() As MailAddress
        Get
            Return _origen
        End Get
        Set(ByVal value As MailAddress)
            _origen = value
        End Set
    End Property

    Public Property destino() As MailAddress
        Get
            Return _destino
        End Get
        Set(ByVal value As MailAddress)
            _destino = value
        End Set
    End Property

    Public Property titulo() As String
        Get
            Return _titulo
        End Get
        Set(ByVal value As String)
            _titulo = value
        End Set
    End Property
    Public Property cuerpo() As String
        Get
            Return _cuerpo
        End Get
        Set(ByVal value As String)
            _cuerpo = value
        End Set
    End Property

End Class
