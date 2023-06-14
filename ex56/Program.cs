// Задача 56:
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int FindMinSumOfElements(int[,] arr)
{
    int sum = 0;
    int minSum = 100;
    int minSumRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        Console.WriteLine($"{i} строка: {sum}");
        if (sum < minSum)
        {
            minSum = sum;
            minSumRow = i;
        }
        sum = 0;
    }
    return minSumRow;
}

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void FillMatrix(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(10, 50);
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
int[,] array = new int[m, n];

FillMatrix(array);
PrintMatrix(array);
Console.WriteLine();
Console.WriteLine($"{FindMinSumOfElements(array)} строка наименьшая");