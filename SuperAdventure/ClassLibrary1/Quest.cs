using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems{ get; set; }

        // a class constructor that takes in 5 parameters
        // these parameters set the properties upon being called
        public Quest(int id, string name, string description, int rewardexppoints, int rewardgold)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardexppoints;
            RewardGold = rewardgold;

            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
