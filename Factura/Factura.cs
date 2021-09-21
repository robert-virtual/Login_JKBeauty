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

namespace Factura
{
    public partial class Factura : Form
    {
        double total = 0.0;
        double subtotal = 0.0;
        double precio = 0.0;
        int cantidad = 0;
        int descuento = 0;
        double impuest = 0.15;

        Clientes clientes = new Clientes();
        Productos productos = new Productos();
        Conexcion Conexcion = new Conexcion();
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            dataGridView1.DataSource = clientes.dataTable();
            dataGridView2.DataSource = productos.dataTable();
            GuardarFactura.Enabled = false;
            textBox_Precio.Text = precio.ToString();
            textBox_Cantidad.Text = cantidad.ToString();
            textBox_Descuento.Text = descuento.ToString();
            txtDescuento.Text = descuento.ToString();
            txtSubTotal.Text = subtotal.ToString();
            Limpiar.Enabled = false;
        }

        private void BuscarCliente_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
        }

        private void BuscarProducto_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_IdProducto.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox_NombreProducto.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox_Precio.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_IDCliente.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_NombreCliente.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() +" "+dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_Telefono.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_Direccion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void ProcesarDetalle_Click(object sender, EventArgs e)
        {
            GuardarFactura.Enabled = true;
            txtImpuesto.Text = impuest.ToString();
            total = (int.Parse(textBox_Cantidad.Text) * double.Parse(textBox_Precio.Text)-int.Parse(textBox_Descuento.Text));
            int existencia = int.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString());
            if (textBox_IdFactura.Text != "")
            {
                if (int.Parse(textBox_Cantidad.Text) > 0)
                {
                    if (int.Parse(textBox_Cantidad.Text) <= existencia)
                    {
                        dataGridView3.Rows.Add(textBox_IdFactura.Text, textBox_IdFactura.Text, textBox_NombreCliente.Text, textBox_NombreProducto.Text, descrpProducto.Text, textBox_Cantidad.Text, textBox_Precio.Text, total);
                        txtDescuento.Text = textBox_Descuento.Text;
                        txtSubTotal.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error No hay suficientes Articulos para Continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Porfavor Indique la Cantodad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Especificar El Numero de Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = productos.dataTable();
            textBox_IdFactura.Text = "";
            textBox_IDCliente.Text = "";
            textBox_NombreCliente.Text = "";
            textBox_Telefono.Text = "";
            textBox_Direccion.Text = "";
            textBox_IdProducto.Text = "";
            MetodoPago2.Text = "";
            textBox_NombreProducto.Text = "";
            textBox_Precio.Text = "";
            textBox_Cantidad.Text = "";
            textBox_Descuento.Text = "";
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            dataGridView3.Rows.Clear();
            txtDescuento.Text = "";
            txtSubTotal.Text = "";
            txtImpuesto.Focus();

        }

        private void textBox_Precio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_IdFactura_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_IDCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_IdProducto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_Descuento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Limpiar.Enabled = true;
            int cant = int.Parse(dataGridView3.CurrentRow.Cells[5].Value.ToString());
            int Exist = Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value.ToString());
            int nuevaexist = Exist - cant;
            string producto = "UPDATE Productos SET Existencia=@NuevaExis WHERE ID_Producto=@ID";
            try
            {
                Conexcion.conectar();
                SqlCommand command = new SqlCommand(producto, Conexcion.cn);
                command.Parameters.AddWithValue("@ID", textBox_IdProducto.Text);
                command.Parameters.AddWithValue("@NuevaExis", nuevaexist);
                command.ExecuteNonQuery();
                MessageBox.Show("Los Datos se han Actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lo sentimos ahocurrido un ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexcion.desconectar();
            }
        }

        private void GuardarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Inser_Datos", Conexcion.cn);
                command.CommandType = CommandType.StoredProcedure;
                Conexcion.conectar();
                if (NombreEmpleado.Text != "")
                {
                    if (textBox_IDCliente.Text != "")
                    {
                        if (MetodoPago2.Text != "")
                        {
                            
                            
                                command.Parameters.AddWithValue("@IdDetalle", textBox_IdFactura.Text);
                                command.Parameters.AddWithValue("@IdFactura", textBox_IdFactura.Text);
                                command.Parameters.AddWithValue("@Descripcion", descrpProducto.Text);
                                command.Parameters.AddWithValue("@Cantidad", textBox_Cantidad.Text);
                                command.Parameters.AddWithValue("@PrecioVenta", textBox_Precio.Text);
                                command.Parameters.AddWithValue("@Producto", textBox_IdProducto.Text);
                                command.Parameters.AddWithValue("@Impuesto", txtImpuesto.Text);
                                command.Parameters.AddWithValue("@MetodoPago", MetodoPago2.Text);
                                command.Parameters.AddWithValue("@Empleado", NombreEmpleado.Text);
                                command.Parameters.AddWithValue("@Cliente", textBox_NombreCliente.Text);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Factura Guardada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            MessageBox.Show("Porfavor Especifique el Metodo de Pago", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Existen Campos Vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Especificar Quien Realiza la Factura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lo sentimos ahocurrido un ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexcion.desconectar();
            }
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double total;
            total = impuest * double.Parse(txtSubTotal.Text);
            txtFactura.Text = total.ToString();
        }
    }
}
