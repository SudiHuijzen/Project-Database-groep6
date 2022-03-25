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
            string query = "SELECT Student.firstName, Student.lastName, Student.student_id " +
                "FROM ActivityStudent " +
                "JOIN Student ON ActivityStudent.Student_id = Student.Student_id " +
                "WHERE ActivityStudent.activity_id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Id", participent);

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddParticipent(int student, int activity)
        {
            String querry = "INSERT INTO ActivityStudent (student_id, activity_id)" +
                "VALUES (@StudentId, @ActivityId);";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@StudentId", student);
            sqlParameters[1] = new SqlParameter("@ActivityId", activity);
            ExecuteEditQuery(querry, sqlParameters);
        }

        public void RemoveParticipent(int student, int activity)
        {
            String querry = "DELETE FROM ActivityStudent WHERE student_id = @StudentId AND activity_id = @activityId";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@StudentId", student);
            sqlParameters[1] = new SqlParameter("@activityId", activity);
            ExecuteEditQuery(querry, sqlParameters);
        }

        private List<Participent> ReadTables(DataTable dataTable)
        {
            List<Participent> students = new List<Participent>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Participent student = new Participent()
                {
                    ParticipentId = (int)(dr["student_id"]),
                    ParticipentFirstName = (string)(dr["firstName"]),
                    ParticipentLastNAme = (string)(dr["lastName"]),
                };
                students.Add(student);
            }
            return students;
        }
    }
}
