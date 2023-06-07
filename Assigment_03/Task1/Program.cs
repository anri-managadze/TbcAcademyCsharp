// See https://aka.ms/new-console-template for more information


/* 1. დაწერეთ პროგრამა რომელსაც კონსოლიდან გადავცემთ რიცხვს
      და პასუხად დაბეჭდავს რიცხვი მარტივია თუ შედგენილი. */

int input = Convert.ToInt32(Console.ReadLine());
int gamyofi = 1;
int count = 0;

while (input >= gamyofi)
{
    if (input % gamyofi == 0)
    {
        count++;
    }
    gamyofi++;
}
string result = count == 2 ? $"{input} is Prime Number" : $"{input} is Composed Number";
Console.WriteLine(result);
