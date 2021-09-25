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
        JCEEntities2 db = new JCEEntities2();
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
