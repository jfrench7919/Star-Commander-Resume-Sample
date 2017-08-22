using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.Ships
{
    public interface IStarShip
    {
        int Size { get; set; }
        int Speed { get; set; }
        int Armor { get; set; }
        int Power { get; set; }

        void Advance();
        void Retreat();
        void Attack();
    }
}
