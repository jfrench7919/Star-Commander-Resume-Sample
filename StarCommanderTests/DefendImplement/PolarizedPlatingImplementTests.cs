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
    }
}