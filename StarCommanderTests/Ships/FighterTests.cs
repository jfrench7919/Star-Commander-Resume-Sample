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
            Assert.Equal(50, ship.Power);
        }

        [Fact()]
        public void FighterSpeedBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter);
            Assert.Equal(80, ship.Speed);
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
            Assert.Equal(70, ship.Size);
        }

        [Fact()]
        public void FighterHealthBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter);
            Assert.Equal(100, ship.Health);
        }

        [Fact()]
        public void FighterNumberOfAttackSlotsBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter);
            Assert.Equal(15, ship.NumberOfAttackSlots);
        }

        [Fact()]
        public void FighterNumberOfDefendSlotsBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter);
            Assert.Equal(10, ship.NumberOfDefendSlots);
        }

        [Fact()]
        public void FighterNumberOfUpgradeSlotsBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter);
            Assert.Equal(5, ship.NumberOfUpgradeSlots);
        }

        [Fact()]
        public void FighterNumberOfAttackSlotsAvailableBaseValueTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter);
            Assert.Equal(15, ship.NumberOfAttackSlotsAvailable);
        }
    }
}