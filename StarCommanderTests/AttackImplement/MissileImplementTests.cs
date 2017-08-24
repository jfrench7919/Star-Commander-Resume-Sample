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
    public class MissileImplementTests
    {
        [Fact()]
        public void MissilePowerBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile);
            Assert.Equal(4, attackImplement.Power);
        }
    }
}