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
    public partial class ColegioForm : Form
    {
        JCEEntities2 db = new JCEEntities2();
        public ColegioForm()
        {
            InitializeComponent();
            GetRecintos();
            GetColegios();
            GetCombos();
        }


        private void Col(object sender, EventArgs e)
        {

        }
        void GetRecintos()
        {
            var recinto = db.recintoes.ToList();
            dgvRecinto.DataSource = recinto.ToList();
        }
        void GetColegios()
        {
            var colegios = db.Colegios.ToList();
            dgvColegio.DataSource = colegios.ToList();
        }
        void GetCombos()
        {
            var sector = db.sectors.ToList();
            cbSector.ValueMember = "id";
            cbSector.DisplayMember = "nombre";
            cbSector.DataSource = sector;

            var recinto = db.recintoes.ToList();
            cbRecinto.ValueMember = "id";
            cbRecinto.DisplayMember = "nombre";
            cbRecinto.DataSource = recinto;

        }
    }
}
