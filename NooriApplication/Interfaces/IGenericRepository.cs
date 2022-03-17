using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NooriApplication.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {

        Task<IEnumerable<T>> getAll();

        Task<T> getById();

        Task<int> UpdateAsync(T entity);

        Task<int> DeleteAsync(int id);


    }
}
