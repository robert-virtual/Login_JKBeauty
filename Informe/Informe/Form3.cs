using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'JKBeautyDataSet2.pedidos' Puede moverla o quitarla según sea necesario.
            this.pedidosTableAdapter.Fill(this.JKBeautyDataSet2.pedidos);

            this.reportViewer1.RefreshReport();
        }
    }
}
