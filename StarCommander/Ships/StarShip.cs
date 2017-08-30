using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.AttackImplement;
using StarCommander.DefendImplement;
using StarCommander.UpgradeImplement;
using StarCommander.Fleet;
using StarCommander.Types;
using StarCommander.AttackResults;

namespace StarCommander.Ships
{
    public abstract class StarShip : IStarShip
    {
        public StarShip()
        {
            Power = 50;
            Size = 50;
            Armor = 50;
            Health = 500;
            AttackImplements = new List<IAttackImplement>();
            DefendImplements = new List<IDefendImplement>();
            UpgradeImplements = new List<IUpgradeImplement>();
        }

        public int Size { get ; set; }
        public int Speed { get; set; }
        public int Armor { get; set; }
        public int Power { get; set; }
        public int Health { get; set; }
        public int NumberOfAttackSlots { get; set; }
        public int NumberOfDefendSlots { get; set; }
        public int NumberOfUpgradeSlots { get; set; }
        public List<IAttackImplement> AttackImplements { get; set; }
        public List<IDefendImplement> DefendImplements { get; set; }
        public List<IUpgradeImplement> UpgradeImplements { get; set; }

        public int NumberOfAttackSlotsAvailable
        {
            get
            {
                return NumberOfAttackSlots - AttackImplements.Sum(x => x.Size);
            }
        }

        public int NumberOfDefendSlotsAvailable
        {
            get
            {
                return NumberOfDefendSlots - DefendImplements.Sum(x => x.Size);
            }
        }

        public int NumberOfUpgradeSlotsAvailable
        {
            get
            {
                return NumberOfUpgradeSlots - UpgradeImplements.Sum(x => x.Size);
            }
        }

        public void TakeDamage(AttackResult result)
        {
            result.Damage = DamageArmor(result.Damage);
            DamageHealth(result.Damage);
            CheckHealth();
        }

        public List<IAttackImplement> availableAttackImplements
        {
            get
            {
                List<IAttackImplement> myImplements = new List<IAttackImplement>();
                foreach (IAttackImplement implement in AttackImplements)
                {
                    myImplements.Add(implement);
                }

                return myImplements;
            }
        }

        public void Attack(IFleet enemyFleet, BattleStratagyType battleStratagyType)
        {
            foreach (IAttackImplement i in availableAttackImplements)
            {
                i.Fire(enemyFleet, battleStratagyType);
            }
        }

        private void DamageHealth(int damageAmount)
        {
            if (Health > 0 && damageAmount > 0)
            {
                if (Health > damageAmount)
                {
                    Health = Health - damageAmount;
                }
                else
                {
                    Health = 0;
                }
            }
        }

        private int DamageArmor(int damageAmount)
        {
            if (Armor > 0)
            {
                if (Armor > damageAmount)
                {
                    Armor = Armor - damageAmount;
                    damageAmount = 0;
                }
                else
                {
                    damageAmount = damageAmount - Armor;
                    Armor = 0;
                }
            }

            return damageAmount;
        }

        private void CheckHealth()
        {
            if (Health == 0)
            {
                ReportDistruction();
            }
        }

        public void ReportDistruction()
        {
            //todo: add pub sub
        }

        public void Advance()
        {
            throw new NotImplementedException();
        }

        public void Retreat()
        {
            throw new NotImplementedException();
        }
        
        public void Deffend()
        {
            throw new NotImplementedException();
        }
    }
}
