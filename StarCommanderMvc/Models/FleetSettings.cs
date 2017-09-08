using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StarCommander.Types;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace StarCommanderMvc.Models
{
    public class FleetSettings
    {
        [Required()]
        [Display(Name = "Configeration")]
        public FleetConfigerationType fleetConfigerationType { get; set; } = FleetConfigerationType.Select;
        [Required()]
        [Display(Name = "Stratagy")]
        public BattleStratagyType battleStratagyType { get; set; } = BattleStratagyType.Select;
    }
}