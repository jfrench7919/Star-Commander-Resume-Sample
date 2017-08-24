using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.AttackImplement
{
    public abstract class AttackImplement : IAttackImplement
    {
        public int Power { get; set; }
    }
}
