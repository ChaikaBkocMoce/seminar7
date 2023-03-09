// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[columns, rows];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void PrintTwoDimensionalIntArray(int[,] array)
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

void PrintOneDimensionalDoubleArray(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}   ");
    }
}

double[] AverageColumnsArray(int[,] array)
{
    double[] averageColumnsInArray = new double[array.GetLength(1)];
    int sumElemetsColum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sumElemetsColum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumElemetsColum += array[j, i];
        }
        averageColumnsInArray[i] = Math.Round(Convert.ToDouble(sumElemetsColum) / Convert.ToDouble(array.GetLength(0)), 2);
    }
    return averageColumnsInArray;
}


int[,] arr = GenerateArray(5, 3);
PrintTwoDimensionalIntArray(arr);
System.Console.WriteLine();
System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintOneDimensionalDoubleArray(AverageColumnsArray(arr));