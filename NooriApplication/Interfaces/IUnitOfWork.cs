using System;
using System.Collections.Generic;
using System.Text;

namespace NooriApplication.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
    }
}
