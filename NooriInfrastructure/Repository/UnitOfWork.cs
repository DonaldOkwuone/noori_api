using NooriApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NooriInfrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }
        public IUserRepository UserRepository { get ; set ; }
    }
}
