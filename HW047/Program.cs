// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк массива:");
bool isNumberLines = int.TryParse(Console.ReadLine(), out int lengthLine);
if (!isNumberLines || lengthLine <= 1)
{
    Console.WriteLine("Неверно!");
    return;
}
Console.WriteLine("Введите количество столбцов массива:");
bool isNumberRows = int.TryParse(Console.ReadLine(), out int lengthRow);
if (!isNumberRows || lengthRow <= 1)
{
    Console.WriteLine("Неверно!");
    return;
}
int m = lengthLine;
int n = lengthRow;
int[,] CreateRandomIntArray(int m, int n)
{
   int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 10);
        }
    }
    return array;
}
void Print2DIntArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}
int[,] arrayInt = CreateRandomIntArray(m, n);
Print2DIntArray(arrayInt);
