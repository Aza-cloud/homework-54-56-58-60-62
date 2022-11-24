// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();
Console.Write("Задайте количество строк 1 двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Так как умножение матриц происходит путем i-ая строка матрицы A умножается на j-ый столбец матрицы B, то");
Console.Write("Задайте количество столбцов 1-ого двумерного массива и количество строк 2-ого двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов 2-ого двумерного массива:");
int a = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = new int[m, n];
Console.WriteLine($"матрица A:");
FillArray(firstArray);

Console.WriteLine();

int[,] secondArray = new int[n, a];
Console.WriteLine($"матрица B:");
FillArray(secondArray);

int[,] resArray = new int[m,a];
ResultArray(firstArray, secondArray, resArray);
Console.WriteLine($"\nПроизведение матриц A и B:");
PrintArray(resArray);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToInt32(new Random().Next(0, 15));
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t  ");
        Console.WriteLine();
    }
}

void ResultArray(int[,] firstArray, int[,] secondArray, int[,] resArray)
{
    for (int i = 0; i < resArray.GetLength(0); i++)
    {
        for (int j = 0; j < resArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum = sum + (firstArray[i, k] * secondArray[k, j]);
            }
            resArray[i, j] = sum;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t  ");
        Console.WriteLine();
    }
}