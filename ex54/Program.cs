// Задача 54:
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void SortInDescendingOrder(int[,] arr)
{
    // int min = 0;
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < arr[i, j + 1])
            {
                temp = arr[i, j];
                arr[i, j] = arr[i, j + 1];
                arr[i, j + 1] = temp;
            }
        }
    }
}

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void FillMatrix(int[,] array, int num)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(0, num + 1);
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Количество строк: ");
int m = InputNumber();
Console.Write("Количество столбцов: ");
int n = InputNumber();
Console.Write("Максимальное число в частотном словаре (и соответственно в самом массиве): ");
int maxNum = InputNumber();
int[,] array = new int[m, n];

FillMatrix(array, maxNum);
PrintMatrix(array);
Console.WriteLine();
SortInDescendingOrder(array);
PrintMatrix(array);