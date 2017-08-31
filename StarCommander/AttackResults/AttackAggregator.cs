using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.AttackResults
{
    public class AttackAggregator : IAttacker
    {
        public readonly List<IDefender> Observers = new List<IDefender>();

        public void NotifyObservers(AttackResult result)
        {
            Observers.ForEach(x => x.TakeDamage(result));
        }

        public void RegisterObserver(IDefender battleObserver)
        {
            Observers.Add(battleObserver);
        }

        public void UnregisterObserver(IDefender observer)
        {
            Observers.Remove(observer);
        }
    }
}
