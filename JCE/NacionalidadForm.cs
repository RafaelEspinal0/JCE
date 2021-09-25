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
    public partial class NacionalidadForm : Form
    {
        JCEEntities2 db = new JCEEntities2();
        public NacionalidadForm()
        {
            InitializeComponent();
            GetPaises();
            GetOcupaciones();
        }

        void GetPaises()
        {
            var paises = db.nacionalidads.ToList();
            dgvNac.DataSource = paises.ToList();
        }
        void GetOcupaciones()
        {
            var ocupaciones = db.ocupacions.ToList();
            dgvOcup.DataSource = ocupaciones.ToList();
        }

        void GuardarPaises()
        {
            try
            {
                var paises = new nacionalidad
                {
                    nombre = txtPaises.Text,
                    
                };

                db.nacionalidads.Add(paises);
                GetPaises();
                txtPaises.Text = string.Empty;


            }
            catch (Exception e)
            {
                Console.WriteLine("Error al guardar");
                Console.WriteLine(e.Message);
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarPaises();
        }
    }
}
