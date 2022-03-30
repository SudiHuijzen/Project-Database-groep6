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
            HashSalt hashSalt = new HashSalt();
            string salt = hashSalt.GenerateSalt(70);
            string hashedPassword = hashSalt.HashPassword(password, salt, 10101, 70);
            userdb.CreateUser(userName, hashedPassword, salt, secretQuestion, secretAwnser);
        }

        public void ChangePassword(string userName, string secretAwnser, string password)
        {
            HashSalt hashSalt = new HashSalt();
            string NewSalt = hashSalt.GenerateSalt(70);
            string hashedPassword = hashSalt.HashPassword(password, NewSalt, hashSalt.Iterations, hashSalt.Hash);
            userdb.ChangePassword(userName, secretAwnser, hashedPassword, NewSalt);
        }
    }
}
