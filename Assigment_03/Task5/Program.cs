


/* 5. დაწერეთ პროგრამა რომელსაც გადასცემთ რიცხვის დიაპაზონს 
      (დიაპაზონის მინიმალური და მაქსიმალური რიცხვი), 
      პროგრამა დიაპაზონიდან დააგენერირებს შემთხვევით რიცხვს და 
      შემოგთავაზებთ მის გამოცნობას მანამ სანამ არ გამოიცნობთ, 
      და დაბეჭდავს რამდენ ცდაში გამოიცანით რიცხვი. გამოცნობის შემდეგ 
      პროგრამა გვკითხოს გვსურს თუ არა გაგრძელება, Yes ან No შეყვანით, 
      თანხმობის შემთხვევაში თავიდან შემოგვთავაზოს ახალი დიაპაზონის შეყვანას 
      და რიცხვის გამოცნობას, უარის შემთხვევაში კონსოლი დაიხუროს. */



Console.WriteLine("Please, Enter Min Number");
int minNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, Enter Max Number");
int maxNumber = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
var rnd = random.Next(minNumber, maxNumber);
int count = 1;

while (true)
{
    Console.WriteLine("Please,Enter your Number");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == rnd)
    {
        Console.WriteLine("You are Winner");
        Console.WriteLine("The number of your attempts:" + count);
        Console.WriteLine("Yes/No");
        string y = Console.ReadLine();
        if (y == "Yes")
        {
            Console.Clear();
            count = 0;
            Console.WriteLine("Please, Enter Min Number");
            minNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, Enter Max Number");
            maxNumber = Convert.ToInt32(Console.ReadLine());
            rnd = random.Next(minNumber, maxNumber);
        }
        else
        {
            break;
        }
    }
    else
    {
        count++;
    }
}