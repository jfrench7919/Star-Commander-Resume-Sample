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
    public class PhotonTorpedoImplementTests
    {
        [Fact()]
        public void PhotonTorpedoPowerBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo);
            Assert.Equal(8, attackImplement.Power);
        }

        [Fact()]
        public void PhotonTorpedoShipArmorModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo);
            Assert.Equal(0, attackImplement.ShipArmorModification);
        }

        [Fact()]
        public void PhotonTorpedoSizeBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo);
            Assert.Equal(4, attackImplement.Size);
        }

        [Fact()]
        public void PhotonTorpedoHealthBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo);
            Assert.Equal(100, attackImplement.Health);
        }

        [Fact()]
        public void PhotonTorpedoAmmoBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo);
            Assert.Equal(10, attackImplement.Ammo);
        }

        [Fact()]
        public void PhotonTorpedoAmmoAvailableTest()
        {
            IAttackImplement i = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo);
            Assert.True(i.AmmoAvailable);
        }

        [Fact()]
        public void PhotonTorpedoAmmoUnAvailableTest()
        {
            IAttackImplement ai = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo);
            var shots = ai.Ammo;
            for (int i = 0; i < shots; i++)
            {
                ai.Fire();
            }
            Assert.False(ai.AmmoAvailable);
        }

        [Fact()]
        public void PhotonTorpedoObserverNotNullTest()
        {
            IAttackImplement ai = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo);
            Assert.False(ai.EnemyShips == null);
            Assert.Equal(0, ai.EnemyShips.Count());
        }

        [Fact()]
        public void PhotonTorpedoObserverCountTest()
        {
            IAttackImplement ai = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo);
            ai.EnemyShips.Add(ShipFactory.CreateShip(ShipType.Fighter, null));
            ai.EnemyShips.Add(ShipFactory.CreateShip(ShipType.Fighter, null));
            ai.EnemyShips.Add(ShipFactory.CreateShip(ShipType.Fighter, null));
            Assert.Equal(3, ai.EnemyShips.Count());
        }

        [Fact()]
        public void PhotonTorpedoShipHealthModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo);
            Assert.Equal(0, attackImplement.ShipHealthModification);
        }

        [Fact()]
        public void PhotonTorpedoShipPowerModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo);
            Assert.Equal(0, attackImplement.ShipPowerModification);
        }

        [Fact()]
        public void PhotonTorpedoShipSpeedModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo);
            Assert.Equal(-3, attackImplement.ShipSpeedModification);
        }
    }
}