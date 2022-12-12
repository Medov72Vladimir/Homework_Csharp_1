// Задача 29
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите число, равное длине массива -> ");
var longArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[longArray!];
Random rnd = new Random();
Console.Write("[");
for (int i = 0; i < longArray; i++)
{
    array[i] = rnd.Next(1, 99);
    Console.Write(array[i] + " " );
}
Console.Write("]");