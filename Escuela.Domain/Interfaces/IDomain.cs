using Escuela.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.Domain.Interfaces
{
    public interface IDomain<T>
    {
        public Task<T> GetObjet();

        public Task<IEnumerable<T>> GetAllObjet();

        public Task<bool> AddObjet(T obj);

        public Task<bool> Update(T obj);
    }
}
