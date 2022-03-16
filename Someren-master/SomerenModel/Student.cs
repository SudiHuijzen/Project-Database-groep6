using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Student
    {
        DateTime birthDate;
        Room room;
        public string FirstName { get; set; }

        public string LastName { get; set; }    
        public int Number { get; set; } // StudentNumber, e.g. 474791
        public DateTime BirthDate
        {
            get => this.birthDate;
            set
            {
                if(value < DateTime.Now)
                {
                    this.birthDate = value;
                }
            }
        }
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

        public Student(int number)
        {
            Number = number;
        }

        public Student()
        {
        }
    }
}
