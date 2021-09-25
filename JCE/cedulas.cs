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
        JCEEntities2 db = new JCEEntities2();
        public cedulas()
        {
            InitializeComponent();
            GetCombos();
            
        }

        void GetCedulas()
        {
            var cedulas = db.sp_get_cedulas().ToList();
            dgvRecords.DataSource = cedulas.ToList();
        }

      

        private void btnAgrCed_Click(object sender, EventArgs e)
        {
           
        }

        private void cedulas_Load(object sender, EventArgs e)
        {
            GetCedulas();
        }

        void GetCombos()
        {
            var nacionalidad= db.nacionalidads.ToList();
            cbNacionalidad.ValueMember = "id";
            cbNacionalidad.DisplayMember = "nombre";
            cbNacionalidad.DataSource = nacionalidad;

            var ocupacion = db.ocupacions.ToList();
            cbOcupacion.ValueMember = "id";
            cbOcupacion.DisplayMember = "nombre";
            cbOcupacion.DataSource = ocupacion;

            var colegio = db.Colegios.ToList();
            cbColegio.ValueMember = "id";
            cbColegio.DisplayMember = "colegio_id";
            cbColegio.DataSource = colegio;

            var sector = db.sectors.ToList();
            cbSector.ValueMember = "id";
            cbSector.DisplayMember = "nombre";
            cbSector.DataSource = sector;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Guardar();


        }

        void Guardar()
        {
            try
            {
                var ced = new cedula
                {
                    UniqueID = Guid.NewGuid(),
                    cedula_id = txtNCedula.Text,
                    nombre = txtNom.Text,
                    sangre = txtSangre.Text,
                    sexo = radioButton1.Checked,
                    estado_civil = Convert.ToInt32(cbEstado.SelectedValue),
                    fecha_nacimiento = dtpNacimiento.Value,
                    fecha_expiracion = dtpExpir.Value,
                    direccion = txtDireccion.Text,
                    nacionalidad_id = Convert.ToInt32(cbNacionalidad.SelectedValue),
                    ocupacion_id = Convert.ToInt32(cbOcupacion.SelectedValue),
                    colegio_id = Convert.ToInt32(cbColegio.SelectedValue),

                };
                db.cedulas.Add(ced);

                bool result = db.SaveChanges() > 0;
                GetCedulas();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error al guardar");
                Console.WriteLine(e.Message);
            }
            
        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            dtpExpir.Value = DateTime.Now.AddYears(6);
        }
    }
}
