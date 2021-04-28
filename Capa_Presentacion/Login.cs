using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Login cr = new Login();
            cr.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string su=txt_usuario.Text;
            string pass=txt_contraseña.Text;
            if (su == "" && pass == "")
            {
                MessageBox.Show("Falta usuario y contraseña ");
            }
            else if (su == "" || pass == "")
            {
                MessageBox.Show("Falta usuario o contraseña ");
            }
            else
            {

                CN_Login usu = new CN_Login();
                SqlDataReader leer;
                usu.Usuario = txt_usuario.Text;
                usu.Password = txt_contraseña.Text;
                leer = usu.IniciarSesion();
                if (leer.Read() == true)
                {
                    this.Hide();
                    Crud c = new Crud();
                    c.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecto!!!!");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
