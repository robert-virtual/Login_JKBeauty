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
    public partial class VistaMarcas : Form
    {
        Marcas marcas = new Marcas();
        public VistaMarcas()
        {
            InitializeComponent();
        }

        private void VistaMarcas_Load(object sender, EventArgs e)
        {
            datagridview1.DataSource = marcas.dataTable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = marcas.dataTable();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = marcas.dataTable();
        }
    }
}
