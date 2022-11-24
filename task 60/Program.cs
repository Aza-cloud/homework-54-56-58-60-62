// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Clear();
Console.WriteLine("Задайте размерность трехмерного массива");
Console.Write("Введите первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[m, n, a];
FillArray(array);
PrintArray(array);

void FillArray(int[,,] array)
{
    int[] res = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int i = 0; i < res.GetLength(0); i++)
    {
        res[i] = new Random().Next(10, 100);
        number = res[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (res[i] == res[j])
                {
                    res[i] = new Random().Next(10, 100);
                    j = 0;
                    number = res[i];
                }
                number = res[i];
            }
        }
    }
    int count = 0;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int a = 0; a < array.GetLength(2); a++)
            {
                array[m, n, a] = res[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.Write($"{array[i, j, l]}({i},{j},{l}); ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}