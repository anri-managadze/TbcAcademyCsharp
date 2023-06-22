
//1.
Console.WriteLine("Please, Enter Array size: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int i = 0;

while (i < N)
{
    int input = int.Parse(Console.ReadLine());
    array[i] = input;
    Console.WriteLine("Entered Number:" + array[i]);
    i++;
}
bool swapped = true;
int l = array.Length;

while (swapped)
{
    swapped = false;
    for (int k = 1; k < l; k++)
    {
        if (array[k - 1] > array[k])
        {
            int temp = array[k - 1];
            array[k - 1] = array[k];
            array[k] = temp;
            swapped = true;
        }
    }
    l--;
}
Console.Write("Result: ");
foreach (int number in array)
{
    Console.Write(number);
}
