using Xunit;
using StarCommander.Factories;
using StarCommander.Types;
using StarCommander.UpgradeImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.Factories.Tests
{
    public class UpgradeImplementFactoryTests
    {
        [Fact()]
        public void CreatMetalicMicrobesImplementTest()
        {
            Assert.IsType<MetalicMicrobesImplement>(UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MetalicMicrobes));
        }

        [Fact()]
        public void CreateMineFieldImplementTest()
        {
            Assert.IsType<MineFieldImplement>(UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MineField));
        }

        [Fact()]
        public void CreateShieldBoosterImplementTest()
        {
            Assert.IsType<WarpDriveImplement>(UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.WarpDrive));
        }

        [Fact()]
        public void CreateUpgradeImplementNullTest()
        {
            Assert.Equal(null, UpgradeImplementFactory.CreateUpgradeImplement(null));
        }
    }
}