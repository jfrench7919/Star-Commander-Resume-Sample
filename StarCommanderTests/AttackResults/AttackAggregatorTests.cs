using Xunit;
using StarCommander.AttackResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Factories;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.AttackImplement;

namespace StarCommander.AttackResults.Tests
{
    [Collection("Observer")]
    public class AttackAggregatorTests
    {
        [Fact()]
        public void RegisterObserverTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Balanced);
            var attackAggregator = new AttackAggregator();
            attackAggregator.RegisterObserver(ship);
            Assert.Equal(1, attackAggregator.Observers.Count());
            attackAggregator.UnregisterObserver(ship);
        }

        [Fact()]
        public void UnregisterObserverTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Balanced);
            AttackAggregator attackAggregator = new AttackAggregator();
            attackAggregator.RegisterObserver(ship);
            attackAggregator.UnregisterObserver(ship);
            Assert.Equal(0, attackAggregator.Observers.Count());
        }

        [Fact()]
        public void NotifyObserversTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Balanced);
            int oHandA = ship.Health + ship.Armor;
            var attackAggregator = new AttackAggregator();
            attackAggregator.RegisterObserver(ship);
            attackAggregator.NotifyObservers(new AttackResult { Damage = 10 });
            Assert.Equal(ship.Health + ship.Armor + 10, oHandA);
            attackAggregator.UnregisterObserver(ship);
        }
    }
}