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
using AccesoConexcion;
using System.Data.SqlClient;

namespace Administrador
{
    public partial class VistaProveedores : Form
    {
        Proveedores proveedores = new Proveedores();
        Conexcion conexcion = new Conexcion();
        public VistaProveedores()
        {
            InitializeComponent();
        }

        private void VistaProveedores_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            datagridview1.DataSource = proveedores.dataTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexcion.conectar();
                string eliminar = "DELETE  FROM [dbo].[proveedores] WHERE cod_proveedor = @Cod";
                SqlCommand command = new SqlCommand(eliminar,conexcion.cn);

                command.Parameters.AddWithValue("@Cod", cod_proveedor.Text);

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
                string modificar = "UPDATE proveedores SET nom_proveedor=@nombre,direccion_proveedor=@dir," +
                    "tel_propietario=@tel,correo_proveedor=@correo,productos_proveedor=@producto WHERE cod_proveedor = @Cod";
                SqlCommand command = new SqlCommand(modificar, conexcion.cn);
                command.Parameters.AddWithValue("@Cod", int.Parse(cod_proveedor.Text));
                command.Parameters.AddWithValue("@nombre", nom_proveedor.Text);
                command.Parameters.AddWithValue("@dir", direccion_proveedor.Text);
                command.Parameters.AddWithValue("@tel", int.Parse(Telefono.Text));
                command.Parameters.AddWithValue("@correo", Correo.Text);
                command.Parameters.AddWithValue("@producto", productos_proveedor.Text);
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
            cod_proveedor.Text = datagridview1.CurrentRow.Cells[0].Value.ToString();
            nom_proveedor.Text = datagridview1.CurrentRow.Cells[1].Value.ToString();
            direccion_proveedor.Text = datagridview1.CurrentRow.Cells[2].Value.ToString();
            Telefono.Text = datagridview1.CurrentRow.Cells[3].Value.ToString();
            Correo.Text = datagridview1.CurrentRow.Cells[4].Value.ToString();
            productos_proveedor.Text = datagridview1.CurrentRow.Cells[5].Value.ToString();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = proveedores.dataTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = proveedores.dataTable();
        }
    }
}
