using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Implement;
using StarCommander.Ships;

namespace StarCommander.AttackImplement
{
    public interface IAttackImplement : IImplement
    {
        Nullable<int> Ammo { get; set; }
        void Fire();

        bool AmmoAvailable { get; }

        List<IStarShip> EnemyShips { get; set; }
    }
}
