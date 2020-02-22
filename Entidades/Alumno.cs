//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumno
    {
        public Alumno()
        {
        }

        public Alumno(int nMatricula, string nombre, string telefono, bool aprobado, string idCiclo)
        {
            NMatricula = nMatricula;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Telefono = telefono ?? throw new ArgumentNullException(nameof(telefono));
            Aprobado = aprobado;
            IdCiclo = idCiclo ?? throw new ArgumentNullException(nameof(idCiclo));
        }

        public Alumno(int nMatricula, string nombre, string telefono, bool aprobado, string idCiclo, Ciclo ciclo, FCT fCT) : this(nMatricula, nombre, telefono, aprobado, idCiclo)
        {
            Ciclo = ciclo ?? throw new ArgumentNullException(nameof(ciclo));
            FCT = fCT ?? throw new ArgumentNullException(nameof(fCT));
        }

        public int NMatricula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public bool Aprobado { get; set; }
        public string IdCiclo { get; set; }
    
        public virtual Ciclo Ciclo { get; set; }
        public virtual FCT FCT { get; set; }
    }
}
