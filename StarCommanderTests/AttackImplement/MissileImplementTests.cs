using Xunit;
using StarCommander.AttackImplement;
using StarCommander.Factories;
using StarCommander.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.AttackImplement.Tests
{
    public class MissileImplementTests
    {
        [Fact()]
        public void MissilePowerBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile);
            Assert.Equal(4, attackImplement.Power);
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
            var shots = ai.Ammo;
            for (int i = 0; i < shots; i++)
            {
                ai.Fire();
            }
            Assert.False(ai.AmmoAvailable);
        }

        [Fact()]
        public void MissileObserverNotNullTest()
        {
            IAttackImplement ai = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile);
            Assert.False(ai.EnemyShips == null);
            Assert.Equal(0, ai.EnemyShips.Count());
        }

        [Fact()]
        public void MissileObserverCountTest()
        {
            IAttackImplement ai = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile);
            ai.EnemyShips.Add(ShipFactory.CreateShip(ShipType.Fighter, null));
            ai.EnemyShips.Add(ShipFactory.CreateShip(ShipType.Fighter, null));
            ai.EnemyShips.Add(ShipFactory.CreateShip(ShipType.Fighter, null));
            Assert.Equal(3, ai.EnemyShips.Count());
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