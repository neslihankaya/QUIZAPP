using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using DAL;

namespace BLL
{
    public class QuestionsBLL
    {
        private QuestionDAL questionsDAL;
        public QuestionsBLL()
        {
            questionsDAL = new QuestionDAL();
        }
        public System.Data.DataTable GetAllItems()
        {
            //ilk olarak guvenlik onlemlerinin alındığı kodlar
            //validasyon işlemlerinin yapıldığı kodlar
            return questionsDAL.GetAllItems();
        }
        public void AddViewItem(int questionId, string question, string questionimage, string answerA, string answerB, string answerC, string answerD, string correctAnswer, string categoryId)
        {
            //ilk olarak guvenlik onlemlerinin alındığı kodlar
            //validasyon işlemlerinin yapıldığı kodlar
            questionsDAL.AddNewItems(questionId,question,questionimage,answerA,answerB,answerC,answerD,correctAnswer,categoryId);
        }
        public void DeleteItemsById(int questionId)
        {
            questionsDAL.DeleteItemsById(questionId);
        }
        public void UpdateItem(int questionId, string question, string questionimage, string answerA, string answerB, string answerC, string answerD, string correctAnswer, string categoryId)
        {

        }
    }
}
