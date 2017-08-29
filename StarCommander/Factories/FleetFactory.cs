using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Fleet;
using StarCommander.Types;
using StarCommander.Configeration;

namespace StarCommander.Factories
{
    public class FleetFactory
    {
        public static IFleet CreateFleet(Nullable<FleetConfigerationType> fleetConfigerationType, BattleStratagyType battleStratagyType)
        {
            switch (fleetConfigerationType)
            {
                case FleetConfigerationType.SmallShips:
                    IFleet smallShips = new Fleet.Fleet();
                    SetSmallShipsDefaultValues(smallShips, battleStratagyType);
                    BuildSmallShipsCollection(smallShips, fleetConfigerationType);
                    return smallShips;
                case FleetConfigerationType.BalancedShips:
                    IFleet balancedShips = new Fleet.Fleet();
                    SetBalancedShipsDefaultValues(balancedShips, battleStratagyType);
                    BuildBalancedShipsCollection(balancedShips, fleetConfigerationType);
                    return balancedShips;
                case FleetConfigerationType.HeavyShips:
                    IFleet heavyShips = new Fleet.Fleet();
                    SetHeavyShipsDefaultValues(heavyShips, battleStratagyType);
                    BuildHeavyShipsCollection(heavyShips, fleetConfigerationType);
                    return heavyShips;
                default:
                    return null;
            }
        }

        private static void BuildHeavyShipsCollection(IFleet heavyShips, FleetConfigerationType? fleetConfigerationType)
        {
            IFleetConfigeration fleetConfigeration = FleetConfigerationFactory.CreateFleetConfiguration(FleetConfigerationType.HeavyShips);
            AddShips(heavyShips, fleetConfigeration);
        }

        private static void BuildBalancedShipsCollection(IFleet balancedShips, FleetConfigerationType? fleetConfigerationType)
        {
            IFleetConfigeration fleetConfigeration = FleetConfigerationFactory.CreateFleetConfiguration(FleetConfigerationType.BalancedShips);
            AddShips(balancedShips, fleetConfigeration);
        }

        private static void BuildSmallShipsCollection(IFleet smallShips, FleetConfigerationType? fleetConfigerationType)
        {
            IFleetConfigeration fleetConfigeration = FleetConfigerationFactory.CreateFleetConfiguration(FleetConfigerationType.SmallShips);
            AddShips(smallShips, fleetConfigeration);
        }

        private static void SetHeavyShipsDefaultValues(IFleet heavyShips, BattleStratagyType battleStratagyType)
        {
            SetStratagyType(heavyShips, battleStratagyType);
        }

        private static void SetBalancedShipsDefaultValues(IFleet balancedShips, BattleStratagyType battleStratagyType)
        {
            SetStratagyType(balancedShips, battleStratagyType);
        }

        private static void SetSmallShipsDefaultValues(IFleet smallShips, BattleStratagyType battleStratagyType)
        {
            SetStratagyType(smallShips, battleStratagyType);
        }

        private static void SetStratagyType(IFleet fleet, BattleStratagyType battleStratagyType)
        {
            fleet.BattleStratagyType = battleStratagyType;
        }

        private static void AddShips(IFleet ships, IFleetConfigeration fleetConfigeration)
        {
            foreach (var ship in fleetConfigeration.Destroyers)
            {
                if (ships.NumberOfShipSlotsAvailable > ship.Size)
                {
                    ships.StarShips.Add(ship);
                }
            }

            foreach (var ship in fleetConfigeration.Frigets)
            {
                if (ships.NumberOfShipSlotsAvailable > ship.Size)
                {
                    ships.StarShips.Add(ship);
                }
            }

            foreach (var ship in fleetConfigeration.Fighters)
            {
                if (ships.NumberOfShipSlotsAvailable > ship.Size)
                {
                    ships.StarShips.Add(ship);
                }
            }
        }
    }
}
