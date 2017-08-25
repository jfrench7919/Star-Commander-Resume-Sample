using Xunit;
using StarCommander.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Implement;
using StarCommander.Types;
using StarCommander.Ships;

namespace StarCommander.Factories.Tests
{
    public class ShipConfigerationFactoryTests
    {
        [Fact()]
        public void CreateFighterBalancedConfigurationCollectionCountTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, null);
            IShipConfigeration config = ShipConfigerationFactory.CreateShipConfiguration(ShipType.Fighter, ShipConfigurationType.Balanced);
            Assert.True(config.attackImplements.Count() > 0);
            Assert.True(config.defendImplements.Count() > 0);
            Assert.True(config.upgradeImplements.Count() > 0);
            Assert.True(config.attackImplements.Sum(x => x.Size) <= ship.NumberOfAttackSlots);
            Assert.True(config.defendImplements.Sum(x => x.Size) <= ship.NumberOfDefendSlots);
            Assert.True(config.upgradeImplements.Sum(x => x.Size) <= ship.NumberOfUpgradeSlots);
        }

        [Fact()]
        public void CreateFighterHeavyConfigurationCollectionCountTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, null);
            IShipConfigeration config = ShipConfigerationFactory.CreateShipConfiguration(ShipType.Fighter, ShipConfigurationType.Heavy);
            Assert.True(config.attackImplements.Count() > 0);
            Assert.True(config.defendImplements.Count() > 0);
            Assert.True(config.upgradeImplements.Count() > 0);
            Assert.True(config.attackImplements.Sum(x => x.Size) <= ship.NumberOfAttackSlots);
            Assert.True(config.defendImplements.Sum(x => x.Size) <= ship.NumberOfDefendSlots);
            Assert.True(config.upgradeImplements.Sum(x => x.Size) <= ship.NumberOfUpgradeSlots);
        }

        [Fact()]
        public void CreateFighterLightConfigurationCollectionCountTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, null);
            IShipConfigeration config = ShipConfigerationFactory.CreateShipConfiguration(ShipType.Fighter, ShipConfigurationType.Light);
            Assert.True(config.attackImplements.Count() > 0);
            Assert.True(config.defendImplements.Count() > 0);
            Assert.True(config.upgradeImplements.Count() > 0);
            Assert.True(config.attackImplements.Sum(x => x.Size) <= ship.NumberOfAttackSlots);
            Assert.True(config.defendImplements.Sum(x => x.Size) <= ship.NumberOfDefendSlots);
            Assert.True(config.upgradeImplements.Sum(x => x.Size) <= ship.NumberOfUpgradeSlots);
        }

        [Fact()]
        public void CreateFrigetBalancedConfigurationCollectionCountTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget, null);
            IShipConfigeration config = ShipConfigerationFactory.CreateShipConfiguration(ShipType.Friget, ShipConfigurationType.Balanced);
            Assert.True(config.attackImplements.Count() > 0);
            Assert.True(config.defendImplements.Count() > 0);
            Assert.True(config.upgradeImplements.Count() > 0);
            Assert.True(config.attackImplements.Sum(x => x.Size) <= ship.NumberOfAttackSlots);
            Assert.True(config.defendImplements.Sum(x => x.Size) <= ship.NumberOfDefendSlots);
            Assert.True(config.upgradeImplements.Sum(x => x.Size) <= ship.NumberOfUpgradeSlots);
        }

        [Fact()]
        public void CreateFrigetHeavyConfigurationCollectionCountTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget, null);
            IShipConfigeration config = ShipConfigerationFactory.CreateShipConfiguration(ShipType.Friget, ShipConfigurationType.Heavy);
            Assert.True(config.attackImplements.Count() > 0);
            Assert.True(config.defendImplements.Count() > 0);
            Assert.True(config.upgradeImplements.Count() > 0);
            Assert.True(config.attackImplements.Sum(x => x.Size) <= ship.NumberOfAttackSlots);
            Assert.True(config.defendImplements.Sum(x => x.Size) <= ship.NumberOfDefendSlots);
            Assert.True(config.upgradeImplements.Sum(x => x.Size) <= ship.NumberOfUpgradeSlots);
        }

        [Fact()]
        public void CreateFrigetLightConfigurationCollectionCountTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Friget, null);
            IShipConfigeration config = ShipConfigerationFactory.CreateShipConfiguration(ShipType.Friget, ShipConfigurationType.Light);
            Assert.True(config.attackImplements.Count() > 0);
            Assert.True(config.defendImplements.Count() > 0);
            Assert.True(config.upgradeImplements.Count() > 0);
            Assert.True(config.attackImplements.Sum(x => x.Size) <= ship.NumberOfAttackSlots);
            Assert.True(config.defendImplements.Sum(x => x.Size) <= ship.NumberOfDefendSlots);
            Assert.True(config.upgradeImplements.Sum(x => x.Size) <= ship.NumberOfUpgradeSlots);
        }

        [Fact()]
        public void CreateDestroyerBalancedConfigurationCollectionCountTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer, null);
            IShipConfigeration config = ShipConfigerationFactory.CreateShipConfiguration(ShipType.Destroyer, ShipConfigurationType.Balanced);
            Assert.True(config.attackImplements.Count() > 0);
            Assert.True(config.defendImplements.Count() > 0);
            Assert.True(config.upgradeImplements.Count() > 0);
            Assert.True(config.attackImplements.Sum(x => x.Size) <= ship.NumberOfAttackSlots);
            Assert.True(config.defendImplements.Sum(x => x.Size) <= ship.NumberOfDefendSlots);
            Assert.True(config.upgradeImplements.Sum(x => x.Size) <= ship.NumberOfUpgradeSlots);
        }

        [Fact()]
        public void CreateDestroyerHeavyConfigurationCollectionCountTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer, null);
            IShipConfigeration config = ShipConfigerationFactory.CreateShipConfiguration(ShipType.Destroyer, ShipConfigurationType.Heavy);
            Assert.True(config.attackImplements.Count() > 0);
            Assert.True(config.defendImplements.Count() > 0);
            Assert.True(config.upgradeImplements.Count() > 0);
            Assert.True(config.attackImplements.Sum(x => x.Size) <= ship.NumberOfAttackSlots);
            Assert.True(config.defendImplements.Sum(x => x.Size) <= ship.NumberOfDefendSlots);
            Assert.True(config.upgradeImplements.Sum(x => x.Size) <= ship.NumberOfUpgradeSlots);
        }

        [Fact()]
        public void CreateDestroyerLightConfigurationCollectionCountTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer, null);
            IShipConfigeration config = ShipConfigerationFactory.CreateShipConfiguration(ShipType.Destroyer, ShipConfigurationType.Light);
            Assert.True(config.attackImplements.Count() > 0);
            Assert.True(config.defendImplements.Count() > 0);
            Assert.True(config.upgradeImplements.Count() > 0);
            Assert.True(config.attackImplements.Sum(x => x.Size) <= ship.NumberOfAttackSlots);
            Assert.True(config.defendImplements.Sum(x => x.Size) <= ship.NumberOfDefendSlots);
            Assert.True(config.upgradeImplements.Sum(x => x.Size) <= ship.NumberOfUpgradeSlots);
        }
    }
}