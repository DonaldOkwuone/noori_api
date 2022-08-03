using NooriApplication.Data;
using NooriApplication.Interfaces;
using NooriEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NooriInfrastructure.Repository
{
    public class UserDbContextRepo : IUserRepository
    {
        private readonly NooriDbContext _dbContext;
        public UserDbContextRepo(NooriDbContext dbConext)
        {
            _dbContext = dbConext;
        }
        public async Task<int> AddAsync(Users entity)
        {
            await _dbContext.AddAsync(entity);
            int result = _dbContext.SaveChanges();
            return result;
        }

        Task<int> IGenericRepository<Users>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Users>> IGenericRepository<Users>.getAll()
        {
            throw new NotImplementedException();
        }

        Task<Users> IGenericRepository<Users>.getById(int Id)
        {
            throw new NotImplementedException();
        }

        Task<int> IGenericRepository<Users>.UpdateAsync(Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
