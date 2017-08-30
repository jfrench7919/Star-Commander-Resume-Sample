using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Fleets;

namespace StarCommander.BattleFields
{
    public interface IBattleField
    {
        int NumberOfFleetSlots { get; set; }
        List<IFleet> Fleets { get; set; }
        int NumberOfFleetSlotsAvailable { get; }

        void StartBattle();
        void AdvanceRound(IFleet myFleet);
        void StartRound(IFleet myFleet);
        bool CheckForVictory();
    }
}
