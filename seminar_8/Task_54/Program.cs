/*Задача 54.
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.*/
int[,] array = new int[3, 5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
     for (int j = 0; j < array.GetLength(1); j++)
     {
          for (int m = 0; m < array.GetLength(1) - 1; m++)
            {
              if(array[i, m] < array[i, m + 1])
              {
                int num = array[i, m + 1];
                array[i, m + 1] = array[i, m]; 
                array[i, m] = num; 
              }
            }
    }
}
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }