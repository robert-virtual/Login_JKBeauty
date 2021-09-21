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
   public class Productos
    {
        Conexcion conexcion = new Conexcion();
        public DataTable dataTable()
        {
            try
            {
                conexcion.conectar();
                string consulta = "SELECT ID_Producto AS [ID Producto],Nombre_Producto AS [Nombre],Existencia,Precio_Actual AS [Precio],Fecha_Vencimiento AS [Fecha Vencimiento],Marca FROM Productos";
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
