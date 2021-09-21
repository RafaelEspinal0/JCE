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
        JCEEntities1 db = new JCEEntities1();
        public SectorForm()
        {
            InitializeComponent();
            getSector();
        }

        void getSector()
        {
            var sectores = db.sector.ToList();
            dgvSector.DataSource = sectores.ToList();
        }
    }
}
