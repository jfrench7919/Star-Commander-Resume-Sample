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
    public class FighterTests
    {
        [Fact()]
        public void FighterPowerBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter);
            Assert.Equal(45, ship.Power);
        }

        [Fact()]
        public void FighterSpeedBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter);
            Assert.Equal(35, ship.Speed);
        }

        [Fact()]
        public void FighterArmorBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter);
            Assert.Equal(30, ship.Armor);
        }

        [Fact()]
        public void FighterSizeBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter);
            Assert.Equal(10, ship.Size);
        }

        [Fact()]
        public void FighterHealthBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter);
            Assert.Equal(100, ship.Health);
        }
    }
}