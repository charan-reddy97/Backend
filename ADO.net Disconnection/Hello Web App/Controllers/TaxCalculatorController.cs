using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Web_App.Controllers
{
    [Route("/tax")]
    public class TaxCalculatorController : Controller
    {
        int tax;
        public IActionResult TaxCal(int FN)
        {
            if (Request.Method == "POST")
            {
                if (FN >= 200000 && FN <= 500000)
                {
                    tax = (int)(FN *0.1);
                }
                else if (FN > 500000 && FN <= 7000)
                {
                    tax = (int)(FN * 0.2);
                }
                else 
                {
                    tax = (int)(FN * 0.3);
                }
                ViewBag.result = tax;
            }
            
            return View();
        }
    }
}
