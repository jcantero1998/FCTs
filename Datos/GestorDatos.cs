using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class GestorDatos
    {

        public BdFCTsEntities fct;

        public GestorDatos(out string mens)
        {
            mens = "";
            try
            {
                fct = new BdFCTsEntities();
            }
            catch (Exception e)
            {
                mens = "No se ha podido acceder a la base de datos " + e.Message;
            }
        }
        public List<Ciclo> Ciclos(out string mens)
        {
            mens = "";
            try
            {
                return fct.Ciclos.ToList();
            }
            catch (Exception)
            {
                mens = "Error al cargar los ciclos de la base de datos";
                return new List<Ciclo>();
            }
        }
        public List<Profe> Profes(out string mens)
        {
            mens = "";
            try
            {
                return fct.Profes.ToList();
            }
            catch (Exception)
            {
                mens = "Error al cargar los profesores de la base de datos";
                return new List<Profe>();
            }
        }
        public string AsignarEmpresa(Ciclo ciclo, Alumno alumno, Empresa empresa, Profe tutorInstituto, string tutorEmpresa)
        {
            //Que exista el ciclo
            Ciclo cicloComprobar = fct.Ciclos.Find(ciclo.Id);
            if (cicloComprobar == null)
            {
                return $"El ciclo {ciclo.Nombre} no existe";
            }

            //Que exista el alumno y sea del ciclo
            Alumno alumnoComprobar = ciclo.Alumnos.Where(alumn => alumn.NMatricula.Equals(alumno.NMatricula)).SingleOrDefault();
            if (alumnoComprobar == null)
            {
                return $"El alumno {alumno.Nombre} no existe o no es del ciclo {ciclo.Nombre}";
            }

            //No existe el tutor o tutora del instituto 
            Profe profeComprobar = fct.Profes.Find(tutorInstituto.Id);
            if (profeComprobar == null)
            {
                return $"El tutor {tutorInstituto.Nombre} no existe";
            }

            //No existe la empresa
            Empresa empresaComprobar = fct.Empresas.Find(empresa.Id);
            if (empresaComprobar == null)
            {
                return $"La empresa {empresa.Nombre} no existe";
            }
            //Que la empresa haya solicitado alumnos
            var ofertasParaElCiclo = ciclo.OfertasFCTs.Where(ofer => ofer.Empresa.Id.Equals(empresa.Id)).SingleOrDefault();
            if (ofertasParaElCiclo.Cantidad <1)
            {
                return $"la empresa {empresa.Nombre} no ha solicitado ningún alumno para el ciclo {ciclo.Nombre}";
            }

            //Que el alumno haya aprobado el ciclo
            if (alumno.Aprobado==false)
            {
                return $"El alumno {alumno.Nombre} no ha aprobado el ciclo";
            }

            //El alumno ya tiene asignada la empresa
            if (alumno.FCT != null)
            {
                return $"El alumno {alumno.Nombre} ya está asignado a la empresa {alumno.FCT.Empresa.Nombre}";
            }
            //if (alumno.FCT.Empresa.Id == empresa.Id)
            //{
            //    return $"El alumno {alumno.Nombre} ya está asignado a la empresa {empresa.Nombre}";
            //}

            //La empresa ya tiene asignada la cantidad de alumnos pedidos
            if (ofertasParaElCiclo.Cantidad <= ofertasParaElCiclo.Empresa.FCTs.Count)// oferta.Empresa.FCTs.Count
            {
                return $"la empresa {empresa.Nombre} ya tiene asignada la cantidad de alumnos pedidos";
            }

            //Asignar alumno
            fct.FCTs.Add(new FCT(alumno.NMatricula, empresa.Id, tutorInstituto.Id, tutorEmpresa));

            try
            {
                //fct.SaveChangesAsync();
                fct.SaveChanges();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }
    }
}