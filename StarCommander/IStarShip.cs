using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander
{
    public interface IStarShip
    {
        void Advance();
        void Retreat();
        void Attack();
    }
}
