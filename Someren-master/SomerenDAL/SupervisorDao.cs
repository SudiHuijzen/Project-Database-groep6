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
            string query = "SELECT Teacher.firstName, Teacher.lastName, ActivitySupervisor.activity_id, Activity.Description," +
                "ActivitySupervisor.teacher_id FROM [ActivitySupervisor] " +
                "JOIN Activity ON ActivitySupervisor.activity_id = Activity.activity_id" +
                "JOIN Teacher On ActivitySupervisor.activiyy_id = Teacher.activity_id" +
                "WHERE ActivityTeacher.activity_id = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            sqlParameters[0] = new SqlParameter("@Id", supervisor);

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddSupervisor(int teacher, int activity)
        {
            String query = "INSERT INTO dbo.ActivitySupervisor (Teacher_id, activity_id)" +
                "VALUES (@teacherId, @ActivityId);";
            String secondQuery = "UPDATE Teacher SET isSupervisor = True WHERE Teacher_id = @teacherId";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@teacherId", teacher);
            sqlParameters[1] = new SqlParameter("@ActivityId", activity);
            ExecuteEditQuery(query, sqlParameters);
            ExecuteEditQuery(secondQuery, sqlParameters);
        }

        public void RemoveSupervisor(int Teacher)
        {
            String query = "DELETE FROM ActivitySupervisor WHERE Teacher_id = @teacherId";
            String secondQuery = "UPDATE Teacher SET isSupervisor = False WHERE Teacher_id = @teacherId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@teacherId", Teacher);
            ExecuteEditQuery(query, sqlParameters);
            ExecuteEditQuery(secondQuery, sqlParameters);
        }

        private List<Supervisor> ReadTables(DataTable dataTable)
        {
            List<Supervisor> teachers = new List<Supervisor>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Supervisor teacher = new Supervisor()
                {
                    ActivityId = (int)dr["ActivitySupervisor.activity_id"],
                    ActivityDescription = (string)(dr["Activity.Description"]),
                    SupervisorId = (int)(dr["ActivitySupervisor.Teacher_id"]),
                    SupervisorFirstName = (string)(dr["Teacher.firstName"]),
                    SupervisorLastNAme = (string)(dr["Teacher.lastName"]),
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}
