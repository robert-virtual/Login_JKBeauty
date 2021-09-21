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
using AccesoProcedimiento;
using System.Data.SqlClient;

namespace General
{
    public partial class Proveedores : Form
    {
        Conexcion conexcion = new Conexcion();
        Validar validar = new Validar();
        public Proveedores()
        {
            InitializeComponent();
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

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                conexcion.conectar();
                string query = "INSERT INTO proveedores(cod_proveedor,nom_proveedor,direccion_proveedor,tel_propietario,correo_proveedor,productos_proveedor) VALUES(@Cod,@Nombre,@Dir,@Tel,@Correo,@Producto)";
                SqlCommand command = new SqlCommand(query,conexcion.cn);
                if (ID.Text != "")
                {
                    if (Nombre.Text != "")
                    {
                        if (Producto.Text != "")
                        {
                            command.Parameters.AddWithValue("@Cod", Convert.ToInt32(ID.Text));
                            command.Parameters.AddWithValue("@Nombre",Nombre.Text);
                            command.Parameters.AddWithValue("@Dir", Direccion.Text);
                            command.Parameters.AddWithValue("@Tel", Telefono.Text);
                            command.Parameters.AddWithValue("@Correo",Correo.Text);
                            command.Parameters.AddWithValue("@Producto", Producto.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Proveedor Agregado", "Informacion", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("El Campo Producto esta vacio", "Informacion", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo Nombre esta vacio", "Informacion", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Campos vacios no son aceptados", "Informacion", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo Sentimos Ha Ocurrido un Error, Vuelva a Intentar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            Direccion.Text = "";
            Telefono.Text = "";
            Correo.Text = "";
            Producto.Text = "";
        }
    }
}
