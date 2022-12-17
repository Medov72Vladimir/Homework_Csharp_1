// Задача 41.
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введи число M -> ");
var numberM = Convert.ToUInt32(Console.ReadLine());
int[] array = new int [numberM!];
Random rnd = new Random();
int positivNumber = 0;
Console.Write("Сгенерированная последовательность чисел -> ( ");
for (int i = 0; i < numberM; i++)
{
    array[i] = rnd.Next(-999, 999);
    Console.Write(array[i] + " " );
    if (array[i] > 0) positivNumber++;
}
Console.WriteLine(")"); 
Console.WriteLine($"Количество положительных чисел -> {positivNumber}");
