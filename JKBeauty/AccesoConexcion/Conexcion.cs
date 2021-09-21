using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace AccesoConexcion
{
    public class Conexcion
    {
        public SqlConnection cn = new SqlConnection(@"Data Source =localhost\SQLEXPRESS; Initial Catalog = JKBeauty; Integrated Security = True");

        public void conectar()
        {
            cn.Open();
        }

        public void desconectar()
        {
            cn.Close();
        }
    }
}