using Xunit;
using StarCommander.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Types;
using StarCommander.Ships;

namespace StarCommander.Factories.Tests
{
    public class ShipFactoryTests
    {
        [Fact()]
        public void CreateShipFighterTest()
        {
            Assert.IsType<Fighter>(ShipFactory.CreateShip(ShipType.Fighter, null));
        }

        [Fact()]
        public void CreateShipFrigetTest()
        {
            Assert.IsType<Friget>(ShipFactory.CreateShip(ShipType.Friget, null));
        }

        [Fact()]
        public void CreateShipDestroyerTest()
        {
            Assert.IsType<Destroyer>(ShipFactory.CreateShip(ShipType.Destroyer, null));
        }

        [Fact()]
        public void CreateShipNullTest()
        {
            Assert.Equal(null, ShipFactory.CreateShip(null, null));
        }


        //Todo: Start some better test for implemented StarShips
        [Fact()]
        public void CreateShipTest()
        {
            var t = ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Balanced);
            Assert.IsType<Friget>(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Balanced));
        }
    }
}