using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace openclass_helloworld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();          // Equivaut à : return View("Index");      
        }
    }
}