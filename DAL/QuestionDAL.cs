using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
/// <summary>
/// ///////////
/// </summary>
///
///////////////////////////////////////////////////////

namespace DAL
{
    public class QuestionDAL
    {
        private DBConnection dBConnection;
        public QuestionDAL()
        {
            dBConnection = new DBConnection();
        }
         public System.Data.DataTable GetAllItems()
        {
            SqlCommand cmd = dBConnection.GetSqlCommand();
            cmd.CommandText = "Select * from questions";
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public void AddNewItems(int questionId,string question,string questionimage,string answerA,string answerB,string answerC,string answerD,string correctAnswer,string categoryId)
        {
            string cmdText = "Insert Into [questions] ([questions],[questiomimage],[answerA],[answerB],[answerC],[answerD],[correctAmswer],[categoryId]";
            cmdText += String.Format("Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7}",question,questionimage,answerA,answerB,answerC,answerD,correctAnswer,categoryId);
            SqlCommand cmd = dBConnection.GetSqlCommand();
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();
        }
        public void DeleteItemsById(int questionId)
        {
            SqlCommand cmd = dBConnection.GetSqlCommand();
            cmd.CommandText = String.Format("Delete from questions where questionsId={0}",questionId);
            cmd.ExecuteNonQuery();
        }
        public void UpdateItems(int questionsId, string question, string questionimage, string answerA, string answerB, string answerC, string answerD, string correctAnswer, string categoryId)
        {
            
        }
    }
}
