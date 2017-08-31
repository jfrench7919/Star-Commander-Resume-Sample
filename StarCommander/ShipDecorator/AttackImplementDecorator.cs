using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.AttackImplement;
using StarCommander.Ships;

namespace StarCommander.ShipDecorator
{
    public class AttackImplementDecorator
    {
        public static void DecorateShip(IStarShip ship, IAttackImplement attackImplement)
        {
            if(ship.NumberOfAttackSlotsAvailable >= attackImplement.Size)
            {
                ship.AttackImplements.Add(attackImplement);
                ship.Health = ship.Health + attackImplement.ShipHealthModification;
                ship.Speed = ship.Speed + attackImplement.ShipSpeedModification;
                ship.Power = ship.Power + attackImplement.ShipPowerModification;
                ship.Armor = ship.Armor + attackImplement.ShipArmorModification;

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
