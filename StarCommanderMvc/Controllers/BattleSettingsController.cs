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
    public class BattleSettingsController : Controller
    {
        public ActionResult Index(Battle battle)
        {
            battle = SessionController.GetSessionOrNewBattle(battle, Session["BattleField"]);

            if (battle.myBattleField == null)
            {
                battle.myBattleField = BattleFieldFactory.CreateBattleField(battle.battleFieldType);
                Session.Add("BattleField", battle.myBattleField);
            }
            
            if (battle.HasBattleField)
            {
                return RedirectToRoute("Default", new { controller = "Battle", action = "Index" });
            }
            return View(battle);
        }
    }
}
