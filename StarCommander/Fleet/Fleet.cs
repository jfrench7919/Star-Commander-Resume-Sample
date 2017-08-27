using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Ships;
using StarCommander.Types;

namespace StarCommander.Fleet
{
    public class Fleet : IFleet
    {
        public Fleet()
        {
            StarShips = new List<IStarShip>();
        }

        public BattleStratagyType BattleStratagyType { get; set; }
        //12000
        public int NumberOfShipSlots { get; set; }
        public List<IStarShip> StarShips { get; set; }

        public int Size
        {
            get
            {
                return StarShips.Sum(x => x.Size);
            }
        }

        public int NumberOfShipSlotsAvailable
        {
            get
            {
                return NumberOfShipSlots - Size;
            }
        }

        public void AttackEnemyShips()
        {
            throw new NotImplementedException();
        }

        public void EnterField()
        {
            throw new NotImplementedException();
        }

        public void LeaveField()
        {
            throw new NotImplementedException();
        }

        public void TargetEnemyShips()
        {
            throw new NotImplementedException();
        }
    }
}
