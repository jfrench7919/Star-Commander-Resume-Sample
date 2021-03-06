﻿using Xunit;
using StarCommander.Factories;
using StarCommander.Types;
using StarCommander.Fleets;

namespace StarCommander.AttackImplement.Tests
{
    public class MissileImplementTests
    {
        [Fact()]
        public void MissilePowerBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile);
            Assert.Equal(1, attackImplement.Power);
        }

        [Fact()]
        public void MissileShipArmorModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile);
            Assert.Equal(0, attackImplement.ShipArmorModification);
        }

        [Fact()]
        public void MissileSizeBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile);
            Assert.Equal(2, attackImplement.Size);
        }

        [Fact()]
        public void MissileHealthBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile);
            Assert.Equal(100, attackImplement.Health);
        }

        [Fact()]
        public void MissileAmmoBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile);
            Assert.Equal(4, attackImplement.Ammo);
        }

        [Fact()]
        public void MissileAmmoAvailableTest()
        {
            IAttackImplement i = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile);
            Assert.True(i.AmmoAvailable);
        }

        [Fact()]
        public void MissileAmmoUnAvailableTest()
        {
            IAttackImplement ai = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile);
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigurationType.BalancedShips, BattleStratageyType.WeekShipsFirst);
            var shots = ai.Ammo;
            for (int i = 0; i < shots; i++)
            {
                ai.Fire(fleet, BattleStratageyType.StrongShipsFirst);
            }
            Assert.False(ai.AmmoAvailable);
        }

        [Fact()]
        public void MissileShipHealthModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile);
            Assert.Equal(0, attackImplement.ShipHealthModification);
        }

        [Fact()]
        public void MissileShipPowerModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile);
            Assert.Equal(0, attackImplement.ShipPowerModification);
        }

        [Fact()]
        public void MissileShipSpeedModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile);
            Assert.Equal(-2, attackImplement.ShipSpeedModification);
        }
    }
}