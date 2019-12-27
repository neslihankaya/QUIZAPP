using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
using Entity;

namespace BLL
{
    public class StudentBLL
    {
        private StudentDAL studentDAL;
        public StudentBLL()
        {
            studentDAL = new StudentDAL();
        }
        public int LoginControl(string username, string password)
        {

            return studentDAL.LoginControl(username, password);
        }
        public List<StudentEntity> GetStudents()
        {
            return studentDAL.GetStudents();
        }
    }
}
