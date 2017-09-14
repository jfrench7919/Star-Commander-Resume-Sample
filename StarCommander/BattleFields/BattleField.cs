using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Fleets;
using StarCommander.BattleResult;
using StarCommander.Types;

namespace StarCommander.BattleFields
{
    public class BattleField : IBattleField
    {
        public BattleField ()
        {
            Fleets = new List<IFleet>();
        }

        public List<IFleet> Fleets { get; set; }
        public int NumberOfFleetSlots { get; set; }
        public int NumberOfFleetSlotsAvailable 
        {
            get
            {
                return NumberOfFleetSlots - Fleets.Sum(x => x.Size);
            }
        }
        public List<IFleet> WorkingFleets { get { return Fleets.Where(x => x.WorkingStarShips.Count() > 0).ToList(); } }
        public List<IFleet> DisabledFleets { get { return Fleets.Where(x => x.WorkingStarShips.Count() == 0).ToList(); } }

        public void AdvanceRound(IFleet myFleet)
        {
            myFleet.NumberOfRoundsCompleted++;
        }

        public void StartBattle()
        {
            BattleResults.Messages.Add("The battle has started!");
            StartRound(GetFleetWithTurnLeft());
        }

        public void StartRound(IFleet myFleet)
        {
            if (!CheckForVictory())
            {
                IFleet enemyFleet = GetFirstFleetsEnemy(myFleet);
                myFleet.AttacKEnemyShips(enemyFleet);
                AdvanceRound(myFleet);
                StartRound(GetFleetWithTurnLeft());
            }
        }

        public Random rnd { get; set; } = new Random();
        public BattleFieldType myBattleFieldType { get; set; }

        private IFleet GetFirstFleetsEnemy(IFleet myFleet)
        {
            List<IFleet> availableFleets = GetFleetsThatAreNotMe(myFleet);
            var index = rnd.Next(availableFleets.Count());
            return availableFleets[index];
        }

        private List<IFleet> GetFleetsThatAreNotMe(IFleet myFleet)
        {
            return WorkingFleets.Where(x => x != myFleet).ToList();
        }

        private IFleet GetFleetWithTurnLeft()
        {
            List<IFleet> availableFleets = GetWorkingFleetsByRound(GetLowestNumberOfRoundsCompleted());

            var index = rnd.Next(availableFleets.Count());

            return availableFleets[index];
        }

        private List<IFleet> GetWorkingFleetsByRound(int lowestRound)
        {
            return WorkingFleets.Where(x => x.NumberOfRoundsCompleted == lowestRound).ToList();
        }

        private int GetLowestNumberOfRoundsCompleted()
        {
            return WorkingFleets.Min(x => x.NumberOfRoundsCompleted);
        }

        public bool CheckForVictory()
        {
            if (WorkingFleets.Count() == 1)
            {
                ReportBattleWon();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ReportBattleWon()
        {
            foreach(IFleet fleet in DisabledFleets)
            {
                fleet.LeaveField(this);
            }

            IFleet winner = Fleets.Where(x => x.WorkingStarShips.Count > 0).FirstOrDefault();
            BattleResults.Messages.Add("The battle has been won and only the " + winner.Name + " fleet survives!");
            BattleResults.Messages.Add("The " + winner.Name + " fleet still has " + Fleets.Where(x => x.WorkingStarShips.Count > 0).FirstOrDefault().WorkingStarShips.Count + " ship's left!");
        }
    }
}
