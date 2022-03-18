using NooriApplication.Interfaces;
using NooriEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace NooriInfrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        IConfiguration _configuration;
        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task<int> AddAsync(Users entity)
        {
            string SQL = "INSERT INTO NOORI_USERS (username, email, phone, address, birthday, dateadded, datecreated) VALUES (@username, @email, @phone, @address, @birthday, @dateadded, @datecreated)";

            using (var SqlConn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                SqlConn.Open();
                var result = SqlConn.ExecuteAsync(SQL, entity);
            }
            throw new NotImplementedException();
        }



        Task<int> IGenericRepository<Users>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Users>> IGenericRepository<Users>.getAll()
        {
            throw new NotImplementedException();
        }

        Task<Users> IGenericRepository<Users>.getById()
        {
            throw new NotImplementedException();
        }

        Task<int> IGenericRepository<Users>.UpdateAsync(Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
