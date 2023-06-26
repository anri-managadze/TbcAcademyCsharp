// See https://aka.ms/new-console-template for more information
/


string temperature = Console.ReadLine();
int input = int.Parse(temperature);
//var input = int.Parse(Console.ReadLine());

if (input < 0)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("It's freezing");
}
else if (input >= 0 && input <= 30)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Weather is good");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("It's hot");
}
Console.ReadKey();
