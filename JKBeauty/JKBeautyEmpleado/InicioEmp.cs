using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JKBeauty;
using Milibreria;

namespace JKBeautyEmpleado
{
    public partial class InicioEmp : Form
    {
        public InicioEmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string CMD = string.Format("Select * FROM Empleados WHERE Usuario='{0}' AND Contraseña='{1}' AND Cargo='{2}'", txt_usuario.Text.Trim(), txt_contraseña.Text.Trim(), cmb_tipo.SelectedItem);
                DataSet ds = Utilidades.Ejecutar(CMD);

                string user = ds.Tables[0].Rows[0]["Usuario"].ToString().Trim();
                string pass = ds.Tables[0].Rows[0]["Contraseña"].ToString().Trim();
                string tip = ds.Tables[0].Rows[0]["Cargo"].ToString().Trim();

                if (user == txt_usuario.Text.Trim() && pass == txt_contraseña.Text.Trim() && tip == cmb_tipo.SelectedItem.ToString())
                {
                    //MessageBox.Show("se ha iniciado");

                    if (txt_usuario.Text == "" || txt_contraseña.Text == "")
                    {
                        lbl_error.Text = "Ingrese Usuario y contraseña";
                    }
                    if (cmb_tipo.SelectedIndex == 0)
                    {
                        lbl_error.Text = "Bienvenido Administrador";
                        //AQUI SE PONE LA CLASE DEL FORMURALIO A MOSTRAR, EJEMPLO: menuAdmin.Show
                        this.Hide();
                        LogearAdmin logear = new LogearAdmin();
                        logear.Show();
                    }
                    else if (cmb_tipo.SelectedIndex == 1)
                    {
                        lbl_error.Text = "Bienvenido Agente de ventas";
                        //AQUI SE PONE LA CLASE DEL FORMURALIO A MOSTRAR, EJEMPLO: menuAgente.Show
                        this.Hide();
                        LogearEmpleado logear = new LogearEmpleado();
                        logear.Show();

                    }

                }
                else
                {
                    MessageBox.Show("Usuario y contraseña incorrecta");
                }


            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
                txt_usuario.Clear();
                txt_contraseña.Clear();
            }
        }
    }
}
