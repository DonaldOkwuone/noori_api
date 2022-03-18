using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NooriApplication.Interfaces;
using NooriEntity;
using NooriInfrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NooriApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public IUnitOfWork _unitOfWork { get; set; }

        public UsersController(IUnitOfWork unitOfWork, ILogger<UsersController> logger)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        public Task<int> AddUser(Users user)
        {
            var result =  _unitOfWork.UserRepository.AddAsync(user);
            return result;
        }
    }
}
