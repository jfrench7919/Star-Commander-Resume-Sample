using Xunit;
using DiceRoller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Tests
{
    public class DiceTests
    {
        [Fact()]
        public void RoleDiceForeNumTest()
        {
            IDice dice = DiceFactory.CreateDice(4);
            int num = dice.RoleDiceForeNum();
            Assert.NotEqual(0, num);
        }

        [Fact()]
        public void RoleDiceForSuccessTwentyFiveTest()
        {
            IDice dice = DiceFactory.CreateDice(4);
            bool wasFial = false;
            bool wasSuccess = false;
            for (int i = 0; i < 100; i++)
            {
                if(dice.RoleDiceForSuccess(OddType.TwentyFive))
                {
                    wasSuccess = true;
                }
                else
                {
                    wasFial = true;
                }
            }
            Assert.True(wasSuccess && wasFial);
        }

        [Fact()]
        public void RoleDiceForSuccessFiftyTest()
        {
            IDice dice = DiceFactory.CreateDice(4);
            bool wasFial = false;
            bool wasSuccess = false;
            for (int i = 0; i < 100; i++)
            {
                if (dice.RoleDiceForSuccess(OddType.Fifty))
                {
                    wasSuccess = true;
                }
                else
                {
                    wasFial = true;
                }
            }
            Assert.True(wasSuccess && wasFial);
        }
    }
}