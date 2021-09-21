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

namespace Administrador
{
    public partial class VistaCliente : Form
    {
        Conexcion conexcion = new Conexcion();
        Clientes clientes = new Clientes();
        public VistaCliente()
        {
            InitializeComponent();
        }

        private void VistaCliente_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            datagridview1.DataSource = clientes.dataTable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = clientes.dataTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexcion.conectar();
                string eliminar = "DELETE  FROM [dbo].[Table_Cliente] WHERE Id_cliente = @Cod";
                SqlCommand command = new SqlCommand(eliminar,conexcion.cn);

                command.Parameters.AddWithValue("@Cod", int.Parse(ID.Text));

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
                string modificar = "UPDATE Table_Cliente SET Primer_Nombre=@nombre,Segundo_Nombre=@Snombre,Primer_Apellido=@Apellido,Direccion=@dir,Telefono=@tel,Correo=@correo WHERE Id_cliente=@ID";
                SqlCommand command = new SqlCommand(modificar, conexcion.cn);
                command.Parameters.AddWithValue("@ID", ID.Text);
                command.Parameters.AddWithValue("@nombre", PrimerNombre.Text);
                command.Parameters.AddWithValue("@Snombre", SegundoNombre.Text);
                command.Parameters.AddWithValue("@Apellido", PrimerApellido.Text);
                command.Parameters.AddWithValue("@dir", Direccion.Text);
                command.Parameters.AddWithValue("@tel", Telefono.Text);
                command.Parameters.AddWithValue("@correo",Correo.Text);
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

        private void datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = datagridview1.CurrentRow.Cells[0].Value.ToString();
            PrimerNombre.Text = datagridview1.CurrentRow.Cells[1].Value.ToString();
            SegundoNombre.Text = datagridview1.CurrentRow.Cells[2].Value.ToString();
            PrimerApellido.Text = datagridview1.CurrentRow.Cells[3].Value.ToString();
            Direccion.Text = datagridview1.CurrentRow.Cells[4].Value.ToString();
            Telefono.Text = datagridview1.CurrentRow.Cells[5].Value.ToString();
            Correo.Text = datagridview1.CurrentRow.Cells[6].Value.ToString();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = clientes.dataTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = clientes.dataTable();
        }
    }
}
