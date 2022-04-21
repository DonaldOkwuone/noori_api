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
        public ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("result");
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
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

 