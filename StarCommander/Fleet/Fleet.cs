using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.AttackImplement;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.BattleField;

namespace StarCommander.Fleet
{
    public class Fleet : IFleet
    {
        public Fleet()
        {
            StarShips = new List<IStarShip>();
            NumberOfShipSlots = 12000;
        }

        public BattleStratagyType BattleStratagyType { get; set; }
        public int NumberOfShipSlots { get; set; }
        public int NumberOfRoundsCompleted { get; set; }
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

        public void AttacKEnemyShips(IFleet enemyFleet)
        {
            foreach (IStarShip ship in StarShips)
            {
                ship.AttackEnemyShips(enemyFleet, BattleStratagyType);
            }

            CheckEnemyFleetHealth(enemyFleet);
        }

        private static void CheckEnemyFleetHealth(IFleet enemyFleet)
        {
            if (enemyFleet.StarShips.Sum(x => x.Health) == 0)
            {
                enemyFleet.ReportDestruction();
            }
        }

        public void EnterField(IBattleField battleField)
        {
            if (battleField.NumberOfFleetSlotsAvailable > this.Size)
            {
                battleField.Fleets.Add(this);
            }
        }

        public void LeaveField(IBattleField battleField)
        {
            battleField.Fleets.Remove(this);
        }

        public void ReportDestruction()
        {
            throw new NotImplementedException();
        }
    }
}
