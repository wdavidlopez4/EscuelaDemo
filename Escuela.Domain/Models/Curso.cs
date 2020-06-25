using System;
using System.Collections.Generic;
using System.Text;

namespace Escuela.Domain.Models
{
    public class Curso : EscuelaBase
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Curso():base()
        {

        }

        public Curso(string nombre, string descripcion, string id):base(id)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
    }
}
