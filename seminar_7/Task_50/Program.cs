// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите искомый индекс строки массива -> ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомый индекс столбца массива -> ");
int columnIndex = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[3, 6];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
if ((rowIndex >= array.GetLength(0)) || 
   (columnIndex >= array.GetLength(1)) ||
   (rowIndex < 0) || (columnIndex < 0))
{
    Console.WriteLine($"Элемента [{rowIndex},{columnIndex}] в массиве нет");
}
else
{
    Console.WriteLine($"Значение элемента позиции [{rowIndex},{columnIndex}] = {array[rowIndex,columnIndex]}");
}