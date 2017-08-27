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
        public void CreateShipConfigurationFighterBalancedTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Balanced);
            Assert.True(ship.Armor != 0);
            Assert.True(ship.Speed != 0);
            Assert.True(ship.Health != 0);
            Assert.True(ship.Power != 0);
            Assert.True(ship.NumberOfAttackSlotsAvailable >= 0);
            Assert.True(ship.NumberOfDefendSlotsAvailable >= 0);
            Assert.True(ship.NumberOfUpgradeSlotsAvailable >= 0);
        }

        [Fact()]
        public void CreateShipConfigurationFighterHeavyTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Heavy);
            Assert.True(ship.Armor != 0);
            Assert.True(ship.Speed != 0);
            Assert.True(ship.Health != 0);
            Assert.True(ship.Power != 0);
            Assert.True(ship.NumberOfAttackSlotsAvailable >= 0);
            Assert.True(ship.NumberOfDefendSlotsAvailable >= 0);
            Assert.True(ship.NumberOfUpgradeSlotsAvailable >= 0);
        }

        [Fact()]
        public void CreateShipConfigurationFighterLightTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Light);
            Assert.True(ship.Armor != 0);
            Assert.True(ship.Speed != 0);
            Assert.True(ship.Health != 0);
            Assert.True(ship.Power != 0);
            Assert.True(ship.NumberOfAttackSlotsAvailable >= 0);
            Assert.True(ship.NumberOfDefendSlotsAvailable >= 0);
            Assert.True(ship.NumberOfUpgradeSlotsAvailable >= 0);
        }

        [Fact()]
        public void CreateShipConfigurationFrigetBalancedTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Balanced);
            Assert.True(ship.Armor != 0);
            Assert.True(ship.Speed != 0);
            Assert.True(ship.Health != 0);
            Assert.True(ship.Power != 0);
            Assert.True(ship.NumberOfAttackSlotsAvailable >= 0);
            Assert.True(ship.NumberOfDefendSlotsAvailable >= 0);
            Assert.True(ship.NumberOfUpgradeSlotsAvailable >= 0);
        }

        [Fact()]
        public void CreateShipConfigurationFrigetHeavyTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Heavy);
            Assert.True(ship.Armor != 0);
            Assert.True(ship.Speed != 0);
            Assert.True(ship.Health != 0);
            Assert.True(ship.Power != 0);
            Assert.True(ship.NumberOfAttackSlotsAvailable >= 0);
            Assert.True(ship.NumberOfDefendSlotsAvailable >= 0);
            Assert.True(ship.NumberOfUpgradeSlotsAvailable >= 0);
        }

        [Fact()]
        public void CreateShipConfigurationFrigetLightTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Light);
            Assert.True(ship.Armor != 0);
            Assert.True(ship.Speed != 0);
            Assert.True(ship.Health != 0);
            Assert.True(ship.Power != 0);
            Assert.True(ship.NumberOfAttackSlotsAvailable >= 0);
            Assert.True(ship.NumberOfDefendSlotsAvailable >= 0);
            Assert.True(ship.NumberOfUpgradeSlotsAvailable >= 0);
        }

        [Fact()]
        public void CreateShipConfigurationDestroyerBalancedTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer, ShipConfigurationType.Balanced);
            Assert.True(ship.Armor != 0);
            Assert.True(ship.Speed != 0);
            Assert.True(ship.Health != 0);
            Assert.True(ship.Power != 0);
            Assert.True(ship.NumberOfAttackSlotsAvailable >= 0);
            Assert.True(ship.NumberOfDefendSlotsAvailable >= 0);
            Assert.True(ship.NumberOfUpgradeSlotsAvailable >= 0);
        }

        [Fact()]
        public void CreateShipConfigurationDestroyerHeavyTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer, ShipConfigurationType.Heavy);
            Assert.True(ship.Armor != 0);
            Assert.True(ship.Speed != 0);
            Assert.True(ship.Health != 0);
            Assert.True(ship.Power != 0);
            Assert.True(ship.NumberOfAttackSlotsAvailable >= 0);
            Assert.True(ship.NumberOfDefendSlotsAvailable >= 0);
            Assert.True(ship.NumberOfUpgradeSlotsAvailable >= 0);
        }

        [Fact()]
        public void CreateShipConfigurationDestroyerLightTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer, ShipConfigurationType.Light);
            Assert.True(ship.Armor != 0);
            Assert.True(ship.Speed != 0);
            Assert.True(ship.Health != 0);
            Assert.True(ship.Power != 0);
            Assert.True(ship.NumberOfAttackSlotsAvailable >= 0);
            Assert.True(ship.NumberOfDefendSlotsAvailable >= 0);
            Assert.True(ship.NumberOfUpgradeSlotsAvailable >= 0);
        }
    }
}