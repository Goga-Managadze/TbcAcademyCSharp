// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;
using Task;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Welcome to the Quiz Application!");

Console.WriteLine("What would you like to do?");
Console.WriteLine("1. Create a new quiz");
Console.WriteLine("2. Complete an existing quiz");

Console.WriteLine("Enter your choice (1-2): ");
string choice = Console.ReadLine();
if (choice == "1")
{
    Console.Write("Enter the quiz name: ");
    string quizName = Console.ReadLine();
    Quiz quiz = new Quiz(quizName);

    Console.WriteLine("Enter the quiz questions (to finish adding questions enter 'done' ):");

    while (true)
    {
        Console.Write("Enter question text: ");
        string questionText = Console.ReadLine();
        if (questionText.ToLower() == "done")
            break;

        Question question = new Question { QuestionText = questionText };
        question.ProbableAnswers = new List<string>();

        Console.Write("Enter question score: ");
        int questionScore = int.Parse(Console.ReadLine());
        question.QuestionScore = questionScore;
        quiz.AddQuestion(question);

        for (int i = 1; i <= 4; i++)
        {
            Console.Write("Enter probable answer " + i + ": ");
            string answers = Console.ReadLine();
            question.ProbableAnswers.Add(answers);
        }
        Console.Write("Enter the correct answer (1-4): ");
        int correctAnswer = int.Parse(Console.ReadLine());
        question.CorrectAnswer = correctAnswer;
        Console.WriteLine("Question added to the quiz.");
        Console.WriteLine();
    }
    
    quiz.SaveQuizToFile(quiz.Questions);

}
