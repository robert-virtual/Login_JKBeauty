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
using AccesoDatos;
using AccesoConexcion;

namespace Administrador
{
    public partial class VistaMarcas : Form
    {
        Conexcion conexcion = new Conexcion();
        Marcas marcas = new Marcas();
        public VistaMarcas()
        {
            InitializeComponent();
        }

        private void VistaMarcas_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            datagridview1.DataSource = marcas.dataTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexcion.conectar();
                string eliminar = "DELETE  FROM [dbo].[Marca] WHERE Id_marca = @ID";
                SqlCommand command = new SqlCommand(eliminar,conexcion.cn);
                command.Parameters.AddWithValue("@ID", int.Parse(ID.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Datos Eliminados con Exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                string modificar = "UPDATE Marca SET Descripcion=@Descrip,Nombre_Marca=@Nombre,Proveedor=@cod WHERE Id_marca = @ID";
                SqlCommand command = new SqlCommand(modificar, conexcion.cn);

                command.Parameters.AddWithValue("@ID", int.Parse(ID.Text));
                command.Parameters.AddWithValue("@Descrip", Descripcion.Text);
                command.Parameters.AddWithValue("@Nombre", Nombre_Marca.Text);
                command.Parameters.AddWithValue("@cod", Proveedor.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Datos Actualizados Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexcion.desconectar();
            }
        }

        private void datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = datagridview1.CurrentRow.Cells[0].Value.ToString();
            Descripcion.Text = datagridview1.CurrentRow.Cells[1].Value.ToString();
            Nombre_Marca.Text = datagridview1.CurrentRow.Cells[2].Value.ToString();
            Proveedor.Text = datagridview1.CurrentRow.Cells[3].Value.ToString();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = marcas.dataTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = marcas.dataTable();
        }
    }
}
