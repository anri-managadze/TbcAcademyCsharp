

//2. 
//string array 
Console.WriteLine("Please, Enter First Array size: ");
int N = Convert.ToInt32(Console.ReadLine());

string[] array = new string[N];
int i = 0;

while (i < N)
{
    Console.WriteLine("Please, Enter String: ");
    string input = Console.ReadLine();
    array[i] = input;
    Console.WriteLine("Entered string:" + array[i]);
    i++;
}
Console.Write("First array result: ");
foreach (string l in array)
{
    Console.Write(l + ",");
}

//int array 
Console.WriteLine("\n" + "Please, Enter Second Array size: ");
int N1 = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[N1];
int j = 0;

while (j < N1)
{
    Console.WriteLine("\n" + "Please, Enter Number: ");
    int input = int.Parse(Console.ReadLine());
    array1[j] = input;
    Console.WriteLine("Entered Number:" + array1[j]);
    j++;
}
Console.Write("Second array result: ");
foreach (int n in array1)
{
    Console.Write(n + ",");
}

//result array
string[] result = new string[array1.Length];

for (int k = 0; k < array1.Length; k++)
{
    result[k] = $"{array[k]} {array1[k]}";
}
Console.Write("\n"+"Result: ");
foreach (string item in result)
{
    Console.Write(item + ",");
}
