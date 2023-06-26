/*1.  დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქცია, რომელიც პირველ პარამეტრად იღებს 
     მთელი რიცხვების მასივს, მეორე პარამეტრად იღებს მთელ რიცხვს (index), 
     ფუნქციამ უნდა დაითვალოს იმ ელემენტის ციფრების ჯამი, რომლის ინდექსი არის მეორე პარამეტრი. 
     მაგალითად: თუ ინდექს 2-ზე წერია ელემენტი 123 ფუნქციამ უნდა დააბრუნოს 6. */


int calcIndexSum(int[] array, int index)
{
    int sum = 0;
    string convertNumbertoString = array[index].ToString();
    char[] charArray = convertNumbertoString.ToCharArray();
    int[] intArray = convertNumbertoString.Select(c => (int)(c - '0')).ToArray();

    for (int i = 0; i < convertNumbertoString.Length; i++)
    {
        charArray[i] = convertNumbertoString[i];  
    }

    foreach (int s in intArray)
    {
        sum += s;
    }
    //Console.WriteLine(sum);
    return sum;
}

int result = calcIndexSum(new int[] { 1, 2, 123, 555, }, 2);

//Console.WriteLine("Number Sum is: " + result);
Console.ReadKey();
