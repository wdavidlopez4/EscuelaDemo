using System;
using System.Collections.Generic;
using System.Text;

namespace Escuela.Domain.Models
{
    public class EscuelaBase
    {
        public string Id { get; set; }

        public EscuelaBase()
        {

        }

        public EscuelaBase(string Id)
        {
            this.Id = Id;
        }
    }
}
