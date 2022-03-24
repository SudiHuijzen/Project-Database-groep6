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
    public class ParticipentDao : BaseDao
    {
        public List<Participent> GetAll(int participent)
        {
            string query = "SELECT Student.firstName, Student.lastName, ActivityStudent.activity_id, Activity.Description," +
                "ActivityStudent.student_id FROM [ActivityStudent] " +
                "JOIN Activity ON ActivityStudent.activity_id = Activity.activity_id" +
                "JOIN Student On ActivityStudent.activity_id = Student.activity_id" +
                "WHERE ActivityStudent.activity_id = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            sqlParameters[0] = new SqlParameter("@Id", participent);
     
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddParticipent(int student, int activity)
        {
            String querry = "INSERT INTO dbo.ActivityStudent (student_id, activity_id)" +
                "VALUES (@DStudentId, @ActivityId);";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@StudentId", student);
            sqlParameters[1] = new SqlParameter("@ActivityId", activity);
            ExecuteEditQuery(querry, sqlParameters);
        }

        public void RemoveParticipent(int student)
        {
            String querry = "DELETE FROM ActivityStudent WHERE student_id = @StudentId";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            sqlParameters[0] = new SqlParameter("@StudentId", student);
            ExecuteEditQuery(querry, sqlParameters);
        }

        private List<Participent> ReadTables(DataTable dataTable)
        {
            List<Participent> students = new List<Participent>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Participent student = new Participent()
                {
                    ActivityId = (int)dr["ActivityStudent.activity_id"],
                    ActivityDescription = (string)(dr["Activity.Description"]),
                    ParticipentId = (int)(dr["drink_price"]),
                    ParticipentFirstName = (string)(dr["Student.firstName"]),
                    ParticipentLastNAme = (string)(dr["Student.lastName"]),
                };
                students.Add(student);
            }
            return students;
        }
    }
}
