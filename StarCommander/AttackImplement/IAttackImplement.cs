using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Implement;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.Fleet;

namespace StarCommander.AttackImplement
{
    public interface IAttackImplement : IImplement
    {
        Nullable<int> Ammo { get; set; }
        void Fire(IStarShip shipToAttcack);

        bool AmmoAvailable { get; }
        
        void AttackEnemyShips(IFleet enemyFleet, BattleStratagyType battleStratagyType);
        IStarShip GetTargetShip(BattleStratagyType battleStratagyType, IFleet enemyFleet);
    }
}
