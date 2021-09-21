using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoConexcion;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
   public class UsuarioDa
    {
        Conexcion conexcion = new Conexcion();

        public bool Secion(string usuario, string contraseña)
        {
            try
            {
                conexcion.conectar();
                SqlCommand command = new SqlCommand();
                command.Connection = conexcion.cn;
                command.CommandText = "SELECT * FROM Empleados WHERE Usuario = @usuario AND Contraseña = @ontraseña";
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@contraseña", contraseña);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            finally
            {
                conexcion.desconectar();
            }
        }
    }
}
