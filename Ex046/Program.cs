// Задайте двумерный массив размером mxn, заполненный случайными целыми числами

int[,] result = CreateRandomArray(3, 4);
Print2DArray(result);

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(0, 100);
        }
    }

    return array;

}
