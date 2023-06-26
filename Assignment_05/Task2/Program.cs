/*2.  დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქცია, რომელიც მომხმარებელს მოსთხოვს შეიყვანოს 
     მასივის ზომა და შემდეგ შეავსებინებს მასივის ელემენტებს კონსოლიდან,მასივი უნდა იყოს char-ების, 
     ფუნქციამ უნდა დააბრუნოს მომხმარებლის მიერ შევსებული მასივი.
      დაწერე მეორე ფუნქცია, რომელიც პირველი ფუნქციის დახმარებით პარამეტრად მიიღებს უკვე შევსებულ 
     მასივს და სიმბოლოს, თუ ასეთი სიმბოლო მოიძებნა პარამეტრად გადმოცემულ მასივში მაშინ ფუნქციამ 
     უნდა დააბრუნოს ის რიცხვი თუ რამდენჯერაც შეგვხდება მასივში გადმოცემული სიმბოლო.
     მაგალითად: თუ 'a' არის მასივში 2 ჯერ, უნდა დააბრუნოს 2. 
      დაწერეთ მესამე ფუნქცია, რომელიც დაბეჭდავს მიღებულ შედეგებს, სიმბოლო 'a' shegvxda 2 jer ასეთი სახით.*/



Console.WriteLine("Please, Enter Array size: ");
int N = Convert.ToInt32(Console.ReadLine());
string input="";
char[] addArray(string input = "", int size=0)
{ 
    string[] array = new string[size];
    int i = 0;
        while (i < size)
        {
            input = Console.ReadLine();
            array[i] = input;
            Console.WriteLine("Entered Number:" + array[i]);
            i++;
        }
    char[] charArray = array.SelectMany(str => str.ToCharArray()).ToArray();
    Console.WriteLine(charArray);
    searchArray(charArray);
    return charArray;
}
//Console.WriteLine(addArray(input, N));

int searchArray(char[] array)
{
    int count = 0;
    Console.WriteLine("add symbol");
    char symbol = Convert.ToChar(Console.ReadLine());
    for (int i = 0; i < array.Length; i++)
    {
        if (symbol == array[i])
        {
            count++;
        }
    }
    Console.WriteLine("count:" + count);
    result(count,symbol);
    return count;
}
addArray(input, N);

string result (int count, char symbol)
{

    string g="symbol: " + symbol + " gamoyenebulia " + count + "-jer";
    Console.WriteLine(g);
    return g;
}