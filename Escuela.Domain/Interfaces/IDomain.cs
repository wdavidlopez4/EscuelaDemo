using Escuela.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.Domain.Interfaces
{
    public interface IDomain<T> where T : EscuelaBase
    {
        public Task<T> GetObjet();

        public Task<IEnumerable<T>> GetAllObjet();

        public Task<bool> AddObjet();

        public Task<bool> Update();
    }
}
