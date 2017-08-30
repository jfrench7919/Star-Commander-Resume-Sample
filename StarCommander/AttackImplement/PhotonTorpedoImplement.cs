using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.AttackImplement
{
    public class PhotonTorpedoImplement : AttackImplement
    {
        public PhotonTorpedoImplement()
        {

        }

        public override int CalculateDamage()
        {
            Random r = new Random();
            return Power * r.Next(2, 3);
        }
    }
}
