using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Question
    {
        public string QuestionText { get; set; }
        public int QuestionScore { get; set; }
        public List<string> ProbableAnswers { get; set; }
        public int CorrectAnswer { get; set; }
    }
}
