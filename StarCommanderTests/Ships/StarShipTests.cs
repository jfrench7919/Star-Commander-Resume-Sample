using Xunit;
using StarCommander.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Factories;
using StarCommander.Types;
using StarCommander.Fleets;
using StarCommander.AttackResults;

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
            AttackResult attackResult = new AttackResult { Damage = damageAmount };
            starShip.TakeDamage(attackResult);
            Assert.Equal(oHealth - 20, starShip.Health);
            Assert.Equal(0, starShip.Armor);
        }

        [Fact()]
        public void TakeDamagArmorZeroTest()
        {
            IStarShip starShip = ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Light);
            int damageAmount = 300;
            AttackResult attackResult = new AttackResult { Damage = damageAmount };
            starShip.TakeDamage(attackResult);
            Assert.Equal(0, starShip.Armor);
        }

        [Fact()]
        public void TakeDamagHealthZeroTest()
        {
            IStarShip starShip = ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Light);
            int damageAmount = 9000;
            AttackResult attackResult = new AttackResult { Damage = damageAmount };
            starShip.TakeDamage(attackResult);
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
            IFleet enemyfleet = FleetFactory.CreateFleet(FleetConfigurationType.BalancedShips, BattleStratageyType.WeekShipsFirst);
            var oTotalHealthAndArmor = enemyfleet.StarShips.Sum(x => x.Health) + enemyfleet.StarShips.Sum(x => x.Armor);

            //has random miss rate
            for (int i = 0; i < 100; i++)
            {
                myship.Attack(enemyfleet, BattleStratageyType.WeekShipsFirst);
            }

            var newTotalHealthAndArmor = enemyfleet.StarShips.Sum(x => x.Health) + enemyfleet.StarShips.Sum(x => x.Armor);
            var shipsDestroyed = enemyfleet.StarShips.Where(x => x.Health == 0).ToList();
            Assert.True(oTotalHealthAndArmor > newTotalHealthAndArmor);
        }

        [Fact()]
        public void StarShipTest()
        {
            IStarShip ship = ShipFactory.CreateShip(ShipType.Fighter, ShipConfigurationType.Heavy);
            Assert.True(ship.availableAttackImplements.Count > 0);
            Assert.True(ship.AttackImplements.Count > 0);
            Assert.True(ship.DefendImplements.Count > 0);
            Assert.True(ship.UpgradeImplements.Count > 0);
            Assert.True(ship.NumberOfAttackSlotsAvailable ==  ship.NumberOfAttackSlots - ship.AttackImplements.Sum(x => x.Size));
            Assert.True(ship.NumberOfDefendSlotsAvailable == ship.NumberOfDefendSlots - ship.DefendImplements.Sum(x => x.Size));
            Assert.True(ship.NumberOfUpgradeSlotsAvailable == ship.NumberOfUpgradeSlots - ship.UpgradeImplements.Sum(x => x.Size));
        }
    }
}