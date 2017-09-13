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
    public class BattleController : Controller
    {
        //[ValidateAntiForgeryToken]
        public ActionResult Index(Battle battle)
        {
            battle = SessionController.GetSessionOrNewBattle(battle, Session["BattleField"]);
            return View(battle);
        }

        public ActionResult Create(Battle battle)
        {
            battle = SessionController.GetSessionOrNewBattle(battle, Session["BattleField"]);
            battle.myBattleField.StartBattle();
            Session.Add("BattleField", battle.myBattleField);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Battle battle)
        {
            Session.Add("BattleField", null);
            StarCommander.BattleResult.BattleResults.Messages.Clear();
            return RedirectToAction("Index");
        }
    }
}