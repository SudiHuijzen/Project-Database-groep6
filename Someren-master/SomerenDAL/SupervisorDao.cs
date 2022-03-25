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
    public class SupervisorDao : BaseDao
    {
        public List<Supervisor> GetAll(int supervisor)
        {
            string query = "SELECT Teacher.firstName, Teacher.lastName, Teacher.teacher_id FROM ActivitySupervisor " +
                "JOIN Teacher ON ActivitySupervisor.teacher_id = Teacher.teacher_id " +
                "WHERE ActivitySupervisor.activity_id = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Id", supervisor);

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddSupervisor(int teacher, int activity)
        {
            String query = "INSERT INTO ActivitySupervisor (Teacher_id, activity_id)" +
                "VALUES (@teacherId, @ActivityId);";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@teacherId", teacher);
            sqlParameters[1] = new SqlParameter("@ActivityId", activity);
            ExecuteEditQuery(query, sqlParameters);
        
        }

        public void RemoveSupervisor(int Teacher, int activity)
        {
            String query = "DELETE FROM ActivitySupervisor WHERE Teacher_id = @teacherId AND activity_id = @ActivityId";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@teacherId", Teacher);
            sqlParameters[1] = new SqlParameter("@ActivityId", activity);
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Supervisor> ReadTables(DataTable dataTable)
        {
            List<Supervisor> teachers = new List<Supervisor>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Supervisor teacher = new Supervisor()
                { 
                    SupervisorId = (int)(dr["Teacher_id"]),
                    SupervisorFirstName = (string)(dr["firstName"]),
                    SupervisorLastNAme = (string)(dr["lastName"]),
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}
