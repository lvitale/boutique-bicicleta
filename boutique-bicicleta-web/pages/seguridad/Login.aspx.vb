Imports servicio = boutique_bicicleta_servicio
Imports System.Drawing

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Try

            servicio.Login.getInstance().ingresar(New servicio.Usuario(txtUsuario.Text, txtPassword.Text))
            Response.Redirect(Configuracion.PAGE_SECURITY_INDEX, False)
                   
        Catch ex As servicio.ServicioException
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red
                
        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red
            servicio.GestorBitacora.getInstance().agregar(New servicio.Bitacora())


        End Try
    End Sub
End Class