using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Configeration;
using StarCommander.Types;

namespace StarCommander.Factories
{
    public class FleetConfigerationFactory
    {
        public static IFleetConfigeration CreateFleetConfiguration(Nullable<FleetConfigerationType> fleetConfigerationType)
        {

            switch (fleetConfigerationType)
            {
                case FleetConfigerationType.SmallShips:
                    IFleetConfigeration smallShips = new FleetConfigeration();
                    CreateSmallShipDefaultCollection(smallShips);
                    return smallShips;
                case FleetConfigerationType.BalancedShips:
                    IFleetConfigeration balancedShips = new FleetConfigeration();
                    CreateBalancedShipDefaultCollection(balancedShips);
                    return balancedShips;
                case FleetConfigerationType.HeavyShips:
                    IFleetConfigeration heavyShips = new FleetConfigeration();
                    CreateHeavyShipDefaultCollection(heavyShips);
                    return heavyShips;
                default:
                    return null;
            }
        }

        private static void CreateHeavyShipDefaultCollection(IFleetConfigeration heavyShips)
        {
            //Add Fighters
            for (int i = 0; i < 15; i++)
            {
                heavyShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Heavy));
                heavyShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Heavy));
                heavyShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Balanced));
            }

            //Add Friget
            for (int i = 0; i < 3; i++)
            {
                heavyShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Heavy));
                heavyShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Heavy));
                heavyShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Balanced));
            }

            //Add Destroyers
            for (int i = 0; i < 2; i++)
            {
                heavyShips.Destroyers.Add(ShipFactory.CreateShip(ShipType.Destroyer, ShipConfigurationType.Heavy));
            }
        }

        private static void CreateBalancedShipDefaultCollection(IFleetConfigeration balancedShips)
        {
            //Add Fighters
            for (int i = 0; i < 20; i++)
            {
                balancedShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Balanced));
                balancedShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Balanced));
                balancedShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Light));
            }

            //Add Friget
            for (int i = 0; i < 2; i++)
            {
                balancedShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Balanced));
                balancedShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Balanced));
                balancedShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Heavy));
            }

            //Add Destroyers
            balancedShips.Destroyers.Add(ShipFactory.CreateShip(ShipType.Destroyer, ShipConfigurationType.Balanced));
            
        }

        private static void CreateSmallShipDefaultCollection(IFleetConfigeration smallShips)
        {
            //Add Fighters
            for (int i = 0; i < 30; i++)
            {
                smallShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Light));
                smallShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Light));
                smallShips.Fighters.Add(ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Balanced));
            }

            //Add Friget
            for (int i = 0; i < 3; i++)
            {
                smallShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Light));
                smallShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Light));
                smallShips.Frigets.Add(ShipFactory.CreateShip(ShipType.Friget, ShipConfigurationType.Balanced));
            }
        }
    }
}
