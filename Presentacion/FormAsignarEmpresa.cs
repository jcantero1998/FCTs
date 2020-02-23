using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormAsignarEmpresa : Form
    {
        private Ciclo cicloActual;
        private List<Ciclo> ciclos;

        GestorDatos gestor;

        public FormAsignarEmpresa()
        {
            InitializeComponent();
        }

        private void FormAsignarEmpresa_Load(object sender, EventArgs e)
        {
            gestor = new GestorDatos(out string mens);
            if (mens != "")
            {
                MessageBox.Show(mens);
                this.Close();
            }
            RecargarCMB();
        }
        private void RecargarCMB()
        {
            String mens = "";

            //Ciclos
            ciclos = gestor.Ciclos(out mens);
            if (mens != "")
            {
                MessageBox.Show(mens);
            }
            else
            {
                cmbCiclos.Items.Clear();
                cmbCiclos.Items.AddRange(ciclos.ToArray());
                cmbCiclos.DisplayMember = "Nombre";
            }
            //Tutor del instituto
            List<Profe> profes = gestor.Profes(out mens);
            if (mens != "")
            {
                MessageBox.Show(mens);
            }
            else
            {
                cmbTutorInstituto.Items.Clear();
                cmbTutorInstituto.Items.AddRange(profes.ToArray());
                cmbTutorInstituto.DisplayMember = "Nombre";
            }
        }

        private void cmbCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cicloActual = (Ciclo)cmbCiclos.SelectedItem;

            //Alumnos Del Ciclo
            var alumnosDelCiclo = (from alumn in cicloActual.Alumnos
                                   select alumn).ToList();
            cmbAlumnosDelCiclo.Text = "";
            cmbAlumnosDelCiclo.Items.Clear();
            cmbAlumnosDelCiclo.Items.AddRange(alumnosDelCiclo.ToArray());
            cmbAlumnosDelCiclo.DisplayMember = "Nombre";

            //Empresas para el ciclo actual
            var empresasParaElCiclo = (from oferta in cicloActual.OfertasFCTs
                                       select oferta.Empresa).ToList();
            cmbEmpresasParaElCiclo.Text = "";
            cmbEmpresasParaElCiclo.Items.Clear();
            cmbEmpresasParaElCiclo.Items.AddRange(empresasParaElCiclo.ToArray());
            cmbEmpresasParaElCiclo.DisplayMember = "Nombre";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

            if (cmbCiclos.Text == "" || cmbAlumnosDelCiclo.Text == "" || cmbEmpresasParaElCiclo.Text == "" || cmbTutorInstituto.Text == "" || txtTutorEmpresa.Text=="")
            {
                MessageBox.Show("Completa todos los campos");
            }
            else
            {
                Ciclo ciclo = (Ciclo)cmbCiclos.SelectedItem;
                Alumno alumno = (Alumno)cmbAlumnosDelCiclo.SelectedItem;
                Empresa empresa = (Empresa)cmbEmpresasParaElCiclo.SelectedItem;
                Profe tutorInstituto = (Profe)cmbTutorInstituto.SelectedItem;
                string tutorEmpresa = txtTutorEmpresa.Text;

                string msg = gestor.AsignarEmpresa(ciclo, alumno, empresa, tutorInstituto, tutorEmpresa);

                if (msg != "")
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    cmbCiclos.Text = "";
                    cmbAlumnosDelCiclo.Text = "";
                    cmbEmpresasParaElCiclo.Text = "";
                    cmbTutorInstituto.Text = "";
                    txtTutorEmpresa.Text = "";
                    RecargarCMB();
                }
            }
        }
    }
}
