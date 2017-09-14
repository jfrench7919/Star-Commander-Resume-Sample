using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Fleets;
using StarCommander.Types;
using StarCommander.Configuration;

namespace StarCommander.Factories
{
    public class FleetFactory
    {
        public static IFleet CreateFleet(Nullable<FleetConfigurationType> fleetConfigurationType, BattleStratageyType battleStratageyType)
        {
            switch (fleetConfigurationType)
            {
                case FleetConfigurationType.SmallShips:
                    IFleet smallShips = new Fleet();
                    SetSmallShipsDefaultValues(smallShips, battleStratageyType);
                    BuildSmallShipsCollection(smallShips, fleetConfigurationType);
                    smallShips.Name = NameGenerator();
                    return smallShips;
                case FleetConfigurationType.BalancedShips:
                    IFleet balancedShips = new Fleet();
                    SetBalancedShipsDefaultValues(balancedShips, battleStratageyType);
                    BuildBalancedShipsCollection(balancedShips, fleetConfigurationType);
                    balancedShips.Name = NameGenerator();
                    return balancedShips;
                case FleetConfigurationType.HeavyShips:
                    IFleet heavyShips = new Fleet();
                    SetHeavyShipsDefaultValues(heavyShips, battleStratageyType);
                    BuildHeavyShipsCollection(heavyShips, fleetConfigurationType);
                    heavyShips.Name = NameGenerator();
                    return heavyShips;
                default:
                    return null;
            }
        }

        private static void BuildHeavyShipsCollection(IFleet heavyShips, FleetConfigurationType? fleetConfigurationType)
        {
            IFleetConfiguration fleetConfiguration = FleetConfigurationFactory.CreateFleetConfiguration(FleetConfigurationType.HeavyShips);
            if (fleetConfigurationType.HasValue)
            {
                heavyShips.myFleetConfigurationType = fleetConfigurationType.Value;
            }
            AddShips(heavyShips, fleetConfiguration);
        }

        private static void BuildBalancedShipsCollection(IFleet balancedShips, FleetConfigurationType? fleetConfigurationType)
        {
            IFleetConfiguration fleetConfiguration = FleetConfigurationFactory.CreateFleetConfiguration(FleetConfigurationType.BalancedShips);
            if (fleetConfigurationType.HasValue)
            {
                balancedShips.myFleetConfigurationType = fleetConfigurationType.Value;
            }
            AddShips(balancedShips, fleetConfiguration);
        }

        private static void BuildSmallShipsCollection(IFleet smallShips, FleetConfigurationType? fleetConfigurationType)
        {
            IFleetConfiguration fleetConfiguration = FleetConfigurationFactory.CreateFleetConfiguration(FleetConfigurationType.SmallShips);
            if (fleetConfigurationType.HasValue)
            {
                smallShips.myFleetConfigurationType = fleetConfigurationType.Value;
            }
            AddShips(smallShips, fleetConfiguration);
        }

        private static void SetHeavyShipsDefaultValues(IFleet heavyShips, BattleStratageyType battleStratageyType)
        {
            SetStratageyType(heavyShips, battleStratageyType);
        }

        private static void SetBalancedShipsDefaultValues(IFleet balancedShips, BattleStratageyType battleStratageyType)
        {
            SetStratageyType(balancedShips, battleStratageyType);
        }

        private static void SetSmallShipsDefaultValues(IFleet smallShips, BattleStratageyType battleStratageyType)
        {
            SetStratageyType(smallShips, battleStratageyType);
        }

        private static void SetStratageyType(IFleet fleet, BattleStratageyType battleStratageyType)
        {
            fleet.myBattleStratageyType = battleStratageyType;
        }

        private static void AddShips(IFleet ships, IFleetConfiguration fleetConfiguration)
        {
            foreach (var ship in fleetConfiguration.Destroyers)
            {
                if (ships.NumberOfShipSlotsAvailable > ship.Size)
                {
                    ships.StarShips.Add(ship);
                }
            }

            foreach (var ship in fleetConfiguration.Frigets)
            {
                if (ships.NumberOfShipSlotsAvailable > ship.Size)
                {
                    ships.StarShips.Add(ship);
                }
            }

            foreach (var ship in fleetConfiguration.Fighters)
            {
                if (ships.NumberOfShipSlotsAvailable > ship.Size)
                {
                    ships.StarShips.Add(ship);
                }
            }
        }

        private static string NameGenerator()
        {
            int maxIndex = FleetNames.names.Count() -1;
            int returnedRandom = rnd.Next(1, maxIndex);
            return FleetNames.names[returnedRandom];
        }

        private static Random rnd = new Random();
    }
}
