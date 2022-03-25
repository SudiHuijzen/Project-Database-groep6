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
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAll()
        {
            string query = "SELECT activity_id, Description, StartDateTime, EndDateTime FROM [Activity]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddActivity(string description, DateTime startDate, DateTime endDate)
        {
            String query = "INSERT INTO Activity (Description, StartDateTime, EndDateTime) " +
               "VALUES (@description, @StartTime, @EndTime);";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@description", description);
            sqlParameters[1] = new SqlParameter("@StartTime", startDate);
            sqlParameters[2] = new SqlParameter("@EndTime", endDate);
            
            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveActivity(int id)
        {
            String query = "DELETE FROM Activity WHERE activity_id = @ActivityId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ActivityId", id);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void ChangeDescription(string newDescription, int id)
        {
            string querry = "UPDATE Activity SET Description = @description WHERE activity_id = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@description", newDescription);
            sqlParameters[1] = new SqlParameter("@Id", id);
            ExecuteEditQuery(querry, sqlParameters);
        }

        public void ChangeDateTime(int id, DateTime startTime, DateTime endTime )
        {
            string querry = "UPDATE Activity SET StartDateTime = @startDateTime WHERE activity_id = @Id";
            string querry2 = "UPDATE Activity SET EndDateTime = @endDateTime WHERE activity_id = @Id";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@startDateTime", startTime);
            sqlParameters[1] = new SqlParameter("@Id", id);

            SqlParameter[] secondSqlParameters = new SqlParameter[2];
            secondSqlParameters[0] = new SqlParameter("@endDateTime", endTime);
            secondSqlParameters[1] = new SqlParameter("@Id", id);

            ExecuteEditQuery(querry, sqlParameters);
            ExecuteEditQuery(querry2, secondSqlParameters);
        }
        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    ActivityId = (int)dr["activity_id"],
                    Description = (string)(dr["Description"]),
                    BeginTime = (DateTime)(dr["StartDateTime"]),
                    EndTime = (DateTime)(dr["EndDateTime"])
                };
                activities.Add(activity);
            }
            return activities;
        }
    }
}
