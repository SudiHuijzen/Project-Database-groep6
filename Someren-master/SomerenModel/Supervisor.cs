using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Supervisor
    {
        public int ActivityId { get; set; }
        public int SupervisorId { get; set; }
        public string ActivityDescription { get; set; }
        public string SupervisorFirstName { get; set; }
        public string SupervisorLastNAme { get; set; }
        public string SupervisorFullName
        {
            get { return $"{SupervisorFirstName} {SupervisorLastNAme}"; }
        }
    }
}
