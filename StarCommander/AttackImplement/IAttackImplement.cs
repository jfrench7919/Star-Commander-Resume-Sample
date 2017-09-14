using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Implement;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.Fleets;
using StarCommander.AttackResults;

namespace StarCommander.AttackImplement
{
    public interface IAttackImplement : IImplement
    {
        Nullable<int> Ammo { get; set; }
        bool AmmoAvailable { get; }

        void Fire(IFleet enemyFleet, BattleStratageyType battleStratageyType);
        IStarShip GetTargetShip(BattleStratageyType? battleStratageyType, IFleet enemyFleet);
        int CalculateDamage();
    }
}
