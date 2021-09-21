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
          
        }

      

        private void btnAgrCed_Click(object sender, EventArgs e)
        {
           
        }

        private void cedulas_Load(object sender, EventArgs e)
        {
            GetCedulas();
        }
    }
}
