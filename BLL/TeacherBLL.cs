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
    public class TeacherBLL
    {
        private TeacherDAL teacherDAL;
        public TeacherBLL()
        {
            teacherDAL = new TeacherDAL();
        }
        public bool LoginControl(string username, string password)
        {
            return teacherDAL.LoginControl(username, password);
        }
    }
    
}
