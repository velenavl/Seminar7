// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: А = m + n.
// Выведите полученный массив на экран.
Console.WriteLine("Введите количество строк");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
if (!isNumberM || m <= 0 || !isNumberN || n <= 0)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

int[,] FillArray(int m, int n)
{
  int[,] array = new int[m, n];

   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}

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

int[,] result = FillArray(m, n);
Print2DArray(result);
