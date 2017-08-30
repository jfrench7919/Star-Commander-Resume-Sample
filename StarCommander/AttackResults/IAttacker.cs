using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.AttackResults
{
    public interface IAttacker
    {
        void RegisterObserver(IDefender defenderObserver);
        void UnregisterObserver(IDefender defenderObserver);
        void NotifyObservers(AttackResult result);
    }
}
