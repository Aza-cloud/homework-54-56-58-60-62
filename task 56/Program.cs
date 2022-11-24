// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
FillArray(array);
Console.WriteLine();


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

int SumElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int minSumRows = 0;
int sumLine = SumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temporarySumRows = SumElements(array, i);
  if (sumLine > temporarySumRows)
  {
    sumLine = temporarySumRows;
    minSumRows = i;
  }
}
Console.WriteLine($"Cтрокa с наименьшей суммой элементов: {minSumRows+1}");

