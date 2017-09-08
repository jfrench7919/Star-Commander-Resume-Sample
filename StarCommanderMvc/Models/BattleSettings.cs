using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StarCommander.Types;
using System.ComponentModel.DataAnnotations;

namespace StarCommanderMvc.Models
{
    public class BattleSettings
    {
        [Required()]
        [Display(Name = "Field Size")]
        public BattleFieldType battleFieldType { get; set; } = BattleFieldType.Select;
    }
}