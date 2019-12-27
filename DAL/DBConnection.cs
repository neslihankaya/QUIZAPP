using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DAL
{
    public class DBConnection
    {
        private readonly string _connectionString;

        public DBConnection()
        {
            _connectionString = "Data Source=NESSS\\SQLEXPRESS;Initial Catalog=log;Integrated Security=True";
        }
        private SqlConnection GetSqlConnection()
        {
            SqlConnection con = new SqlConnection(_connectionString);
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            else
            {
                con.Open();
            }
            return con;
        }

        public SqlCommand GetSqlCommand()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetSqlConnection();
            return cmd;
        }
       
    }
}
