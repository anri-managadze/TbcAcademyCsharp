Console.WriteLine("Please, Enter Array Size: ");
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
int maxLength = 0;
int startIndex = 0;
int currentLength = 1;
int currentStartIndex = 0;


for (int j = 1; j < array.Length; j++)
{
    if (array[j] > array[j - 1])
    {
        currentLength++;
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            startIndex = currentStartIndex;
        }
    }
    else
    {
        currentLength = 1;
        currentStartIndex = i;
    }
}

    
for (int k = startIndex; k < startIndex + maxLength; k++)
{
    Console.Write(array[k] + " ");
}
