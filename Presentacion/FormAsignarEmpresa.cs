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
                                   select new { alumn.Nombre,alumn.NMatricula }).ToList();
            cmbAlumnosDelCiclo.Items.AddRange(alumnosDelCiclo.ToArray());
            cmbAlumnosDelCiclo.DisplayMember = "Nombre";

            //Empresas para el ciclo actual
            var empresasParaElCiclo = (from oferta in cicloActual.OfertasFCTs
                                       select new { oferta.Empresa.Nombre, oferta.Empresa, oferta.Empresa.Id}).ToList();
            cmbEmpresasParaElCiclo.Items.AddRange(empresasParaElCiclo.ToArray());
            cmbEmpresasParaElCiclo.DisplayMember = "Nombre";

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

        }
    }
}
