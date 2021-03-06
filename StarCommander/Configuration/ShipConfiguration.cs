﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.AttackImplement;
using StarCommander.DefendImplement;
using StarCommander.UpgradeImplement;

namespace StarCommander.Configuration
{
    public class ShipConfiguration : IShipConfiguration
    {
        public ShipConfiguration()
        {
            attackImplements = new List<IAttackImplement>();
            defendImplements = new List<IDefendImplement>();
            upgradeImplements = new List<IUpgradeImplement>();
        }
        public List<IAttackImplement> attackImplements { get; set; }
        public List<IDefendImplement> defendImplements { get; set; }
        public List<IUpgradeImplement> upgradeImplements { get; set; }
    }
}
