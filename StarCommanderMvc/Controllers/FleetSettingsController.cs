using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StarCommanderMvc.Models;
using StarCommander.Types;
using StarCommander.Factories;
using StarCommander.Fleets;
using StarCommander.BattleFields;
using StarCommanderMvc.Utility;

namespace StarCommanderMvc.Controllers
{
    public class FleetSettingsController : Controller
    {
        public ActionResult Index(Battle battle)
        {
            battle = SessionController.GetSessionOrNewBattle(battle, Session["BattleField"]);

            IFleet fleet = FleetFactory.CreateFleet(battle.fleetConfigurationType, battle.battleStratageyType);
            if (fleet != null)
            {
                if (battle.myBattleField != null)
                {
                    fleet.EnterField(battle.myBattleField);
                    Session.Add("BattleField", battle.myBattleField);
                }
            }

            if (fleet != null)
            {
                return RedirectToRoute("Default", new { controller = "Battle", action = "Index" });
            }

            return View(battle);
        }
    }
}
