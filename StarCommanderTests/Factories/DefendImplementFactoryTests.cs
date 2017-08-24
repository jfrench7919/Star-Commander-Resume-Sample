using Xunit;
using StarCommander.Factories;
using StarCommander.Types;
using StarCommander.DefendImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.Factories.Tests
{
    public class DefendImplementFactoryTests
    {
        [Fact()]
        public void CreatDeflectionShieldImplementTest()
        {
            Assert.IsType<DeflectionShieldImplement>(DefendImplementFactory.CreateDefendImplement(DefendImplementType.DeflectionShield));
        }

        [Fact()]
        public void CreatePolarizedPlatingImplementTest()
        {
            Assert.IsType<PolarizedPlatingImplement>(DefendImplementFactory.CreateDefendImplement(DefendImplementType.PolarizedPlating));
        }

        [Fact()]
        public void CreateShieldBoosterImplementTest()
        {
            Assert.IsType<ShieldBoosterImplement>(DefendImplementFactory.CreateDefendImplement(DefendImplementType.ShieldBooster));
        }

        [Fact()]
        public void CreateDefendImplementNullTest()
        {
            Assert.Equal(null, DefendImplementFactory.CreateDefendImplement(null));
        }
    }
}