using Xunit;
using StarCommander.UpgradeImplement;
using StarCommander.Factories;
using StarCommander.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.UpgradeImplement.Tests
{
    public class MineFieldImplementTests
    {
        [Fact()]
        public void MineFieldPowerBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MineField);
            Assert.Equal(25, upgradeImplement.Power);
        }

        [Fact()]
        public void MineFieldSizeBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MineField);
            Assert.Equal(25, upgradeImplement.Size);
        }

        [Fact()]
        public void MineFieldHealthBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MineField);
            Assert.Equal(100, upgradeImplement.Health);
        }
    }
}