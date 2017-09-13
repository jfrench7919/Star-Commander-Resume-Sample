using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.Configeration;
using StarCommander.ShipDecorator;

namespace StarCommander.Factories
{
    public class ShipFactory
    {
        public static IStarShip CreateShip(Nullable<ShipType> shipType, Nullable<ShipConfigurationType> configurationType)
        {
            switch(shipType)
            {
                case ShipType.Fighter:
                    var fighter = new Fighter();
                    SetFighterDefaultValues(fighter);
                    SetDecorations(fighter, shipType, configurationType);
                    fighter.Name = NameGenerator();
                    return fighter;
                case ShipType.Friget:
                    var friget = new Friget();
                    SetFrigetDefaultValues(friget);
                    SetDecorations(friget, shipType, configurationType);
                    friget.Name = NameGenerator();
                    return friget;
                case ShipType.Destroyer:
                    var destroyer = new Destroyer();
                    SetDestroyerDefaultValues(destroyer);
                    SetDecorations(destroyer, shipType, configurationType);
                    destroyer.Name = NameGenerator();
                    return destroyer;
                default:
                    return null;
            }
        }

        private static void SetDecorations(IStarShip ship, ShipType? shipType, ShipConfigurationType? configurationType)
        {
            if (shipType != null && configurationType != null)
            {
                IShipConfigeration conCollection = ShipConfigerationFactory.CreateShipConfiguration(shipType, configurationType);

                foreach (var i in conCollection.upgradeImplements)
                {
                    UpgradeImplementDecorator.DecorateShip(ship, i);
                }
                
                foreach (var i in conCollection.defendImplements)
                {
                    DefendImplementDecorator.DecorateShip(ship, i);
                }

                foreach (var i in conCollection.attackImplements)
                {
                    AttackImplementDecorator.DecorateShip(ship, i);
                }
            }
        }

        private static void SetFighterDefaultValues(IStarShip ship)
        {
            ship.Power = 100;
            ship.Size = 70;
            ship.Armor = 90;
            ship.Speed = 800;
            ship.Health = 250;
            ship.NumberOfAttackSlots = 15;
            ship.NumberOfDefendSlots = 10;
            ship.NumberOfUpgradeSlots = 5;
            ship.Name = NameGenerator();
            ship.myShipType = ShipType.Fighter;
        }

        private static void SetFrigetDefaultValues(IStarShip ship)
        {
            ship.Power = 140;
            ship.Size = 500;
            ship.Armor = 180;
            ship.Speed = 500;
            ship.Health = 500;
            ship.NumberOfAttackSlots = 40;
            ship.NumberOfDefendSlots = 20;
            ship.NumberOfUpgradeSlots = 10;
            ship.Name = NameGenerator();
            ship.myShipType = ShipType.Friget;
        }

        private static void SetDestroyerDefaultValues(IStarShip ship)
        {
            ship.Power = 200;
            ship.Size = 2000;
            ship.Armor = 270;
            ship.Speed = 300;
            ship.Health = 1000;
            ship.NumberOfAttackSlots = 150;
            ship.NumberOfDefendSlots = 50;
            ship.NumberOfUpgradeSlots = 20;
            ship.Name = NameGenerator();
            ship.myShipType = ShipType.Destroyer;
        }

        private static string NameGenerator()
        {
            int maxIndex = ShipNames.names.Count() - 1;
            int returnedRandom = rnd.Next(1, maxIndex);
            return ShipNames.names[returnedRandom];
        }

        private static Random rnd = new Random();
    }
}
