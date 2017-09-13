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
            var availableFleets = Fleets.Where(x => x != myFleet && x.WorkingStarShips.Count() > 0).ToList();
            var index = rnd.Next(availableFleets.Count());
            return availableFleets[index];
        }
        
        private IFleet GetFleetWithTurnLeft()
        {
            int minRounds = Fleets.Where(x => x.WorkingStarShips.Count() > 0).Min(n => n.NumberOfRoundsCompleted);

            var availableFleets = Fleets.Where(x => x.WorkingStarShips.Count() > 0 && x.NumberOfRoundsCompleted == minRounds).ToList();
            
            var index = rnd.Next(availableFleets.Count());
            
            return availableFleets[index];
        }

        public bool CheckForVictory()
        {
            if (Fleets.Where(x => x.WorkingStarShips.Count() > 0).Count() == 1)
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
