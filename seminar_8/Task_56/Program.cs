/*Задача 56.
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
строку с наименьшей суммой элементов и выдаёт
номер строки с наименьшей суммой элементов. Например: 1 строка*/
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
int sum0row = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
   sum0row += array[0, i];
}
int minNumberRow = 0; int sumRow = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
           if (sumRow < sum0row)
        {
            sum0row = sumRow;
            minNumberRow = i;
        }
        sumRow = 0;
    }
}
Console.Write($"{minNumberRow + 1} строка");
