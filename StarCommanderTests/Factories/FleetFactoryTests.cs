using Xunit;
using StarCommander.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Types;
using StarCommander.Fleets;

namespace StarCommander.Factories.Tests
{
    public class FleetFactoryTests
    {
        [Fact()]
        public void CreateBalancedShipsFleetTest()
        {
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigurationType.BalancedShips, BattleStratageyType.WeekShipsFirst);
            Assert.IsType<Fleets.Fleet>(fleet);
        }

        [Fact()]
        public void CreateHeavyShipsFleetTest()
        {
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigurationType.HeavyShips, BattleStratageyType.WeekShipsFirst);
            Assert.IsType<Fleets.Fleet>(fleet);
        }

        [Fact()]
        public void CreateSmallShipsFleetTest()
        {
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigurationType.SmallShips, BattleStratageyType.WeekShipsFirst);
            Assert.IsType<Fleets.Fleet>(fleet);
        }

        [Fact()]
        public void CreateFleetConfigurationOverSizedTest()
        {
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigurationType.BalancedShips, BattleStratageyType.WeekShipsFirst);
            var size = fleet.StarShips.Sum(x => x.Size);
            Assert.True(size < 12000);
        }
    }
}