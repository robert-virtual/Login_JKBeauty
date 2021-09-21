using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoConexcion;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class Existencia
    {
        Conexcion conexcion = new Conexcion();
        public DataTable dataTable()
        {
            try
            {
                conexcion.conectar();
                string consulta = "SELECT[Id_existencias] AS[ID] ,[cantidad_existencias] AS[Cantidad],[cantidad_bodega] AS[Bodega],[Cantidad_tienda] AS[Tienda],[Producto] FROM[dbo].[Existencias] ";
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
