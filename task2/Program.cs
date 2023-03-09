// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[columns, rows];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
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

string SearchElementsArray(int[,] array, int rowsPositionElement, int columnsPositionElement)
{
    if (array.GetLength(0) < rowsPositionElement || array.GetLength(1) < columnsPositionElement)
    {
        return "Элемента на такой позиции нет";
    }
    else
    {
        return $"Значение элемента равно: {array[rowsPositionElement - 1, columnsPositionElement - 1]}";
    }
}

int[,] arr = GenerateArray(5, 4);
System.Console.Write("Введите номер столбца: ");
int columnsPositionElement = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите номер строки: ");
int rowsPositionElement = Convert.ToInt32(Console.ReadLine());

PrintArray(arr);
Console.WriteLine();
System.Console.WriteLine(SearchElementsArray(arr, rowsPositionElement, columnsPositionElement));
