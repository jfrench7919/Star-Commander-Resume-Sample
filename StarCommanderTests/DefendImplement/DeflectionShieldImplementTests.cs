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
    }
}