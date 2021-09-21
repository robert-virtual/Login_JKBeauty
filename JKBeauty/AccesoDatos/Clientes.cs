using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AccesoConexcion;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class Clientes
    {
        Conexcion conexcion = new Conexcion();
        public DataTable dataTable()
        {
            try
            {
                conexcion.conectar();
                string consulta = "SELECT Id_cliente AS [ID],Primer_Nombre AS [Primer Nombre],Segundo_Nombre AS [Segundo Nombre], Primer_Apellido AS [Apellido],Direccion,Telefono,Correo FROM Table_Cliente";
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