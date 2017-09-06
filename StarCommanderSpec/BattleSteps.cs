using System;
using System.Linq;
using TechTalk.SpecFlow;
using StarCommander.BattleFields;
using StarCommander.Factories;
using StarCommander.Types;
using System.Collections.Generic;
using Xunit;

namespace StarCommanderSpec
{
    [Binding]
    public class BattleSteps
    {
        public IBattleField battleField { get; set; } = BattleFieldFactory.CreateBattleField(BattleFieldType.Large); 

        [Given(@"I have entered (.*) Fleets into the BattleField")]
        public void GivenIHaveEnteredFleetsIntoTheBattleField(int numberOfFleets)
        {
            for (int i = 0; i < numberOfFleets; i++)
            {
                battleField.Fleets.Add(FleetFactory.CreateFleet(FleetConfigerationType.BalancedShips, BattleStratagyType.WeekShipsFirst));
            }
        }

        [When(@"I call startBattle")]
        public void WhenICallStartBattle()
        {
            battleField.StartBattle();
        }

        [Then(@"the result should be (.*) Fleet with health greater than zero")]
        public void ThenTheResultShouldBeFleetWithHealthGreaterThanZero(int fleetsWithWorkingShips)
        {
            int survivingFleets = battleField.Fleets.Where(x => x.WorkingStarShips.Count > 0).Count();
            Assert.Equal(fleetsWithWorkingShips, survivingFleets);
        }
    }
}
