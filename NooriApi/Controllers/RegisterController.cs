using Microsoft.AspNetCore.Mvc;
using NooriApplication.Interfaces;
using NooriEntity;
using NooriInfrastructure.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NooriApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IUserRepository _repo;
        public RegisterController(IUserRepository userRepo)
        {
            _repo = userRepo;
        }
        // GET: api/<RegisterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

      

        // POST api/<RegisterController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Users user)
        {
            if (user == null)
                return BadRequest("please add a user");

            await _repo.AddAsync(user);

            return Ok(user);

        }


    }
}
