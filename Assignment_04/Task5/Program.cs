

Console.WriteLine("Enter 2 or 3  ");
int M = Convert.ToInt32(Console.ReadLine());

if (M == 2)
{
    int[,] array = new int[2,2];
    for (int i = 0; i < M; i++)
    { for (int j = 0; j < M; j++)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            array[i,j] = input;
        }
    }
    Console.Write("array result: ");
    foreach (int number in array)
    {
        Console.Write(number + ",");
    }
    int d = (array[0, 0] * array[1, 1]) - (array[0, 1] * array[1,0]);
    Console.WriteLine("\n"+d);
}
else if (M == 3)    
{
    int[,] array = new int[3, 3];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < M; j++)
        {
                int input = Convert.ToInt32(Console.ReadLine());
                array[i, j ] = input;
        }
    }
    Console.Write("array result: ");
    foreach (int number in array)
    {
        Console.Write(number + ",");
    }
    int d = array[0, 0] * (array[1, 1] * array[2, 2] - array[1, 2] * array[2, 1]) -
                      array[0, 1] * (array[1, 0] * array[2, 2] - array[1, 2] * array[2, 0]) +
                      array[0, 2] * (array[1, 0] * array[2, 1] - array[1, 1] * array[2, 0]);
    Console.WriteLine("\n" + d);
}else
{
    Console.WriteLine("Please, Enter 2 or 3 !!!");
}