using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entity;

namespace DAL
{
    public class StudentDAL
    {
        private DBConnection dBConnection;
        public StudentDAL()
        {
            dBConnection = new DBConnection();
        }
        public int LoginControl(string username, string password)
        {
            SqlCommand cmd = dBConnection.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM student WHERE username = @p1 and password = @p2";
            cmd.Parameters.AddWithValue("@p1", username);
            cmd.Parameters.AddWithValue("@p2", password);
            SqlDataReader dr = cmd.ExecuteReader();

            int studentId;
            if (dr.Read())
            {
                studentId = int.Parse(dr["studentId"].ToString());
            }

            else studentId = -1;

            return studentId;
        }
        public List<StudentEntity> GetStudents()
        {
            SqlCommand cmd = dBConnection.GetSqlCommand();
            cmd.CommandText = "SELECT * from student";
            List<StudentEntity> students = new List<StudentEntity>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                StudentEntity student = new StudentEntity();
                student.studentId = int.Parse(dr["studentId"].ToString());
                student.studentName = dr["studentName"].ToString();
                student.studentSurname = dr["studentSurname"].ToString();
                student.username = dr["username"].ToString();
                student.password = dr["password"].ToString();

                students.Add(student);
            }
            return students;

        }
    }
}
