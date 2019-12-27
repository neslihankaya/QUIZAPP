using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class QuestionsEntity
    {
        public int questionId { get; set; }
        public int categoryID { get; set; }
        public int lessonId { get; set; }
        public int quizId { get; set; }
        public int questionsNumber { get; set; }
        public string question { get; set; }
        public string answerA { get; set; }
        public string answerB { get; set; }
        public string answerC { get; set; }
        public string answerD { get; set; }
        public string correctanswer { get; set; }
        public string image { get; set; }
    }
}
