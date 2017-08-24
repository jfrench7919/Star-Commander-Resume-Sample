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
            Assert.IsType<Fighter>(ShipFactory.CreateShip(ShipType.Fighter));
        }

        [Fact()]
        public void CreateShipFrigetTest()
        {
            Assert.IsType<Friget>(ShipFactory.CreateShip(ShipType.Friget));
        }

        [Fact()]
        public void CreateShipDestroyerTest()
        {
            Assert.IsType<Destroyer>(ShipFactory.CreateShip(ShipType.Destroyer));
        }

        [Fact()]
        public void CreateShipNullTest()
        {
            Assert.Equal(null, ShipFactory.CreateShip(null));
        }
    }
}