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
    }
}