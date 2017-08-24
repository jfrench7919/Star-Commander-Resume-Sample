using Xunit;
using StarCommander.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Factories;
using StarCommander.Types;

namespace StarCommander.Ships.Tests
{
    public class FrigetTests
    {
        [Fact()]
        public void FrigetPowerBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget);
            Assert.Equal(60, ship.Power);
        }

        [Fact()]
        public void FrigetSpeedBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget);
            Assert.Equal(20, ship.Speed);
        }

        [Fact()]
        public void FrigetArmorBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget);
            Assert.Equal(60, ship.Armor);
        }

        [Fact()]
        public void FrigetSizeBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget);
            Assert.Equal(40, ship.Size);
        }

        [Fact()]
        public void FrigetHealthBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget);
            Assert.Equal(100, ship.Health);
        }
    }
}