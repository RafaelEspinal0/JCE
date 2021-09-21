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
        JCEEntities1 db = new JCEEntities1();
        public NacionalidadForm()
        {
            InitializeComponent();
            GetPaises();
            GetOcupaciones();
        }

        void GetPaises()
        {
            var paises = db.nacionalidad.ToList();
            dgvNac.DataSource = paises.ToList();
        }
        void GetOcupaciones()
        {
            var ocupaciones = db.ocupacion.ToList();
            dgvOcup.DataSource = ocupaciones.ToList();
        }
    }
}
