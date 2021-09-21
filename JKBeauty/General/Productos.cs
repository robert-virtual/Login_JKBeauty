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
using AccesoProcedimiento;

namespace General
{
    public partial class Productos : Form
    {
        Conexcion conexcion = new Conexcion();
        Validar validar = new Validar();
        AccesoDatos.Marcas marcas = new AccesoDatos.Marcas();
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'jKBeautyMarcas.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.jKBeautyMarcas.Marca);
            dataGridView1.DataSource = marcas.dataTable();
            groupBox1.Visible = false;
            ID.Focus();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Productos(ID_Producto,Nombre_Producto,Existencia,Precio_Actual,Fecha_Vencimiento,Marca) VALUES(@Id,@Nombre,@Exis,@Precio,@FechaVen,@Mar)";
                conexcion.conectar();
                SqlCommand comand = new SqlCommand(query,conexcion.cn);
                if (ID.Text != "")
                {
                    if (Nombre.Text != "")
                    {
                        if (Precio.Text != "")
                        {
                            if (validar.EsFlotante(Precio.Text))
                            {
                                if (FechaVencimiento.Text != "")
                                {
                                    if (validar.esfecha(FechaVencimiento.Text))
                                    {
                                        comand.Parameters.AddWithValue("@Id", Convert.ToInt32(ID.Text));
                                        comand.Parameters.AddWithValue("@Nombre", Nombre.Text);
                                        comand.Parameters.AddWithValue("@Exis", Convert.ToInt32(Existencia.Text));
                                        comand.Parameters.AddWithValue("@Precio", Convert.ToDouble(Precio.Text));
                                        comand.Parameters.AddWithValue("@FechaVen", DateTime.Parse(FechaVencimiento.Text));
                                        comand.Parameters.AddWithValue("@Mar", textBox1.Text);
                                        comand.ExecuteNonQuery();

                                        MessageBox.Show("Productos Agregados correctamente");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Campo de la Fecha Vacia No Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Campo de la Fecha Vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Precio No Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Precio del producto Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nombre del Producto Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Campos Vacios no aceptados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Nombre.Text = "";
            Existencia.Text = "";
            Precio.Text = "";
            FechaVencimiento.Text = "";
            textBox1.Text = "";
            groupBox1.Visible = false;
        }

        private void Precio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Existencia_KeyPress(object sender, KeyPressEventArgs e)
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
