// Задача 47.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
Console.Write("Введите число строк массива -> ");
int numberString = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива -> ");
int numberColumn = Convert.ToInt32(Console.ReadLine());
 Random rmd = new Random();
double[,] array = new double[numberString, numberColumn];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Math.Round(rmd.NextDouble()*10,2);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
