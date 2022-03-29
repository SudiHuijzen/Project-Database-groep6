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
            string query = "SELECT UserId, UserName, UserPasswordHash, UserPasswordSalt, SecretQuestion, SecretAwnser FROM [User]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void CreateUser(string userName, string password, string question, string awnser)
        {
            HashSalt hash = new HashSalt();

            hash.GenerateHashWithSalt(64, password);


            

            String querry = "INSERT INTO [User] (UserName, UserPasswordHash, UserPasswordSalt, SecretQuestion, SecretAwnser) " +
                    "VALUES (@userName, @PasswordHash, @PasswordSalt, @Question, @Awnser);";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@userName", userName);
            sqlParameters[1] = new SqlParameter("@PasswordHash", hash.Hash);
            sqlParameters[2] = new SqlParameter("@PasswordSalt", hash.Salt);
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
                    Hash = (string)(dr["UserPasswordHash"]).ToString(),
                    Salt = (string)(dr["UserPasswordSalt"]).ToString(),
                    SecretQuestion = (string)(dr["SecretQuestion"]).ToString(),
                    SecretAwnser = (string)dr["SecretAwnser"]
                };
                users.Add(user);
            }
            return users;
        }
    }
}
