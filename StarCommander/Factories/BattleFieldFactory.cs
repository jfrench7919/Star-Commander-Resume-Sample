using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.BattleFields;
using StarCommander.Types;
using StarCommander.Configeration;

namespace StarCommander.Factories
{
    public class BattleFieldFactory
    {
        public static IBattleField CreateBattleField(Nullable<BattleFieldType> battleFieldType)
        {
            switch (battleFieldType)
            {
                case BattleFieldType.Large:
                    IBattleField large = new BattleField();
                    SetLargeDefaultValues(large);
                    return large;
                case BattleFieldType.Medium:
                    IBattleField medium = new BattleField();
                    SetMediumDefaultValues(medium);
                    return medium;
                case BattleFieldType.Small:
                    IBattleField small = new BattleField();
                    SetSmallDefaultValues(small);
                    return small;
                default:
                    return null;
            }
        }

        private static void SetSmallDefaultValues(IBattleField small)
        {
            small.NumberOfFleetSlots = 24000;
        }

        private static void SetMediumDefaultValues(IBattleField medium)
        {
            medium.NumberOfFleetSlots = 48000;
        }

        private static void SetLargeDefaultValues(IBattleField large)
        {
            large.NumberOfFleetSlots = 72000;
        }
    }
}
