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
    public partial class FormPrincipal : Form
    {
        private List<Ciclo> ciclos;
        private Ciclo cicloActual;

        GestorDatos gestor;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
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
            txtNombreCiclo.Text = cicloActual.Nombre;
            txtAlumnosDelCiclo.Text = cicloActual.Alumnos.Count.ToString();

            //dgvAlumnosDelCiclo
            dgvAlumnosDelCiclo.DataSource = (from alumn in cicloActual.Alumnos
                                             select new { alumn.Nombre, alumn.Telefono, alumn.Aprobado}).ToList();

            //Lista de Alumnos del ciclo ya asignados
            var alumnosAsignadosList = (from alumn in cicloActual.Alumnos
                                        where alumn.FCT != null
                                        select new { alumn.NMatricula, alumn.Nombre, alumn.Telefono, alumn.Aprobado, alumn.IdCiclo, alumn.Ciclo, alumn.FCT }).ToList();
            //dgvAlumnosAsignados
            dgvAlumnosAsignados.DataSource = (from alumn in alumnosAsignadosList
                                              where alumn.FCT != null
                                              select new { alumn.Nombre, Empresa = alumn.FCT.Empresa.Nombre }).ToList();

            //Numero de alúmnos del ciclo asignados
            txtAlumnosAsignados.Text = alumnosAsignadosList.Count().ToString();

            //Empresas para el ciclo actual
            dgvEmpresasParaElCiclo.DataSource = (from oferta in cicloActual.OfertasFCTs
                                       select new { Empresa= oferta.Empresa.Nombre, oferta.Empresa.TelefonoContacto, Solicitudes = oferta.Cantidad,Asignadas = oferta.Empresa.FCTs.Count }).ToList();
        }
    }
}