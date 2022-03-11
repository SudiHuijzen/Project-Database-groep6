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
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT teacher_id, firstName, lastName, isSupervisor FROM [Teacher]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Number = (int)dr["teacher_id"],
                    firstName = (string)(dr["firstName"].ToString()),
                    lastName = (string)(dr["lastName"]).ToString(),
                    isSupervisor = (bool)(dr["isSupervisor"]),
                    //RoomNR = (int)dr["room_nr"]
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}
