using Xunit;
using StarCommander.Fleets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Factories;
using StarCommander.Types;
using StarCommander.Ships;
using StarCommander.BattleFields;

namespace StarCommander.Fleet.Tests
{
    public class FleetTests
    {
        [Fact()]
        public void FleetDefaultNumberOfShipSlotsTest()
        {
            IFleet fleet = new Fleets.Fleet();
            Assert.Equal(12000, fleet.NumberOfShipSlots);
        }

        [Fact()]
        public void AttackEnemyShipsTest()
        {
            IFleet myfleet = FleetFactory.CreateFleet(FleetConfigurationType.BalancedShips, BattleStratageyType.WeekShipsFirst);
            IFleet enemyfleet = FleetFactory.CreateFleet(FleetConfigurationType.BalancedShips, BattleStratageyType.WeekShipsFirst);
            var oTotalHealthAndArmor = enemyfleet.StarShips.Sum(x => x.Health) + enemyfleet.StarShips.Sum(x => x.Armor);
            myfleet.AttacKEnemyShips(enemyfleet);
            var newTotalHealthAndArmor = enemyfleet.StarShips.Sum(x => x.Health) + enemyfleet.StarShips.Sum(x => x.Armor);
            var shipsDestroyed = enemyfleet.StarShips.Where(x => x.Health == 0).ToList();
            Assert.True(oTotalHealthAndArmor > newTotalHealthAndArmor);
        }

        [Fact()]
        public void EnterFieldTest()
        {
            IBattleField battleField = BattleFieldFactory.CreateBattleField(BattleFieldType.Small);
            IFleet myfleet = FleetFactory.CreateFleet(FleetConfigurationType.BalancedShips, BattleStratageyType.WeekShipsFirst);
            myfleet.EnterField(battleField);
            Assert.True(battleField.Fleets.Count() > 0);
        }

        [Fact()]
        public void LeaveFieldTest()
        {
            IBattleField battleField = BattleFieldFactory.CreateBattleField(BattleFieldType.Small);
            IFleet myfleet = FleetFactory.CreateFleet(FleetConfigurationType.BalancedShips, BattleStratageyType.WeekShipsFirst);
            myfleet.EnterField(battleField);
            myfleet.LeaveField(battleField);
            Assert.True(battleField.Fleets.Count() == 0);
        }
    }
}