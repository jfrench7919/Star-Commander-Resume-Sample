using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Configuration;
using StarCommander.Types;

namespace StarCommander.Factories
{
    public class FleetConfigurationFactory
    {
        public static IFleetConfiguration CreateFleetConfiguration(Nullable<FleetConfigurationType> fleetConfigurationType)
        {

            switch (fleetConfigurationType)
            {
                case FleetConfigurationType.SmallShips:
                    IFleetConfiguration smallShips = new FleetConfiguration();
                    CreateSmallShipDefaultCollection(smallShips);
                    return smallShips;
                case FleetConfigurationType.BalancedShips:
                    IFleetConfiguration balancedShips = new FleetConfiguration();
                    CreateBalancedShipDefaultCollection(balancedShips);
                    return balancedShips;
                case FleetConfigurationType.HeavyShips:
                    IFleetConfiguration heavyShips = new FleetConfiguration();
                    CreateHeavyShipDefaultCollection(heavyShips);
                    return heavyShips;
                default:
                    return null;
            }
        }

        private static void CreateHeavyShipDefaultCollection(IFleetConfiguration heavyShips)
        {
            //Add Destroyers
            for (int i = 0; i < 2; i++)
            {
                heavyShips.Destroyers.Add(ShipFactory.CreateShip(ShipType.Destroyer, ShipConfigurationType.Heavy));
            }

            //Add Friget
            for (int i = 0; i < 3; i++)
            {
                heavyShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Heavy));
                heavyShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Heavy));
                heavyShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Balanced));
            }

            //Add Fighters
            for (int i = 0; i < 16; i++)
            {
                heavyShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Heavy));
                heavyShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Heavy));
                heavyShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Balanced));
            }
        }

        private static void CreateBalancedShipDefaultCollection(IFleetConfiguration balancedShips)
        {
            //Add Destroyers
            balancedShips.Destroyers.Add(ShipFactory.CreateShip(ShipType.Destroyer, ShipConfigurationType.Balanced));
            
            //Add Friget
            for (int i = 0; i < 3; i++)
            {
                balancedShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Balanced));
                balancedShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Balanced));
                balancedShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Heavy));
            }

            //Add Fighters
            for (int i = 0; i < 25; i++)
            {
                balancedShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Balanced));
                balancedShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Balanced));
                balancedShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Light));
            }
        }

        private static void CreateSmallShipDefaultCollection(IFleetConfiguration smallShips)
        {
            //Add Friget
            for (int i = 0; i < 3; i++)
            {
                smallShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Light));
                smallShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Light));
                smallShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Balanced));
            }

            //Add Fighters
            for (int i = 0; i < 35; i++)
            {
                smallShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Light));
                smallShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Light));
                smallShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Balanced));
            }
        }
    }
}
