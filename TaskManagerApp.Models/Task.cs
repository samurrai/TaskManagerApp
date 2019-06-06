using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp.Models
{
    public class Task
    {
        public DateTime DateAndTime { get; set; }
        public TaskTypes TaskType { get; set; }
        public PeridiocityTypes PeridiocityType { get; set; }
    }
}