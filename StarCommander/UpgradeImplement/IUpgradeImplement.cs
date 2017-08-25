using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Implement;

namespace StarCommander.UpgradeImplement
{
    public interface IUpgradeImplement : IImplement
    {
        void Activate();
    }
}
