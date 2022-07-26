using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Web_App.Controllers
{
    [Route("/calculator")]
    public class CalculatorController : Controller
    {
        public IActionResult Index(int firstnumber, int secondnumber)
        {
            if(Request.Method=="POST")
            {
                int sum = firstnumber + secondnumber;
                ViewBag.Sum = sum;

            }
            return View();
        }
    }
}
