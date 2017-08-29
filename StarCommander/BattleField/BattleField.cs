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
            StartRound(GetFleetWithTurnLeft());
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
            }
            else
            {
                ReportBattleWon();
            }
        }

        private IFleet GetFirstFleetsEnemy(IFleet myFleet)
        {
            return Fleets.Where(x => x != myFleet).FirstOrDefault();
        }
        
        private IFleet GetFleetWithTurnLeft()
        {
            return Fleets.OrderBy(x => x.NumberOfRoundsCompleted).FirstOrDefault();
        }

        private bool CheckForVictory()
        {
            if (Fleets.Where(x => x.StarShips.Sum(s => s.Health) >= 0).Count() < 2)
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
            throw new NotImplementedException();
        }
    }
}
