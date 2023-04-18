using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0414hw
{
    public class QuestionWithAnswers
    {
        public string Question { get;set; }
        public string Answer1 { get;set; }
        public string Answer2 { get;set; }
        public string Answer3 { get;set; }
        public string Answer4 { get;set; }
        public int RightAnswer { get;set; }
        public QuestionWithAnswers(string Question,string Answer1,string Answer2,string Answer3,string Answer4,int RightAnswer)
        {
            this.Question = Question;
            this.Answer1 = Answer1;
            this.Answer2 = Answer2;
            this.Answer3 = Answer3;
            this.Answer4 = Answer4;
            this.RightAnswer = RightAnswer;
        }

    }
}
