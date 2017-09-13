using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCommander.Fleets
{
    public class FleetNames
    {
        public static Dictionary<int, string> names
        {
            get
            {
                var n = new List<string>();
                n.Add("Lem H Wightman");
                n.Add("Stacy V Adell");
                n.Add("Flavius U Ostrander");
                n.Add("Boyd P Crawley");
                n.Add("Fitzhugh Angelo Bunn");
                n.Add("Court Dexter Carman");
                n.Add("Dain Tynes Ebener");
                n.Add("Carlton Hence Landerback");
                n.Add("Manson G Fullerton");
                n.Add("Laurance Boothe");
                n.Add("Nicolas Y Hubby");
                n.Add("Holland Scholes");
                n.Add("Cyrus W Dehart");
                n.Add("Hortensius Erasmus Bachelor");
                n.Add("Herb Milas Cowan");
                n.Add("Sanders Grotts");
                n.Add("Levi Y Purnell");
                n.Add("Presly J Schbert");
                n.Add("Isam Bethuel Stausberry");
                n.Add("Lester Elie Hortman");
                n.Add("Frank Brinkman");
                n.Add("Ambers A Mizell");
                n.Add("Pascal I Wathan");
                n.Add("Burr Golden Conrats");
                n.Add("Lranze Ayer");

                Dictionary<int, string> myNames = new Dictionary<int, string>();
                int key = 0;
                foreach(var s in n)
                {
                    key++;
                    myNames.Add(key, s);
                }

                return myNames;
            }
        }
    }
}
