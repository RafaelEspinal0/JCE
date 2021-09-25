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
    public partial class SectorForm : Form
    {
        JCEEntities2 db = new JCEEntities2();
        public SectorForm()
        {
            InitializeComponent();
            getSector();
            GetCombos();
        }

        void getSector()
        {
            var sectores = db.sectors.ToList();
            dgvSector.DataSource = sectores.ToList();
        }

        void GetCombos()
        {
            var municipio = db.municipios.ToList();
            cbMunicipio.ValueMember = "id";
            cbMunicipio.DisplayMember = "nombre";
            cbMunicipio.DataSource = municipio;


        }
    }
}
