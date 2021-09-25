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
        JCEEntities2 db = new JCEEntities2();
        public MunicipioForm()
        {
            InitializeComponent();
            GetProvincias();
            GetMunicipios();
            GetCombos();
        }
        void GetProvincias()
        {
            var provincias = db.provincias.ToList();
            dgvProv.DataSource = provincias.ToList();
        }
        void GetMunicipios()
        {
            var municipios = db.municipios.ToList();
            dgvMun.DataSource = municipios.ToList();
        }
        void GetCombos()
        {
            var provincia = db.provincias.ToList();
            cbProvincia.ValueMember = "id";
            cbProvincia.DisplayMember = "nombre";
            cbProvincia.DataSource = provincia;


        }
    }
}
