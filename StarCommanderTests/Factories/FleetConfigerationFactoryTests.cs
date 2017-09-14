using Xunit;
using StarCommander.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Types;
using StarCommander.Configuration;

namespace StarCommander.Factories.Tests
{
    public class FleetConfigurationFactoryTests
    {
        [Fact()]
        public void CreateBalancedShipsFleetConfigurationTest()
        {
            IFleetConfiguration fleetConfiguration = FleetConfigurationFactory.CreateFleetConfiguration(FleetConfigurationType.BalancedShips);
            Assert.IsType<FleetConfiguration>(fleetConfiguration);
        }

        [Fact()]
        public void CreateHeavyShipsFleetConfigurationTest()
        {
            IFleetConfiguration fleetConfiguration = FleetConfigurationFactory.CreateFleetConfiguration(FleetConfigurationType.HeavyShips);
            Assert.IsType<FleetConfiguration>(fleetConfiguration);
        }

        [Fact()]
        public void CreateSmallShipsFleetConfigurationTest()
        {
            IFleetConfiguration fleetConfiguration = FleetConfigurationFactory.CreateFleetConfiguration(FleetConfigurationType.SmallShips);
            Assert.IsType<FleetConfiguration>(fleetConfiguration);
        }

        [Fact()]
        public void CreateSmallShipsFleetConfigurationSizeTest()
        {
            IFleetConfiguration fleetConfiguration = FleetConfigurationFactory.CreateFleetConfiguration(FleetConfigurationType.SmallShips);
            var destroyers = fleetConfiguration.Destroyers.Sum(x => x.Size);
            var frigets = fleetConfiguration.Frigets.Sum(x => x.Size);
            var fighters = fleetConfiguration.Fighters.Sum(x => x.Size);
            var size = destroyers + frigets + fighters;
            Assert.True(size < 12000);
        }

        [Fact()]
        public void CreateHeavyShipsFleetConfigurationSizeTest()
        {
            IFleetConfiguration fleetConfiguration = FleetConfigurationFactory.CreateFleetConfiguration(FleetConfigurationType.HeavyShips);
            var destroyers = fleetConfiguration.Destroyers.Sum(x => x.Size);
            var frigets = fleetConfiguration.Frigets.Sum(x => x.Size);
            var fighters = fleetConfiguration.Fighters.Sum(x => x.Size);
            var size = destroyers + frigets + fighters;
            Assert.True(size < 12000);
        }

        [Fact()]
        public void CreateBalancedShipsFleetConfigurationSizeTest()
        {
            IFleetConfiguration fleetConfiguration = FleetConfigurationFactory.CreateFleetConfiguration(FleetConfigurationType.BalancedShips);
            var destroyers = fleetConfiguration.Destroyers.Sum(x => x.Size);
            var frigets = fleetConfiguration.Frigets.Sum(x => x.Size);
            var fighters = fleetConfiguration.Fighters.Sum(x => x.Size);
            var size = destroyers + frigets + fighters;
            Assert.True(size < 12000);
        }
    }
}