using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.AttackImplement
{
    public class PlasmaCannonImplement : AttackImplement
    {
        public PlasmaCannonImplement()
        {

        }

        public override int CalculateDamage()
        {
            Random r = new Random();
            return Power * r.Next(3, 6);
        }
    }
}
