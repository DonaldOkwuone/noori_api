using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NooriApplication.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {

        public Task<IEnumerable<T>> getAll();

        public Task<int> AddAsync(T entity);

        public Task<T> getById(int Id);

        public Task<int> UpdateAsync(T entity);

        public Task<int> DeleteAsync(int id);


    }
}
