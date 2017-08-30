using Xunit;
using StarCommander.AttackImplement;
using StarCommander.Factories;
using StarCommander.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Fleet;
using StarCommander.Ships;


namespace StarCommander.AttackImplement.Tests
{
    public class AttackImplementTests
    {
        [Fact()]
        public void GetWeekTargetShipTest()
        {
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigerationType.SmallShips, BattleStratagyType.WeekShipsFirst);
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            var ship = attackImplement.GetTargetShip(BattleStratagyType.WeekShipsFirst, fleet);
            Assert.IsType<Fighter>(ship);
        }

        [Fact()]
        public void GetStrongTargetShipTest()
        {
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigerationType.HeavyShips, BattleStratagyType.StrongShipsFirst);
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            var ship = attackImplement.GetTargetShip(BattleStratagyType.StrongShipsFirst, fleet);
            Assert.IsType<Destroyer>(ship);
        }

        [Fact()]
        public void GetNoPriorityTargetShipTest()
        {
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigerationType.HeavyShips, BattleStratagyType.NoPriority);
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            var ship = attackImplement.GetTargetShip(BattleStratagyType.NoPriority, fleet);
            Assert.IsType<Destroyer>(ship);
        }

        [Fact()]
        public void GetTargetShipTest()
        {
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigerationType.HeavyShips, BattleStratagyType.NoPriority);
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            var ship = attackImplement.GetTargetShip(BattleStratagyType.NoPriority, fleet);
            Assert.IsType<Destroyer>(ship);
        }

        [Fact()]
        public void FireTest()
        {
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigerationType.HeavyShips, BattleStratagyType.NoPriority);
            var oTotalHealthAndArmor = fleet.StarShips.Sum(x => x.Health) + fleet.StarShips.Sum(x => x.Armor);
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);

            attackImplement.Fire(fleet, BattleStratagyType.WeekShipsFirst);
            var newTotalHealthAndArmor = fleet.StarShips.Sum(x => x.Health) + fleet.StarShips.Sum(x => x.Armor);
            Assert.True(oTotalHealthAndArmor > newTotalHealthAndArmor);
        }
    }
}