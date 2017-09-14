using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Ships;

namespace StarCommander.Configuration
{
    public class FleetConfiguration : IFleetConfiguration
    {
        public FleetConfiguration()
        {
            Fighters = new List<IStarShip>();
            Frigets = new List<IStarShip>();
            Destroyers = new List<IStarShip>();
        }

        public List<IStarShip> Fighters { get; set; }
        public List<IStarShip> Frigets { get; set; }
        public List<IStarShip> Destroyers { get; set; }
    }
}
