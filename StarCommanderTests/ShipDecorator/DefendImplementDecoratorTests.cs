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
    public class DefendImplementDecoratorTests
    {
        [Fact()]
        public void DeflectionShieldDecorateShipTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, null);
            var oSpeed = ship.Speed;
            var oHealth = ship.Health;
            var oPower = ship.Power;
            var oArmor = ship.Armor;

            var newImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.DeflectionShield);
            DefendImplementDecorator.DecorateShip(ship, newImplement);

            Assert.True(ship.Speed == (oSpeed + newImplement.ShipSpeedModification) || ship.Speed == 0);
            Assert.True(ship.Health == (oHealth + newImplement.ShipHealthModification) || ship.Health == 0);
            Assert.True(ship.Power == (oPower + newImplement.ShipPowerModification) || ship.Power == 0);
            Assert.True(ship.Armor == (oArmor + newImplement.ShipArmorModification) || ship.Armor == 0);
            Assert.Equal(1, ship.DefendImplements.Count());
        }

        [Fact()]
        public void PolarizedPlatingDecorateShipTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, null);
            var oSpeed = ship.Speed;
            var oHealth = ship.Health;
            var oPower = ship.Power;
            var oArmor = ship.Armor;

            var newImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.PolarizedPlating);
            DefendImplementDecorator.DecorateShip(ship, newImplement);

            Assert.True(ship.Speed == (oSpeed + newImplement.ShipSpeedModification) || ship.Speed == 0);
            Assert.True(ship.Health == (oHealth + newImplement.ShipHealthModification) || ship.Health == 0);
            Assert.True(ship.Power == (oPower + newImplement.ShipPowerModification) || ship.Power == 0);
            Assert.True(ship.Armor == (oArmor + newImplement.ShipArmorModification) || ship.Armor == 0);
            Assert.Equal(1, ship.DefendImplements.Count());
        }

        [Fact()]
        public void ShieldBoosterDecorateShipTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, null);
            var oSpeed = ship.Speed;
            var oHealth = ship.Health;
            var oPower = ship.Power;
            var oArmor = ship.Armor;

            var newImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.ShieldBooster);
            DefendImplementDecorator.DecorateShip(ship, newImplement);

            Assert.True(ship.Speed == (oSpeed + newImplement.ShipSpeedModification) || ship.Speed == 0);
            Assert.True(ship.Health == (oHealth + newImplement.ShipHealthModification) || ship.Health == 0);
            Assert.True(ship.Power == (oPower + newImplement.ShipPowerModification) || ship.Power == 0);
            Assert.True(ship.Armor == (oArmor + newImplement.ShipArmorModification) || ship.Armor == 0);
            Assert.Equal(1, ship.DefendImplements.Count());
        }
    }
}