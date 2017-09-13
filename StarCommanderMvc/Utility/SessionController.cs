using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.BattleFields;
using StarCommanderMvc.Models;
using System.Web;
using System.Web.Mvc;

namespace StarCommanderMvc.Utility
{
    public class SessionController
    {
        public static Battle GetSessionOrNewBattle(Battle battle, object sv)
        {
            if (battle == null)
            {
                battle = new Battle();
            }

            if (sv != null)
            {
                IBattleField myBattleField = (IBattleField)sv;
                battle.myBattleField = myBattleField;
            }

            return battle;
        }
    }
}
