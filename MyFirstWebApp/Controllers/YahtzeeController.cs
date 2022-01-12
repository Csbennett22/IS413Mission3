using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Controllers
{
    public class YahtzeeController : Controller
    {
        public IActionResult Index()
        {
            //throw new IndexOutOfRangeException();
            return View();
        }

        public IActionResult Gradeform ()
        {
            return View();
        }
    }
}
