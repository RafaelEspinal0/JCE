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
    public partial class UserForm : Form
    {
        JCEEntities1 db = new JCEEntities1();
        public UserForm()
        {
            InitializeComponent();
            getUsuarios();
        }

        void getUsuarios()
        {
            var usuarios = db.Users.ToList();
            dgvUser.DataSource = usuarios.ToList();
        }
    }
}
