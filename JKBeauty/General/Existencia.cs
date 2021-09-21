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
using AccesoConexcion;
using AccesoDatos;

namespace General
{
    public partial class Existencia : Form
    {
        Conexcion conexcion = new Conexcion();
       AccesoDatos.Productos productos = new AccesoDatos.Productos();
        public Existencia()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            string agregar = "INSERT INTO [dbo].[Existencias]([Id_existencias],[cantidad_existencias],[cantidad_bodega],[Cantidad_tienda],[Producto]) VALUES(@ID,@Cantidad,@Bodega,@Tienda,@IDP)";
            SqlCommand command = new SqlCommand(agregar,conexcion.cn);
            try
            {
                conexcion.conectar();
                if (ID.Text != "")
                {
                    if (Bodega.Text != "")
                    {

                        if (Tienda.Text != "")
                        {

                            if (Cantidad.Text != "")
                            {

                                command.Parameters.AddWithValue("@ID", int.Parse(ID.Text));
                                command.Parameters.AddWithValue("@IDP", textBox1.Text);
                                command.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(Cantidad.Text));
                                command.Parameters.AddWithValue("@Bodega", Convert.ToInt32(Bodega.Text));
                                command.Parameters.AddWithValue("@Tienda", int.Parse(Tienda.Text));
                                command.ExecuteNonQuery();
                                MessageBox.Show("Datos Ingresados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Cantidad Vacia,Ingresar Datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cantidad en Tienda Vacia,Ingresar Datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cantidad en Bodega Vacia,Ingresar Datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Campos Vacios ,Ingresar Datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo Sentimos Ha Ocurrido un Error, Vuelva a Intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexcion.desconectar();
            }
        }

        private void Existencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'jKBeautyProducto.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.jKBeautyProducto.Productos);
            dataGridView1.DataSource = productos.dataTable();
            ID.Focus();
            groupBox1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID.Text = "";
            Bodega.Text = "";
            Tienda.Text = "";
            textBox1.Text = "";
            Cantidad.Text = "";
            groupBox1.Visible = false;
            ID.Focus();
        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void Bodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void Tienda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
