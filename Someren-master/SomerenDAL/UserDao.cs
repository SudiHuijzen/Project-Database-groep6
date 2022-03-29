using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class UserDao : BaseDao
    {
        public List<User> GetAll()
        {
            string query = "SELECT UserId, UserName, UserPassword, UserSalt, SecretQuestion, SecretAwnser FROM [User]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void ChangePassword(string newPassword, string salt, string userName, string awnser)
        {
            string querry = "UPDATE [User] SET UserPassword = @NewPassword, UserSalt = @Salt WHERE UserName = @userName AND SecretAwnser = @Awnser ";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@NewPassword", newPassword);
            sqlParameters[1] = new SqlParameter("@Salt", salt);
            sqlParameters[2] = new SqlParameter("@userName", userName);
            sqlParameters[3] = new SqlParameter("@Awnser", awnser);
            ExecuteEditQuery(querry, sqlParameters);
        }

        public void CreateUser(string userName, string password, string salt, string question, string awnser)
        {
            String querry = "INSERT INTO [User] (UserName, UserPassword, UserSalt, SecretQuestion, SecretAwnser) " +
                    "VALUES (@userName, @Password, @Salt, @Question, @Awnser);";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@userName", userName);
            sqlParameters[1] = new SqlParameter("@Password", password);
            sqlParameters[2] = new SqlParameter("@Salt", salt);
            sqlParameters[3] = new SqlParameter("@Question", question);
            sqlParameters[4] = new SqlParameter("@Awnser", awnser);
            ExecuteEditQuery(querry, sqlParameters);   
        }

        private List<User> ReadTables(DataTable dataTable)
        {
            List<User> users = new List<User>();

            foreach (DataRow dr in dataTable.Rows)
            {
                User user = new User()
                {
                    Id = (int)dr["UserId"],
                    UserName = (string)(dr["UserName"].ToString()),
                    Password = (string)(dr["UserPassword"]).ToString(),
                    Salt = (string)(dr["UserSalt"]).ToString(),
                    SecretQuestion = (string)(dr["SecretQuestion"]).ToString(),
                    SecretAwnser = (string)dr["SecretAwnser"]
                };
                users.Add(user);
            }
            return users;
        }
    }
}
