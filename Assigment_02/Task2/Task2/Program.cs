// See https://aka.ms/new-console-template for more information


Console.WriteLine("Please, Enter : paper, stone or scissors!");
var input = Console.ReadLine();
Random random = new Random();
string[] sagnebi = { "paper", "stone", "scissors" };
int index = random.Next(sagnebi.Length);

Console.WriteLine("Your move:" + input);
Console.WriteLine("Computer move:" + sagnebi[index]);

if (input == sagnebi[index])
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("Drow :| ");
}
else if (
    (input == sagnebi[1] && sagnebi[index] == "scissors") ||
    (input == sagnebi[2] && sagnebi[index] == "paper") ||
    (input == sagnebi[0] && sagnebi[index] == "stone"))
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("You are a winner :) ");
}
else
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("You are a loser :( ");
}
Console.ReadKey();