﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class PlayerQuest
    {
        public Quest Details { get; set; }

        public bool IsCompleted { get; set; }
        
        public PlayerQuest(Quest details, bool iscompleted)
        {
            Details = details;
            IsCompleted = false;
        }
    }
}
