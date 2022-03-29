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

        public void CreateUser(string userName, string password, string salt, string secretQuestion, string secretAwnser)
        {
            userdb.CreateUser(userName, password, salt, secretQuestion, secretAwnser);
        }

        public void ChangePassword(string newPassword,string salt, string userName, string awnser)
        {
            userdb.ChangePassword(newPassword, salt, userName, awnser);
        }
    }
}
