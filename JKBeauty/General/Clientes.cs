using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoConexcion;
using System.Data.SqlClient;

namespace General
{
    public partial class Clientes : Form
    {
        Conexcion conexcion = new Conexcion();
        public Clientes()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (ID.Text != "")
                {
                    string query = "INSERT INTO Table_Cliente(Id_Cliente,Primer_Nombre,Segundo_Nombre,Primer_Apellido,Direccion,Telefono,Correo) VALUES(@Id,@PrNombre,@SgNombre,@PrApellido,@Direccion,@Telefono,@Correo)";
                    conexcion.conectar();
                    SqlCommand comand = new SqlCommand(query,conexcion.cn);
                    comand.Parameters.AddWithValue("@Id",ID.Text);
                    comand.Parameters.AddWithValue("@PrNombre", PrimerNombre.Text);
                    comand.Parameters.AddWithValue("@SgNombre", SegundoNombre.Text);
                    comand.Parameters.AddWithValue("@PrApellido", PrimerApellido.Text);
                    comand.Parameters.AddWithValue("@Direccion", Direccion.Text);
                    comand.Parameters.AddWithValue("@Telefono", Telefono.Text);
                    comand.Parameters.AddWithValue("@Correo",Correo.Text);
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Clientes Agregados Corecctamente");
                }
                else
                {
                    MessageBox.Show("No se pueden ingresar campos en blancos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            PrimerNombre.Text = "";
            SegundoNombre.Text = "";
            PrimerApellido.Text = "";
            Direccion.Text = "";
            Telefono.Text = "";
            Correo.Text = "";
            ID.Focus();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
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

        private void Telefono_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
