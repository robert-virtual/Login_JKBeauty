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
    public partial class VistaExistencia : Form
    {
        Existencia existencia = new Existencia();
        Conexcion conexcion = new Conexcion();
        public VistaExistencia()
        {
            InitializeComponent();
        }

        private void VistaExistencia_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            datagridview1.DataSource = existencia.dataTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexcion.conectar();
                string eliminar = "DELETE  FROM [dbo].[Existencias] WHERE Id_existencias = @Id_existencias";
                SqlCommand command = new SqlCommand(eliminar, conexcion.cn);

                command.Parameters.AddWithValue("@Id_existencias", Id_existencias.Text);

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
            button2.Visible = true;
            try
            {
                conexcion.conectar();
                string modificar = "UPDATE Existencias SET Producto=@ID_Producto,cantidad_existencias=@cantidad ,cantidad_bodega=@bodega,Cantidad_tienda=@tienda WHERE Id_existencias = @Id_existencias";
                SqlCommand command = new SqlCommand(modificar, conexcion.cn);
                command.Parameters.AddWithValue("@Id_existencias", int.Parse(Id_existencias.Text));
                command.Parameters.AddWithValue("@ID_Producto", productosExistencia.Text);
                command.Parameters.AddWithValue("@cantidad", int.Parse(cantidad_existencias.Text));
                command.Parameters.AddWithValue("@bodega", int.Parse(cantidad_bodega.Text));
                command.Parameters.AddWithValue("@tienda", int.Parse(Cantidad_tienda.Text));
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
            Id_existencias.Text = datagridview1.CurrentRow.Cells[0].Value.ToString();
            productosExistencia.Text = datagridview1.CurrentRow.Cells[4].Value.ToString();
            cantidad_existencias.Text = datagridview1.CurrentRow.Cells[1].Value.ToString();
            cantidad_bodega.Text = datagridview1.CurrentRow.Cells[2].Value.ToString();
            Cantidad_tienda.Text = datagridview1.CurrentRow.Cells[3].Value.ToString();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = existencia.dataTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datagridview1.DataSource = existencia.dataTable();
        }
    }
}
