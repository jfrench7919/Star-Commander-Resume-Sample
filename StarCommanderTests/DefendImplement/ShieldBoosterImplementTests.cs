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
    }
}