using Escuela.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.DAL.Repository
{
    public class Repositorio<T> : IDomain<T> where T : class
    {
        public Task<bool> AddObjet(T obj)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllObjet()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetObjet()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
