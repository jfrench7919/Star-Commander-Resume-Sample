using System;
using System.Linq;
using StarCommander.Ships;
using StarCommander.Types;
using StarCommander.Fleets;
using StarCommander.AttackResults;
using System.Collections.Generic;

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

        private Random rnd { get; set; } = new Random();

        public abstract int CalculateDamage();

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

        public void Fire(IFleet enemyFleet, BattleStratageyType battleStratageyType)
        {
            if (AmmoAvailable)
            {
                if (Ammo.HasValue)
                {
                    Ammo = Ammo - 1;
                }
                
                IStarShip ship = GetTargetShip(battleStratageyType, enemyFleet);
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

        public IStarShip GetTargetShip(BattleStratageyType? battleStratageyType, IFleet enemyFleet)
        {
            switch (battleStratageyType)
            {
                case BattleStratageyType.WeekShipsFirst:
                    var first25Week = enemyFleet.WorkingStarShips.OrderBy(x => x.Power).OrderBy(x => x.Health).OrderBy(x => x.Armor).Take(25).ToList();
                    return FindShip(first25Week);
                case BattleStratageyType.StrongShipsFirst:
                    var first25Strong = enemyFleet.WorkingStarShips.OrderByDescending(x => x.Power).OrderByDescending(x => x.Health).OrderByDescending(x => x.Armor).Take(25).ToList();
                    return FindShip(first25Strong);
                case BattleStratageyType.NoPriority:
                    var first25Health = enemyFleet.WorkingStarShips.OrderByDescending(x => x.Health).Take(25).ToList();
                    return FindShip(first25Health);
                default:
                    var first25Null = enemyFleet.WorkingStarShips.OrderByDescending(x => x.Health).Take(25).ToList();
                    return FindShip(first25Null);
            }
        }

        private IStarShip FindShip(List<IStarShip> enemyShips)
        {
            int index = 0;

            if (enemyShips.Count > 0)
            {
                index = rnd.Next(1, enemyShips.Count());
                return enemyShips[index - 1];
            }
            return null;
        }
    }
}
