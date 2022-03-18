using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NooriApplication.Interfaces;
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
        [HttpGet]
        public void AddUser()
        {
            _unitOfWork.UserRepository.AddAsync(User user);

        }
    }
}
