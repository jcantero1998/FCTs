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

    }
}
