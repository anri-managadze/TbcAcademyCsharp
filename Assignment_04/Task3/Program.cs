
//first array
Console.WriteLine("Enter first array Number: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
for (int i = 0; i < N; i++)
{
   int input = Convert.ToInt32(Console.ReadLine());
    array[i] = input;
}
Console.Write("First array result: ");
foreach (int number in array)
{
    Console.Write(number+ ",");
}

//second array
Console.WriteLine("\n"+"Enter Second array Number: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[M];
for (int i = 0; i < M; i++)
{
    int input = Convert.ToInt32(Console.ReadLine());
    array1[i] = input;
}
Console.Write("Second array result: ");
foreach (int number in array1)
{
    Console.Write(number + ",");
}

// Concatenate the arrays
var concatenatedArray = array.Concat(array1).ToArray();

Console.Write("\n"+ "Concatenate array result: ");
foreach (int number in concatenatedArray)
{
    Console.Write(number+ ",");
}

//ASC / DESC
Console.Write("\n"+ "Sort Array with asc or desc:");
string sort  = Console.ReadLine();
if (sort == "asc")
{
    Array.Sort(concatenatedArray);
    foreach (int number in concatenatedArray)
    {
        Console.Write(number + ",");
       
    }  
}else if(sort =="desc")
{
    Array.Sort(concatenatedArray);
    Array.Reverse(concatenatedArray);
    foreach (int number in concatenatedArray)
    {
        Console.Write(number + ",");
    }
}
else
{
    Console.WriteLine("Please, Enter asc or desc");
}