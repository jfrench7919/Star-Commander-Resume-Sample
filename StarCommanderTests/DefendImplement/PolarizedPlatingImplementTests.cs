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
    public class PolarizedPlatingImplementTests
    {
        [Fact()]
        public void PolarizedPlatingPowerBaseValueTest()
        {
            IDefendImplement defendImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.PolarizedPlating);
            Assert.Equal(100, defendImplement.Power);
        }

        [Fact()]
        public void PolarizedPlatingSizeBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.PolarizedPlating);
            Assert.Equal(5, upgradeImplement.Size);
        }

        [Fact()]
        public void PolarizedPlatingHealthBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.PolarizedPlating);
            Assert.Equal(100, upgradeImplement.Health);
        }

        [Fact()]
        public void PolarizedPlatingShipHealthModificationBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.PolarizedPlating);
            Assert.Equal(10, upgradeImplement.ShipHealthModification);
        }

        [Fact()]
        public void PolarizedPlatingShipPowerModificationBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.PolarizedPlating);
            Assert.Equal(0, upgradeImplement.ShipPowerModification);
        }

        [Fact()]
        public void PolarizedPlatingShipSpeedModificationBaseValueTest()
        {
            IDefendImplement upgradeImplement = DefendImplementFactory.CreateDefendImplement(DefendImplementType.PolarizedPlating);
            Assert.Equal(-2, upgradeImplement.ShipSpeedModification);
        }
    }
}