using Xunit;
using StarCommander.ShipDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.Factories;

namespace StarCommander.ShipDecorator.Tests
{
    public class UpgradeImplementDecoratorTests
    {
        [Fact()]
        public void MetalicMicrobesDecorateShipTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer, null);
            var oSpeed = ship.Speed;
            var oHealth = ship.Health;
            var oPower = ship.Power;
            var oArmor = ship.Armor;

            var newImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MetalicMicrobes);
            UpgradeImplementDecorator.DecorateShip(ship, newImplement);

            Assert.True(ship.Speed == (oSpeed + newImplement.ShipSpeedModification) || ship.Speed == 0);
            Assert.True(ship.Health == (oHealth + newImplement.ShipHealthModification) || ship.Health == 0);
            Assert.True(ship.Power == (oPower + newImplement.ShipPowerModification) || ship.Power == 0);
            Assert.True(ship.Armor == (oArmor + newImplement.ShipArmorModification) || ship.Armor == 0);
            Assert.Equal(1, ship.UpgradeImplements.Count());
        }

        [Fact()]
        public void MetalicMicrobesDecorateToLargeShipTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, null);
            var oSpeed = ship.Speed;
            var oHealth = ship.Health;
            var oPower = ship.Power;
            var oArmor = ship.Armor;

            var newImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MetalicMicrobes);
            UpgradeImplementDecorator.DecorateShip(ship, newImplement);

            Assert.True(ship.Speed == oSpeed);
            Assert.True(ship.Health == oHealth);
            Assert.True(ship.Power == oPower);
            Assert.True(ship.Armor == oArmor);
            Assert.Equal(0, ship.UpgradeImplements.Count());
        }

        [Fact()]
        public void MineFieldDecorateShipTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Destroyer, null);
            var oSpeed = ship.Speed;
            var oHealth = ship.Health;
            var oPower = ship.Power;
            var oArmor = ship.Armor;

            var newImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MineField);
            UpgradeImplementDecorator.DecorateShip(ship, newImplement);

            Assert.True(ship.Speed == (oSpeed + newImplement.ShipSpeedModification) || ship.Speed == 0);
            Assert.True(ship.Health == (oHealth + newImplement.ShipHealthModification) || ship.Health == 0);
            Assert.True(ship.Power == (oPower + newImplement.ShipPowerModification) || ship.Power == 0);
            Assert.True(ship.Armor == (oArmor + newImplement.ShipArmorModification) || ship.Armor == 0);
            Assert.Equal(1, ship.UpgradeImplements.Count());
        }

        [Fact()]
        public void MineFieldDecorateToLargeShipTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, null);
            var oSpeed = ship.Speed;
            var oHealth = ship.Health;
            var oPower = ship.Power;
            var oArmor = ship.Armor;

            var newImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MineField);
            UpgradeImplementDecorator.DecorateShip(ship, newImplement);

            Assert.True(ship.Speed == oSpeed);
            Assert.True(ship.Health == oHealth);
            Assert.True(ship.Power == oPower);
            Assert.True(ship.Armor == oArmor);
            Assert.Equal(0, ship.UpgradeImplements.Count());
        }

        [Fact()]
        public void WarpDriveDecorateShipTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, null);
            var oSpeed = ship.Speed;
            var oHealth = ship.Health;
            var oPower = ship.Power;
            var oArmor = ship.Armor;

            var newImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.WarpDrive);
            UpgradeImplementDecorator.DecorateShip(ship, newImplement);

            Assert.True(ship.Speed == (oSpeed + newImplement.ShipSpeedModification) || ship.Speed == 0);
            Assert.True(ship.Health == (oHealth + newImplement.ShipHealthModification) || ship.Health == 0);
            Assert.True(ship.Power == (oPower + newImplement.ShipPowerModification) || ship.Power == 0);
            Assert.True(ship.Armor == (oArmor + newImplement.ShipArmorModification) || ship.Armor == 0);
            Assert.Equal(1, ship.UpgradeImplements.Count());
        }
    }
}