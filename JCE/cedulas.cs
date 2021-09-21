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
    public partial class cedulas : Form
    {
        JCEEntities1 db = new JCEEntities1();
        public cedulas()
        {
            InitializeComponent();
           
        }

        void GetCedulas()
        {
            try
            {
                var users = db.sp_get_cedulas().ToList();

                dgvRecords.DataSource = users.ToList();
            }
            catch(Exception e)
            {

            }
            
        }

        void abrirForm(object form)
        {
            if (this.Controls.Count > 0)
                this.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Controls.Add(f);
            this.Tag = f;
            f.Show();
        }

        private void btnAgrCed_Click(object sender, EventArgs e)
        {
            abrirForm(new agrCedulas());
        }

        private void cedulas_Load(object sender, EventArgs e)
        {
            GetCedulas();
        }
    }
}
