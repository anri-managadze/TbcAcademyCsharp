using Task;

CompilationFunctionality quizMaker = new CompilationFunctionality();
FillingFunctionality fillingFunctionality = new FillingFunctionality();

Console.WriteLine("Please choose: ");
Console.WriteLine("1.Compilation a quiz");
Console.WriteLine("2.Filling out the quiz");
int input = int.Parse(Console.ReadLine());
switch (input)
{
    case 1:
        while (true)
        {
            Console.WriteLine("Compilation a quiz");
            Console.WriteLine("1. Clear Quiz");
            Console.WriteLine("2. Add Question to Quiz");
            Console.WriteLine("3. Exit");
            int input1 = int.Parse(Console.ReadLine());

            switch (input1)
            {
                case 1:
                    quizMaker.ClearQuiz();
                    break;
                case 2:
                    quizMaker.AddQuestion();
                    break;
                case 3:
                    Console.WriteLine("Exit");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    case 2:
        Console.WriteLine("Filling out the quiz");
        
        Console.WriteLine("Enter your first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter your last name:");
        string lastName = Console.ReadLine();

        int score = fillingFunctionality.Filling();

        Console.WriteLine();
        Console.WriteLine("Quiz Results:");
        Console.WriteLine("Participant: " + firstName + " " + lastName);
        Console.WriteLine("Score: " + score);
        break;
    default:
        Console.WriteLine("");
        break;
}


