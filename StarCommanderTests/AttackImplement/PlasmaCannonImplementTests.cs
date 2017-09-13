using Xunit;
using StarCommander.Factories;
using StarCommander.Types;
using StarCommander.Fleets;

namespace StarCommander.AttackImplement.Tests
{
    public class PlasmaCannonImplementTests
    {
        [Fact()]
        public void PlasmaCannonPowerBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.Equal(2, attackImplement.Power);
        }

        [Fact()]
        public void PlasmaCannonShipArmorModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.Equal(0, attackImplement.ShipArmorModification);
        }

        [Fact()]
        public void PlasmaCannonSizeBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.Equal(8, attackImplement.Size);
        }

        [Fact()]
        public void PlasmaCannonHealthBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.Equal(100, attackImplement.Health);
        }

        [Fact()]
        public void PlasmaCannonAmmoBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.Equal(100, attackImplement.Ammo);
        }

        [Fact()]
        public void PlasmaCannonAmmoAvailableTest()
        {
            IAttackImplement i = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.True(i.AmmoAvailable);
        }

        [Fact()]
        public void PlasmaCannonAmmoUnAvailableTest()
        {
            IAttackImplement ai = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            IFleet fleet = FleetFactory.CreateFleet(FleetConfigerationType.BalancedShips, BattleStratagyType.WeekShipsFirst);
            var shots = ai.Ammo;
            for (int i = 0; i < shots; i++)
            {
                ai.Fire(fleet, BattleStratagyType.StrongShipsFirst);
            }
            Assert.False(ai.AmmoAvailable);
        }

        [Fact()]
        public void PlasmaCannonShipHealthModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.Equal(0, attackImplement.ShipHealthModification);
        }

        [Fact()]
        public void PlasmaCannonShipPowerModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.Equal(0, attackImplement.ShipPowerModification);
        }

        [Fact()]
        public void PlasmaCannonShipSpeedModificationBaseValueTest()
        {
            IAttackImplement attackImplement = AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon);
            Assert.Equal(-4, attackImplement.ShipSpeedModification);
        }
    }
}