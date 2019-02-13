
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerApp.BllDtos.Tasks
{
    public class TaskBaseWithPriorityAndContext : TaskBase
    {
        public string Priority { get; set; }
        public string Context { get; set; }
    }
}
