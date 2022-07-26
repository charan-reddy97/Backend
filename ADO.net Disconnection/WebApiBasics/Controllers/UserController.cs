using Books.Core.Entities;
using Books.Core.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBasics.Filters;

namespace WebApiBasics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    
    public class UserController : ControllerBase
    {
          IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        //IUserRepository

        [HttpPost]

        public IActionResult Add(User user)
        {
            userRepository.Add(user);
            return Created($"/api/user/{user.Id}", user);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                userRepository.Delete(id);
                return Ok();
            }
            else
                return BadRequest($"Invalid user Id");
        }
        [HttpPut]

        public IActionResult Update(User user)
        {
            if (user.Id > 0)
            {
                userRepository.Update(user);
                return Ok();
            }
            else
                return BadRequest($"Invalid user Id");
        }
        [HttpGet("byid/{id}")]
        //[Redirect]

        public IActionResult FindUserById(int id)
        {
            if (id > 0)
            {
                var user = userRepository.FindUserById(id);

                if (user != null)
                    return Ok(user);
                else
                    return NotFound($"user with the id:{id} cannot be found");
            }
            else
                return BadRequest($"Invalid user Id");
        }
        [HttpGet]
        //[CheckPerformance]
        public IActionResult GetUsers()
        {
            var users = userRepository.GetUsers();
            return Ok(users);
        }
    }
}
