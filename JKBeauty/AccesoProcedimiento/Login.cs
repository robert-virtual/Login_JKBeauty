using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace AccesoProcedimiento
{
   public class Login
    {
        UsuarioDa usuarioda = new UsuarioDa();
        public bool LoginUser(string usuario,string caontraseña)
        {
            return usuarioda.Secion(usuario, caontraseña);
        }
    }
}
