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
    public partial class MunicipioForm : Form
    {
        JCEEntities1 db = new JCEEntities1();
        public MunicipioForm()
        {
            InitializeComponent();
            GetProvincias();
            GetMunicipios();
        }
        void GetProvincias()
        {
            var provincias = db.provincia.ToList();
            dgvProv.DataSource = provincias.ToList();
        }
        void GetMunicipios()
        {
            var municipios = db.municipio.ToList();
            dgvMun.DataSource = municipios.ToList();
        }
    }
}
