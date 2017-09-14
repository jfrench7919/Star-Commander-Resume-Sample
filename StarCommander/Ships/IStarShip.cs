using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.AttackImplement;
using StarCommander.DefendImplement;
using StarCommander.UpgradeImplement;
using StarCommander.Fleets;
using StarCommander.Types;
using StarCommander.AttackResults;

namespace StarCommander.Ships
{
    public interface IStarShip : IDefender
    {
        string Name { get; set; }
        ShipType myShipType { get; set; }
        int Size { get; set; }
        int Speed { get; set; }
        int Armor { get; set; }
        int Power { get; set; }
        int Health { get; set; }
        int NumberOfAttackSlots { get; set; }
        List<IAttackImplement> AttackImplements { get; set; }
        int NumberOfAttackSlotsAvailable { get; }
        int NumberOfDefendSlots { get; set; }
        List<IDefendImplement> DefendImplements { get; set; }
        int NumberOfDefendSlotsAvailable { get; }
        int NumberOfUpgradeSlots { get; set; }
        List<IUpgradeImplement> UpgradeImplements { get; set; }
        int NumberOfUpgradeSlotsAvailable { get; }
        List<IAttackImplement> availableAttackImplements { get; }
        bool HasFiredThisLoop { get; set; }
        void Attack(IFleet enemyFleet, BattleStratageyType battleStratageyType);
        void Advance();
        void Retreat();
        void Deffend();
        //void TakeDamage(AttackResult result);
        void ReportDistruction();
        
    }
}
