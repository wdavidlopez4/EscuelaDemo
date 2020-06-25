using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Escuela.Domain.Models
{
    public class Salon : EscuelaBase
    {
        public string Localizacion { get; set; }
        public string Descripcion { get; set; }
        public List<Curso> Cursos { get; set; }


        public Salon(): base()
        {

        }

        public Salon(string id, string localizacion, string descripcion, List<Curso> cursos)
            : base(id)
        {
            this.Localizacion = localizacion;
            this.Descripcion = descripcion;
            this.Cursos = cursos;
        }
    }
}
