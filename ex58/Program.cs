// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            array[m, n] = new Random().Next(0, 10);
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

void ProductOfMatrices(int[,] arr1, int[,] arr2, int[,] arr3)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                arr3[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
}

Console.Write("Количество строк первой матрицы: ");
int m = InputNumber();
Console.Write("Количество столбцов первой матрицы (строк второй матрицы): ");
int n = InputNumber();
Console.Write("Количество столбцов второй матрицы: ");
int k = InputNumber();

int[,] array1 = new int[m, n];
int[,] array2 = new int[n, k];
int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];

FillMatrix(array1);
FillMatrix(array2);
PrintMatrix(array1);
Console.WriteLine();
PrintMatrix(array2);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц:");
ProductOfMatrices(array1, array2, array3);
PrintMatrix(array3);