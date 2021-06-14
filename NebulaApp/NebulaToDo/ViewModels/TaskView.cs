using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaToDo.ViewModels
{
    public class TaskView
    {
        public string TaskName { get; set; }

        public DateTime DueDate { get; set; }

        public string Description { get; set; }
        
    }

    public class TaskAddingView : TaskView
    {
        public string Creator { get; set; }
    }

    public class TaskListView : TaskView
    {
        public int TaskID { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
