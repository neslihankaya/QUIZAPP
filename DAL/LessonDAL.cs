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
    public class LessonDAL
    {
        private DBConnection dBConnection;
        public LessonDAL()
        {
            dBConnection = new DBConnection();
        }
        public DataTable GetAllItems(LessonEntity lesson)
        {
            SqlCommand cmd = dBConnection.GetSqlCommand();
            cmd.CommandText = "Select * from lesson";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public void AddLesson(LessonEntity lesson)
        {

            SqlCommand cmd = dBConnection.GetSqlCommand();
            cmd.CommandText = "INSERT INTO lesson(lessonname) VALUES(@p1)";
            cmd.Parameters.AddWithValue("@p1", lesson.lessonName);

            cmd.ExecuteNonQuery();
             
        }
    }
}
