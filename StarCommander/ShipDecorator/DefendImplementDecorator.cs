using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.DefendImplement;
using StarCommander.Ships;

namespace StarCommander.ShipDecorator
{
    public class DefendImplementDecorator
    {
        public static void DecorateShip(IStarShip ship, IDefendImplement defendImplement)
        {
            if (ship.NumberOfDefendSlotsAvailable >= defendImplement.Size)
            {
                ship.DefendImplements.Add(defendImplement);
                ship.Health = ship.Health + defendImplement.ShipHealthModification;
                ship.Speed = ship.Speed + defendImplement.ShipSpeedModification;
                ship.Power = ship.Power + defendImplement.ShipPowerModification;
                ship.Armor = ship.Armor + defendImplement.ShipArmorModification;
                if (ship.Health < 0)
                {
                    ship.Health = 0;
                }
                if (ship.Speed < 0)
                {
                    ship.Speed = 0;
                }
                if (ship.Power < 0)
                {
                    ship.Power = 0;
                }
                if (ship.Armor < 0)
                {
                    ship.Armor = 0;
                }
            }
        }
    }
}
