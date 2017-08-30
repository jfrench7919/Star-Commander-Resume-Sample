using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.AttackImplement;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.BattleFields;
using StarCommander.BattleResult;

namespace StarCommander.Fleets
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
        public List<IStarShip> DiabledStarShips { get { return StarShips.Where(x => x.Health == 0).ToList(); } }
        public List<IStarShip> WorkingStarShips { get { return StarShips.Where(x => x.Health > 0).ToList(); } }

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
            foreach (IStarShip ship in WorkingStarShips)
            {
                ship.Attack(enemyFleet, BattleStratagyType);
            }

            CheckEnemyFleetHealth(enemyFleet);
        }

        private static void CheckEnemyFleetHealth(IFleet enemyFleet)
        {
            if (enemyFleet.WorkingStarShips.Count() == 0)
            {
                enemyFleet.ReportDestruction();
            }
        }

        public void EnterField(IBattleField battleField)
        {
            if (battleField.NumberOfFleetSlotsAvailable > this.Size)
            {
                battleField.Fleets.Add(this);
                BattleResults.Messages.Add("The new fleet has entered the field!");
            }
        }

        public void LeaveField(IBattleField battleField)
        {
            battleField.Fleets.Remove(this);
            BattleResults.Messages.Add("The fleet has left the field!");
        }

        public void ReportDestruction()
        {
            BattleResults.Messages.Add("A fleet was destroyed!");
        }
    }
}
