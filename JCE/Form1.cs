using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JCE
{
    public partial class Form1 : Form
    {
        JCEEntities1 db = new JCEEntities1();
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "Usuario")
            {
                if (txtPass.Text != "Contraseña")
                {
                    doLogin();
                }else
                {
                    mensajeError("Por favor ingrese su contraseña");
                }
            }else
            {
                mensajeError("Por favor ingrese su usuario");
            }
        }

        void doLogin()
        {
            var user = db.Users.FirstOrDefault(x => x.LoginName == txtUser.Text && x.Password == txtPass.Text);
            if (user == null)
            {
                mensajeError("Credenciales invalidas");
                txtPass.Text = "Contraseña";
                return;
            }
            
            
            Dashboard dashboard = new Dashboard();
            dashboard.FormClosed += logOut;
            dashboard.Show();
        
            this.Hide();
        }

        void mensajeError(string msg)
        {
            lblError.Text = "       " + msg;
            lblError.Visible = true;
        }

        void logOut(object sender, FormClosedEventArgs e)
        {
            txtUser.Text = "Usuario";
            txtPass.Text = "Contraseña";
            txtPass.UseSystemPasswordChar = false;
            lblError.Visible = false;
            txtUser.Focus();
            this.Show();
        }
        
    }
}
