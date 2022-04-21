using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NooriApplication.Interfaces;
using Dapper;
using NooriEntity;
using System.Threading.Tasks;

namespace NooriInfrastructure.Services
{
    public class LoginService : ILoginService
    {
        private IConfiguration _configuration;

        public LoginService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<Users> ValidateUser(string phoneno, string password)
        {
            var SQL = "SELECT * FROM NOORI_USERS WHERE phoneno = @phoneno AND password = @password";
            using(var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await  connection.QuerySingleOrDefaultAsync<Users>(SQL, new { phoneno = phoneno, password = password });
                
                return result;
            }
        }
    }
}

