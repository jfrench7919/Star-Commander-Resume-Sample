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
            ship.Power = 45;
            ship.Size = 10;
            ship.Armor = 30;
        }

        private static void SetFrigetDefaultValues(IStarShip ship)
        {
            ship.Power = 60;
            ship.Size = 40;
            ship.Armor = 60;
        }

        private static void SetDestroyerDefaultValues(IStarShip ship)
        {
            ship.Power = 100;
            ship.Size = 90;
            ship.Armor = 90;
        }
    }
}
