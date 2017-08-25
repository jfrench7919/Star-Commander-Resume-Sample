using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Implement;

namespace StarCommander.DefendImplement
{
    public abstract class DefendImplement : IDefendImplement
    {
        public int Power { get; set; }
        public int Size { get; set; }
        public int Health { get; set; }
        public int ShipSpeedModification { get; set; }
        public int ShipPowerModification { get; set; }
        public int ShipHealthModification { get; set; }
        public int ShipArmorModification { get; set; }

        public void Activate()
        {
            throw new NotImplementedException();
        }
    }
}
