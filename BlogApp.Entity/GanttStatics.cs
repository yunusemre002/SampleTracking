using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Entity
{
    public class GanttStatics
    {
        //'2014Spring', 'Spring 2014', 'spring', new Date(2014, 2, 22), new Date(2014, 5, 20), null, 100, null

        public string TaskId { get; set; }
        public string TaskName { get; set; }
        public string Resource { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Duration { get; set; }
        public int Percent { get; set; }
        public string Dependencies { get; set; }
    }
}
