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
    public class ShieldBoosterImplementTests
    {
        [Fact()]
        public void ShieldBoosterPowerBaseValueTest()
        {
            IDefendImplement defendImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.ShieldBooster);
            Assert.Equal(40, defendImplement.Power);
        }

        [Fact()]
        public void ShieldBoosterSizeBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.ShieldBooster);
            Assert.Equal(10, upgradeImplement.Size);
        }

        [Fact()]
        public void ShieldBoosterHealthBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.ShieldBooster);
            Assert.Equal(100, upgradeImplement.Health);
        }

        [Fact()]
        public void ShieldBoosterShipHealthModificationBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.ShieldBooster);
            Assert.Equal(30, upgradeImplement.ShipHealthModification);
        }

        [Fact()]
        public void ShieldBoosterShipPowerModificationBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.ShieldBooster);
            Assert.Equal(0, upgradeImplement.ShipPowerModification);
        }

        [Fact()]
        public void ShieldBoosterShipSpeedModificationBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.ShieldBooster);
            Assert.Equal(-8, upgradeImplement.ShipSpeedModification);
        }
    }
}