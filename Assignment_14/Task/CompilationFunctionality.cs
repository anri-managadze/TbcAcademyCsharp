using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task
{
    public class CompilationFunctionality
    {
        private const string QuizFileName = "quiz.txt";

        public void ClearQuiz()
        {
            if (File.Exists(QuizFileName))
            {
                File.WriteAllText(QuizFileName,string.Empty);
                Console.WriteLine("Quiz cleared successfully.");
            }
            else
            {
                Console.WriteLine("Quiz file does not exist.");
            }
        }
        public void AddQuestion()
        {
            Console.WriteLine("Enter Your question:");
            string question = "Your Question: " +Console.ReadLine();

            Console.WriteLine("Enter the answers (separated by commas):");
            string[] answers = Console.ReadLine().Split(',');

            Console.WriteLine("Enter the correct answer (index starting from 1):");
            int correctAnswerIndex =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Question Point :");
            string score = ("Question Point: " + Console.ReadLine());

            var questionData = new List<string>
        {
            question,
            string.Join(",", answers),
            correctAnswerIndex.ToString(),
            score
        };

            using (var stream = new StreamWriter(QuizFileName,true))
            {
                stream.WriteLine(string.Join("\n", questionData));
            }
            Console.WriteLine("Question added to the quiz.");
        }
    }
}

