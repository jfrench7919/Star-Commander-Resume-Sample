﻿using Xunit;
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
    public class MetalicMicrobesImplementTests
    {
        [Fact()]
        public void MetalicMicrobesPowerBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MetalicMicrobes);
            Assert.Equal(15, upgradeImplement.Power);
        }

        [Fact()]
        public void MetalicMicrobesSizeBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MetalicMicrobes);
            Assert.Equal(10, upgradeImplement.Size);
        }

        [Fact()]
        public void MetalicMicrobesHealthBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MetalicMicrobes);
            Assert.Equal(100, upgradeImplement.Health);
        }

        [Fact()]
        public void MetalicMicrobesShipHealthModificationBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MetalicMicrobes);
            Assert.Equal(10, upgradeImplement.ShipHealthModification);
        }

        [Fact()]
        public void MetalicMicrobesShipPowerModificationBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MetalicMicrobes);
            Assert.Equal(0, upgradeImplement.ShipPowerModification);
        }

        [Fact()]
        public void MetalicMicrobesShipSpeedModificationBaseValueTest()
        {
            IUpgradeImplement upgradeImplement = UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MetalicMicrobes);
            Assert.Equal(-2, upgradeImplement.ShipSpeedModification);
        }
    }
}