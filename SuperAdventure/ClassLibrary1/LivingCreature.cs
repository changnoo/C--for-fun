using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
        // base class for all living objects
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }

        public LivingCreature(int currenthitpoints, int maxhitpoints)
        {
            CurrentHitPoints = currenthitpoints;
            MaximumHitPoints = maxhitpoints;
        }

    }
}
