using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.ShipDecorator.DefendImplement;

namespace StarCommander.Factories
{
    public class DefendImplementFactory
    {
        public static IDefendImplement CreateDefendImplement(Nullable<DefendImplementType> type)
        {
            switch(type)
            {
                case DefendImplementType.DeflectionShield:
                    return null;
                case DefendImplementType.PolarizedPlating:
                    return null;
                case DefendImplementType.ShieldBooster:
                    return null;
                default:
                    return null;
            }
        }
    }
}
