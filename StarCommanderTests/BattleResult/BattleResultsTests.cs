﻿using Xunit;
using StarCommander.BattleResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.BattleFields;
using StarCommander.Factories;
using StarCommander.Fleets;
using StarCommander.Types;

namespace StarCommander.BattleResult.Tests
{
    public class BattleResultsTests
    {
        [Fact()]
        public void BattleResultsTest()
        {
            BattleResults.Messages.Add("Test Singleton");
            Assert.True(BattleResults.Messages.Count() > 0);
            BattleResults.Messages.Clear();
            Assert.True(BattleResults.Messages.Count() == 0);
        }

        [Fact()]
        public void PostBattleResultsTest()
        {
            BattleResults.Messages.Clear();
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
            List<string> battleResult = BattleResults.Messages;
            Assert.True(battleResult.Count > 7);
        }
    }
}