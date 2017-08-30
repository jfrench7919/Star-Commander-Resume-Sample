using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.BattleResult
{
    public sealed class BattleResults
    {
        private static BattleResults instance = null;
        private static readonly object padlock = new object();

        BattleResults()
        {
        }

        public static BattleResults Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new BattleResults();
                    }
                    return instance;
                }
            }
        }

        public static List<string> Messages { get; set; } = new List<string>();
    }
}
