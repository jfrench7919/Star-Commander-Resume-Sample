using Xunit;
using StarCommander.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Types;
using StarCommander.Configeration;

namespace StarCommander.Factories.Tests
{
    public class FleetConfigerationFactoryTests
    {
        //Todo: Add Factory Test
        [Fact()]
        public void CreateBalancedShipsFleetConfigurationTest()
        {
            IFleetConfigeration fleetConfigeration = FleetConfigerationFactory.CreateFleetConfiguration(FleetConfigerationType.BalancedShips);
            Assert.IsType<FleetConfigeration>(fleetConfigeration);
        }

        [Fact()]
        public void CreateHeavyShipsFleetConfigurationTest()
        {
            IFleetConfigeration fleetConfigeration = FleetConfigerationFactory.CreateFleetConfiguration(FleetConfigerationType.HeavyShips);
            Assert.IsType<FleetConfigeration>(fleetConfigeration);
        }

        [Fact()]
        public void CreateSmallShipsFleetConfigurationTest()
        {
            IFleetConfigeration fleetConfigeration = FleetConfigerationFactory.CreateFleetConfiguration(FleetConfigerationType.SmallShips);
            Assert.IsType<FleetConfigeration>(fleetConfigeration);
        }

        [Fact()]
        public void CreateSmallShipsFleetConfigurationSizeTest()
        {
            IFleetConfigeration fleetConfigeration = FleetConfigerationFactory.CreateFleetConfiguration(FleetConfigerationType.SmallShips);
            var destroyers = fleetConfigeration.Destroyers.Sum(x => x.Size);
            var frigets = fleetConfigeration.Frigets.Sum(x => x.Size);
            var fighters = fleetConfigeration.Fighters.Sum(x => x.Size);
            var size = destroyers + frigets + fighters;
            Assert.True(size < 12000);
        }

        [Fact()]
        public void CreateHeavyShipsFleetConfigurationSizeTest()
        {
            IFleetConfigeration fleetConfigeration = FleetConfigerationFactory.CreateFleetConfiguration(FleetConfigerationType.HeavyShips);
            var destroyers = fleetConfigeration.Destroyers.Sum(x => x.Size);
            var frigets = fleetConfigeration.Frigets.Sum(x => x.Size);
            var fighters = fleetConfigeration.Fighters.Sum(x => x.Size);
            var size = destroyers + frigets + fighters;
            Assert.True(size < 12000);
        }

        [Fact()]
        public void CreateBalancedShipsFleetConfigurationSizeTest()
        {
            IFleetConfigeration fleetConfigeration = FleetConfigerationFactory.CreateFleetConfiguration(FleetConfigerationType.BalancedShips);
            var destroyers = fleetConfigeration.Destroyers.Sum(x => x.Size);
            var frigets = fleetConfigeration.Frigets.Sum(x => x.Size);
            var fighters = fleetConfigeration.Fighters.Sum(x => x.Size);
            var size = destroyers + frigets + fighters;
            Assert.True(size < 12000);
        }
    }
}