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
    public partial class VistaExistencia : Form
    {
        Existencia existencia = new Existencia();
        public VistaExistencia()
        {
            InitializeComponent();
        }

        private void VistaExistencia_Load(object sender, EventArgs e)
        {
            datagridview1.DataSource = existencia.dataTable();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = existencia.dataTable();
        }
    }
}
