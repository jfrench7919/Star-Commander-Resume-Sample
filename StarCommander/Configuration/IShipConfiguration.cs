using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.AttackImplement;
using StarCommander.DefendImplement;
using StarCommander.UpgradeImplement;


namespace StarCommander.Configuration
{
    public interface IShipConfiguration
    {
        List<IAttackImplement> attackImplements { get; set; }
        List<IDefendImplement> defendImplements { get; set; }
        List<IUpgradeImplement> upgradeImplements { get; set; }
    }
}
