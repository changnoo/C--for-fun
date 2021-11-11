using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class HealingPotion : Item
    {
        // these attributes are inherited
        //public int ID { get; set; }
        //public string Name { get; set; }
        //public string NamePlural { get; set; }
        public int AmountToHeal { get; set; }

        public HealingPotion(int id, string name, string nameplural, int amounttoheal) : base(id, name, nameplural)
        {
            AmountToHeal = AmountToHeal;
        }

            
    }
}
