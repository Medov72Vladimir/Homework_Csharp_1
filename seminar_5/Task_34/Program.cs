// Задача 34.
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 

Console.WriteLine("Введи число равное длине массива ->");
var longArray = Convert.ToUInt32(Console.ReadLine());
int[] array = new int [longArray!];
Random rnd = new Random();
int count = 0;
Console.Write("Массив -> [ ");
for (int i = 0; i < longArray; i++)
{
    array[i] = rnd.Next(100, 999);
    Console.Write(array[i] + " " );
    int anEvenNumber = array[i] % 2;
    if (anEvenNumber == 0) count++;
}
Console.WriteLine("]"); 
Console.WriteLine($"Количество четных чисел массива -> {count}");