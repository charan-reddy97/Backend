using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBasics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        IConfiguration config;

        public TestController(IConfiguration config)
        {
            this.config = config;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var ClientName = config.GetValue<string>("Client:Name");
            var dbconstr = config.GetValue<string>("Client:DataBaseConnection");
            return Ok(new { Client = ClientName, DataBase = dbconstr });
        }
    }
}
