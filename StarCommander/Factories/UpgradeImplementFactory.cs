using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.ShipDecorator.UpgradeImplement;

namespace StarCommander.Factories
{
    public class UpgradeImplementFactory
    {
        public static IUpgradeImplement CreateUpgradeImplement(Nullable<UpgradeImplementType> type)
        {
            switch(type)
            {
                case UpgradeImplementType.MetalicMicrobes:
                    return null;
                case UpgradeImplementType.MineField:
                    return null;
                case UpgradeImplementType.WarpDrive:
                    return null;
                default:
                    return null;
            }
        }
    }
}
