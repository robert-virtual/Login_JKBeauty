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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'JKBeautyDataSet1.Productos' Puede moverla o quitarla según sea necesario.
            this.ProductosTableAdapter.Fill(this.JKBeautyDataSet1.Productos);
            // TODO: esta línea de código carga datos en la tabla 'JKBeautyDataSet.Detalle_Factura' Puede moverla o quitarla según sea necesario.
            this.Detalle_FacturaTableAdapter.Fill(this.JKBeautyDataSet.Detalle_Factura);
            // TODO: esta línea de código carga datos en la tabla 'JKBeautyDataSet.Factura' Puede moverla o quitarla según sea necesario.
            this.FacturaTableAdapter.Fill(this.JKBeautyDataSet.Factura);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
