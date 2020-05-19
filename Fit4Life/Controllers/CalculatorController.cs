using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fit4Life.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Fit4Life.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View(new Calculator());
        }

        [HttpPost]
        public ActionResult Index(Calculator c, string calculate)
        {
            if (calculate == "add")
            {
                c.total = c.no2 + c.no1;

            }

            else if (calculate == "min")
            {
                c.total = c.no1 - c.no2;
            }

            else if (calculate == "sub")
            {
                c.total = c.no1 * c.no2;
            }

            else
            {
                c.total = c.no1 - c.no2;
            }

            return View(calculate);
        }
    }
}