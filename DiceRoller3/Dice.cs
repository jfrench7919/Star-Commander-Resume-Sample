using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    public class Dice : IDice
    {
        public Dice(int numberOfSides)
        {
            NumberOfSides = numberOfSides;
        }
        public int NumberOfSides { get; set; }
        public List<IDiceSide> Sides { get; set; }

        public bool HasSides
        {
            get
            {
                return Sides.Count > 0;
            }
        }

        public int RoleDiceForeNum()
        {
            int side = rnd.Next(this.NumberOfSides -1);
            return this.Sides[side].Number;
        }

        public bool RoleDiceForSuccess(OddType type)
        {
            switch (type)
            {
                case OddType.TwentyFive:
                    return IsSuccess(4);
                case OddType.Fifty:
                    return IsSuccess(2);
                default:
                    return false;
            }
        }

        private List<int> GetSuccessNumbers(int divisable)
        {
            int odd = this.NumberOfSides / divisable;
            List<int> successNumbers = new List<int>();
            for (int i = 0; successNumbers.Count < odd; i++)
            {
                int sideNumber = Sides[rnd.Next(this.NumberOfSides - 1)].Number;
                if (!successNumbers.Contains(sideNumber))
                {
                    successNumbers.Add(sideNumber);
                }
            }
            return successNumbers;
        }

        private bool IsSuccess(int odd)
        {
            return GetSuccessNumbers(odd).Contains(RoleDiceForeNum());
        }

        private Random rnd = new Random();
    }
}
