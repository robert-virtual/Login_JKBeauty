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
    public partial class VistaProducto : Form
    {
        Productos productos = new Productos();
        public VistaProducto()
        {
            InitializeComponent();
        }

        private void VistaProducto_Load(object sender, EventArgs e)
        {
            datagridview1.DataSource = productos.dataTable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = productos.dataTable();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = productos.dataTable();
        }
    }
}
