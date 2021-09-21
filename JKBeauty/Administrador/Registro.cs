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

namespace Administrador
{
    public partial class Registro : Form
    {
        Conexcion conexcion = new Conexcion();
        Validar validar = new Validar();
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'jKBeautyCargos.Cargos' Puede moverla o quitarla según sea necesario.
            this.cargosTableAdapter.Fill(this.jKBeautyCargos.Cargos);
            ID.Focus();
            if (comboBox1.Items.Count > 1)
            {
                comboBox1.SelectedIndex = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID.Text = "";
            PrimerNombre.Text = "";
            SegundoNombre.Text = "";
            Apellido.Text = "";
            Usuario.Text = "";
            Contraseña.Text = "";
            VerificarContraseña.Text = "";
            ID.Focus();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                conexcion.conectar();
                string query = "INSERT INTO Empleados (IDEmpleado,Primer_Nombre,Segundo_Nombre,Primer_Apellido,Usuario,Contraseña,Cargo) VALUES(@IdEmp,@PrNombre,@SgNombre,@PrApellido,@Usuario,@Contraseña,@Cargo)";
                SqlCommand comand = new SqlCommand(query, conexcion.cn);

                if (ID.Text != "")
                {
                    if (Contraseña.Text == VerificarContraseña.Text)
                    {
                        comand.Parameters.AddWithValue("@IdEmp", ID.Text);
                        comand.Parameters.AddWithValue("@PrNombre", PrimerNombre.Text);
                        comand.Parameters.AddWithValue("@SgNombre", SegundoNombre.Text);
                        comand.Parameters.AddWithValue("@PrApellido", Apellido.Text);
                        comand.Parameters.AddWithValue("@Usuario", Usuario.Text);
                        comand.Parameters.AddWithValue("@Contraseña", VerificarContraseña.Text);
                        comand.Parameters.AddWithValue("@Cargo", (((DataRowView)comboBox1.SelectedValue)["Cargo"]));
                        comand.ExecuteNonQuery();
                        MessageBox.Show("Registro exitoso","Informacio",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Las Contaseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lo sentimos a ocurrido un Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                conexcion.desconectar();
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
    }
}
