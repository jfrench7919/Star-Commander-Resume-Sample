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
    public class LaserImplementTests
    {
        [Fact()]
        public void LaserPowerBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.Equal(2, attackImplement.Power);
        }

        [Fact()]
        public void LaserSizeBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.Equal(1, attackImplement.Size);
        }

        [Fact()]
        public void LaserHealthBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.Equal(100, attackImplement.Health);
        }

        [Fact()]
        public void LaserAmmoBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.Equal(false, attackImplement.Ammo.HasValue);
        }

        [Fact()]
        public void LaserAmmoAvailableTest()
        {
            IAttackImplement i = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.True(i.AmmoAvailable);
        }

        [Fact()]
        public void LaserAmmoNeverUnAvailableTest()
        {
            IAttackImplement ai = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            for (int i = 0; i < 600; i++)
            {
                ai.Fire();
            }
            Assert.True(ai.AmmoAvailable);
            Assert.False(ai.Ammo.HasValue);
        }

        [Fact()]
        public void LaserObserverNotNullTest()
        {
            IAttackImplement ai = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.False(ai.EnemyShips == null);
            Assert.Equal(0, ai.EnemyShips.Count());
        }

        [Fact()]
        public void LaserObserverCountTest()
        {
            IAttackImplement ai = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            ai.EnemyShips.Add(ShipFactory.CreateShip(ShipType.Fighter));
            ai.EnemyShips.Add(ShipFactory.CreateShip(ShipType.Fighter));
            ai.EnemyShips.Add(ShipFactory.CreateShip(ShipType.Fighter));
            Assert.Equal(3, ai.EnemyShips.Count());
        }
    }
}