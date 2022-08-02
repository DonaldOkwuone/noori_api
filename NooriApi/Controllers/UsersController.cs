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

        //create user
        [HttpPost]
        public async Task<IActionResult> Post(Users user)
        {
            try
            {
                var result = await this._unitOfWork.UserRepository.AddAsync(user);

                if (result == 1)
                    return Ok("User account created successfully.");
                else
                    return Ok("User not created");

            }
            catch (Exception)
            {

                return Ok("User not created");
            }
        }

        /// <summary>
        /// Get all data
        /// </summary>
        /// no params
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await this._unitOfWork.UserRepository.getAll();
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok("Could not create user");
            }

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var result = await _unitOfWork.UserRepository.getById(id);
            return Ok(result);

        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(Users user)
        {
            var result = await _unitOfWork.UserRepository.UpdateAsync(user);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int Id)
        {
            var result = await _unitOfWork.UserRepository.DeleteAsync(Id);
            return Ok(result);
        }

        
    }
}
