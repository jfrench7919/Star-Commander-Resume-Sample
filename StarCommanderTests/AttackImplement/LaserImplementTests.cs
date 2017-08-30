using Xunit;
using StarCommander.Factories;
using StarCommander.Types;
using StarCommander.Fleet;

namespace StarCommander.AttackImplement.Tests
{
    public class LaserImplementTests
    {
        [Fact()]
        public void LaserPowerBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.Equal(2, attackImplement.Power);
        }

        [Fact()]
        public void LaserSizeBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.Equal(1, attackImplement.Size);
        }

        [Fact()]
        public void LaserHealthBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.Equal(100, attackImplement.Health);
        }

        [Fact()]
        public void LaserAmmoBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.Equal(false, attackImplement.Ammo.HasValue);
        }


        [Fact()]
        public void LaserAmmoAvailableTest()
        {
            IAttackImplement i = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.True(i.AmmoAvailable);
        }

        [Fact()]
        public void LaserAmmoNeverUnAvailableTest()
        {
            IAttackImplement ai = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigerationType.BalancedShips, BattleStratagyType.WeekShipsFirst);
            for (int i = 0; i < 600; i++)
            {
                ai.Fire(fleet, BattleStratagyType.StrongShipsFirst);
            }
            Assert.True(ai.AmmoAvailable);
            Assert.False(ai.Ammo.HasValue);
        }

        [Fact()]
        public void LaserShipHealthModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.Equal(0, attackImplement.ShipHealthModification);
        }

        [Fact()]
        public void LaserShipPowerModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.Equal(0, attackImplement.ShipPowerModification);
        }

        [Fact()]
        public void LaserShipArmorModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.Equal(0, attackImplement.ShipArmorModification);
        }

        [Fact()]
        public void LaserShipSpeedModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser);
            Assert.Equal(-1, attackImplement.ShipSpeedModification);
        }
    }
}