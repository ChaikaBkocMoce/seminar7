// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GenerateArray(int rows, int columns)
{
    double[,] array = new double[columns, rows];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 10, 2);

        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

System.Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = GenerateArray(m, n);
Console.WriteLine();
PrintArray(arr);

