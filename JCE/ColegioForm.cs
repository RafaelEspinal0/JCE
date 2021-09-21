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
        JCEEntities1 db = new JCEEntities1();
        public ColegioForm()
        {
            InitializeComponent();
            GetRecintos();
            GetColegios();
        }


        private void Col(object sender, EventArgs e)
        {

        }
        void GetRecintos()
        {
            var recinto = db.recinto.ToList();
            dgvRecinto.DataSource = recinto.ToList();
        }
        void GetColegios()
        {
            var colegios = db.recinto.ToList();
            dgvColegio.DataSource = colegios.ToList();
        }
    }
}
