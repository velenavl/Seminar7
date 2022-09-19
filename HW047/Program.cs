// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк в массиве:");
bool isNumberLines = int.TryParse(Console.ReadLine(), out int lengthLine);
if (!isNumberLines || lengthLine <= 1)
{
    Console.WriteLine("Неверно!");
    return;
}
Console.WriteLine("Введите количество столбиков в массиве:");
bool isNumberRows = int.TryParse(Console.ReadLine(), out int lengthRow);
if (!isNumberRows || lengthRow <= 1)
{
    Console.WriteLine("Неверно!");
    return;
}
int m = lengthLine;
int n = lengthRow;
double[,] arrayDouble = new double[m,n];
void CreateRandomDoubleArray(int m, int n)
{  
    Random random = new Random();
    for (int i = 0; i < arrayDouble.GetLength(0); i++) 
    {
        for (int j = 0; j < arrayDouble.GetLength(1); j++) 
        {
            arrayDouble[i, j] = Convert.ToDouble(random.Next(-100, 100))/10; 
        }
    }
}
void Print2DDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]}");
        }
        Console.WriteLine();
    }
}
CreateRandomDoubleArray(m,n);
Print2DDoubleArray(arrayDouble);

