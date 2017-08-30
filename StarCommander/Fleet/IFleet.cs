using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Types;
using StarCommander.Ships;
using StarCommander.AttackImplement;
using StarCommander.BattleField;

namespace StarCommander.Fleet
{
    public interface IFleet
    {
        BattleStratagyType BattleStratagyType { get; set; }
        int Size { get; }
        int NumberOfRoundsCompleted { get; set; }
        int NumberOfShipSlots { get; set; }
        List<IStarShip> StarShips { get; set; }
        List<IStarShip> DiabledStarShips { get; }
        List<IStarShip> WorkingStarShips { get; }
        int NumberOfShipSlotsAvailable { get; }
        void AttacKEnemyShips(IFleet enemyFleet);
        void EnterField(IBattleField battleField);
        void LeaveField(IBattleField battleField);
        void ReportDestruction();
    }
}