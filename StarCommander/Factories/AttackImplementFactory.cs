using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.AttackImplement;

namespace StarCommander.Factories
{
    public class AttackImplementFactory
    {
        public static IAttackImplement CreateAttackImplement(Nullable<AttackImplementType> type)
        {
            switch(type)
            {
                case AttackImplementType.Laser:
                    var laser = new LaserImplement();
                    SetLaserDefaultValues(laser);
                    return laser;
                case AttackImplementType.Missile:
                    var missile = new MissileImplement();
                    SetMissileDefaultValues(missile);
                    return missile;
                case AttackImplementType.PhotonTorpedo:
                    var photonTorpedo = new PhotonTorpedoImplement();
                    SetPhotonTorpedoDefaultValues(photonTorpedo);
                    return photonTorpedo;
                case AttackImplementType.PlasmaCannon:
                    var plasmaCannon = new PlasmaCannonImplement();
                    SetPlasmaCannonDefaultValues(plasmaCannon);
                    return plasmaCannon;
                default:
                    return null;
            }
        }

        private static void SetLaserDefaultValues(IAttackImplement attackImplement)
        {
            attackImplement.Power = 2;
            attackImplement.Health = 100;
            attackImplement.Ammo = null;
            attackImplement.Size = 1;
        }

        private static void SetMissileDefaultValues(IAttackImplement attackImplement)
        {
            attackImplement.Power = 4;
            attackImplement.Health = 100;
            attackImplement.Ammo = 4;
            attackImplement.Size = 2;
        }

        private static void SetPhotonTorpedoDefaultValues(IAttackImplement attackImplement)
        {
            attackImplement.Power = 8;
            attackImplement.Health = 100;
            attackImplement.Ammo = 10;
            attackImplement.Size = 4;
        }

        private static void SetPlasmaCannonDefaultValues(IAttackImplement attackImplement)
        {
            attackImplement.Power = 6;
            attackImplement.Health = 100;
            attackImplement.Ammo = 100;
            attackImplement.Size = 8;
        }
    }
}
