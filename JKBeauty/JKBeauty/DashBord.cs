using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoConexcion;
using System.Data.SqlClient;

namespace JKBeauty
{
    public partial class DashBord : Form
    {
        Conexcion conexcion = new Conexcion();
        SqlCommand command;
        public DashBord()
        {
            InitializeComponent();
        }

        ArrayList marca = new ArrayList();
        ArrayList cantprod = new ArrayList();

        private void DatosCargados()
        {
            command = new SqlCommand("Datos",conexcion.cn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter("@client", 0);
            SqlParameter parameter1 = new SqlParameter("@prov", 0);
            SqlParameter parameter2 = new SqlParameter("@prod", 0);
            SqlParameter parameter3 = new SqlParameter("@ped", 0);
            SqlParameter parameter4 = new SqlParameter("@marc", 0);

            parameter.Direction = ParameterDirection.Output;
            parameter1.Direction = ParameterDirection.Output;
            parameter2.Direction = ParameterDirection.Output;
            parameter3.Direction = ParameterDirection.Output;
            parameter4.Direction = ParameterDirection.Output;

            command.Parameters.Add(parameter);
            command.Parameters.Add(parameter1);
            command.Parameters.Add(parameter2);
            command.Parameters.Add(parameter3);
            command.Parameters.Add(parameter4);
            conexcion.conectar();
            command.ExecuteNonQuery();
            lbCantidadClientes.Text = command.Parameters["@client"].Value.ToString();
            lbCantidadProductos.Text = command.Parameters["@prod"].Value.ToString();
            lbCantidadProveedores.Text = command.Parameters["@prov"].Value.ToString();
            lbCantidadPedidos.Text = command.Parameters["@ped"].Value.ToString();
            lbCantidadMarcas.Text = command.Parameters["@marc"].Value.ToString();
            conexcion.desconectar();
        }

        private void DashBord_Load(object sender, EventArgs e)
        {
            DatosCargados();
        }
    }
}
