using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Fleet;

namespace StarCommander.BattleField
{
    public class BattleField : IBattleField
    {
        public BattleField ()
        {
            Fleets = new List<IFleet>();
        }

        public int NumberOfFleetSlots { get; set; }
        public List<IFleet> Fleets { get; set; }

        public int NumberOfFleetSlotsAvailable 
        {
            get
            {
                return NumberOfFleetSlots - Fleets.Sum(x => x.Size);
            }
        }

        public void AdvanceRound()
        {
            throw new NotImplementedException();
        }

        public void EndBattle()
        {
            throw new NotImplementedException();
        }

        public void StartBattle()
        {
            throw new NotImplementedException();
        }
    }
}
