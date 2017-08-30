using System;
using System.Linq;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.Fleet;
using StarCommander.AttackResults;

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

        

        public virtual int CalculateDamage()
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

        public void Fire(IFleet enemyFleet, BattleStratagyType battleStratagyType)
        {
            if (AmmoAvailable)
            {
                if (Ammo.HasValue)
                {
                    Ammo = Ammo - 1;
                }
                
                IStarShip ship = GetTargetShip(battleStratagyType, enemyFleet);
                if (ship != null)
                {
                    AttackResult result = new AttackResult { Damage = CalculateDamage() };
                    AttackAggregator battleAttackAggregator = new AttackAggregator();
                    battleAttackAggregator.RegisterObserver(ship);
                    battleAttackAggregator.NotifyObservers(result);
                    battleAttackAggregator.UnregisterObserver(ship);
                }
            }
        }

        public IStarShip GetTargetShip(BattleStratagyType battleStratagyType, IFleet enemyFleet)
        {
            switch (battleStratagyType)
            {
                case BattleStratagyType.WeekShipsFirst:
                    return enemyFleet.WorkingStarShips.OrderBy(x => x.Power).OrderBy(x => x.Health).OrderBy(x => x.Armor).FirstOrDefault();
                case BattleStratagyType.StrongShipsFirst:
                    return enemyFleet.WorkingStarShips.OrderByDescending(x => x.Power).OrderByDescending(x => x.Health).OrderByDescending(x => x.Armor).FirstOrDefault();
                case BattleStratagyType.NoPriority:
                    return enemyFleet.WorkingStarShips.OrderByDescending(x => x.Health).FirstOrDefault();
                default:
                    return enemyFleet.WorkingStarShips.OrderByDescending(x => x.Health).FirstOrDefault();
            }
        }
    }
}
