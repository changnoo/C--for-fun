using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Weapon : Item
    {
        // these three attributes are inherited from base class item
        //public int ID { get; set; }
        //public string Name { get; set; }
        //public string NamePlural { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int id, string name, string nameplural, int mindmg, int maxdmg) : base(id, name, nameplural)
        {
            MinimumDamage = mindmg;
            MaximumDamage = maxdmg;
        }

    }
}
