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
    public class Proveedores
    {
        Conexcion conexcion = new Conexcion();
        public DataTable dataTable()
        {
            try
            {
                conexcion.conectar();
                string consulta = "SELECT [cod_proveedor] AS [Codigo Proveedor],[nom_proveedor] AS [Nombre Proveedor],[direccion_proveedor] AS [Direccion],[tel_propietario] AS [Telefono],[correo_proveedor] AS [Correo],[productos_proveedor] AS [Nombre Producto] FROM [dbo].[proveedores]";
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
