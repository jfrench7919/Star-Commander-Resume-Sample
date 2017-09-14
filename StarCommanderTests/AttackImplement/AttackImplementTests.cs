using Xunit;
using StarCommander.AttackImplement;
using StarCommander.Factories;
using StarCommander.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Fleets;
using StarCommander.Ships;


namespace StarCommander.AttackImplement.Tests
{
    public class AttackImplementTests
    {
        [Fact()]
        public void GetWeekTargetShipTest()
        {
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigurationType.SmallShips, BattleStratageyType.WeekShipsFirst);
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            var ship = attackImplement.GetTargetShip(BattleStratageyType.WeekShipsFirst, fleet);
            Assert.NotNull(ship);
        }

        [Fact()]
        public void GetStrongTargetShipTest()
        {
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigurationType.HeavyShips, BattleStratageyType.StrongShipsFirst);
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            var ship = attackImplement.GetTargetShip(BattleStratageyType.StrongShipsFirst, fleet);
            Assert.NotNull(ship);
        }

        [Fact()]
        public void GetNoPriorityTargetShipTest()
        {
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigurationType.HeavyShips, BattleStratageyType.NoPriority);
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            var ship = attackImplement.GetTargetShip(BattleStratageyType.NoPriority, fleet);
            Assert.NotNull(ship);
        }

        [Fact()]
        public void GetTargetShipTest()
        {
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigurationType.HeavyShips, BattleStratageyType.NoPriority);
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            var ship = attackImplement.GetTargetShip(null, fleet);
            Assert.NotNull(ship);
        }

        [Fact()]
        public void FireTest()
        {
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigurationType.HeavyShips, BattleStratageyType.NoPriority);
            var oTotalHealthAndArmor = fleet.StarShips.Sum(x => x.Health) + fleet.StarShips.Sum(x => x.Armor);
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);

            //Has A random miss rate
            for (int i = 0; i < 1000; i++)
            {
                attackImplement.Fire(fleet, BattleStratageyType.WeekShipsFirst);
            }

            var newTotalHealthAndArmor = fleet.StarShips.Sum(x => x.Health) + fleet.StarShips.Sum(x => x.Armor);
            Assert.True(oTotalHealthAndArmor > newTotalHealthAndArmor);
        }

        [Fact()]
        public void CalculateDamageTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            int maxvalue = attackImplement.Power * 4;
            Assert.True(attackImplement.CalculateDamage() <= maxvalue);
        }
    }
}