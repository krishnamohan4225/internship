using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace calc.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int num1, int num2, string command)
        {
            if (command == "add")
            {
                int result = num1 + num2;
                ViewBag.num1 = num1;
                ViewBag.num2 = num2;
                ViewBag.result = result;
            }

            if (command == "mul")
            {
                int result = num1 * num2;
                ViewBag.num1 = num1;
                ViewBag.num2 = num2;
                ViewBag.result = result;
            }

            if (command == "sub")
            {
                int result = num1 - num2;
                ViewBag.num1 = num1;
                ViewBag.num2 = num2;
                ViewBag.result = result;
            }

            if (command == "div")
            {
                int result = num1 / num2;
                ViewBag.num1 = num1;
                ViewBag.num2 = num2;
                ViewBag.result = result;
            }



            return View();
        }
    }
}
