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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

       

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMant_Click(object sender, EventArgs e)
        {
            subMant.Visible = true;
        }

        private void btnMCed_Click(object sender, EventArgs e)
        {
            subMant.Visible = false;
            abrirForm(new ColegioForm());
        }

        private void btnMUser_Click(object sender, EventArgs e)
        {
            subMant.Visible = false;
            abrirForm(new UserForm());
        }
        void abrirForm(object form)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
                Form f = form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(f);
                this.panelContenedor.Tag = f;
                f.Show();
        }
        private void btnCed_Click(object sender, EventArgs e)
        {
            abrirForm(new cedulas());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirForm(new inicio());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que quieres cerrar sesion?", "Precaución",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnMCol_Click(object sender, EventArgs e)
        {
            subMant.Visible = false;
            abrirForm(new ColegioForm());
        }

        private void btnMMun_Click(object sender, EventArgs e)
        {
            subMant.Visible = false;
        }

        private void btnMPais_Click(object sender, EventArgs e)
        {
            subMant.Visible = false;
        }

        private void btnMOcu_Click(object sender, EventArgs e)
        {
            subMant.Visible = false;
        }

        private void btnMPro_Click(object sender, EventArgs e)
        {
            subMant.Visible = false;
        }

        private void btnMSec_Click(object sender, EventArgs e)
        {
            subMant.Visible = false;
        }
    }
}
