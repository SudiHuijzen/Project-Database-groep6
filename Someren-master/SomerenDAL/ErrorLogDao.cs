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
    public class ErrorLogDao : BaseDao
    {
        public List<ErrorLog> GetAll()
        {
            string query = "SELECT error_id, error_date, error_log FROM [ErrorLog]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddError(string error)
        {
            String querry = "INSERT INTO ErrorLog (error_log)" +
                "VALUES (@ErrorLog)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ErrorLog", error);
            ExecuteEditQuery(querry, sqlParameters);
        }

        private List<ErrorLog> ReadTables(DataTable dataTable)
        {
            List<ErrorLog> errors = new List<ErrorLog>();

            foreach (DataRow dr in dataTable.Rows)
            {
                ErrorLog error = new ErrorLog()
                {
                    ErrorId = (int)dr["error_id"],
                    TimeStamp = (DateTime)(dr["error_date"]),
                    ErrorMessage = (string)(dr["error_log"])
                };
                errors.Add(error);
            }
            return errors;
        }
    }
}
