// See https://aka.ms/new-console-template for more information


/* 2.დაწერეთ პროგრამა რომელსაც კონსოლიდან გადავცემთ რიცხვს და
     პასუხად დაბეჭდავს შეყვანილი რიცხვის გამყოფების რაოდენობას.
     მაგალითად, თუ შევიყვანთ 6-ს, უნდა დაიბეჭდოს 4-ს (1, 6, 2, 3). */

Console.WriteLine("Enter Number: ");
int gasayofi = Convert.ToInt32(Console.ReadLine());
int gamyofi = 1;
int count = 0;

while (gamyofi <= gasayofi)
{
    if (gasayofi % gamyofi == 0)
    {
        count++;
        Console.Write(gamyofi + ",");
    }
    gamyofi++;
}

Console.WriteLine("\n" + "Divisors Counts:" + count);
Console.ReadKey();