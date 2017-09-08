using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StarCommanderMvc.Models;

namespace StarCommanderMvc.Controllers
{
    public class BattleController : Controller
    {
        
        // GET: Battle
        public ActionResult Index()
        {
            return View(new Battle());
            //return View("BattleSettings", new BattleSettings());
            //return View("FleetSettings", new FleetSettings());
            //return View("BattleResults", new BattleResults());
        }
    }
}