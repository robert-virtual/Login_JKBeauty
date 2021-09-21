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
    public class Pedidos
    {
        Conexcion conexcion = new Conexcion();
        public DataTable dataTable()
        {
            try
            {
                conexcion.conectar();
                string consulta = "SELECT dped.[Id_Pedido] AS [ID Pedido],dped.Id_Detallepedido AS [ID Detalle],[Estado_pedido] AS [Estado],[Fecha_pedido] AS [Feche Pedido],[Fecha_envio] AS [Fecha Envio],[Fecha_entrega] AS [Fecha Entrega],[Destinatario],dped.Cantidad AS [Cantidad],dped.Descuento AS [Descuento],dped.PrecioUnidad AS [Precio],[Direccion] FROM [dbo].[pedidos] AS ped INNER JOIN detallepedido dped ON ped.Id_Pedido = dped.Id_Pedido";
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
