using Microsoft.AspNetCore.Mvc;
using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Home()
        {
            return View();
        }
        [HttpGet("students")]
        public IActionResult Studentslist()
        {
            var student = new Student();
            student.Name = "charan";
            ViewBag.name = student.Id = 1;
            student.Marks = 75;
           

            return View();
        }
    }
}
