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
    public class Marcas
    {
        Conexcion conexcion = new Conexcion();
        public DataTable dataTable()
        {
            try
            {
                conexcion.conectar();
                string consulta = "SELECT Id_marca AS [ID Marca],Descripcion,Nombre_Marca AS [Nombre Marca],Proveedor FROM Marca";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexcion.cn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            finally
            {
                conexcion.desconectar();
            }
        }
    }
}
