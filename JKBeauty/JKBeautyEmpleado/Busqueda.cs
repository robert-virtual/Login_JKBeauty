using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using interfazBusqueda;

namespace JKBeautyEmpleado
{
    public partial class Busqueda : Form
    {
        BusquedaCliente cliente = new BusquedaCliente();
        BusquedaProducto producto = new BusquedaProducto();
        BusquedaProveedor proveedor = new BusquedaProveedor();
        public Busqueda()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cliente.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            producto.Show();
        }

        private void proveedortoolStripMenuItem_Click(object sender, EventArgs e)
        {
            proveedor.Show();
        }
    }
}
