using NooriApplication.Data;
using NooriEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NooriInfrastructure.Services
{
    public class RegisterService
    {
        private readonly NooriDbContext _dbContext;
        public RegisterService(NooriDbContext nooriDBContext)
        {
            this._dbContext = nooriDBContext;
        }

        //Register Use

        public async void RegisterUser(Users user)
        {

            await this._dbContext.AddAsync(user);
            this._dbContext.SaveChanges();

        }
    }
}
