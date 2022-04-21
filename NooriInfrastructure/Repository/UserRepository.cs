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
        private readonly IConfiguration _configuration;
        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> AddAsync(Users entity)
        {
            entity.date_added = DateTime.Now;
            entity.date_created = DateTime.Now;
            entity.birthday = DateTime.Now;

            string SQL = "INSERT INTO NOORI_USERS (username, email, phoneno, address,password, birthday, date_added, date_created) VALUES (@username, @email, @phoneno, @address, @password, @birthday, @date_added, @date_created)";

            using (var SqlConn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                SqlConn.Open();
                var result = await SqlConn.ExecuteAsync(SQL, entity);
                return result;
            }
        }



        public async Task<int> DeleteAsync(int Id)
        {
            string SQL = "DELETE FROM NOORI_USERS WHERE user_id = @user_id";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(SQL, new { user_id = Id });
                return result;
            }
        }

        public async Task<IEnumerable<Users>> getAll()
        {
            string SQL = "SELECT * FROM NOORI_USERS";

            using (var SqlConn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                SqlConn.Open();
                var result = await SqlConn.QueryAsync<Users>(SQL);
                return result;
            }
        }

        public async Task<Users> getById(int id)
        {
            string SQL = "SELECT * FROM NOORI_USERS WHERE user_id = @user_id";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Users>(SQL, new { user_id = id });
                return result;
            }

        }

        public async Task<int> UpdateAsync(Users entity)
        {
            entity.date_added = DateTime.Now;
            entity.date_created = DateTime.Now;

            string SQL = "UPDATE NOORI_USERS SET username = @username, email = @email, phoneno = @phoneno, address= @address, password = @password, birthday = @birthday, date_added = @date_added, date_created = @date_created WHERE user_id = @user_id";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(SQL, entity);
                return result;
            }

        }
    }
}
