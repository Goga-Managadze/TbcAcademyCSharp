using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Quiz
    {
        public string QuizName { get; set; }
        public List<Question> Questions { get; set; }


        public Quiz(string quizName)
        {
            QuizName = quizName;
            Questions = new List<Question>();
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
        public void SaveQuizToFile(List<Question> Questions)
        {
            Console.Write("Enter the file name to save the quiz: ");
            string fileName = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(QuizName);
                writer.WriteLine(Questions.Count);

                foreach (Question question in Questions)
                {
                    writer.WriteLine(question.QuestionText);
                    writer.WriteLine(question.QuestionScore);
                    foreach (string answer in question.ProbableAnswers)
                    {
                        writer.WriteLine(answer);
                    }

                    writer.WriteLine();
                    writer.WriteLine(question.CorrectAnswer);
                }
            }
            Console.WriteLine("Quiz saved to file: " + fileName);
        }
    }
}
