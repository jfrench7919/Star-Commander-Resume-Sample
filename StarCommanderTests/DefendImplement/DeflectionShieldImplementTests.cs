using Xunit;
using StarCommander.DefendImplement;
using StarCommander.Factories;
using StarCommander.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.DefendImplement.Tests
{
    public class DeflectionShieldImplementTests
    {
        [Fact()]
        public void DeflectionShieldPowerBaseValueTest()
        {
            IDefendImplement defendImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.DeflectionShield);
            Assert.Equal(60, defendImplement.Power);
        }

        [Fact()]
        public void DeflectionShieldSizeBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.DeflectionShield);
            Assert.Equal(3, upgradeImplement.Size);
        }

        [Fact()]
        public void DeflectionShieldsHealthBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.DeflectionShield);
            Assert.Equal(100, upgradeImplement.Health);
        }

        [Fact()]
        public void DeflectionShieldsShipHealthModificationBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.DeflectionShield);
            Assert.Equal(20, upgradeImplement.ShipHealthModification);
        }

        [Fact()]
        public void DeflectionShieldsShipPowerModificationBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.DeflectionShield);
            Assert.Equal(0, upgradeImplement.ShipPowerModification);
        }

        [Fact()]
        public void DeflectionShieldsShipSpeedModificationBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.DeflectionShield);
            Assert.Equal(-4, upgradeImplement.ShipSpeedModification);
        }
    }
}