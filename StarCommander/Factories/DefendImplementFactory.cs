using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.DefendImplement;

namespace StarCommander.Factories
{
    public class DefendImplementFactory
    {
        public static IDefendImplement CreateDefendImplement(Nullable<DefendImplementType> type)
        {
            switch (type)
            {
                case DefendImplementType.DeflectionShield:
                    var deflectionShield = new DeflectionShieldImplement();
                    SetDeflectionShieldDefaultValues(deflectionShield);
                    return deflectionShield;
                case DefendImplementType.PolarizedPlating:
                    var polarizedPlating = new PolarizedPlatingImplement();
                    SetPolarizedPlatingDefaultValues(polarizedPlating);
                    return polarizedPlating;
                case DefendImplementType.ShieldBooster:
                    var shieldBooster = new ShieldBoosterImplement();
                    SetShieldBoosterDefaultValues(shieldBooster);
                    return shieldBooster;
                default:
                    return null;
            }
        }

        private static void SetDeflectionShieldDefaultValues(IDefendImplement defendImplement)
        {
            defendImplement.Power = 60;
        }

        private static void SetPolarizedPlatingDefaultValues(IDefendImplement defendImplement)
        {
            defendImplement.Power = 100;
        }

        private static void SetShieldBoosterDefaultValues(IDefendImplement defendImplement)
        {
            defendImplement.Power = 40;
        }
    }
}
