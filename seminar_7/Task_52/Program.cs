// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("Введите число строк массива -> ");
int numberString = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива -> ");
int numberColumn = Convert.ToInt32(Console.ReadLine());
Random rmd = new Random();
//int result = 0;
int[,] array = new int[numberString, numberColumn];
for (int i = 0; i < array.GetLength(0); i++) // строки
{
    for (int j = 0; j < array.GetLength(1); j++) // столбцы
    {
        array[i,j] = rmd.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
for (int j = 0; j < array.GetLength(1); j++) // столбцы
{
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++) // строки
    {
        result += array[i, j];
    }
   Console.WriteLine($"Среднее арифметическое столбца {j} = {Math.Round(result /= array.GetLength(0),1)}"); 
}
