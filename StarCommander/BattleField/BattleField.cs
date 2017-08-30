using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Fleet;

namespace StarCommander.BattleField
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
            else
            {
                ReportBattleWon();
            }
        }

        private IFleet GetFirstFleetsEnemy(IFleet myFleet)
        {
            return Fleets.Where(x => x != myFleet && x.WorkingStarShips.Count() > 0).FirstOrDefault();
        }
        
        private IFleet GetFleetWithTurnLeft()
        {
            return Fleets.Where(x => x.WorkingStarShips.Count() > 0).OrderBy(x => x.NumberOfRoundsCompleted).FirstOrDefault();
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
            //todo: add pub sub
        }
    }
}
