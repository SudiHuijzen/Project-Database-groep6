using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Participent
    {
        
        public int ActivityId { get; set; }
        public int ParticipentId { get; set; }
        public string ActivityDescription { get; set; }

        public string ParticipentFirstName { get; set; }

        public string ParticipentLastNAme { get; set; }

        public string ParticipentFullName
        {
            get { return $"{ParticipentFirstName} {ParticipentLastNAme}"; }
        }
    }
}
