using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Ships;
using StarCommander.Types;

namespace StarCommander.Factories
{
    public class ShipFactory
    {
        public static IStarShip CreateShip(Nullable<ShipType> type)
        {
            switch(type)
            {
                case ShipType.Fighter:
                    var fighter = new Fighter();
                    SetFighterDefaultValues(fighter);
                    return fighter;
                case ShipType.Friget:
                    var friget = new Friget();
                    SetFrigetDefaultValues(friget);
                    return friget;
                case ShipType.Destroyer:
                    var destroyer = new Destroyer();
                    SetDestroyerDefaultValues(destroyer);
                    return destroyer;
                default:
                    return null;
            }
        }

        private static void SetFighterDefaultValues(IStarShip ship)
        {
            ship.Power = 50;
            ship.Size = 70;
            ship.Armor = 30;
            ship.Speed = 80;
            ship.NumberOfAttackSlots = 15;
            ship.NumberOfDefendSlots = 10;
            ship.NumberOfUpgradeSlots = 5;
        }

        private static void SetFrigetDefaultValues(IStarShip ship)
        {
            ship.Power = 70;
            ship.Size = 500;
            ship.Armor = 60;
            ship.Speed = 30;
            ship.NumberOfAttackSlots = 40;
            ship.NumberOfDefendSlots = 20;
            ship.NumberOfUpgradeSlots = 10;
        }

        private static void SetDestroyerDefaultValues(IStarShip ship)
        {
            ship.Power = 100;
            ship.Size = 2000;
            ship.Armor = 90;
            ship.Speed = 10;
            ship.NumberOfAttackSlots = 150;
            ship.NumberOfDefendSlots = 50;
            ship.NumberOfUpgradeSlots = 20;
        }
    }
}
