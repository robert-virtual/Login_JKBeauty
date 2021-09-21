using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administrador;


namespace JKBeauty
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir de la aplicación", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        public void AbrirFormulario<FormularioAbrir>() where FormularioAbrir : Form, new()
        {
            Form Formulario;
            Formulario = panelCentral.Controls.OfType<FormularioAbrir>().FirstOrDefault();

            if (Formulario == null)
            {
                Formulario = new FormularioAbrir
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };

                panelCentral.Controls.Add(Formulario);
                panelCentral.Tag = Formulario;

                Formulario.Show();
                Formulario.BringToFront();

            }
            else
            {
                Formulario.BringToFront();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormulario<DashBord>();
        }

        private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Administrador.VistaCliente>();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.Clientes>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.Productos>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.Existencia>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.Proveedores>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.Marcas>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Administrador.Registro>();
        }

        private void listarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Administrador.VistaProductos>();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.Clientes>();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.Productos>();
        }

        private void agregarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.Marcas>();
        }

        private void agregarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.Proveedores>();
        }

        private void agregarExistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.Existencia>();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cerrar la Sesion", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                Application.Exit();
            }

        }

        private void listarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Administrador.VistaMarcas>();
        }

        private void mostrarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mostrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Administrador.VistaProveedores>();
        }

        private void listarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Administrador.VistaExistencia>();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<interfazBusqueda.Busqueda>();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Factura.Factura>();
        }

        private void perfil_Click(object sender, EventArgs e)
        {
            AbrirFormulario<edicion_de_perfil.Form1>();
        }

        private void actividadPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Informe.Form1>();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Informe.Form2>();
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Informe.Form3>();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Informe.Form4>();
        }
    }
}
