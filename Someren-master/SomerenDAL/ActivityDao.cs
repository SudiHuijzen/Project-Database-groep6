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
            string query = "SELECT activity_id, [Description], StartDateTime, EndDateTime FROM [Activity]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    ActivityId = (int)dr["activity_id"],
                    Description = (string)(dr["[Description]"]),
                    BeginTime = (DateTime)(dr["StartDateTime"]),
                    EndTime = (DateTime)(dr["EndDateTime"])
                };
                activities.Add(activity);
            }
            return activities;
        }
    }
}
