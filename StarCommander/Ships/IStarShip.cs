using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.AttackImplement;
using StarCommander.DefendImplement;
using StarCommander.UpgradeImplement;

namespace StarCommander.Ships
{
    public interface IStarShip
    {
        int Size { get; set; }
        int Speed { get; }
        int Armor { get; set; }
        int Power { get; set; }
        int Health { get; set; }
        int NumberOfAttackSlots { get; set; }
        List<IAttackImplement> AttackImplements { get; set; }
        int NumberOfDefendSlots { get; set; }
        List<IDefendImplement> DefendImplements { get; set; }
        int NumberOfUpgradeSlots { get; set; }
        List<IUpgradeImplement> UpgradeImplements { get; set; }


        void Advance();
        void Retreat();
        void Attack();
        void Deffend();
    }
}
