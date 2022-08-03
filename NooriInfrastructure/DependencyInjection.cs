using Microsoft.Extensions.DependencyInjection;
using NooriApplication.Interfaces;
using NooriInfrastructure.Repository;
using NooriInfrastructure.Services;
using System;
using System.Collections.Generic;
using System.Text;


namespace NooriInfrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserRepository, UserDbContextRepo>();
            services.AddTransient<ILoginService, LoginService>();
        }
    }
}
