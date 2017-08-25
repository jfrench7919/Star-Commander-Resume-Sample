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
            Assert.Equal(20, upgradeImplement.Size);
        }

        [Fact()]
        public void MineFieldHealthBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MineField);
            Assert.Equal(100, upgradeImplement.Health);
        }

        [Fact()]
        public void MineFieldShipHealthModificationBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MineField);
            Assert.Equal(70, upgradeImplement.ShipArmorModification);
        }

        [Fact()]
        public void MineFieldShipPowerModificationBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MineField);
            Assert.Equal(0, upgradeImplement.ShipPowerModification);
        }

        [Fact()]
        public void MineFieldShipSpeedModificationBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MineField);
            Assert.Equal(-20, upgradeImplement.ShipSpeedModification);
        }
    }
}