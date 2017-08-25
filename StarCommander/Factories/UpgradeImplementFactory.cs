using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.UpgradeImplement;

namespace StarCommander.Factories
{
    public class UpgradeImplementFactory
    {
        public static IUpgradeImplement CreateUpgradeImplement(Nullable<UpgradeImplementType> type)
        {
            switch (type)
            {
                case UpgradeImplementType.MetalicMicrobes:
                    var metalicMicrobes = new MetalicMicrobesImplement();
                    SetMetalicMicrobesDefaultValues(metalicMicrobes);
                    return metalicMicrobes;
                case UpgradeImplementType.MineField:
                    var mineField = new MineFieldImplement();
                    SetMineFieldDefaultValues(mineField);
                    return mineField;
                case UpgradeImplementType.WarpDrive:
                    var warpDrive = new WarpDriveImplement();
                    SetWarpDriveDefaultValues(warpDrive);
                    return warpDrive;
                default:
                    return null;
            }
        }

        private static void SetMetalicMicrobesDefaultValues(IUpgradeImplement upgradeImplement)
        {
            upgradeImplement.Power = 15;
            upgradeImplement.Size = 10;
            upgradeImplement.Health = 100;
            upgradeImplement.ShipHealthModification = 10;
            upgradeImplement.ShipArmorModification = 10;
            upgradeImplement.ShipSpeedModification = -2;
        }

        private static void SetMineFieldDefaultValues(IUpgradeImplement upgradeImplement)
        {
            upgradeImplement.Power = 25;
            upgradeImplement.Size = 20;
            upgradeImplement.Health = 100;
            upgradeImplement.ShipArmorModification = 70;
            upgradeImplement.ShipSpeedModification = -20;
        }

        private static void SetWarpDriveDefaultValues(IUpgradeImplement upgradeImplement)
        {
            upgradeImplement.Power = 10;
            upgradeImplement.Size = 5;
            upgradeImplement.Health = 100;
            upgradeImplement.ShipSpeedModification = 30;
        }
    }
}
