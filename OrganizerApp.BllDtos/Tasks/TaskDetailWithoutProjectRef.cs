
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerApp.BllDtos.Tasks
{
    public class TaskDetailWithoutProjectRef : TaskBaseWithPriorityAndContext
    {
        public string Description { get; set; }
        public string ExecutionTime { get; set; }
        public DateTime? StartTime { get; set; }
        public string State { get; set; }
        public int? ProjectID { get; set; }
    }
}
