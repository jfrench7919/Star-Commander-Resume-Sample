using Xunit;
using StarCommander.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.BattleField;
using StarCommander.Types;

namespace StarCommander.Factories.Tests
{
    public class BattleFieldFactoryTests
    {
        [Fact()]
        public void CreateSmallBattleFieldFleetSlotTest()
        {
            IBattleField battleField = BattleFieldFactory.CreateBattleField(BattleFieldType.Small);
            Assert.Equal(24000, battleField.NumberOfFleetSlots);
        }

        [Fact()]
        public void CreateSmallBattleFieldFleetSlotAvailableTest()
        {
            IBattleField battleField = BattleFieldFactory.CreateBattleField(BattleFieldType.Small);
            Assert.Equal(24000, battleField.NumberOfFleetSlotsAvailable);
        }

        [Fact()]
        public void CreateMediumBattleFieldFleetSlotTest()
        {
            IBattleField battleField = BattleFieldFactory.CreateBattleField(BattleFieldType.Medium);
            Assert.Equal(48000, battleField.NumberOfFleetSlots);
        }

        [Fact()]
        public void CreateMediumBattleFieldFleetSlotsAvailableTest()
        {
            IBattleField battleField = BattleFieldFactory.CreateBattleField(BattleFieldType.Medium);
            Assert.Equal(48000, battleField.NumberOfFleetSlotsAvailable);
        }

        [Fact()]
        public void CreateLargeBattleFieldFleetSlotTest()
        {
            IBattleField battleField = BattleFieldFactory.CreateBattleField(BattleFieldType.Large);
            Assert.Equal(72000, battleField.NumberOfFleetSlots);
        }

        [Fact()]
        public void CreateLargeBattleFieldFleetSlotsAvailableTest()
        {
            IBattleField battleField = BattleFieldFactory.CreateBattleField(BattleFieldType.Large);
            Assert.Equal(72000, battleField.NumberOfFleetSlotsAvailable);
        }

        [Fact()]
        public void CreateNullBattleFieldTypeTest()
        {
            IBattleField battleField = BattleFieldFactory.CreateBattleField(null);
            Assert.Equal(null, battleField);
        }
    }
}