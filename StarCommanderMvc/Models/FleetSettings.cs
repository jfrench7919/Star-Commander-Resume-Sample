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
        [Display(Name = "Configuration")]
        public FleetConfigurationType fleetConfigurationType { get; set; } = FleetConfigurationType.Select;
        [Required()]
        [Display(Name = "Stratagey")]
        public BattleStratageyType battleStratageyType { get; set; } = BattleStratageyType.Select;
    }
}