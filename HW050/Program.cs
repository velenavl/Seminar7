// Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.

int[,] result = CreateRandomArray(3, 3);
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
            array[i,j] = random.Next(0, 10);
        }
    }

    return array;

}

Console.WriteLine("Найти число из массива:");
int findNumber = Convert.ToInt32(Console.ReadLine());
string FindArrayNumber(int[,] array, int number)
{
    string someString = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                someString = $"{i}, {j}";
            }
            else
            { 
                someString ="Такого элемента нет в массиве";
            }
        }
    }
    return someString;
}
string findArrayNumber = FindArrayNumber(result, findNumber);
Console.WriteLine(findArrayNumber);


