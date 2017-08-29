using Xunit;
using StarCommander.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Factories;
using StarCommander.Types;
using StarCommander.Fleet;

namespace StarCommander.Ships.Tests
{
    public class StarShipTests
    {
        [Fact()]
        public void TakeDamageTest()
        {
            IStarShip starShip = ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Light);
            var oHealth = starShip.Health;
            int damageAmount = starShip.Armor + 20;
            starShip.TakeDamage(damageAmount);
            Assert.Equal(oHealth - 20, starShip.Health);
            Assert.Equal(0, starShip.Armor);
        }

        [Fact()]
        public void TakeDamagArmorZeroTest()
        {
            IStarShip starShip = ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Light);
            int damageAmount = 300;
            starShip.TakeDamage(damageAmount);
            Assert.Equal(0, starShip.Armor);
        }

        [Fact()]
        public void TakeDamagHealthZeroTest()
        {
            IStarShip starShip = ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Light);
            int damageAmount = 9000;
            starShip.TakeDamage(damageAmount);
            Assert.Equal(0, starShip.Health);
        }

        [Fact()]
        public void FleetTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Light);
            Assert.True(ship.availableAttackImplements.Count > 0);
        }

        [Fact()]
        public void AttackEnemyShipsTest()
        {
            IStarShip myship = ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Light);
            IFleet enemyfleet = FleetFactory.CreateFleet(FleetConfigerationType.BalancedShips, BattleStratagyType.WeekShipsFirst);
            var oTotalHealthAndArmor = enemyfleet.StarShips.Sum(x => x.Health) + enemyfleet.StarShips.Sum(x => x.Armor);
            myship.AttackEnemyShips(enemyfleet, BattleStratagyType.WeekShipsFirst);
            var newTotalHealthAndArmor = enemyfleet.StarShips.Sum(x => x.Health) + enemyfleet.StarShips.Sum(x => x.Armor);
            var shipsDestroyed = enemyfleet.StarShips.Where(x => x.Health == 0).ToList();
            Assert.True(oTotalHealthAndArmor > newTotalHealthAndArmor);
        }
    }
}