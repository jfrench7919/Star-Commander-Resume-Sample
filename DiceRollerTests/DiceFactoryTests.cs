using Xunit;
using DiceRoller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Tests
{
    public class DiceFactoryTests
    {
        [Fact()]
        public void CreateDiceTest()
        {
            int num = 4;
            IDice dice = DiceFactory.CreateDice(num);
            Assert.True(dice.HasSides);
            Assert.Equal(num, dice.Sides.Count());
            Assert.Equal(num, dice.NumberOfSides);
        }
    }
}