/* 4.დაწერეთ კონსოლური აპლიკაცია რომელიც მომხმარებლისგან მიიღებს შემავალ პარამეტრად რიცხვს 
     და შემდეგ დაბეჭდავს ამ რიცხვის შესაბამისი სართულების "პირამიდას". */


int input = Convert.ToInt32(Console.ReadLine());
int k;
for (int i = 0; i <= input; i++)
{
    for (int j = 0; j < input - i; j++)
    {
        Console.Write(" ");
    }
    for (k = 1; k <= i; k++)
    {
        Console.Write("*");
    }
    for (k = (i - 1); k >= 1; k--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}