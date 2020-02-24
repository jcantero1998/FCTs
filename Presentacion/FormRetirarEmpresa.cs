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
    public partial class FormRetirarEmpresa : Form
    {
        private List<Ciclo> ciclos;
        private Ciclo cicloActual;
        private Alumno alumnoActual;
        GestorDatos gestor;

        public FormRetirarEmpresa()
        {
            InitializeComponent();
        }

        private void FormRetirarEmpresa_Load(object sender, EventArgs e)
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
        }

        private void cmbCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cicloActual = (Ciclo)cmbCiclos.SelectedItem;

            List<Alumno> listAlumnosDelCicloActual = (from alumn in cicloActual.Alumnos
                                                      select alumn).ToList();
            cmbAlumnos.Items.Clear();
            cmbAlumnos.Items.AddRange(listAlumnosDelCicloActual.ToArray());
            cmbAlumnos.DisplayMember = "Nombre";

        }
        private void cmbAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            alumnoActual = (Alumno)cmbAlumnos.SelectedItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = gestor.ComprobarRetirarEmpresa(cicloActual,alumnoActual);
            if (msg!="")
            {
                MessageBox.Show(msg);
            }
            else
            {
                DialogResult result = MessageBox.Show($"El alumno/a {alumnoActual.Nombre} tiene asignada a la empresa {alumnoActual.FCT.Empresa.Nombre} ¿Deseas eliminar la asignación?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    gestor.RetirarEmpresa(alumnoActual);
                }
            }
        }

    }
}
