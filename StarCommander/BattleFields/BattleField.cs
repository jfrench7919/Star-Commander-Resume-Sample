using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Fleets;
using StarCommander.BattleResult;

namespace StarCommander.BattleFields
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

        private IFleet GetFirstFleetsEnemy(IFleet myFleet)
        {
            
            var availableFleets = Fleets.Where(x => x != myFleet && x.WorkingStarShips.Count() > 0).ToList();
            var index = rnd.Next(1, availableFleets.Count());
            return availableFleets[index-1];
        }
        
        private IFleet GetFleetWithTurnLeft()
        {
            
            var availableFleets = Fleets.Where(x => x.WorkingStarShips.Count() > 0).OrderBy(x => x.NumberOfRoundsCompleted).ToList();
            var index = rnd.Next(1, availableFleets.Count());
            return availableFleets[index-1];
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
            BattleResults.Messages.Add("The battle has been won only one fleet survives");
            BattleResults.Messages.Add("The surviving fleet still has " + Fleets.Where(x => x.WorkingStarShips.Count > 0).FirstOrDefault().WorkingStarShips.Count + " ship's left!");
        }
    }
}
