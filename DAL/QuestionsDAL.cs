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
    public class QuestionsDAL
    {

        private DBConnection dBConnection;
        public QuestionsDAL()
        {
            dBConnection = new DBConnection();
        }
        public DataTable GetAllQuestions()
        {
            SqlCommand cmd = dBConnection.GetSqlCommand();
            cmd.CommandText = "Select * from questions";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public void AddNewQuestion(int questionId, string question, string questionimage, string answerA, string answerB, string answerC, string answerD, string correctAnswer, string categoryId)
        {
            string cmdText = "Insert Into [questions] ([questions],[questiomimage],[answerA],[answerB],[answerC],[answerD],[correctAmswer],[categoryId]";
            cmdText += String.Format("Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7}", question, questionimage, answerA, answerB, answerC, answerD, correctAnswer, categoryId);
            SqlCommand cmd = dBConnection.GetSqlCommand();
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();
        }
        public void DeleteQuestionById(int questionId)
        {
            SqlCommand cmd = dBConnection.GetSqlCommand();
            cmd.CommandText = String.Format("Delete from questions where questionsId={0}", questionId);
            cmd.ExecuteNonQuery();
        }
      
    }
}
