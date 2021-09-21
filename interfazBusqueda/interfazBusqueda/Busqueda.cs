using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace interfazBusqueda
{
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog =JkBeauty;Integrated security=True");
        

        private void bnBuscar_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaCliente Nuevaventana2 = new BusquedaCliente();
            Nuevaventana2.Show();

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaProducto ventananueva3 = new BusquedaProducto();
            ventananueva3.Show();

        }


        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaEmpleado ventananueva4 = new BusquedaEmpleado();
            ventananueva4.Show();

        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
           
        }

        private void proveedortoolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaProveedor ventananueva6 = new BusquedaProveedor();
            ventananueva6.Show();
        }
    }
}
