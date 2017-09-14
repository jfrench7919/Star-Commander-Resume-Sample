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

        public BattleStratageyType myBattleStratageyType { get; set; }
        public FleetConfigurationType myFleetConfigurationType { get; set; }
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

        public string Name { get; set; }

        public void AttacKEnemyShips(IFleet enemyFleet)
        {
            bool resetLoopAfterFire = LessThan10LeftToFire();
            Fire10Ship(enemyFleet);
            ResetLoop(resetLoopAfterFire);
            CheckEnemyFleetHealth(enemyFleet);
        }

        private void Fire10Ship(IFleet enemyFleet)
        {
            foreach (IStarShip ship in WorkingStarShips.Where(x => !x.HasFiredThisLoop).Take(10))
            {
                ship.Attack(enemyFleet, myBattleStratageyType);
                ship.HasFiredThisLoop = true;
            }
        }

        private void ResetLoop(bool resetLoopAfterFire)
        {
            if (resetLoopAfterFire)
            {
                foreach (IStarShip s in WorkingStarShips)
                {
                    s.HasFiredThisLoop = false;
                }
            }
        }

        private bool LessThan10LeftToFire()
        {
            if (WorkingStarShips.Where(x => !x.HasFiredThisLoop).Count() < 10)
            {
                return true;
            }

            return false;
        }

        private static void CheckEnemyFleetHealth(IFleet enemyFleet)
        {
            if (enemyFleet.WorkingStarShips.Count() == 0)
            {
                enemyFleet.ReportDestruction();
                enemyFleet.StarShips.Clear();
            }
        }

        public void EnterField(IBattleField battleField)
        {
            if (battleField.NumberOfFleetSlotsAvailable > this.Size)
            {
                battleField.Fleets.Add(this);
                BattleResults.Messages.Add("The " + this.Name + " fleet has entered the field!");
            }
        }

        public void LeaveField(IBattleField battleField)
        {
            battleField.Fleets.Remove(this);
            BattleResults.Messages.Add("The " + this.Name + " has left the field!");
        }

        public void ReportDestruction()
        {
            BattleResults.Messages.Add("The " + this.Name + " fleet was destroyed!");
        }
    }
}
