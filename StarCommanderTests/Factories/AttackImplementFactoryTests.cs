using Xunit;
using StarCommander.Factories;
using StarCommander.Types;
using StarCommander.AttackImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.Factories.Tests
{
    public class AttackImplementFactoryTests
    {
        [Fact()]
        public void CreateLaserImplementTest()
        {
            Assert.IsType<LaserImplement>(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser));
        }

        [Fact()]
        public void CreateMissileImplementTest()
        {
            Assert.IsType<MissileImplement>(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile));
        }

        [Fact()]
        public void CreatePhotonTorpedoImplementTest()
        {
            Assert.IsType<PhotonTorpedoImplement>(AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo));
        }

        [Fact()]
        public void CreatePlasmaCannonImplementTest()
        {
            Assert.IsType<PlasmaCannonImplement>(AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon));
        }

        [Fact()]
        public void CreateAttackImplementNullTest()
        {
            Assert.Equal(null, AttackImplementFactory.CreateAttackImplement(null));
        }
    }
}