using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Implement;
using StarCommander.Ships;

namespace StarCommander.AttackImplement
{
    public abstract class AttackImplement : IAttackImplement
    {
        public AttackImplement()
        {
            EnemyShips = new List<IStarShip>();
        }
        public int Power { get; set; }
        public Nullable<int> Ammo { get; set; }
        public int Size { get; set; }
        public int Health { get; set; }
        public int ShipSpeedModification { get; set; }
        public int ShipPowerModification { get; set; }
        public int ShipHealthModification { get; set; }
        public int ShipArmorModification { get; set; }
        public List<IStarShip> EnemyShips { get; set; }

        public virtual void Fire()
        {
            Ammo = Ammo - 1;
        }

        public bool AmmoAvailable
        {
            get
            {
                if (Ammo.HasValue)
                {
                    return Ammo > 0 ? true : false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
