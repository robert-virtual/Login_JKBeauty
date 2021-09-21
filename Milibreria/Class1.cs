using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Milibreria
{
    public class Utilidades
    {

        public static DataSet Ejecutar(string CMD)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=JKBeauty;Integrated Security=True");
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(CMD, con);
            dp.Fill(ds);

            con.Close();
            return ds;
        }

    }
}
