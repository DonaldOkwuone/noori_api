using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NooriApplication.Interfaces;
using NooriEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NooriApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUnitOfWork unitofwork)
        {
            _logger = logger;
            _unitOfWork = unitofwork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            //_unitOfWork.UserRepository.AddAsync(new Users (){username="Nkem", address="HALIM",birthday="31-03-31" });
            var users = await _unitOfWork.UserRepository.getAll();
            var rng = new Random();
            return Ok(users);
        }

        [HttpPost]
        //[Route("getResult")]
        public async Task<IActionResult> Post([FromBody] Users users)
        {
            var result = await _unitOfWork.UserRepository.AddAsync(users);
            return Ok(result);
        }
    }
}
