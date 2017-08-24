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
    public class DestroyerTests
    {
        [Fact()]
        public void DestroyerPowerBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer);
            Assert.Equal(100, ship.Power);
        }

        [Fact()]
        public void DestroyerSpeedBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer);
            Assert.Equal(10, ship.Speed);
        }

        [Fact()]
        public void DestroyerArmorBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer);
            Assert.Equal(90, ship.Armor);
        }

        [Fact()]
        public void DestroyerSizeBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer);
            Assert.Equal(90, ship.Size);
        }

        [Fact()]
        public void DestroyerHealthBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer);
            Assert.Equal(100, ship.Health);
        }
    }
}