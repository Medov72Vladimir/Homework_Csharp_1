// Задача 36.
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введи число равное длине массива -> ");
var longArray = Convert.ToUInt32(Console.ReadLine());
int[] array = new int [longArray!];
Random rnd = new Random();
int sumNotEvenIndex = 0;
Console.Write("Массив -> [ ");
for (int i = 0; i < longArray; i++)
{
    array[i] = rnd.Next(-99, 99);
    Console.Write(array[i] + " " );
    if ( i % 2 > 0) sumNotEvenIndex += array[i];
}
Console.WriteLine("]"); 
Console.WriteLine($"Сумма элементов с нечетным индексом -> {sumNotEvenIndex}");
