using System;
using System.Threading.Tasks;
using NooriEntity;

namespace NooriApplication.Interfaces
{
	public interface ILoginService
	{
        public Task<Users> ValidateUser(string phoneno, string password);
    }
}

