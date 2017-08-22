using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander
{
    public abstract class StarShip : IStarShip
    {
        public void Advance()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Retreat()
        {
            throw new NotImplementedException();
        }
    }
}
