using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Ships;

namespace StarCommander.Configeration
{
    public interface IFleetConfigeration
    {
        List<IStarShip> Fighters { get; set; }
        List<IStarShip> Frigets { get; set; }
        List<IStarShip> Destroyers { get; set; }
    }
}
