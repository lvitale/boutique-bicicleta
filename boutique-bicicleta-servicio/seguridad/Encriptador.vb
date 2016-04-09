Imports System.Text
Imports System.Security.Cryptography

Public Class Encriptador

    Private key As String = "boutique"

    Public Function encriptar(valor As String) As String
        Dim md5 As MD5 = md5.Create()
        Dim data As Byte() = md5.ComputeHash(Encoding.UTF8.GetBytes(valor))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function
End Class
