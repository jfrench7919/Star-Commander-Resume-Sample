﻿using Xunit;
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
    public class PhotonTorpedoImplementTests
    {
        [Fact()]
        public void PhotonTorpedoPowerBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo);
            Assert.Equal(8, attackImplement.Power);
        }
    }
}