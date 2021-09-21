using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoConexcion;
using AccesoDatos;

namespace Administrador
{
    public partial class VistaProductos : Form
    {
        Conexcion conexcion = new Conexcion();
        Productos productos = new Productos();
        public VistaProductos()
        {
            InitializeComponent();
        }

        private void VistaProductos_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            datagridview1.DataSource = productos.dataTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexcion.conectar();
                string eliminar = "DELETE  FROM [dbo].[Productos] WHERE ID_Producto = @ID";
                SqlCommand command = new SqlCommand(eliminar, conexcion.cn);
                command.Parameters.AddWithValue("@ID", int.Parse(ID.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Datos Eliminados con Exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button2.Visible = true;
                conexcion.conectar();
                string modificar = "UPDATE Productos SET Marca=@IDM,Nombre_Producto=@nombre,Existencia=@Exs,Precio_Actual=@precio,Fecha_Vencimiento=@fecha WHERE ID_Producto = @ID";
                SqlCommand command = new SqlCommand(modificar, conexcion.cn);
                command.Parameters.AddWithValue("@ID", int.Parse(ID.Text));
                command.Parameters.AddWithValue("@IDM", int.Parse(Marca.Text));
                command.Parameters.AddWithValue("@nombre", PrimerNombre.Text);
                command.Parameters.AddWithValue("@Exs", Convert.ToInt32(Existencia.Text));
                command.Parameters.AddWithValue("@precio", double.Parse(Precio_Actual.Text));
                command.Parameters.AddWithValue("@fecha", Fecha_Vencimiento.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Los Datos se han Modificado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Precio_Actual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;

            }
        }

        private void datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = datagridview1.CurrentRow.Cells[0].Value.ToString();
            PrimerNombre.Text = datagridview1.CurrentRow.Cells[1].Value.ToString();
            Existencia.Text = datagridview1.CurrentRow.Cells[2].Value.ToString();
            Precio_Actual.Text = datagridview1.CurrentRow.Cells[3].Value.ToString();
            Fecha_Vencimiento.Text = datagridview1.CurrentRow.Cells[4].Value.ToString();
            Marca.Text = datagridview1.CurrentRow.Cells[5].Value.ToString();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = productos.dataTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = productos.dataTable();
        }
    }
}
