using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Implement;

namespace StarCommander.UpgradeImplement
{
    public abstract class UpgradeImplement : IUpgradeImplement
    {
        public int Power { get; set; }
        public int Size { get; set; }
        public int Health { get; set; }

        public virtual void Activate()
        {
            throw new NotImplementedException();
        }
    }
}
