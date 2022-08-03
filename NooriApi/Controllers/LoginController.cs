using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NooriInfrastructure.Services;
using NooriApplication.Interfaces;
using NooriEntity;

namespace NooriApi.Controllers
{
    [Route("api/[controller]")]
 
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
   

        // GET api/values/5
        [HttpGet("{phonenumber},{password}")]
        public async Task<IActionResult> Get(string phonenumber, string password)
        {
            //retrieve information from database
            var user = await _loginService.ValidateUser(phonenumber, password);
            return Ok(user);
        }

        // POST api/values
      
    }
}

 