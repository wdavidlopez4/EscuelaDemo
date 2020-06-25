using System;
using System.Collections.Generic;
using System.Text;

namespace Escuela.Domain.Models
{
    public class Curso : EscuelaBase
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Salon Salon { get; set; }

        public Curso():base()
        {

        }

        public Curso(string id, string nombre, string descripcion, Salon salon):base(id)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Salon = salon;
        }
    }
}
