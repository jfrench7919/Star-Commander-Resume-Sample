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
            Assert.Equal(2000, ship.Size);
        }

        [Fact()]
        public void DestroyerHealthBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer);
            Assert.Equal(100, ship.Health);
        }

        [Fact()]
        public void DestroyerNumberOfAttackSlotsBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer);
            Assert.Equal(150, ship.NumberOfAttackSlots);
        }

        [Fact()]
        public void DestroyerNumberOfDefendSlotsBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer);
            Assert.Equal(50, ship.NumberOfDefendSlots);
        }

        [Fact()]
        public void DestroyerNumberOfUpgradeSlotsBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer);
            Assert.Equal(20, ship.NumberOfUpgradeSlots);
        }

        [Fact()]
        public void DestroyerNumberOfAttackSlotsAvailableBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer);
            Assert.Equal(150, ship.NumberOfAttackSlotsAvailable);
        }

        [Fact()]
        public void DestroyerNumberOfDefendSlotsAvailableBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer);
            Assert.Equal(50, ship.NumberOfDefendSlotsAvailable);
        }

        [Fact()]
        public void DestroyerNumberOfUpgradeSlotsAvailableBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer);
            Assert.Equal(20, ship.NumberOfUpgradeSlotsAvailable);
        }
    }
}