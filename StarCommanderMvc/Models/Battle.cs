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
        [Display(Name = "Configuration Type")]
        public FleetConfigurationType fleetConfigurationType { get; set; }
        public IEnumerable<SelectListItem> fleetConfigurationTypes
        {
            get
            {
                return Enum.GetValues(typeof(FleetConfigurationType))
                                .Cast<FleetConfigurationType>()
                                .Select(p => new SelectListItem()
                                {
                                    Text = p.ToString(),
                                    Value = ((int)p).ToString()
                                })
                                .ToList();
            }
        }
        [Required()]
        [Display(Name = "Stratagey Type")]
        [Editable(false)]
        public BattleStratageyType battleStratageyType { get; set; }
        public IEnumerable<SelectListItem> battleStratageyTypes
        {
            get
            {
                return Enum.GetValues(typeof(BattleStratageyType))
                                .Cast<BattleStratageyType>()
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