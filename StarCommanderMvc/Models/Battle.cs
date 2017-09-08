using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarCommanderMvc.Models
{
    public class Battle : StarCommander.BattleFields.BattleField
    {
        public BattleSettings battleSettings { get; set; } = new BattleSettings();
        public FleetSettings fleetSettings { get; set; } = new FleetSettings();
        public BattleResults battleResults { get; set; } = new BattleResults();
    }
}