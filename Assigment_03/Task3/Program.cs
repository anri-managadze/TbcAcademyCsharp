
/* დაწერეთ პროგრამა რომელიც კონსოლიდან მიიღებს N რიცხვს 
   და გამოიტანს დადებითების საშუალო არითმეტიკულს და ჯამს. */


Console.WriteLine("Please, Enter Number");
decimal num = 0;
int count = 0;
while (true)
{
    int input = Convert.ToInt32(Console.ReadLine());
    if (input > 0)
    {
        count++;
        num = num + input;
        decimal sum = num;
        decimal avar = sum / count;
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + avar);
    }
    else
    {
        Console.WriteLine("Please, Enter Positive Number");
    }
}
