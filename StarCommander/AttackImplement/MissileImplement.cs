using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.AttackImplement
{
    public class MissileImplement : AttackImplement
    {
        public MissileImplement()
        {

        }

        public override int CalculateDamage()
        {
            Random r = new Random();
            return Power * r.Next(2, 6);
        }
    }
}
