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

namespace General
{
    public partial class Marcas : Form
    {
        Conexcion conexcion = new Conexcion();
        AccesoDatos.Proveedores proveedores = new AccesoDatos.Proveedores();
        public Marcas()
        {
            InitializeComponent();
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'jKBeautyProveedores.proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.jKBeautyProveedores.proveedores);
            ID.Focus();
            groupBox1.Visible = false;
            dataGridView1.DataSource = proveedores.dataTable();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Marca (Id_marca,Descripcion,Nombre_marca,Proveedor) VALUES (@IDMarca,@Descrip,@Nombre,@Cproveedor)";
                conexcion.conectar();
                SqlCommand comand = new SqlCommand(query, conexcion.cn);
                if (ID.Text != "")
                {
                    if (Marca.Text != "")
                    {
                        if (Descripcion.Text != "")
                        {
                            comand.Parameters.AddWithValue("@IDMarca", Convert.ToInt32(ID.Text));
                            comand.Parameters.AddWithValue("@Descrip", Descripcion.Text);
                            comand.Parameters.AddWithValue("@Nombre", Marca.Text);
                            comand.Parameters.AddWithValue("@Cproveedor", textBox1.Text);
                            comand.ExecuteNonQuery();
                            MessageBox.Show("Datos Agregados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Descripcion esta Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Marca esta Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void button2_Click(object sender, EventArgs e)
        {
            ID.Text = "";
            Descripcion.Text = "";
            Marca.Text = "";
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
