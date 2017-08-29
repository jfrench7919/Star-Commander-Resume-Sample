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
    public abstract class AttackImplement : IAttackImplement
    {
        public int Power { get; set; }
        public Nullable<int> Ammo { get; set; }
        public int Size { get; set; }
        public int Health { get; set; }
        public int ShipSpeedModification { get; set; }
        public int ShipPowerModification { get; set; }
        public int ShipHealthModification { get; set; }
        public int ShipArmorModification { get; set; }

        public void Fire(IStarShip shipToAttcack)
        {
            Ammo = Ammo - 1;
            var damage = CalculateDamage();
        }

        private int CalculateDamage()
        {
            Random r = new Random();
            return Power * r.Next(2, 4);
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

        public void AttackEnemyShips(IFleet enemyFleet, BattleStratagyType battleStratagyType)
        {
            IStarShip ship =  GetTargetShip(battleStratagyType, enemyFleet);
            if(ship != null)
            {
                ship.TakeDamage(CalculateDamage());
            }
        }

        public IStarShip GetTargetShip(BattleStratagyType battleStratagyType, IFleet enemyFleet)
        {
            switch (battleStratagyType)
            {
                case BattleStratagyType.WeekShipsFirst:
                    return enemyFleet.StarShips.Where(x => x.Health != 0).OrderBy(x => x.Power).OrderBy(x => x.Health).OrderBy(x => x.Armor).FirstOrDefault();
                case BattleStratagyType.StrongShipsFirst:
                    return enemyFleet.StarShips.Where(x => x.Health != 0).OrderByDescending(x => x.Power).OrderByDescending(x => x.Health).OrderByDescending(x => x.Armor).FirstOrDefault();
                case BattleStratagyType.NoPriority:
                    return enemyFleet.StarShips.Where(x => x.Health != 0).OrderByDescending(x => x.Health).FirstOrDefault();
                default:
                    return enemyFleet.StarShips.Where(x => x.Health != 0).OrderByDescending(x => x.Health).FirstOrDefault();
            }
        }
    }
}
