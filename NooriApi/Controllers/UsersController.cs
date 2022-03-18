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
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork, ILogger<UsersController> logger)
        {
            this._unitOfWork = unitOfWork;
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(Users user)
        {
            var result = await this._unitOfWork.UserRepository.AddAsync(user);
            return Ok(result);
        }
    }
}
