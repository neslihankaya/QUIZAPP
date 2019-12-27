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
    public class TeacherDAL
    {
        private DBConnection dBConnection;
        public TeacherDAL()
        {
            dBConnection = new DBConnection();
        }
        public bool LoginControl(string username, string password)
        {
            SqlCommand cmd = dBConnection.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM teacher WHERE username = @p1 and password = @p2";
            cmd.Parameters.AddWithValue("@p1", username);
            cmd.Parameters.AddWithValue("@p2", password);
            SqlDataReader dr = cmd.ExecuteReader();

            bool control;
            if (dr.Read())
            {
                control = true;
            }

            else control = false;

            return control;
        }
    }
}
