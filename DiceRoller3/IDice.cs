using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    public interface IDice
    {
        int NumberOfSides { get; set; }
        List<IDiceSide> Sides { get; set; }
        bool HasSides { get; }
        bool RoleDiceForSuccess(OddType type);
        int RoleDiceForeNum();
    }
}
