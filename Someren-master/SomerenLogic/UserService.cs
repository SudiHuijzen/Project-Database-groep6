using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class UserService
    {
        UserDao userdb;

        public UserService()
        {
            this.userdb = new UserDao();
        }

        public List<User> GetUsers()
        {
            List<User> users = userdb.GetAll();
            return users;
        }

        public void CreateUser(string userName, string password, string secretQuestion, string secretAwnser)
        {
            userdb.CreateUser(userName, password, secretQuestion, secretAwnser);
        }
    }
}
