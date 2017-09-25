using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    public class DiceFactory
    {
        public static IDice CreateDice(int numberOfSides)
        {
            IDice dice = new Dice(numberOfSides);
            dice.Sides = new List<IDiceSide>();
            for (int i = 0; i < dice.NumberOfSides; i++)
            {
                dice.Sides.Add(new DiceSide { Number = i + 1});
            }

            return dice;
        }
    }
}
