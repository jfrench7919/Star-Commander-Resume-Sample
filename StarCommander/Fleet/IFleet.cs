using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Types;
using StarCommander.Ships;

namespace StarCommander.Fleet
{
    public interface IFleet
    {
        BattleStratagyType BattleStratagyType { get; set; }
        int Size { get; }
        int NumberOfShipSlots { get; set; }
        List<IStarShip> StarShips { get; set; }
        int NumberOfShipSlotsAvailable { get; }

        void EnterField();
        void LeaveField();
        void TargetEnemyShips();
        void AttackEnemyShips();
    }
}