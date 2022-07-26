using Books.Core.Entities;
using Books.Core.Repository;
using Books.Core.SMS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebApiBasics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        
        
        ISmsService smsService;
        IUserRepository userRepository;
        public LoginController(ISmsService smsService, IUserRepository userRepository)
        {
            this.smsService = smsService;
            this.userRepository = userRepository;
        }
        [HttpPost]
        public IActionResult Post(UserModel user)
        {
            var authuser = userRepository.FindByUserName(user.Email, user.Password);
            if (authuser != null)
            {
                smsService.Sent($"Welcome back to our library {authuser.Name}", "123456789");
                var jwtToken = GenerateJWTToken(authuser.Email, authuser.Role.ToString());

                return Ok(new { Profile=authuser,Token=jwtToken });
            }
            else
            {
                return Unauthorized("Login Failed");
            }
}
        /// <summary>
        /// Generates Token if user is  valid
        /// </summary>
        /// <param name="userName">UserName</param>
        /// <param name="role"></param>
        /// <returns></returns>
        private string GenerateJWTToken(string userName, string role)
        {
            string jwtToken = string.Empty;
            var symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This is My secret "));
            var credentials = new SigningCredentials(symmetricKey, SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, userName));
            claims.Add(new Claim(ClaimTypes.Role, role));

            var token = new JwtSecurityToken("mybook.com", "mybook.com", claims, expires: DateTime.Now.AddDays(7), signingCredentials: credentials);
            jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return jwtToken;
        }
    }
}
