using Xunit;
using StarCommander.BattleFields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Factories;
using StarCommander.Types;
using StarCommander.Fleets;
using StarCommander.Ships;

namespace StarCommander.BattleField.Tests
{
    public class BattleFieldTests
    {
        [Fact()]
        public void StartBattleTest()
        {
            IBattleField battleField = BattleFieldFactory.CreateBattleField(BattleFieldType.Large);
            IFleet fleet1 = FleetFactory.CreateFleet(FleetConfigerationType.SmallShips, BattleStratagyType.WeekShipsFirst);
            IFleet fleet2 = FleetFactory.CreateFleet(FleetConfigerationType.BalancedShips, BattleStratagyType.StrongShipsFirst);
            IFleet fleet3 = FleetFactory.CreateFleet(FleetConfigerationType.HeavyShips, BattleStratagyType.NoPriority);
            IFleet fleet4 = FleetFactory.CreateFleet(FleetConfigerationType.BalancedShips, BattleStratagyType.WeekShipsFirst);
            IFleet fleet5 = FleetFactory.CreateFleet(FleetConfigerationType.BalancedShips, BattleStratagyType.NoPriority);
            IFleet fleet6 = FleetFactory.CreateFleet(FleetConfigerationType.BalancedShips, BattleStratagyType.NoPriority);
            fleet1.EnterField(battleField);
            fleet2.EnterField(battleField);
            fleet3.EnterField(battleField);
            fleet4.EnterField(battleField);
            fleet5.EnterField(battleField);
            fleet6.EnterField(battleField);
            battleField.StartBattle();
            Assert.True(battleField.Fleets.Where(x => x.WorkingStarShips.Count() > 0).Count() == 1);
            bool result = battleField.CheckForVictory();
            Assert.True(result);
        }

        [Fact()]
        public void StartRoundTest()
        {
            IBattleField battleField = BattleFieldFactory.CreateBattleField(BattleFieldType.Small);
            IFleet fleet1 = FleetFactory.CreateFleet(FleetConfigerationType.BalancedShips, BattleStratagyType.WeekShipsFirst);
            IFleet fleet2 = FleetFactory.CreateFleet(FleetConfigerationType.BalancedShips, BattleStratagyType.StrongShipsFirst);
            fleet1.EnterField(battleField);
            fleet2.EnterField(battleField);
            foreach (IStarShip ship in fleet2.StarShips)
            {
                ship.Health = 0;
            }
            bool result = battleField.CheckForVictory();
            Assert.True(result);
        }

        [Fact()]
        public void AdvanceRoundTest()
        {
            IBattleField battleField = BattleFieldFactory.CreateBattleField(BattleFieldType.Small);
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigerationType.BalancedShips, BattleStratagyType.WeekShipsFirst);
            fleet.EnterField(battleField);
            battleField.AdvanceRound(fleet);
            Assert.True(fleet.NumberOfRoundsCompleted == 1);
        }
    }
}