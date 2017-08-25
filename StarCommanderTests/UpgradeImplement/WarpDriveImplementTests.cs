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
    public class WarpDriveImplementTests
    {
        [Fact()]
        public void WarpDrivePowerBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.WarpDrive);
            Assert.Equal(10, upgradeImplement.Power);
        }

        [Fact()]
        public void WarpDriveSizeBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.WarpDrive);
            Assert.Equal(5, upgradeImplement.Size);
        }

        [Fact()]
        public void WarpDriveHealthBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.WarpDrive);
            Assert.Equal(100, upgradeImplement.Health);
        }
    }
}