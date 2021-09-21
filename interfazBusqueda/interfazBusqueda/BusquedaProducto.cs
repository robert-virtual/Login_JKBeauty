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
using System.Data.Sql;


namespace interfazBusqueda
{
    public partial class BusquedaProducto : Form
    {
        public BusquedaProducto()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog =JkBeauty;Integrated security=True");
        
        private void aceptarbn2_Click(object sender, EventArgs e)
        {
            try
            { 
                con.Open();
                int ID_Producto = 0;
                string cod = textBox1.Text;
                string cadena = "Select Nombre_Producto, Existencia, Precio_Actual, Fecha_Vencimiento, Marca from Productos where ID_Producto=" + cod;
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.Parameters.AddWithValue("ID_Producto", ID_Producto);

                SqlDataReader Cliente = cmd.ExecuteReader();

                if (Cliente.Read())
                {
                    textBox6.Text = Cliente["Marca"].ToString();
                    textBox2.Text = Cliente["Nombre_Producto"].ToString();
                    textBox3.Text = Cliente["Existencia"].ToString();
                    textBox4.Text = Cliente["Precio_Actual"].ToString();
                    textBox5.Text = Cliente["Fecha_Vencimiento"].ToString();
                    MessageBox.Show("datos buscados con exito");
                }
                else
                {
                    MessageBox.Show("Lo sentimos datos no registrados");

                }

            }
            catch
            {
                MessageBox.Show("Solo se admiten valores numericos");
            }
            finally 
            {
                con.Close();
            }
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Focus();
        }
    }
}
