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
        }

        private static void SetMineFieldDefaultValues(IUpgradeImplement upgradeImplement)
        {
        }

        private static void SetWarpDriveDefaultValues(IUpgradeImplement upgradeImplement)
        {
        }
    }
}
