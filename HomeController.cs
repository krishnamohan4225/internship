using BiharITI.DATA;
using System;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;

namespace BiharITI.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public ActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculator(int? num1, int? num2)
        {
            int? sum = num1 + num2;
            ViewBag.num1 = num1;
            ViewBag.num2 = num2;
            ViewBag.sum = sum;
            return View();
        }
    }
}
