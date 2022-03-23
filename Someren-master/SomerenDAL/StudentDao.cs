﻿using System;
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
    public class StudentDao : BaseDao
    {      
        public List<Student> GetAllStudents()
        {
            string query = "SELECT student_id, firstName, lastName, birthdate FROM [Student]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Student> GetActivityStudents()
        {
            string query = "SELECT student.student_id, student.firstName FROM [ActivityStudent]" +
                "JOIN Activity ON activitystudent.activity_id = activity.activity_id" +
                "JOIN Student ON activitystudent.student_id = student.student_id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student((int)dr["student_id"])
                {
                    FirstName = (string)(dr["firstName"].ToString()),
                    LastName = (string)(dr["lastName"].ToString()),
                    BirthDate = (DateTime)dr["birthdate"]
                };
                students.Add(student);
            }
            return students;
        }
    }
}
