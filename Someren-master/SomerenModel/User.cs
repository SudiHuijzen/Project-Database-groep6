using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Hash { get; set; }
        public string Salt { get; set; }
        public string SecretQuestion { get; set; }
        public string SecretAwnser { get; set; }
    }
}
