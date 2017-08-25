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
    public class PlasmaCannonImplementTests
    {
        [Fact()]
        public void PlasmaCannonPowerBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.Equal(6, attackImplement.Power);
        }

        [Fact()]
        public void PlasmaCannonSizeBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.Equal(8, attackImplement.Size);
        }

        [Fact()]
        public void PlasmaCannonHealthBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.Equal(100, attackImplement.Health);
        }

        [Fact()]
        public void PlasmaCannonAmmoBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.Equal(100, attackImplement.Ammo);
        }

        [Fact()]
        public void PlasmaCannonAmmoAvailableTest()
        {
            IAttackImplement i = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.True(i.AmmoAvailable);
        }

        [Fact()]
        public void PlasmaCannonAmmoUnAvailableTest()
        {
            IAttackImplement ai = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            var shots = ai.Ammo;
            for (int i = 0; i < shots; i++)
            {
                ai.Fire();
            }
            Assert.False(ai.AmmoAvailable);
        }

        [Fact()]
        public void PlasmaCannonObserverNotNullTest()
        {
            IAttackImplement ai = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.False(ai.EnemyShips == null);
            Assert.Equal(0, ai.EnemyShips.Count());
        }

        [Fact()]
        public void PlasmaCannonObserverCountTest()
        {
            IAttackImplement ai = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            ai.EnemyShips.Add(ShipFactory.CreateShip(ShipType.Fighter));
            ai.EnemyShips.Add(ShipFactory.CreateShip(ShipType.Fighter));
            ai.EnemyShips.Add(ShipFactory.CreateShip(ShipType.Fighter));
            Assert.Equal(3, ai.EnemyShips.Count());
        }
    }
}