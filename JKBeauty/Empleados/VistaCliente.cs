using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
namespace Empleados
{
    public partial class VistaCliente : Form
    {
        Clientes clientes = new Clientes();
        public VistaCliente()
        {
            InitializeComponent();
        }

        private void VistaCliente_Load(object sender, EventArgs e)
        {
            datagridview1.DataSource = clientes.dataTable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = clientes.dataTable();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = clientes.dataTable();
        }
    }
}
