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
    public class LesssonBLL
    {
        private LessonDAL lessonDAL;
        public LesssonBLL()
        {
            lessonDAL = new LessonDAL();
        }
        public DataTable GetAllItems(LessonEntity lesson)
        {
            return lessonDAL.GetAllItems(lesson);
        }
        public void AddLesson(LessonEntity lesson)
        {
            lessonDAL.AddLesson(lesson);
        }
    }
}
