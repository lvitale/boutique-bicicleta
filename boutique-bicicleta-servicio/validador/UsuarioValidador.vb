Public Class UsuarioValidador

    Private Shared instance As UsuarioValidador = New UsuarioValidador()

    Private Sub New()

    End Sub

    Public Shared Function getInstance() As UsuarioValidador
        Return instance
    End Function

    Public Sub validar(nombre As String, clave As String)
        If StringUtils.isNullOrEmpty(nombre) Or StringUtils.isNullOrEmpty(clave) Then

               Throw new UsuarioException(ErrorConstante.WARNING_USUARIO_503.ToString(), ErrorConstante.WARNING_USUARIO_503);

    End Sub

       public void validate(Usuario usuario)
       {
           if (usuario == null)
           {
               throw new UsuarioException(ErrorConstante.WARNING_GENERAL_601.ToString(), ErrorConstante.WARNING_GENERAL_601);
           }
           if (StringUtils.isNullOrEmpty(usuario.nombre) || StringUtils.isNullOrEmpty(usuario.clave) || StringUtils.isNullOrEmpty(usuario.intentos.ToString()))
           {
               throw new UsuarioException(ErrorConstante.WARNING_GENERAL_601.ToString(), ErrorConstante.WARNING_GENERAL_601);
           }
           if (StringUtils.isNullOrEmpty(usuario.idioma.cultura) || StringUtils.isNullOrEmpty(usuario.perfil.codigo) )
           {
               throw new UsuarioException(ErrorConstante.WARNING_GENERAL_601.ToString(), ErrorConstante.WARNING_GENERAL_601);
           }
       }

       public Boolean existe(String usuario) {
        Boolean existe = false;
        try{
            Usuario usu = UsuarioDao.getInstance().consultarUno(new Usuario(usuario));
            if(usu !=null && !StringUtils.isNullOrEmpty(usu.nombre))
            {
                existe=true;
            }
        }catch(Exception ex){
             Console.Write(ex.Message);
         }
           return existe;
       }
End Class
