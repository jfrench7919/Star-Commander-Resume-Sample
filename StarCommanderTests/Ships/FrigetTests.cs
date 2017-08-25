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
            Assert.Equal(70, ship.Power);
        }

        [Fact()]
        public void FrigetSpeedBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget);
            Assert.Equal(30, ship.Speed);
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
            Assert.Equal(500, ship.Size);
        }

        [Fact()]
        public void FrigetHealthBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget);
            Assert.Equal(100, ship.Health);
        }

        [Fact()]
        public void FrigetNumberOfAttackSlotsBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget);
            Assert.Equal(40, ship.NumberOfAttackSlots);
        }

        [Fact()]
        public void FrigetNumberOfDefendSlotsBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget);
            Assert.Equal(20, ship.NumberOfDefendSlots);
        }

        [Fact()]
        public void FrigetNumberOfUpgradeSlotsBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget);
            Assert.Equal(10, ship.NumberOfUpgradeSlots);
        }

        [Fact()]
        public void FrigetNumberOfAttackSlotsAvailableBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget);
            Assert.Equal(40, ship.NumberOfAttackSlotsAvailable);
        }

        [Fact()]
        public void FrigetNumberOfDefendSlotsAvailableBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget);
            Assert.Equal(20, ship.NumberOfDefendSlotsAvailable);
        }

        [Fact()]
        public void FrigetNumberOfUpgradeSlotsAvailableBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget);
            Assert.Equal(10, ship.NumberOfUpgradeSlotsAvailable);
        }
    }
}