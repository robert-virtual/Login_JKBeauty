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
using AccesoConexcion;

namespace edicion_de_perfil
{
    public partial class Form1 : Form
    {
        Conexcion conexcion = new Conexcion();
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (textBox6.PasswordChar == '\0')
            {
                //pictureBox4.BringToFront();
                textBox6.PasswordChar = '*';
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexcion.conectar();
                string cod = txtID.Text;
                SqlCommand command = new SqlCommand("UPDATE Empleados Set Primer_Nombre = @name1, Segundo_Nombre = @name2, Primer_Apellido = @lastname, Usuario = @user, Contraseña = @contra WHERE IDEmpleado = @ID", conexcion.cn);
                //SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ID", txtID.Text);
                command.Parameters.AddWithValue("@user", txtUser.Text);
                command.Parameters.AddWithValue("@name1", txtFirstName.Text);
                command.Parameters.AddWithValue("@name2", txtSecName.Text);
                command.Parameters.AddWithValue("@lastname", txtLastName.Text);
                command.Parameters.AddWithValue("@contra", txtNuevaContra.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Su perfil ha sido actualizado");
            }


            catch
            {
                MessageBox.Show("Ah ocurrido un eror!! Lo sentimos su perfil no ha sido actualizado");

            }
            finally
            {
                conexcion.desconectar();
            }
          
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            txtNuevaContra.Visible = false;
            txtConfirContra.Visible = false;
            lbConfirContra.Visible = false;
            lbNuevaContra.Visible = false;
            
            SqlCommand cmd = new SqlCommand ("Select * From Empleados Where IDEmpleado=@Id", conexcion.cn);
            cmd.Parameters.AddWithValue("@Id", textBox1.Text);
            conexcion.conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {
                textBox2.Text = registro["Usuario"].ToString();
                textBox3.Text = registro["Primer_Nombre"].ToString();
                textBox4.Text = registro["Segundo_Nombre"].ToString();
                textBox5.Text = registro["Primer_Apellido"].ToString();
                textBox6.Text = registro["Contraseña"].ToString();
                txtID.Text = registro["IDEmpleado"].ToString();
                txtUser.Text = registro["Usuario"].ToString();
                txtFirstName.Text = registro["Primer_Nombre"].ToString();
                txtSecName.Text = registro["Segundo_Nombre"].ToString();
                txtLastName.Text = registro["Primer_Apellido"].ToString();
                txtAcContra.Text = registro["Contraseña"].ToString();
                txtNuevaContra.Text = registro["Contraseña"].ToString();
                txtConfirContra.Text = registro["Contraseña"].ToString();

                if (txtAcContra.PasswordChar == '\0')
                {
                    pictureBox4.BringToFront();
                    txtAcContra.PasswordChar = '*';
                }
            }
            conexcion.desconectar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtNuevaContra.Visible = true;
            txtConfirContra.Visible = true;
            lbConfirContra.Visible = true;
            lbNuevaContra.Visible = true;
            
             if (txtNuevaContra.PasswordChar == '\0')
             {
                txtNuevaContra.PasswordChar = '*';
             }

            if (txtConfirContra.PasswordChar == '\0')
            {
                txtConfirContra.PasswordChar = '*';
            }

        }
       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtAcContra.PasswordChar == '\0')
            {
                pictureBox4.BringToFront();
                txtAcContra.PasswordChar = '*';
            }
            if (txtNuevaContra.PasswordChar == '\0')
            {
                pictureBox4.BringToFront();
                txtNuevaContra.PasswordChar = '*';

            }

            if (txtConfirContra.PasswordChar == '\0')
            {
                pictureBox4.BringToFront();
                txtConfirContra.PasswordChar = '*';

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtAcContra.PasswordChar == '*')
            {
                pictureBox3.BringToFront();
                txtAcContra.PasswordChar = '\0';
                
            }

            if (txtNuevaContra.PasswordChar == '*')
            {
                pictureBox3.BringToFront();
                txtNuevaContra.PasswordChar = '\0';

            }

            if (txtConfirContra.PasswordChar == '*')
            {
                pictureBox3.BringToFront();
                txtConfirContra.PasswordChar = '\0';

            }

        }

       
    }
}
   
