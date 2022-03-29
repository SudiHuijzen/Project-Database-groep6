using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
       
        DateTime endTime;
        
        
        public int ActivityId { get; set; }
        public string Description { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime
        {
            get => endTime;
            set
            {
                if (value > BeginTime)
                {
                    this.endTime = value;
                }
            }
        }

        public int TeacherId { get; set; }

        public int StudentId { get; set; }

        public string TeacherName { get; set; }

        public string StudentName { get; set; }
    }
}
