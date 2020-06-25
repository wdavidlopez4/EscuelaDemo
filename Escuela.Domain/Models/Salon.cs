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

        public Salon(): base()
        {

        }

        public Salon(string localizacion, string descripcion, string id): base(id)
        {
            this.Localizacion = localizacion;
            this.Descripcion = descripcion;
        }
    }
}
