using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.Ships
{
    public abstract class StarShip : IStarShip
    {
        public StarShip()
        {
            Power = 50;
            Size = 50;
            Speed = 50;
            Armor = 50;
        }

        public int Size { get ; set; }
        public int Speed { get; set; }
        public int Armor { get; set; }
        public int Power { get; set; }

        public void Advance()
        {
            throw new NotImplementedException();
        }

        public void Retreat()
        {
            throw new NotImplementedException();
        }
        
        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
