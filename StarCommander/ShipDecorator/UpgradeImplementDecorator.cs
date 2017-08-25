using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.UpgradeImplement;
using StarCommander.Ships;

namespace StarCommander.ShipDecorator
{
    public class UpgradeImplementDecorator
    {
        public static void DecorateShip(IStarShip ship, IUpgradeImplement upgradeImplement)
        {
            if (ship.NumberOfUpgradeSlotsAvailable >= upgradeImplement.Size)
            {
                ship.UpgradeImplements.Add(upgradeImplement);
                ship.Health = ship.Health + upgradeImplement.ShipHealthModification;
                ship.Speed = ship.Speed + upgradeImplement.ShipSpeedModification;
                ship.Power = ship.Power + upgradeImplement.ShipPowerModification;
                ship.Armor = ship.Armor + upgradeImplement.ShipArmorModification;
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
