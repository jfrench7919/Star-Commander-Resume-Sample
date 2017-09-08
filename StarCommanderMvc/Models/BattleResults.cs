using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StarCommanderMvc.Models
{
    public class BattleResults
    {
        [Display(Name = "Results")]
        public List<String> results { get; set; } = new List<string>();
    }
}