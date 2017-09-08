using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarCommanderMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> test = new List<string>{ "1", "2" };
            ViewBag.Worlds = "Monkey";
            return View();
        }
    }
}