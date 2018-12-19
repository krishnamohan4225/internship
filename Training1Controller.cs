using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Training_2.Controllers
{
    public class Training1Controller : Controller
    {
        // GET: Training1
        public ActionResult Index()
        {
            return View();
        }


        //code to send data from view to controller using form tag in view and request object in controller
        [HttpPost]
        public ActionResult postdata()
        { 
            string myname = Request["myname"];
            string mycity = Request["mycity"];
            ViewBag.myname = myname;
            ViewBag.mycity = mycity;
            return View("Index");
        }

        [HttpPost]
        public ActionResult postdata_formcollection(FormCollection f)
        {
            string myname = f["myname"];
            string mycity = f["mycity"];
            ViewBag.myname = myname;
            ViewBag.mycity = mycity;
            return View("Index");
        }


    }
}