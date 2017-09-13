using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StarCommander.Types;
using StarCommander.BattleResult;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StarCommanderMvc.Models
{
    public class Battle 
    {
        [Required()]
        [Display(Name = "Battle Field Size")]
        public BattleFieldType battleFieldType { get; set; }
        public IEnumerable<SelectListItem> battleFieldTypes
        {
            get
            {
                return Enum.GetValues(typeof(BattleFieldType))
                                .Cast<BattleFieldType>()
                                .Select(p => new SelectListItem()
                                {
                                    Text = p.ToString(),
                                    Value = ((int)p).ToString()
                                })
                                .ToList();
            }
        }

        [Required()]
        [Display(Name = "Configeration Type")]
        public FleetConfigerationType fleetConfigerationType { get; set; }
        public IEnumerable<SelectListItem> fleetConfigerationTypes
        {
            get
            {
                return Enum.GetValues(typeof(FleetConfigerationType))
                                .Cast<FleetConfigerationType>()
                                .Select(p => new SelectListItem()
                                {
                                    Text = p.ToString(),
                                    Value = ((int)p).ToString()
                                })
                                .ToList();
            }
        }
        [Required()]
        [Display(Name = "Stratagy Type")]
        [Editable(false)]
        public BattleStratagyType battleStratagyType { get; set; }
        public IEnumerable<SelectListItem> battleStratagyTypes
        {
            get
            {
                return Enum.GetValues(typeof(BattleStratagyType))
                                .Cast<BattleStratagyType>()
                                .Select(p => new SelectListItem()
                                {
                                    Text = p.ToString(),
                                    Value = ((int)p).ToString()
                                })
                                .ToList();
            }
        }

        public StarCommander.BattleFields.IBattleField myBattleField { get; set; }

        [Display(Name = "Battle Field Established")]
        public bool HasBattleField { get { return myBattleField != null; } }

        [Display(Name = "Ready for battle?")]
        public bool ReadyToDeploy { get; set; }
    }
}