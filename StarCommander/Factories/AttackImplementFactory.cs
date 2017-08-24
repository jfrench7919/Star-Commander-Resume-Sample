using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.ShipDecorator.AttackImplement;

namespace StarCommander.Factories
{
    public class AttackImplementFactory
    {
        public static IAttackImplement CreateAttackImplement(Nullable<AttackImplementType> type)
        {
            switch(type)
            {
                case AttackImplementType.Laser:
                    return null;
                case AttackImplementType.Missile:
                    return null;
                case AttackImplementType.PhotonTorpedo:
                    return null;
                case AttackImplementType.PlasmaCannon:
                    return null;
                default:
                    return null;
            }
        }
    }
}
