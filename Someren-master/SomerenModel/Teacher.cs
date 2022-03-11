using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SomerenModel
{
  
    public class Teacher
    {
        private Room room;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; } // LecturerNumber, e.g. 47198
        public bool isSupervisor { get; set; } // sets whether or not a teacher is in supervisor role

        public int RoomNR 
        {
            get { return this.room.Number; }
            set
            {
                // allow only a roomnumber of the type teachers room
                if (this.room.Type == true)
                {
                    this.room.Number = value;
                }
            }
        }

        public string PrintSupervisor()
        {
            // prints yes or no in the supervisor collumn
            if (isSupervisor == true)
            {
                return "Yes";
            }
            return "No";    
        }
    }
}
