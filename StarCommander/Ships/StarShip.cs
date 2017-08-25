﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.AttackImplement;
using StarCommander.DefendImplement;
using StarCommander.UpgradeImplement;

namespace StarCommander.Ships
{
    public abstract class StarShip : IStarShip
    {
        public StarShip()
        {
            Power = 50;
            Size = 50;
            Armor = 50;
            Health = 100;
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
        public List<IAttackImplement> AttackImplements { get; set; }
        public List<IDefendImplement> DefendImplements { get; set; }
        public List<IUpgradeImplement> UpgradeImplements { get; set; }

        public void Advance()
        {
            throw new NotImplementedException();
        }

        public void Retreat()
        {
            throw new NotImplementedException();
        }
        
        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Deffend()
        {
            throw new NotImplementedException();
        }

        public void ReceiveDamage()
        {

        }
    }
}
