using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Web_App.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        string message = "Hello Charan How are you doing";
        public IActionResult Index()
        {
            int a = 20;
            int b = 70;
            int sum = a + b;
            ViewBag.Sum = sum;
            string color = "green";
            ViewBag.Color = color;
            string[] friuts = { "Apple", "Banana", "Orange" };
            ViewBag.Fruit = friuts;
            //string message = "Hello Charan How are you doing";
            ViewBag.welcome = message;
            return View();
        }
        [Route("aboutus")]
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
