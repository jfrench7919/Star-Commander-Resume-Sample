using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Fleets;
using StarCommander.Types;

namespace StarCommander.BattleFields
{
    public interface IBattleField
    {
        BattleFieldType myBattleFieldType { get; set; }
        int NumberOfFleetSlots { get; set; }
        List<IFleet> Fleets { get; set; }
        List<IFleet> WorkingFleets { get; }
        List<IFleet> DisabledFleets { get; }
        int NumberOfFleetSlotsAvailable { get; }

        void StartBattle();
        void AdvanceRound(IFleet myFleet);
        void StartRound(IFleet myFleet);
        bool CheckForVictory();
    }
}
